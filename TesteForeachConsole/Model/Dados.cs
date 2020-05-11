namespace TesteForeachConsole.Model
{
    internal class Dados
    {
        public Dados(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        private string Nome { get; set; }

        private string Email { get; set; }

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome}, {nameof(Email)}: {Email}";
        }
    }
}