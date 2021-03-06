﻿using System;
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

        public static ObservableCollection<User> GetTexts()
        {
            ObservableCollection<User> myListContact = new ObservableCollection<User>();
            myListContact.Add(new User("ABC"));
            myListContact.Add(new User("AEF"));
            myListContact.Add(new User("GHI"));
            myListContact.Add(new User("JKL"));
            myListContact.Add(new User("MNO"));
            myListContact.Add(new User("PQR"));
            myListContact.Add(new User("STU"));
            return myListContact;
        }

        public static ObservableCollection<GroupInfoList> GetItemsGrouped()
        {
            ObservableCollection<GroupInfoList> groups = new ObservableCollection<GroupInfoList>();

            var query = from item in GetTexts()
                        group item by item.Username[0] into g
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
