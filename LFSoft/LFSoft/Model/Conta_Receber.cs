namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conta_Receber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conta_Receber()
        {
            Movimentacao_Financeira = new HashSet<Movimentacao_Financeira>();
        }

        [Key]
        public int ID_Conta_Receber { get; set; }

        public double Valor_Previsao { get; set; }

        public double Valor_Recebido { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        public DateTime DT_Previsao { get; set; }

        public double Valor { get; set; }

        public DateTime DT_Efetivacao { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public int ID_Origem { get; set; }

        public int ID_Doacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimentacao_Financeira> Movimentacao_Financeira { get; set; }

        public virtual Doacao_Financeira Doacao_Financeira { get; set; }
    }
}
