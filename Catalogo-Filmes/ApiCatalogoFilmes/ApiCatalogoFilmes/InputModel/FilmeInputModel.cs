using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoFilmes.InputModel
{
    public class FilmeInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome do filme deve conter entre 3 a 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "O preço do filme deve estar entre 1 a 1000 reais")]
        public double Preco { get; set; }

    }
}
