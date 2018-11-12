using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAspCore.Models;

namespace DemoAspCore.Data
{
    public class Dbinitializer
    {
        public static void initialize(DemoAspCoreContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria
                {
                    Nombre = "Programacion",
                    Descripcion ="Desarrollo Asp",
                    Estado= true
                },
                 new Categoria
                {
                    Nombre = "Diseño Grafico",
                    Descripcion ="Diseño en Adobe ",
                    Estado= true
                }

            };
            foreach (Categoria item in categorias)
            {
                context.Categoria.Add(item);
            }
            context.SaveChanges();
        }
        
    }
}
