using ChatApp.Core;
using ChatApp.MVVM.Model;
using System;
using System.Collections.ObjectModel;

namespace ChatApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }

        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }

        }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();
            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = "";
            });

            Messages.Add(new MessageModel
            {
                Username = "SomeName",
                UsernameColor = "#409aff",
                ImageSource = "https://tse1.mm.bing.net/th?id=OIP.-JYxqac14UaxnbQlv4YNAQHaHa&pid=Api",
                Message = "Test message",
                Time = DateTime.UtcNow,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "SomeName",
                    UsernameColor = "#409aff",
                    ImageSource = "https://tse1.mm.bing.net/th?id=OIP.Sd02Jhq0RoEJ4IVBWoRr_AHaE7&pid=Api",
                    Message = "Test message",
                    Time = DateTime.UtcNow,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "TestUser ",
                    UsernameColor = "#409aff",
                    ImageSource = "https://tse1.mm.bing.net/th?id=OIP.Sd02Jhq0RoEJ4IVBWoRr_AHaE7&pid=Api",
                    Message = "Test message",
                    Time = DateTime.UtcNow,
                    IsNativeOrigin = true
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "TestUser",
                UsernameColor = "#409aff",
                ImageSource = "https://tse1.mm.bing.net/th?id=OIP.Sd02Jhq0RoEJ4IVBWoRr_AHaE7&pid=Api",
                Message = "Last message",
                Time = DateTime.UtcNow,
                IsNativeOrigin = true
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"TestUser {i}",
                    ImageSource = "https://tse1.mm.bing.net/th?id=OIP.Sd02Jhq0RoEJ4IVBWoRr_AHaE7&pid=Api",
                    Messages = Messages
                });
            }
        }
    }
}
