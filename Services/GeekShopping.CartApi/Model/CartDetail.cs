using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.CartApi.Model.Base;

namespace GeekShopping.CartApi.Model
{
    [Table("cart_details")]
    public class CartDetail : BaseEntity
    {
        public long? CartHeaderId { get; set; }

        [ForeignKey("CartHeaderId")]
        public virtual CartHeader? CartHeader { get; set; }

        public long? ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }

        [Column("count")]
        public int? Count { get; set; }
    }
}