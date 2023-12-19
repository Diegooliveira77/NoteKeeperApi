using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteKeeper.Dominio.Compartilhado;

namespace NoteKeeper.Dominio.ModuloNota
{
    public interface IRepositorioNota : IRepositorioBase<Nota>
    {
    }
}
