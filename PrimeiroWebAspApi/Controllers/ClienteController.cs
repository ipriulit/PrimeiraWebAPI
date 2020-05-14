using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeiroWebAspApi.Model;

namespace PrimeiroWebAspApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public ClienteController()
        {
        }

        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return Repositorio.ClienteRepositorio.Clientes;
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public Cliente Get(int id)
        {
            return Repositorio.ClienteRepositorio.Clientes.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/Cliente
        [HttpPost]
        public void Post([FromBody] Cliente value)
        {
            Repositorio.ClienteRepositorio.Clientes.Add(value);
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {
            Cliente cli = Repositorio.ClienteRepositorio.Clientes.FirstOrDefault(x => x.Id == id);
            if(cli != null)
            {
                cli.Nome = value.Nome;
                cli.Telefone = value.Telefone;
                cli.Endereco = value.Endereco;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Cliente cli = Repositorio.ClienteRepositorio.Clientes.FirstOrDefault(x => x.Id == id);
            if (cli != null)
            {
                Repositorio.ClienteRepositorio.Clientes.Remove(cli);
            }
        }
    }
}
