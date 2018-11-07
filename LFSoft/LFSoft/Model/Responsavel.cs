namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Responsavel")]
    public partial class Responsavel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Responsavel()
        {
            Internacao = new HashSet<Internacao>();
        }

        [Key]
        public int ID_Responsavel { get; set; }

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

        [Required]
        [StringLength(10)]
        public string Tel_Fixo { get; set; }

        [Required]
        [StringLength(11)]
        public string Tel_Celular { get; set; }

        [Required]
        [StringLength(11)]
        public string Tel_Recado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Internacao> Internacao { get; set; }
    }
}
