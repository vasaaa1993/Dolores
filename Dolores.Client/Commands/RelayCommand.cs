using System;
using System.Windows.Input;

namespace Dolores.Client.Commands
{
    class RelayCommand: ICommand
    {
	    private readonly Action<object> _execure;
	    private readonly Predicate<object> _canExecute;
	    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
	    {
			if(execute == null)
				throw  new NullReferenceException("execute");

			_execure = execute;
		    _canExecute = canExecute;
	    }

	    public bool CanExecute(object parameter = null)
	    {
		    return _canExecute?.Invoke(parameter) ?? true;
	    }

	    public void Execute(object parameter = null)
	    {
		    _execure.Invoke(parameter);
	    }

	    public event EventHandler CanExecuteChanged;
    }
}
