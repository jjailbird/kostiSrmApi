using System;
namespace kostiSrmApi.Models
{
    public class ResourceImage
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public bool IsFeature { get; set; }

        public int ResourceItemId { get; set; }
    }
}
