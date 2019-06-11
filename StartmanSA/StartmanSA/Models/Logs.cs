using System;
using System.Collections.Generic;

namespace StartmanSA.Models
{
    public partial class Logs
    {
        public int Id { get; set; }
        public string Encarregado { get; set; }
        public string MateriaPrima { get; set; }
        public long QuantidadeAlterada { get; set; }
        public DateTime DiaAlteracao { get; set; }
    }
}
