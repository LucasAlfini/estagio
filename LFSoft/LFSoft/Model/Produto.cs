namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produto")]
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            Itens_Compra = new HashSet<Itens_Compra>();
            Produto_Emprestimo = new HashSet<Produto_Emprestimo>();
        }

        [Key]
        public int ID_Produto { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        public int ID_UC { get; set; }

        public int ID_Categoria { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Estoque Estoque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Itens_Compra> Itens_Compra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto_Emprestimo> Produto_Emprestimo { get; set; }

        public virtual Unidade_Comercial Unidade_Comercial { get; set; }
    }
}
