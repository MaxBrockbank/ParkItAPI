using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using ParkIt.Models;

namespace ParkItControllers
{
  [ApiVersion("1.0")]
  [Route("api/Parks")]
  [ApiController]
  public class ParksV1Controller : ControllerBase
  {
    private ParkItContext _db;
    public ParksV1Controller(ParkItContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put (int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete (int id)
    {
      var thisPark = _db.Parks.FirstOrDefault(entry=>entry.ParkId == id);
      _db.Parks.Remove(thisPark);
      _db.SaveChanges();
    }
  }
  
  [ApiVersion("2.0")]
  [Route("api/{Version:apiVersion}/Parks")]
  [ApiController]
  public class ParksV2Controller : ControllerBase
  {
    private ParkItContext _db;
    public ParksV2Controller(ParkItContext db)
    {
      _db = db;
    }

    [HttpGet("{id}")]
    public ActionResult <Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry=>entry.ParkId == id);
      
    }

    [HttpGet]
    public ActionResult <IEnumerable<Park>> Get(string name, string state, string parkType)
    {
      var query = _db.Parks.AsQueryable();

      if(name!=null)
      {
        query = query.Where(entry=>entry.Name == name);
      }
      
      if(state!=null)
      {
        query = query.Where(entry=>entry.State == state);
      }

      if(parkType!=null)
      {
        query = query.Where(entry=>entry.ParkType == parkType);
      }

      return query.ToList();
    }
  }
}