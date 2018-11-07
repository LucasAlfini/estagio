namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Locatario")]
    public partial class Locatario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locatario()
        {
            Emprestimo = new HashSet<Emprestimo>();
        }

        [Key]
        public int ID_Locatario { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefone_Fixo { get; set; }

        [Required]
        [StringLength(11)]
        public string Telefone_Celular { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprestimo> Emprestimo { get; set; }

        public void insere()
        {
            var contexto = new Contexto();
            contexto.Locatario
        }
    }
}
