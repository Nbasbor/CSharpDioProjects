using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.ViewModel
{
    public class FilmeViewModel
    {
        //criação da id
        public Guid Id { get; set; }

        //criação do nome
        public string Nome { get; set; }

        //criação do preço
        public double Preco { get; set; }
    }
}
