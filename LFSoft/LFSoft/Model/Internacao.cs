namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Internacao")]
    public partial class Internacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Internacao()
        {
            Conta_Paciente = new HashSet<Conta_Paciente>();
            Contribuicao = new HashSet<Contribuicao>();
            Procedimento = new HashSet<Procedimento>();
            Visitas = new HashSet<Visitas>();
        }

        [Key]
        public int ID_Internacao { get; set; }

        public DateTime DT_Internacao { get; set; }

        public DateTime DT_Alta { get; set; }

        public int ID_Responsavel { get; set; }

        public int ID_Paciente { get; set; }

        public int ID_Funcionario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conta_Paciente> Conta_Paciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contribuicao> Contribuicao { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimento> Procedimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitas> Visitas { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Responsavel Responsavel { get; set; }
    }
}
