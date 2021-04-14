using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipeBox.Data;
using System;
using System.Linq;

namespace RecipeBox.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipeBoxContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RecipeBoxContext>>()))
            {
                // Look for any movies.
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }

                context.Recipe.AddRange(
                    new Recipe
                    {
                        Title = "Marinara",
                        Ingredients = "28 oz can San Marzano tomatoes, 1/4 cup olive oil, 7 cloves garlic, 1/4 tsp crushed red pepper, 1 tsp salt, 1/4 tsp dried oregano, 1/4 tsp dried basil ",
                        Directions = "Crush tomatoes in large bowl. Use 1/2 cup water to get tomato juices out. Heat oil on medium, add garlic. Add tomatoes once garlic is sizzling. Add Tomato water and seasonings. Simmer until done ~ 60 minutes."
                    },

                    new Recipe
                    {
                        Title = " Pizza dough ",
                        Ingredients = " 2 1/2 cups warm water, 1 TBSP sugar, 1 tsp yeast, 2 tbs olive oil, 1 TBSP salt, 5 cups bread flour ",
                        Directions = " Combine water, sugar, and yeast in a large bowl. Let sit for a few minutes. Add the olive oil, salt and bread flour. Kneed until you can stretch the dough into a thin sheet without it tearing. Divide the dough into 3 equal balls and put in the fridge for at least 24 hours to cold proof. "
                    }
                );
                context.SaveChanges();
            }
        }
    }
}