using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multi_view.ViewModel
{
    public class SearchVM:ViewModelBase
    {
        public ObservableCollection<string> MessageList { get; set; }
        public SearchVM()
        {
            Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();

            messenger.Register<PropertyChangedMessage<string>>(this , AddMsgToList);
            MessageList = new ObservableCollection<string>();
        }

        private void AddMsgToList(PropertyChangedMessage<string> message)
        {
            MessageList.Add(message.NewValue);
        }


    }
}
