using mudblazor_augcenter.Models;

namespace mudblazor_augcenter.Data
{
    public class ProductsInit
    {
        public List<Product> Products { get; set; }

        public ProductsInit()
        {
            this.Products = this.listInitProducts();
        }

        private List<Product> listInitProducts()
        {
            return new List<Product>(){
                    new Product
                    {
                        ProductId = 1,
                        ProductSku = "TABL002",
                        ProductName = "Máy tính bảng HANET SMART EDU T432P",
                        ProductPrice = decimal.Parse("3950000"),
                        ProductCartDesc = "Tablet Hanet",
                        ProductShortDesc = "Máy tính bảng HANET SMART EDU T432P giá ƯU ĐÃI",
                        ProductLongDesc = "- CPU Quad Core 2.0<br/>- Màn hình 10.1inch IPS<br/>- Ram: 4GB<br/>- Dung lượng lưu trữ: 32GB<br/>- Độ phân giải camera chính: 8MP<br/>- Loại cáp điện thoại: Type C<br/>- Dung lượng pin: 5000mAh<br/>- Loại bảo hành: Bảo hành nhà sản xuất<br/>- Hạn bảo hành: 12 tháng",
                        ProductThumb = string.Empty,
                        ProductImage = "/Img/Products/2/Hanet-Tablet-T432P.png",
                        ProductStock = 50,
                        ProductLive = true,
                        ProductUnlimited = true,
                        ProductLocation = "Rạch Giá - Kiên Giang",
                        CategoryId = 4,
                        TimestampId = 1
                    },
                    new Product
                    {
                        ProductId = 2,
                        ProductSku = "PC00001",
                        ProductName = "PC Gaming - Augcenter(Tặng Phím & Chuột Gaming",
                        ProductPrice = decimal.Parse("5800000"),
                        ProductCartDesc = "AugCenter building",
                        ProductShortDesc = "PC Gaming - Augcenter(Tặng Phím & Chuột Gaming) giá ƯU ĐÃI",
                        ProductLongDesc = "- Main H61 Samsung<br/>- Core i5 2400<br/>- Ram 8G<br/>- SSD 120GB<br/>- VGA 7730 2G D5<br/>- PSU Jetek 320W<br/>- Màn 19in Compaq<br/>- Tặng Phím Chuột Gaming<br/>- Bảo hành 12 tháng",
                        ProductThumb = string.Empty,
                        ProductImage = "/Img/Products/3/PC-Gaming-Augcenter.png",
                        ProductStock = 50,
                        ProductLive = true,
                        ProductUnlimited = true,
                        ProductLocation = "Rạch Giá - Kiên Giang",
                        CategoryId = 3,
                        TimestampId = 2
                    },
                    new Product
                    {
                        ProductId = 3,
                        ProductSku = "CMR0001",
                        ProductName = "Camera IPC-A22EP-D-IMOU (Kèm Thẻ Nhớ 32GB)",
                        ProductPrice = decimal.Parse("848000"),
                        ProductCartDesc = "Camera IMOU",
                        ProductShortDesc = "CAMERA IMOU IPC-A22EP tặng kèm thẻ nhớ 32gb giá ƯU ĐÃI",
                        ProductLongDesc = "- Đàm thoại 2 chiều<br/>- Hỗ trợ PTZ xoay 360 độ<br/>- Độ phân giải FullHD 1080P và chuẩn nén H265<br/>- Bảo hành 12 tháng",
                        ProductThumb = string.Empty,
                        ProductImage = "/Img/Products/4/Camera-IPC-A22EP-D-IMOU.png",
                        ProductStock = 50,
                        ProductLive = true,
                        ProductUnlimited = true,
                        ProductLocation = "Rạch Giá - Kiên Giang",
                        CategoryId = 4,
                        TimestampId = 3
                    },
                    new Product
                    {
                        ProductId = 4,
                        ProductSku = "CMR0001",
                        ProductName = "Camera quan sát IPC-F22P Imou + Thẻ nhớ 32GB",
                        ProductPrice = decimal.Parse("1119000"),
                        ProductCartDesc = "Camera IMOU",
                        ProductShortDesc = "Camera quan sát IPC-F22P Imou tặng kèm thẻ nhớ 32gb giá ƯU ĐÃI",
                        ProductLongDesc = "- Độ phân giải 2 Megapixel CMOS 1/2.7”<br/>- Chuẩn hình ảnh H265. Chế độ ngày đêm(ICR)<br/>- Tích hợp micro với chuẩn âm thanh G.711a / G.711u / PCM<br/>- Hỗ trợ khe cắm thẻ nhớ Micro<br/>- Chất liệu vỏ plastic<br/>- Bảo hành 12 tháng",
                        ProductThumb = string.Empty,
                        ProductImage = "/Img/Products/4/Camera-quan-sat-IPC-F22P-Imou.png",
                        ProductStock = 50,
                        ProductLive = true,
                        ProductUnlimited = true,
                        ProductLocation = "Rạch Giá - Kiên Giang",
                        CategoryId = 4,
                        TimestampId = 4
                    },
                    new Product
                    {
                        ProductId = 5,
                        ProductSku = "TABL001",
                        ProductName = "Lenovo Tab M8 LTE CA Iron Grey 2G + 32GB",
                        ProductPrice = decimal.Parse("3190000"),
                        ProductCartDesc = "Tablet Lenovo",
                        ProductShortDesc = "Lenovo Tab M8 LTE CA Iron Grey 2G + 32GB giá ƯU ĐÃI",
                        ProductLongDesc = "- CPU: MediaTek* Helio A22 Tab<br/>- Display: 8.0inch 1280*800 IPS<br/>- WLAN: 802.11 A,B,G,N,AC<br/>- BT 5.0/ OS: Android 10.0<br/>- Battery: 5100mAh<br/>- Bảo hành 12 tháng",
                        ProductThumb = string.Empty,
                        ProductImage = "/Img/Products/2/Lenovo-tab-m8.png",
                        ProductStock = 50,
                        ProductLive = true,
                        ProductUnlimited = true,
                        ProductLocation = "Rạch Giá - Kiên Giang",
                        CategoryId = 2,
                        TimestampId = 5
                    },
                    new Product
                    {
                        ProductId = 6,
                        ProductSku = "CMR0002",
                        ProductName = "Camera IP Wifi Ezviz TY2 1080P (Kèm Thẻ Nhớ 32GB)",
                        ProductPrice = decimal.Parse("889000"),
                        ProductCartDesc = "Camera Ezviz TY2",
                        ProductShortDesc = "Camera IP Wifi Ezviz TY2 1080P tặng kèm thẻ nhớ 32gb giá ƯU ĐÃI",
                        ProductLongDesc = "- Độ phân giải: 1080p full HD<br/>- Góc quay: chéo 85 độ, ngang 75 độ, dọc 45 độ<br/>- Hồng ngoại phạm vi: 10m<br/>- Có hổ trợ thu âm. Kết nối mạng wifi<br/>- Bảo hành 12 tháng",
                        ProductThumb = string.Empty,
                        ProductImage = "/Img/Products/4/Camera-IP-Wifi-Ezviz-TY2-1080P.png",
                        ProductStock = 50,
                        ProductLive = true,
                        ProductUnlimited = true,
                        ProductLocation = "Rạch Giá - Kiên Giang",
                        CategoryId = 4,
                        TimestampId = 6
                    }
                };
        }
    }
}