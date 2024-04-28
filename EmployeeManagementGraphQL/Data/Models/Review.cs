using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementGraphQL.Data.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public required int Rate { get; set; }

        public required string Comment { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public required Employee Employee { get; set; }
    }
}
