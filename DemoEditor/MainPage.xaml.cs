using DemoEditor.Models;
using DemoEditor.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace DemoEditor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listView.BindingContext = new ViewModel();
            listView.Commands.Add(new GroupHeaderTapCommand());

            var delegateDescriptor = new DelegateGroupDescriptor
            {
                KeyExtractor = FirstLetterKeyExtractor,
                //SortOrder = SortOrder.Descending,
            };

            listView.GroupDescriptors.Add(delegateDescriptor);
            listView.SortDescriptors.Add(new Telerik.XamarinForms.DataControls.ListView.
                PropertySortDescriptor { PropertyName = "LogInfoDate", SortOrder = SortOrder.Descending });
        }


     
        private object FirstLetterKeyExtractor(object arg)
        {
            var item = arg as Log;
            return item?.FormatDateForGp;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
          
        }
    }
}
