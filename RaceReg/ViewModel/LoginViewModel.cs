﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using RaceReg.Helpers;
using System.Collections.Generic;
using System.Text;

namespace RaceReg.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private PasswordRelayCommand loginCommand;
        public PasswordRelayCommand LoginCommand => loginCommand ?? (loginCommand = new PasswordRelayCommand(Login));

        private PasswordRelayCommand createAccountCommand;
        public PasswordRelayCommand CreateAccountCommand => createAccountCommand ?? (createAccountCommand = new PasswordRelayCommand(Login));

        private RelayCommand exitCommand;
        public RelayCommand ExitCommand => exitCommand ?? (exitCommand = new RelayCommand(
            () =>
            {
                Console.WriteLine("Program is closing now.");

                //Clean up program here!!

                Environment.Exit(0);
            }
            ));

        private RelayCommand aboutCommand;
        public RelayCommand AboutCommand => aboutCommand ?? (aboutCommand = new RelayCommand(
            () =>
            {
                throw new NotImplementedException();
            }
            ));

        private void Login(object parameter)
        {
            var passwordContainer = parameter as IHavePassword;
            if(passwordContainer != null)
            {
                var secureString = passwordContainer.Password;
                //Do stuff with the password
            }

            //Change to Managment View

            throw new NotImplementedException();
        }
    }
}