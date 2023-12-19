using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace NoteKeeper.Dominio.ModuloNota
{
    public class ValidadorNota : AbstractValidator<Nota>
    {
        public ValidadorNota()
        {
            RuleFor(x => x.Titulo)
               .NotNull().NotEmpty();

            RuleFor(x => x.Conteudo)
               .NotNull().NotEmpty();

            RuleFor(x => x.Categoria)
               .NotNull().NotEmpty();
        }
    }
}
