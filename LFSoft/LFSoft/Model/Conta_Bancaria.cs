namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conta_Bancaria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conta_Bancaria()
        {
            Movimentacao_Financeira = new HashSet<Movimentacao_Financeira>();
        }

        [Key]
        public int ID_Conta { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        [Required]
        [StringLength(20)]
        public string Agencia { get; set; }

        [Required]
        [StringLength(20)]
        public string Conta { get; set; }

        [Required]
        [StringLength(20)]
        public string Banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimentacao_Financeira> Movimentacao_Financeira { get; set; }
    }
}
