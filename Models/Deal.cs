namespace TreeViewMVVMBinding
{
    //Deals
    public class Deal : ViewModelBase
    {
        private string _strDeal = string.Empty;
        public string DealName
        {
            get
            {
                return _strDeal;
            }
            set
            {
                _strDeal = value;
                OnPropertyChanged("DealName");
            }
        }

        public Deal(string dealname)
        {
            DealName = dealname;
        }
    }
}