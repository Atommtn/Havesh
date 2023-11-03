using System.Reflection;

namespace HaveshApp.Admin.DashboardManagement.WidgetResolvers;

public static class ResolverDiscovery
{
    public static List<Type> DiscoverResolverTypes()
    {
        // Get the current assembly (or the assembly where your resolvers are defined)
        var currentAssembly = Assembly.GetExecutingAssembly();

        // Find all types in the assembly that derive from WidgetResolver
        var types = currentAssembly
            .GetTypes();

        var resolverTypes = types
            .Where(type => type.IsSubclassOf(typeof(WidgetResolver)))
            .ToList();

        return resolverTypes;
    }
}
