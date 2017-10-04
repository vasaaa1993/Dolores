using System;
using System.Windows.Input;

namespace Dolores.Client.Commands
{
    class RelayCommand: ICommand
    {
	    private readonly Action<object> _execure;
	    private readonly Predicate<object> _canExecute;
	    public RelayCommand(Action<object> execure, Predicate<object> canExecute = null)
	    {
			if(execure == null)
				throw  new NullReferenceException("execute");

			_execure = execure;
		    _canExecute = canExecute;
	    }

	    public bool CanExecute(object parameter)
	    {
		    return (_canExecute == null) ? true : _canExecute(parameter);
	    }

	    public void Execute(object parameter)
	    {
		    _execure.Invoke(parameter);
	    }

	    public event EventHandler CanExecuteChanged;
    }
}
