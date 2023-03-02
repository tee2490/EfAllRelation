using System.ComponentModel.DataAnnotations.Schema;

namespace EfAllRelation.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
