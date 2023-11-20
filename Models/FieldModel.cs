using Microsoft.AspNetCore.Server.IIS.Core;

namespace Delievery_Dashboard.Models
{
    public class FieldModel
    {
        public string Text { get; set; }
        public List<ItemsModel> Items { get; set; }
    }
}

