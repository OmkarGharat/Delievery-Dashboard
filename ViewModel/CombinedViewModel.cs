using Delievery_Dashboard.Models;

namespace Delievery_Dashboard.ViewModel
{
    public class CombinedViewModel
    {
        public CombinedViewModel()
        {
            DelieveryDashboard = new DelieveryDashboardModel();
            TextBox = new TextBoxViewModel();
        }
        public DelieveryDashboardModel DelieveryDashboard { get; set; }
        public TextBoxViewModel TextBox { get; set; }
        //public List<DatesViewModel> Dates { get; set; }

    }
}
