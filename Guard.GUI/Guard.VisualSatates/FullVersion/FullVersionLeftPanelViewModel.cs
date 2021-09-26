using System.Collections.Generic;
using System.Linq;
using Guard.Infrastructure;
using Guard.Models;
using Guard.Models.Features;
using Guard.VisualStates.FullVersion.Features;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionLeftPanelViewModel : BaseViewModel, IAppLayout
    {
        protected LeftPanelModel LeftPanelModel { get; }
        public IReadOnlyCollection<FeatureViewModel> Features =>
            LeftPanelModel.Features.Select(CreateFeature).ToArray();

        public FullVersionLeftPanelViewModel(LeftPanelModel leftPanelModel)
        {
            LeftPanelModel = leftPanelModel;
        }

        protected virtual FeatureViewModel CreateFeature(IFeature feature)
        {
            if (feature.Name == "VPN")
            {
                return new VpnFeatureViewModel(feature);
            }
            return new FeatureViewModel(feature);
        }
    }
}