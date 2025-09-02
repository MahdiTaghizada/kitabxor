using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Commands.AdminCommands
{
    public class RemoveAdminCommand : IRequest
    {
        public int AdminId { get; set; }

        public RemoveAdminCommand(int adminId)
        {
            AdminId = adminId;
        }
    }
}
