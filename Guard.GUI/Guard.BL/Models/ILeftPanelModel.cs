using System.Collections.Generic;
using Guard.BL.Features;

namespace Guard.BL.Models
{
    public interface ILeftPanelModel
    {
        IReadOnlyCollection<IFeature> Features { get; }
    }
}