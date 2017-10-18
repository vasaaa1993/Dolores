using System;
using System.Windows.Input;

namespace Dolores.Client.Commands
{
	class RelayCommandWithoutParam : ICommand
	{

		private readonly Action _execute;
		private readonly Predicate<object> _predicate;

		public event EventHandler CanExecuteChanged;

		public RelayCommandWithoutParam(Action execute, Predicate<object> predicate = null)
		{
			if (execute == null)
				throw new NullReferenceException("execute");

			_predicate = predicate;
			_execute = execute;
		}

		public bool CanExecute(object parameter)
		{
			return _predicate?.Invoke(parameter) ?? true;
		}

		public void Execute(object parameter)
		{
			_execute.Invoke();
		}

	}
}
