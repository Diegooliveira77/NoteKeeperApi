using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace NoteKeeper.Dominio.ModuloCategoria
{
    public class ValidadorCategoria : AbstractValidator<Categoria>
    {
        public ValidadorCategoria()
        {
            RuleFor(x => x.Titulo)
                .NotNull().NotEmpty();
        }
    }
}
