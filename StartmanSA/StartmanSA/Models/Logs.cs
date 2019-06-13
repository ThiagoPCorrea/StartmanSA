using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartmanSA.Models
{
    //classe de logs
    public partial class Logs
    {
        public int Id { get; set; }
        public string Encarregado { get; set; }
        [Display(Name = "Matéria-Prima")]
        public string MateriaPrima { get; set; }
        [Display(Name = "Tipo de Operação")]
        public string TipodeOperacao { get; set; }
        [Display(Name = "Quantidade Alterada")]
        public long QuantidadeAlterada { get; set; }
        [Display(Name = "Data de Alteração")]
        [DataType(DataType.DateTime)]
        public DateTime DiaAlteracao { get; set; }
    }
}
