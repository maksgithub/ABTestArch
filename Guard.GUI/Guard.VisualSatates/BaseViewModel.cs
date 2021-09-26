using System;
using Prism.Mvvm;

namespace Guard.VisualStates
{
    public abstract class BaseViewModel : BindableBase
    {
        public string Background { get; }
        public string Description => $"{GetType().Name}".Replace("ViewModel", "");

        protected BaseViewModel()
        {
            var random = new Random();
            Background = $"#{random.Next(0x1000000):X6}";
        }
    }
}