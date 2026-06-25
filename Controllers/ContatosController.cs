using AgendaApi.Data;
using AgendaApi.Models;
using AgendaApi.DTOs;
using AgendaApi.Services;
using Microsoft.AspNetCore.Mvc;


namespace AgendaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    /*
    Endpoints da API - para testes no Swagger:
    GET	/api/Contatos (Busca todos)
    GET	/api/Contatos/1	(pesquisa registro com contato Id=1)
    GET	/api/Contatos/buscar?nome=Susi (pesquisa registro com nome=Susi)
    POST /api/Contatos (Inclui contato)
    PUT	/api/Contatos/1	(Altera contato com Id=1)
    DELETE /api/Contatos/1(Exclui contato com Id=1)
    */
         

    // ContatosController herda classe Controller de API (APIs REST)
    public class ContatosController : ControllerBase
    {
        // Recebe uma instância de ContatoService criada automaticamente pelo ASP.NET Core
        // através da Injeção de Dependência (Dependency Injection).
        private readonly ContatoService contatoService;

        public ContatosController(ContatoService contatoService)
        {
            this.contatoService = contatoService;
        }

        // Retorna lista de contatos e um código HTTP adequado      
        [HttpGet]  // Este método responde ao verbo HTTP GET        
        public ActionResult<List<Contato>> Get()
        {
            return Ok(contatoService.ListarTodos());
        }


        // Retorna um contato conforme id passado e um código HTTP adequado        
        [HttpGet("{id}")]
        public ActionResult<Contato> Get(int id)
        {           
            var contato = contatoService.ListarTodos()
                .FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return NotFound("Contato não encontrado.");

            return Ok(contato);
        }

        // Retorna contatos conforme nome pesquisado e um código HTTP adequado 
        [HttpGet("buscar")]
        public ActionResult<List<Contato>> BuscarPorNome(string nome)
        {
            var resultado = contatoService.BuscarPorNome(nome);

           // if (!resultado.Any())
           //     return NotFound("Nenhum contato encontrado para o nome informado.");

            return Ok(resultado); // Retorna cód 200 mesmo vazia
        }

        // Adiciona registro e retorna código HTTP adequado
        [HttpPost]
        public ActionResult Post(ContatoDTO contatoDTO)
        {
            var contato = new Contato
            {
                Nome = contatoDTO.Nome,
                Tel1 = contatoDTO.Tel1,
                Tel2 = contatoDTO.Tel2,
                Detalhes = contatoDTO.Detalhes
            };

            var contatoCriado = contatoService.Adicionar(contato);

            return Ok(contatoCriado);
        }

        // Altera registro conforme id selecionado e retorna código HTTP adequado
        [HttpPut("{id}")]
        public ActionResult Put(int id, ContatoDTO contatoDTO)
        {
            var contatoAlterado = new Contato
            {
                Nome = contatoDTO.Nome,
                Tel1 = contatoDTO.Tel1,
                Tel2 = contatoDTO.Tel2,
                Detalhes = contatoDTO.Detalhes
            };

            var contato = contatoService.Alterar(id, contatoAlterado);

            if (contato == null)                
                return NotFound("Contato não encontrado.");

            return Ok(contato);
        }

        // Exclui registro conforme id selecionado e retorna código HTTP adequado
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var sucesso = contatoService.Excluir(id);

            if (!sucesso)
                return NotFound("Contato não encontrado.");

            return Ok();
        }
    }
}