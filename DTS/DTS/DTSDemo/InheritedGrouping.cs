using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateSelectorDemo
{
    class InheritedGrouping<K, T> : Grouping<K, T>
    {
        public InheritedGrouping(K key, IEnumerable<T> items): 
            base(key, items)
        {

        }
    }
}
