namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visitas
    {
        [Key]
        public int ID_Visita { get; set; }

        public DateTime Data_Visita { get; set; }

        [Required]
        [StringLength(1000)]
        public string Observacaoes { get; set; }

        public int ID_Internacao { get; set; }

        public int ID_Visitante { get; set; }

        public virtual Internacao Internacao { get; set; }

        public virtual Visitante Visitante { get; set; }
    }
}
