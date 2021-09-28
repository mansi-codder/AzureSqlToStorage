using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSqlToStorage.Models
{
    public class Dish
    {
        public int DishID { get; set; }

        public string DishName { get; set; }
        public decimal Rating { get; set; }

        public string DishImage { get; set; }
    }
}
