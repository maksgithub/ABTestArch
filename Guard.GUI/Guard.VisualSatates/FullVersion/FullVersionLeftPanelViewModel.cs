using System.Collections.Generic;
using System.Linq;
using Guard.BL.Features;
using Guard.BL.Models;
using Guard.Infrastructure;
using Guard.VisualStates.FullVersion.Features;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionLeftPanelViewModel : BaseViewModel, IAppLayout
    {
        private readonly FeatureViewModel[] _ss;
        protected ILeftPanelModel LeftPanelModel { get; }
        public IReadOnlyCollection<FeatureViewModel> Features => _ss;

        public FullVersionLeftPanelViewModel(ILeftPanelModel leftPanelModel)
        {
            LeftPanelModel = leftPanelModel;
            _ss = LeftPanelModel.Features.Select(CreateFeature).ToArray();
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