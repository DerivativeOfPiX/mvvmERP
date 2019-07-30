using System.Collections.Generic;


namespace TreeViewMVVMBinding
{
    //Clients
    public class Client : ViewModelBase
    {
        private List<WorkArea> workareas;

        public Client(string clname)
        {
            ClientName = clname;
            workareas = new List<WorkArea>()
                {
                    new WorkArea("Construction"),
                    new WorkArea("Machines Purchasing")
                };
        }
        public List<WorkArea> WorkAreas
        {
            get
            {
                return workareas;
            }
            set
            {
                 workareas = value;
                OnPropertyChanged("WorkArea");
            }
        }
        public string ClientName
        {
            get;
            set;
        }
    }
}