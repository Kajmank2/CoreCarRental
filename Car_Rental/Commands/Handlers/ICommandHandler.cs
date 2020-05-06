using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Car_Rental.Commands
{
   public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}
