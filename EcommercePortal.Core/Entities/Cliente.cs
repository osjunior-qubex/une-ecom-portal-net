namespace EcommercePortal.Core.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string NumeroContrato { get; set; }
        public string NumeroCentroCusto { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string CorTema { get; set; } // Para personalização de tema
        public string LogoUrl { get; set; } // URL da logo do cliente
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
