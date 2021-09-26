using System;
using Guard.Infrastructure;
using Guard.VisualStates.FullVersion;
using Guard.VisualStates.Onboarding;
using Guard.VisualStates.TrialVersion;
using Guard.VisualStates.TrialVersion.Factories;

namespace Guard.VisualStates
{
    public class AppLayoutManager : IAppLayoutManager
    {
        private readonly FullVersionFactory _fullVersionFactory;
        private readonly TrialVersionFactory _trialVersionFactory;
        private LayoutState _currentSate;
        public event Action<IAppLayout> CurrentLayoutChanged;

        public AppLayoutManager(FullVersionFactory fullVersionFactory,
            TrialVersionFactory trialVersionFactory)
        {
            _fullVersionFactory = fullVersionFactory;
            _trialVersionFactory = trialVersionFactory;
            _currentSate = LayoutState.FullVersion;
        }

        public void SetContext(LayoutState state)
        {
            _currentSate = state;
            CurrentLayoutChanged?.Invoke(GetCurrentLayout());
        }

        public IAppLayout GetCurrentLayout()
        {
            return _currentSate switch
            {
                LayoutState.TrialVersion => _trialVersionFactory.CreateTrialLayout(),
                LayoutState.FullVersion => _fullVersionFactory.CreateFullVersionLayout(),
                LayoutState.Onboarding => new OnboardingLayotViewModel(),
                _ => null
            };
        }
    }
}