using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StartmanSA.Models
{
    //classe para fazer filtro entre encarregados
    public class LogsEncarregadosViewModel
    {
        public List<Logs> Logs { get; set; }
        public SelectList Encarregados { get; set; }
        public string LogEncarregado { get; set; }
        public string SearchString { get; set; }

    }
}
