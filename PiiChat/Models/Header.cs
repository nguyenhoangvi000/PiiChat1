using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiiChat.Models
{
    public class Header
    {
        public string HeaderTitle { get; set; }

        public Header()
        {
            HeaderTitle = string.Empty;
        }

        public static ObservableCollection<Text> GetTexts()
        {
            ObservableCollection<Text> myListContact = new ObservableCollection<Text>();
            myListContact.Add(new Text("ABC"));
            myListContact.Add(new Text("AEF"));
            myListContact.Add(new Text("GHI"));
            myListContact.Add(new Text("JKL"));
            myListContact.Add(new Text("MNO"));
            myListContact.Add(new Text("PQR"));
            myListContact.Add(new Text("STU"));
            return myListContact;
        }

        public static ObservableCollection<GroupInfoList> GetItemsGrouped()
        {
            ObservableCollection<GroupInfoList> groups = new ObservableCollection<GroupInfoList>();

            var query = from item in GetTexts()
                        group item by item.Title[0] into g
                        orderby g.Key
                        select new { GroupName = g.Key, Items = g };

            foreach (var g in query)
            {
                GroupInfoList info = new GroupInfoList();

                info.Key = g.GroupName;

                foreach (var item in g.Items)
                {
                    info.Add(item);
                }
                groups.Add(info);
            }
            return groups;
        }
    }
}
