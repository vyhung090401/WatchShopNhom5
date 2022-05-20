using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "G-Shock", Url = "g-shock", Icon = "fas fa-watch" },
                new Category { Id = 2, Name = "Hublot", Url = "hublot", Icon = "fas fa-watch" },
                new Category { Id = 3, Name = "Rolex", Url = "rolex", Icon = "fas fa-watch" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "GST-B400D-1ADR",
                    Description = "Giới thiệu biến thể màu mới cho dòng sản phẩm của mẫu G-STEEL GST-B400 thanh mảnh với thiết kế mới, cải tiến được tạo ra nhờ mô-đun mỏng và cấu trúc bảo vệ lõi carbon. Dòng sản phẩm này có mẫu tiêu chuẩn là chiếc GST-B400D màu bạc hoàn toàn.",
                    Image = "https://casio-vietnam.com.vn/wp-content/uploads/gst-b200-1a.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "GM-2100-1A",
                    Description = "Hai đèn LED Đèn LED dành cho mặt đồng hồ (Đèn chiếu sáng cực mạnh, thời lượng chiếu sáng có thể chọn (1,5 giây hoặc 3 giây), phát sáng sau) Đèn nền LED dành cho màn hình số (Đèn chiếu sáng cực mạnh, thời lượng chiếu sáng có thể chọn (1,5 giây hoặc 3 giây), phát sáng sau)",
                    Image = "https://gshockvn.net/wp-content/uploads/GM-2100-1A_l.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "GA-2100-1A1 AP ROYAL OAK (DIAMOND)",
                    Description = "Lấy cảm hứng từ Audemars Piguet (AP), 1 trong 5 lãnh tụ của thế giới đồng hồ sa xỉ tại Thụy Sĩ. GA-2100AP là một hiện tượng đang lan nhanh trên toàn thế giới ngay tại thời điểm hiện tại.",
                    Image = "https://gshockvn.net/wp-content/uploads/272827433_1836152373246243_61879198662350425_n.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Hublot Spirit Of Big Bang 641.OM.0183.LR",
                    Description = "Đặc điểm kỹ thuật vỏ ngoài tham chiếu 641.Om.0183.Lr.Kích thước vỏ 42 mm vỏ bằng vàng 18k King được hoàn thiện và đánh bóng bằng satinBezel, gốm đen hoàn thiện,đánh bóng và thổi vi mô bới 6 vít Titan hình chữ H",
                    Image = "https://luxshopping.vn/Uploads/News/spirit-of-big-bang-641-om-0183-lr-ceramic-42.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "HUBLOT CLASSIC FUSION 582.NX.1170.RX.1704 TITANIUM 33",
                    Description = "Hình dạng trường hợp tròn, kích thước vỏ 33mm, chất liệu vỏ Titanium,màu quay số Đen,tinh thể Sapphire chống xước,bezel cố định",
                    Image = "https://luxshopping.vn/Uploads/News/hublot-classic-fusion-titanium-582-nx-1170-rx-1704-33mm.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "HUBLOT BIG BANG 441.UP.7320.NR.GIT20 MILLENNIAL PINK",
                    Description = "Đường kính 42 mm,vỏ nhôm đã hoàn thiện và đánh bóng bằng nhôm mạ kẽm màu hồng Millennial,bezel được hoàn thiện và đánh bóng bằng nhôm mạ màu hồng Millennial màu hồng",
                    Image = "https://luxshopping.vn/Uploads/News/hublot-big-bang-441-up-7320-nr-git20-millennial-pink-42mm.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Rolex Datejust 41",
                    Description = "Rolex hân hoan giới thiệu đến giới sưu tập đồng hồ sản phẩm Rolex Datejust 126331 với mặt số màu socola ma mị, cuốn hút mọi ánh nhìn.",
                    Image = "https://bizweb.dktcdn.net/100/175/988/products/rolex-datejust-41-126331.jpg?v=1638007562237",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Rolex Oyster Perpetual Datejust",
                    Description = "Nếu là một fan của đồng hồ Rolex, bạn chắc chắn sẽ nhớ đến cái tên Oyster Perpetual - bộ sưu tập mang tính chất kinh điển làm nên tên tuổi lẫy lừng của thương hiệu đồng hồ cao cấp Thụy Sĩ này.",
                    Image = "https://bizweb.dktcdn.net/100/175/988/products/m126333-0012.jpg?v=1616061649253",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "Rolex Datejust 31",
                    Description = "Là một thương hiệu đồng hồ có sức ảnh hưởng lớn trong thị trường đồng hồ cao cấp, Rolex luôn đem đến những phiên bản đồng hồ nữ thỏa mãn yêu cầu của các quý cô hiện đại.",
                    Image = "https://bizweb.dktcdn.net/100/175/988/products/dong-ho-rolex-datejust-31-278271-mat-so-vo-trai-trang.jpg?v=1619575314933",
                    DateCreated = new DateTime(2021, 1, 1)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "Medium" },
                    new Edition { Id = 3, Name = "Small" },
                    new Edition { Id = 4, Name = "Large" },
                    new Edition { Id = 5, Name = "Medium" },
                    new Edition { Id = 6, Name = "Small" },
                    new Edition { Id = 7, Name = "Large" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 9.299m,
                    OriginalPrice = 12.955m,
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 8m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 10m,
                    OriginalPrice = 14m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 5.799m,
                    OriginalPrice = 6.265m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 6.999m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 860m,
                    OriginalPrice = 880m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 400m,
                    OriginalPrice = 410m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 680m,
                    OriginalPrice = 700m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 680m,
                    OriginalPrice = 700m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 6,
                    Price = 528m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 500m,
                    
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 420m,
                    
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 5,
                    Price = 466m
                }
            );
        }
    }
}
