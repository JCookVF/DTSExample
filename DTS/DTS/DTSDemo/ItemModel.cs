using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateSelectorDemo
{
    class ItemModel
    {
        public bool IsBlue { get; set; }

        public ItemModel(bool isBlue)
        {
            IsBlue = isBlue;
        }
    }
}
