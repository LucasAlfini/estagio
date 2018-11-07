namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conta_Pagar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conta_Pagar()
        {
            Movimentacao_Financeira = new HashSet<Movimentacao_Financeira>();
        }

        [Key]
        public int ID_Conta_Pagar { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        public DateTime Vencimento { get; set; }

        public double Valor { get; set; }

        public DateTime Dt_Pagamento { get; set; }

        public double Valor_Pagamento { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        public int ID_Tipo_Despesa { get; set; }

        public int ID_Origem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimentacao_Financeira> Movimentacao_Financeira { get; set; }

        public virtual Tipo_Despesa Tipo_Despesa { get; set; }
    }
}
