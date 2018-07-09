using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ChatUIXForms.ViewModels;
using Xamarin.Forms;

namespace ChatUIXForms.Views
{
    public partial class ChatPage : ContentPage
    {
       // public ICommand ScrollListCommand { get; set; }
        public ChatPage()
        {
            InitializeComponent();
            this.BindingContext = new ChatPageViewModel();

            //Option for scroll to the last message
            /*
            ScrollListCommand = new Command(() =>
            {
                Device.BeginInvokeOnMainThread(() =>
                  ChatList.ScrollTo((this.BindingContext as ChatPageViewModel).Messages.Last(), ScrollToPosition.End, false)
              );
            });*/
        }
    }
}
