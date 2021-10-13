using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_series.web
{
    public class SerieModel
    {
        public int Id { get; set; }
        public Genero Genero { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Ano { get; set; }

        private bool Excluido { get; set; }
    }
}
