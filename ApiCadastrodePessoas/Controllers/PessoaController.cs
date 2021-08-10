using ApiCadastrodePessoas.Context;
using ApiCadastrodePessoas.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiCadastrodePessoas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly MyContext _db;

        public PessoaController(MyContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            var pessoa = _db.Pessoas.ToList();
            return pessoa;
        }

        [HttpGet("{id}")]
        public Pessoa Get(int id)
        {
            var pessoa = _db.Pessoas.Find(id);
            return pessoa;
        }

        [HttpPost]
        public void Post([FromBody] Pessoa obj)
        {
            _db.Pessoas.Add(obj);
            _db.SaveChanges();
        }

        // PUT api/<PessoaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pessoa obj)
        {
            _db.Pessoas.Update(obj);
            _db.SaveChanges();
        }

        // DELETE api/<PessoaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var obj = _db.Pessoas.Find(id);
            _db.Pessoas.Remove(obj);
            _db.SaveChanges();
        }
    }
}
