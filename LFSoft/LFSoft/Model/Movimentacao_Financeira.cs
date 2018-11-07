namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movimentacao_Financeira
    {
        [Key]
        public int ID_Movimentacao { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        [Required]
        [StringLength(100)]
        public string Finalidade { get; set; }

        public int ID_Conta { get; set; }

        public int ID_Conta_Receber { get; set; }

        public int ID_Conta_Pagar { get; set; }

        public virtual Conta_Bancaria Conta_Bancaria { get; set; }

        public virtual Conta_Pagar Conta_Pagar { get; set; }

        public virtual Conta_Receber Conta_Receber { get; set; }
    }
}
