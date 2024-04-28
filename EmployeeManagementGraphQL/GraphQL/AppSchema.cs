using EmployeeManagementGraphQL.GraphQL.Mutations;
using EmployeeManagementGraphQL.GraphQL.Queries;
using GraphQL.Types;

namespace EmployeeManagementGraphQL.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(EmployeeQuery query,EmployeeMutation mutation)
        {
            this.Query = query;
            this.Mutation = mutation;
        }
    }
}
