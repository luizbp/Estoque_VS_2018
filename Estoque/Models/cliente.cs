namespace Estoque.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbpecas.cliente")]
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            pecas = new HashSet<pecas>();
            orcamentos = new HashSet<orcamentos>();
            pecas_vendidas = new HashSet<pecas_vendidas>();
        }

        public int ID { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string NOME { get; set; }

        [StringLength(30)]
        public string CPF { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string CIDADE { get; set; }

        [StringLength(50)]
        public string ENDERECO { get; set; }

        [StringLength(30)]
        public string NUMERO_CASA { get; set; }

        [StringLength(20)]
        public string TELEFONE { get; set; }

        [StringLength(20)]
        public string CELULAR { get; set; }

        [StringLength(1000)]
        public string ADICIONAIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pecas> pecas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orcamentos> orcamentos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pecas_vendidas> pecas_vendidas { get; set; }
    }
}
