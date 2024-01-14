namespace hc_6589.Types;

[QueryType]
public static class Query
{
    [GraphQLDescription("Get Test")]
    [UsePaging(IncludeTotalCount = true, DefaultPageSize = 20, MaxPageSize = 50)]
    // Workaround: https://github.com/ChilliCream/graphql-platform/issues/6589#issuecomment-1778045257
    //[UsePaging(typeof(TestType), IncludeTotalCount = true, DefaultPageSize = 20, MaxPageSize = 50)]
    [UseProjection]
    [UseSorting(typeof(TestSortInput))]
    [UseFiltering(typeof(TestFilterInput))]
    public static IQueryable<Test> GetTests(DatabaseContext databaseContext)
    {
        return databaseContext.Tests;
    }
}
