using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartmanSA.Models
{
    public partial class Materiaprima
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Quantidade em Estoque")]
        public long QuantidadeEstoque { get; set; }
        [Display(Name = "Quantidade Maxima para Estoque")]
        public long QuantidadeEstoqueMax { get; set; }
    }
}
