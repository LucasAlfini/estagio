namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contribuicao")]
    public partial class Contribuicao
    {
        [Key]
        public int ID_Contribuicao { get; set; }

        public DateTime Data_Contribuicao { get; set; }

        public double Valor_Contribuicao { get; set; }

        public int ID_Internacao { get; set; }

        public virtual Internacao Internacao { get; set; }
    }
}
