using Guard.Infrastructure;

namespace Guard.BL.Factories
{
    public interface ILayoutFactory
    {
        IAppLayout CreateLayout();
    }
}