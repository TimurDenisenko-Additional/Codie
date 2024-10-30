
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codie.Models
{
    [Table("Materials")]
    public class MaterialModel
    {
        [Key]
        public int Id { get; set; }
    }
}