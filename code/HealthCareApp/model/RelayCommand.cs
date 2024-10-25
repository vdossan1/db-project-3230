using System.Windows.Input;

namespace HealthCareApp.model
{
	/// <summary>
	/// A command that relays its functionality through delegates.
	/// </summary
	public class RelayCommand : ICommand
	{
		private readonly Action<object> execute;
		private readonly Predicate<object> canExecute;

		/// <summary>
		/// Initializes a new instance of the <see cref="RelayCommand" /> class.
		/// </summary>
		/// <param name="execute">The action to be executed when the command is invoked.</param>
		/// <param name="canExecute">The predicate that determines whether the command can be executed.</param>
		public RelayCommand(Action<object> execute, Predicate<object> canExecute)
		{
			this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
			this.canExecute = canExecute;
		}

		/// <summary>
		/// Typically, protected but made public, so can trigger a manual refresh on the result of CanExecute.
		/// </summary>
		public virtual void OnCanExecuteChanged()
		{
			this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
		}

		/// <summary>
		/// Defines the method that determines whether the command can execute in its current state.
		/// </summary>
		/// <param name="parameter">Data used by the command.</param>
		/// <returns>True if this command can be executed; otherwise, false.</returns>
		public bool CanExecute(object parameter)
		{
			return this.canExecute?.Invoke(parameter) ?? true;
		}

		/// <summary>
		/// Defines the method to be called when the command is invoked.
		/// </summary>
		/// <param name="parameter">Data used by the command.</param>
		public void Execute(object parameter)
		{
			if (this.CanExecute(parameter))
			{
				this.execute(parameter);
			}
		}

		/// <summary>
		/// Occurs when changes occur that affect whether the command should execute.
		/// </summary>
		public event EventHandler CanExecuteChanged;
	}
}
