using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository :IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
          new List<Pie>
          {
                new Pie{PieId = 1, Name = "Fruit Pies", Price = 15.95M, ShortDescription = "All-fruits"},
                new Pie{PieId = 2, Name = "Cheese Cakes", Price = 15.95M, ShortDescription = "Cheesy all the way"},
                new Pie{PieId = 3, Name = "Seasonal Pies", Price = 15.95M, ShortDescription = "Get in the mood for a seasonal pie"}
          };


        public IEnumerable<Pie> PiesOfTheWeek { get; }


        public Pie GetPieById(int pieId)
        {
           
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
