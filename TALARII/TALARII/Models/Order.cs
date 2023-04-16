using System.Numerics;

namespace TALARII.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string User { get; set; } // имя фамилия покупателя
        public string Address { get; set; } // адрес покупателя
        public string ContactPhone { get; set; } // контактный телефон покупателя

        public int BasketId { get; set; } // ссылка на связанную модель Basket
        public Basket Basket { get; set; }
    }
}
