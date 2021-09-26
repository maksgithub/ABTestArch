using Guard.Infrastructure;

namespace Guard.VisualStates.Main
{
    public class MenuItem
    {
        public string Name => State.ToString();
        public LayoutState State { get; }

        public MenuItem(LayoutState state)
        {
            State = state;
        }
    }
}