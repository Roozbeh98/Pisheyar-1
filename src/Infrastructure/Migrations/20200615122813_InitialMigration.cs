using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pisheyar.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeGroup",
                columns: table => new
                {
                    CodeGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeGroupGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeGroup", x => x.CodeGroupID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProvider",
                columns: table => new
                {
                    PaymentProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentProviderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProvider", x => x.PaymentProviderID);
                });

            migrationBuilder.CreateTable(
                name: "PermissionGroup",
                columns: table => new
                {
                    PermissionGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionGroupGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionGroup", x => x.PermissionGroupID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserInitialCredit = table.Column<int>(nullable: false),
                    OrderRequestPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingID);
                });

            migrationBuilder.CreateTable(
                name: "SMSProvider",
                columns: table => new
                {
                    SMSProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProvider", x => x.SMSProviderID);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Usage = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "Code",
                columns: table => new
                {
                    CodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CodeGroupID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Code", x => x.CodeID);
                    table.ForeignKey(
                        name: "FK_Code_CodeGroup",
                        column: x => x.CodeGroupID,
                        principalTable: "CodeGroup",
                        principalColumn: "CodeGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentProviderSetting",
                columns: table => new
                {
                    PaymentProviderSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentProviderSettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PaymentProviderID = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 128, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    APIKey = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentProviderSetting", x => x.PaymentProviderSettingID);
                    table.ForeignKey(
                        name: "FK_PaymentProviderSetting_PaymentProvider",
                        column: x => x.PaymentProviderID,
                        principalTable: "PaymentProvider",
                        principalColumn: "PaymentProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionGroupID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionID);
                    table.ForeignKey(
                        name: "FK_Permission_PermissionGroup",
                        column: x => x.PermissionGroupID,
                        principalTable: "PermissionGroup",
                        principalColumn: "PermissionGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ProvinceID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_Province",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSProviderSetting",
                columns: table => new
                {
                    SMSProviderSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderSettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderID = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 128, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    APIKey = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderSetting", x => x.SMSProviderSettingID);
                    table.ForeignKey(
                        name: "FK_SMSProviderSetting_SMSProvider",
                        column: x => x.SMSProviderID,
                        principalTable: "SMSProvider",
                        principalColumn: "SMSProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUsGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContactUsBusinessTypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.ContactUsID);
                    table.ForeignKey(
                        name: "FK_ContactUs_Code",
                        column: x => x.ContactUsBusinessTypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Size = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_Document_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PublicDiscount",
                columns: table => new
                {
                    PublicDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicDiscount", x => x.PublicDiscountID);
                    table.ForeignKey(
                        name: "FK_PublicDiscount_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Cost = table.Column<long>(nullable: false),
                    Serial = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    RolePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolePermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.RolePermissionID);
                    table.ForeignKey(
                        name: "FK_RolePermission_Permission",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSProviderSettingNumber",
                columns: table => new
                {
                    SMSProviderSettingNumberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderSettingNumberGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderSettingID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderSettingNumber", x => x.SMSProviderSettingNumberID);
                    table.ForeignKey(
                        name: "FK_SMSProviderSettingNumber_SMSProviderSetting",
                        column: x => x.SMSProviderSettingID,
                        principalTable: "SMSProviderSetting",
                        principalColumn: "SMSProviderSettingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSTemplate",
                columns: table => new
                {
                    SMSTemplateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSTemplateGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderSettingID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSTemplate", x => x.SMSTemplateID);
                    table.ForeignKey(
                        name: "FK_SMSTemplate_SMSProviderSetting",
                        column: x => x.SMSProviderSettingID,
                        principalTable: "SMSProviderSetting",
                        principalColumn: "SMSProviderSettingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    AdvertisementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    DocumentID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.AdvertisementID);
                    table.ForeignKey(
                        name: "FK_Advertisement_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ParentCategoryID = table.Column<int>(nullable: true),
                    CoverDocumentID = table.Column<int>(nullable: true),
                    ActiveIconDocumentID = table.Column<int>(nullable: true),
                    InactiveIconDocumentID = table.Column<int>(nullable: true),
                    QuadMenuDocumentID = table.Column<int>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 128, nullable: false),
                    Abstract = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Category_Document1",
                        column: x => x.ActiveIconDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_Document",
                        column: x => x.CoverDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_Document2",
                        column: x => x.InactiveIconDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_Category",
                        column: x => x.ParentCategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_Document3",
                        column: x => x.QuadMenuDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    RoleID = table.Column<int>(nullable: false),
                    GenderCodeID = table.Column<int>(nullable: true),
                    ProfileDocumentID = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 128, nullable: false),
                    LastName = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 128, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsRegister = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    RegisteredDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Code",
                        column: x => x.GenderCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Document_ProfileDocumentID",
                        column: x => x.ProfileDocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTag",
                columns: table => new
                {
                    CategoryTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CategoryID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTag", x => x.CategoryTagID);
                    table.ForeignKey(
                        name: "FK_CategoryTag_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryTag_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admin_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Client_City",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    ComplaintID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(maxLength: 512, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintID);
                    table.ForeignKey(
                        name: "FK_Complaint_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contractor",
                columns: table => new
                {
                    ContractorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    BusinessTypeCodeID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(maxLength: 128, nullable: false),
                    Longitude = table.Column<string>(maxLength: 128, nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    AverageRate = table.Column<double>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractor", x => x.ContractorID);
                    table.ForeignKey(
                        name: "FK_Contractor_Code",
                        column: x => x.BusinessTypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_City",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractor_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    DocumentID = table.Column<int>(nullable: false),
                    ViewCount = table.Column<int>(nullable: false),
                    LikeCount = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Abstract = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsSuggested = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsInSlider = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Post_Document",
                        column: x => x.DocumentID,
                        principalTable: "Document",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSResponse",
                columns: table => new
                {
                    SMSResponseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSResponseGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSTemplateID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusText = table.Column<string>(nullable: false),
                    Sender = table.Column<string>(maxLength: 128, nullable: false),
                    Receptor = table.Column<string>(maxLength: 128, nullable: false),
                    Token = table.Column<string>(maxLength: 128, nullable: true),
                    Token1 = table.Column<string>(maxLength: 128, nullable: true),
                    Token2 = table.Column<string>(maxLength: 128, nullable: true),
                    Message = table.Column<string>(nullable: false),
                    Cost = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    SentDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSResponse", x => x.SMSResponseID);
                    table.ForeignKey(
                        name: "FK_SMSResponse_SMSTemplate",
                        column: x => x.SMSTemplateID,
                        principalTable: "SMSTemplate",
                        principalColumn: "SMSTemplateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SMSResponse_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suggestion",
                columns: table => new
                {
                    SuggestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuggestionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(maxLength: 512, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestion", x => x.SuggestionID);
                    table.ForeignKey(
                        name: "FK_Suggestion_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    TokenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    UserID = table.Column<int>(nullable: false),
                    RoleCodeID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.TokenID);
                    table.ForeignKey(
                        name: "FK_Token_Code",
                        column: x => x.RoleCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Token_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPermission",
                columns: table => new
                {
                    UserPermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPermissionGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PermissionID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermission", x => x.UserPermissionID);
                    table.ForeignKey(
                        name: "FK_UserPermission_Permission",
                        column: x => x.PermissionID,
                        principalTable: "Permission",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPermission_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorCategory",
                columns: table => new
                {
                    ContractorCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorCategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorCategory", x => x.ContractorCategoryID);
                    table.ForeignKey(
                        name: "FK_ContractorCategory_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorCategory_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractorDiscount",
                columns: table => new
                {
                    ContractorDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    PublicDiscountID = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorDiscount", x => x.ContractorDiscountID);
                    table.ForeignKey(
                        name: "FK_ContractorDiscount_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractorDiscount_PublicDiscount",
                        column: x => x.PublicDiscountID,
                        principalTable: "PublicDiscount",
                        principalColumn: "PublicDiscountID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ClientID = table.Column<int>(nullable: false),
                    ContractorID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    StateCodeID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Rate = table.Column<double>(nullable: true),
                    Cost = table.Column<int>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    DeadlineDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Client",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Code",
                        column: x => x.StateCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentGUID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    PaymentProviderSettingID = table.Column<int>(nullable: false),
                    ContractorID = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    TrackingToken = table.Column<long>(nullable: true),
                    IsSuccessful = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentProviderSetting_PaymentProviderSettingID",
                        column: x => x.PaymentProviderSettingID,
                        principalTable: "PaymentProviderSetting",
                        principalColumn: "PaymentProviderSettingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateDiscount",
                columns: table => new
                {
                    PrivateDiscountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivateDiscountGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    TypeCodeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<int>(nullable: false),
                    MaximumUsesNumber = table.Column<int>(nullable: false),
                    NumberUsed = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateDiscount", x => x.PrivateDiscountID);
                    table.ForeignKey(
                        name: "FK_PrivateDiscount_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrivateDiscount_Code",
                        column: x => x.TypeCodeID,
                        principalTable: "Code",
                        principalColumn: "CodeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostCategory",
                columns: table => new
                {
                    PostCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCategoryGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CategoryID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategory", x => x.PostCategoryID);
                    table.ForeignKey(
                        name: "FK_PostCategory_Category",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostCategory_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    PostCommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCommentGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    CommentID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.PostCommentID);
                    table.ForeignKey(
                        name: "FK_PostComment_Comment",
                        column: x => x.CommentID,
                        principalTable: "Comment",
                        principalColumn: "CommentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComment_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostTagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTagGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    PostID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => x.PostTagID);
                    table.ForeignKey(
                        name: "FK_PostTag_Post",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostTag_Tag",
                        column: x => x.TagID,
                        principalTable: "Tag",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderRequest",
                columns: table => new
                {
                    OrderRequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderRequestGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    ContractorID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    OfferedPrice = table.Column<long>(nullable: false),
                    IsAllow = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsAccept = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRequest", x => x.OrderRequestID);
                    table.ForeignKey(
                        name: "FK_OrderRequest_Contractor",
                        column: x => x.ContractorID,
                        principalTable: "Contractor",
                        principalColumn: "ContractorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRequest_Order",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChatMessage",
                columns: table => new
                {
                    ChatMessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatMessageGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    OrderRequestID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    IsSeen = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsModified = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    SentAt = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessage", x => x.ChatMessageID);
                    table.ForeignKey(
                        name: "FK_ChatMessage_OrderRequest",
                        column: x => x.OrderRequestID,
                        principalTable: "OrderRequest",
                        principalColumn: "OrderRequestID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatMessage_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), null, null, "سایت اصلی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 178, DateTimeKind.Local).AddTicks(7526), null, null, 1 },
                    { 2, null, null, new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), null, null, "وبلاگ", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(522), null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "CodeGroup",
                columns: new[] { "CodeGroupID", "CodeGroupGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"), "نوع فایل", "FilepondType" },
                    { 2, new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"), "نوع کسب و کار", "BusinessType" },
                    { 3, new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"), "جنسیت", "Gender" },
                    { 4, new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"), "وضعیت سفارش", "OrderState" },
                    { 5, new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"), "نقش", "Role" },
                    { 6, new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"), "نوع کسب و کار بخش ارتباط با ما", "ContactUsBusinessType" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceID", "Name", "ProvinceGUID" },
                values: new object[,]
                {
                    { 19, "اصفهان", new Guid("4cd46d10-6357-4494-85a8-311c89d00ad1") },
                    { 20, "ايلام", new Guid("90cf5a6a-ee21-4a62-a93c-3877dad30af1") },
                    { 21, "تهران", new Guid("5aa33ade-2e25-49e9-918d-f744763dcfca") },
                    { 22, "آذربايجان شرقي", new Guid("c75aa72c-8f48-41f7-990d-96d6d3b288ce") },
                    { 23, "فارس", new Guid("67749b66-1cac-49c8-85cb-357a5868200f") },
                    { 24, "کرمانشاه", new Guid("d049b376-710e-4ab7-be7c-062609b3da1a") },
                    { 28, "همدان", new Guid("e991d104-7a26-4c39-a801-acf388f05e50") },
                    { 26, "مرکزي", new Guid("4ef84c1d-1491-418b-a1f0-c6e71d00828b") },
                    { 27, "گيلان", new Guid("b74cd6d1-aaba-4d78-8ef1-5d0666f773bd") },
                    { 18, "اردبيل", new Guid("57aa1fe7-89ec-49de-a60f-de16ebbc95f9") },
                    { 29, "کرمان", new Guid("6042d663-41b4-4373-a8cf-20fd1b4fddbb") },
                    { 30, "سمنان", new Guid("e29b662e-cac5-47be-ae46-7dadea258054") },
                    { 31, "کهگيلويه و بويراحمد", new Guid("d2c989ea-c78e-4a51-9e59-c718d8e3140d") },
                    { 25, "هرمزگان", new Guid("20c1d945-534f-4e64-9531-cb4dea108df7") },
                    { 17, "لرستان", new Guid("179ed318-ce57-4dd4-80e4-1bef010acdf6") },
                    { 14, "گلستان", new Guid("797f9576-54d4-48b4-a7d7-69f6b3ddd22a") },
                    { 15, "مازندران", new Guid("ab5cf666-d3ed-4895-99cc-0c101721d26b") },
                    { 1, "يزد", new Guid("e0e7dc4e-0007-4370-a3d1-1662e5978918") },
                    { 2, "چهار محال و بختياري", new Guid("d0fd2378-53ce-415e-9c27-b592726c3708") },
                    { 3, "خراسان شمالي", new Guid("be88e02b-65c9-498d-9fa9-65674df6b0e7") },
                    { 4, "البرز", new Guid("1519da58-5b4d-497e-a27b-8f9743bcc39f") },
                    { 5, "قم", new Guid("c5d6e5a6-dd8c-4875-8bdd-c245517b29b4") },
                    { 16, "قزوين", new Guid("ed2497ea-4951-4494-b3ee-8b89d1b480fe") },
                    { 7, "آذربايجان غربي", new Guid("ac614113-0acf-457c-b85d-872fa933e4ea") },
                    { 6, "کردستان", new Guid("9b84b7cb-abd6-4348-acef-19c3e1afe613") },
                    { 9, "سيستان و بلوچستان", new Guid("cc97369f-a353-498b-872f-33f10e70a49f") },
                    { 10, "خراسان جنوبي", new Guid("14c7c5f8-6193-45fb-bc36-9ffe567d2156") },
                    { 11, "خوزستان", new Guid("3abf300f-0fd8-48c5-96c2-efb256c5b9f9") },
                    { 12, "بوشهر", new Guid("5dc0ffd0-c539-450a-bbef-38b864788883") },
                    { 13, "زنجان", new Guid("5da539c7-0a7c-4406-93cc-4a1b623248c3") },
                    { 8, "خراسان رضوي", new Guid("c6d2041a-0549-40e5-89e2-f08aec46d202") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "DisplayName", "ModifiedDate", "Name", "RoleGUID" },
                values: new object[,]
                {
                    { 3, "سرویس گیرنده", new DateTime(2020, 6, 15, 16, 58, 11, 167, DateTimeKind.Local).AddTicks(8336), "Client", new Guid("42479697-f5f9-4fbc-b0fa-9185d0deaa35") },
                    { 1, "ادمین", new DateTime(2020, 6, 15, 16, 58, 11, 163, DateTimeKind.Local).AddTicks(4471), "Admin", new Guid("083d677d-4aca-4012-8241-3695c4c71e7e") },
                    { 2, "سرویس دهنده", new DateTime(2020, 6, 15, 16, 58, 11, 167, DateTimeKind.Local).AddTicks(8239), "Contractor", new Guid("2cdb0c20-0c1f-4ce5-aa73-a1c2099b6f37") }
                });

            migrationBuilder.InsertData(
                table: "SMSProvider",
                columns: new[] { "SMSProviderID", "Name" },
                values: new object[] { 1, "Kavenegar" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 3, null, null, new Guid("9561551f-8535-4567-8708-4b8db3e1b9d7"), null, null, "خانه", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(665), 1, null, 1 },
                    { 4, null, null, new Guid("232f06e0-73c4-4023-85a7-475f3a026f26"), null, null, "حمل و نقل", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(687), 1, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 826, new Guid("4518c068-00fc-42dc-b5f5-de68d1f47245"), "ليلان", 22 },
                    { 825, new Guid("a64098b0-ac10-42db-9363-d35e5c8a9692"), "قره آغاج", 22 },
                    { 824, new Guid("57ca0bc6-0bc8-4c5d-b2e3-3eab1e5cf416"), "عجب شير", 22 },
                    { 823, new Guid("f6c257b6-9669-45cf-a23c-86e39a0e6807"), "صوفيان", 22 },
                    { 822, new Guid("7df5c25c-b711-49d3-b4cb-95428ce8c89d"), "شهر جديد سهند", 22 },
                    { 821, new Guid("2dd59c44-3d96-452c-b3f0-fb94b319a5a1"), "شند آباد", 22 },
                    { 820, new Guid("c46f9def-02d0-4982-ba7b-8ec6dfe6775c"), "شرفخانه", 22 },
                    { 819, new Guid("85264049-73be-42a4-a7c4-43a33ce4fbd5"), "شربيان", 22 },
                    { 818, new Guid("adf9bcff-7688-46ef-a255-e144dd798590"), "شبستر", 22 },
                    { 817, new Guid("e93863a5-4ab8-43e8-9a6b-69e0ab00e264"), "سيه رود", 22 },
                    { 816, new Guid("b2f1a24c-1f4d-4b47-b8bf-0152ce7a309f"), "سيس", 22 },
                    { 815, new Guid("f684ea77-f8e6-4bbe-b0ab-ef3f0a5c0702"), "سردرود", 22 },
                    { 814, new Guid("10bae718-daa7-4571-8fb3-e020754bc364"), "سراب", 22 },
                    { 813, new Guid("3439cad2-6971-4fcc-9230-ca4b803c6499"), "زنوز", 22 },
                    { 812, new Guid("5a4374d1-bc36-43ff-84d6-9b56a6aa38d9"), "زرنق", 22 },
                    { 827, new Guid("e5a32fb2-c96e-4381-b497-74728115fb61"), "مبارک شهر", 22 },
                    { 828, new Guid("352d2518-4742-49ad-9863-ad1fdc86c882"), "مراغه", 22 },
                    { 829, new Guid("85d37133-cfca-40a9-9eb9-9e580e5a937d"), "مرند", 22 },
                    { 830, new Guid("f5cbe2cc-921f-4bcc-beb7-d55429ccf75e"), "ملکان", 22 },
                    { 846, new Guid("97ecb0d2-0270-47d5-960e-088c7fdbbed0"), "گوگان", 22 },
                    { 845, new Guid("79d4b3da-e736-4eca-8ad0-0e675404ba95"), "کوزه کنان", 22 },
                    { 844, new Guid("bdb9a92f-5fab-4d20-a4d6-701f96e6f258"), "کليبر", 22 },
                    { 843, new Guid("5a635d91-0fb3-4835-8d14-0d7d6e2c25d7"), "کلوانق", 22 },
                    { 842, new Guid("fe1ea430-4713-4488-9d3a-f7e3e3658474"), "کشکسراي", 22 },
                    { 841, new Guid("507a22a4-1437-4934-83f7-72dfe502300c"), "يامچي", 22 },
                    { 840, new Guid("338c628b-08b4-4f30-b518-8519d0669256"), "ورزقان", 22 },
                    { 811, new Guid("e4ab2b6c-8ad3-4ab0-828e-3c407b0c7e9d"), "دوزدوزان", 22 },
                    { 839, new Guid("b0b7618d-f2e3-43a8-a326-e68a57f103ca"), "وايقان", 22 },
                    { 837, new Guid("21c35612-3a25-4993-a49b-e40511f3cc39"), "هشترود", 22 },
                    { 836, new Guid("60af3abb-087b-4467-b503-f7fdf388ce12"), "هريس", 22 },
                    { 835, new Guid("e6f5e370-13be-44dd-98e8-2cf82668d159"), "هاديشهر", 22 },
                    { 834, new Guid("78943a17-f57e-4eed-bba9-0dee1c2c1a79"), "نظرکهريزي", 22 },
                    { 833, new Guid("019ddb70-a9f9-4ddc-a32d-757c6a32e178"), "ميانه", 22 },
                    { 832, new Guid("52165778-d8c8-444b-b7de-5c902510ad9f"), "مهربان", 22 },
                    { 831, new Guid("792d17fe-07e2-4365-81a2-6230fc698e0b"), "ممقان", 22 },
                    { 838, new Guid("63d7a6bf-70d1-411c-a759-7f33a94749dd"), "هوراند", 22 },
                    { 810, new Guid("10abfe37-4a01-4d8d-8c1a-51dfc7b4f093"), "خواجه", 22 },
                    { 809, new Guid("4b7ed8b3-343d-4f2a-81c1-aaeb004d2141"), "خمارلو", 22 },
                    { 808, new Guid("5e0b1789-d3f3-4962-b4df-2badbdf00984"), "خسروشاه", 22 },
                    { 787, new Guid("027f15e8-1847-4e64-ac4c-e5be62471c7f"), "آقکند", 22 },
                    { 786, new Guid("e1f360e2-d313-403a-993d-b483523b2af0"), "آذرشهر", 22 },
                    { 785, new Guid("36ed339b-27f9-4e9c-b9dc-28802043a72a"), "آبش احمد", 22 },
                    { 784, new Guid("02dd0ac8-d553-429b-bdfa-ea49f09d37fc"), "گلستان", 21 },
                    { 783, new Guid("f1ea86da-9fe4-468d-b9f0-840c777b222a"), "کيلان", 21 },
                    { 782, new Guid("fd4ea61f-3d74-4f21-a213-f314283b77a5"), "کهريزک", 21 },
                    { 781, new Guid("102c1388-ca56-4355-b6d0-131f8b1e5515"), "چهاردانگه", 21 },
                    { 780, new Guid("49e2eb16-0d26-4a6b-8882-2d46e3ede80f"), "پيشوا", 21 },
                    { 779, new Guid("1690e205-dcec-4829-9b03-9ae18f6228e4"), "پرديس", 21 },
                    { 778, new Guid("e11242c3-db2c-498d-8181-14d9feccaab9"), "پاکدشت", 21 },
                    { 777, new Guid("9bab8131-c3b8-40fd-9d02-a152c1176d26"), "ورامين", 21 },
                    { 776, new Guid("71f26939-62d2-4e9a-a612-41d8bbf3d2ba"), "وحيديه", 21 },
                    { 775, new Guid("3840f29a-3994-4be9-b2ef-c89e7b53e3a2"), "نصيرشهر", 21 },
                    { 774, new Guid("eaa23d21-6432-4b0d-aa88-5929f299eb38"), "نسيم شهر", 21 },
                    { 773, new Guid("9d47dff3-db09-45e1-869b-bb40d785df09"), "ملارد", 21 },
                    { 788, new Guid("d81e0b5c-2333-4988-b505-29d2145e7311"), "آچاچي", 22 },
                    { 789, new Guid("b802ae82-2e3b-4783-a11f-3fbedc905c8f"), "اسکو", 22 },
                    { 790, new Guid("b05f6c42-9f8c-4995-90a3-5f421b159b49"), "اهر", 22 },
                    { 791, new Guid("6784a936-2cfa-4649-83e2-a5440d5f8ea1"), "ايلخچي", 22 },
                    { 807, new Guid("9e4ad1ff-4268-47a7-b18d-88df3ae2ac9f"), "خداجو", 22 },
                    { 806, new Guid("83adff51-0c2f-45a6-b86e-25a6cbe5cc6d"), "خامنه", 22 },
                    { 805, new Guid("b65a74de-a89e-4f6e-9fbd-fb02908fce40"), "خاروانا", 22 },
                    { 804, new Guid("25b33f61-695f-4016-bb97-2c15e122db0d"), "جوان قلعه", 22 },
                    { 803, new Guid("d1bbedfe-df1b-4aa9-88ac-13fe2c1a9296"), "جلفا", 22 },
                    { 802, new Guid("3df31cca-39df-48e3-ad7e-2fd221778e5a"), "تيکمه داش", 22 },
                    { 801, new Guid("a7cce5be-0045-4fd3-a305-c064c76981b3"), "تيمورلو", 22 },
                    { 847, new Guid("a4593923-6817-4acd-a877-325236738bb4"), "آباده", 23 },
                    { 800, new Guid("35d299f2-28ac-4738-98c8-58f91684ad65"), "تسوج", 22 },
                    { 798, new Guid("78a5c55b-cb3c-4d22-80f3-f51e480a11b3"), "ترک", 22 },
                    { 797, new Guid("fcf1b63c-bee2-43c8-8fdd-e9ae92fa049b"), "تبريز", 22 },
                    { 796, new Guid("fcd213ed-99f4-4226-951d-50f26403c5ce"), "بناب مرند", 22 },
                    { 795, new Guid("5f08d61c-3247-4f20-b477-cd7a83eca123"), "بناب", 22 },
                    { 794, new Guid("7c1b7c0c-f8ec-448b-afeb-0700c7e18a56"), "بستان آباد", 22 },
                    { 793, new Guid("d784296d-20f6-45d9-9255-739bd532d5dd"), "بخشايش", 22 },
                    { 792, new Guid("42ee92c8-f7a9-4d5a-9963-cc5fb935899d"), "باسمنج", 22 },
                    { 799, new Guid("7563d992-4892-4219-8d29-bf11aa5b1ea3"), "ترکمانچاي", 22 },
                    { 848, new Guid("cc9d5710-8876-4cc4-a262-1309a4969d40"), "آباده طشک", 23 },
                    { 849, new Guid("89dc828f-a6ba-4cac-9551-14d713b71a24"), "اردکان", 23 },
                    { 850, new Guid("d022b585-26c9-468a-b243-8ec618e05133"), "ارسنجان", 23 },
                    { 905, new Guid("189b920a-b65d-40ac-9f65-853510de8668"), "صغاد", 23 },
                    { 904, new Guid("6d3ab3b0-5ab9-435c-b750-240d2da59d03"), "شيراز", 23 },
                    { 903, new Guid("7419caac-5735-4936-b717-aff3881f896b"), "شهر پير", 23 },
                    { 902, new Guid("8f37abd6-95fc-4b29-96ba-2c80ff216d06"), "شهر جديد صدرا", 23 },
                    { 901, new Guid("652e82c0-35f6-4aec-97b6-e3781a1c6e73"), "ششده", 23 },
                    { 900, new Guid("5587c94d-ac93-4f9f-9aa4-e5b960cb01ef"), "سيدان", 23 },
                    { 899, new Guid("c528441e-d0e1-40e8-ac2e-a61eb4f95d92"), "سورمق", 23 },
                    { 898, new Guid("58eddbc2-b05d-4e96-a785-0b01d1b29797"), "سلطان شهر", 23 },
                    { 897, new Guid("9486727f-c921-43d5-be66-54aa59d51ee6"), "سعادت شهر", 23 },
                    { 896, new Guid("c441d2f7-759e-46ab-a149-afcae9ec136c"), "سروستان", 23 },
                    { 895, new Guid("31620ec8-990c-4890-b6f3-e06a7d76e803"), "سده", 23 },
                    { 894, new Guid("51322954-0554-498d-865d-1abd59d30563"), "زرقان", 23 },
                    { 893, new Guid("294b1a2a-72b4-463f-a66f-68347e2c6672"), "زاهد شهر", 23 },
                    { 892, new Guid("75edd580-b22f-4d92-8819-66b55025fabc"), "رونيز", 23 },
                    { 891, new Guid("303051e3-5b51-4819-b15d-2d3299821b16"), "رامجرد", 23 },
                    { 906, new Guid("da393084-1124-41e1-9fef-431b92d3747a"), "صفا شهر", 23 },
                    { 907, new Guid("f9bf0b23-3a81-4860-8699-eaec5be09110"), "علامرودشت", 23 },
                    { 908, new Guid("7c0adfea-b5b0-46e7-a65f-b9436e24ace9"), "عماد ده", 23 },
                    { 909, new Guid("f305dcdc-b5a4-46ca-bdba-ac47b35575ff"), "فدامي", 23 },
                    { 925, new Guid("0319ddcb-cef5-491a-a73d-f69c646edfb5"), "مرودشت", 23 },
                    { 924, new Guid("43147bb8-e063-496b-9d14-fa391a941e66"), "مبارک آباد", 23 },
                    { 923, new Guid("a3665f96-9ad6-4025-adc0-218385f0a304"), "مادرسليمان", 23 },
                    { 922, new Guid("765c31bf-6b05-41b2-9710-b67c6329ba70"), "لپوئي", 23 },
                    { 921, new Guid("a2bdcada-61a5-40c0-9540-949b8b79c347"), "لطيفي", 23 },
                    { 920, new Guid("5344ab40-4924-48fd-b699-536b38664356"), "لامرد", 23 },
                    { 919, new Guid("c00f1d42-407b-4ac2-8243-11dc5210f962"), "لار", 23 },
                    { 890, new Guid("cf9376fb-27e8-49dc-bab3-950635ebd183"), "دژکرد", 23 },
                    { 918, new Guid("7a9332a9-539c-470f-b5eb-582db685e444"), "قير", 23 },
                    { 916, new Guid("6df831a6-cc21-488a-9fce-bc5426dc3150"), "قطب آباد", 23 },
                    { 915, new Guid("aaa749fe-b761-46f8-84bf-1983aed3c938"), "قره بلاغ", 23 },
                    { 914, new Guid("8a1a01a5-0169-4559-bd3f-a3a6deaa4529"), "قادرآباد", 23 },
                    { 913, new Guid("5b42c49d-7a15-476f-b7ce-af70690e83db"), "قائميه", 23 },
                    { 912, new Guid("7bdbb58a-6604-47b9-b9aa-be82d901ed62"), "فيروزآباد", 23 },
                    { 911, new Guid("89cc9d6d-1a4c-4beb-aac8-559cc78bd9bf"), "فسا", 23 },
                    { 910, new Guid("60da57b8-2391-4bd4-93b6-193f7f8e8bfe"), "فراشبند", 23 },
                    { 917, new Guid("6bd9b4a6-d163-4756-89a5-eb714cb11494"), "قطرويه", 23 },
                    { 889, new Guid("c3646013-3d68-471f-961e-0fb0b0ac0757"), "دوزه", 23 },
                    { 888, new Guid("7899d8c7-ea5c-4147-90eb-e19e578af38c"), "دوبرجي", 23 },
                    { 887, new Guid("4dc5eb48-4bf3-4028-a892-1591693e997b"), "دهرم", 23 },
                    { 866, new Guid("afec48e4-e5f7-4487-b59f-9c968c0471bc"), "بوانات", 23 },
                    { 865, new Guid("a3dcecdd-7d3c-4384-8df7-ad66cb54a802"), "بهمن", 23 },
                    { 864, new Guid("5e5408db-5292-468d-ac41-cefa965faf08"), "بنارويه", 23 },
                    { 863, new Guid("7391f94c-5544-47c4-a630-51feb2070f6f"), "بالاده", 23 },
                    { 862, new Guid("2f74f150-1ee7-4d17-a40c-3e4e695f3687"), "بابامنير", 23 },
                    { 861, new Guid("b8773c45-1a8b-4517-b805-ecd9f0f4d282"), "باب انار", 23 },
                    { 860, new Guid("34de9cd1-eb06-4e0d-92cd-b29400d96122"), "ايزد خواست", 23 },
                    { 867, new Guid("00a44254-ec75-47cb-b865-7fe9fe81ba4c"), "بيرم", 23 },
                    { 859, new Guid("86726d26-57b6-4f39-95cc-b64519d9f4e9"), "ايج", 23 },
                    { 857, new Guid("373b7f19-848c-4e50-bad4-8b6b174f95e1"), "اهل", 23 },
                    { 856, new Guid("8036c72f-39ac-414b-9aed-b45d47d3c293"), "امام شهر", 23 },
                    { 855, new Guid("3ee4ae12-9399-427f-af58-a2d4fffa67ba"), "اقليد", 23 },
                    { 854, new Guid("9adea4f3-36b8-4bf1-b783-1ae15a47136b"), "افزر", 23 },
                    { 853, new Guid("6759f3d9-6c29-4420-940f-cb2f80560344"), "اشکنان", 23 },
                    { 852, new Guid("71b87095-3180-44c2-b57d-5446648acf32"), "اسير", 23 },
                    { 851, new Guid("84297ad3-bbd1-40fd-8a2f-9c8cbc6c2e8f"), "استهبان", 23 },
                    { 858, new Guid("f2b45ec3-e138-4a9e-aada-f236f1b44d41"), "اوز", 23 },
                    { 772, new Guid("a9d81b41-8fb1-4178-a026-fc5628ac25fd"), "لواسان", 21 },
                    { 868, new Guid("b0a99cfe-64b0-4ed8-893e-2cd875d2dbe1"), "بيضا", 23 },
                    { 870, new Guid("bd8ce527-6819-4f3f-959c-86f722fdd9ef"), "جهرم", 23 },
                    { 886, new Guid("813fbcb0-1200-4117-b76e-414c61892516"), "دبيران", 23 },
                    { 885, new Guid("40db343d-e269-4926-a796-49afcfaae2ce"), "داريان", 23 },
                    { 884, new Guid("14e7e943-7715-415b-9f32-90f788edbfb5"), "داراب", 23 },
                    { 883, new Guid("8c39b47f-3f31-46bf-a362-8ce9efc610e9"), "خومه زار", 23 },
                    { 882, new Guid("4b48bb35-2cce-4c56-b1aa-09ac94195bca"), "خوزي", 23 },
                    { 881, new Guid("d0dddbdf-ffda-4e00-8325-50f0f2566719"), "خور", 23 },
                    { 880, new Guid("04c0b310-2850-4bc2-b25e-fb69bb4cfcb8"), "خنج", 23 },
                    { 869, new Guid("b0db855b-2495-4764-bfb5-fce7ae5bff52"), "جنت شهر", 23 },
                    { 879, new Guid("ab2685ab-3176-4318-a399-b4feb6f73444"), "خشت", 23 },
                    { 877, new Guid("ad25b8d0-72b2-43fb-b43d-4415a298aeb7"), "خاوران", 23 },
                    { 876, new Guid("c20a4553-b37d-48d4-accd-058fd3806c2b"), "خانيمن", 23 },
                    { 875, new Guid("9f53a36f-12fa-4e7b-9d85-232198b57c16"), "خانه زنيان", 23 },
                    { 874, new Guid("3649d9e5-9fb5-4940-b8a5-ad0ca26e1aa4"), "حسن آباد", 23 },
                    { 873, new Guid("20338979-b98e-4df8-b630-281aadc62dc4"), "حسامي", 23 },
                    { 872, new Guid("469001e2-6d14-4dc4-a6ca-8f1825e65205"), "حاجي آباد", 23 },
                    { 871, new Guid("245f863e-d4c7-40aa-858d-052cb9e92a0a"), "جويم", 23 },
                    { 878, new Guid("077c4634-b822-429a-b490-580965bb8ee9"), "خرامه", 23 },
                    { 771, new Guid("410e80e3-c013-4779-b02f-62b908b0066d"), "قرچک", 21 },
                    { 770, new Guid("395b23aa-182d-4d00-9af4-78ef566a459b"), "قدس", 21 },
                    { 769, new Guid("f4bd0ce6-94b8-4f55-8db3-7419440ce4cd"), "فيروزکوه", 21 },
                    { 669, new Guid("7fa7bce8-9764-4b2a-9353-4aa5a1209389"), "عسگران", 19 },
                    { 668, new Guid("9ea177ba-c84d-404a-99bd-2873a14919e3"), "طرق رود", 19 },
                    { 667, new Guid("d5f36444-6da5-4941-a4bc-083e4d80934c"), "طالخونچه", 19 },
                    { 666, new Guid("d16cbaba-aa65-4c62-8da2-f4bb52b535ae"), "شهرضا", 19 },
                    { 665, new Guid("8db5cca2-ced3-4e1a-8680-b77e8c8285b7"), "شاپورآباد", 19 },
                    { 664, new Guid("a19b3477-a5af-450b-8191-13839160b347"), "شاهين شهر", 19 },
                    { 663, new Guid("38f929af-6a68-4409-b173-07e20d5806d4"), "سگزي", 19 },
                    { 662, new Guid("2b173250-060c-4f4f-9c62-584768527e27"), "سين", 19 },
                    { 661, new Guid("6b92552f-39cf-492c-ac36-1116808d9420"), "سميرم", 19 },
                    { 660, new Guid("49f50499-ba72-471d-b124-f61c9ca83a30"), "سفيد شهر", 19 },
                    { 659, new Guid("ceea9f21-2ae6-4701-bcc7-678a64e420d3"), "سده لنجان", 19 },
                    { 658, new Guid("80cd51a2-80a8-41dc-9b99-f2a98755f8d7"), "زيباشهر", 19 },
                    { 657, new Guid("f95bebf6-a1ac-49dd-9bf3-0372eac7b002"), "زيار", 19 },
                    { 656, new Guid("9eb3c62d-017a-4ab7-bae8-dab9db1b6edb"), "زواره", 19 },
                    { 655, new Guid("984be769-38cb-4f8f-80d6-295fcf8d1854"), "زرين شهر", 19 },
                    { 670, new Guid("93d70bc6-71f6-43d5-bacf-731505521b8f"), "علويچه", 19 },
                    { 671, new Guid("ef874061-f3de-4482-bd3d-23bd1307a373"), "فرخي", 19 },
                    { 672, new Guid("61f00c09-2ebf-4db7-98a2-dcfceffa4b4f"), "فريدونشهر", 19 },
                    { 673, new Guid("e2dce5f1-6f3b-4a51-943f-cc4f75ceb58a"), "فلاورجان", 19 },
                    { 689, new Guid("7851d5cf-aa2e-4342-b1ff-a6cb2c63f41a"), "نوش آباد", 19 },
                    { 688, new Guid("0d6876bf-73d5-4455-9288-2a0913b2c9f4"), "نطنز", 19 },
                    { 687, new Guid("b2b03746-5210-4c53-a8f4-6af55ce507ad"), "نصرآباد", 19 },
                    { 686, new Guid("7eac7ee3-edf1-49bb-a30f-22ec8ae559e5"), "نجف آباد", 19 },
                    { 685, new Guid("49c85354-e5ec-4ced-abd8-3d97c8e087fe"), "نائين", 19 },
                    { 684, new Guid("bb051ee1-3972-4b6c-a85f-cf7171ea3766"), "ميمه", 19 },
                    { 683, new Guid("44d8a9a8-8ce5-4f59-82f6-bc10bdcf11bf"), "مهاباد", 19 },
                    { 654, new Guid("26bec9dd-a0a3-4f2c-a20d-6f0ae762dee2"), "زاينده رود", 19 },
                    { 682, new Guid("2143ef1f-bf5f-4d1f-9061-c971bf53cb0f"), "منظريه", 19 },
                    { 680, new Guid("9b884d25-fcbb-4c41-b732-5e2f493c655a"), "محمد آباد", 19 },
                    { 679, new Guid("4e4bf021-78c9-40f7-972e-f694dcaf01a7"), "مبارکه", 19 },
                    { 678, new Guid("66d2acc4-2afe-4739-988f-f4e2276f8038"), "لاي بيد", 19 },
                    { 677, new Guid("3c1c0bc3-1d49-42f9-b0da-77e7a6905c31"), "قهدريجان", 19 },
                    { 676, new Guid("12351e8e-9b68-4072-ab9f-ae85b3de9e82"), "قهجاورستان", 19 },
                    { 675, new Guid("18e5dc82-a694-42d2-9d6d-a7b4701babb0"), "قمصر", 19 },
                    { 674, new Guid("ed8d9574-3d06-48d4-b673-068ffd495fef"), "فولاد شهر", 19 },
                    { 681, new Guid("cab63cd4-547c-4a54-af40-9431912bd876"), "مشکات", 19 },
                    { 653, new Guid("276208b7-8c56-4d00-9a93-228dec83d668"), "زازران", 19 },
                    { 652, new Guid("ef0977e9-f0a7-4233-be3a-16e00c89ba9c"), "رضوانشهر", 19 },
                    { 651, new Guid("a0f08dee-b954-4096-9713-232149b2c3cb"), "رزوه", 19 },
                    { 630, new Guid("1e413548-4296-4317-97e0-3af45ff0b239"), "تودشک", 19 },
                    { 629, new Guid("944b176b-e5c2-44c8-8549-9418478ae250"), "بوئين مياندشت", 19 },
                    { 628, new Guid("2a1fa9c1-99b1-41fe-8b1b-35c1295624fc"), "بهارستان", 19 },
                    { 627, new Guid("7f1318ec-d551-4097-b4b8-8f3a5c34d752"), "بهاران شهر", 19 },
                    { 626, new Guid("8264558d-5a87-42ca-bc7b-5c7fac2f4bce"), "برف انبار", 19 },
                    { 625, new Guid("cae17af0-5ac4-49d9-be1a-321d04454a7b"), "برزک", 19 },
                    { 624, new Guid("86c266c6-8b93-48d9-92ce-98bade03ea0c"), "بافران", 19 },
                    { 631, new Guid("c82a7ba4-8830-4d7d-81ad-4efe970e31fa"), "تيران", 19 },
                    { 623, new Guid("c4056a4f-45c2-44fd-ab1f-715fc52c1ac5"), "باغشاد", 19 },
                    { 621, new Guid("9bc5a798-a736-4d1f-97b3-ba5f4b90c280"), "بادرود", 19 },
                    { 620, new Guid("c547c934-61a3-4163-8bd0-4c935a1df159"), "اژيه", 19 },
                    { 619, new Guid("da9387b5-dd95-4a04-8e4b-0086c7d5247f"), "ايمانشهر", 19 },
                    { 618, new Guid("bc084a72-2063-4724-b86e-538c55d49d11"), "انارک", 19 },
                    { 617, new Guid("26ceaeab-e57d-45d4-8feb-9fb5efc4f3f8"), "افوس", 19 },
                    { 616, new Guid("e06611a9-bb24-44ba-82e9-6a740d566533"), "اصفهان", 19 },
                    { 615, new Guid("ac776d8d-1114-40e2-b3db-4212c0739610"), "اصغرآباد", 19 },
                    { 622, new Guid("8635156e-9aff-4ce6-928b-f7051b259ce8"), "باغ بهادران", 19 },
                    { 690, new Guid("b87fbe16-e43d-4305-859f-a1dc13188a51"), "نياسر", 19 },
                    { 632, new Guid("869c510d-89b4-4aae-8e87-b4caa6592e46"), "جندق", 19 },
                    { 634, new Guid("844f9e7b-6f40-4f91-b289-9d19cb25e07a"), "جوشقان قالي", 19 },
                    { 650, new Guid("16f4d410-1c49-4430-84e9-db20c1eff403"), "ديزيچه", 19 },
                    { 649, new Guid("b6dbd70d-1fd6-4105-b6b3-8847367ebbdf"), "دولت آباد", 19 },
                    { 648, new Guid("fa147778-16a7-4769-92ed-466e1ddc842a"), "دهق", 19 },
                    { 647, new Guid("87988b92-909b-45e0-aae3-ef7abaceec6b"), "دهاقان", 19 },
                    { 646, new Guid("aa972baf-5bf2-43da-bb61-5147b1e897e8"), "دستگرد", 19 },
                    { 645, new Guid("043b89ce-dbdf-4efb-a087-aaef24ff9443"), "درچه پياز", 19 },
                    { 644, new Guid("8e99162a-2759-4b01-a443-220cabf250e9"), "دامنه", 19 },
                    { 633, new Guid("531e1828-8b22-4ec4-bf75-9ae110ebf4f2"), "جوزدان", 19 },
                    { 643, new Guid("fdec24e4-e5bb-439d-85c4-8797696cbbfb"), "داران", 19 },
                    { 641, new Guid("019c3a84-032d-428e-8b71-ae8ea6f47297"), "خور", 19 },
                    { 640, new Guid("b5e3a01e-7d33-447f-a576-619ad4140b4e"), "خوانسار", 19 },
                    { 639, new Guid("81b3c606-5e1c-4ebc-a3bf-8ff0afa64aaf"), "خميني شهر", 19 },
                    { 638, new Guid("e5e9c681-bfed-4caa-a394-4839e010e3bc"), "خالد آباد", 19 },
                    { 637, new Guid("d8aa296c-d2b2-4a0d-96b5-19090cecf51b"), "حنا", 19 },
                    { 636, new Guid("4b5468a5-fe42-4da6-b48d-022ad5d7c363"), "حسن آباد", 19 },
                    { 635, new Guid("c5991e93-6926-4efa-ad4e-afa866072e18"), "حبيب آباد", 19 },
                    { 642, new Guid("90f01b3b-1a97-482c-8a8b-28a68871be3c"), "خورزوق", 19 },
                    { 926, new Guid("69fd8206-d0df-427b-bf10-ce060aba19f5"), "مزايجان", 23 },
                    { 691, new Guid("43712c15-59e5-46ab-8b01-283e06cb8a0d"), "نيک آباد", 19 },
                    { 693, new Guid("f369f3c3-d088-4627-8b0d-fac9150b1b4f"), "ورزنه", 19 },
                    { 748, new Guid("a5c5b0fe-6245-4387-96f5-55ccdaca6995"), "باقرشهر", 21 },
                    { 747, new Guid("5e7e8853-cee2-4ae4-bc33-895a6a30946e"), "باغستان", 21 },
                    { 746, new Guid("5e8baf8d-e6aa-4361-8ea1-208ceb06f7fa"), "انديشه", 21 },
                    { 745, new Guid("384f4861-7078-4a9d-bf25-058f220711c2"), "اسلامشهر", 21 },
                    { 744, new Guid("3fa00130-78c2-4509-96ca-9ffce05e575d"), "ارجمند", 21 },
                    { 743, new Guid("1bbe0e02-3fe6-4253-ad4a-e02177bc78ad"), "آبعلي", 21 },
                    { 742, new Guid("94f069b8-3653-43f0-9829-711a7022fa9f"), "آبسرد", 21 },
                    { 741, new Guid("35e8d48d-281b-4d6c-aa6e-09d6032b3bde"), "چوار", 20 },
                    { 740, new Guid("4ccfa460-5f75-4fb7-b142-3171288e48be"), "پهله", 20 },
                    { 739, new Guid("6c4b2e36-b9f4-4a15-8326-201226475181"), "ميمه", 20 },
                    { 738, new Guid("8f07fa5b-1913-4209-b677-af7b40b6959d"), "موسيان", 20 },
                    { 737, new Guid("ef40507d-b3b1-400c-8069-8eac465da2bf"), "مورموري", 20 },
                    { 736, new Guid("fcc1a4f1-3d65-4fac-90af-3699f91b4598"), "مهران", 20 },
                    { 735, new Guid("069c3f1e-a2bc-43a1-9106-d9490d5a9d45"), "مهر", 20 },
                    { 734, new Guid("8095b671-55a7-4ea4-b9dc-7a340d98a297"), "ماژين", 20 },
                    { 749, new Guid("44de9b4c-fa48-4b3b-934c-c2b2ad122e33"), "بومهن", 21 },
                    { 750, new Guid("6cacc97b-61f7-4613-b5f7-cf8a39530fd0"), "تجريش", 21 },
                    { 751, new Guid("ac90771f-e7e6-47ac-a05f-4603ca206dfa"), "تهران", 21 },
                    { 752, new Guid("f8392b72-1e0b-417a-93ca-ff35c9159977"), "جواد آباد", 21 },
                    { 768, new Guid("2f20e4ac-8f54-4c7a-ae81-fc5447e1548d"), "فشم", 21 },
                    { 767, new Guid("a4c3d38e-9128-4265-886b-c77658e242e6"), "فرون آباد", 21 },
                    { 766, new Guid("dda13a44-6bc0-4a9d-b767-ac351b0343be"), "فردوسيه", 21 },
                    { 765, new Guid("206284f9-2bf0-4047-9d0e-dd6a8ada86e1"), "صفادشت", 21 },
                    { 764, new Guid("0c3ef935-fd7f-42e0-bff7-2da3dc8ee676"), "صبا شهر", 21 },
                    { 763, new Guid("f830181b-4dad-406e-9d30-268c86d2d9ea"), "صالحيه", 21 },
                    { 762, new Guid("d6d094b9-2af9-4760-abac-dc3b7e3d0555"), "شهريار", 21 },
                    { 733, new Guid("e5cb4502-8336-4b91-8594-2de145e0e704"), "لومار", 20 },
                    { 761, new Guid("00146e9c-7053-41f3-a6ab-407bc3400d7f"), "شهر جديد پرند", 21 },
                    { 759, new Guid("9949a7ae-3a0e-418f-9ec0-7af5a228690b"), "شريف آباد", 21 },
                    { 758, new Guid("beffae53-0207-46c3-b480-f9b50762d840"), "شاهدشهر", 21 },
                    { 757, new Guid("acf5b3e9-5baf-430e-8284-78843f0b493e"), "ري", 21 },
                    { 756, new Guid("a7cfe537-d3bf-42f5-aa5d-2cfd87c08b56"), "رودهن", 21 },
                    { 755, new Guid("bf6a5f7c-60af-42b6-a738-b9ebce45e186"), "رباط کريم", 21 },
                    { 754, new Guid("45a11c6b-b0df-451e-989a-e6ac6d3cd07c"), "دماوند", 21 },
                    { 753, new Guid("c03f1284-5b52-4e97-8a5f-ba97d6c0b824"), "حسن آباد", 21 },
                    { 760, new Guid("cbb0b029-fc0c-4e1b-8ea2-6304fa538533"), "شمشک", 21 },
                    { 732, new Guid("c784c41e-2b82-4525-96da-159ed7d8f775"), "صالح آباد", 20 },
                    { 731, new Guid("b5d790af-2aa7-446c-87e7-9be76b6d9ddf"), "شباب", 20 },
                    { 730, new Guid("d7521e54-9c57-49c0-849c-68f9f61cd1f6"), "سرابله", 20 },
                    { 709, new Guid("9d60cd6c-0763-4e57-865f-5668da57d0a0"), "کوهپايه", 19 },
                    { 708, new Guid("331b4221-8312-4940-a8b5-b35059ff65c3"), "کوشک", 19 },
                    { 707, new Guid("a7c7ed14-2eb4-492b-a1aa-87b2ea08c3da"), "کهريزسنگ", 19 },
                    { 706, new Guid("c67cb7ba-450b-4c4f-98a4-857770d3a588"), "کمه", 19 },
                    { 705, new Guid("1ae29618-21b2-430b-83f8-20cf2f8129e7"), "کمشجه", 19 },
                    { 704, new Guid("70d08470-dd75-4495-8b02-83aba9cc0982"), "کليشاد و سودرجان", 19 },
                    { 703, new Guid("6a1bbfef-bbb0-4ccf-a64a-bad6352975ef"), "کرکوند", 19 },
                    { 710, new Guid("61cce136-0484-4d0f-9e00-8da56d12e3f8"), "گرگاب", 19 },
                    { 702, new Guid("d942a6af-fc74-4e9e-ae75-2f0ae34e0520"), "کامو و چوگان", 19 },
                    { 700, new Guid("d7b4ac4a-d985-41e4-89bc-764667739fcc"), "چمگردان", 19 },
                    { 699, new Guid("f6b4057e-87a6-4576-a4e1-11fb9cd444d1"), "چرمهين", 19 },
                    { 698, new Guid("0ee87ecc-f561-48f0-bcba-e31a6ffb6cc8"), "چادگان", 19 },
                    { 697, new Guid("f7418a80-be28-4780-8a8f-a8d4f80b8dec"), "پير بکران", 19 },
                    { 696, new Guid("21b50226-7ac0-4c83-b511-f1d3fb56cf34"), "ونک", 19 },
                    { 695, new Guid("b60f461b-ea5b-4df4-a5c7-fd04f51b102d"), "وزوان", 19 },
                    { 694, new Guid("3f6d121d-6d33-429f-8ce2-32801f51c463"), "ورنامخواست", 19 },
                    { 701, new Guid("0706f6dd-a6d2-46fb-b4c7-9525f36736f0"), "کاشان", 19 },
                    { 692, new Guid("08ad6be1-2f33-4de7-ad31-0332dee0ac72"), "هرند", 19 },
                    { 711, new Guid("f7a62f46-482d-47cf-b652-50eae0b6521f"), "گز برخوار", 19 },
                    { 713, new Guid("0481c89a-a5b1-4f44-baac-578b29f862f0"), "گلشن", 19 },
                    { 729, new Guid("b00c0389-d972-400a-841f-a7e70aa4a636"), "سراب باغ", 20 },
                    { 728, new Guid("2e9ffae7-ffd9-4c93-9ccc-ab75d00db5b8"), "زرنه", 20 },
                    { 727, new Guid("f6184195-ec4b-41d7-9f68-1892807a03ae"), "دهلران", 20 },
                    { 726, new Guid("15ddda24-20ee-4762-ad14-3c1bd4753afb"), "دلگشا", 20 },
                    { 725, new Guid("464e4616-5081-49a3-978a-679072c166a2"), "دره شهر", 20 },
                    { 724, new Guid("99f600de-6070-4657-8dfd-a2fa3391adfa"), "توحيد", 20 },
                    { 723, new Guid("2611c456-66e4-4ba5-b675-15389e25d853"), "بلاوه", 20 },
                    { 712, new Guid("000865fd-c781-43cb-bd33-8759fa1fa353"), "گلدشت", 19 },
                    { 722, new Guid("0b29c3eb-7ef9-40e2-80b2-c877b047f6f4"), "بدره", 20 },
                    { 720, new Guid("38c5d7ad-a2d1-4f15-bdef-c5053febfb61"), "ايلام", 20 },
                    { 719, new Guid("0148429b-e303-45b8-a817-97c28a080f44"), "ارکواز", 20 },
                    { 718, new Guid("5f07154f-955b-44a7-9ea3-50be470c2fb4"), "آسمان آباد", 20 },
                    { 717, new Guid("1dd5fd27-dbe0-4717-98f1-f4a4f61cf375"), "آبدانان", 20 },
                    { 716, new Guid("27091036-7dd0-437e-a63e-d8310a4efa13"), "گوگد", 19 },
                    { 715, new Guid("0ad897bc-8d3f-4f40-bac9-b106b257d9f1"), "گلپايگان", 19 },
                    { 714, new Guid("7f2cb021-3a91-4ff6-8ef9-6ec3c40d215d"), "گلشهر", 19 },
                    { 721, new Guid("b366e1af-f240-436d-a510-a38ba6aa77e2"), "ايوان", 20 },
                    { 927, new Guid("37d5696e-c138-42c6-917f-1aba06befe72"), "مشکان", 23 },
                    { 928, new Guid("d31e2cbb-1d40-4933-b8c2-4c673ab76a7f"), "مصيري", 23 },
                    { 929, new Guid("5950558a-0f04-4d15-951e-001a4059f9d4"), "مهر", 23 },
                    { 1141, new Guid("78957e6e-c939-473c-8e03-227bdb243fa0"), "بردسير", 29 },
                    { 1140, new Guid("ecae9b06-e510-430e-9264-4c6c91153515"), "بافت", 29 },
                    { 1139, new Guid("8c457c1c-4e33-4b82-bbfa-50ca83d0a06a"), "باغين", 29 },
                    { 1138, new Guid("880d5535-a726-4147-944d-651fbec3766b"), "اندوهجرد", 29 },
                    { 1137, new Guid("3aa70aa3-a5be-4c2f-ae2e-8b9528ba4477"), "انار", 29 },
                    { 1136, new Guid("c67ae1e8-0062-46bc-b4cf-4301d73e405e"), "امين شهر", 29 },
                    { 1135, new Guid("6d97410a-bdfe-4ed9-be54-4dc0ecbdbb0e"), "ارزوئيه", 29 },
                    { 1134, new Guid("fd4f0784-6b28-4313-86f3-26a7cfd0f882"), "اختيار آباد", 29 },
                    { 1133, new Guid("ffa8562f-cdc7-44fe-a0b0-1682991cc919"), "گيان", 28 },
                    { 1132, new Guid("235e05e9-aa09-42cc-8405-42ef12a48404"), "گل تپه", 28 },
                    { 1131, new Guid("883f3007-e0d8-415d-a5a3-2733b9998562"), "کبودر آهنگ", 28 },
                    { 1130, new Guid("d5864aa7-8fdc-4ed9-bb6f-5a7f91c46333"), "همدان", 28 },
                    { 1129, new Guid("7f87cb6f-68f9-46f2-8c34-18f798d76f52"), "نهاوند", 28 },
                    { 1128, new Guid("85c0b161-46c2-4b51-b440-f376c5eb7f18"), "مهاجران", 28 },
                    { 1127, new Guid("8dd5136a-2230-4b81-a008-f4e4cd624be3"), "ملاير", 28 },
                    { 1142, new Guid("eff8587c-62f1-4c13-9e59-910b315f2ca7"), "بروات", 29 },
                    { 1143, new Guid("2e280295-29fa-4654-9b31-a697f25a88ad"), "بزنجان", 29 },
                    { 1144, new Guid("ce119112-bff1-4463-a9c3-9000faa8bdc1"), "بلورد", 29 },
                    { 1145, new Guid("0f27c5eb-2aa9-4f30-b21f-82bc9a458072"), "بلوک", 29 },
                    { 1161, new Guid("b4d418fb-66f1-4562-9fab-2282ba4b0fd2"), "راور", 29 },
                    { 1160, new Guid("3692032f-3863-415e-beb8-4e582c31f197"), "رابر", 29 },
                    { 1159, new Guid("5d3e7e4f-d5dd-4f80-a167-cfcabeeae03b"), "دوساري", 29 },
                    { 1158, new Guid("cacf5be1-c41b-4edd-967e-730462b8bd57"), "دهج", 29 },
                    { 1157, new Guid("869c1cf5-fae5-468f-a8da-6cf54a4f5a27"), "دشتکار", 29 },
                    { 1156, new Guid("a0ecfb06-f50f-4006-94e3-19ce826b9af9"), "درب بهشت", 29 },
                    { 1155, new Guid("a7cf9532-7d9f-4b17-b9b1-ae0301fda510"), "خورسند", 29 },
                    { 1126, new Guid("b19fc347-8779-44ba-ad3b-affdc3b255c1"), "مريانج", 28 },
                    { 1154, new Guid("418f749c-86b4-4c01-8736-9804ec721ae4"), "خواجوشهر", 29 },
                    { 1152, new Guid("9dced347-655c-4c3b-8cf3-d68b01edcb3b"), "خاتون آباد", 29 },
                    { 1151, new Guid("2eccd60d-a964-42c2-8f75-8e42a16ccf79"), "جيرفت", 29 },
                    { 1150, new Guid("6c716c2d-b7f0-4093-b3a8-9e20302845ba"), "جوپار", 29 },
                    { 1149, new Guid("3cd237c9-7250-4479-ac43-f6072ef3fba7"), "جوزم", 29 },
                    { 1148, new Guid("b672c70f-ac9b-4f6f-8571-98ff723fe1d6"), "جبالبارز", 29 },
                    { 1147, new Guid("d4b72a89-a22c-485f-9e8a-cca64f6d4fe1"), "بهرمان", 29 },
                    { 1146, new Guid("19256728-14a8-4847-b416-46eda5cae289"), "بم", 29 },
                    { 1153, new Guid("2d6d1644-e14e-4ce6-aa7d-1cfdbee7a0b0"), "خانوک", 29 },
                    { 1162, new Guid("06f6395c-22d4-406e-9b8d-db997d080746"), "راين", 29 },
                    { 1125, new Guid("58a10011-86b2-41e7-85a1-aab13dcb90f6"), "لالجين", 28 },
                    { 1123, new Guid("e5fea714-1673-4cb8-8817-4a9720ca0e5e"), "قروه در جزين", 28 },
                    { 1102, new Guid("1a64ca2b-9496-45f6-a072-49534eaa0d4a"), "کوچصفهان", 27 },
                    { 1101, new Guid("ed30d8fb-70ca-4a6c-99d3-c238088f7a1c"), "کومله", 27 },
                    { 1100, new Guid("8a52e8b9-7aa0-456f-9d83-7dfead51a376"), "کلاچاي", 27 },
                    { 1099, new Guid("ccaf21b1-0701-4679-b374-4e923fa0cc83"), "چوبر", 27 },
                    { 1098, new Guid("bfda51df-0969-4d8d-93d2-9feac8d76ebf"), "چاف و چمخاله", 27 },
                    { 1097, new Guid("c3c4baa1-c7aa-4caf-8f4a-f1d1a4085b05"), "چابکسر", 27 },
                    { 1096, new Guid("70bfe2a7-c1aa-4409-89a8-9eed4f2827d8"), "پره سر", 27 },
                    { 1095, new Guid("68e7cd04-0a20-4de3-9b17-4b3ffa326e68"), "واجارگاه", 27 },
                    { 1094, new Guid("c35fa332-2d5b-484a-92de-4da1077c1cba"), "هشتپر", 27 },
                    { 1093, new Guid("e527a474-56da-448f-b389-76dcaa9914c0"), "منجيل", 27 },
                    { 1092, new Guid("6bf77fbf-6a41-468e-bbdf-02c8e996187e"), "مرجقل", 27 },
                    { 1091, new Guid("9b8d0d4a-f420-477e-aae7-aa0cb95cd061"), "ماکلوان", 27 },
                    { 1090, new Guid("be162537-2539-4dab-8683-53cf3a259926"), "ماسوله", 27 },
                    { 1089, new Guid("bff8c003-7aa6-470c-96ed-baeb5ccca461"), "ماسال", 27 },
                    { 1088, new Guid("58fb437c-ad1b-427d-9a4f-46bb43943216"), "ليسار", 27 },
                    { 1103, new Guid("c7839812-2090-4fc0-bb0b-043157b897cc"), "کياشهر", 27 },
                    { 1104, new Guid("021c747f-bf72-4c4c-87bf-daff0b2b4ce5"), "گوراب زرميخ", 27 },
                    { 1105, new Guid("a1b5cdf3-d683-4a46-b3a0-a164806dd29a"), "آجين", 28 },
                    { 1106, new Guid("335c10c1-05e3-4e20-84c6-a765f7f744c8"), "ازندريان", 28 },
                    { 1122, new Guid("72c55f25-125b-41a3-8731-4163b3ac6c66"), "فيروزان", 28 },
                    { 1121, new Guid("f5b31724-6adb-44eb-b389-56aaab1d659f"), "فرسفج", 28 },
                    { 1120, new Guid("26149141-9cfb-4c8a-9a79-e0a6df92064d"), "فامنين", 28 },
                    { 1119, new Guid("5887d2e9-8e30-4500-b1d4-9aaf5a883c2c"), "صالح آباد", 28 },
                    { 1118, new Guid("ef0cc705-0be9-475e-823f-ec622a8f1b02"), "شيرين سو", 28 },
                    { 1117, new Guid("6082e6d1-7816-455d-b709-cc45d0d2e9ac"), "سرکان", 28 },
                    { 1116, new Guid("832ddc1c-cd01-4bbe-9e43-03344befa9f5"), "سامن", 28 },
                    { 1124, new Guid("0078321a-3a99-4759-9051-f79297599762"), "قهاوند", 28 },
                    { 1115, new Guid("f42660e1-e725-44be-bf3f-a03f007ebfa9"), "زنگنه", 28 },
                    { 1113, new Guid("d0184832-18a4-40b9-a504-a60a453404cb"), "دمق", 28 },
                    { 1112, new Guid("6ee8482a-410e-44cb-8717-8f1a23534ee4"), "جوکار", 28 },
                    { 1111, new Guid("5edf24b3-9fd0-48c4-9d2b-0e510981c566"), "جورقان", 28 },
                    { 1110, new Guid("85954d9c-0670-4d4b-a7ed-6558a86f493d"), "تويسرکان", 28 },
                    { 1109, new Guid("913db810-cec7-41e3-9606-1b434a88b7cc"), "بهار", 28 },
                    { 1108, new Guid("9887ad0a-e0ab-464d-b44c-b220bcfd1bd9"), "برزول", 28 },
                    { 1107, new Guid("ef8432a1-61d6-4bb5-b80a-918d5d59287b"), "اسد آباد", 28 },
                    { 1114, new Guid("5ecf0bf0-be94-40db-b8cb-6c905ba88c52"), "رزن", 28 },
                    { 1163, new Guid("ae5a377a-1bd9-4482-a5b1-fe85c1fa4a4d"), "رفسنجان", 29 },
                    { 1164, new Guid("4c2f21e4-a9ae-444d-a930-56dcf2ae9a98"), "رودبار", 29 },
                    { 1165, new Guid("3fd1a61c-f5d3-441c-a838-f4e7e558e7ce"), "ريحان", 29 },
                    { 1220, new Guid("bba0422a-1107-4ee5-ba5e-9d0196036f02"), "ميامي", 30 },
                    { 1219, new Guid("93856a61-df3e-4d1e-bb71-573ca1df0748"), "مهدي شهر", 30 },
                    { 1218, new Guid("561dea2c-409b-44b5-9724-bdca186af07a"), "مجن", 30 },
                    { 1217, new Guid("894351b7-c870-40aa-b101-d4bb7e54f1a5"), "شهميرزاد", 30 },
                    { 1216, new Guid("cee8e460-fc72-4046-b20d-e8fbfa8198ab"), "شاهرود", 30 },
                    { 1215, new Guid("fd6b88f8-2dcf-4eb0-a665-01d36c89e1d8"), "سمنان", 30 },
                    { 1214, new Guid("dbbe7f47-efc7-4575-8598-905d3f20650f"), "سرخه", 30 },
                    { 1213, new Guid("5fbcc725-c1bd-4ef4-97bb-8644da9614f6"), "روديان", 30 },
                    { 1212, new Guid("754dbc6f-7c40-4d7d-8051-4d109df2bf6f"), "ديباج", 30 },
                    { 1211, new Guid("7dc196b3-b9e9-42c0-97fd-d6d1c3d4d703"), "درجزين", 30 },
                    { 1210, new Guid("2aee20d7-4a58-4cfe-8fa4-7ab6696c5e2e"), "دامغان", 30 },
                    { 1209, new Guid("f4132202-23da-44a9-9cfb-13a1aca69f22"), "بيارجمند", 30 },
                    { 1208, new Guid("7a7f5148-90a4-4583-8139-35d3cad353ed"), "بسطام", 30 },
                    { 1207, new Guid("99710274-7728-4ee4-85c9-7116183c7aaf"), "ايوانکي", 30 },
                    { 1206, new Guid("8febe6cc-9355-477d-9c41-17f0c19d67ba"), "اميريه", 30 },
                    { 1221, new Guid("847b33cf-546b-4e2c-8458-e3c9ce9e2171"), "کلاته", 30 },
                    { 1222, new Guid("a8441d5d-9421-41ec-8c08-979cadf40c3f"), "کلاته خيج", 30 },
                    { 1223, new Guid("6ebb79dd-f4c8-43db-87aa-287035c221c4"), "کهن آباد", 30 },
                    { 1224, new Guid("55322819-3669-4009-a055-608986aea2cd"), "گرمسار", 30 },
                    { 1240, new Guid("31de326e-51b3-4eee-95b3-aea51c14ed7c"), "چيتاب", 31 },
                    { 1239, new Guid("2e036526-53e8-4ec8-8c29-9c891e75449b"), "چرام", 31 },
                    { 1238, new Guid("7a6a226e-e07f-4aa9-808e-83981214cec8"), "پاتاوه", 31 },
                    { 1237, new Guid("766fe095-7855-4ca5-9985-e6801fadefa2"), "ياسوج", 31 },
                    { 1236, new Guid("df9d8201-c53e-4bb1-848b-c10e265bffbc"), "مارگون", 31 },
                    { 1235, new Guid("cbb97e25-ea3c-4456-ad7d-26f52120e3f4"), "مادوان", 31 },
                    { 1234, new Guid("21f3e48b-c577-4b2e-a05b-7a7ea4eea762"), "ليکک", 31 },
                    { 1205, new Guid("2655d2a4-121b-4ab2-a103-6f91ac3f8781"), "آرادان", 30 },
                    { 1233, new Guid("88e1ae28-8a52-440c-b74c-29651cfecb69"), "لنده", 31 },
                    { 1231, new Guid("9661078b-2616-420f-abe8-ae1a582512f2"), "سي سخت", 31 },
                    { 1230, new Guid("dbd7e8f9-7265-42bc-ae68-817f603f4b78"), "سوق", 31 },
                    { 1229, new Guid("ebc328b5-5e19-46e7-8725-80cf6fa24b04"), "سرفارياب", 31 },
                    { 1228, new Guid("60685948-192b-46db-8e5a-ed9da5057e02"), "ديشموک", 31 },
                    { 1227, new Guid("2ebdae2f-4beb-4998-a347-3dd074e5e40f"), "دوگنبدان", 31 },
                    { 1226, new Guid("66318e16-8061-43c8-b1da-a45755f9d1b1"), "دهدشت", 31 },
                    { 1225, new Guid("dd2de5f8-8ee9-4bac-9d59-95d7a8f1e060"), "باشت", 31 },
                    { 1232, new Guid("e3b4b909-320d-4de3-bb6e-70522aa39e42"), "قلعه رئيسي", 31 },
                    { 1204, new Guid("f7837006-cec9-45d4-945d-f61fad5bda48"), "گنبکي", 29 },
                    { 1203, new Guid("7617b880-cd1e-4284-a825-1058f507de0e"), "گلزار", 29 },
                    { 1202, new Guid("347eddfd-84e8-4a51-8ba1-e8b958735ac1"), "گلباف", 29 },
                    { 1181, new Guid("008cf8e7-2d19-49e9-bb5e-7a9b474fd810"), "محي آباد", 29 },
                    { 1180, new Guid("3c34089d-074d-4d09-a8b3-b3dbfb77771a"), "محمد آباد", 29 },
                    { 1179, new Guid("1c80315a-608c-4355-a489-598af1e57d9b"), "ماهان", 29 },
                    { 1178, new Guid("ef02d5a1-8914-4cef-af71-3a85cf38c144"), "لاله زار", 29 },
                    { 1177, new Guid("c8cf2d16-4828-4828-a209-a23c987e568b"), "قلعه گنج", 29 },
                    { 1176, new Guid("9520baec-1be2-4394-b204-7ec454be2e99"), "فهرج", 29 },
                    { 1175, new Guid("85732c47-0048-46b3-a549-c7872bd5563c"), "فارياب", 29 },
                    { 1182, new Guid("6e30aaed-25dc-4c6f-8ecf-b4978c1057a5"), "مردهک", 29 },
                    { 1174, new Guid("f1d0f031-ac7e-4c24-870b-5dd57366c3b0"), "عنبر آباد", 29 },
                    { 1172, new Guid("633dc450-eece-4f2c-a31e-2dc47145f8be"), "شهر بابک", 29 },
                    { 1171, new Guid("e001a62e-0c96-4e18-98a4-65c1f7dcccea"), "شهداد", 29 },
                    { 1170, new Guid("8de0b418-41af-4894-a591-794865271b24"), "سيرجان", 29 },
                    { 1169, new Guid("4a5a76b6-796a-4a39-8aa7-2c7821b6629f"), "زيد آباد", 29 },
                    { 1168, new Guid("8f7f48be-3bf0-4ded-9c1b-7294b9538990"), "زهکلوت", 29 },
                    { 1167, new Guid("d2185d85-4514-44a7-a401-f02bae6315d2"), "زنگي آباد", 29 },
                    { 1166, new Guid("01135ca9-cac3-45be-96bc-4906cc965283"), "زرند", 29 },
                    { 1173, new Guid("2bfbc3b2-c4cf-4ce0-9516-db0bdad1bef2"), "صفائيه", 29 },
                    { 1087, new Guid("11a281b6-c561-4d53-94cb-1d96a1bc7ff7"), "لوندويل", 27 },
                    { 1183, new Guid("8c725c9f-4b7a-4330-abe5-609549beebe0"), "مس سرچشمه", 29 },
                    { 1185, new Guid("d4e6f722-60ab-4482-89da-c748e387477d"), "نجف شهر", 29 },
                    { 1201, new Guid("1ef7ff29-ad56-4361-8a77-7e1842ab56b1"), "کيانشهر", 29 },
                    { 1200, new Guid("b203dd1e-7bc0-4f53-9ec3-b03e4a2b8b78"), "کوهبنان", 29 },
                    { 1199, new Guid("284a5301-4548-4094-9b79-95326e3bbce3"), "کهنوج", 29 },
                    { 1198, new Guid("ec745661-9679-4f33-8843-9c042a120ae7"), "کشکوئيه", 29 },
                    { 1197, new Guid("4131ecb9-5bbb-496e-82db-896cfc4e8653"), "کرمان", 29 },
                    { 1196, new Guid("143b2934-d7d3-4156-a5ee-28d9b09b8555"), "کاظم آباد", 29 },
                    { 1195, new Guid("68c7f84a-fa2f-4f9b-9f5a-661275ddb9f1"), "چترود", 29 },
                    { 1184, new Guid("c0211ad4-e5bd-477e-949f-dc0281cb8556"), "منوجان", 29 },
                    { 1194, new Guid("caa1f171-c53b-4586-b009-dd5567337ae1"), "پاريز", 29 },
                    { 1192, new Guid("6b77ab5b-6b77-4c57-99e5-853d55ece9b3"), "هنزا", 29 },
                    { 1191, new Guid("5fa1965a-85e9-4ee4-b0cc-c679b9acb3a2"), "هماشهر", 29 },
                    { 1190, new Guid("24c56830-4c7c-4ee9-8811-3be32494a66f"), "هجدک", 29 },
                    { 1189, new Guid("94361b04-b090-4edb-8191-e93dabd39171"), "نگار", 29 },
                    { 1188, new Guid("7f1bc542-04d3-44d8-8ad6-d57e40fe72d8"), "نودژ", 29 },
                    { 1187, new Guid("034333ac-0657-4ee6-a824-8710298bc8fe"), "نظام شهر", 29 },
                    { 1186, new Guid("7eb9ad79-c7aa-4073-8ac7-cbb71ab24b28"), "نرماشير", 29 },
                    { 1193, new Guid("71f66c55-ab17-42dd-b83f-c7cab9f2a72a"), "يزدان شهر", 29 },
                    { 1086, new Guid("029aa3cb-2c71-4726-b984-7cdea0f53431"), "لولمان", 27 },
                    { 1085, new Guid("5216984d-5252-479c-8117-4bf97c40b19d"), "لوشان", 27 },
                    { 1084, new Guid("f30e6cee-bdb0-4894-b4cd-6ee39d8e579c"), "لنگرود", 27 },
                    { 984, new Guid("6ceed47c-adc7-4abe-a258-5b16790f17ff"), "بندر عباس", 25 },
                    { 983, new Guid("93c0bf8f-1959-4d66-826a-9f0a4948f74c"), "بندر جاسک", 25 },
                    { 982, new Guid("dd98165e-cd83-4ccc-a325-fc109580c3a1"), "بستک", 25 },
                    { 981, new Guid("a76727a7-37de-4054-ae91-af7b3d63727e"), "ابوموسي", 25 },
                    { 980, new Guid("34a3811a-7dba-4421-809c-6e177b95f7d5"), "گيلانغرب", 24 },
                    { 979, new Guid("b337c679-5c4b-43bc-a8e6-546a10fdc8c7"), "گودين", 24 },
                    { 978, new Guid("e548b598-140b-4aa6-9188-6f8aef012265"), "گهواره", 24 },
                    { 977, new Guid("bd2cb3c8-1cc7-428c-ac3c-c1a50b45c443"), "کوزران", 24 },
                    { 976, new Guid("09616970-d4a9-4a3c-92fa-4051c3597d2e"), "کنگاور", 24 },
                    { 975, new Guid("f6b1e896-6e91-4656-b85f-f69dfaed832b"), "کرند غرب", 24 },
                    { 974, new Guid("8ed2c994-51f0-44c9-9b63-d87b95bc5774"), "کرمانشاه", 24 },
                    { 973, new Guid("58beb43e-8d69-4d65-8d27-fd6995bc7352"), "پاوه", 24 },
                    { 972, new Guid("c9afdb7d-70a5-421f-bd80-acb375df39ea"), "هلشي", 24 },
                    { 971, new Guid("4083bbab-bef2-4863-b4a9-04ece8249885"), "هرسين", 24 },
                    { 970, new Guid("8c0062c1-a94f-4172-bc06-4e8e3eb26c36"), "نوسود", 24 },
                    { 985, new Guid("e4260e49-fd8c-4a65-9f26-2d7da6376830"), "بندر لنگه", 25 },
                    { 986, new Guid("41764f4a-394b-46b4-934a-0e09c9d91ddf"), "بيکاه", 25 },
                    { 987, new Guid("0268e95d-ac9d-4513-a8b7-f12080f1ddb8"), "تازيان پائين", 25 },
                    { 988, new Guid("69b85bba-8f04-46a1-8f2c-db58302e5b2a"), "تخت", 25 },
                    { 1004, new Guid("6521f0b6-8ca4-48d0-8e48-b75fef3cfed6"), "فين", 25 },
                    { 1003, new Guid("81519bc4-4634-4da5-8ebb-10a8cda193c3"), "فارغان", 25 },
                    { 1002, new Guid("3a4f0384-8ee9-405b-b9a9-4e9b9d176811"), "سيريک", 25 },
                    { 1001, new Guid("8cadcecf-7f95-4b16-ab9b-b5768611853c"), "سوزا", 25 },
                    { 1000, new Guid("64c9d3d5-4bf4-4356-a0b4-295fcf01d4f0"), "سندرک", 25 },
                    { 999, new Guid("58cfedd9-dbb3-419f-a9d0-53679f89bfc3"), "سرگز", 25 },
                    { 998, new Guid("5308af32-659e-46ff-af57-56e6ccacb0fc"), "سردشت", 25 },
                    { 969, new Guid("ea6512c8-0cf1-42de-ba21-07fe262e2b4f"), "نودشه", 24 },
                    { 997, new Guid("f0ad189b-1ddb-4856-914e-b56b39364b6d"), "زيارتعلي", 25 },
                    { 995, new Guid("e4e86ceb-cb80-444d-89f4-554423092c81"), "دهبارز", 25 },
                    { 994, new Guid("53b4be27-8d6b-41a0-882f-ac1f185f8168"), "دشتي", 25 },
                    { 993, new Guid("e7fb5552-9521-41f8-80e1-5ef70209e1db"), "درگهان", 25 },
                    { 992, new Guid("108c10b1-7532-4354-b567-4aeee05f16c2"), "خمير", 25 },
                    { 991, new Guid("a4718272-b329-42a7-b913-97b24474592b"), "حاجي آباد", 25 },
                    { 990, new Guid("f23ce7ba-1d7c-4d19-be1d-8c2f2361940d"), "جناح", 25 },
                    { 989, new Guid("036cfa50-ec94-4a25-963a-7b3ee3063f85"), "تيرور", 25 },
                    { 996, new Guid("eba4364d-f49d-467c-ad87-fb8ca78b368d"), "رويدر", 25 },
                    { 968, new Guid("1f470963-71c4-48de-b4b2-43fe8b15606d"), "ميان راهان", 24 },
                    { 967, new Guid("786830c2-966c-41a6-a43f-32658294c7e6"), "قصر شيرين", 24 },
                    { 966, new Guid("a722ec63-f1b7-4e44-a155-8a62c48f70ad"), "صحنه", 24 },
                    { 945, new Guid("4ef296cd-4412-4493-9b7b-fe4f8f9c4ad5"), "کوهنجان", 23 },
                    { 944, new Guid("4836b254-464a-4f03-9af0-d336caf36c5d"), "کوار", 23 },
                    { 943, new Guid("5f23f6b7-20dd-4e89-a7bd-63a73ff37fc3"), "کنار تخته", 23 },
                    { 942, new Guid("a9d7bffc-1b38-408c-a3be-762affec2233"), "کره اي", 23 },
                    { 941, new Guid("93979c9b-8b90-497a-89ba-ff321968091e"), "کامفيروز", 23 },
                    { 940, new Guid("6ec06564-ea6c-4ee5-8e9c-4de5f5c9b255"), "کازرون", 23 },
                    { 939, new Guid("e5932bc0-f130-48f7-99fd-0c482d477f83"), "کارزين", 23 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 946, new Guid("af855de6-6275-454d-80ec-0fd1b7fe7ea2"), "کوپن", 23 },
                    { 938, new Guid("115ee320-57cf-46bc-aea6-775609cfd61f"), "وراوي", 23 },
                    { 936, new Guid("2b2186e9-92be-4041-a714-bcb736c73a34"), "ني ريز", 23 },
                    { 935, new Guid("e5a3eee9-2b29-488e-b716-43f48c79c365"), "نورآباد", 23 },
                    { 934, new Guid("ebf76652-13a2-40c4-93e4-134e8cf9dcf6"), "نودان", 23 },
                    { 933, new Guid("f5b729ce-427e-48f2-8cda-d43838aeb70f"), "نوجين", 23 },
                    { 932, new Guid("7c1a2b43-feb6-43d2-8774-265e0a2cfc15"), "نوبندگان", 23 },
                    { 931, new Guid("c8d25a09-9b37-48bb-a141-6c1e9babd16c"), "ميمند", 23 },
                    { 930, new Guid("6481a0d5-705c-4ec9-b6b4-0323e2f933f5"), "ميانشهر", 23 },
                    { 937, new Guid("4a92ff1d-f35e-48ff-bd2c-1fd47123366b"), "هماشهر", 23 },
                    { 1005, new Guid("750cf776-cc0f-4d44-82ce-cad8c6999590"), "قشم", 25 },
                    { 947, new Guid("2db946c6-ee0b-431e-9ea9-bb97a25483fc"), "گراش", 23 },
                    { 949, new Guid("595b4e76-8bc7-47d6-a2f4-8e72ccca2bdf"), "ازگله", 24 },
                    { 965, new Guid("292cb4ad-8035-4daf-8bf1-de04dd6f0fc6"), "شاهو", 24 },
                    { 964, new Guid("4c2ebc03-3fd3-4c13-99f1-58f535ba78ab"), "سومار", 24 },
                    { 963, new Guid("4d055ee1-02b7-4d15-947f-83822ac1d7fd"), "سنقر", 24 },
                    { 962, new Guid("da95dc0b-ea87-4749-aed7-11ed642bfedd"), "سطر", 24 },
                    { 961, new Guid("92bddeb5-84ac-47a1-b347-5f93a478437d"), "سرمست", 24 },
                    { 960, new Guid("fd829b1d-0dfd-4457-8836-7d25d56e93e6"), "سر پل ذهاب", 24 },
                    { 959, new Guid("cace534c-6236-4ba6-a939-d1dbc9391985"), "ريجاب", 24 },
                    { 948, new Guid("e70dcb53-dbce-42fd-a811-f811683b17fc"), "گله دار", 23 },
                    { 958, new Guid("a4dbc7dd-9b08-42bf-8820-580316537e0a"), "روانسر", 24 },
                    { 956, new Guid("5eb7811b-d8d4-4bbd-a170-87885ad7934f"), "حميل", 24 },
                    { 955, new Guid("99fbd4f6-446d-489e-84ed-50c8cf76a194"), "جوانرود", 24 },
                    { 954, new Guid("c471d447-5027-46bc-9416-2c33b22985e9"), "تازه آباد", 24 },
                    { 953, new Guid("cf12bed2-f15b-42d9-9c45-75cb48f098b3"), "بيستون", 24 },
                    { 952, new Guid("5164b7d3-4f5e-4b6f-bb41-b6fa9f8711c3"), "باينگان", 24 },
                    { 951, new Guid("4144d6ca-2a87-486b-a1a5-962a656c946e"), "بانوره", 24 },
                    { 950, new Guid("7bc8b70a-933c-4c3c-8661-2e30500ac426"), "اسلام آباد غرب", 24 },
                    { 957, new Guid("77e8ebc0-5109-48f5-8ca2-c2c9ae5b40e7"), "رباط", 24 },
                    { 614, new Guid("e8c62d0e-2c4b-49db-939a-da5655962685"), "اردستان", 19 },
                    { 1006, new Guid("4c390089-3d3f-4ba4-97cb-48f15551ebd5"), "قلعه قاضي", 25 },
                    { 1008, new Guid("ab08d0e3-b983-4f32-8a5c-4f8f29470486"), "ميناب", 25 },
                    { 1063, new Guid("bb47ae20-399c-4e9b-9bdf-a6ef8032dc41"), "جيرنده", 27 },
                    { 1062, new Guid("90956065-b38e-46d9-aa17-75381f20f0ed"), "توتکابن", 27 },
                    { 1061, new Guid("cd63cb93-a4fd-4e69-befa-2347d0782ff4"), "بندر انزلي", 27 },
                    { 1060, new Guid("53af1036-7ab9-4f34-8ad7-f2c9a502f7f7"), "بره سر", 27 },
                    { 1059, new Guid("e17a3dde-5bca-4e39-86bf-0898c1a6d7fc"), "بازار جمعه", 27 },
                    { 1058, new Guid("577caf82-007d-4f8d-b681-7ca9aa545159"), "املش", 27 },
                    { 1057, new Guid("9ab4c6a7-cdd4-41d4-91a7-948c7ff90bc8"), "اطاقور", 27 },
                    { 1056, new Guid("425fad25-91a1-4c76-8360-db70475addcf"), "اسالم", 27 },
                    { 1055, new Guid("95e53371-b529-48b7-b489-a15c7e1ebcf8"), "احمد سرگوراب", 27 },
                    { 1054, new Guid("6f94d5d8-c8eb-49d2-9728-c22561e2848a"), "آستانه اشرفيه", 27 },
                    { 1053, new Guid("13995751-4316-49d3-b21d-0c7974e355ea"), "آستارا", 27 },
                    { 1052, new Guid("fb82cfcc-ca63-4aac-bc82-824abcef23f5"), "کميجان", 26 },
                    { 1051, new Guid("e6d6ce4e-0202-4d77-9128-9bc7c0470f6f"), "کارچان", 26 },
                    { 1050, new Guid("47912a97-7cdb-4753-b19b-c8835c5f116e"), "پرندک", 26 },
                    { 1049, new Guid("8d78d4e1-f1ce-4caa-b19f-36c49552858e"), "هندودر", 26 },
                    { 1064, new Guid("1471fb8e-d983-43b6-adbc-dbf6cf1924cd"), "حويق", 27 },
                    { 1065, new Guid("7f48d993-372d-49eb-bea4-ae08dcf75a9d"), "خشکبيجار", 27 },
                    { 1066, new Guid("aa7bbca6-dcde-4734-bd24-2c8a8d8755b4"), "خمام", 27 },
                    { 1067, new Guid("7d6e439e-981a-4e97-ad4a-756b5d12f07b"), "ديلمان", 27 },
                    { 1083, new Guid("e0055b58-f997-4582-bfad-440eaca2427c"), "لشت نشاء", 27 },
                    { 1082, new Guid("2aa7a10e-ff2c-411c-9051-83b3875c81e0"), "لاهيجان", 27 },
                    { 1081, new Guid("e6030a4e-291d-420d-9305-c26022c42406"), "فومن", 27 },
                    { 1080, new Guid("9101ca98-90a0-47ac-aec3-d6d683aa0faf"), "صومعه سرا", 27 },
                    { 1079, new Guid("5e445f20-d827-434f-a6f6-56ac156d79ef"), "شلمان", 27 },
                    { 1078, new Guid("00f08982-4ae8-4b74-8eaf-f56236c4a1f2"), "شفت", 27 },
                    { 1077, new Guid("d92b2353-5d62-492c-927c-b22281748c49"), "سياهکل", 27 },
                    { 1048, new Guid("eb6ff067-3db2-49a1-80aa-567b26590205"), "نيمور", 26 },
                    { 1076, new Guid("664a31da-8a92-4414-aea0-1279089e435c"), "سنگر", 27 },
                    { 1074, new Guid("df86dd94-43a0-4473-83d5-d8813c305047"), "رودبنه", 27 },
                    { 1073, new Guid("6e7cae09-0707-4e56-81ef-a3578771f679"), "رودبار", 27 },
                    { 1072, new Guid("7c1585e3-8337-45bc-b9bd-f02811730065"), "رضوانشهر", 27 },
                    { 1071, new Guid("43d4f415-4966-49e7-af55-43279e0ad8bb"), "رشت", 27 },
                    { 1070, new Guid("c1a90643-dc30-43f7-b4ec-95b9767a46dd"), "رستم آباد", 27 },
                    { 1069, new Guid("d8276690-3184-41b7-9afb-c281a3c3cbbf"), "رحيم آباد", 27 },
                    { 1068, new Guid("52828e34-3c59-42fb-8fc6-11ad43664c51"), "رانکوه", 27 },
                    { 1075, new Guid("33abf352-e0f4-498e-8d42-5a28ca9db09f"), "رودسر", 27 },
                    { 1047, new Guid("c512433a-4dc5-4c23-8259-3c5fcf8668d6"), "نوبران", 26 },
                    { 1046, new Guid("8d663c3b-22ae-4063-8100-b4e354f7f774"), "نراق", 26 },
                    { 1045, new Guid("5c35da35-785f-4a9e-be3b-2800213ab131"), "ميلاجرد", 26 },
                    { 1024, new Guid("c996f038-45fd-4adf-9200-fa583659a4c2"), "تفرش", 26 },
                    { 1023, new Guid("76ca9d9b-07eb-4069-8ae6-d313e7abf4a3"), "اراک", 26 },
                    { 1022, new Guid("2f976455-268f-4a42-807a-ac7788a05822"), "آوه", 26 },
                    { 1021, new Guid("9934c536-64c3-4365-8c94-812d869c7973"), "آشتيان", 26 },
                    { 1020, new Guid("6be22a94-9682-4a8b-a51e-ec7e9bb99dbf"), "آستانه", 26 },
                    { 1019, new Guid("54485a6f-c63c-4190-907c-e5014e4b28ca"), "گوهران", 25 },
                    { 1018, new Guid("7f0a8042-f843-48b8-ab58-d7fb1a9560aa"), "گروک", 25 },
                    { 1025, new Guid("0e975610-eb13-4586-9a5e-956013e4f2cb"), "توره", 26 },
                    { 1017, new Guid("5c51d1c7-f243-45f3-b4df-e001ce3ab2fb"), "کيش", 25 },
                    { 1015, new Guid("7faa8d0c-48f5-4406-96c6-0d6178485198"), "کوشکنار", 25 },
                    { 1014, new Guid("4469ecd1-1956-4199-8870-1439d2f9f433"), "کوخردهرنگ", 25 },
                    { 1013, new Guid("702df869-1dd7-47df-bc5b-3f7abc1f6071"), "کنگ", 25 },
                    { 1012, new Guid("f9c3ccff-71cd-4330-b240-8bc766e8e720"), "چارک", 25 },
                    { 1011, new Guid("bf3aaa76-935b-493d-a24c-175e5355df1b"), "پارسيان", 25 },
                    { 1010, new Guid("65dc34d3-80fd-4838-b966-b07fd59eee73"), "هشتبندي", 25 },
                    { 1009, new Guid("106e9e19-f8d1-4c99-98c9-a1cf5f1fb698"), "هرمز", 25 },
                    { 1016, new Guid("f7f6e3e7-7991-4f2c-b546-891c9254abe8"), "کوهستک", 25 },
                    { 1007, new Guid("42def88b-466a-4c3f-b6fe-3a302c2bf9b7"), "لمزان", 25 },
                    { 1026, new Guid("4d4ebdda-8cac-4e3a-93c8-392ace7aac1f"), "جاورسيان", 26 },
                    { 1028, new Guid("a92c4a71-7954-437b-95a9-86d2600de7f8"), "خمين", 26 },
                    { 1044, new Guid("966c6a9e-06c7-455f-a752-3f790edd80bb"), "محلات", 26 },
                    { 1043, new Guid("d129d6c3-bf13-4f1b-b473-aa12fa48417f"), "مامونيه", 26 },
                    { 1042, new Guid("62ec962c-8047-4a9a-b423-37a41fe25366"), "قورچي باشي", 26 },
                    { 1041, new Guid("a6a663fc-d8fe-437b-b82b-98ff22e391e4"), "فرمهين", 26 },
                    { 1040, new Guid("b70cc9fc-8b5e-4f6a-bb64-ad1f02fe68bc"), "غرق آباد", 26 },
                    { 1039, new Guid("7e77d2c7-a2d3-4e5a-a368-355ae7f299cd"), "شهر جديد مهاجران", 26 },
                    { 1038, new Guid("5df20a53-3c7d-4a45-a40b-f508f46a6f2c"), "شهباز", 26 },
                    { 1027, new Guid("fd7c9a16-d708-4c2b-827f-54f4887481e7"), "خشکرود", 26 },
                    { 1037, new Guid("01e30afe-021a-4a54-bb27-0840fcc84f71"), "شازند", 26 },
                    { 1035, new Guid("3e781fa1-653c-4235-b8ce-5f2094778503"), "ساروق", 26 },
                    { 1034, new Guid("e3029472-7b69-4694-9ae2-54dc07205b80"), "زاويه", 26 },
                    { 1033, new Guid("5d83cb3d-b795-46b3-a4e8-1a46c63d0d9a"), "رازقان", 26 },
                    { 1032, new Guid("425933c0-1e92-4f8f-b5c4-3c764d86fffc"), "دليجان", 26 },
                    { 1031, new Guid("51caf4a6-60a7-4ffd-a433-58bf23b60506"), "داود آباد", 26 },
                    { 1030, new Guid("0c824a35-8571-4c9c-91de-80431945df5d"), "خنداب", 26 },
                    { 1029, new Guid("9af2b922-bc32-4434-b9e6-e18b6db0aae3"), "خنجين", 26 },
                    { 1036, new Guid("ffff25a1-50a1-4571-80d7-c3ff458dad55"), "ساوه", 26 },
                    { 613, new Guid("1d55de87-56dd-4367-9a9d-c307056b2d93"), "ابوزيد آباد", 19 },
                    { 612, new Guid("a333b0cf-ce82-49a0-a99d-0c49033e9c9e"), "ابريشم", 19 },
                    { 611, new Guid("b45399a9-17f2-4925-820a-9c0e6431f3d1"), "آران و بيدگل", 19 },
                    { 207, new Guid("244fe849-d69c-426e-b57e-9ae5271a14b9"), "سلامي", 8 },
                    { 206, new Guid("ccf4e805-fd02-4dd7-969c-d4f30e456a73"), "سفيد سنگ", 8 },
                    { 205, new Guid("f5c59a3f-9db8-4e7f-9acc-33e201fe8feb"), "سرخس", 8 },
                    { 204, new Guid("c447d3bf-b9d9-4279-944d-51ffc2f4e901"), "سبزوار", 8 },
                    { 203, new Guid("e213640a-95f4-470b-a237-d11a27ca1ab9"), "ريوش", 8 },
                    { 202, new Guid("2f9a6660-3583-43e9-8392-6a15bc6ed382"), "روداب", 8 },
                    { 201, new Guid("9c18abe3-363b-4210-bfeb-c4bd288611fa"), "رضويه", 8 },
                    { 200, new Guid("f5925669-f13f-48f1-adaf-058eee4fd59c"), "رشتخوار", 8 },
                    { 199, new Guid("a8b21ed4-2928-4fdd-bd31-f4140c2475fc"), "رباط سنگ", 8 },
                    { 198, new Guid("d1fa134e-2218-4c24-9421-77fcbe697d0d"), "دولت آباد", 8 },
                    { 197, new Guid("bc0a8c9d-be3f-4cad-b85d-80087f78eb9e"), "درگز", 8 },
                    { 196, new Guid("aa377c25-5d7e-476f-83e5-ba0452a6ea16"), "درود", 8 },
                    { 195, new Guid("3436ea64-a3b5-4506-944e-5bd7d2741773"), "داورزن", 8 },
                    { 194, new Guid("7070eb40-11b2-4022-93e9-0e7eca1e7215"), "خواف", 8 },
                    { 193, new Guid("6a78fc3f-147d-47bc-a4f0-187ec4aaf374"), "خليل آباد", 8 },
                    { 208, new Guid("97786d58-d258-4020-99f3-73eef041e986"), "سلطان آباد", 8 },
                    { 192, new Guid("9a1c33ad-acc4-4b5b-9028-8b1f093304a7"), "خرو", 8 },
                    { 209, new Guid("c3444e01-0311-488c-905f-566583fee38d"), "سنگان", 8 },
                    { 211, new Guid("0819df17-dc43-45a5-9dd2-e79835611ad3"), "شانديز", 8 },
                    { 226, new Guid("febfb76d-0a12-4867-b13a-887e7490ba0b"), "لطف آباد", 8 },
                    { 225, new Guid("69d627be-cacd-45c0-83d8-d87d7e308702"), "قوچان", 8 },
                    { 224, new Guid("16a99c05-11d8-40f0-ae46-ae1cbedd6a2b"), "قلندر آباد", 8 },
                    { 223, new Guid("a53df95f-a640-414d-a9b4-2e315fcbb2e3"), "قدمگاه", 8 },
                    { 222, new Guid("935cdab9-2d9c-4c60-8b4b-9f9a5793ad4b"), "قاسم آباد", 8 },
                    { 221, new Guid("76c3e30e-1ab7-4d0b-8d55-04e4ee29cc47"), "فيض آباد", 8 },
                    { 220, new Guid("61991e23-a1d6-4e18-9531-50f777d5de48"), "فيروزه", 8 },
                    { 219, new Guid("877514a8-b602-4345-a1af-638d9b6c3e11"), "فريمان", 8 },
                    { 218, new Guid("8459b98a-7ce6-4631-88fa-db4f25912393"), "فرهاد گرد", 8 },
                    { 217, new Guid("0dbb0259-4694-4ea3-8f03-4d9a64827e47"), "عشق آباد", 8 },
                    { 216, new Guid("28aee98f-2019-4398-a689-ca55867df5c0"), "طرقبه", 8 },
                    { 215, new Guid("167c373b-61da-4b2e-9a8b-8106b442948a"), "صالح آباد", 8 },
                    { 214, new Guid("f18ad1e2-0dbe-4088-9970-c691265edfa0"), "شهرآباد", 8 },
                    { 213, new Guid("8fcc860f-f0cf-4086-ac96-d753b9a27e2b"), "شهر زو", 8 },
                    { 212, new Guid("69103a96-f328-4d32-a1c8-27651b515546"), "ششتمد", 8 },
                    { 210, new Guid("79d8d70b-5972-4830-bcd9-e693a0d77209"), "شادمهر", 8 },
                    { 227, new Guid("7eb12dfe-ed55-4271-8be8-ab46080b60e2"), "مزدآوند", 8 },
                    { 191, new Guid("0d8a0db1-497a-49b0-9962-a4a82446b7c1"), "جنگل", 8 },
                    { 189, new Guid("124b0f69-0efa-481b-b96d-b8422512d534"), "تربت حيدريه", 8 },
                    { 169, new Guid("89f41c9b-6300-470b-8401-0b119ec67e84"), "نازک عليا", 7 },
                    { 168, new Guid("0d62a280-46f6-489f-b0f0-2fe5784d133d"), "ميرآباد", 7 },
                    { 167, new Guid("437582db-4f78-426b-8c70-3293b3a99352"), "مياندوآب", 7 },
                    { 166, new Guid("f438f66d-1f17-4415-ae19-abbfd1a91e57"), "مهاباد", 7 },
                    { 165, new Guid("f06e4d21-cc60-469e-80cf-fe530fa28ca3"), "مرگنلر", 7 },
                    { 164, new Guid("4fc82c84-7954-4253-8d31-79b953038db0"), "محمود آباد", 7 },
                    { 163, new Guid("55b41b80-fe1b-4046-a943-f40a45b4c2c3"), "محمد يار", 7 },
                    { 162, new Guid("be5a013e-9159-448f-b1f0-29d3b0053a3d"), "ماکو", 7 },
                    { 161, new Guid("64641015-58b8-4197-88ab-4eebdda9f43a"), "قوشچي", 7 },
                    { 160, new Guid("99e7c819-593d-4f8d-a957-39f021433d9a"), "قطور", 7 },
                    { 159, new Guid("229de1cf-ba69-4b0a-858b-0b689efe0c9f"), "قره ضياء الدين", 7 },
                    { 158, new Guid("58fab462-36cc-48cf-968b-5cf6bf84f36a"), "فيرورق", 7 },
                    { 157, new Guid("d592244e-5f3f-4735-9a05-1de2b935dd21"), "شوط", 7 },
                    { 156, new Guid("96242170-def5-41f6-b602-099673857618"), "شاهين دژ", 7 },
                    { 155, new Guid("f564dd6c-09eb-490a-a452-dd49a535b654"), "سيه چشمه", 7 },
                    { 170, new Guid("837f8fa5-0342-42d7-b058-3da9909368a4"), "نالوس", 7 },
                    { 190, new Guid("193f8e8b-9a55-42e6-9351-6b466d187166"), "جغتاي", 8 },
                    { 171, new Guid("9435eb31-c670-4a44-9021-f72d5886bab5"), "نقده", 7 },
                    { 173, new Guid("c2ecf04f-c1c4-44d9-b78d-a369e287b551"), "پلدشت", 7 },
                    { 188, new Guid("fa48b44f-1a77-442c-b4ff-d40114e09a11"), "تربت جام", 8 },
                    { 187, new Guid("f46418ae-0b8f-4b5b-8f12-1d570f8ab611"), "تايباد", 8 },
                    { 186, new Guid("e91da842-3b53-45c0-be5d-96e99f2b509e"), "بيدخت", 8 },
                    { 185, new Guid("774dbd60-9784-4a1d-857f-d0c82f4c7eb8"), "بردسکن", 8 },
                    { 184, new Guid("4918b945-5a31-4af4-b422-0fc6769d6e87"), "بجستان", 8 },
                    { 183, new Guid("5d779acd-0063-4eef-956d-6bb69577ab76"), "بايک", 8 },
                    { 182, new Guid("9a0004af-6933-4254-bc90-b0036be63f03"), "بار", 8 },
                    { 181, new Guid("9c1acd4b-f4bc-4634-8070-a5d99fc45cf6"), "باخرز", 8 },
                    { 180, new Guid("1d4eaf17-5942-4025-a129-c05be996c7dd"), "باجگيران", 8 },
                    { 179, new Guid("3e7d5cf8-99b2-4868-87fd-0fc09a995225"), "انابد", 8 },
                    { 178, new Guid("d955e33e-f127-4ba5-bc1c-dd65fac6c131"), "احمدآباد صولت", 8 },
                    { 177, new Guid("b6e54069-adff-401a-934d-3effbe947c29"), "گردکشانه", 7 },
                    { 176, new Guid("c72a771c-0972-467d-bc12-69b6e8fb4b70"), "کشاورز", 7 },
                    { 175, new Guid("ab05e48e-11ad-4661-bbd2-bfe0e04447c5"), "چهار برج", 7 },
                    { 174, new Guid("ffedb917-6647-47cd-aaa1-c66c7ffcbb28"), "پيرانشهر", 7 },
                    { 172, new Guid("ba2b3d15-7ffc-4d45-85e6-2bf373c2dc96"), "نوشين", 7 },
                    { 228, new Guid("dfebd9b2-2b3f-4cc5-a0ab-2706f06cd9cc"), "مشهد", 8 },
                    { 229, new Guid("942dcae8-bfd8-443c-8212-9bc39d7a2c4d"), "مشهدريزه", 8 },
                    { 230, new Guid("c24df33b-367b-44a8-b05e-b8260c99a6d1"), "ملک آباد", 8 },
                    { 284, new Guid("e416933c-df52-49da-b4de-757530050bc5"), "کنارک", 9 },
                    { 283, new Guid("c958a241-c64f-43dd-a61b-067998b8c722"), "چاه بهار", 9 },
                    { 282, new Guid("8a7ac940-3444-44cd-a5b3-e4c3c51f6ea5"), "پيشين", 9 },
                    { 281, new Guid("2002f33b-6ced-4d0c-b147-29a3621a4413"), "هيدوچ", 9 },
                    { 280, new Guid("e8aba65f-a12d-4908-b053-7d7ed8fcf15f"), "نگور", 9 },
                    { 279, new Guid("02edef13-ac70-479e-98cc-0dbcd3d1ef18"), "نيک شهر", 9 },
                    { 278, new Guid("9389009b-9d0f-431c-a512-a996ee99ef3f"), "نوک آباد", 9 },
                    { 277, new Guid("72a88f72-172c-435c-99d1-ffacd34df90b"), "نصرت آباد", 9 },
                    { 276, new Guid("88f35aa9-e267-4f08-94f2-c42c9212f9e0"), "ميرجاوه", 9 },
                    { 275, new Guid("06d12296-80d7-4532-8870-0bce4bcff976"), "مهرستان", 9 },
                    { 274, new Guid("80b92415-716d-46a3-b7db-f41907e00b9a"), "محمدي", 9 },
                    { 273, new Guid("7c34b12b-ac9e-46d4-a30d-c6e866b06390"), "محمدان", 9 },
                    { 272, new Guid("07861539-a8ab-4fbb-a974-7547ca1b7691"), "محمد آباد", 9 },
                    { 271, new Guid("788c1d5b-be32-4d43-8c3b-addc2ffce575"), "قصر قند", 9 },
                    { 270, new Guid("48c3237b-8ed3-4a9d-9cd9-d3ea75dbbb5f"), "فنوج", 9 },
                    { 285, new Guid("b9b20d85-c3bd-46e0-9e1a-0d86119a2692"), "گشت", 9 },
                    { 269, new Guid("b8d78e1d-024b-4d05-9143-cad90a421b32"), "علي اکبر", 9 },
                    { 286, new Guid("59740201-ba96-4d2b-a258-7bf85f7df7d5"), "گلمورتي", 9 },
                    { 288, new Guid("7de9a581-c1cc-494d-b707-17da64a89bae"), "آيسک", 10 },
                    { 303, new Guid("a5f772b8-c9a6-4c25-96a8-d20d5e7ff1d8"), "شوسف", 10 },
                    { 302, new Guid("b92dcf29-8fb6-4b7a-87af-c2af81878dd2"), "سه قلعه", 10 },
                    { 301, new Guid("8f1483be-0c4c-4fbc-853c-8452e3d1cce7"), "سربيشه", 10 },
                    { 300, new Guid("882d7969-4e9a-41e7-b084-f2082bc917bf"), "سرايان", 10 },
                    { 299, new Guid("323f0bbf-529b-4941-9927-72bf0e779cc4"), "زهان", 10 },
                    { 298, new Guid("d67bc014-08ec-4e6c-bc9a-2720cead1cbf"), "ديهوک", 10 },
                    { 1241, new Guid("3c1e6032-70a3-40f0-b374-510ddcf2aa38"), "گراب سفلي", 31 },
                    { 296, new Guid("b48d2fc2-867f-4e91-b970-ba54a148be92"), "خضري دشت بياض", 10 },
                    { 295, new Guid("9a0614dc-a69c-44cd-a1e0-f72ec8d0e05a"), "حاجي آباد", 10 },
                    { 294, new Guid("62aea89b-f0d1-4af2-8168-f6b31bdf6496"), "بيرجند", 10 },
                    { 293, new Guid("c4c33970-70a4-4de5-83a0-1a63fbeaa7a7"), "بشرويه", 10 },
                    { 292, new Guid("0147bfda-6706-49bc-946d-d25372f88031"), "اسلاميه", 10 },
                    { 291, new Guid("0c30b106-773a-464c-a90f-0a3260c7d895"), "اسفدن", 10 },
                    { 290, new Guid("acc70deb-5f32-4b2d-85aa-a1424a2f47a1"), "اسديه", 10 },
                    { 289, new Guid("4788385f-3756-4754-ba3a-b50562b81f84"), "ارسک", 10 },
                    { 287, new Guid("0ed9271d-7d45-4402-b670-40e2b5ec11be"), "آرين شهر", 10 },
                    { 268, new Guid("94c823f9-9c07-4515-ac5f-d8bf16ac0abc"), "سيرکان", 9 },
                    { 267, new Guid("3b518570-5c85-4a03-82fc-c7867de7b3dd"), "سوران", 9 },
                    { 266, new Guid("4b2fee23-8b25-4d54-984d-abac7d300b24"), "سرباز", 9 },
                    { 245, new Guid("e57438f6-642a-4261-a1b7-74687f41b526"), "کدکن", 8 },
                    { 244, new Guid("2cfae0b3-5cfa-4518-b9d4-ca01395229aa"), "کاشمر", 8 },
                    { 243, new Guid("64b525d4-2d4b-47dd-8f3a-f7e3da12eadd"), "کاريز", 8 },
                    { 242, new Guid("ccad5a06-286b-4e5b-b206-ff3d876fd4db"), "کاخک", 8 },
                    { 241, new Guid("8b37fa9c-5b2e-4278-bde1-2e1907eec796"), "چکنه", 8 },
                    { 240, new Guid("9e416f98-e0fe-4a2b-ab85-b6fcdb34cd13"), "چناران", 8 },
                    { 239, new Guid("330cd4c1-d9d6-43fc-8209-7bbc9df88f16"), "چاپشلو", 8 },
                    { 238, new Guid("75d03077-10e4-4ecd-b3ec-0c934572d4ff"), "يونسي", 8 },
                    { 237, new Guid("2695ddd2-0a00-4752-902f-341532b0dd07"), "همت آباد", 8 },
                    { 236, new Guid("9c7fd8aa-11e6-4c82-9b1a-a091e2806ddb"), "نيل شهر", 8 },
                    { 235, new Guid("a02e98c6-2389-4247-859c-0d05c171ee53"), "نيشابور", 8 },
                    { 234, new Guid("7ef5a73e-3ac8-48b1-823e-6d4da37b5491"), "نوخندان", 8 },
                    { 233, new Guid("f63fbcb1-b5d6-41bb-9d49-0038590a748d"), "نقاب", 8 },
                    { 232, new Guid("9bbe4888-e200-4e04-9d13-ab31da2e36b9"), "نصرآباد", 8 },
                    { 231, new Guid("43357cb7-0453-45f5-88c0-625779282b19"), "نشتيفان", 8 },
                    { 246, new Guid("12f1eb49-f25b-4f64-912a-f8c0dd7332fe"), "کلات", 8 },
                    { 247, new Guid("3897e592-3eeb-497a-8e3c-7ba0a35fd30b"), "کندر", 8 },
                    { 248, new Guid("3c354cfd-8255-42de-8361-ccb7752ef2bb"), "گلمکان", 8 },
                    { 249, new Guid("53041b73-bfd8-4559-9dd3-0c4f8fc1ce31"), "گناباد", 8 },
                    { 265, new Guid("f5fc0e29-f9b9-4759-912e-015729e16252"), "سراوان", 9 },
                    { 264, new Guid("9d87787b-d568-496d-9f56-24d71430c18e"), "زهک", 9 },
                    { 263, new Guid("462b825c-2ff6-4701-b2ce-0da4b5c873f2"), "زرآباد", 9 },
                    { 262, new Guid("e2b38fdb-adc6-4385-8e70-6961ef037639"), "زاهدان", 9 },
                    { 261, new Guid("d51d2864-166b-4729-8764-dc8d9aadfafb"), "زابل", 9 },
                    { 260, new Guid("3b36b476-b3e6-453d-afaf-68df102a6ce6"), "راسک", 9 },
                    { 259, new Guid("eb7ea209-df87-4139-b524-6b2a1789509c"), "دوست محمد", 9 },
                    { 154, new Guid("69af8856-267b-4752-b4a8-de4c05b048e7"), "سيمينه", 7 },
                    { 258, new Guid("ee39f5a8-21a9-4964-a2b5-0b236782fa71"), "خاش", 9 },
                    { 256, new Guid("eecf6016-71fc-49c9-ac14-1d1d5cfbcf53"), "بنجار", 9 },
                    { 255, new Guid("941e7380-f61e-4d38-835b-bd71c5087816"), "بنت", 9 },
                    { 254, new Guid("e205f937-8560-4146-aee6-8d7403111d3a"), "بمپور", 9 },
                    { 253, new Guid("1a14b98c-1012-4a6a-8e52-fd83baada52e"), "بزمان", 9 },
                    { 252, new Guid("43bd873c-ea01-4613-a709-817322dba650"), "ايرانشهر", 9 },
                    { 251, new Guid("90ff4e32-6b3b-4d61-830d-b67bc9dcf03d"), "اسپکه", 9 },
                    { 250, new Guid("8e840eff-247b-4df8-95d0-ce51dd3d3a8c"), "اديمي", 9 },
                    { 257, new Guid("62902101-c73d-4aa1-ac67-5cf25a55216e"), "جالق", 9 },
                    { 153, new Guid("8450b692-fe1f-4c1a-8dcf-268e3ad63d82"), "سيلوانه", 7 },
                    { 152, new Guid("d5152c66-eaa3-48e4-bba1-d1bf5d2d61ca"), "سلماس", 7 },
                    { 151, new Guid("ac265ec4-16d3-4409-b352-72175bf4b9d5"), "سرو", 7 },
                    { 54, new Guid("edd04bec-cc79-4de1-92f1-101fba76b062"), "پردنجان", 2 },
                    { 53, new Guid("56eb7f15-f865-43a0-8074-36b6ebd219a6"), "وردنجان", 2 },
                    { 52, new Guid("ce772dfe-ca22-42e7-8681-4a38b25d3850"), "هفشجان", 2 },
                    { 51, new Guid("17a9b7d9-b971-4f42-8947-abf159077a9d"), "هاروني", 2 },
                    { 50, new Guid("e67acf9a-8297-4990-ab69-d76f5d801f5a"), "نقنه", 2 },
                    { 49, new Guid("040963c1-8b1b-4437-95e4-b1b78b50a49b"), "نافچ", 2 },
                    { 48, new Guid("82c01ab9-085d-4142-8cd5-0bd30cd99b11"), "ناغان", 2 },
                    { 47, new Guid("ece09797-b9bb-43b2-8020-f2b208b71b7b"), "منج", 2 },
                    { 46, new Guid("82ca6cbc-f84d-491b-bdf0-490d4bbfba76"), "مال خليفه", 2 },
                    { 45, new Guid("d344ee0f-1f10-4877-96e7-557b799f00fa"), "لردگان", 2 },
                    { 44, new Guid("3238c3eb-5fab-45d3-b331-24cf7601d8e1"), "فرخ شهر", 2 },
                    { 43, new Guid("de0043cc-274e-47a9-8912-04fa15bb94b5"), "فرادنبه", 2 },
                    { 42, new Guid("1a94e169-3681-422f-b190-4d477d667ee6"), "فارسان", 2 },
                    { 41, new Guid("a4ff973c-3c02-49c3-b1f2-592f481aa2d0"), "طاقانک", 2 },
                    { 40, new Guid("d5034c23-cd94-451e-812d-37dd6ee28ea7"), "صمصامي", 2 },
                    { 55, new Guid("f792346b-c4fc-49a0-a8b0-c83a9d705b32"), "چليچه", 2 },
                    { 39, new Guid("c9656b8c-8cd3-441e-ae5d-915e33b1ed8d"), "شهرکرد", 2 },
                    { 56, new Guid("dafa1474-e86f-4219-a740-dab97abe9d07"), "چلگرد", 2 },
                    { 58, new Guid("b4759ac4-31f3-411e-b901-06bf4010111d"), "کيان", 2 },
                    { 73, new Guid("3e328b71-0440-4aae-8fe4-95284884f25e"), "سنخواست", 3 },
                    { 72, new Guid("e4b9f4c8-28da-4991-b098-b41daee85708"), "زيارت", 3 },
                    { 71, new Guid("edef279c-8f3c-4f3a-9025-40a9dbaec19f"), "راز", 3 },
                    { 70, new Guid("1f654b19-c1f4-4c7d-9bcb-a2d023f3214a"), "درق", 3 },
                    { 69, new Guid("209648f1-9152-44a5-94a8-b3381d7071d4"), "حصارگرمخان", 3 },
                    { 68, new Guid("8ca51209-a59c-46ea-a075-173ee76230f3"), "جاجرم", 3 },
                    { 67, new Guid("516cd208-ca24-43c5-b308-0444c7d28343"), "تيتکانلو", 3 },
                    { 66, new Guid("6ac1d485-43c7-412d-b977-cc2b99f471be"), "بجنورد", 3 },
                    { 65, new Guid("5ba5a0f8-5b06-490b-b2a3-5fe37bd8cd0e"), "ايور", 3 },
                    { 64, new Guid("06d84752-9c88-40ef-8d76-81d0b6c7319d"), "اسفراين", 3 },
                    { 63, new Guid("f171360b-21ed-440f-9628-575f886fc196"), "آوا", 3 },
                    { 62, new Guid("545d368b-0ae8-4ba7-8962-f494990c613c"), "آشخانه", 3 },
                    { 61, new Guid("32241ad5-fc05-4c63-9f43-2bc8f93d9c17"), "گوجان", 2 },
                    { 60, new Guid("2e568339-ba0c-4b98-a331-4d7272513bfb"), "گهرو", 2 },
                    { 59, new Guid("1a1565eb-5a37-4cef-b577-06bd958d20ea"), "گندمان", 2 },
                    { 57, new Guid("0d156960-772c-4cff-ad4a-69f6f557b16e"), "کاج", 2 },
                    { 38, new Guid("88870832-cfe0-497b-8f06-561c79e351cd"), "شلمزار", 2 },
                    { 37, new Guid("68b9d335-6386-4465-b27f-dd62c0c1c0e2"), "سورشجان", 2 },
                    { 36, new Guid("0c0d1330-c260-4fc7-b71a-51f910c52844"), "سودجان", 2 },
                    { 15, new Guid("36044872-a1f1-4ed3-9269-100d745375eb"), "مهردشت", 1 },
                    { 14, new Guid("da6aaad0-8836-4b74-a117-578640a9187b"), "مروست", 1 },
                    { 13, new Guid("4e661dfb-2452-4484-9be4-1b41ac9e295e"), "عقدا", 1 },
                    { 12, new Guid("96ea2fb0-c22b-41a5-87b6-a50d8998c322"), "شاهديه", 1 },
                    { 11, new Guid("d83604ec-81d5-4eee-a79c-370cbfc5c19c"), "زارچ", 1 },
                    { 10, new Guid("5b5d9a43-d1cf-4014-abce-cfabd84a73fb"), "خضر آباد", 1 },
                    { 9, new Guid("7124599e-3753-4a70-8e10-d39dc4b90ec5"), "حميديا", 1 },
                    { 8, new Guid("26afe78e-1445-40f7-97c2-32a5b781e29b"), "تفت", 1 },
                    { 7, new Guid("9cdee426-3b41-41cc-92b2-7e5b1a4cc1b5"), "بهاباد", 1 },
                    { 6, new Guid("bf769e37-1421-41c0-b72a-a2426e21415c"), "بفروئيه", 1 },
                    { 5, new Guid("8724092d-36a3-4d54-a342-dfd45ff1e907"), "بافق", 1 },
                    { 4, new Guid("5adab455-d0ff-424d-9136-0fda7079e8c3"), "اشکذر", 1 },
                    { 3, new Guid("ecdd929e-7fb8-46a3-b8eb-dfd9188a7623"), "اردکان", 1 },
                    { 2, new Guid("eafefad3-09f7-4ea1-be1c-c36150042fc9"), "احمد آباد", 1 },
                    { 1, new Guid("d876be96-966d-43c7-8a18-15e75416ac62"), "ابرکوه", 1 },
                    { 16, new Guid("55dc8006-9543-4f63-b031-1c18d312b7c9"), "مهريز", 1 },
                    { 17, new Guid("15f4ed36-734a-456d-9682-fe939be13af5"), "ميبد", 1 },
                    { 18, new Guid("e1b1bb80-d499-4cba-ba35-9a22952dac2b"), "ندوشن", 1 },
                    { 19, new Guid("9c8731d0-a7e9-4875-b68e-e8bcd9518023"), "نير", 1 },
                    { 35, new Guid("ba1574b0-0ac0-4cf3-868a-ac5ecf0f696b"), "سفيد دشت", 2 },
                    { 34, new Guid("e26c22f5-aca1-4ebc-b4f3-b691d7b96197"), "سردشت لردگان", 2 },
                    { 33, new Guid("4549f498-2fc9-42d3-9af0-33ca033cc214"), "سرخون", 2 },
                    { 32, new Guid("c77cb1a8-b952-474d-b969-c2d67d98e603"), "سامان", 2 },
                    { 31, new Guid("b91041e1-63e7-4cf0-bb2b-ca9e2b19d927"), "دشتک", 2 },
                    { 30, new Guid("1242778b-e651-41f8-8077-de373be68ec6"), "دستناء", 2 },
                    { 29, new Guid("88954527-6c1d-41f4-a32f-b0c71fd72b05"), "جونقان", 2 },
                    { 74, new Guid("4024ffbd-a140-4a26-8d26-c33a92c563f6"), "شوقان", 3 },
                    { 28, new Guid("6e7af1ef-9ba0-4a31-81b5-ac604a13cd01"), "بن", 2 },
                    { 26, new Guid("50e7aa0e-d1c9-461d-bea5-98c5bb978b54"), "بروجن", 2 },
                    { 25, new Guid("4d7119de-56ae-4805-9cf2-49097c4ccbc6"), "بازفت", 2 },
                    { 24, new Guid("d6182fd5-f60d-4772-8466-c46128160df5"), "باباحيدر", 2 },
                    { 23, new Guid("9a845620-adbf-41c8-9027-85c98b0ff497"), "اردل", 2 },
                    { 22, new Guid("b37f380d-ad87-448a-97ce-87012ed81705"), "آلوني", 2 },
                    { 21, new Guid("139cdcf5-aedc-48fb-8d34-35126cf6bf73"), "يزد", 1 },
                    { 20, new Guid("36732b25-2e55-4bc8-a574-0b5993f6ec4b"), "هرات", 1 },
                    { 27, new Guid("eb40337d-193f-4348-b01c-0eee624e1555"), "بلداجي", 2 },
                    { 304, new Guid("0c48481d-27a7-4412-8d45-e31a01208cb9"), "طبس", 10 },
                    { 75, new Guid("7b294e27-16e0-493f-9f9f-abca79aad5c0"), "شيروان", 3 },
                    { 77, new Guid("b00dfb78-8171-448b-afac-6a9cd8400bbb"), "فاروج", 3 },
                    { 131, new Guid("adf3116c-3ac2-47d8-bc4f-6a736e234ab0"), "پيرتاج", 6 },
                    { 130, new Guid("654c8e91-61a0-4baf-a019-0a13217b8b84"), "ياسوکند", 6 },
                    { 129, new Guid("bbbd8ccb-641a-4fdb-b285-991ffb6617df"), "موچش", 6 },
                    { 128, new Guid("9fc515fc-eab6-48d2-add3-7ed347a19aa4"), "مريوان", 6 },
                    { 127, new Guid("a5251f5d-79ac-4184-96bb-fac96d40c439"), "قروه", 6 },
                    { 126, new Guid("791703a0-c669-4877-ad91-597de7dbb370"), "صاحب", 6 },
                    { 125, new Guid("5c62ab48-8de5-44be-bbb0-163489522761"), "شويشه", 6 },
                    { 124, new Guid("a3726dcd-a535-456b-9e9a-ca334287dc15"), "سنندج", 6 },
                    { 123, new Guid("177e32b8-4e55-473f-a913-ac82ecfb9863"), "سقز", 6 },
                    { 122, new Guid("11798e6a-c754-485b-aeba-f004fc69cd40"), "سريش آباد", 6 },
                    { 121, new Guid("937b717b-0a14-4fbb-9fe3-e21bde993f80"), "سرو آباد", 6 },
                    { 120, new Guid("ef23579c-91c1-4508-bf38-cf760db071ed"), "زرينه", 6 },
                    { 119, new Guid("f5675d96-4d84-4ab9-a89c-968fc09cd41e"), "ديواندره", 6 },
                    { 118, new Guid("0a86cd9c-8448-43dc-ae4b-2c53dda3e474"), "دهگلان", 6 },
                    { 117, new Guid("8da0121f-ce47-4257-bfbc-ad356692f24c"), "دلبران", 6 },
                    { 132, new Guid("47bd5dc8-25db-4d6f-953a-0782c9c7060e"), "چناره", 6 },
                    { 116, new Guid("73abf9a9-f2ab-4c09-8e2d-53211b4d2ba3"), "دزج", 6 },
                    { 133, new Guid("b380c366-0cc1-43aa-a93e-873f675e2018"), "کامياران", 6 },
                    { 135, new Guid("29f80931-f634-4a0f-923b-401f72a2259d"), "کاني سور", 6 },
                    { 150, new Guid("c23109ad-d567-4696-92b7-d4a8d5f3ec24"), "سردشت", 7 },
                    { 149, new Guid("314f27c9-3406-4c86-bcff-5e51b89395f1"), "زرآباد", 7 },
                    { 148, new Guid("3310064e-b786-43e5-93a8-969edb16fea2"), "ربط", 7 },
                    { 147, new Guid("235395bb-4dc3-491b-b33c-e0f5e7e083c7"), "ديزج ديز", 7 },
                    { 146, new Guid("95917b43-3737-4d10-a479-c02fc167c6c4"), "خوي", 7 },
                    { 145, new Guid("254fed22-e2a0-4609-849c-2c46ee35e972"), "خليفان", 7 },
                    { 144, new Guid("06ae790c-0d2c-4798-a56b-76fb4dec8eab"), "تکاب", 7 },
                    { 143, new Guid("6c2f5f68-7076-41cb-bde0-5fe92e78fad9"), "تازه شهر", 7 },
                    { 142, new Guid("3eb1079c-99f3-4f8d-9758-9cb58befec09"), "بوکان", 7 },
                    { 141, new Guid("5204556f-a852-4ef3-840b-2213b8e4c820"), "بازرگان", 7 },
                    { 140, new Guid("fa7b7b61-95a4-4cf8-865b-96e87506c505"), "باروق", 7 },
                    { 139, new Guid("31d18a75-9c74-43ac-bc02-ef7fdf639e1b"), "ايواوغلي", 7 },
                    { 138, new Guid("43e6d998-f1c3-47c6-9f40-f81c76cd89db"), "اشنويه", 7 },
                    { 137, new Guid("862c7a36-66cb-457e-ad70-01a81f5764b7"), "اروميه", 7 },
                    { 136, new Guid("9b5bfc71-5014-4081-a6ae-9ed0125966a7"), "آواجيق", 7 },
                    { 134, new Guid("f16d4334-0bae-4ba1-8ec7-9963c190e281"), "کاني دينار", 6 },
                    { 115, new Guid("24830dcf-ab60-49d9-900c-4a3ebdf88e48"), "توپ آغاج", 6 },
                    { 114, new Guid("15719069-d5ab-4836-b239-3d921a538551"), "بيجار", 6 },
                    { 113, new Guid("fe1b310c-209c-42fe-8fc6-b3b435267279"), "بوئين سفلي", 6 },
                    { 92, new Guid("630ba836-5ae6-4ee2-94b7-16a134abc99c"), "مشکين دشت", 4 },
                    { 91, new Guid("374c424c-0c86-49db-ab6b-34573d6c94b5"), "محمد شهر", 4 },
                    { 90, new Guid("98d96916-51ac-454d-a8b2-9319902bd87f"), "ماهدشت", 4 },
                    { 89, new Guid("efd03479-a7af-410d-b724-138c73142f81"), "فرديس", 4 },
                    { 88, new Guid("b6d86672-9025-45e5-8f52-4ae2b3759c5c"), "طالقان", 4 },
                    { 87, new Guid("f07714f8-bd2f-4ba1-9668-d40d3ad835c9"), "شهر جديد هشتگرد", 4 },
                    { 86, new Guid("0eb6129d-520f-4337-8ac3-ec91ef93f013"), "تنکمان", 4 },
                    { 85, new Guid("95acc3d4-efa6-4949-99a1-7bdc59090b8b"), "اشتهارد", 4 },
                    { 84, new Guid("49dd41db-40f5-4230-b3ad-0e7caddd000b"), "آسارا", 4 },
                    { 83, new Guid("61b8b4d3-3090-4a9b-a499-5243e845eec6"), "گرمه", 3 },
                    { 82, new Guid("d4bad6db-dabe-4cf5-80ea-b4d782040843"), "چناران شهر", 3 },
                    { 81, new Guid("0e207dbd-f590-4fbc-8d93-9737ec00eb2e"), "پيش قلعه", 3 },
                    { 80, new Guid("d3863548-5543-4de3-a932-c58651480215"), "لوجلي", 3 },
                    { 79, new Guid("1d8b8da3-efe8-49c0-b006-daee7c18fae5"), "قوشخانه", 3 },
                    { 78, new Guid("eee50945-fdb4-4945-a337-e34a8272ab19"), "قاضي", 3 },
                    { 93, new Guid("0c27db56-e98b-4033-9816-1fce7e334717"), "نظر آباد", 4 },
                    { 94, new Guid("fb0159c1-5fdd-46c7-b6b6-d2d4c7abb41a"), "هشتگرد", 4 },
                    { 95, new Guid("0061ed44-7d3f-4913-b2ee-f4042f03dff6"), "چهارباغ", 4 },
                    { 96, new Guid("d306b475-65f0-435b-9cf8-e6ec2c10966c"), "کرج", 4 },
                    { 112, new Guid("f8bf90ed-c36d-4ee6-b6d7-e1bfb2409aee"), "بلبان آباد", 6 },
                    { 111, new Guid("7cbfcc15-13c9-4c66-9aea-8ddc2dce2445"), "برده رشه", 6 },
                    { 110, new Guid("756571b9-8972-4999-b1d0-f0c7103505f0"), "بانه", 6 },
                    { 109, new Guid("b675b4df-1c72-4744-a2aa-1936a0d0c5d3"), "بابارشاني", 6 },
                    { 108, new Guid("87105688-a987-49b6-848a-68eb4a7ad267"), "اورامان تخت", 6 },
                    { 107, new Guid("bf61999e-e656-4a03-8eeb-96a056d47e2b"), "آرمرده", 6 },
                    { 106, new Guid("408c68a1-750a-4755-a34c-8a4f173ecb10"), "کهک", 5 },
                    { 76, new Guid("bffbb96e-c776-489e-a19f-79ba0362fe05"), "صفي آباد", 3 },
                    { 105, new Guid("ce7b36d6-2273-46fb-8813-5469c7a1f8ba"), "قنوات", 5 },
                    { 103, new Guid("b6fd1b60-2f49-4053-94e8-25996f5e0a1a"), "سلفچگان", 5 },
                    { 102, new Guid("1cf72040-bb9e-4a65-9291-cd6a0b59b4d6"), "دستجرد", 5 },
                    { 101, new Guid("3ee34810-379a-44b3-8aaa-b484c42e30f3"), "جعفريه", 5 },
                    { 100, new Guid("5646a53e-21d2-4d8a-9f5f-0b414a3e8157"), "گلسار", 4 },
                    { 99, new Guid("369fee20-ccd2-4e9b-902a-22709180b5c0"), "گرمدره", 4 },
                    { 98, new Guid("b56d44e2-3441-4b81-bde9-3981e845399e"), "کوهسار", 4 },
                    { 97, new Guid("be48f270-b7ad-4204-870f-3dcc3cd4fc39"), "کمال شهر", 4 },
                    { 104, new Guid("cf9c8018-6e6e-40cb-98eb-97d42b38e57f"), "قم", 5 },
                    { 305, new Guid("9a511fe3-c809-4f3e-be83-e5068ee79871"), "طبس مسينا", 10 },
                    { 297, new Guid("5669da0c-323e-45e3-b08b-d758dbeeaf3a"), "خوسف", 10 },
                    { 307, new Guid("69ee1704-a9c7-46c4-8ead-0720a087df3d"), "فردوس", 10 },
                    { 514, new Guid("4c0d5b6f-3faa-4770-917a-1af249c09982"), "نشتارود", 15 },
                    { 513, new Guid("556baa52-1dab-4882-8baf-972b193b82be"), "مرزيکلا", 15 },
                    { 512, new Guid("018ba855-3d22-49dc-98c6-e487d88fbca6"), "مرزن آباد", 15 },
                    { 511, new Guid("2da0171d-296b-4f0f-85b8-ad23132cc783"), "محمود آباد", 15 },
                    { 510, new Guid("b475de7e-f9fc-4b64-94f5-c5c37e7ecf8c"), "قائم شهر", 15 },
                    { 509, new Guid("7e9ba00f-46a9-449e-9fc7-98b3b9cb7580"), "فريم", 15 },
                    { 508, new Guid("8ed357a8-2d23-470d-a8d9-c3681cd5d1eb"), "فريدونکنار", 15 },
                    { 507, new Guid("b9430c99-279a-44c4-a52c-42bf0cd74902"), "عباس آباد", 15 },
                    { 506, new Guid("7b1bf238-33ae-421c-83b2-a2c0f86342c4"), "شيرگاه", 15 },
                    { 505, new Guid("5cad0e76-7ac3-4557-a340-b09bd671674b"), "شيرود", 15 },
                    { 504, new Guid("aa31f4bb-0ad8-4b81-989c-117009544229"), "سورک", 15 },
                    { 503, new Guid("091006d1-69e1-40c3-bd15-6e0c635b388b"), "سلمان شهر", 15 },
                    { 502, new Guid("a901bf85-7dbe-400e-92ca-f880a7b7b9f4"), "سرخرود", 15 },
                    { 501, new Guid("d5417371-998c-4450-b25c-839f94cc351a"), "ساري", 15 },
                    { 500, new Guid("17083842-321c-4d70-85d1-4ced612f6224"), "زيرآب", 15 },
                    { 515, new Guid("8c7d4100-7d26-450d-84aa-e7b8c7de4589"), "نور", 15 },
                    { 499, new Guid("5133c358-3694-489f-955d-4845184d6f86"), "زرگر محله", 15 },
                    { 516, new Guid("14521996-f242-4cbf-8a89-728b276918d5"), "نوشهر", 15 },
                    { 518, new Guid("97d05735-cd30-49ca-8314-af6b5574382a"), "هادي شهر", 15 },
                    { 533, new Guid("16d87e93-9fa3-488a-8cb4-d667ca198d2a"), "گزنک", 15 },
                    { 532, new Guid("c9dc8d9a-ba43-4f74-b229-0f3908080fcf"), "گتاب", 15 },
                    { 531, new Guid("a06d2ff6-99f1-4744-b78a-903cef040ffa"), "کياکلا", 15 },
                    { 530, new Guid("af253cc9-465c-4689-ade9-280bcf69dcf0"), "کياسر", 15 },
                    { 529, new Guid("bfa7eb08-797f-4933-8ea2-7b34090d1930"), "کوهي خيل", 15 },
                    { 528, new Guid("7a8fa583-abe5-41c2-a2e1-29b40534df5a"), "کلاردشت", 15 },
                    { 527, new Guid("e45f52c2-b6e7-4e9d-850e-a7c6a80a4019"), "کلارآباد", 15 },
                    { 526, new Guid("d4520c77-6a12-4c6d-b3e2-bc49de71756e"), "کجور", 15 },
                    { 525, new Guid("0a358205-acd9-450c-9ab7-7579c11cbf3b"), "کتالم و سادات شهر", 15 },
                    { 524, new Guid("d0bf0e22-ec7e-42bf-a18e-bf8fd0b4faf4"), "چمستان", 15 },
                    { 523, new Guid("23b5e1fb-8a25-4758-a9c6-0bd558ba9e7e"), "چالوس", 15 },
                    { 522, new Guid("22592211-c9dc-4ef6-b739-267b66cebd68"), "پول", 15 },
                    { 521, new Guid("6e23413a-515c-49c7-8546-5e56415ecf30"), "پل سفيد", 15 },
                    { 520, new Guid("0351f6c5-d31d-4d39-88a2-406a4eb6e681"), "پايين هولار", 15 },
                    { 519, new Guid("c60b3320-ec16-46ca-80a0-c2fef5f1880d"), "هچيرود", 15 },
                    { 517, new Guid("e7c9c684-c67e-43bf-9a2f-3bc3647ff800"), "نکا", 15 },
                    { 534, new Guid("250c2951-ae65-4823-af83-d36ccd637b21"), "گلوگاه", 15 },
                    { 498, new Guid("e870be32-783d-4353-a585-f6c049c249fb"), "رينه", 15 },
                    { 496, new Guid("1649951a-5798-450d-a17c-48a80b8e18c1"), "رستمکلا", 15 },
                    { 476, new Guid("c02b1e9a-2643-4108-89ad-8457d4e99c72"), "گميش تپه", 14 },
                    { 475, new Guid("0a2fbc37-db41-4c3e-8b31-970af80eacd4"), "گرگان", 14 },
                    { 474, new Guid("8c062b92-74d0-4b90-924d-168897b8f054"), "گاليکش", 14 },
                    { 473, new Guid("3f2d9864-abdb-4b1e-8dad-fd0b62f112a2"), "کلاله", 14 },
                    { 472, new Guid("2a66c1e5-8173-49eb-8fc9-26c39f3ccf59"), "کرد کوي", 14 },
                    { 471, new Guid("f61887ba-4479-465d-9348-503a2a0f2da4"), "نگين شهر", 14 },
                    { 470, new Guid("669c034e-35fa-49a1-8847-a93800766f34"), "نوکنده", 14 },
                    { 469, new Guid("e838bf8c-9c19-4707-9f6e-5f208f906e77"), "نوده خاندوز", 14 },
                    { 306, new Guid("eae63624-4afb-479c-9572-1f4dd4295030"), "عشق آباد", 10 },
                    { 467, new Guid("b3398dc8-c0c3-46f3-bd1c-bfd3286e310e"), "مزرعه", 14 },
                    { 466, new Guid("a54f1cb1-33a1-4c0c-96a3-20532d4e9304"), "مراوه تپه", 14 },
                    { 465, new Guid("d06cb68c-eb33-48d8-aaa3-3ba9108add6b"), "فراغي", 14 },
                    { 464, new Guid("de5b6a95-29b6-4c9f-9fe5-f923058f1693"), "فاضل آباد", 14 },
                    { 463, new Guid("bea2d6d7-ad80-453f-aeda-4983e0dab553"), "علي آباد", 14 },
                    { 462, new Guid("28802077-bd9a-4005-b98a-bafdf04a4133"), "سيمين شهر", 14 },
                    { 477, new Guid("582147cb-96e0-42a1-af2c-a4a3c0b35374"), "گنبدکاووس", 14 },
                    { 497, new Guid("0b275a77-0f95-4564-a3e2-ad1756cec87f"), "رويان", 15 },
                    { 478, new Guid("233d448d-8fe2-4343-89f1-c88e590e3d86"), "آلاشت", 15 },
                    { 480, new Guid("7ced85a4-dcaa-4e25-b14c-72ddb58ef1cb"), "ارطه", 15 },
                    { 495, new Guid("b6da5119-40fa-4b84-bfed-310ca885955f"), "رامسر", 15 },
                    { 494, new Guid("36f58a58-122c-40de-b0b2-baf637e26ce1"), "دابودشت", 15 },
                    { 493, new Guid("b06eee5d-556e-4793-aa99-d9834c6d8a93"), "خوش رودپي", 15 },
                    { 492, new Guid("435a7816-e16f-4196-ab70-3f85cc892daa"), "خليل شهر", 15 },
                    { 491, new Guid("f2658869-e349-4e56-8faf-fa2430e510e2"), "خرم آباد", 15 },
                    { 490, new Guid("c211eb18-b26f-444d-8f9f-6813e00f1deb"), "جويبار", 15 },
                    { 489, new Guid("6e330b50-bc9d-4c77-9b2c-ed7de6789ef8"), "تنکابن", 15 },
                    { 488, new Guid("cda472ab-c7bc-4a31-bf88-df372682726f"), "بهنمير", 15 },
                    { 487, new Guid("3713bc87-a574-45fb-bb1a-6d1b2b002bb6"), "بهشهر", 15 },
                    { 486, new Guid("7a33aee9-2f16-45a1-b6d0-22de1f879761"), "بلده", 15 },
                    { 485, new Guid("ca38e95e-8919-4745-ae54-56a422f2e63a"), "بابلسر", 15 },
                    { 484, new Guid("22d59696-f470-418c-9767-e144e377b7b3"), "بابل", 15 },
                    { 483, new Guid("b4d66db2-1d65-43ce-ba70-0535fb6f60cc"), "ايزد شهر", 15 },
                    { 482, new Guid("0abea1d2-5cb6-435b-b6e6-941886bd71f3"), "امير کلا", 15 },
                    { 481, new Guid("f90f4609-bc32-4a1a-959a-f6383d26d02f"), "امامزاده عبدالله", 15 },
                    { 479, new Guid("a4dffb09-e914-4363-a9ec-e9341537ca86"), "آمل", 15 },
                    { 535, new Guid("44480eff-776c-4bd9-a31d-11197df74045"), "آبيک", 16 },
                    { 536, new Guid("5bf07161-c5ed-4c0a-b870-e872d20fac5a"), "آبگرم", 16 },
                    { 537, new Guid("651c5c85-de6c-4350-827d-996a0eb98f08"), "آوج", 16 },
                    { 591, new Guid("6c4061b8-b9db-4df1-bc8d-83d0e93907aa"), "تازه کند انگوت", 18 },
                    { 590, new Guid("19d38896-73d1-4a5a-ba73-96e7b793a8e7"), "تازه کند", 18 },
                    { 589, new Guid("04454ca5-e738-4d05-8d16-cb986bb99ff0"), "بيله سوار", 18 },
                    { 588, new Guid("d6e21d01-c076-4bd6-962f-cd23ab5ac4ba"), "اصلاندوز", 18 },
                    { 587, new Guid("23860e1e-c0d6-4440-86bf-cc54ba1ac466"), "اسلام آباد", 18 },
                    { 586, new Guid("fb22bce5-0c50-4559-a934-e7225f4a090d"), "اردبيل", 18 },
                    { 585, new Guid("dd669d85-f037-45b2-ad15-babc102cee86"), "آبي بيگلو", 18 },
                    { 584, new Guid("30ab2904-e83e-42bb-8d3c-78a3c0c8c3ed"), "گراب", 17 },
                    { 583, new Guid("8d91e279-4001-424d-b331-63e077c2a418"), "کوهناني", 17 },
                    { 582, new Guid("0911762a-eecd-495e-8dca-0b99875ff6e8"), "کوهدشت", 17 },
                    { 581, new Guid("27d5c4a3-9c36-40eb-b877-948a6c83ac7c"), "چقابل", 17 },
                    { 580, new Guid("2745bf63-5b24-4c39-b2b3-3b647757ef9e"), "چالانچولان", 17 },
                    { 579, new Guid("ef89d4e8-6eb5-485f-b5b0-242a9a2e8a93"), "پلدختر", 17 },
                    { 578, new Guid("a3333cb4-6e08-442c-bde7-65af111f7747"), "ويسيان", 17 },
                    { 577, new Guid("84510800-7cd5-429b-89be-09979b15f259"), "هفت چشمه", 17 },
                    { 592, new Guid("dd5b4516-14c5-4355-93f7-4a896ba73b9b"), "جعفر آباد", 18 },
                    { 576, new Guid("a50e5331-36ba-46f6-aa11-dbbe2ae29f37"), "نورآباد", 17 },
                    { 593, new Guid("9155db26-1b81-4680-963b-29120621d282"), "خلخال", 18 },
                    { 595, new Guid("094106b5-2567-48a0-bab6-978b81ae0087"), "سرعين", 18 },
                    { 610, new Guid("61eae3cb-9e84-4a3b-ac52-09c4f487ca63"), "گيوي", 18 },
                    { 609, new Guid("8b4b2ebb-190b-4020-b566-32a18af2252e"), "گرمي", 18 },
                    { 608, new Guid("5be1983d-96cb-4754-8813-4f209ea236a2"), "کورائيم", 18 },
                    { 607, new Guid("24da799e-18f9-4854-819d-64780a89ebbe"), "کلور", 18 },
                    { 606, new Guid("d8fe7f1f-da3f-4f29-bf72-d13d5282a6f3"), "پارس آباد", 18 },
                    { 605, new Guid("f86bc454-e0f4-4c01-8f9a-f7f02a00a47b"), "هير", 18 },
                    { 604, new Guid("2ba4b1ec-1097-420b-b8ca-8f8c4d76c405"), "هشتجين", 18 },
                    { 603, new Guid("b4a34455-50ec-45f4-8478-a8c4976dcce6"), "نير", 18 },
                    { 602, new Guid("7af5b049-bdbd-4501-adf8-ea647b857ce8"), "نمين", 18 },
                    { 601, new Guid("160be356-9a51-45b3-b45b-7d92856b4e2b"), "مشگين شهر", 18 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 600, new Guid("1146a6d4-0dd6-4cf1-8de9-13488cf641e6"), "مرادلو", 18 },
                    { 599, new Guid("51662238-3eb2-42d8-8c17-18f5ae078f74"), "لاهرود", 18 },
                    { 598, new Guid("f74b22ee-6652-4fbe-bddc-a1edb7c3c838"), "قصابه", 18 },
                    { 597, new Guid("5c758bb6-a210-44a2-8c2e-6fc5261441e4"), "فخرآباد", 18 },
                    { 596, new Guid("fd2d5641-db3d-4061-90b9-26737638d080"), "عنبران", 18 },
                    { 594, new Guid("d9922972-9570-49dd-8022-920ff7ab534b"), "رضي", 18 },
                    { 575, new Guid("7405b4a0-b3c7-416d-87bc-3e40f98e0bff"), "مومن آباد", 17 },
                    { 574, new Guid("ed33dc24-36f6-46f3-9a03-a8b5722e43f2"), "معمولان", 17 },
                    { 573, new Guid("31b61e8f-dcfe-4f25-aff7-ff05904fd1b4"), "فيروزآباد", 17 },
                    { 552, new Guid("7d461ef9-bb01-4a93-9561-35a9dc7dd893"), "شريفيه", 16 },
                    { 551, new Guid("577317ce-bfc5-4944-8298-1f0b5c87c9a8"), "شال", 16 },
                    { 550, new Guid("93917de2-bb55-44bf-a7b3-13bf0fcc9b8d"), "سگز آباد", 16 },
                    { 549, new Guid("b8c90e21-90f8-42c3-b2db-a003702446ac"), "سيردان", 16 },
                    { 548, new Guid("7463279e-9e31-43f3-a967-5fa3f0ccef5c"), "رازميان", 16 },
                    { 547, new Guid("17df9150-3820-4e4e-b27f-bec88333f21a"), "دانسفهان", 16 },
                    { 546, new Guid("5bc4d070-b635-45bf-b936-5c7d1a6c7066"), "خرمدشت", 16 },
                    { 545, new Guid("ac21b659-d6dd-48e6-9654-39783855fdd2"), "خاکعلي", 16 },
                    { 544, new Guid("eefcd9f8-624d-455a-90e8-9d6572585249"), "تاکستان", 16 },
                    { 543, new Guid("483a7d7d-6c4d-402d-bb7e-6ff5a581e5b6"), "بيدستان", 16 },
                    { 542, new Guid("2975a624-77c5-4ee8-a44f-6a680449510c"), "بوئين زهرا", 16 },
                    { 541, new Guid("505bacad-a8b8-476f-8e99-61018830ec08"), "الوند", 16 },
                    { 540, new Guid("42f8e72a-246c-40e4-ac7b-37612d4912f4"), "اقباليه", 16 },
                    { 539, new Guid("4721e51b-faea-4618-992c-4e499326bff9"), "اسفرورين", 16 },
                    { 538, new Guid("ec168d3a-be07-439d-b6a1-3bffff6a73bc"), "ارداق", 16 },
                    { 553, new Guid("d6ae9fe9-ce8b-42d3-91f3-5fbb9c5a136a"), "ضياء آباد", 16 },
                    { 554, new Guid("475cef46-4b50-4e82-bbad-bd977774ecaa"), "قزوين", 16 },
                    { 555, new Guid("c1c4e583-c377-48f9-96c9-08fdf159a9e3"), "محمديه", 16 },
                    { 556, new Guid("65b15f32-9575-4ee6-8c69-858072e62381"), "محمود آباد نمونه", 16 },
                    { 572, new Guid("e25df2d7-466a-4ea3-8dad-f500a43f0181"), "شول آباد", 17 },
                    { 571, new Guid("8147cb67-4a2e-4f40-a52f-e13fe8033ff0"), "سپيد دشت", 17 },
                    { 570, new Guid("89d627e0-a4dd-489d-bad2-16a6867b3822"), "سراب دوره", 17 },
                    { 569, new Guid("3daf3512-685d-4a8c-888c-5628c0cf7105"), "زاغه", 17 },
                    { 568, new Guid("a842982a-fdfe-4093-818f-17fa8ce94ecd"), "دورود", 17 },
                    { 567, new Guid("534737e8-bf8b-4bdd-981a-0f9092bcff70"), "درب گنبد", 17 },
                    { 566, new Guid("b1be17f0-a48f-47a3-a941-0c5e144650ab"), "خرم آباد", 17 },
                    { 461, new Guid("6f611162-eb29-4c04-820d-d92248368318"), "سنگدوين", 14 },
                    { 565, new Guid("1e5fab7b-f7fb-497f-9053-274c66552dc2"), "بيرانشهر", 17 },
                    { 563, new Guid("8e32f2f2-22b5-465e-806e-f7a2339c9ad9"), "اليگودرز", 17 },
                    { 562, new Guid("76fdb2b7-03e3-4889-890a-baeffe58d8b3"), "الشتر", 17 },
                    { 561, new Guid("f9c53556-f215-420a-9303-e31a82938f7c"), "اشترينان", 17 },
                    { 560, new Guid("7a207f45-ee76-4b7a-bdbf-b8e2f028f96d"), "ازنا", 17 },
                    { 559, new Guid("7607435c-adba-439d-bc64-091c90bcfa2e"), "کوهين", 16 },
                    { 558, new Guid("befbcffe-8441-4571-bb05-f3c8d73ef7a8"), "نرجه", 16 },
                    { 557, new Guid("41e31db7-0922-4ee8-befe-8ce5bb43b007"), "معلم کلايه", 16 },
                    { 564, new Guid("f7e7f9c6-6caa-4307-9597-1174b238b793"), "بروجرد", 17 },
                    { 460, new Guid("a0402f03-1ea4-432a-9162-a2f6d7d34f56"), "سرخنکلاته", 14 },
                    { 468, new Guid("640153a1-33a4-401b-9b86-dbeafe59db36"), "مينودشت", 14 },
                    { 458, new Guid("909c3b0d-315b-4b46-a3f5-2ad4074498a3"), "دلند", 14 },
                    { 361, new Guid("4c006024-8c55-41f2-9c50-26c8f3d09504"), "شوش", 11 },
                    { 360, new Guid("6e26d162-f3c3-4b89-8043-8ef7a56aa61a"), "شهر امام", 11 },
                    { 359, new Guid("39c49df8-58ff-4dc8-b885-5d6e001465cf"), "شمس آباد", 11 },
                    { 358, new Guid("fd3e87e2-17d8-459e-92bf-c116d02e601d"), "شرافت", 11 },
                    { 357, new Guid("b3c9998f-e502-4572-8109-2ed262b87bd3"), "شاوور", 11 },
                    { 356, new Guid("d29461d3-67e7-47d0-80fe-bd2de3000aee"), "شادگان", 11 },
                    { 355, new Guid("9bdd433c-e57b-4921-b804-467634350689"), "سياه منصور", 11 },
                    { 354, new Guid("68f69780-5807-466b-9615-4ddec259aac0"), "سوسنگرد", 11 },
                    { 353, new Guid("460b466d-afcf-4314-a2c5-e0b5b4bb1880"), "سماله", 11 },
                    { 352, new Guid("cb0965da-1bbf-44d0-acf0-0618e46ec979"), "سردشت", 11 },
                    { 351, new Guid("168dead4-36d6-445b-8f7a-8f154f81c00c"), "سرداران", 11 },
                    { 350, new Guid("739702cf-64ac-4c2e-9986-2105e30d7cd7"), "سالند", 11 },
                    { 349, new Guid("a2b7f599-357c-4d6a-a4c8-3fcfc27d65df"), "زهره", 11 },
                    { 348, new Guid("73452303-948b-4532-b0c8-8319a7c784ca"), "رفيع", 11 },
                    { 347, new Guid("87e28f11-ff65-455b-9c9d-a0b0c8240371"), "رامهرمز", 11 },
                    { 362, new Guid("a9ed6dcd-1ae3-435c-9204-5022514d24cd"), "شوشتر", 11 },
                    { 346, new Guid("92f97ca7-6a08-49d4-8904-ed4415c9e2b0"), "رامشير", 11 },
                    { 363, new Guid("125641df-9095-40eb-930b-2c357104e922"), "شيبان", 11 },
                    { 365, new Guid("27805da2-3901-43be-ac37-deed36c2e59e"), "صفي آباد", 11 },
                    { 380, new Guid("f4534f1b-d82f-4d8b-82ca-38ef03b687a3"), "هنديجان", 11 },
                    { 379, new Guid("f10783d8-2d4a-46a6-82ed-0dfd52e6c233"), "هفتگل", 11 },
                    { 378, new Guid("1fdd7bab-fd1e-433a-afef-6dffd14d1961"), "مينوشهر", 11 },
                    { 377, new Guid("268fa3a1-8e08-4eb2-8dce-e8cba345c55f"), "ميداود", 11 },
                    { 376, new Guid("c2502b96-16f8-47d4-bdfb-1fd446dc28c7"), "ميانرود", 11 },
                    { 375, new Guid("55235515-571c-4fac-adb1-639e9684cccc"), "منصوريه", 11 },
                    { 459, new Guid("a3e0513c-958a-41fc-99b0-0a4ed9b8f5d6"), "راميان", 14 },
                    { 373, new Guid("c720ca59-24dc-420a-92e8-4c9ffd75f727"), "مقاومت", 11 },
                    { 372, new Guid("6dae7e6f-d6e4-4e93-b2b0-f0b64933e869"), "مشراگه", 11 },
                    { 371, new Guid("b442e4d7-abec-428a-9fff-21a6379c333d"), "مسجد سليمان", 11 },
                    { 370, new Guid("0068b7e6-cb38-48f0-bbc7-0ec9c286c21a"), "لالي", 11 },
                    { 369, new Guid("78d72329-19ce-4d4a-ae78-6d854ad5ccb5"), "قلعه خواجه", 11 },
                    { 368, new Guid("0a47de21-8a9d-4a6b-a37f-94b8c3c2625d"), "قلعه تل", 11 },
                    { 367, new Guid("b75e2aee-18c0-4119-acc9-82186be7be89"), "فتح المبين", 11 },
                    { 366, new Guid("da0044ca-676e-4435-af51-44fe14794298"), "صيدون", 11 },
                    { 364, new Guid("4dded659-ce59-4afe-a98a-4341f201a584"), "صالح شهر", 11 },
                    { 345, new Guid("3b986d93-25b2-4cf8-a324-9207ac41ab55"), "دهدز", 11 },
                    { 344, new Guid("9c7275ba-e460-4c4b-9c0e-917c459bc69d"), "دزفول", 11 },
                    { 343, new Guid("85797d22-b33d-478d-acaa-75df5d90b4e0"), "دارخوين", 11 },
                    { 322, new Guid("04a72838-2b06-4b03-be60-6a219aea6214"), "الوان", 11 },
                    { 321, new Guid("cb056bc7-c364-42ac-b454-5ded24d7c25d"), "الهايي", 11 },
                    { 320, new Guid("a6d535d3-3888-45b5-bdfe-f35e25e26775"), "اروند کنار", 11 },
                    { 319, new Guid("fb56ed98-6610-4a76-99ac-00eef5ff800f"), "ابوحميظه", 11 },
                    { 318, new Guid("2214ccd9-431a-4bb8-932e-c1c5ae5472be"), "آغاجاري", 11 },
                    { 317, new Guid("c86eeab3-b1a7-4aed-bb6d-a39ffa442146"), "آزادي", 11 },
                    { 316, new Guid("a2fa5026-3bbb-4192-ad3f-b9ff1d53d8c2"), "آبژدان", 11 },
                    { 315, new Guid("1fa8acc5-ffc2-479f-822a-dd06dc305ee2"), "آبادان", 11 },
                    { 314, new Guid("6c9aff3f-86ca-46a1-b2ce-a052973a2a01"), "گزيک", 10 },
                    { 313, new Guid("6eb1c7e7-2743-45c0-b001-0096067d1dc2"), "نيمبلوک", 10 },
                    { 312, new Guid("cab25c4f-63ea-4b12-a188-f9060ee6d858"), "نهبندان", 10 },
                    { 311, new Guid("fbb7d36e-fc50-4df3-8936-d4eb79fef740"), "مود", 10 },
                    { 310, new Guid("2fdaaf5f-47b8-4170-80ee-7686dcbd61bd"), "محمدشهر", 10 },
                    { 309, new Guid("17279d29-5a48-4ef8-95fa-b939d1f871d1"), "قهستان", 10 },
                    { 308, new Guid("cf559baf-5b83-4b55-a180-9fafde5e8cdd"), "قائن", 10 },
                    { 323, new Guid("ae5d08b1-58e4-4a79-ad23-af7b57f6f205"), "اميديه", 11 },
                    { 324, new Guid("50d22a9a-ca13-491c-815e-94c74f83f6a0"), "انديمشک", 11 },
                    { 325, new Guid("3f95ff82-59fb-40be-92f0-6b18dc94107c"), "اهواز", 11 },
                    { 326, new Guid("0806a1b2-8adc-4068-a70f-b08de920c898"), "ايذه", 11 },
                    { 342, new Guid("3e6f5ddf-bd5f-4141-8cc7-68a1a71aad7d"), "خنافره", 11 },
                    { 341, new Guid("4529774c-320f-4fa8-be2c-ad5c1b07bb1f"), "خرمشهر", 11 },
                    { 340, new Guid("e709f7f0-926a-4355-9c7f-fb32ba26841f"), "حميديه", 11 },
                    { 339, new Guid("3b7a5a99-3438-4c26-b515-95512f856d44"), "حمزه", 11 },
                    { 338, new Guid("ece39ce4-34bc-4a8f-bd68-b0f99825852b"), "حسينيه", 11 },
                    { 337, new Guid("c2538ee7-2d45-4b7d-a772-7107ffa2175d"), "حر", 11 },
                    { 336, new Guid("dc391039-2181-4c44-bfca-c6266e0a5047"), "جنت مکان", 11 },
                    { 381, new Guid("7725cf19-0a8d-43e5-bc36-88822b39fcc8"), "هويزه", 11 },
                    { 335, new Guid("18ef27dc-55bc-4eb4-bcc5-5868e2dd4048"), "جايزان", 11 },
                    { 333, new Guid("9ea82830-7941-42cf-ac0c-eb09bedd1d12"), "ترکالکي", 11 },
                    { 332, new Guid("c2196f8c-143c-4694-b48c-721d2554da09"), "بيدروبه", 11 },
                    { 331, new Guid("1cefe0e7-1168-4d68-a822-a714847be3bf"), "بهبهان", 11 },
                    { 330, new Guid("5d21dc0d-e4da-4b60-a865-350a4bec5095"), "بندر ماهشهر", 11 },
                    { 329, new Guid("c174352c-aad5-487a-a311-34a7f6e1b697"), "بندر امام خميني", 11 },
                    { 328, new Guid("7d432dc4-1f1b-48b2-82bb-0f86fbfc5a26"), "بستان", 11 },
                    { 327, new Guid("e7abcb29-f9ca-4838-89da-72825683377f"), "باغ ملک", 11 },
                    { 334, new Guid("2c4839dd-387d-4473-9cc9-35cfc34bcb0e"), "تشان", 11 },
                    { 382, new Guid("099fa013-1910-434b-9c03-4e757342388b"), "ويس", 11 },
                    { 374, new Guid("b9eba596-dadb-4896-a22e-3281204eeaca"), "ملاثاني", 11 },
                    { 384, new Guid("0116dedc-65dc-4a34-96a3-aa59d50be2ea"), "چم گلک", 11 },
                    { 438, new Guid("5aab4484-eb30-4739-962c-efb9e26480ab"), "سلطانيه", 13 },
                    { 437, new Guid("72a41a52-5ad2-43c0-a8b7-ceb457c98835"), "سجاس", 13 },
                    { 436, new Guid("cf11f687-2dd2-4007-8330-d1b4a89e7fcf"), "زنجان", 13 },
                    { 435, new Guid("ab4b7db2-1b74-4346-9b09-2ffabf7d4c9b"), "زرين رود", 13 },
                    { 434, new Guid("9062dbad-8781-430c-a623-b23548e4b576"), "زرين آباد", 13 },
                    { 433, new Guid("5b61ab2a-9246-48f8-b30a-0decde5ef953"), "دندي", 13 },
                    { 432, new Guid("d253e5fa-d2d6-4b0c-8726-6b6b174a52e8"), "خرمدره", 13 },
                    { 431, new Guid("6f3079f8-7086-4800-b4a5-4694ab193a8e"), "حلب", 13 },
                    { 383, new Guid("7fd70bc3-3932-42ba-8a7b-efe8d5e0eaee"), "چغاميش", 11 },
                    { 429, new Guid("ed6549c8-c782-4939-bccd-c405a2369dca"), "ابهر", 13 },
                    { 428, new Guid("59a740e7-b562-47fa-bc81-b0657bbca88c"), "آب بر", 13 },
                    { 427, new Guid("e78efb5f-3f6e-4cac-ba00-a45fac792c3e"), "کلمه", 12 },
                    { 426, new Guid("a7f63d4d-cec7-4707-bdce-e76ed59e982d"), "کاکي", 12 },
                    { 425, new Guid("ef9f6526-cd6f-454e-b811-ee9130155ab5"), "چغادک", 12 },
                    { 424, new Guid("aaa786a6-442c-4d85-8c0f-faa1b0b0208a"), "وحدتيه", 12 },
                    { 439, new Guid("4edc2bb0-df54-4106-9c87-965379b2219e"), "سهرورد", 13 },
                    { 423, new Guid("0c2fb345-fa97-47ae-8650-0cc6111f9f3a"), "نخل تقي", 12 },
                    { 440, new Guid("d3b8db77-2e40-400d-8d05-7bc52b1c2c57"), "صائين قلعه", 13 },
                    { 442, new Guid("c8cded89-e022-4bf2-8828-1108103eab47"), "ماه نشان", 13 },
                    { 457, new Guid("06a27824-f751-44f5-a77f-025157a85d45"), "خان ببين", 14 },
                    { 456, new Guid("3a32d1f2-bc3f-48e2-b395-cbfe9dd7de4d"), "جلين", 14 },
                    { 455, new Guid("4e085f18-aed2-4946-b416-d0440216089d"), "تاتار عليا", 14 },
                    { 454, new Guid("878f0575-088d-43f6-bb50-128b1dc589d7"), "بندر گز", 14 },
                    { 453, new Guid("3b3bc255-dab8-4136-968c-cf7348ad71e8"), "بندر ترکمن", 14 },
                    { 452, new Guid("069ea2e6-b1e4-4d91-bf41-a09256cb2191"), "اينچه برون", 14 },
                    { 451, new Guid("22dedc5c-7b6a-4362-b5ff-9722a1f5f143"), "انبار آلوم", 14 },
                    { 450, new Guid("85dc375e-1dec-425c-a6da-8045308f7709"), "آق قلا", 14 },
                    { 449, new Guid("88ff3c4b-fb19-4e25-b9c6-754d20c360ad"), "آزاد شهر", 14 },
                    { 448, new Guid("55f76ebc-b1e9-4f87-95ae-bfc1799aa8bc"), "گرماب", 13 },
                    { 447, new Guid("74f935a8-b266-48ea-9d74-2230e0f5f679"), "کرسف", 13 },
                    { 446, new Guid("e6ada71d-1356-42fc-933b-ec22306c7bb4"), "چورزق", 13 },
                    { 445, new Guid("187450f9-8c8d-4e4a-95d0-a7a283078bf9"), "هيدج", 13 },
                    { 444, new Guid("fa4178e6-6cd8-4f3c-801c-52c699622ab7"), "نيک پي", 13 },
                    { 443, new Guid("626b0248-5231-4284-973c-b138ffe698da"), "نوربهار", 13 },
                    { 441, new Guid("976405a3-ea9a-493b-8aa7-1a7b68f84336"), "قيدار", 13 },
                    { 422, new Guid("0b8e0890-9474-4aaa-9f14-31eea9dba8b6"), "عسلويه", 12 },
                    { 430, new Guid("5909830d-d53a-4b9b-b489-1c04823c2a94"), "ارمخانخانه", 13 },
                    { 420, new Guid("3f2627a0-faa9-4b84-b193-ef3c7a177b97"), "شبانکاره", 12 },
                    { 399, new Guid("ca2a480a-1182-48ea-9c98-e87e88d2fec1"), "برازجان", 12 },
                    { 398, new Guid("1a766f43-11d9-420c-8e95-0dc231214cc7"), "بادوله", 12 },
                    { 397, new Guid("37cca037-bef3-4ce0-88cd-92dc1c39e4ba"), "اهرم", 12 },
                    { 396, new Guid("2eb56a54-14c5-4ba7-bb4e-1f5ef342079c"), "انارستان", 12 },
                    { 395, new Guid("c506750b-b8bb-4eca-bed2-37b9d64eb823"), "امام حسن", 12 },
                    { 394, new Guid("e44f6faa-8c6f-4042-8548-e987ed5d34d0"), "آبپخش", 12 },
                    { 421, new Guid("065b9fc3-d6c3-4b51-8dbd-53fa3f366176"), "شنبه", 12 },
                    { 392, new Guid("d1b2caf2-c6c6-49e4-a0aa-6b9ca5b5be00"), "آباد", 12 },
                    { 391, new Guid("ded334d3-c838-46a7-8536-08db4c3e647e"), "گوريه", 11 },
                    { 390, new Guid("cdf36d0f-7170-4a7c-82ad-e2554bf61df9"), "گلگير", 11 },
                    { 389, new Guid("55c93f94-8c4a-4324-8813-126c71498fc0"), "گتوند", 11 },
                    { 388, new Guid("a9ce3c3a-071f-4ce7-9af9-9e08be5f0262"), "کوت عبدالله", 11 },
                    { 387, new Guid("5bcafad5-ed61-4615-823a-6810f76e7555"), "کوت سيدنعيم", 11 },
                    { 386, new Guid("94ba55f2-1c73-48a1-9327-9a17c79ac426"), "چوئبده", 11 },
                    { 385, new Guid("4a43abb0-2fca-43c9-a96c-cd010f900c08"), "چمران", 11 },
                    { 400, new Guid("710c0c3f-5cae-48ac-b944-e389128beefc"), "بردخون", 12 },
                    { 401, new Guid("781e967c-0a79-4527-b91c-214ab6c6ee49"), "بردستان", 12 },
                    { 393, new Guid("988018fa-d1ec-4e73-b3d7-7ca7a67cb509"), "آبدان", 12 },
                    { 403, new Guid("57275940-836e-40dd-9bc4-599ce9313ade"), "بندر ديلم", 12 },
                    { 402, new Guid("f1214e4d-a0b2-4288-8149-2a0cdf001543"), "بندر دير", 12 },
                    { 419, new Guid("9eee6a81-a0af-4801-a2ac-b5b0dc6f0571"), "سيراف", 12 },
                    { 418, new Guid("1e6251be-1289-4d76-8099-7072cadf8dbf"), "سعد آباد", 12 },
                    { 417, new Guid("69132512-1212-4880-8c09-7e356cacb1e7"), "ريز", 12 },
                    { 416, new Guid("33755117-e614-42ad-94c9-3a78f7ab6e64"), "دوراهک", 12 },
                    { 414, new Guid("fe363f33-1f7b-4a35-a8db-2a2acb2a44c0"), "دالکي", 12 },
                    { 413, new Guid("fea2f41c-d6de-4f4f-b3f6-e4f3f4dee85f"), "خورموج", 12 },
                    { 412, new Guid("df5b753a-a7a3-4120-ac2e-695840c09674"), "خارک", 12 },
                    { 415, new Guid("abede31e-44e2-445a-ae94-1495639082b6"), "دلوار", 12 },
                    { 410, new Guid("8bdc7b50-3ead-4615-9ace-a5cca1352767"), "تنگ ارم", 12 },
                    { 409, new Guid("321a6733-26f1-491e-a2de-c3e88e2cd9c0"), "بوشکان", 12 },
                    { 408, new Guid("f16f6c63-424f-47be-a8a4-057f1de8e8b0"), "بوشهر", 12 },
                    { 407, new Guid("4515f648-8a4f-4a6d-9037-f282430c97eb"), "بنک", 12 },
                    { 406, new Guid("c6698c1f-f119-4724-97ab-d4746ae819b0"), "بندر گناوه", 12 },
                    { 405, new Guid("61466df7-4420-4e63-a34a-7e7c1279770b"), "بندر کنگان", 12 },
                    { 404, new Guid("8ea367fe-e66e-4690-994c-3fce92604fab"), "بندر ريگ", 12 },
                    { 411, new Guid("49b5ef36-c212-4c50-b1bb-5d9cf876a79b"), "جم", 12 }
                });

            migrationBuilder.InsertData(
                table: "Code",
                columns: new[] { "CodeID", "CodeGroupID", "CodeGUID", "DisplayName", "Name" },
                values: new object[,]
                {
                    { 7, 3, new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"), "زن", "Female" },
                    { 1, 1, new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"), "png", "image/png" },
                    { 2, 1, new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"), "jpg", "image/jpg" },
                    { 3, 1, new Guid("3209341a-07d4-437b-9301-2d0f909ad713"), "jpeg", "image/jpeg" },
                    { 4, 2, new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"), "به صورت شخصی فعالیت میکنم", "به صورت شخصی فعالیت میکنم" },
                    { 5, 2, new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"), "نماینده یک شرکت هستم", "نماینده یک شرکت هستم" },
                    { 6, 2, new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"), "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم", "نماینده یک واحد، آموزشگاه یا دیگر مجوز ها هستم" },
                    { 8, 3, new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"), "مرد", "Male" },
                    { 17, 6, new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"), "حقیقی", "Natural" },
                    { 10, 4, new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"), "در حال انجام", "Doing" },
                    { 11, 4, new Guid("2b9d07c8-5535-495e-8557-da32acb58600"), "انجام شده", "Done" },
                    { 12, 4, new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"), "لغو شده", "Canceled" },
                    { 13, 4, new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"), "ادمین", "Admin" },
                    { 14, 4, new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"), "سرویس گیرنده", "Client" },
                    { 15, 4, new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"), "سرویس دهنده", "Contractor" },
                    { 16, 6, new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"), "حقوقی", "Legal" },
                    { 9, 4, new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"), "در انتظار تایید", "Waiting" }
                });

            migrationBuilder.InsertData(
                table: "SMSProviderSetting",
                columns: new[] { "SMSProviderSettingID", "APIKey", "Password", "SMSProviderID", "Username" },
                values: new object[] { 1, "61726634455053586E44464E413462574A76535677436B547236574B56386D6A6F6E4F326A374A4C7755773D", "ptcoptco", 1, "ptmgroupco@gmail.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 5, null, null, new Guid("8db4fbe1-b6f2-467f-8a95-941d1ee3d8ba"), null, null, "تاسیسات", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(710), 3, null, 1 },
                    { 31, null, null, new Guid("6c09710d-7f38-4444-a1d7-7dc5215deb1f"), null, null, "سرویس و تعمیر خودرو", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1449), 4, null, 3 },
                    { 30, null, null, new Guid("821054eb-b531-4753-b828-227472a8c8b5"), null, null, "اجاره خودرو", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1430), 4, null, 2 },
                    { 29, null, null, new Guid("93563a09-8cc3-4b5f-8f7d-734058a08da7"), null, null, "اتوبار", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1408), 4, null, 1 },
                    { 21, null, null, new Guid("9b4cfb65-1e49-4a46-a060-b34d3392b048"), null, null, "کار در ارتفاع", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1179), 3, null, 17 },
                    { 20, null, null, new Guid("bc996806-8481-4aa5-8ee7-750a83a08616"), null, null, "آسانسور و بالابر", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1157), 3, null, 16 },
                    { 19, null, null, new Guid("f1b23e49-aae7-4774-a659-42635afb55a5"), null, null, "نجاری", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1135), 3, null, 15 },
                    { 18, null, null, new Guid("317f11bf-8e8c-4caa-9b3c-f735b2791f73"), null, null, "تعمیرات لوازم خانگی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1115), 3, null, 14 },
                    { 16, null, null, new Guid("ed41941b-16b0-422c-bd72-c969e3ade50f"), null, null, "عایق کاری", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1066), 3, null, 12 },
                    { 15, null, null, new Guid("4736c559-57c1-400d-91b1-a771ae7cfda6"), null, null, "عایق کاری", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1046), 3, null, 11 },
                    { 17, null, null, new Guid("d3abb76f-d676-4ec0-875e-ac93adecb382"), null, null, "نرده و حفاظ استیل", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1095), 3, null, 13 },
                    { 13, null, null, new Guid("c6e04f08-38a7-4b26-8db4-6356edeb6aa9"), null, null, "بنایی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1009), 3, null, 9 },
                    { 12, null, null, new Guid("79f1e730-8b05-4c8c-aa60-e5eafce35c5d"), null, null, "دکوراسیون داخلی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(988), 3, null, 8 },
                    { 11, null, null, new Guid("1e0d9331-90ae-409c-93af-67e9ff7a4334"), null, null, "کابینت سازی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(967), 3, null, 7 },
                    { 10, null, null, new Guid("05236875-c49b-4271-b318-0ab7bb5b4657"), null, null, "شیشه بری و قابسازی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(946), 3, null, 6 },
                    { 9, null, null, new Guid("71fce2a5-0c66-40a3-adca-88c380db37c2"), null, null, "آلومینیوم سازی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(925), 3, null, 5 },
                    { 8, null, null, new Guid("6a3133f2-3a47-46bb-afaf-b02e3ccb0bd0"), null, null, "مبلمان", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(887), 3, null, 4 },
                    { 7, null, null, new Guid("bc997237-4eab-496c-8985-34d2f63e557d"), null, null, "ایمنی و امنیت", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(750), 3, null, 3 },
                    { 6, null, null, new Guid("7c93509a-a5dc-40d2-ad38-4c0551de438f"), null, null, "الکتریکی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(729), 3, null, 2 },
                    { 14, null, null, new Guid("850870f3-329e-4f62-8a41-28d6c108f4b0"), null, null, "آهنگری", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1028), 3, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "SMSTemplate",
                columns: new[] { "SMSTemplateID", "Name", "SMSProviderSettingID" },
                values: new object[] { 1, "VerifyAccount", 1 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "GenderCodeID", "IsActive", "IsRegister", "LastName", "ModifiedDate", "PhoneNumber", "ProfileDocumentID", "RegisteredDate", "RoleID", "UserGUID" },
                values: new object[,]
                {
                    { 4, "white.luciferrr@gmail.com", "محمد", 8, true, true, "میرزایی", new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(4346), "09147830093", null, new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(4339), 2, new Guid("3039bb8d-42c9-48b4-9571-0e487c21adb2") },
                    { 1, "mahdiroudaki@hotmail.com", "سید مهدی", 8, true, true, "رودکی", new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(568), "09227204305", null, new DateTime(2020, 6, 15, 16, 58, 11, 170, DateTimeKind.Local).AddTicks(9519), 1, new Guid("52a2b449-429f-47d2-a993-ae71b81e17d8") },
                    { 2, "roozbehshamekhi@hotmail.com", "روزبه", 8, true, true, "شامخی", new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(4217), "09128277075", null, new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(4170), 3, new Guid("20d3a70a-a9f5-4e07-b45e-72aa0897a437") },
                    { 3, "dead.hh98@gmail.com", "حامد", 8, true, true, "حقیقیان", new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(4308), "09108347428", null, new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(4299), 2, new Guid("ee237459-09ae-4b2a-8129-fba972e10109") }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminGUID", "IsDelete", "ModifiedDate", "UserID" },
                values: new object[] { 1, new Guid("f3c05c82-e725-4d54-9f1e-69a734c6962d"), false, new DateTime(2020, 6, 15, 16, 58, 11, 171, DateTimeKind.Local).AddTicks(8292), 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 22, null, null, new Guid("13fb15cc-a49f-4654-bcd9-e3ad41f46f06"), null, null, "سرویس کولر آبی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1197), 5, null, 1 },
                    { 23, null, null, new Guid("06bb01a4-159c-4fd2-8e16-eebdbebd1e21"), null, null, "نقاشی ساختمان", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1216), 5, null, 2 },
                    { 24, null, null, new Guid("608a63e4-635e-4902-9bff-cc94302962d7"), null, null, "رنگ کاری مبل", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1305), 8, null, 1 },
                    { 25, null, null, new Guid("577b658b-f564-4a70-8dc2-c6d3bb9240b1"), null, null, "تعمیر صندلی اداری", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1334), 8, null, 2 },
                    { 26, null, null, new Guid("8e75f86f-6de2-4691-b794-4353d3180dde"), null, null, "ساخت مبلمان", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1352), 8, null, 3 },
                    { 27, null, null, new Guid("75da9a7c-194b-484f-8014-2b4d0d415f5f"), null, null, "دوخت کاور مبل", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1374), 8, null, 4 },
                    { 28, null, null, new Guid("024b9727-d943-4777-a87d-1e02853d31f3"), null, null, "تعمیر مبل", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1390), 8, null, 5 },
                    { 32, null, null, new Guid("a0e71300-b05c-4759-89b9-54c28defafa2"), null, null, "وانت بار", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1469), 29, null, 1 },
                    { 33, null, null, new Guid("6bcf4231-c1b4-476d-9258-eaf8f55eedc3"), null, null, "باربری و اتوبار", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1495), 29, null, 2 },
                    { 34, null, null, new Guid("48f08b61-c111-4688-b9c8-9ac3cdf7e3c9"), null, null, "کارگر اسباب کشی", null, true, new DateTime(2020, 6, 15, 16, 58, 11, 179, DateTimeKind.Local).AddTicks(1510), 29, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "CityID", "ClientGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, 751, new Guid("b120653d-1515-45c1-954f-ea014bca850d"), new DateTime(2020, 6, 15, 16, 58, 11, 172, DateTimeKind.Local).AddTicks(8886), 2 });

            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "ContractorID", "AverageRate", "BusinessTypeCodeID", "CityID", "ContractorGUID", "Credit", "Latitude", "Longitude", "ModifiedDate", "UserID" },
                values: new object[,]
                {
                    { 1, null, 4, 751, new Guid("5d390402-7441-418a-baa1-d7b307f72e56"), 0, "1", "2", new DateTime(2020, 6, 15, 16, 58, 11, 175, DateTimeKind.Local).AddTicks(179), 3 },
                    { 2, null, 4, 751, new Guid("0b468746-137f-4c58-a7dd-311307a9c5ad"), 10000, "1", "2", new DateTime(2020, 6, 15, 16, 58, 11, 175, DateTimeKind.Local).AddTicks(1565), 4 }
                });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[,]
                {
                    { 1, 4, new Guid("50f5b284-aff3-441e-a446-484f78fbc70c"), 1 },
                    { 2, 5, new Guid("6538eb5e-bd42-4dc2-9f22-2a5dcdd21e81"), 1 },
                    { 3, 14, new Guid("e0f0943c-13f8-430d-a66b-b70aab582bd3"), 1 },
                    { 4, 22, new Guid("01f10561-da9a-44a2-b1b3-a354f6bdc70c"), 1 },
                    { 5, 25, new Guid("ff384d6a-85e3-4373-826f-d431c8da7bc7"), 1 },
                    { 6, 30, new Guid("22e384ae-0dea-4635-b9af-eec23400919f"), 1 },
                    { 7, 33, new Guid("3453e994-c7fa-48a3-bbc9-4ffb4d640877"), 1 },
                    { 8, 34, new Guid("12df2195-efea-4d1d-af8b-29310fe55032"), 1 },
                    { 9, 27, new Guid("027db6d3-49fe-45f2-883f-4635bbf5ce97"), 1 },
                    { 10, 20, new Guid("db65a591-57de-4433-9cde-f18e7066df4c"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CategoryID", "ClientID", "Comment", "ContractorID", "Cost", "DeadlineDate", "Description", "ModifiedDate", "OrderGUID", "Rate", "StateCodeID", "Title" },
                values: new object[,]
                {
                    { 1, 14, 1, null, null, null, null, "توضیح", new DateTime(2020, 6, 15, 16, 58, 11, 176, DateTimeKind.Local).AddTicks(4093), new Guid("26bc868b-ce23-41b2-b8f7-d5be35862bc4"), null, 9, "تیتر" },
                    { 2, 22, 1, null, null, null, null, "کولر ماشین مشکل داره", new DateTime(2020, 6, 15, 16, 58, 11, 176, DateTimeKind.Local).AddTicks(4823), new Guid("e16617d6-7183-4afc-b435-c96fac9b4ac9"), null, 9, "مشکل" }
                });

            migrationBuilder.InsertData(
                table: "OrderRequest",
                columns: new[] { "OrderRequestID", "ContractorID", "IsAllow", "Message", "ModifiedDate", "OfferedPrice", "OrderID", "OrderRequestGUID" },
                values: new object[] { 1, 1, true, "پیام", new DateTime(2020, 6, 15, 16, 58, 11, 177, DateTimeKind.Local).AddTicks(1414), 250000L, 1, new Guid("f700f27a-2b3d-411a-82f7-e2fb06b8f3c5") });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserID",
                table: "Admin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_DocumentID",
                table: "Advertisement",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ActiveIconDocumentID",
                table: "Category",
                column: "ActiveIconDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CoverDocumentID",
                table: "Category",
                column: "CoverDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_InactiveIconDocumentID",
                table: "Category",
                column: "InactiveIconDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryID",
                table: "Category",
                column: "ParentCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_QuadMenuDocumentID",
                table: "Category",
                column: "QuadMenuDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTag_CategoryID",
                table: "CategoryTag",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTag_TagID",
                table: "CategoryTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_OrderRequestID",
                table: "ChatMessage",
                column: "OrderRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessage_UserID",
                table: "ChatMessage",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceID",
                table: "City",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_CityID",
                table: "Client",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserID",
                table: "Client",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Code_Code_CGID",
                table: "Code",
                column: "CodeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_UserID",
                table: "Complaint",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_ContactUsBusinessTypeCodeID",
                table: "ContactUs",
                column: "ContactUsBusinessTypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_BusinessTypeCodeID",
                table: "Contractor",
                column: "BusinessTypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_CityID",
                table: "Contractor",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Contractor_UserID",
                table: "Contractor",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorCategory_CategoryID",
                table: "ContractorCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorCategory_ContractorID",
                table: "ContractorCategory",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDiscount_ContractorID",
                table: "ContractorDiscount",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorDiscount_PublicDiscountID",
                table: "ContractorDiscount",
                column: "PublicDiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Document_Document_TypeCodeID",
                table: "Document",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CategoryID",
                table: "Order",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientID",
                table: "Order",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ContractorID",
                table: "Order",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StateCodeID",
                table: "Order",
                column: "StateCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequest_ContractorID",
                table: "OrderRequest",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequest_OrderID",
                table: "OrderRequest",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ContractorID",
                table: "Payment",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentProviderSettingID",
                table: "Payment",
                column: "PaymentProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentProviderSetting_PaymentProviderID",
                table: "PaymentProviderSetting",
                column: "PaymentProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_PermissionGroupID",
                table: "Permission",
                column: "PermissionGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_DocumentID",
                table: "Post",
                column: "DocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserID",
                table: "Post",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_CategoryID",
                table: "PostCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategory_PostID",
                table: "PostCategory",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_CommentID",
                table: "PostComment",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostID",
                table: "PostComment",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_PostID",
                table: "PostTag",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagID",
                table: "PostTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateDiscount_ContractorID",
                table: "PrivateDiscount",
                column: "ContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateDiscount_TypeCodeID",
                table: "PrivateDiscount",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_PublicDiscount_TypeCodeID",
                table: "PublicDiscount",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_RolePermission_RP_PermissionID",
                table: "RolePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_RolePermission_RP_RoleID",
                table: "RolePermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSProviderSetting_SMSProviderID",
                table: "SMSProviderSetting",
                column: "SMSProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSProviderNumber_SPN_SPCID",
                table: "SMSProviderSettingNumber",
                column: "SMSProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSResponse_SMS_STID",
                table: "SMSResponse",
                column: "SMSTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSResponse_UserID",
                table: "SMSResponse",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSTemplate_ST_SSID",
                table: "SMSTemplate",
                column: "SMSProviderSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestion_UserID",
                table: "Suggestion",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Token_RoleCodeID",
                table: "Token",
                column: "RoleCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Token_UserID",
                table: "Token",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TypeCodeID",
                table: "Transaction",
                column: "TypeCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_GenderCodeID",
                table: "User",
                column: "GenderCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfileDocumentID",
                table: "User",
                column: "ProfileDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserPermission_UP_PermissionID",
                table: "UserPermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_UserID",
                table: "UserPermission",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "CategoryTag");

            migrationBuilder.DropTable(
                name: "ChatMessage");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "ContractorCategory");

            migrationBuilder.DropTable(
                name: "ContractorDiscount");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PostCategory");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "PrivateDiscount");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "SMSProviderSettingNumber");

            migrationBuilder.DropTable(
                name: "SMSResponse");

            migrationBuilder.DropTable(
                name: "Suggestion");

            migrationBuilder.DropTable(
                name: "Token");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "UserPermission");

            migrationBuilder.DropTable(
                name: "OrderRequest");

            migrationBuilder.DropTable(
                name: "PublicDiscount");

            migrationBuilder.DropTable(
                name: "PaymentProviderSetting");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "SMSTemplate");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PaymentProvider");

            migrationBuilder.DropTable(
                name: "SMSProviderSetting");

            migrationBuilder.DropTable(
                name: "PermissionGroup");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "SMSProvider");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Code");

            migrationBuilder.DropTable(
                name: "CodeGroup");
        }
    }
}
