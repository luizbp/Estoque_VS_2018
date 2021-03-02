namespace Estoque.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbpecas.pecas")]
    public partial class pecas
    {
        public int ID { get; set; }

        public int? CODIGO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string TIPO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PRATELEIRA { get; set; }

        public int? QTDE { get; set; }

        [StringLength(50)]
        public string PRECO { get; set; }

        public int? IDCLIENTE { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string PE_SVO { get; set; }

        public virtual cliente cliente { get; set; }
    }
}
