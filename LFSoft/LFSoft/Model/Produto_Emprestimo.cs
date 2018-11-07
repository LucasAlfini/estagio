namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Produto_Emprestimo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Emprestimo { get; set; }

        public int ID_Produto { get; set; }

        public int Qtde { get; set; }

        public double Valor_Unitario { get; set; }

        public virtual Emprestimo Emprestimo { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
