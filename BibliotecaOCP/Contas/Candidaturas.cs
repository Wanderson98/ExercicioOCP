using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaOCP.Pessoas;
using BibliotecaOCP.Enums;

namespace BibliotecaOCP.Contas
{
    public class Candidaturas
    {
        public ModeloEmpregado Criacao(ModeloCandidato modeloCandidato)
        {
            ModeloEmpregado modeloEmpregado = new ModeloEmpregado();
            modeloEmpregado.PrimeiroNome = modeloCandidato.PrimeiroNome;
            modeloEmpregado.UltimoNome = modeloCandidato.UltimoNome;
            modeloEmpregado.EnderecoEmail = $"{modeloCandidato.PrimeiroNome.Substring(0, 1).ToLower()}" +
                $"{modeloCandidato.UltimoNome.ToLower()}@castgroup.com";

            switch (modeloCandidato.FuncaoEmpregado)
            {
                case FuncaoEmpregado.Gerente:
                    modeloEmpregado.Gerente = true;
                    break;
                case FuncaoEmpregado.Desenvolvedor:
                    break;
                case FuncaoEmpregado.Executivo:
                    modeloEmpregado.Executivo = true;   
                    break;
                case FuncaoEmpregado.Estagiário:
                    break;
                default:
                    break;
            }


            return modeloEmpregado;
        }
    }
}
