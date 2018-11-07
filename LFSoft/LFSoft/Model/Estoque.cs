namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estoque")]
    public partial class Estoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Produto { get; set; }

        public DateTime Data { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public int Qtde { get; set; }

        public int Destino { get; set; }

        public virtual Destino_Produto Destino_Produto { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
