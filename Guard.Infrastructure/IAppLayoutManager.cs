using System;

namespace Guard.Infrastructure
{
    public interface IAppLayoutManager
    {
        event Action<IAppLayout> CurrentLayoutChanged;

        public void SetContext(LayoutState state);
        public IAppLayout GetCurrentLayout();
    }

    public enum LayoutState
    {
        TrialVersion,
        FullVersion,
        Onboarding
    }
}