using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TimeLine
{
    public class MainViewModel
    {
        public List<DateTime> DatesSource;
        public MainViewModel()
        {
            DatesSource = FakeTimes();

        }

        private static List<DateTime> FakeTimes()
        {
            var list = new List<DateTime>
            {
                new DateTime(2016,3,2),
                new DateTime(2017,10,2),
                new DateTime(2017,12,25),
                new DateTime(2018,3,12),
                new DateTime(2018,11,4),
                new DateTime(2017,12,25),
                new DateTime(2018,1,3),
                new DateTime(2018,3,3),
                new DateTime(2018,8,9),
                new DateTime(2016,11,11),
                new DateTime(2018,10,15),
                new DateTime(2018,8,29),
                new DateTime(2017,12,25),
                new DateTime(2018,10,3),
                new DateTime(2018,10,22),
                new DateTime(2018,11,8),
                new DateTime(2016,6,7),
                new DateTime(2018,11,22),
            };
            return list;
        }
    }
    public class LeftOrRightCardSelector : DataTemplateSelector
    {
        public DataTemplate LeftCardTemplate { get; set; }
        public DataTemplate RightCardTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var dataObject = (DateTime) item;

            if (dataObject.Year == 2018)
            {
                return LeftCardTemplate;

            }

            return RightCardTemplate;
        }
    }
}
