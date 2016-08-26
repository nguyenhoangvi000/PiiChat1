using PiiChat.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PiiChat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactList : Page
    {
        public List<string> contactListRecent;


        public ContactList()
        {
            this.InitializeComponent();
            contactListRecent = new List<string>()
            {
                "ABC",
                "DEF",
                "ABC",
                "DEF",
                "ABC",
                "DEF",
                "ABC",
                "DEF"
            };
            ListViewContact.ItemsSource = contactListRecent;
            //ListViewContacts.ItemsSource = contactListRecent;
            MyItems.Source = Header.GetItemsGrouped();
        }

        
    }
}
