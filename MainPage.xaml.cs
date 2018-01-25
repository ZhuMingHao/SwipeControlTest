using SwipeControlTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SwipeControlTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ViewModel viewmodel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new ViewModel();
            viewmodel = this.DataContext as ViewModel;
        }

        private int i = 0;

        private void UpdateCountCommand_CanExecuteChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(i++);
        }

        public ObservableCollection<SampleModel> list = new ObservableCollection<SampleModel>();

        private void DeleteItem_ItemInvoked(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {
        }

        private void Flag_ItemInvoked(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {
        }

        private void Accept_ItemInvoked(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {
        }

        private void swipe_Invoked(SwipeItem sender, SwipeItemInvokedEventArgs args)
        {
        }
    }
}