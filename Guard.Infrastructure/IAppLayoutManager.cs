using System;

namespace Guard.Infrastructure
{
    public interface IAppLayoutManager
    {
        event Action<IAppLayout> CurrentLayoutChanged;
        public IAppLayout CurrentLayout { get; }
    }
}