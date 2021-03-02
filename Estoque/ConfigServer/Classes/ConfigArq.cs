using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Configuration.Internal;

namespace Estoque.ConfigServer.Classes
{
    public class ConfigArq
    {
        private static string strPathFile = @"C:\Users\Public\Documents\";
        private static string fileName = "SysEstoque.ini";

        private static string _chave = "SPSQOqBs9mz7ecsXIhrv6CTcjBHQadUzUi0s5KViFtI";

        private static bool _valida = false;

        public static string Chave { get { return _chave; } }

        public static bool Valida { get { return _valida; } }

        public static string StrPathFile { get { return strPathFile + fileName; } }

        public static bool verifConfig()
        {
            if (!File.Exists(strPathFile + fileName))
            {
                ConfigServer config = new ConfigServer();
                config.ShowDialog();
                if (File.Exists(strPathFile + fileName))
                {
                    altAppConfig();
                    return true;
                }
                else return false;
            }
            else
            {
                if (altAppConfig())
                    return true;
                else return false;
            }
        }

        public static void Criar(string ipServ, string porta, string userDb, string pwdDb, string nomeDb)
        {
            //Verificas se o diretório existe
            if (!Directory.Exists(strPathFile))
            {
                //Cria um com o nome folder
                Directory.CreateDirectory(strPathFile);
            }

            //Verifica se o arquivo existe, caso exista deleta para poder
            //criar um novo com os valores atualizados
            if (File.Exists(strPathFile + fileName))
            {
                if (MessageBox.Show("O arquivo já existe. Deseja alterar seus valores?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    File.Delete(strPathFile + fileName);
                    CriarArq(ipServ, porta, userDb, pwdDb, nomeDb);
                    altAppConfig();
                    _valida = true;
                }
                else _valida = false;
            }
            else
            {
                CriarArq(ipServ, porta, userDb, pwdDb, nomeDb);
                altAppConfig();
                _valida = true;
            }
        }

        private static void CriarArq(string ipServ, string porta, string userDb, string pwdDb, string nomeDb)
        {
            try
            {
                //Usarei a cláusula using como boas práticas de programação em todos os métodos
                //Instancio a classe FileStream, uso a classe File e o método Create para criar o
                //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo
                using (FileStream fs = File.Create(strPathFile + fileName))
                {
                    //Atribuo o aquivo como oculto
                    FileInfo arquivo = new FileInfo(strPathFile + fileName);
                    arquivo.Attributes = FileAttributes.Hidden;

                    //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)
                    //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Uso o método Write para escrever o ip do servidor em nosso arquivo de texto
                        sw.WriteLine("IP Servidor|" + ipServ);
                        sw.WriteLine("Porta|" + porta);
                        sw.WriteLine("Usuario Db|" + Criptografar.Cript(userDb));
                        sw.WriteLine("Senha Db|" + Criptografar.Cript(pwdDb));
                        sw.WriteLine("Nome Db|" + Criptografar.Cript(nomeDb));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException == null ? "" : ex.InnerException.Message);
            }
        }

        /// <summary>
        /// Tipo 0 - server; port; user id; pwd; persistsecurityinfo=True; database;
        /// 
        /// Tipo 1 - server; port; user id; pwd=; persistsecurityinfo=True;
        /// 
        /// Tipo 3 - server, porta; user id; pwd; persistsecurityinfo=True; database;
        /// 
        /// </summary>
        /// <param name="stringConexao"></param>
        /// <returns></returns>
        public static string stringConexao(int tipo)
        {
            if (File.Exists(StrPathFile))
            {
                return getStringConexao(tipo);
            }
            else
            {
                ConfigServer newConfig = new ConfigServer();
                newConfig.ShowDialog();
                if (!newConfig.Enabled)
                    return getStringConexao(tipo);
                else return "";
            }
        }

        private static string getStringConexao(int tipo)
        {
            string ip = "", user = "", pwd = "", nomeDb = "", porta = "";

            try
            {
                string[] array = File.ReadAllLines(@StrPathFile);
                int i = 0;

                //percorro o array e para cada linha
                while (i < array.Length)
                {
                    string[] auxiliar = array[i].Split('|');

                    switch (i)
                    {
                        case 0:
                            ip = auxiliar[1];
                            break;
                        case 1:
                            porta = auxiliar[1];
                            break;
                        case 2:
                            user = Descriptografar.Descript(auxiliar[1]);
                            break;
                        case 3:
                            pwd = Descriptografar.Descript(auxiliar[1]);
                            break;
                        case 4:
                            nomeDb = Descriptografar.Descript(auxiliar[1]);
                            break;
                    }
                    i++;
                }
                string conexao = tipo == 1
                    ? "server=" + ip + "; port= " + porta + "; user id=" + user + "; pwd=" + pwd + "; persistsecurityinfo=True; database=" + nomeDb
                    : "server=" + ip + "; port= " + porta + "; user id=" + user + "; pwd=" + pwd + "; persistsecurityinfo=True;";
                if (tipo == 3)
                    conexao = "server=" + ip + ", " + porta + "; user id=" + user + "; pwd=" + pwd + "; persistsecurityinfo=True; database=" + nomeDb;
                return conexao;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível ler o arquivo de configuração.\nPor favor entre em contato com o Administrador do Sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static bool altAppConfig()
        {
            try
            {
                ConnectionStringSettings conSetting = new ConnectionStringSettings();

                conSetting.ConnectionString = stringConexao(1);
                conSetting.Name = "dbSgc";
                conSetting.ProviderName = "MySql.Data.MySqlClient";
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConnectionStringsSection conSettings = (ConnectionStringsSection)config.GetSection("connectionStrings");
                conSettings.ConnectionStrings.Remove(conSetting);
                conSettings.ConnectionStrings.Add(conSetting);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsConnected()
        {
            bool fail;

            System.Uri Url = new System.Uri("http://www.google.com"); //é sempre bom por um site que costuma estar sempre on, para n haver problemas

            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);

            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                fail = true; //consegue conexão à internet
                return fail;
            }

            catch
            {
                WebReq = null;
                fail = false; //falhou a conexão à internet
                return fail;
            }
        }
    }
}
