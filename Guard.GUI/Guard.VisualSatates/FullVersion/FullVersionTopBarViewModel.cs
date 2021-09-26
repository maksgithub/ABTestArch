using System.Collections.Generic;
using Guard.Infrastructure;
using Guard.VisualStates.Main;

namespace Guard.VisualStates.FullVersion
{
    public class FullVersionTopBarViewModel : BaseViewModel, IAppLayout
    {
        public IEnumerable<MenuItem> States => new List<MenuItem>()
        {
            new MenuItem(LayoutState.FullVersion),
            new MenuItem(LayoutState.TrialVersion)
        };
    }
}