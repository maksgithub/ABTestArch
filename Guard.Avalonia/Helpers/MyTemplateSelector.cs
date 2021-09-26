using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Metadata;
using Guard.Infrastructure;

namespace Guard.Avalonia.Helpers
{
    public class MyTemplateSelector : IDataTemplate
    {
        public bool SupportsRecycling => false;
        [Content]
        public Dictionary<IAppLayout, IDataTemplate> Templates {get;} = new Dictionary<IAppLayout, IDataTemplate>();

        public IControl Build(object data)
        {
            return Templates[((IAppLayout) data)].Build(data);
        }

        public bool Match(object data)
        {
            return data is IAppLayout;
        }
    } 
}
