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
  public class ParksV1Controller
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
}