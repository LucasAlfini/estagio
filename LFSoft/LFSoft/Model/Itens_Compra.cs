namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Itens_Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Compra { get; set; }

        public int Quantidade { get; set; }

        public double Valor_Unitario { get; set; }

        public double Valor_Total { get; set; }

        public int ID_Produto { get; set; }

        public virtual Compra_Doacao_Produto Compra_Doacao_Produto { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
