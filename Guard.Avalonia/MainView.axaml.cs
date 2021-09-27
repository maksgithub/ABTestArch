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
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
