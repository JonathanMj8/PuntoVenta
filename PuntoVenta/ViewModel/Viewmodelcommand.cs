using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
namespace PuntoVenta.ViewModel
{
    public class Viewmodelcommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;

        public Viewmodelcommand(Action<object> executeAction)
        {
                _executeAction = executeAction;
                _canExecuteAction = null;
        }
        public Viewmodelcommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }


         

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
