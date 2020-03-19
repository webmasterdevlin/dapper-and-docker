
using Dapper.Contrib.Extensions;

namespace DapperAndDocker.Models
{
    [Table("Item")]
    public class ItemModel
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Key]
        public int ItemId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}