using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApplication.Models
{
    [Table("test_table")]
    public class TestTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}