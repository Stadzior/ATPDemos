using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Windows;
using System.Windows.Input;
using TworzenieAplikacjiBiznesowychATP.Messages;

namespace TworzenieAplikacjiBiznesowychATP.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            AddPersonCommand = new RelayCommand(() => ShowWelcomeWindow());
            OpenFlyoutCommand = new RelayCommand(() => OpenFlyout());
        }

        private string personName;
        public string PersonName
        {
            get
            {
                return personName;
            }
            set
            {
                Set(() => PersonName, ref personName, value);
            }
        }

        private string personSurname;

        public string PersonSurname
        {
            get { return personSurname; }
            set { Set(() => PersonSurname, ref personSurname, value); }
        }


        public ICommand AddPersonCommand { get; set; }
        public ICommand OpenFlyoutCommand { get; set; }

        private void OpenFlyout()
        {
            Messenger.Default.Send(new FlyoutOpenedMessage());       
        }

        private void ShowWelcomeWindow()
        {
            string userName = PersonName;
            string userSurname = PersonSurname;
            var person = new Person();
            person.Name = userName;
            person.Surname = userSurname;

            Messenger.Default.Send(new PersonAddedMessage() { Person = person });

            MessageBox.Show("Witaj " + person.Name + " " + person.Surname);

            PersonName = string.Empty;
            PersonSurname = string.Empty;
        }
    }
}