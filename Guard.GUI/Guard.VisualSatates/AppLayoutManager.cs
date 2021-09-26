using Guard.Infrastructure;
using Guard.VisualStates.FullVersion;

namespace Guard.VisualStates
{
    public class AppLayoutManager : IAppLayoutManager
    {
        public void SetContext()
        {
        }

        public IAppLayout GetLayout()
        {
            return new FullVersionLayoutViewModel();
        }
    }
}