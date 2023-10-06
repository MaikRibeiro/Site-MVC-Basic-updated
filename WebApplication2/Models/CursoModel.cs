using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CursoModel
    {
        public string Nome { get; set; }
        public string Modalidade { get; set; }
        public int Vagas { get; set; }

        public static List<CursoModel> CriarLista()
        {
            var lista = new List<CursoModel>();

            lista.Add(new CursoModel() { Nome = "Desenvolvimento de Sistemas", Modalidade = "Presencial", Vagas = 40});
            lista.Add(new CursoModel() { Nome = "Contabilidade", Modalidade = "Semi-Presencial", Vagas = 40});
            lista.Add(new CursoModel() { Nome = "Administração", Modalidade = "EAD", Vagas = 40});
            lista.Add(new CursoModel() { Nome = "Edificações", Modalidade = "Presencial (20% EAD)", Vagas = 80});
            lista.Add(new CursoModel() { Nome = "Recursos Humanos", Modalidade = "EAD", Vagas = 40});

            return lista;
        }
    }
}
