using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using TworzenieAplikacjiBiznesowychATP.Messages;

namespace TworzenieAplikacjiBiznesowychATP.ViewModel
{

    public class PersonListViewModel : ViewModelBase
    {  
        public ObservableCollection<Person> People { get; set; }
        public PersonListViewModel()
        {
            People = new ObservableCollection<Person>();
            Messenger.Default.Register<PersonAddedMessage>(this, (arg) => AddPerson(arg.Person));
        }

        private void AddPerson(Person person)
            => People.Add(person);
         
    }
}