using System.Collections.Generic;

namespace TreeViewMVVMBinding
{

    public class MainWindowViewModel : ViewModelBase
    {
        private List<Client> clients;

        public MainWindowViewModel()
        {
            Clients = new List<Client>()
                {
                    new Client("Macter"),
                    new Client("PakArab")
                };
        }

        public List<Client> Clients
        {
            get
            {
                return clients;
            }
            set
            {
                clients = value;
                OnPropertyChanged("Client");
            }
        }
    }
}