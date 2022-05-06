using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOCP.Pessoas
{
    public class ModeloEmpregado
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string EnderecoEmail { get; set; }
        public bool Gerente { get; set; }
        public bool Executivo { get; set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {UltimoNome}: {EnderecoEmail}. É Gerente: {Gerente} - É Executivo: {Executivo}";
        }
    }
    
}
