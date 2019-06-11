using System;
using System.Collections.Generic;

namespace StartmanSA.Models
{
    public partial class Materiaprima
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long QuantidadeEstoque { get; set; }
        public long QuantidadeEstoqueMax { get; set; }
    }
}
