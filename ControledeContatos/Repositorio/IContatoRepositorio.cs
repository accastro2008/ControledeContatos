using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        //um contato que vai receber como parametro um objeto contato
        //e que vai retornar ele mesmo deve ser usado na classe ContatoRepositorio
        //por injeção

        

        ContatoModel Atualizar(ContatoModel contato);

        ContatoModel Adicionar(ContatoModel contato);

        List<ContatoModel> BuscarTodos();

        ContatoModel ListarPorId(int Id);
                
        bool Apagar(int id);
    }

}
