using Guard.Infrastructure;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionLayoutViewModel : BaseViewModel, IAppLayout
    {
        public IAppLayout TopBar { get; } = new FullVersionTopBarViewModel();
        public IAppLayout LeftPanel { get; } = new FullVersionLeftPanelViewModel();
        public IAppLayout MiddlePanel { get; } = new FullVersionMiddlePanelViewModel();
        public IAppLayout FooterPanel { get; }= new FullVersionFooterViewModel();
    }
}