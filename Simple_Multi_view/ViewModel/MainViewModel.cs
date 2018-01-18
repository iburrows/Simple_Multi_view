using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace Simple_Multi_view.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVM;

        public ViewModelBase CurrentVM
        {
            get { return currentVM; }
            set { currentVM = value; RaisePropertyChanged(); }
        }

        public RelayCommand SearchBtn { get; set; }
        public RelayCommand AddBtn { get; set; }

        public MainViewModel()
        {
            SearchBtn = new RelayCommand(()=> 
            {
                CurrentVM = SimpleIoc.Default.GetInstance<SearchVM>();
            });
            AddBtn = new RelayCommand(()=> 
            {
                CurrentVM = SimpleIoc.Default.GetInstance<AddVM>();
            });
        }
    }
}