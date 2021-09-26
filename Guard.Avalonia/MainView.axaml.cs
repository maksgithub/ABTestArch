using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Guard.BL;
using Guard.Models;
using Guard.VisualStates.FullVersion;
using Guard.VisualStates.Main;
using Guard.VisualStates.Onboarding;
using Guard.VisualStates.TrialVersion.Factories;

namespace Guard.Avalonia
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
            var leftPanelModel = new LeftPanelModel();
            var fullVersionLayoutFactory = new FullVersionFactory(leftPanelModel);
            var trialVersionFactory = new TrialVersionFactory(leftPanelModel);
            var appLayoutManager = new AppLayoutManager(fullVersionLayoutFactory, 
                trialVersionFactory,
                new OnboardingLayoutFactory());
            DataContext = new MainViewModel(appLayoutManager);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
