using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTemplateSelectorDemo
{
    class GroupingDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate GreenDataTemplate { get; set; }
        public DataTemplate YellowDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item.GetType().IsConstructedGenericType && item.GetType().GetGenericTypeDefinition() == typeof(InheritedGrouping<,>))
            {
                return GreenDataTemplate;
            }
            else
            {
                return YellowDataTemplate;
            }
        }
    }
}
