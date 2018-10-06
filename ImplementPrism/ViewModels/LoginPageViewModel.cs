using System;
using ImplementPrism.Models;
using ImplementPrism.Util;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace ImplementPrism.ViewModels
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        User _user;
        public User User 
        {
            get {
                return _user;
            }
            set {
                // Aqui se hace la magia
                SetProperty(ref _user, value);
            }
        }

        public DelegateCommand LoginCommand { get; set; }
        INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            User = new User();
            _navigationService = navigationService;

            LoginCommand = new DelegateCommand(async () =>
            {
                await _navigationService.NavigateAsync(Routes.MainPageRoute, null, false, true);
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();

            var isLogin = parameters["isLogin"];
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
    }
}
