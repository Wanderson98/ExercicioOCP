using System;
using BibliotecaOCP.Enums;
using BibliotecaOCP.Pessoas;
using BibliotecaOCP.Contas;
using System.Collections.Generic;

namespace ExercicioOCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ModeloCandidato> candidatos = new List<ModeloCandidato>
                {
                new ModeloCandidato{PrimeiroNome = "Wanderson", UltimoNome = "Andrade"},
                new ModeloCandidato{PrimeiroNome = "Nara", UltimoNome = "Matos", FuncaoEmpregado = FuncaoEmpregado.Gerente},
                new ModeloCandidato{PrimeiroNome = "Lucas", UltimoNome = "Andrade"},
                new ModeloCandidato{PrimeiroNome = "Anderson", UltimoNome = "Silva"},
                new ModeloCandidato{PrimeiroNome = "Sergio", UltimoNome = "Ramos", FuncaoEmpregado = FuncaoEmpregado.Executivo}
            };

            List<ModeloEmpregado> empregados = new List<ModeloEmpregado>();
            Candidaturas processoCandidato = new Candidaturas();

            foreach(var pessoa in candidatos)
            {
                empregados.Add(processoCandidato.Criacao(pessoa));
            }

            foreach(var pessoa in empregados)
            {
                Console.WriteLine(pessoa);
            }

        }
    }
}
