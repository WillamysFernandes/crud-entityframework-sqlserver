namespace Blog.Models
{
    public class Produto
    {
        public int id { get; set; }
        public int id_marca { get; set; }
        public string? nome { get; set; }
        public double preco { get; set; }
        public string? fotos { get; set; }
        public int categoria { get; set; }
    }

}