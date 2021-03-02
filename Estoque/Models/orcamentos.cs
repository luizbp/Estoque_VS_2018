namespace Estoque.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbpecas.orcamentos")]
    public partial class orcamentos
    {
        public int ID { get; set; }

        public int? IDCLIENTE { get; set; }

        [StringLength(300)]
        public string VALOR { get; set; }

        [StringLength(1000)]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string F_STATUS { get; set; }

        [StringLength(45)]
        public string PRODUTO { get; set; }

        [StringLength(45)]
        public string DATA_CRIACAO { get; set; }

        [StringLength(45)]
        public string DATA_ALT { get; set; }

        public virtual cliente cliente { get; set; }
    }
}
