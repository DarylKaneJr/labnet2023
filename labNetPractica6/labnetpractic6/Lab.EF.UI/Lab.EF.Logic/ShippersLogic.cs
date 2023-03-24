using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ShippersLogic: BaseLogic
    {
        public void Add(Shippers oshippers)
        {
            context.Shippers.Add(oshippers);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var shippersdelete = context.Shippers.Find(id);
            context.Shippers.Remove(shippersdelete);
            context.SaveChanges();
        }
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
        public void Update(Shippers shi)
        {
            var shipperupdate = context.Shippers.Find(shi.ShipperID);
            shipperupdate.CompanyName = shi.CompanyName;
            shipperupdate.Phone = shi.Phone;
            context.Entry(shipperupdate).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        
       
    }
}
