namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Destino_Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Produto { get; set; }

        [Required]
        [StringLength(100)]
        public string Setor { get; set; }

        public virtual Estoque Estoque { get; set; }
    }
}
