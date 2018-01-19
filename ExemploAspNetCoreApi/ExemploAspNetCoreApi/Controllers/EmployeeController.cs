using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAspNetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExemploAspNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly ExWebApiDbContext _db;

        public EmployeeController(ExWebApiDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return _db.Employees.ToList();
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _db.Employees.Find(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Employee obj)
        {
            _db.Employees.Add(obj);
            _db.SaveChanges();
            return new ObjectResult("Colaborador adicionado com sucesso!");

        }




        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Employee obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            return new ObjectResult("Colaborador alterado com sucesso!");
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _db.Employees.Remove(_db.Employees.Find(id));
            _db.SaveChanges();
            return new ObjectResult("Colaborador excluido com sucesso!");
        }
    }
}
