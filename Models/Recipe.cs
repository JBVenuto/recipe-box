using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // public string[] Ingredients { get; set; }
        // public string[] Directions { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
    }
}