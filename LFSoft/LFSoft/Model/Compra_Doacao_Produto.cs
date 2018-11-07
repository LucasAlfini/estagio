namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Compra_Doacao_Produto
    {
        [Key]
        public int ID_Compra { get; set; }

        public int ID_Fornecedor { get; set; }

        public double Valor_Total { get; set; }

        public DateTime Data_Compra { get; set; }

        public DateTime Data_Pagamento { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        public virtual Itens_Compra Itens_Compra { get; set; }

        public virtual Fonecedor Fonecedor { get; set; }
    }
}
