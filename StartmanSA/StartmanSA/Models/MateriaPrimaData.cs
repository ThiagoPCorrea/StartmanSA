using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartmanSA.Models
{
    // Classe para popular as materias-primas
    public class MateriaPrimaData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StartmanSAContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StartmanSAContext>>()))

            {
                if (context.Materiaprima.Any())
                {
                    return;
                }

                context.Materiaprima.AddRange(
                    new Materiaprima
                    {
                        Nome = "Alumínio",
                        QuantidadeEstoque = 3500,
                        QuantidadeEstoqueMax = 5000
                    },

                    new Materiaprima
                    {
                        Nome = "Plástico",
                        QuantidadeEstoque = 5000,
                        QuantidadeEstoqueMax = 5000

                    },

                    new Materiaprima
                    {
                        Nome = "Cobre",
                        QuantidadeEstoque = 1200,
                        QuantidadeEstoqueMax = 5000

                    },

                    new Materiaprima
                    {
                        Nome = "Aço",
                        QuantidadeEstoque = 450,
                        QuantidadeEstoqueMax = 5000

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
