using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{
    [Table("Marca")]
    public class Marca{
        [Key]
        public int id { get; set; }

        public string? nome { get; set; }

        public string? descricao { get; set; }
    }
}