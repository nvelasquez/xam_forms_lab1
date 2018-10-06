using System;
using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Mvvm;

namespace ImplementPrism.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        ObservableCollection<string> _list;
        public ObservableCollection<string> List
        {
            get {
                return _list;
            }
            set {
                SetProperty(ref _list, value);
            }
        }

        public DelegateCommand AddCommand { get; set; }
        int index = 1;

        public MainPageViewModel()
        {
            List = new ObservableCollection<string>();
            AddCommand = new DelegateCommand(() => {
                List.Add("Index No: " + index);
                index++;
            });
        }
    }
}
