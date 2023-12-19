using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeper.Dominio.Compartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : Entidade
    {
        Task<bool> InserirAsync(TEntidade registro);
        void Editar(TEntidade registro);
        void Excluir(TEntidade registro);

        TEntidade SelecionarPorId(Guid id);

        Task<TEntidade> SelecionarPorIdAsync(Guid id);
        Task<List<TEntidade>> SelecionarTodosAsync();
    }
}
