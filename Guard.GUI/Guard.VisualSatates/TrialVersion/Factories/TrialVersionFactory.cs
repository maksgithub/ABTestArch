using Guard.BL.Factories;
using Guard.BL.Models;
using Guard.Infrastructure;

namespace Guard.VisualStates.TrialVersion.Factories
{
    public class TrialVersionFactory : ITrialLayoutFactory
    {
        private ILeftPanelModel _model;

        public TrialVersionFactory(ILeftPanelModel model)
        {
            _model = model;
        }

        public IAppLayout CreateLayout()
        {
            return new TrialVersionLayoutViewModel(_model);
        }
    }
}