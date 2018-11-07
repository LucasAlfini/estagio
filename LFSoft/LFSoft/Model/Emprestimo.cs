namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Emprestimo")]
    public partial class Emprestimo
    {
        [Key]
        public int ID_Emprestimo { get; set; }

        public DateTime Data_Emprestimo { get; set; }

        public DateTime Data_Devolucao { get; set; }

        public int ID_Locatario { get; set; }

        public double Valor_Locacao { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        public virtual Produto_Emprestimo Produto_Emprestimo { get; set; }

        public virtual Locatario Locatario { get; set; }
    }
}
