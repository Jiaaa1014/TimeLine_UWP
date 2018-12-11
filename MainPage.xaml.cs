using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TimeLine
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var item = TimeLv.Items.Where(date => (DateTime) date == new DateTime(2018, 11, 22)).ToList();
            TimeLv.ScrollIntoView((DateTime)item.FirstOrDefault());
            TimeLv.SelectedItem = item;
        }
    }    
}
