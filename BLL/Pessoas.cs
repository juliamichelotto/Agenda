namespace BLL_
{
    public class Pessoas
    {
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Nome} {Telefone}";
        }

    }
}