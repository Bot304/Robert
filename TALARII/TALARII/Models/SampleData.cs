using System.Numerics;

namespace TALARII.Models
{
    public class SampleData
    {
        public static void Initialize(Context context)
        {
            if (!context.Models.Any())
            {
                context.Models.AddRange(
                    new Model
                    {
                        Name = "YEEZY BOOST 700 v2",
                        Brand = "Adidas",
                        Link = "https://st.bmshop.net/itro10671/product/m/krossovki-adidas-yeezy-boost-700-v2-1-5f74ca24622ae.jpg",
                        Price = 5990
                    },
                    new Model
                    {
                        Name = "YEEZY BOOST 700",
                        Brand = "Adidas",
                        Link = "https://st.bmshop.net/itro10671/product/m/krossovki-adidas-yeezy-boost-700-1-5fdbdc9b32fc2.jpg",
                        Price = 6990
                    }, new Model
                    {
                        Name = "YEEZY BOOST 700 MNVN \"Bone\"",
                        Brand = "Adidas",
                        Link = "https://in-styleshop.com/image/cache/catalog/temp/ge-data-tovar-Adidas-Yeezy-Boost-700v3-unisex-6-1-6-500x800.jpg",
                        Price = 8990
                    }, new Model
                    {
                        Name = "YEEZY BOOST 700 v3",
                        Brand = "Adidas",
                        Link = "https://lionsneakers.ru/image/cache/catalog/products/18665/Adidas-krossovki-Adidas-Yeezy-Boost-700-v3-1-1000x750.jpg",
                        Price = 7990
                    }, new Model
                    {
                        Name = "YEEZY BOOST 700 WaveRunner",
                        Brand = "Adidas",
                        Link = "https://onthestreet.ru/image/cache/catalog/katalog1/79f/IMG79f68ea971fe15479085bcd19b83f113-500x375.jpg",
                        Price = 6990
                    }
                );

                

                context.SaveChanges();
            }
        }
    }
}
