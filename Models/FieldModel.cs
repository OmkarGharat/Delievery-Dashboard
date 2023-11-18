using Microsoft.AspNetCore.Server.IIS.Core;

namespace Delievery_Dashboard.Models
{
    public class FieldModel
    {
        public string Text { get; set; }
        public List<ItemsModel> Items { get; set; }

        //public FieldModel()
        //{
        //    Items = new List<ItemsModel>();
        //    //Items.Sort();
        //    SortItems();
        //}
        //private void SortItems()
        //{
        //    if (Items.Count > 0)
        //        Items = Items.OrderBy(x => x.Text).ToList();
        //}
    }
}

