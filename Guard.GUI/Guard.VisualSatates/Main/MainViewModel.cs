using System.Collections.Generic;
using Guard.Infrastructure;

namespace Guard.VisualStates.Main
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IAppLayoutManager _layoutManager;
        private IAppLayout _mainContent;

        public IEnumerable<MenuItem> States => new List<MenuItem>()
        {
            new MenuItem(LayoutState.FullVersion),
            new MenuItem(LayoutState.TrialVersion),
            new MenuItem(LayoutState.Onboarding)
        };

        private MenuItem _currentState;
        public MenuItem CurrentState
        {
            get => _currentState;
            set
            {
                if(_currentState != value)
                {
                    _currentState = value;
                    _layoutManager.SetContext(_currentState.State);
                }
            }
        }

        public IAppLayout MainContent
        {
            get => _mainContent;
            private set => SetProperty(ref _mainContent, value);
        }

        public MainViewModel(IAppLayoutManager layoutManager)
        {
            _layoutManager = layoutManager;
            layoutManager.CurrentLayoutChanged += OnCurrentLayoutChanged;
            MainContent = layoutManager.GetCurrentLayout();
        }

        private void OnCurrentLayoutChanged(IAppLayout layout)
        {
            MainContent = layout;
        }
    }
}