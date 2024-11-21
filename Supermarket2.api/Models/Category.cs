using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Supermarket2.api.Models
{
    public class Category
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [JsonIgnore]

        public required ICollection<Product> Products { get; set; }
    }

}

