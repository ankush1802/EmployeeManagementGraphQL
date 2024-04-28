using GraphQL.Types;

namespace EmployeeManagementGraphQL.GraphQL.Types
{
    public class EmployeeInputType : InputObjectGraphType
    {
        public EmployeeInputType()
        {
            Name = "EmployeeInputType";
            Field<StringGraphType>("FirstName");
            Field<StringGraphType>("LastName");
            Field<StringGraphType>("Email");
            //Adding Reviews for Employee Object
            Field<ListGraphType<ReviewInputType>>("Reviews");
        }
    }
}
