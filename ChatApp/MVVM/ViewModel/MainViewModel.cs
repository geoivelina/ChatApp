using ChatApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.MVVM.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "SomeName",
                UsernameColor = "#409aff",
                ImageSource = "https://tse1.mm.bing.net/th?id=OIP.dtqKdwsdEUpJauqb0Z4f_QHaJj&pid=Api",
                Message = "Test message",
                Time = DateTime.UtcNow,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "TestUser",
                    UsernameColor = "#409aff",
                    ImageSource = "https://tse1.mm.bing.net/th?id=OIP.dtqKdwsdEUpJauqb0Z4f_QHaJj&pid=Api",
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
                    ImageSource = "https://tse1.mm.bing.net/th?id=OIP.dtqKdwsdEUpJauqb0Z4f_QHaJj&pid=Api",
                    Message = "Test message",
                    Time = DateTime.UtcNow,
                    IsNativeOrigin = true
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "TestUser",
                UsernameColor = "#409aff",
                ImageSource = "https://tse1.mm.bing.net/th?id=OIP.dtqKdwsdEUpJauqb0Z4f_QHaJj&pid=Api",
                Message = "Last message",
                Time = DateTime.UtcNow,
                IsNativeOrigin = true
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"TestUser {i}",
                    ImageSource = "https://tse1.mm.bing.net/th?id=OIP.dtqKdwsdEUpJauqb0Z4f_QHaJj&pid=Api",
                    Messages = Messages
                });
            }
        }
    }
}
