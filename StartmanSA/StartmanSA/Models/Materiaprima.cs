using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartmanSA.Models
{
    //classe de materia prima
    public partial class Materiaprima
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Quantidade em Estoque")]
        public long QuantidadeEstoque { get; set; }
        [Display(Name = "Quantidade Máxima para Estoque")]
        public long QuantidadeEstoqueMax { get; set; }


        //teste para validar a materia-prima
        public bool Validar(int val = 0,string op = null)
        {
            if(op == "+")
            {
                return Nome != null && QuantidadeEstoque > 0 && QuantidadeEstoqueMax > 0 && QuantidadeEstoque + val <= QuantidadeEstoqueMax;
            }else if(op == "-")
            {
                return Nome != null && QuantidadeEstoque > 0 && QuantidadeEstoqueMax > 0 && QuantidadeEstoque - val >= 0;
            }
            return Nome != null && QuantidadeEstoque > 0 && QuantidadeEstoqueMax > 0 && QuantidadeEstoque <= QuantidadeEstoqueMax;
            
        }
    }
}
