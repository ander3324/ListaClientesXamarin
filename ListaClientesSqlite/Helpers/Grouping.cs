using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListaClientesSqlite.Helpers
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get;  }

        public Grouping(K key, IEnumerable<T> items)
        {
            this.Key = key;
            foreach (var item in items) {
                Items.Add(item);
            }
        }

        public Grouping(object key, IGrouping<object, string> theGroup)
        {
        }
    }
}
