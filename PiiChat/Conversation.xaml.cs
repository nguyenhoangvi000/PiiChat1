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
    public sealed partial class Conversation : Page
    {
        public ObservableCollection<MessageContent> dataSource { get; set; }
        public Conversation()
        {
            this.InitializeComponent();
            dataSource = new ObservableCollection<MessageContent>();
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {
            addMessage(txtMessage.Text);
            txtMessage.Text = "";
            ListMessage.ItemsSource = dataSource;
        }

        public void addMessage(string message)
        {
            dataSource.Add(new MessageContent(message, DateTime.Now.ToString(), "", "Left"));
        }

        private void txtMessage_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                SendMessage(sender, e);
            }
        }

        private void ShowEmoji(object sender, RoutedEventArgs e)
        {
            if (LayerEmoji.Visibility == Visibility.Collapsed)
            {
                LayerEmoji.Visibility = Visibility.Visible;
            }
            else
            {
                LayerEmoji.Visibility = Visibility.Collapsed;
            }
        }

        private void SelectImage(object sender, RoutedEventArgs e)
        {

        }
    }
}
