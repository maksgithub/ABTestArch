using Guard.Infrastructure;
using Guard.Models;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionLayoutViewModel : BaseViewModel, IAppLayout
    {
        private readonly LeftPanelModel _leftPanelModel;

        public FullVersionLayoutViewModel(LeftPanelModel leftPanelModel)
        {
            _leftPanelModel = leftPanelModel;
        }

        public IAppLayout TopBar { get; } = new FullVersionTopBarViewModel();
        public virtual IAppLayout LeftPanel => new FullVersionLeftPanelViewModel(_leftPanelModel);
        public IAppLayout MiddlePanel { get; } = new FullVersionMiddlePanelViewModel();
        public IAppLayout FooterPanel { get; }= new FullVersionFooterViewModel();
    }
}