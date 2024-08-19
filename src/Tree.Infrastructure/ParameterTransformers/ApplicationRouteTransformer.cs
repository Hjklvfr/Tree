using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace Tree.Infrastructure.ParameterTransformers;

public partial class ApplicationRouteTransformer : DynamicRouteValueTransformer
{
    [GeneratedRegex("(?<!^)([A-Z])")]
    private static partial Regex DotSeparateRegex();
    
    public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
    {
        var newValues = new RouteValueDictionary();

        foreach (var key in values.Keys)
        {
            if (key.Equals("action", StringComparison.OrdinalIgnoreCase) && values[key] is string actionName)
            {
                newValues[key] = ToCamelCase(actionName);
            }
            else if (key.Equals("controller", StringComparison.OrdinalIgnoreCase) && values[key] is string controllerName)
            {
                newValues[key] = DotSeparateRegex().Replace(controllerName, ".$1").ToLower();
            }
            else
            {
                newValues[key] = values[key];
            }
        }

        return new ValueTask<RouteValueDictionary>(newValues);
    }

    private static string ToCamelCase(string input)
    {
        if (string.IsNullOrEmpty(input) || !char.IsUpper(input[0]))
            return input;

        var camelCase = char.ToLowerInvariant(input[0]).ToString();
        if (input.Length > 1)
        {
            camelCase += input[1..];
        }

        return camelCase;
    }
}