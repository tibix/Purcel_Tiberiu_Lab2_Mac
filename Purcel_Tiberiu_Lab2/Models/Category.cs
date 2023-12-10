using System;
using System.ComponentModel.DataAnnotations;

namespace Purcel_Tiberiu_Lab2.Models
{
	public class Category
	{
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
        public ICollection<AssignedCategoryData>? AssignedCategories { get; set; }
    }
}

