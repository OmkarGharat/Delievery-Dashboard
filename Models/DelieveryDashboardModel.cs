namespace Delievery_Dashboard.Models
{
    public class DelieveryDashboardModel
    {
        public string UID { get; set; }
        public string TaskId { get; set; }
        public string TaskDescription { get; set; }

        public DelieveryDashboardModel() 
        {
            Classification = new List<Items>
            {
                new Items {Text = "Select the Value", Value = "1"},
                new Items {Text = "CR", Value = "2"},
                new Items {Text = "Incident", Value = "3"},
                new Items {Text = "Task", Value = "4"}
            };
        }

        public List<Items> Classification { get; set; }
    }
}
