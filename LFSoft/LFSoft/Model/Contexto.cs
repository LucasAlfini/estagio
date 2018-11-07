namespace LFSoft.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Compra_Doacao_Produto> Compra_Doacao_Produto { get; set; }
        public virtual DbSet<Conta_Bancaria> Conta_Bancaria { get; set; }
        public virtual DbSet<Conta_Paciente> Conta_Paciente { get; set; }
        public virtual DbSet<Conta_Pagar> Conta_Pagar { get; set; }
        public virtual DbSet<Conta_Receber> Conta_Receber { get; set; }
        public virtual DbSet<Contribuicao> Contribuicao { get; set; }
        public virtual DbSet<Destino_Produto> Destino_Produto { get; set; }
        public virtual DbSet<Doacao_Financeira> Doacao_Financeira { get; set; }
        public virtual DbSet<Doador> Doador { get; set; }
        public virtual DbSet<Emprestimo> Emprestimo { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<Fonecedor> Fonecedor { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Internacao> Internacao { get; set; }
        public virtual DbSet<Itens_Compra> Itens_Compra { get; set; }
        public virtual DbSet<Locatario> Locatario { get; set; }
        public virtual DbSet<Movimentacao_Financeira> Movimentacao_Financeira { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Procedimento> Procedimento { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Produto_Emprestimo> Produto_Emprestimo { get; set; }
        public virtual DbSet<Responsavel> Responsavel { get; set; }
        public virtual DbSet<Tipo_Despesa> Tipo_Despesa { get; set; }
        public virtual DbSet<Unidade_Comercial> Unidade_Comercial { get; set; }
        public virtual DbSet<Visitante> Visitante { get; set; }
        public virtual DbSet<Visitas> Visitas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>()
                .Property(e => e.Cargo1)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Funcionario)
                .WithRequired(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .Property(e => e.Categoria1)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Produto)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Compra_Doacao_Produto>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Compra_Doacao_Produto>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Compra_Doacao_Produto>()
                .HasOptional(e => e.Itens_Compra)
                .WithRequired(e => e.Compra_Doacao_Produto);

            modelBuilder.Entity<Conta_Bancaria>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Bancaria>()
                .Property(e => e.Agencia)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Bancaria>()
                .Property(e => e.Conta)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Bancaria>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Bancaria>()
                .HasMany(e => e.Movimentacao_Financeira)
                .WithRequired(e => e.Conta_Bancaria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta_Paciente>()
                .Property(e => e.Tipo_Movimentacao)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Pagar>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Pagar>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Pagar>()
                .HasMany(e => e.Movimentacao_Financeira)
                .WithRequired(e => e.Conta_Pagar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta_Receber>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Receber>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Conta_Receber>()
                .HasMany(e => e.Movimentacao_Financeira)
                .WithRequired(e => e.Conta_Receber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Destino_Produto>()
                .Property(e => e.Setor)
                .IsUnicode(false);

            modelBuilder.Entity<Doacao_Financeira>()
                .HasMany(e => e.Conta_Receber)
                .WithRequired(e => e.Doacao_Financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doador>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Doador>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Doador>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Doador>()
                .Property(e => e.Endereo)
                .IsUnicode(false);

            modelBuilder.Entity<Doador>()
                .HasMany(e => e.Doacao_Financeira)
                .WithRequired(e => e.Doador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Emprestimo>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Emprestimo>()
                .HasOptional(e => e.Produto_Emprestimo)
                .WithRequired(e => e.Emprestimo);

            modelBuilder.Entity<Estoque>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Estoque>()
                .HasOptional(e => e.Destino_Produto)
                .WithRequired(e => e.Estoque);

            modelBuilder.Entity<Fonecedor>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Fonecedor>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Fonecedor>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Fonecedor>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Fonecedor>()
                .Property(e => e.Representante)
                .IsUnicode(false);

            modelBuilder.Entity<Fonecedor>()
                .HasMany(e => e.Compra_Doacao_Produto)
                .WithRequired(e => e.Fonecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Tel_Fixo)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Tel_Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.Internacao)
                .WithRequired(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.Procedimento)
                .WithRequired(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Internacao>()
                .HasMany(e => e.Conta_Paciente)
                .WithRequired(e => e.Internacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Internacao>()
                .HasMany(e => e.Contribuicao)
                .WithRequired(e => e.Internacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Internacao>()
                .HasMany(e => e.Procedimento)
                .WithRequired(e => e.Internacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Internacao>()
                .HasMany(e => e.Visitas)
                .WithRequired(e => e.Internacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locatario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Locatario>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Locatario>()
                .Property(e => e.Telefone_Fixo)
                .IsUnicode(false);

            modelBuilder.Entity<Locatario>()
                .Property(e => e.Telefone_Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Locatario>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Locatario>()
                .HasMany(e => e.Emprestimo)
                .WithRequired(e => e.Locatario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movimentacao_Financeira>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Movimentacao_Financeira>()
                .Property(e => e.Finalidade)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .HasMany(e => e.Internacao)
                .WithRequired(e => e.Paciente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Procedimento>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .HasOptional(e => e.Estoque)
                .WithRequired(e => e.Produto);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.Itens_Compra)
                .WithRequired(e => e.Produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.Produto_Emprestimo)
                .WithRequired(e => e.Produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Responsavel>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Responsavel>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Responsavel>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<Responsavel>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Responsavel>()
                .Property(e => e.Tel_Fixo)
                .IsUnicode(false);

            modelBuilder.Entity<Responsavel>()
                .Property(e => e.Tel_Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Responsavel>()
                .Property(e => e.Tel_Recado)
                .IsUnicode(false);

            modelBuilder.Entity<Responsavel>()
                .HasMany(e => e.Internacao)
                .WithRequired(e => e.Responsavel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_Despesa>()
                .Property(e => e.Tipo_Despesa1)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Despesa>()
                .HasMany(e => e.Conta_Pagar)
                .WithRequired(e => e.Tipo_Despesa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unidade_Comercial>()
                .Property(e => e.Unid_Comercial)
                .IsUnicode(false);

            modelBuilder.Entity<Unidade_Comercial>()
                .HasMany(e => e.Produto)
                .WithRequired(e => e.Unidade_Comercial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Visitante>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Visitante>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Visitante>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Visitante>()
                .HasMany(e => e.Visitas)
                .WithRequired(e => e.Visitante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Visitas>()
                .Property(e => e.Observacaoes)
                .IsUnicode(false);
        }
    }
}
