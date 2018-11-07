namespace LFSoft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doacao_Financeira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doacao_Financeira()
        {
            Conta_Receber = new HashSet<Conta_Receber>();
        }

        [Key]
        public int ID_Doacao { get; set; }

        public DateTime Data_Doacao { get; set; }

        public double Valor_Doacao { get; set; }

        public int ID_Doador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conta_Receber> Conta_Receber { get; set; }

        public virtual Doador Doador { get; set; }
    }
}
