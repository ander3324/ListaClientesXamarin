using ListaClientesSqlite.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ListaClientesSqlite.Helpers;
using System.Collections.ObjectModel;

namespace ListaClientesSqlite.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }

        public MainPageViewModel()
        {
            FriendRepository repo = new FriendRepository();
            Friends = repo.getAllGrouped();
        }
    }
}
