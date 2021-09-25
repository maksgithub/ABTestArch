using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Guard.GUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new CounterViewModel();
        }
    }

    public class CounterViewModel : BindableObject
    {

        ICommand clickedCommand;
        public ICommand ClickedCommand => clickedCommand ??= new Command(IncrementCount);

        private void IncrementCount()
        {
            Count += 10;
        }

        private int count = 0;
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }
    }
}
