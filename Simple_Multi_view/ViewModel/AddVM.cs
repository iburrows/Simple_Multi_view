using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multi_view.ViewModel
{
    public class AddVM:ViewModelBase
    {
        
        public RelayCommand SendBtn { get; set; }
        public string Message { get; set; }

        Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();
        public AddVM()
        {
            SendBtn = new RelayCommand(()=> 
            {
                messenger.Send<PropertyChangedMessage<string>>(new PropertyChangedMessage<string>(null, Message, ""));
            });
        }
    }
}
