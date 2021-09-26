namespace Guard.Models.Features
{
    public interface IFeature
    {
        string Name { get; }
    }

    class Feature : IFeature
    {
        public string Name { get; }

        public Feature(string name)
        {
            Name = name;
        }
    }
}