using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.ViewModel
{
    public class FilmeViewModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }
    }
}
