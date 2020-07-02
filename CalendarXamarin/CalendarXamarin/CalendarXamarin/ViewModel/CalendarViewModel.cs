using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public class CalendarViewModel
    {
       
            public ObservableCollection<SelectionRange> SelectedRanges { get; set; }
        public CalendarViewModel()
        {
            SelectedRanges = new ObservableCollection<SelectionRange>();
            SelectedRanges.Add(new SelectionRange()
            {
                StartDate = new DateTime(2019, 09, 12),
                EndDate = new DateTime(2019, 09, 26)
            });

            SelectedRanges.Add(new SelectionRange()
            {
                StartDate = new DateTime(2019, 09, 30),
                EndDate = new DateTime(2019, 10, 04)
            });
        }
    }
}

