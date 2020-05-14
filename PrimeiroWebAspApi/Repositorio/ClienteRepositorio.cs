using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroWebAspApi.Repositorio
{
    public class ClienteRepositorio
    {
        public static List<Model.Cliente> Clientes;

        public static void GeraDados()
        {
            ClienteRepositorio.Clientes = new List<Model.Cliente>();

            ClienteRepositorio.Clientes.Add(new Model.Cliente()
            {
                Endereco = "Rua Matilda, 101",
                Id = 1,
                Nome = "Cliente 1",
                Telefone = "40028922"});

            ClienteRepositorio.Clientes.Add(new Model.Cliente()
            {
                Endereco = "Rua ruan, 100",
                Id = 2,
                Nome = "Cliente 2",
                Telefone = "40023422"
            });

            ClienteRepositorio.Clientes.Add(new Model.Cliente()
            {
                Endereco = "Av. ruan, 900",
                Id = 3,
                Nome = "Cliente 3",
                Telefone = "40023422"
            });
        }
    }
}
