namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tipo_Despesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Despesa()
        {
            Conta_Pagar = new HashSet<Conta_Pagar>();
        }

        [Key]
        public int ID_Tipo_Despesa { get; set; }

        [Column("Tipo_Despesa")]
        [Required]
        [StringLength(100)]
        public string Tipo_Despesa1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conta_Pagar> Conta_Pagar { get; set; }
    }
}
