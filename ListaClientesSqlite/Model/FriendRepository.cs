
using FoundationStandard.ObjectHydrator;
using ListaClientesSqlite.Helpers;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaClientesSqlite.Model
{
    public class FriendRepository
    {
        public IList<Friend> Friends { get; set; }

        public FriendRepository() {
            Hydrator<Friend> _friendHydrator = new Hydrator<Friend>();
            Friends = _friendHydrator.GetList(50);
        }

        public IList<Friend> GetAll() {
            return Friends;
        }

        public IList<Friend> GetAllByFirstLetter(string letter)
        {
            var query = from q in Friends
                        where q.FirstName.StartsWith(letter)
                        select q;
            return query.ToList();
        }

        public ObservableCollection<Grouping<string, Friend>> getAllGrouped() {

            var sorted = from f in Friends
                         orderby f.FirstName
                         group f by f.FirstName[0].ToString()
                         into theGroup
                         select new Grouping<string, Friend>(theGroup.Key, theGroup);
            return new ObservableCollection<Grouping<string, Friend>>(sorted);

        }
    }
}
