using BibliotecaOCP.Enums;

namespace BibliotecaOCP.Pessoas
{
    public class ModeloCandidato
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }

        public FuncaoEmpregado FuncaoEmpregado { get; set; } = FuncaoEmpregado.Estagiário;
    }
}
