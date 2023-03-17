using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ProductLogic : BaseLogic
    {
        public List<Products> Punto2()
        {
            var query2 = context.Products.Where(p => p.UnitsInStock == 0).ToList();
            return query2;
        }
        public List<Products> Punto3()
        {
            var query3 = context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
            return query3;
        }
        public string Punto5()
        {
            string mensaje = "";
            var query5 = context.Products.FirstOrDefault(p => p.ProductID == 789);
            if (query5 == null)
            {
                mensaje = "La consulta devolvio null";
            }
            else
            {
                mensaje = "Contiene algo";
            }
            return mensaje;
        }

        public List<Products> Punto9()
        {
            var query9 = (from p in context.Products
                          orderby p.ProductName
                          select p).ToList();
            return query9;
        }

        public List<Products> Punto10()
        {
            var query9 = (from p in context.Products
                          orderby p.UnitsInStock
                          select p).ToList();
            return query9;
        }

        public List<DTO.CategoriesDTO> Punto11()
        {
            var query11 = (from c in context.Categories
                           orderby c.CategoryName
                           join p in context.Products
                           on c.CategoryID equals p.CategoryID
                           select new DTO.CategoriesDTO
                           {
                               CategoryID = c.CategoryID,
                               CategoryName = c.CategoryName,
                               ProductName = p.ProductName                                                           
                           }).ToList();
            return query11;
        }

        public List<Products> Punto12()
        {
            List<Products> lista = new List<Products>();
            var query12 = context.Products.First();
            lista.Add(query12);
            return lista;
        }
    }
}
