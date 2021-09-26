using Guard.BL.Factories;
using Guard.BL.Models;
using Guard.Infrastructure;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionFactory : IFullVersionLayoutFactory
    {
        private readonly ILeftPanelModel _leftPanelModel;

        public FullVersionFactory(ILeftPanelModel leftPanelModel)
        {
            _leftPanelModel = leftPanelModel;
        }

        public IAppLayout CreateLayout()
        {
            return new FullVersionLayoutViewModel(_leftPanelModel);
        }
    }
}