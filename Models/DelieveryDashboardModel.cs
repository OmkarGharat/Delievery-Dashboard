using Delievery_Dashboard.ViewModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Delievery_Dashboard.Models
{
    public class DelieveryDashboardModel
    {
        [Required]
        [DisplayName("Task Description")]
        public string TaskDescription { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Complexity { get; set; }
        [Required]
        public string Resource { get; set; }
        [Required]
        public string Asset { get; set; }
        [Required]
        public string PracticeHead { get; set; }
        public string AccountManager { get; set; }
        [Required]
        public string DeliveryManager { get; set; }
        [Required]
        public string Role { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Plan Start Date")]
        public DateTime PlanStartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Plan End Date")]
        public DateTime PlanEndDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Actual Start Date")]
        public DateTime ActualStartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Actual End Date")]
        public DateTime ActualEndDate { get; set; }




    };

    //private void SortListByName (string listName)
    //{
    //    var field = Fields.FirstOrDefault(f => f.Text == listName);
    //    if (field != null)
    //    {
    //        field.Items = field.Items.OrderBy(item => item.Text == "Please Select" ? "" : item.Text).ToList();
    //    }
    //}

    //public List<DatesViewModel> Dates { get; set; }
    //}
}
