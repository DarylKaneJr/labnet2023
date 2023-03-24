using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomerLogic : BaseLogic
    {
        public List<Customers> Punto1MC()
        {
            List<Customers> query1 = new List<Customers>();
            try
            {
                query1 = (from c in context.Customers
                              select c).ToList();
            }
            catch(SystemException ex)
            {
                throw new SystemException(ex.Message);
            }
            return query1;
        }

        public List<Customers> Punto4MC()
        {
            List<Customers> query4 = new List<Customers>();
            try
            {
                query4 = context.Customers.Where(c => c.Region == "WA").ToList();          
            }
            catch(SystemException ex)
            {
                throw new SystemException(ex.Message);
            }
            return query4;
        }

        public List<string> Punto6MC()
        {
            List<string> query6 = new List<string>();
            try
            {
                query6 = (from c in context.Customers
                              select c.ContactName).ToList();
            }
            catch(SystemException ex)
            {
                throw new SystemException(ex.Message);
            }          
            return query6;
        }

        public List<DTO.CustomersDTO> Punto7()
        {
            List<DTO.CustomersDTO> query7 = new List<DTO.CustomersDTO>();
            DateTime date = new DateTime(1997, 1, 1);
            try
            {
                 query7 = (from c in context.Customers
                              join o in context.Orders
                              on c.CustomerID equals o.CustomerID
                              where c.Region == "WA" && o.OrderDate > date
                              orderby o.CustomerID
                              select new DTO.CustomersDTO
                              {
                                  contactname = c.ContactName,
                                  region = c.Region,
                                  OrderDate = o.OrderDate
                              }).ToList();
            }
            catch(SystemException ex)
            {
                throw new SystemException(ex.Message);
            }             
            return query7;
        }

        public List<Customers> Punto8()
        {
            List<Customers> query8 = new List<Customers>();
            try
            {
                query8 = (from c in context.Customers
                          where c.Region == "WA"
                          select c)
                                .Take(3)
                                .ToList();
            }
            catch(SystemException ex)
            {
                throw new SystemException(ex.Message);
            }
            return query8;
        }
        public List<DTO.OrdersDTO> Punto13()
        {
            List<DTO.OrdersDTO> query13 = new List<DTO.OrdersDTO>();
            try
            {
                 query13 = (from o in context.Orders
                               join c in context.Customers
                               on o.CustomerID equals c.CustomerID
                               group c by new { c.ContactName } into con
                               select new DTO.OrdersDTO
                               {
                                   ContactName = con.Key.ContactName,
                                   cant_ordenes = con
                                   .Count()

                               })
                               .OrderBy(c => c.cant_ordenes)
                               .ToList();
            }
            catch (SystemException ex)
            {
                throw new SystemException(ex.Message);
            }
            return query13;
        }

    }
}
