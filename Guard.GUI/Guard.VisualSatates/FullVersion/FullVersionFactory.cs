using Guard.Infrastructure;
using Guard.Models;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionFactory
    {
        private readonly LeftPanelModel _leftPanelModel;

        public FullVersionFactory(LeftPanelModel leftPanelModel)
        {
            _leftPanelModel = leftPanelModel;
        }

        public IAppLayout CreateFullVersionLayout()
        {
            return new FullVersionLayoutViewModel(_leftPanelModel);
        }
    }
}