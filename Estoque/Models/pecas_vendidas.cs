namespace Estoque.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbpecas.pecas_vendidas")]
    public partial class pecas_vendidas
    {
        public int ID { get; set; }

        public int? CODIGO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string TIPO { get; set; }

        public int? QTDE { get; set; }

        [StringLength(50)]
        public string PRECO { get; set; }

        public int? IDCLIENTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENDA { get; set; }

        public virtual cliente cliente { get; set; }
    }
}
