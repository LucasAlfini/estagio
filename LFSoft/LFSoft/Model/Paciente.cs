namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paciente")]
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            Internacao = new HashSet<Internacao>();
        }

        [Key]
        public int ID_Paciente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(9)]
        public string RG { get; set; }

        public DateTime DT_Nasc { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        public int ID_Estado { get; set; }

        public int ID_Cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Internacao> Internacao { get; set; }
    }
}
