using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("OrderTbl")]
    public class Order
    {
        public int Id { get; set; }
        public String? ItemCode { get; set; }
        public String? ItemName { get; set; }
        public int ItemQty { get; set; }
        public String? OrderDelivery { get; set; }
        public String? OrderAddress { get; set; }
        public String? PhoneNumber { get; set; }
    }
}
