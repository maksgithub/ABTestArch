using Guard.Infrastructure;

namespace Guard.VisualStates.Main
{
    public class MainViewModel
    {
        private readonly IAppLayoutManager _layoutManager;

        public IAppLayout MainContent { get; }
        
        public MainViewModel(IAppLayoutManager layoutManager)
        {
            _layoutManager = layoutManager;
            MainContent = layoutManager.GetLayout();
        }
    }
}