
namespace DIMVC.DbClasses
{
    public partial class Category
    {
        public int Id { get; set; }
        public int? ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Category ParentCategory { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> ChildCategories { get; set; }
    }
}
