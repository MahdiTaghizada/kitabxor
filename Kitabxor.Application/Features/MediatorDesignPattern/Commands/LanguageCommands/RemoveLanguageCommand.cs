using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Commands.LanguageCommands
{
    public class RemoveLanguageCommand : IRequest
    {
        public int LanguageId { get; set; }
        public RemoveLanguageCommand(int languageId)
        {
            LanguageId = languageId;
        }
    }
}
