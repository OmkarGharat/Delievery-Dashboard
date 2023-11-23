using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Delievery_Dashboard.ViewModel
{
    public class TextBoxViewModel
    {
        [Required] [MinLength(8)] [MaxLength(8)]
        public int UID { get; set; }
        [Required] [DisplayName("Task ID")]
        public int Task_ID { get; set; }
        [Required]
        [DisplayName("Number Of Defects - IND")]
        public int NumberOfDefects { get; set; }
        [Required] [DisplayName("Number of Defects - DE")]
        public int NumberOfDefectsDE { get; set; }
    }
}
