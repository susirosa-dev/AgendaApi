using AgendaApi.Models;
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
        private ContatoService contatoService = new ContatoService();

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
                return NotFound();

            return Ok(contato);
        }

        // Retorna contatos conforme nome pesquisado e um código HTTP adequado 
        [HttpGet("buscar")]
        public ActionResult<List<Contato>> BuscarPorNome(string nome)
        {
            var resultado = contatoService.BuscarPorNome(nome);

            return Ok(resultado);
        }


        // Adiciona registro e retorna código HTTP adequado
        [HttpPost]
        public ActionResult Post(Contato contato)
        {
            var contatoCriado = contatoService.Adicionar(contato);

            return Ok(contatoCriado);
        }

        // Altera registro conforme id selecionado e retorna código HTTP adequado
        [HttpPut("{id}")]
        public ActionResult Put(int id, Contato contatoAlterado)
        {
            var contato = contatoService.Alterar(id, contatoAlterado);

            if (contato == null)
                return NotFound();

            return Ok(contato);
        }

        // Exclui registro conforme id selecionado e retorna código HTTP adequado
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var sucesso = contatoService.Excluir(id);

            if (!sucesso)
                return NotFound();

            return Ok();
        }
    }
}