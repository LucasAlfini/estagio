namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conta_Paciente
    {
        [Key]
        public int ID_Transacao { get; set; }

        public DateTime DT_Movimentacao { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo_Movimentacao { get; set; }

        public double Valor { get; set; }

        public int ID_Internacao { get; set; }

        public virtual Internacao Internacao { get; set; }
    }
}
