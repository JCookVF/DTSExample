using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateSelectorDemo
{
    class MainPageVM
    {
        public ObservableCollection<Grouping<string, ItemModel>> Items { get; set; }
        private ItemModel _selectedItem;
        public ItemModel SelectedItem { get; set; }// { get { return _selectedItem; } set { _selectedItem = value; } }
        public MainPageVM()
        {
            Items = new ObservableCollection<Grouping<string, ItemModel>>();
            Items.Add(new Grouping<string, ItemModel>("Grouping 1", new ObservableCollection<ItemModel> { new ItemModel(true), new ItemModel(true) }));
            Items.Add(new InheritedGrouping<string, ItemModel>("Grouping 2", new ObservableCollection<ItemModel> { new ItemModel(false), new ItemModel(true) }));
            Items.Add(new InheritedGrouping<string, ItemModel>("Grouping 3", new ObservableCollection<ItemModel> { new ItemModel(false), new ItemModel(false) }));
            //Items.Add(new Grouping<string, ItemModel>("Grouping 4", new ObservableCollection<ItemModel>())); /* <-- UNCOMMENT THIS FOR A GOOD TIME */
        }
    }
}
