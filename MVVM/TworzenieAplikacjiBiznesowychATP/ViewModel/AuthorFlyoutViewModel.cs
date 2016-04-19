using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TworzenieAplikacjiBiznesowychATP.Messages;

namespace TworzenieAplikacjiBiznesowychATP.ViewModel
{
    public class AuthorFlyoutViewModel : ViewModelBase
    {
        private bool isOpen;

        public AuthorFlyoutViewModel()
        {
            Messenger.Default.Register<FlyoutOpenedMessage>(this, (arg) => IsOpen = true);
        }
        public bool IsOpen
        {
            get { return isOpen; }
            set { Set(() => IsOpen, ref isOpen, value); }
        }

    }
}
