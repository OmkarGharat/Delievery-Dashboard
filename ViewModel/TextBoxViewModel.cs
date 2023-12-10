using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Delievery_Dashboard.ViewModel
{
    public class TextBoxViewModel
    {
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "UID must be exactly 8 digits.")]
        public int? UID { get; set; }
        [Required] 
        [DisplayName("Task ID")]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "Task ID can only include alphabets, numbers, underscores, and hyphens.")]
        public string TaskID { get; set; }

        //public TextBoxViewModel()
        //{
        //    var TextBox = new TextBoxViewModel();
        //}


        //[Required]
        //[DisplayName("Number Of Defects - IND")]
        //public int NumberOfDefects { get; set; }
        //[Required] [DisplayName("Number of Defects - DE")]
        //public int NumberOfDefectsDE { get; set; }
    }
}



