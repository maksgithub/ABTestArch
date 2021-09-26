using Guard.BL.Factories;
using Guard.Infrastructure;

namespace Guard.VisualStates.Onboarding
{
    public class OnboardingLayoutFactory : IOnboardingLayoutFactory
    {
        public IAppLayout CreateLayout()
        {
            return new OnboardingLayotViewModel();
        }
    }
}