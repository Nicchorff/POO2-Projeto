namespace Entities
{
    public class User
    {
        public string FullName { get; set; }

        public double Cpf { get; set; }

        public string Email { get; set; }

        public string DataDeNascimento { get; set; }

        public string OrgaoExpedidor { get; set; }

        public string Naturalidade { get; set; }

        public string NomePai { get; set; }

        public string NomeMae { get; set; }

        public string Emprego { get; set; }

        public double Celular { get; set; }

        public string CEP { get; set; }

        public ABO TipoSanguineo { get; set; }

        public bool IsPositivo {  get; set; }

        public string Sexo { get; set; }

        public string Endereco { get; set;}
    }
}
