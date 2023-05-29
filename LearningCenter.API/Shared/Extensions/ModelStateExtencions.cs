using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LearningCenter.API.Shared.Extensions;

public static class ModelStateExtencions
{
    public static List<string> GetErrorMessage(this ModelStateDictionary dictionary)
    {
        return dictionary.SelectMany(m => m.Value.Errors)
            .Select(m => m.ErrorMessage)
            .ToList();
    }
}