using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitproject.Models
{
    public class IngredientsModel
    {
        public int ID { get; set; }
        public string IngredientName { get; set; }
        public int Calories { get; set; }

        public int Protiens { get; set; }
        public int Carbohydrates { get; set; }
        public int Fats { get; set; }

        public IngredientsModel(int iD, string Name, int cal, int carbs, int pro, int fats)
        {
            ID = iD;
            IngredientName = Name;
            Calories = cal;
            Carbohydrates = carbs;
            Protiens = pro;
            Fats = fats;
        }
    }

    public class IngredientData
    {
        public List<IngredientsModel> Ingredients;

        public IngredientData()
        {
            Ingredients = new List<IngredientsModel>();

            Ingredients.Add(new IngredientsModel(1, "Chicken", 284, 53, 0, 6));
        }
    }
}
