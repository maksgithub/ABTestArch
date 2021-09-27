using Guard.Infrastructure;
using Prism.Mvvm;

namespace SplitTest.Common.Base.ViewModels
{
    public class MainViewModel : BindableBase, IAppLayout
    {
        private IAppLayout _mainContent;

        public IAppLayout MainContent
        {
            get => _mainContent;
            private set => SetProperty(ref _mainContent, value);
        }

        public MainViewModel(IAppLayoutManager layoutManager)
        {
            layoutManager.CurrentLayoutChanged += OnCurrentLayoutChanged;
            MainContent = layoutManager.CurrentLayout;
        }

        private void OnCurrentLayoutChanged(IAppLayout layout)
        {
            MainContent = layout;
        }
    }
}
