using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDemoApp.Model
{
    [Table("tb_produto")]
    public class Product
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public string phone { get; set; }
        public string price { get; set; }
    }
}
