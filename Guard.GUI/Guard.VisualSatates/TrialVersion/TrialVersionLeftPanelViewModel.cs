using System.Linq;
using Guard.Infrastructure;
using Guard.Models;
using Guard.Models.Features;
using Guard.VisualStates.FullVersion;
using Guard.VisualStates.FullVersion.Features;

namespace Guard.VisualStates.TrialVersion
{
    public class TrialVersionLeftPanelViewModel : FullVersionLeftPanelViewModel
    {
        public TrialVersionLeftPanelViewModel(LeftPanelModel leftPanelModel) 
            : base(leftPanelModel)
        {
        }
    }
}