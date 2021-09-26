using System;
using Guard.BL.Factories;
using Guard.Infrastructure;

namespace Guard.BL
{
    public class AppLayoutManager : IAppLayoutManager
    {
        private readonly IFullVersionLayoutFactory _fullVersionFactory;
        private readonly ITrialLayoutFactory _trialVersionFactory;
        private readonly IOnboardingLayoutFactory _onboardingLayoutFactory;
        private LayoutState _currentSate;
        public event Action<IAppLayout> CurrentLayoutChanged;

        public AppLayoutManager(IFullVersionLayoutFactory fullVersionFactory,
            ITrialLayoutFactory trialVersionFactory,
            IOnboardingLayoutFactory onboardingLayoutFactory)
        {
            _fullVersionFactory = fullVersionFactory;
            _trialVersionFactory = trialVersionFactory;
            _onboardingLayoutFactory = onboardingLayoutFactory;
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
                LayoutState.TrialVersion => _trialVersionFactory.CreateLayout(),
                LayoutState.FullVersion => _fullVersionFactory.CreateLayout(),
                LayoutState.Onboarding => _onboardingLayoutFactory.CreateLayout(),
                _ => null
            };
        }
    }
}