using Guard.Infrastructure;
using Guard.Models;
using Guard.VisualStates.FullVersion;

namespace Guard.VisualStates.TrialVersion
{
    public class TrialVersionLayoutViewModel : FullVersionLayoutViewModel
    {
        private readonly LeftPanelModel _leftPanelModel;
        public override IAppLayout LeftPanel => new TrialVersionLeftPanelViewModel(_leftPanelModel);

        public TrialVersionLayoutViewModel(LeftPanelModel leftPanelModel) : base(leftPanelModel)
        {
            _leftPanelModel = leftPanelModel;
        }
    }
}