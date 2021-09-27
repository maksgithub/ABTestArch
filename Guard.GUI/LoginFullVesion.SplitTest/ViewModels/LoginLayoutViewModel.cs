using System.Windows.Input;
using Guard.Infrastructure;
using LoginFullVersion.SplitTest.AppLayout;
using Prism.Commands;
using Prism.Mvvm;

namespace LoginFullVersion.SplitTest.ViewModels
{
    public class LoginLayoutViewModel : BindableBase, IAppLayout
    {
        private readonly IApplicationState _applicationState;
        private DelegateCommand _loginCommand;
        public ICommand LoginCommand => _loginCommand ??= new DelegateCommand(OnLogin);

        internal LoginLayoutViewModel(IApplicationState applicationState)
        {
            _applicationState = applicationState;
        }

        private void OnLogin()
        {
            _applicationState.MoveNext(AppCommand.StartLogin);
        }
    }
}