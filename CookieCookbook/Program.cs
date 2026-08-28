using System;
using System.Collections.Generic;
using CookieCookbook.Recipes;

var cookiesRecipresApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipresConsoleUserInteraction());

cookiesRecipresApp.Run("recipes.txt");

public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository = new (); 
    private readonly IRecipesUserInteraction _recipesUserInteraction ;

    public CookiesRecipesApp(
        IRecipesRepository recipesRepository,
        RecipresConsoleUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }


    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesConsoleUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesConsoleUserInteraction.PromtToCreateRecipe();

        var ingredients = _recipesConsoleUserInteraction.ReadIngredientsFromUser();
        if(ingredients.Count > 0)
        {
            var recipes = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesConsoleUserInteraction.ShowMessage("Recipe added: ");
            _recipesConsoleUserInteraction.ShowMessage(recipes.ToString());



        }
        else
        {
            _recipesConsoleUserInteraction.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved. ");
        }
        _recipesConsoleUserInteraction.Exit();
    }
}

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
}

public class RecipresConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
       if(allRecipes.Count() > 0)
        {
            
        }
    }
}

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}
public class RecipesRepository : IRecipesRepository
{
    public List<Recipe> Read(string filePath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Butter(),
                new Sugar()
            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(),
                new SpeltFlour(),
                new Cinnamon()
            })
        };
    }
}
