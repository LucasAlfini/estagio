namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Procedimento")]
    public partial class Procedimento
    {
        [Key]
        public int ID_Procedimento { get; set; }

        [Required]
        [StringLength(1000)]
        public string Descricao { get; set; }

        public int ID_Internacao { get; set; }

        public int ID_Funcionario { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        public virtual Internacao Internacao { get; set; }
    }
}
