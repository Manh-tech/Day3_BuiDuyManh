using Day3_BuiDuyManh.Models;

namespace Day3_BuiDuyManh.Data
{
    public class SeedData
    {
        //gia lap du lieu ban dau cho databas

        public static List<Category> categories = new List<Category>()
        {


                new Category() { Id = 1, Name = "Category 1", Description = "Description for Category 1" },
                new Category() { Id = 2, Name = "Category 2", Description = "Description for Category 2" },
                new Category() { Id = 3, Name = "Category 3", Description = "Description for Category 3" }

        };
    }
}
