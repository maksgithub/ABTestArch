using Guard.BL.Models;
using Guard.Infrastructure;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionLayoutViewModel : BaseViewModel, IAppLayout
    {
        private readonly ILeftPanelModel _leftPanelModel;

        public FullVersionLayoutViewModel(ILeftPanelModel leftPanelModel)
        {
            _leftPanelModel = leftPanelModel;
        }

        public IAppLayout TopBar { get; } = new FullVersionTopBarViewModel();
        public virtual IAppLayout LeftPanel => new FullVersionLeftPanelViewModel(_leftPanelModel);
        public IAppLayout MiddlePanel { get; } = new FullVersionMiddlePanelViewModel();
        public IAppLayout FooterPanel { get; }= new FullVersionFooterViewModel();
    }
}