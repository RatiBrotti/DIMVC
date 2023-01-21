using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DIMVC.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "ContactIDSequence",
                startValue: 0L,
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "D",
                startValue: 0L);

            migrationBuilder.CreateSequence(
                name: "val");

            migrationBuilder.CreateTable(
                name: "ActivatedAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UserLevel = table.Column<int>(type: "int", maxLength: 50, nullable: false, defaultValue: 1),
                    AcaountStatus = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    DeactivationComment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivatedAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnactivatedAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ActivationToken = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnactivatedAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StateProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryRegion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_ActivatedAccount_AccountId",
                        column: x => x.AccountId,
                        principalTable: "ActivatedAccount",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ShippingPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    ShippingDimensions = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ShippingWeight = table.Column<decimal>(type: "decimal(6,1)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Describtion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PhotoFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ActivatedAccount_AccountId",
                        column: x => x.AccountId,
                        principalTable: "ActivatedAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ShipDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false, defaultValue: 1000),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    ShipToAddressId = table.Column<int>(type: "int", nullable: false),
                    BillToAddressId = table.Column<int>(type: "int", nullable: true),
                    ShipMethod = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_ActivatedAccount_AccountId",
                        column: x => x.AccountId,
                        principalTable: "ActivatedAccount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_BillToAddressId_Addresses",
                        column: x => x.BillToAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingBag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingBag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingBag_ActivatedAccount_AccountId",
                        column: x => x.AccountId,
                        principalTable: "ActivatedAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingBag_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AccountId",
                table: "Address",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryName",
                table: "Category",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AccountId",
                table: "Order",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BillToAddressId",
                table: "Order",
                column: "BillToAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_AccountId",
                table: "Product",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBag_AccountId",
                table: "ShoppingBag",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBag_ProductID",
                table: "ShoppingBag",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ShoppingBag");

            migrationBuilder.DropTable(
                name: "UnactivatedAccount");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "ActivatedAccount");

            migrationBuilder.DropSequence(
                name: "ContactIDSequence");

            migrationBuilder.DropSequence(
                name: "D");

            migrationBuilder.DropSequence(
                name: "val");
        }
    }
}
