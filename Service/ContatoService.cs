using AgendaApi.Models;
using AgendaApi.Services;

namespace AgendaApi.Services
{
    public class ContatoService
    {
        private static List<Contato> contatos = new List<Contato>
        {
            new Contato
            {
                Id = 1,
                Nome = "Susi",
                Tel1 = "99999-9999",
                Tel2 = "",
                Detalhes = "Contato de teste"
            }
        };

        public List<Contato> ListarTodos()
        {
            return contatos;
        }


        public List<Contato> BuscarPorNome(string nome)
        {
            return contatos
                .Where(c => c.Nome.Contains(nome))
                .ToList();
        }

        public Contato Adicionar(Contato contato)
        {

            //if (string.IsNullOrWhiteSpace(contato.Nome))
            //    throw new Exception("O nome é obrigatório.");

            contatos.Add(contato);

            return contato;
        }


        // ? = Nullable Reference Types
        // O ? existe porque às vezes o método devolve um Contato e às vezes devolve null.
        public Contato? Alterar(int id, Contato contatoAlterado)
        {
            // Pega o primeiro contato cujo Id seja igual ao id recebido
            var contato = contatos.FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return null;

            contato.Nome = contatoAlterado.Nome;
            contato.Tel1 = contatoAlterado.Tel1;
            contato.Tel2 = contatoAlterado.Tel2;
            contato.Detalhes = contatoAlterado.Detalhes;

            return contato;
        }

        public bool Excluir(int id)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);

            if (contato == null)
                return false;

            contatos.Remove(contato);

            return true;
        }

    }
}