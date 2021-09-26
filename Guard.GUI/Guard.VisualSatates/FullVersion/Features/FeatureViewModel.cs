using Guard.BL.Features;

namespace Guard.VisualStates.FullVersion.Features
{
    public class FeatureViewModel : BaseViewModel
    {
        private readonly IFeature _feature;
        public string Name => _feature.Name;

        public FeatureViewModel(IFeature feature)
        {
            _feature = feature;
        }
    }

    public class VpnFeatureViewModel : FeatureViewModel
    {
        public VpnFeatureViewModel(IFeature feature) : base(feature)
        {
        }
    }
}