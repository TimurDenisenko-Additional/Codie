using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codie.Models
{
    [Table("SingleChoise")]
    public class SingleChoiseModel
    {
        [Key]
        public int Id { get; set; }
        public string Statement { get; set; }
        public string Options { get; set; }
    }
}