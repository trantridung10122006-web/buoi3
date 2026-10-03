using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedKitchenExpressData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                columns: new[] { "BrandName", "Description" },
                values: new object[] { "Chinsu / Omachi", "Thương hiệu gia vị và thực phẩm ăn liền nổi tiếng" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                columns: new[] { "BrandName", "Description" },
                values: new object[] { "Dutch Lady / Cô Gái Hà Lan", "Các sản phẩm sữa tươi và sữa chua dinh dưỡng" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                columns: new[] { "BrandName", "Description" },
                values: new object[] { "Hoàng Dung Selected", "Thực phẩm khô và nông sản đóng gói nội bộ bách hóa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh kẹo & Đồ ăn vặt", "Snack, bánh quy, kẹo dẻo, sô-cô-la" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nước giải khát & Trà", "Nước ngọt, nước khoáng, trà đóng chai, nước ép" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sữa & Sản phẩm từ sữa", "Sữa tươi, sữa đặc, sữa chua, phô mai" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Mì gói & Thực phẩm ăn liền", "Mì ăn liền, phở khô, hủ tiếu, cháo gói" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Gia vị & Dầu ăn", "Nước mắm, hạt nêm, dầu ăn, xì dầu, bột ngọt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Gạo & Nông sản khô", "Gạo ST25, đậu xanh, đậu đen, mộc nhĩ, nấm hương" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ đóng hộp & Chế biến sẵn", "Cá hộp, thịt xông khói, xúc xích, pate" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Hóa mỹ phẩm & Giặt xả", "Nước giặt, nước xả vải, nước rửa chén, lau sàn" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Chăm sóc cá nhân", "Dầu gội, sữa tắm, kem đánh răng, xà phòng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thực phẩm đông lạnh", "Cá viên, bò viên, xúc xích đức, chả giò, bánh xếp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Kem & Đồ lạnh", "Kem que, kem hộp, đá viên đóng túi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ dùng gia đình gia dụng", "Màng bọc thực phẩm, túi bóng, khăn giấy, mút rửa chén" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bia & Đồ uống có cồn", "Bia lon, rượu nhẹ, nước trái cây lên men" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau củ quả tươi (Hàng ngày)", "Rau xanh, củ quả nguyên liệu nấu ăn hằng ngày" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Văn phòng phẩm & Đồ chơi nhỏ", "Bút, tập học sinh, đồ chơi trẻ em cơ bản" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "nam.le@gmail.com", "Lê Hoàng Nam" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "lan.pham@gmail.com", "Phạm Thị Lan" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                columns: new[] { "ProductId", "UnitPrice" },
                values: new object[] { 1, 12000m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                columns: new[] { "ProductId", "UnitPrice" },
                values: new object[] { 2, 20000m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                columns: new[] { "ProductId", "UnitPrice" },
                values: new object[] { 5, 45000m });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[] { 4, 2, 13, 2, 21000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "TotalAmount",
                value: 32000m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "TotalAmount",
                value: 97000m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BrandId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 1, 12000m, "Snack khoai tây Lay's Vị Tự Nhiên 63g", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 1, 2, 20000m, "Nước ngọt Coca-Cola Chai 1.5L", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 3, 32000m, "Sữa tươi tiệt trùng Cô Gái Hà Lan Có Đường Lốc 4x180ml", 45, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 4, 9000m, "Mì Omachi Xốt Bò Hầm Gói 80g", 200, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 5, 45000m, "Nước mắm Chinsu Hương Cá Hồi Chai 500ml", 35, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 3, 6, 125000m, "Gạo Thơm Thai Ông Thọ Túi 5kg", 25, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 3, 7, 22000m, "Cá sốt cà Hạ Long Hộp 175g", 50, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 3, 8, 34000m, "Nước rửa chén Sunlight Chanh Chai 750g", 40, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "SupplierId" },
                values: new object[] { 3, 9, 79000m, "Dầu gội Clear Bạc Hà Chai 340g", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 3, 10, 48000m, "Cá viên ngon C.P Gói 500g", 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 3, 11, 12000m, "Kem Socola Merino Que 60g", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 3, 12, 38000m, "Màng bọc thực phẩm Ringo 30cm x 100m", 20, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 13, 21000m, "Bia Heineken Lon 330ml", 120, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 14, 25000m, "Cà chua Đà Lạt Tươi Túi 1kg", 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 15, 8000m, "Tập học sinh 96 trang Thiên Long", 150 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Description",
                value: "Chủ bách hóa (Quản lý toàn bộ kho hàng, nhập hàng, nhân sự và báo cáo doanh thu)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "Description",
                value: "Nhân viên thu ngân / POS (Quét mã vạch, lập hóa đơn, nhận thanh toán VietQR/Tiền mặt)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "Description",
                value: "Thành viên thân thiết (Tích điểm, tra cứu hạng thành viên và lịch sử mua hàng)");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "Address", "ContactName", "SupplierName" },
                values: new object[] { "KCN Tân Bình, Q. Tân Phú, TP.HCM", "Nguyễn Văn Hùng", "Công ty Cổ phần Masan Consumer" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 2,
                columns: new[] { "Address", "SupplierName" },
                values: new object[] { "Phường Bình Hòa, TP. Thuận An, Bình Dương", "Công ty TNHH FrieslandCampina Việt Nam" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 3,
                columns: new[] { "Address", "SupplierName" },
                values: new object[] { "42 Bến Vân Đồn, Q.4, TP.HCM", "Tổng Công ty Lương thực Miền Nam (Vinafood II)" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "FullName",
                value: "Quản Lý Hoàng Dung");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "FullName",
                value: "Thu Ngân Ca Sáng (Nguyễn Thị Mai)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "FullName",
                value: "Thu Ngân Ca Chiều (Trần Quốc Tuấn)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "FullName",
                value: "Lê Hoàng Nam");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "FullName",
                value: "Phạm Thị Lan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                columns: new[] { "BrandName", "Description" },
                values: new object[] { "Nutri Mart Clean", "Thương hiệu độc quyền chuẩn Eat Clean Nutri Mart" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                columns: new[] { "BrandName", "Description" },
                values: new object[] { "Dalat Eco Organic", "Rau củ quả tươi sạch đạt chứng nhận VietGAP/GlobalGAP" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                columns: new[] { "BrandName", "Description" },
                values: new object[] { "VietOrganic Natural", "Gia vị và dầu ăn thực vật hữu cơ tự nhiên" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Rau củ quả hữu cơ", "Rau xanh, củ quả tươi đạt chuẩn Organic, VietGAP" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Ngũ cốc & Hạt dinh dưỡng", "Yến mạch, hạt chia, hạnh nhân, óc chó, mác ca" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sữa hạt & Sữa chua hữu cơ", "Sữa hạnh nhân, sữa đậu nành, sữa chua Hy Lạp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thực phẩm Eat Clean", "Ức gà, cơm gạo lứt, salad đóng gói ăn liền" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Gia vị & Dầu thực vật tự nhiên", "Dầu oliu, mật ong nguyên chất, muối hồng Himalaya" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Trái cây tươi xuất nhập khẩu", "Táo Envy, dâu tây Đà Lạt, việt quất, cam vàng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Trà & Thức uống thực dưỡng", "Trà dưỡng nhan, kombucha, trà xanh matcha, nước ép tươi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ khô & Bánh ăn kiêng", "Bánh biscotti, thanh hạt năng lượng, bún chùm ngây, mì gạo lứt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thịt & Hải sản tươi sạch", "Thịt heo ăn chay, cá hồi măng tây, tôm sinh thái" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thực phẩm đông lạnh hữu cơ", "Rau củ hỗn hợp đông lạnh, chả chay organic, dumpling thực dưỡng" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh kẹo & Snack Healthy", "Snack chuối sấy lạnh, kẹo dẻo vitamin, rong biển sấy giòn" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thực phẩm bổ sung & Detox", "Bột cần tây sấy lạnh, bột chlorella, collagen thực vật" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nước ép & Smoothie đóng chai", "Nước ép cần tây củ dền, smoothie bơ chuối, nước dừa tươi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Gạo & Các loại đậu hữu cơ", "Gạo lứt đỏ, gạo st25 organic, đậu đen xanh lòng, đậu chickpea" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sản phẩm thuần chay (Vegan)", "Pate thuần chay, giò nấm, nước mắm chay cốt đậu nành" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "nam.nguyen@gmail.com", "Nguyễn Hoàng Nam" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Email", "FullName" },
                values: new object[] { "mai.pham@gmail.com", "Phạm Thị Mai" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                columns: new[] { "ProductId", "UnitPrice" },
                values: new object[] { 3, 65000m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                columns: new[] { "ProductId", "UnitPrice" },
                values: new object[] { 5, 78000m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                columns: new[] { "ProductId", "UnitPrice" },
                values: new object[] { 10, 120000m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "TotalAmount",
                value: 143000m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "TotalAmount",
                value: 120000m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BrandId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 2, 25000m, "Rau cải bó xôi hữu cơ 300g", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 2, 1, 32000m, "Cà chua bí đỏ hữu cơ 500g", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 1, 45000m, "Bông cải xanh Đà Lạt Organic 500g", 25, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 2, 65000m, "Yến mạch nguyên hạt Quaker 500g", 30, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 2, 95000m, "Hạt hạnh nhân rang Mỹ 250g", 25, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 1, 2, 75000m, "Hạt chia hữu cơ Úc 200g", 35, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 1, 3, 78000m, "Sữa hạnh nhân Nutri 1L", 15, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 1, 3, 55000m, "Sữa chua Hy Lạp không đường 500g", 20, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "SupplierId" },
                values: new object[] { 1, 3, 42000m, "Sữa đậu nành hữu cơ 1L", 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 1, 4, 89000m, "Ức gà tươi đông lạnh 1kg", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 1, 4, 42000m, "Cơm gạo lứt đóng hộp ăn liền 250g", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 1, 4, 48000m, "Salad ức gà xốt chanh dây đóng gói 200g", 18, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[] { 5, 145000m, "Dầu oliu nguyên chất Extra Virgin 500ml", 20, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5, 120000m, "Mật ong hoa rừng nguyên chất 350ml", 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 5, 38000m, "Muối hồng Himalaya nguyên chất 500g", 40 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "Description",
                value: "Quản trị viên (Toàn quyền quản lý kho, nhập hàng, nhân sự và báo cáo doanh thu POS)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "Description",
                value: "Nhân viên bán hàng / POS (Quét mã vạch, lập hóa đơn, tích điểm khách hàng)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "Description",
                value: "Tài khoản khách hàng (Tra cứu điểm thưởng, hạng thành viên, lịch sử mua hàng)");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1,
                columns: new[] { "Address", "ContactName", "SupplierName" },
                values: new object[] { "Phường 11, TP. Đà Lạt, Lâm Đồng", "Nguyễn Văn An", "Nông Trại Xanh Dalat Organic Farm" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 2,
                columns: new[] { "Address", "SupplierName" },
                values: new object[] { "KCN Tân Bình, Tân Phú, TP.HCM", "Công ty TNHH Thực Phẩm Sạch NutriLife" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 3,
                columns: new[] { "Address", "SupplierName" },
                values: new object[] { "Huyện Củ Chi, TP.HCM", "Hợp Tác Xã Gia Vị & Nông Sản Việt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "FullName",
                value: "Quản Lý Nutri Mart");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "FullName",
                value: "Thu Ngân Ca Sáng (Nguyễn Thu Hà)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "FullName",
                value: "Thu Ngân Ca Chiều (Lê Hoàng Nam)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "FullName",
                value: "Nguyễn Hoàng Nam");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "FullName",
                value: "Phạm Thị Mai");
        }
    }
}
