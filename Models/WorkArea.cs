using System.Collections.Generic;

namespace TreeViewMVVMBinding
{
    public class WorkArea : ViewModelBase
    {
        //WorkAreas
        private List<Deal> deals;

        public WorkArea(string workareaname)
        {
            WorkAreaName = workareaname;
            deals = new List<Deal>()
                {
                    new Deal("Sourcing"),
                    new Deal("Inspection and Ordering"),
                    new Deal("Installation")
                };
        }

        public List<Deal> Deals
        {
            get
            {
                return deals;
            }
            set
            {
                deals = value;
                OnPropertyChanged("Deal");
            }
        }

        public string WorkAreaName
        {
            get;
            set;
        }
    }
}
