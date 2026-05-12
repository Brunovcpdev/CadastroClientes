using CadastroClientes.Models;
using CadastroClientes.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace CadastroClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        //CRIANDO UMA INSTANCIA DE ICONFIGURATION PARA CARREGAR O appsettings.json
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        [HttpPost("Salvar")]
        public object Salvar([FromBody] Clientes cliente)
        {
            try
            {
                var appConfig = new AppConnection(configuration);

                ClientesRepository clientes = new ClientesRepository(appConfig);

                var retorno = clientes.GetCliente(cliente.IdCliente);

                if (retorno != null)
                {
                    clientes.Atualizar(cliente);
                }
                else
                    clientes.Salvar(cliente);
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [HttpPost("Alterar")]
        public object Alterar([FromBody] Clientes cliente)
        {
            try
            {
                var appConfig = new AppConnection(configuration);

                ClientesRepository clientes = new ClientesRepository(appConfig);
                clientes.Atualizar(cliente);
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [HttpGet("Listar")]
        public object Listar()
        {
            List<Clientes> listaCli = null;
            try
            {
                var appConfig = new AppConnection (configuration);


                ClientesRepository clientesRepo = new ClientesRepository(appConfig);
                listaCli = clientesRepo.Listar();
            }
            catch (Exception ex)
            {

            }

            return listaCli;
        }
        [HttpDelete("Deletar")]
        public object Deletar(int IdCliente)
        {
            try
            {
                var appConfig = new AppConnection (configuration);


                ClientesRepository clientes = new ClientesRepository(appConfig);
                bool retornoDelete = clientes.Deletar(IdCliente);

                return retornoDelete;
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        [HttpGet("GetCliente")]
        public object GetCliente(int IdCliente)
        {
            try
            {
                var appConfig = new AppConnection(configuration);


                ClientesRepository cliente = new ClientesRepository(appConfig);
                var retorno = cliente.GetCliente(IdCliente);
                return retorno;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return null;
        }
    }
}