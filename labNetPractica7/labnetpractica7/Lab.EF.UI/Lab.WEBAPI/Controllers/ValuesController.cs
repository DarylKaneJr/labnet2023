using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.WEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace Lab.WEBAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET api/values
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var logic = new ShippersLogic();
                var shippers = logic.GetAll();
                List<ShippersView> shippersview = shippers.Select(s => new ShippersView
                {
                    ShippersID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();
                return Ok(shippersview);
            }
            catch
            {
                return InternalServerError();
            }
        }

        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                if (id == 0)
                {

                    return BadRequest("El id es requerido");
                }
                var logic = new ShippersLogic();
                var shippers = logic.GetAll();
                List<ShippersView> shippersview = shippers.Select(s => new ShippersView
                {
                    ShippersID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone
                }).ToList();
                return Ok(shippersview.FirstOrDefault(o => o.ShippersID == id));
            }
            catch
            {
                return InternalServerError();
            }
        }

        // POST api/values
        //Ej : {    "CompanyName": "hola",  "Phone" : "1234"}// 
        [HttpPost]
        public IHttpActionResult Post(Shippers shippersview)
        {
            try
            {
                if (shippersview == null)
                {
                    return BadRequest("se requiere llenar objeto");
                }
                var logic = new ShippersLogic();
                Shippers newshippers = new Shippers { CompanyName = shippersview.CompanyName, Phone = shippersview.Phone };
                logic.Add(newshippers);
                return Ok(newshippers);
            }
            catch
            {
                return InternalServerError();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public IHttpActionResult Put(Shippers shippersview)
        {
            try
            {               
                    var logic = new ShippersLogic();
                    Shippers obj;
                    obj = new Shippers();
                    obj.ShipperID = shippersview.ShipperID;
                    obj.CompanyName = shippersview.CompanyName;
                    obj.Phone = shippersview.Phone;
                    logic.Update(obj);
                    return Ok(obj);            
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpDelete]
        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var logic = new ShippersLogic();
                logic.Delete(id);
                return Ok("se elimino correctamente");
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
