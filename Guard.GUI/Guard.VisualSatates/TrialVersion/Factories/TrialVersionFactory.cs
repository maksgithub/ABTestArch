using Guard.Infrastructure;
using Guard.Models;

namespace Guard.VisualStates.TrialVersion.Factories
{
    public class TrialVersionFactory
    {
        private LeftPanelModel _model;

        public TrialVersionFactory(LeftPanelModel model)
        {
            _model = model;
        }

        public IAppLayout CreateTrialLayout()
        {
            return new TrialVersionLayoutViewModel(_model);
        }
    }
}