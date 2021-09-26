using Guard.BL.Models;
using Guard.Infrastructure;
using Guard.VisualStates.FullVersion;

namespace Guard.VisualStates.TrialVersion
{
    public class TrialVersionLayoutViewModel : FullVersionLayoutViewModel
    {
        private readonly ILeftPanelModel _leftPanelModel;
        public override IAppLayout LeftPanel => new TrialVersionLeftPanelViewModel(_leftPanelModel);

        public TrialVersionLayoutViewModel(ILeftPanelModel leftPanelModel) : base(leftPanelModel)
        {
            _leftPanelModel = leftPanelModel;
        }
    }
}