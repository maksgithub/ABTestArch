using Guard.BL.Features;

namespace Guard.Models.Features
{
    class Feature : IFeature
    {
        public string Name { get; }

        public Feature(string name)
        {
            Name = name;
        }
    }
}