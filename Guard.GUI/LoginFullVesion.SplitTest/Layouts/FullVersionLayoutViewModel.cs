using System.Windows.Input;
using Guard.Infrastructure;
using LoginFullVersion.SplitTest.AppLayout;
using Prism.Commands;

namespace LoginFullVersion.SplitTest.Layouts
{
    public class FullVersionLayoutViewModel : IAppLayout
    {
        private readonly IApplicationState _applicationState;
        private DelegateCommand _exitAccountCommand;
        public ICommand ExitAccountCommand => _exitAccountCommand ??= new DelegateCommand(OnExitAccount);

        internal FullVersionLayoutViewModel(IApplicationState applicationState)
        {
            _applicationState = applicationState;
        }

        private void OnExitAccount()
        {
            _applicationState.MoveNext(AppCommand.ExitAccount);
        }
    }
}