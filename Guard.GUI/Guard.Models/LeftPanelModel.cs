using System.Collections.Generic;
using Guard.Models.Features;

namespace Guard.Models
{
    public class LeftPanelModel : BaseModel
    {
        public IReadOnlyCollection<IFeature> Features { get; } = new List<IFeature>()
        {
            new Feature("Safe mail"),
            new Feature("VPN"),
            new Feature("Antivirus"),
        };
    }
}