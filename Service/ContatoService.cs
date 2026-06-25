using AgendaApi.Models;
using AgendaApi.Data;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Services
{
    public class ContatoService
    {
        private readonly AgendaContext _context;

        public ContatoService(AgendaContext context)
        {
            // _context recebe uma copia do banco de dados(AgendaApi).
            _context = context;
        }

        public List<Contato> ListarTodos()
        {
            return _context.Contatos.ToList();
        }


        public List<Contato> BuscarPorNome(string nome)
        {
            return _context.Contatos
                .Where(c => c.Nome.Contains(nome))
                .ToList();
        }

        public Contato Adicionar(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();

            return contato;
        }


        // ? = Nullable Reference Types
        // O ? existe porque às vezes o método devolve um Contato e às vezes devolve null.
        public Contato? Alterar(int id, Contato contatoAlterado)
        {
            // Pega o primeiro contato cujo Id seja igual ao id recebido
            var contato = _context.Contatos.FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return null;

            contato.Nome = contatoAlterado.Nome;
            contato.Tel1 = contatoAlterado.Tel1;
            contato.Tel2 = contatoAlterado.Tel2;
            contato.Detalhes = contatoAlterado.Detalhes;
            _context.SaveChanges();

            return contato;
        }

        public bool Excluir(int id)
        {
            var contato = _context.Contatos.FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return false;

            _context.Contatos.Remove(contato);
            _context.SaveChanges();

            return true;
        }

    }
}