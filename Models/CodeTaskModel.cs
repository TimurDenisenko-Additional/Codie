using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codie.Models
{
    [Table("CodeTasks")]
    public class CodeTaskModel
    {
        [Key]
        public int Id { get; set; }
        public string Task { get; set; }
        public string Code { get; set; }
        public string Tests { get; set; }
    }
}