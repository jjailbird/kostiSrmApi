using System;
namespace kostiSrmApi.Models
{
    public class ResourceItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ResourceTypeid { get; set; }
    }
}
