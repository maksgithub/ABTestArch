using System;
using System.Linq;
using System.Windows.Markup;

namespace Common.WPF
{
    public class EnumToItemsSource : MarkupExtension
    {
        private readonly Type _type;

        public EnumToItemsSource(Type type)
        {
            _type = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var provideValue = Enum.GetValues(_type)
                .Cast<object>()
                .Select(e => new EnumData{ Value = (int)e, DisplayName = e.ToString() });
            return provideValue;
        }
    }

    public class EnumData
    {
        public int Value { get; set; }
        public string? DisplayName { get; set; }
    }
}