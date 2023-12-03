using Delievery_Dashboard.ViewModel;

namespace Delievery_Dashboard.Models
{
    public class DelieveryDashboardModel
    {
        public string TaskDescription { get; set; }
        public List<FieldModel> Fields { get; set; }

        public DelieveryDashboardModel()
        {
            Fields = new List<FieldModel>
            {
                new FieldModel 
                {
                    Text = "Classification", Items = new List<ItemsModel>
                    {
                        new ItemsModel {Text = "CR", Value = "2"},
                        new ItemsModel {Text = "Incident", Value = "3"},
                        new ItemsModel {Text = "Task", Value = "4"}
                    }
                }, 
                new FieldModel 
                {
                    Text = "Complexity", Items = new List<ItemsModel>
                    {
                        new ItemsModel {Text = "Simple", Value = "2"},
                        new ItemsModel {Text = "Medium", Value = "3"},
                        new ItemsModel {Text = "Complex", Value = "4"},
                    }
                },
                new FieldModel 
                {
                    Text = "Resources", Items = new List<ItemsModel>
                    {
                        new ItemsModel {Text = "Omkar", Value = "2"},
                        new ItemsModel {Text = "Amruta", Value = "3"},
                        new ItemsModel {Text = "Harsh", Value = "4"},
                    }
                }, 
                new FieldModel 
                {
                    Text = "Asset", Items = new List<ItemsModel>
                    {
                        new ItemsModel {Text = "Easy", Value = "2"},
                        new ItemsModel {Text = "Flower", Value = "3"},
                        new ItemsModel {Text = "Savir", Value = "4"},
                        new ItemsModel {Text = "Smaraged", Value = "5"},
                        new ItemsModel {Text = "Kompass", Value = "6"},
                        new ItemsModel {Text = "KDB", Value = "7"},
                    }
                }, 
                new FieldModel 
                {
                    Text = "Practice Head", Items = new List<ItemsModel>
                    {
                        new ItemsModel {Text = "Satish", Value = "2"},
                        new ItemsModel {Text = "Dharmesh", Value = "3"},
                        new ItemsModel {Text = "Mahesh", Value = "4"},
                    }
                }, 
                new FieldModel 
                {
                    Text = "Account Manager", Items = new List<ItemsModel>
                    {
                        new ItemsModel {Text = "A", Value = "2"},
                        new ItemsModel {Text = "B", Value = "3"},
                        new ItemsModel {Text = "C", Value = "4"},
                    }
                }, 
                new FieldModel 
                {
                    Text = "Delivery Manager", Items = new List<ItemsModel>
                    {
                        new ItemsModel {Text = "Pradnya", Value = "2"},
                        new ItemsModel {Text = "Sarika", Value = "3"},
                        new ItemsModel {Text = "Sir ki Dost", Value = "4"},
                    }
                }, 
                new FieldModel 
                {
                    Text = "Role", Items = new List<ItemsModel>
                    {

                        new ItemsModel {Text = "Application Developer", Value = "2"},
                        new ItemsModel {Text = "Requirement Engineer", Value = "3"},
                        new ItemsModel {Text = "Test Engineer", Value = "4"},
                    }
                },
            };

            SortListByName("Asset");
            SortListByName("Resources");
        }

        private void SortListByName (string listName)
        {
            var field = Fields.FirstOrDefault(f => f.Text == listName);
            if (field != null)
            {
                field.Items = field.Items.OrderBy(item => item.Text == "Please Select" ? "" : item.Text).ToList();
            }
        }

        public List<DatesViewModel> Dates { get; set; }
    }
}
