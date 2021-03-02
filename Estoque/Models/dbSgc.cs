namespace Estoque.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbSgc : DbContext
    {
        public dbSgc()
            : base("name=dbSgc")
        {
        }

        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<login> login { get; set; }
        public virtual DbSet<orcamentos> orcamentos { get; set; }
        public virtual DbSet<pecas> pecas { get; set; }
        public virtual DbSet<pecas_vendidas> pecas_vendidas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cliente>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.NUMERO_CASA)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.ADICIONAIS)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.pecas)
                .WithOptional(e => e.cliente)
                .HasForeignKey(e => e.IDCLIENTE);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.orcamentos)
                .WithOptional(e => e.cliente)
                .HasForeignKey(e => e.IDCLIENTE);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.pecas_vendidas)
                .WithOptional(e => e.cliente)
                .HasForeignKey(e => e.IDCLIENTE);

            modelBuilder.Entity<login>()
                .Property(e => e.LOGIN1)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.PERMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.F_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.DATA_CRIACAO)
                .IsUnicode(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.DATA_ALT)
                .IsUnicode(false);

            modelBuilder.Entity<pecas>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<pecas>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<pecas>()
                .Property(e => e.PRATELEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<pecas>()
                .Property(e => e.PRECO)
                .IsUnicode(false);

            modelBuilder.Entity<pecas>()
                .Property(e => e.PE_SVO)
                .IsUnicode(false);

            modelBuilder.Entity<pecas_vendidas>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<pecas_vendidas>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<pecas_vendidas>()
                .Property(e => e.PRECO)
                .IsUnicode(false);
        }
    }
}
