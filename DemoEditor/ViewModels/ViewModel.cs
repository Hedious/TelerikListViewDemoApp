using DemoEditor.Models;
using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.DataControls.ListView;
using Telerik.XamarinForms.DataControls.ListView.Commands;

namespace DemoEditor.ViewModels
{
    public class ViewModel
    {
        public ObservableCollection<Log> Logs { get; set; }

        public ViewModel()
        {
            this.Logs = new ObservableCollection<Log>()
            {
                 new Log() { Title = "Fee", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,01,09),Amount = "9000",Number = 1}
                ,
                 new Log() { Title = "Wallet", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,01,05),Amount = "3000",Number = 1}
                ,
                 new Log() { Title = "Wallet", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,01,05),Amount = "4000",Number = 1}
                ,

                    new Log() { Title = "Pay", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,06,03),Amount = "9000",Number = 1}
                ,
                 new Log() { Title = "Wallet", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,06,12),Amount = "3000",Number = 1}
                ,
                 new Log() { Title = "Wallet", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,06,05),Amount = "4000",Number = 1}
                ,

                 new Log() { Title = "Fee", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,03,03),Amount = "9000",Number = 1}
                ,
                 new Log() { Title = "Wallet", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,03,12),Amount = "3000",Number = 1}
                ,
                 new Log() { Title = "Wallet", QrCode = "12344 1224 1333 1133",
                    LogInfoDate = new DateTime(2022,03,05),Amount = "4000",Number = 1}
                ,



            };
        }
    }

    public class GroupHeaderTapCommand : ListViewCommand
    {
        public GroupHeaderTapCommand()
        {
            Id = CommandId.GroupHeaderTap;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override void Execute(object parameter)
        {
            var context = parameter as GroupHeaderContext;
            context.IsExpanded = true;
        }
    }

}
