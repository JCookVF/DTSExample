using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTemplateSelectorDemo
{
    class ItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BlueDataTemplate { get; set; }
        public DataTemplate RedDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if ((item as ItemModel) != null && (item as ItemModel).IsBlue)
            {
                return BlueDataTemplate;
            }
            else
            {
                return RedDataTemplate;
            }
        }
    }
}
