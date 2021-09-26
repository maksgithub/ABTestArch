using System.Linq;
using Guard.BL.Models;
using Guard.Infrastructure;
using Guard.VisualStates.FullVersion;
using Guard.VisualStates.FullVersion.Features;

namespace Guard.VisualStates.TrialVersion
{
    public class TrialVersionLeftPanelViewModel : FullVersionLeftPanelViewModel
    {
        public TrialVersionLeftPanelViewModel(ILeftPanelModel leftPanelModel) 
            : base(leftPanelModel)
        {
        }
    }
}