using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LENSLOOK.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    DelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.DelID);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DGender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Dpassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumberOfAppointments = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LensType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FrameType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Size = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    SID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.SID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ULastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    URoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UGender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Upassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VID);
                });

            migrationBuilder.CreateTable(
                name: "Doctorsphones",
                columns: table => new
                {
                    DID = table.Column<int>(type: "int", nullable: false),
                    Dphone = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctorsphones", x => new { x.DID, x.Dphone });
                    table.ForeignKey(
                        name: "FK_Doctorsphones_Doctors_DID",
                        column: x => x.DID,
                        principalTable: "Doctors",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false),
                    DID = table.Column<int>(type: "int", nullable: false),
                    SID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => new { x.UID, x.DID, x.SID });
                    table.ForeignKey(
                        name: "FK_Bookings_Doctors_DID",
                        column: x => x.DID,
                        principalTable: "Doctors",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Services_SID",
                        column: x => x.SID,
                        principalTable: "Services",
                        principalColumn: "SID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UID",
                        column: x => x.UID,
                        principalTable: "Users",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    DoctorsDID = table.Column<int>(type: "int", nullable: false),
                    UsersUID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => new { x.DoctorsDID, x.UsersUID });
                    table.ForeignKey(
                        name: "FK_Examinations_Doctors_DoctorsDID",
                        column: x => x.DoctorsDID,
                        principalTable: "Doctors",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Examinations_Users_UsersUID",
                        column: x => x.UsersUID,
                        principalTable: "Users",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DelID = table.Column<int>(type: "int", nullable: true),
                    UID = table.Column<int>(type: "int", nullable: true),
                    DeliveryDelID = table.Column<int>(type: "int", nullable: true),
                    UsersUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OID);
                    table.ForeignKey(
                        name: "FK_Orders_Deliveries_DeliveryDelID",
                        column: x => x.DeliveryDelID,
                        principalTable: "Deliveries",
                        principalColumn: "DelID");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UsersUID",
                        column: x => x.UsersUID,
                        principalTable: "Users",
                        principalColumn: "UID");
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false),
                    DID = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => new { x.UID, x.DID });
                    table.ForeignKey(
                        name: "FK_Rates_Doctors_DID",
                        column: x => x.DID,
                        principalTable: "Doctors",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rates_Users_UID",
                        column: x => x.UID,
                        principalTable: "Users",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false),
                    PID = table.Column<int>(type: "int", nullable: false),
                    reviews = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.PID, x.UID });
                    table.ForeignKey(
                        name: "FK_Reviews_Products_PID",
                        column: x => x.PID,
                        principalTable: "Products",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UID",
                        column: x => x.UID,
                        principalTable: "Users",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Userphnoes",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false),
                    Uphone = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userphnoes", x => new { x.UID, x.Uphone });
                    table.ForeignKey(
                        name: "FK_Userphnoes_Users_UID",
                        column: x => x.UID,
                        principalTable: "Users",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendorPhones",
                columns: table => new
                {
                    VID = table.Column<int>(type: "int", nullable: false),
                    Vphone = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorPhones", x => new { x.VID, x.Vphone });
                    table.ForeignKey(
                        name: "FK_VendorPhones_Vendors_VID",
                        column: x => x.VID,
                        principalTable: "Vendors",
                        principalColumn: "VID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendorProducts",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false),
                    VID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorProducts", x => new { x.VID, x.PID });
                    table.ForeignKey(
                        name: "FK_VendorProducts_Products_PID",
                        column: x => x.PID,
                        principalTable: "Products",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendorProducts_Vendors_VID",
                        column: x => x.VID,
                        principalTable: "Vendors",
                        principalColumn: "VID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false),
                    OID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.OID, x.PID });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OID",
                        column: x => x.OID,
                        principalTable: "Orders",
                        principalColumn: "OID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_PID",
                        column: x => x.PID,
                        principalTable: "Products",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DID",
                table: "Bookings",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SID",
                table: "Bookings",
                column: "SID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_UsersUID",
                table: "Examinations",
                column: "UsersUID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_PID",
                table: "OrderProducts",
                column: "PID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryDelID",
                table: "Orders",
                column: "DeliveryDelID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UsersUID",
                table: "Orders",
                column: "UsersUID");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_DID",
                table: "Rates",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UID",
                table: "Reviews",
                column: "UID");

            migrationBuilder.CreateIndex(
                name: "IX_VendorProducts_PID",
                table: "VendorProducts",
                column: "PID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Doctorsphones");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Userphnoes");

            migrationBuilder.DropTable(
                name: "VendorPhones");

            migrationBuilder.DropTable(
                name: "VendorProducts");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
