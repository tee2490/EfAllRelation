namespace EfAllRelation.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; } 

        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
