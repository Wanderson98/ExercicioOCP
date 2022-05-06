using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
