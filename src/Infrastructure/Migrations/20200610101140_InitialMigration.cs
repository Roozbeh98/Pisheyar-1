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
                    Name = table.Column<string>(maxLength: 128, nullable: false)
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
                name: "SMSProviderConfiguration",
                columns: table => new
                {
                    SMSProviderConfigurationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderConfigurationGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    Username = table.Column<string>(maxLength: 128, nullable: false),
                    Password = table.Column<string>(maxLength: 128, nullable: false),
                    APIKey = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderConfiguration", x => x.SMSProviderConfigurationID);
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
                    Name = table.Column<string>(maxLength: 128, nullable: false)
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
                name: "SMSProviderNumber",
                columns: table => new
                {
                    SMSProviderNumberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSProviderNumberGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderConfigurationID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSProviderNumber", x => x.SMSProviderNumberID);
                    table.ForeignKey(
                        name: "FK_SMSProviderNumber_SMSProviderConfiguration",
                        column: x => x.SMSProviderConfigurationID,
                        principalTable: "SMSProviderConfiguration",
                        principalColumn: "SMSProviderConfigurationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SMSSetting",
                columns: table => new
                {
                    SMSSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSSettingGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSProviderConfigurationID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSSetting", x => x.SMSSettingID);
                    table.ForeignKey(
                        name: "FK_SMSSetting_SMSProviderConfiguration",
                        column: x => x.SMSProviderConfigurationID,
                        principalTable: "SMSProviderConfiguration",
                        principalColumn: "SMSProviderConfigurationID",
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
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false)
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
                name: "SMSTemplate",
                columns: table => new
                {
                    SMSTemplateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMSTemplateGUID = table.Column<Guid>(type: "UNIQUEIDENTIFIER ROWGUIDCOL", nullable: false, defaultValueSql: "(newid())"),
                    SMSSettingID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false, defaultValueSql: "((0))"),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSTemplate", x => x.SMSTemplateID);
                    table.ForeignKey(
                        name: "FK_SMSTemplate_SMSSetting",
                        column: x => x.SMSSettingID,
                        principalTable: "SMSSetting",
                        principalColumn: "SMSSettingID",
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
                    { 1, null, null, new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), null, null, "سایت اصلی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(5865), null, null, 1 },
                    { 2, null, null, new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), null, null, "وبلاگ", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7390), null, null, 2 }
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
                    { 19, "اصفهان", new Guid("19abcdc6-6378-4026-8fe7-530bb25d0922") },
                    { 20, "ايلام", new Guid("ed974d78-18d2-44fd-9d9c-2f677d1a9646") },
                    { 21, "تهران", new Guid("52499ea2-eef5-4e3b-a5e4-d1501853ed60") },
                    { 22, "آذربايجان شرقي", new Guid("b7d61ff2-91bc-4eaa-b491-7ef47c751b83") },
                    { 23, "فارس", new Guid("dcc2183e-d4f8-43b6-b1da-5408830e7e64") },
                    { 24, "کرمانشاه", new Guid("06ac121a-ef04-4b61-9790-d97cd1804a81") },
                    { 28, "همدان", new Guid("fa5df7ff-5ba6-4cec-a487-32c2a10a8de1") },
                    { 26, "مرکزي", new Guid("78af6eb8-3a57-4d02-946b-4123e76418ba") },
                    { 27, "گيلان", new Guid("dd24ff84-3a81-4a24-9766-e30aa96c24e3") },
                    { 18, "اردبيل", new Guid("b6599359-8bca-49d9-890c-090641d2c20d") },
                    { 29, "کرمان", new Guid("b0b62257-1c92-46a3-9bff-4b15bead714b") },
                    { 30, "سمنان", new Guid("81c11d03-3bba-4f86-8cf3-3e24b8616b5d") },
                    { 31, "کهگيلويه و بويراحمد", new Guid("e86b600a-3fc3-4402-8c4e-734b733eb5e3") },
                    { 25, "هرمزگان", new Guid("1c15a27e-290d-40b9-9713-094bd8028a12") },
                    { 17, "لرستان", new Guid("9efa8c0f-3663-4bea-aec7-aaf870209e7f") },
                    { 14, "گلستان", new Guid("44820ab0-8614-4482-a902-8c8e3fd04ba1") },
                    { 15, "مازندران", new Guid("0ea21f2a-35c8-4176-878d-fbf43d7ea082") },
                    { 1, "يزد", new Guid("7ca94235-0322-439d-ba3c-c24118fc6095") },
                    { 2, "چهار محال و بختياري", new Guid("3f458316-b381-480d-8af7-bc17c7a7a26e") },
                    { 3, "خراسان شمالي", new Guid("ea1c16a0-bbde-4ee4-8de2-b46916abdf5f") },
                    { 4, "البرز", new Guid("f60853d0-00de-4b23-95e0-7a86a6b19b09") },
                    { 5, "قم", new Guid("ab020b57-ebf0-4106-a015-c5d1839dfa65") },
                    { 16, "قزوين", new Guid("1771d8dc-84f7-4191-9db2-7b075dcf4a6e") },
                    { 7, "آذربايجان غربي", new Guid("69b2df50-1df5-452e-b07b-3f77101a43d8") },
                    { 6, "کردستان", new Guid("2e17f2ba-755e-4a73-9a1d-89ca21120fa7") },
                    { 9, "سيستان و بلوچستان", new Guid("9a68d6df-c72e-4b70-991c-7a266d52786d") },
                    { 10, "خراسان جنوبي", new Guid("ad69fd23-f6d8-4a9a-b6ae-6d25f52345f8") },
                    { 11, "خوزستان", new Guid("deef82c0-6e0e-4ad6-8217-bc5d7512a3d6") },
                    { 12, "بوشهر", new Guid("0a5cf507-a0a9-4f88-b3b2-8608da4d3a93") },
                    { 13, "زنجان", new Guid("d3452410-4a59-473d-8ad1-8c6d15aa50f3") },
                    { 8, "خراسان رضوي", new Guid("11d4ed84-4b4f-45e4-aecf-59d859fdb683") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "DisplayName", "ModifiedDate", "Name", "RoleGUID" },
                values: new object[,]
                {
                    { 3, "سرویس گیرنده", new DateTime(2020, 6, 10, 14, 41, 38, 247, DateTimeKind.Local).AddTicks(937), "Client", new Guid("5f14dac2-5f28-4841-9688-7733d1d1d3ec") },
                    { 1, "ادمین", new DateTime(2020, 6, 10, 14, 41, 38, 246, DateTimeKind.Local).AddTicks(9878), "Admin", new Guid("51c85bfd-5b01-4373-a0c6-04bfa2323f62") },
                    { 2, "سرویس دهنده", new DateTime(2020, 6, 10, 14, 41, 38, 247, DateTimeKind.Local).AddTicks(906), "Contractor", new Guid("c1c40b38-a2c6-457e-a2e9-1775dd573368") }
                });

            migrationBuilder.InsertData(
                table: "SMSProviderConfiguration",
                columns: new[] { "SMSProviderConfigurationID", "APIKey", "ModifiedDate", "Password", "SMSProviderConfigurationGUID", "Username" },
                values: new object[] { 1, "61726634455053586E44464E413462574A76535677436B547236574B56386D6A6F6E4F326A374A4C7755773D", new DateTime(2020, 6, 10, 14, 41, 38, 242, DateTimeKind.Local).AddTicks(1161), "ptcoptco", new Guid("8749b863-62de-4d86-95a8-dc7a88638f48"), "ptmgroupco@gmail.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 3, null, null, new Guid("6b9a83c1-8807-4505-be10-a9f2af1c6e5f"), null, null, "خانه", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7444), 1, null, 1 },
                    { 4, null, null, new Guid("90131911-2ab8-440b-ad99-5a252b0a0d05"), null, null, "حمل و نقل", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7455), 1, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 826, new Guid("5c13f036-fee2-4588-8979-eb2d03cd0484"), "ليلان", 22 },
                    { 825, new Guid("0eb5a820-6bb3-487f-8b43-b4548c7fa0f4"), "قره آغاج", 22 },
                    { 824, new Guid("53a47b89-9732-45b3-818b-1c416a27c4ec"), "عجب شير", 22 },
                    { 823, new Guid("e70531b6-b164-498e-b6df-e9e35e70408b"), "صوفيان", 22 },
                    { 822, new Guid("2c97a336-3c54-47d9-8232-69c8c633ef69"), "شهر جديد سهند", 22 },
                    { 821, new Guid("7433f02e-d184-4bb9-b61e-810c135ee444"), "شند آباد", 22 },
                    { 820, new Guid("3a8c4f42-0c64-4aad-b524-8cb2ae7c7b93"), "شرفخانه", 22 },
                    { 819, new Guid("5085c31e-0d21-40d6-aaf2-e7046feb95d9"), "شربيان", 22 },
                    { 818, new Guid("f76d7a2b-ed93-4ae6-a847-e7d8d25ab832"), "شبستر", 22 },
                    { 817, new Guid("62c318fa-1c8a-49da-ba25-0cf27b97382e"), "سيه رود", 22 },
                    { 816, new Guid("3bc5ae76-5c3f-493d-a520-18c77800a589"), "سيس", 22 },
                    { 815, new Guid("b5fbe937-ac4f-44bd-84fc-ac8703a174f3"), "سردرود", 22 },
                    { 814, new Guid("d6746d2b-46b3-4a1e-a696-0026448e0b8f"), "سراب", 22 },
                    { 813, new Guid("8ac3de05-95a8-47ab-8611-d77630333db6"), "زنوز", 22 },
                    { 812, new Guid("a59fecfa-cd27-4010-aa59-08677d064ed8"), "زرنق", 22 },
                    { 827, new Guid("48622817-3ac8-41a6-b3b5-d1c1fa80ea7a"), "مبارک شهر", 22 },
                    { 828, new Guid("8869995d-6420-43fd-aed9-3d4cdbaf2e6d"), "مراغه", 22 },
                    { 829, new Guid("8d706dc6-ff58-4b95-8d3c-9ddca85dc27e"), "مرند", 22 },
                    { 830, new Guid("b3410ae4-16b5-4d3b-bcd1-95cc2a491d5f"), "ملکان", 22 },
                    { 846, new Guid("bcfbfc3a-2660-4ae8-9e82-ed8de4f4a400"), "گوگان", 22 },
                    { 845, new Guid("1904d866-1b41-44c1-b299-627cdadad3f2"), "کوزه کنان", 22 },
                    { 844, new Guid("ce270d4d-3d1c-466d-975b-bb94ece6db98"), "کليبر", 22 },
                    { 843, new Guid("556ffb3c-035a-420a-af21-e23eb39641c0"), "کلوانق", 22 },
                    { 842, new Guid("def41a72-7c54-485e-88d1-494d15a71fd2"), "کشکسراي", 22 },
                    { 841, new Guid("ddd14353-8bfe-4f8b-ad6b-323b9ee68da9"), "يامچي", 22 },
                    { 840, new Guid("402dc6f6-2b48-4970-b5c1-eafcf4631a6d"), "ورزقان", 22 },
                    { 811, new Guid("7be5f6a4-b33f-425c-b910-cba840b9ce51"), "دوزدوزان", 22 },
                    { 839, new Guid("9a08a3c3-c511-4847-bd7e-9c52eec970e8"), "وايقان", 22 },
                    { 837, new Guid("01941bdb-4b8e-4215-a5f9-c8252fc2195f"), "هشترود", 22 },
                    { 836, new Guid("9ae8cf49-ac1e-4d29-917d-30e802fd15ed"), "هريس", 22 },
                    { 835, new Guid("966d2e38-942b-4c0c-bf7e-6c2dd8881c9f"), "هاديشهر", 22 },
                    { 834, new Guid("29b8e51f-8e4a-4d27-822c-e51eeb314f3e"), "نظرکهريزي", 22 },
                    { 833, new Guid("b18e52c0-72f3-41f4-88de-441535d3ca0c"), "ميانه", 22 },
                    { 832, new Guid("4122b46e-5a44-4864-ba85-3931f1f90bd4"), "مهربان", 22 },
                    { 831, new Guid("e80c1eb6-49dd-4881-ae58-245a56ffc08b"), "ممقان", 22 },
                    { 838, new Guid("13fefa00-26e3-4491-ad89-46a0bd431885"), "هوراند", 22 },
                    { 810, new Guid("1ad62dce-77e4-4972-9343-b43b4d4f7f72"), "خواجه", 22 },
                    { 809, new Guid("8d3de269-15ab-4683-907f-9bf6bd3af52e"), "خمارلو", 22 },
                    { 808, new Guid("ba16ada3-8bc4-40ff-879e-e362cfbec9e4"), "خسروشاه", 22 },
                    { 787, new Guid("8bdc088c-9e6a-4057-8593-3fd6829f6cbf"), "آقکند", 22 },
                    { 786, new Guid("7ff61648-f996-40b2-bd50-2228b2c5e2a0"), "آذرشهر", 22 },
                    { 785, new Guid("b1c66ca6-5cbf-46be-b57d-058a6369116a"), "آبش احمد", 22 },
                    { 784, new Guid("5679108a-92dd-4d1c-9634-c01d7acf84cc"), "گلستان", 21 },
                    { 783, new Guid("1164a3a2-b221-426f-be27-34b496f3d25b"), "کيلان", 21 },
                    { 782, new Guid("a7afaa12-4340-4964-9fcb-0f46bd86215b"), "کهريزک", 21 },
                    { 781, new Guid("6916a6a1-cbeb-48f6-a3ca-b37af9d07747"), "چهاردانگه", 21 },
                    { 780, new Guid("7feaefc6-ffe9-4419-a190-9200c4865ea4"), "پيشوا", 21 },
                    { 779, new Guid("47655427-523c-4ebc-ae15-c363dc65015f"), "پرديس", 21 },
                    { 778, new Guid("bd8c276c-134f-491c-88cb-20667c6a4a98"), "پاکدشت", 21 },
                    { 777, new Guid("bde473de-d3d4-445b-bca3-b4fabec722db"), "ورامين", 21 },
                    { 776, new Guid("98cb6bd6-f59d-441e-a177-57305e97bc4d"), "وحيديه", 21 },
                    { 775, new Guid("c0b40434-86ba-44af-9d56-4c0de110aecb"), "نصيرشهر", 21 },
                    { 774, new Guid("179894be-78ee-41e3-bff5-7e40fa5ad0a2"), "نسيم شهر", 21 },
                    { 773, new Guid("eecd7fd9-f11a-41ee-9c01-08428a82e189"), "ملارد", 21 },
                    { 788, new Guid("bacc4222-a8ef-4869-be4f-44b449020293"), "آچاچي", 22 },
                    { 789, new Guid("ab9fd010-4f6b-4639-a1a6-6e016a5e186c"), "اسکو", 22 },
                    { 790, new Guid("c07f7c3f-a44e-4109-9f71-eaba4f778441"), "اهر", 22 },
                    { 791, new Guid("a0fabf74-5ed5-4e26-bc92-f0856c85ee4f"), "ايلخچي", 22 },
                    { 807, new Guid("26a76eba-9636-49f2-8c5f-b37b18036aa9"), "خداجو", 22 },
                    { 806, new Guid("cec62aa4-4746-447d-97c2-56a7d58471d6"), "خامنه", 22 },
                    { 805, new Guid("007593d1-0fa2-4732-a3fa-d7d035d0b2fa"), "خاروانا", 22 },
                    { 804, new Guid("2270ac7e-7bfc-4437-b433-6a3ce98b3ae7"), "جوان قلعه", 22 },
                    { 803, new Guid("9281921f-07c6-460d-a49a-ea3b0b7dd7ac"), "جلفا", 22 },
                    { 802, new Guid("2f004cd1-c629-409d-807d-7ffbe3d426b3"), "تيکمه داش", 22 },
                    { 801, new Guid("aaa70642-49fd-4baf-96ab-424ea3649720"), "تيمورلو", 22 },
                    { 847, new Guid("3bf463ff-c352-40e1-a2a2-079416e1e8e1"), "آباده", 23 },
                    { 800, new Guid("09128619-5bbb-482f-8f2d-0d561444aeba"), "تسوج", 22 },
                    { 798, new Guid("61b894df-2cb7-4089-875f-b1359e318934"), "ترک", 22 },
                    { 797, new Guid("19857670-8aa4-490e-a3ba-ec629c532472"), "تبريز", 22 },
                    { 796, new Guid("ac91d24b-6d5e-4ac3-97f2-306158bb1025"), "بناب مرند", 22 },
                    { 795, new Guid("80b849c0-bc0b-46a7-8049-6640dadf6a28"), "بناب", 22 },
                    { 794, new Guid("e0ee0dd9-74d9-4db0-8bbc-91747beb31c7"), "بستان آباد", 22 },
                    { 793, new Guid("e0b9e929-a042-4a1f-ae50-0435f3f20a35"), "بخشايش", 22 },
                    { 792, new Guid("1d5fd13f-f268-470d-a16e-f973fdb12db5"), "باسمنج", 22 },
                    { 799, new Guid("bfc63a02-aa2d-457d-bf9a-3828eada230a"), "ترکمانچاي", 22 },
                    { 848, new Guid("7980ce7d-6b1e-411c-a5a1-2f6f4e804257"), "آباده طشک", 23 },
                    { 849, new Guid("c7c9a05f-c2d0-4016-8070-78ef2543a1b2"), "اردکان", 23 },
                    { 850, new Guid("66cdb60c-c3b3-4266-a710-82709bf01fa2"), "ارسنجان", 23 },
                    { 905, new Guid("afea53e1-284f-48e8-8995-5c3d1f0ca06b"), "صغاد", 23 },
                    { 904, new Guid("fbb62462-92de-45c7-b33a-90cca9d58c4b"), "شيراز", 23 },
                    { 903, new Guid("fefed4df-e513-45f5-9a4e-4c0699b518cd"), "شهر پير", 23 },
                    { 902, new Guid("1e30897f-092e-49de-9927-1fafa41e959a"), "شهر جديد صدرا", 23 },
                    { 901, new Guid("190edb8d-40c0-442d-9ef6-a7a6332dff50"), "ششده", 23 },
                    { 900, new Guid("75d955f1-7e18-4b00-b717-6a083d90f1fc"), "سيدان", 23 },
                    { 899, new Guid("b17eae9f-f046-40f8-bd0c-35f24fe6ed11"), "سورمق", 23 },
                    { 898, new Guid("3220d875-cb3c-4849-b67e-15b7ea46ca25"), "سلطان شهر", 23 },
                    { 897, new Guid("41391623-16c3-4156-823f-38ab140d8cba"), "سعادت شهر", 23 },
                    { 896, new Guid("ff074044-9e5a-4cb2-ae03-0185566e1a83"), "سروستان", 23 },
                    { 895, new Guid("b62b8c98-b704-4eb2-8baa-ed46b0c13c46"), "سده", 23 },
                    { 894, new Guid("e614422d-c516-4e62-b560-7b567ce7d3d3"), "زرقان", 23 },
                    { 893, new Guid("056f3aed-7638-4044-8520-e57935d02c8f"), "زاهد شهر", 23 },
                    { 892, new Guid("b00b4886-d2f3-487a-a25e-6ec51f9eca82"), "رونيز", 23 },
                    { 891, new Guid("c019ba2b-0438-43cc-bf65-1c9626d22f68"), "رامجرد", 23 },
                    { 906, new Guid("0d103643-740c-4303-a242-8d642a9355ee"), "صفا شهر", 23 },
                    { 907, new Guid("8ef77f25-393f-416c-a0cc-112fab968d41"), "علامرودشت", 23 },
                    { 908, new Guid("475c785f-4dd0-49fc-92a0-8b219d44c0d9"), "عماد ده", 23 },
                    { 909, new Guid("0d898d7f-97c0-4888-a9c9-3a3f9c947b10"), "فدامي", 23 },
                    { 925, new Guid("6d2ca1f2-31f2-4dfa-ad61-34559861e4da"), "مرودشت", 23 },
                    { 924, new Guid("7ac02971-7c49-48ab-84fd-7945f03b242b"), "مبارک آباد", 23 },
                    { 923, new Guid("335cbc59-e873-4b01-a2e2-dafb7af10685"), "مادرسليمان", 23 },
                    { 922, new Guid("24ed79ee-1739-4951-bd3c-5dc6d87eba7b"), "لپوئي", 23 },
                    { 921, new Guid("6fd76dcb-6bea-4d67-864e-117f72ab13e7"), "لطيفي", 23 },
                    { 920, new Guid("3120c048-5220-406e-92ca-d636f2817f0a"), "لامرد", 23 },
                    { 919, new Guid("f787a745-4f0a-45e8-aa62-338b0f5225a4"), "لار", 23 },
                    { 890, new Guid("e1c03f97-54a1-49d1-a496-df2e3ebfb4f4"), "دژکرد", 23 },
                    { 918, new Guid("a3430b16-869a-4acb-a7f4-c81052108b12"), "قير", 23 },
                    { 916, new Guid("ff0e6bef-4689-4754-bc27-f0f467e90508"), "قطب آباد", 23 },
                    { 915, new Guid("82728763-aac3-497f-80b2-6d45a9e39fe8"), "قره بلاغ", 23 },
                    { 914, new Guid("abd950a8-c4cc-41cb-9ad7-369d6336bdcd"), "قادرآباد", 23 },
                    { 913, new Guid("f8267871-b718-499a-b6c9-b7e179776cb5"), "قائميه", 23 },
                    { 912, new Guid("e2e95f03-1444-45a6-9ced-9c1a89dac4f4"), "فيروزآباد", 23 },
                    { 911, new Guid("a00f06ae-f5c2-489d-a03b-f66973124833"), "فسا", 23 },
                    { 910, new Guid("85007e84-8c03-4ca8-855c-ed514192944e"), "فراشبند", 23 },
                    { 917, new Guid("c0168aea-339b-4375-b4d8-b6169d2a51a3"), "قطرويه", 23 },
                    { 889, new Guid("b6eefe18-0d14-42f0-9b39-b4d7fb6444d6"), "دوزه", 23 },
                    { 888, new Guid("8bc5e9ad-cccc-4ea5-98f9-4ccf75acccab"), "دوبرجي", 23 },
                    { 887, new Guid("07d6666d-b234-4cbf-8d1a-06361b430dc6"), "دهرم", 23 },
                    { 866, new Guid("cfcb04fe-60bd-4a9a-86f5-183d89d31259"), "بوانات", 23 },
                    { 865, new Guid("564699fe-b37b-49cc-bbaf-b8ff9f7b6c20"), "بهمن", 23 },
                    { 864, new Guid("9cc05182-bff2-4a65-945d-18762da208e9"), "بنارويه", 23 },
                    { 863, new Guid("da963d94-dd2c-4963-8165-8880543a580d"), "بالاده", 23 },
                    { 862, new Guid("ded87adc-04fe-4dbf-88d3-fc9a1fc42461"), "بابامنير", 23 },
                    { 861, new Guid("628c64a5-3e6b-4f0a-aff5-8ffd2128b84a"), "باب انار", 23 },
                    { 860, new Guid("7a6ee5c2-342c-4f95-bf39-45c9cd32687a"), "ايزد خواست", 23 },
                    { 867, new Guid("bebfe04a-9860-4c65-a0a5-ba613c8dbeca"), "بيرم", 23 },
                    { 859, new Guid("4b47fbed-53c8-4d1d-addd-db07d2471916"), "ايج", 23 },
                    { 857, new Guid("cddd854d-ebd6-4b66-8e23-de09b6b12802"), "اهل", 23 },
                    { 856, new Guid("7b50d453-dc1b-4a8f-80f6-c2dbd8ada263"), "امام شهر", 23 },
                    { 855, new Guid("a717f374-a38b-4021-838d-82d4672e7ddf"), "اقليد", 23 },
                    { 854, new Guid("27bf295b-1f3e-43c0-8b9a-edac0bbcb3ab"), "افزر", 23 },
                    { 853, new Guid("8aa6e31d-e53f-4c56-8f51-54f3d6a05498"), "اشکنان", 23 },
                    { 852, new Guid("d9b44af6-76ca-43ae-b2a8-d2f9b94beb5a"), "اسير", 23 },
                    { 851, new Guid("fb276aa8-15da-476b-b14e-045e1c6fea14"), "استهبان", 23 },
                    { 858, new Guid("e5cda992-552a-4686-bce7-e0b840f84396"), "اوز", 23 },
                    { 772, new Guid("a3d4a1ee-2cfe-4b86-97bb-8df83eca37aa"), "لواسان", 21 },
                    { 868, new Guid("499115b6-78c7-4f85-a22d-51d2c292f0d2"), "بيضا", 23 },
                    { 870, new Guid("8c358f13-683d-4aa3-b1eb-c8b20fca38fd"), "جهرم", 23 },
                    { 886, new Guid("e3b14e8b-aacd-4fae-9115-9de2b2304f37"), "دبيران", 23 },
                    { 885, new Guid("afa5c073-881e-4a01-b904-824d2ad2e13e"), "داريان", 23 },
                    { 884, new Guid("b15e5fef-ddc6-4efc-81a4-9a3c73a7ac84"), "داراب", 23 },
                    { 883, new Guid("0509fba9-9a68-4f49-9aee-697091c7d207"), "خومه زار", 23 },
                    { 882, new Guid("98740b0e-4389-46e3-869f-e14cab98e631"), "خوزي", 23 },
                    { 881, new Guid("22f7d710-6f64-4ad7-9b0a-4476041e74d7"), "خور", 23 },
                    { 880, new Guid("439110a1-5096-4f43-a004-3f2c05d0b788"), "خنج", 23 },
                    { 869, new Guid("33c49d9a-946c-4836-b583-a105a4334f22"), "جنت شهر", 23 },
                    { 879, new Guid("be93f5f7-82e2-41bc-8fc3-dca19a399056"), "خشت", 23 },
                    { 877, new Guid("e6bda13e-9fcc-407b-a9be-16c35b731f30"), "خاوران", 23 },
                    { 876, new Guid("80f750b5-38e3-49f9-b226-24f0c37d9c49"), "خانيمن", 23 },
                    { 875, new Guid("1d5c2915-5077-40f0-bc4f-1738e56a0938"), "خانه زنيان", 23 },
                    { 874, new Guid("b6505104-859a-4405-9f4b-7e83b8aa0b41"), "حسن آباد", 23 },
                    { 873, new Guid("874be741-8fe4-4a50-b27a-b2af8974fe08"), "حسامي", 23 },
                    { 872, new Guid("85ecec7e-d284-46f0-bb1e-2500d052b143"), "حاجي آباد", 23 },
                    { 871, new Guid("f7f7c913-0b99-43c1-982b-881cf35be8a2"), "جويم", 23 },
                    { 878, new Guid("c8cfc7e1-e5c3-42c1-abbe-bf295ec3a663"), "خرامه", 23 },
                    { 771, new Guid("2caa4370-d20c-4504-933f-3d465720f9cc"), "قرچک", 21 },
                    { 770, new Guid("cb2d22f9-e6e0-4eb4-8721-30dbbe06ad52"), "قدس", 21 },
                    { 769, new Guid("7fdfa8d9-0664-459b-bf1e-32656bb7004a"), "فيروزکوه", 21 },
                    { 669, new Guid("406999f6-ff4d-466e-9f26-e45cc9c308ab"), "عسگران", 19 },
                    { 668, new Guid("b3235d60-5f59-4863-a8d5-31116cc2eb16"), "طرق رود", 19 },
                    { 667, new Guid("b9f0037f-6ff8-4ba4-a505-48b253f3d1bb"), "طالخونچه", 19 },
                    { 666, new Guid("7ea66b81-a5f1-4e69-967c-d54b4996b19f"), "شهرضا", 19 },
                    { 665, new Guid("a0e0156c-b944-463d-877b-e9126bfcab9d"), "شاپورآباد", 19 },
                    { 664, new Guid("aea4358d-eea1-417c-8636-26384b32f2a3"), "شاهين شهر", 19 },
                    { 663, new Guid("5bdebe3f-b961-49a0-b38b-2e269b2e0918"), "سگزي", 19 },
                    { 662, new Guid("c8d06581-d262-4bfc-937a-02bb43f072a7"), "سين", 19 },
                    { 661, new Guid("9093744d-c76e-4deb-a998-3e8a637ee3d3"), "سميرم", 19 },
                    { 660, new Guid("5107eb7e-0692-4c54-9d45-3b93b30d474b"), "سفيد شهر", 19 },
                    { 659, new Guid("c859f419-c6ea-46bf-9045-8a81324e54f1"), "سده لنجان", 19 },
                    { 658, new Guid("9f37e24b-7d09-48bd-ab4e-b9daf7a7aafe"), "زيباشهر", 19 },
                    { 657, new Guid("da11d016-981e-4c31-a16d-48dc0d2815a2"), "زيار", 19 },
                    { 656, new Guid("c4ea7577-1059-4ca8-bd46-3ef6e49fc3cb"), "زواره", 19 },
                    { 655, new Guid("2f7fac07-8911-41ca-8528-8e5cb9edcd53"), "زرين شهر", 19 },
                    { 670, new Guid("f6653079-329f-459a-8a10-7b725a96b067"), "علويچه", 19 },
                    { 671, new Guid("2b498f6c-95f4-495b-aa8f-c3ed54ef74d7"), "فرخي", 19 },
                    { 672, new Guid("31acc9a9-0b46-403f-9fec-6b6055af0031"), "فريدونشهر", 19 },
                    { 673, new Guid("52e2ab07-6027-417c-87df-7e97517955c0"), "فلاورجان", 19 },
                    { 689, new Guid("f21702a6-4b2c-4bb2-91a9-bd9fd247dbb7"), "نوش آباد", 19 },
                    { 688, new Guid("61d6ee9b-57eb-4ab5-8239-e90461049c0d"), "نطنز", 19 },
                    { 687, new Guid("dd95b513-495c-4c42-9404-1b2990583368"), "نصرآباد", 19 },
                    { 686, new Guid("1f20be7c-d572-45a2-889f-0e8c251b0768"), "نجف آباد", 19 },
                    { 685, new Guid("557d6460-a21d-47c2-b5af-bfadccb2f4c9"), "نائين", 19 },
                    { 684, new Guid("809163c6-fb2d-432f-a8c5-262238bf6fea"), "ميمه", 19 },
                    { 683, new Guid("436bbdb6-3473-4633-9307-76fd6e06a85f"), "مهاباد", 19 },
                    { 654, new Guid("14dce371-5f18-47cc-9af8-69ab75ec649f"), "زاينده رود", 19 },
                    { 682, new Guid("b6889bce-bcb1-4720-aec4-175734a35d5d"), "منظريه", 19 },
                    { 680, new Guid("b213ba77-92be-430e-baeb-8040f2a51ce1"), "محمد آباد", 19 },
                    { 679, new Guid("08b79104-1586-4a76-ac9b-6eba48fe815d"), "مبارکه", 19 },
                    { 678, new Guid("63fb7865-e92a-4603-960b-f255749ce149"), "لاي بيد", 19 },
                    { 677, new Guid("7bd87f50-ba87-40f4-8252-fd0621861135"), "قهدريجان", 19 },
                    { 676, new Guid("534e4630-5622-49d9-a3ad-9ba441b6a9a0"), "قهجاورستان", 19 },
                    { 675, new Guid("0da17f04-4dbf-4eec-84d6-d953ae098f30"), "قمصر", 19 },
                    { 674, new Guid("d7c6bdfa-0201-44a3-a513-290ec3be7904"), "فولاد شهر", 19 },
                    { 681, new Guid("d4b94b27-fe8f-4caa-b4c8-753a491f3e84"), "مشکات", 19 },
                    { 653, new Guid("d0324183-a1ce-437c-872d-8729b447717c"), "زازران", 19 },
                    { 652, new Guid("20769467-1eb3-46f3-b1e2-136255e2d164"), "رضوانشهر", 19 },
                    { 651, new Guid("1c2b9e2b-2d55-406b-989c-4c3289bd0468"), "رزوه", 19 },
                    { 630, new Guid("1260229c-78d0-4bce-895c-550423dc8134"), "تودشک", 19 },
                    { 629, new Guid("634b952c-484e-41dd-9ed6-18d24ec545b7"), "بوئين مياندشت", 19 },
                    { 628, new Guid("a4e6ef87-22c7-49fd-b77c-7d48f43bd232"), "بهارستان", 19 },
                    { 627, new Guid("e6d89421-d3ed-4436-98e4-51d97a60acfe"), "بهاران شهر", 19 },
                    { 626, new Guid("e41e9d1d-88d4-43d5-89f6-b15eaf263192"), "برف انبار", 19 },
                    { 625, new Guid("bd63b772-1ff3-4fde-b0b2-7fb79479e24e"), "برزک", 19 },
                    { 624, new Guid("574c87c2-ad30-46fd-8173-5e5622dbae93"), "بافران", 19 },
                    { 631, new Guid("f4cf764b-5c33-47ec-b8ed-1d7f0d8612ba"), "تيران", 19 },
                    { 623, new Guid("b217dbb2-5767-469d-86a0-f7f4655dca73"), "باغشاد", 19 },
                    { 621, new Guid("faa5e6ac-876c-4414-a427-d9dc39233a97"), "بادرود", 19 },
                    { 620, new Guid("9aaa8a1d-08cd-40bf-87dd-03872a037740"), "اژيه", 19 },
                    { 619, new Guid("ac3d9702-2173-4e96-82d3-e10f4cd62c8d"), "ايمانشهر", 19 },
                    { 618, new Guid("49cb0d36-2455-4682-bdde-9f5c40085542"), "انارک", 19 },
                    { 617, new Guid("9c74ede7-7957-4a63-8429-f17eefc3b5fc"), "افوس", 19 },
                    { 616, new Guid("a7c6552f-12c9-49e1-8fb0-96491247dff1"), "اصفهان", 19 },
                    { 615, new Guid("c47356aa-16ff-4fbe-8408-99531f536d42"), "اصغرآباد", 19 },
                    { 622, new Guid("be2da753-09db-4e01-adf2-870b424822f8"), "باغ بهادران", 19 },
                    { 690, new Guid("df24c32c-93d9-4f76-9438-a507ccfc63d2"), "نياسر", 19 },
                    { 632, new Guid("2c7aee8a-7e8a-4abc-97ba-2b797c4fbe88"), "جندق", 19 },
                    { 634, new Guid("a66212bc-39a8-48de-83dc-7c7f3659903b"), "جوشقان قالي", 19 },
                    { 650, new Guid("52e5f39a-19de-4c3d-85cf-6459c3c3e554"), "ديزيچه", 19 },
                    { 649, new Guid("64ea511d-ae1a-4a9c-b9f7-56ab9469ea5f"), "دولت آباد", 19 },
                    { 648, new Guid("16250e91-ab28-4464-98b8-3d752f001ef0"), "دهق", 19 },
                    { 647, new Guid("55afd4f1-eb3d-4d62-ac89-0f2cd41b8412"), "دهاقان", 19 },
                    { 646, new Guid("fff979e6-c29c-494e-ba8c-3ae812f325b4"), "دستگرد", 19 },
                    { 645, new Guid("fab46c68-56ac-4faa-8db7-ef8359a733f2"), "درچه پياز", 19 },
                    { 644, new Guid("0a724db4-716a-4d73-8799-af942bba01de"), "دامنه", 19 },
                    { 633, new Guid("f961c36b-cba2-4d4b-9ee8-f34e78f5503c"), "جوزدان", 19 },
                    { 643, new Guid("a2bb6d3a-e67b-483a-aa93-2a485fcfd504"), "داران", 19 },
                    { 641, new Guid("2989dd6b-f4c7-4279-8fc4-103250d5319d"), "خور", 19 },
                    { 640, new Guid("9ab8b86e-64bb-4a8b-be68-270a200974fc"), "خوانسار", 19 },
                    { 639, new Guid("167aae7f-7aec-4c57-a1b2-1178f9bb40c4"), "خميني شهر", 19 },
                    { 638, new Guid("3f586b36-0612-4231-8b79-dfb235342019"), "خالد آباد", 19 },
                    { 637, new Guid("64f5d4b2-cc3f-4a14-b66b-02263a0caaa5"), "حنا", 19 },
                    { 636, new Guid("3925e687-9f8c-4f44-b642-1f9a6bf90971"), "حسن آباد", 19 },
                    { 635, new Guid("a731c93b-2b3a-4c07-af27-56e827d79746"), "حبيب آباد", 19 },
                    { 642, new Guid("44b07f89-b5c3-4c5e-9bf9-34b256c135ff"), "خورزوق", 19 },
                    { 926, new Guid("fb1c6932-1ef5-4869-872c-203adaf8a7c5"), "مزايجان", 23 },
                    { 691, new Guid("dec50358-4117-4c88-8a2b-7b609d4a5e48"), "نيک آباد", 19 },
                    { 693, new Guid("6af128d9-7222-44bd-9e02-c210c390bce6"), "ورزنه", 19 },
                    { 748, new Guid("558fba52-e4d5-429d-9800-ad3c2c1d91f8"), "باقرشهر", 21 },
                    { 747, new Guid("2df9f041-977a-4fb3-b334-de556e4a2754"), "باغستان", 21 },
                    { 746, new Guid("aae7a481-a3d4-4766-aa7e-41d6fa0bd45b"), "انديشه", 21 },
                    { 745, new Guid("4628ea63-e34b-41b8-8846-945fabf46df2"), "اسلامشهر", 21 },
                    { 744, new Guid("8b690684-e9b9-4565-b0c7-72fb476ffce8"), "ارجمند", 21 },
                    { 743, new Guid("ff77693d-49b7-4515-b4c8-29224ae2019c"), "آبعلي", 21 },
                    { 742, new Guid("41c1044f-03a0-4f84-90ad-86766b8122bc"), "آبسرد", 21 },
                    { 741, new Guid("5c446840-9024-47b7-b003-85b2097cb7b7"), "چوار", 20 },
                    { 740, new Guid("552fa9fd-c143-4d49-8dff-7a7c81bc0aef"), "پهله", 20 },
                    { 739, new Guid("61e1b931-fc8f-4444-a3bd-cb76cd008490"), "ميمه", 20 },
                    { 738, new Guid("22a1ce78-f1d8-4b13-b809-907bf82d9f9b"), "موسيان", 20 },
                    { 737, new Guid("b7986cf9-3c1d-4974-bc8a-d72ec68c07f4"), "مورموري", 20 },
                    { 736, new Guid("97bec43a-a04a-4a63-8600-344fba72d038"), "مهران", 20 },
                    { 735, new Guid("59ac2be5-e16f-4d69-9338-9936be81a4a1"), "مهر", 20 },
                    { 734, new Guid("663afb66-2eb5-4ff8-8fc1-9503d2a54d8c"), "ماژين", 20 },
                    { 749, new Guid("9bdf085d-143d-424b-9afd-e818fed7a896"), "بومهن", 21 },
                    { 750, new Guid("94268cb7-5259-44e8-afb3-46c24ec2ec7b"), "تجريش", 21 },
                    { 751, new Guid("979019d7-643b-4b0f-977c-47fed3cb4346"), "تهران", 21 },
                    { 752, new Guid("ef223704-07f3-46d8-be76-2c2ddf059c72"), "جواد آباد", 21 },
                    { 768, new Guid("d9ab3146-f7b2-4192-9aec-f777e1742dc1"), "فشم", 21 },
                    { 767, new Guid("eba5a06d-820b-457b-b638-94c4b6790538"), "فرون آباد", 21 },
                    { 766, new Guid("7e6209a4-2925-4d14-9eed-669eca512ffd"), "فردوسيه", 21 },
                    { 765, new Guid("e6d18133-ac8e-4730-b300-cb0f1ee6a80b"), "صفادشت", 21 },
                    { 764, new Guid("94446965-3a7f-4748-b970-27301642d4b9"), "صبا شهر", 21 },
                    { 763, new Guid("3846da04-621e-41ae-94e1-6e77c018e20e"), "صالحيه", 21 },
                    { 762, new Guid("f585a22f-9cfc-4af1-a078-564475f53a0d"), "شهريار", 21 },
                    { 733, new Guid("b054c762-67d5-4a41-87bd-08e67f656333"), "لومار", 20 },
                    { 761, new Guid("1c865742-9e4f-4815-b184-5fa6cfca9cbb"), "شهر جديد پرند", 21 },
                    { 759, new Guid("4617e218-f156-46fa-9b23-4e1f796c3ed6"), "شريف آباد", 21 },
                    { 758, new Guid("1186deb6-28d6-4d11-bd49-a8208f08b543"), "شاهدشهر", 21 },
                    { 757, new Guid("b62dd0ba-6d88-42fd-b028-72d69859bf1c"), "ري", 21 },
                    { 756, new Guid("38ad566a-8f7f-47b0-812a-02d1ebc08684"), "رودهن", 21 },
                    { 755, new Guid("9dc3affe-45a9-4f6f-9034-1f51df43755d"), "رباط کريم", 21 },
                    { 754, new Guid("b6db6e9a-9b8d-496c-ab79-32d687a9ff5c"), "دماوند", 21 },
                    { 753, new Guid("7d401139-392d-4f27-8a28-5f5098ef13dc"), "حسن آباد", 21 },
                    { 760, new Guid("6f5e1213-9b12-407f-87bc-0ace2cc65e0b"), "شمشک", 21 },
                    { 732, new Guid("566fd53c-a54d-43e9-9f1a-a2245b3bf984"), "صالح آباد", 20 },
                    { 731, new Guid("2ae371ca-b26e-4ca2-9d51-1c856ce3e389"), "شباب", 20 },
                    { 730, new Guid("10273927-9489-414e-ae32-3396e166d83b"), "سرابله", 20 },
                    { 709, new Guid("8f36bbe4-38d9-449a-9414-9b32a855c00c"), "کوهپايه", 19 },
                    { 708, new Guid("c5333e52-0750-49d9-be8a-5fcb4aae3b44"), "کوشک", 19 },
                    { 707, new Guid("cb0c7bf6-e449-4b35-86a2-7cc7406b19e0"), "کهريزسنگ", 19 },
                    { 706, new Guid("ed29b70d-c781-4292-88af-270a2a4076ff"), "کمه", 19 },
                    { 705, new Guid("2eb003d0-56e8-4d5c-aaeb-b796ddba1522"), "کمشجه", 19 },
                    { 704, new Guid("8df4e49a-f614-4e43-916a-0fe97c1dde45"), "کليشاد و سودرجان", 19 },
                    { 703, new Guid("400800fc-4f26-423d-8828-671e456716aa"), "کرکوند", 19 },
                    { 710, new Guid("411043e1-5f7a-4016-ad08-2b43e36b2ac9"), "گرگاب", 19 },
                    { 702, new Guid("38f50517-0ef5-4a53-93e3-f04ab24477c6"), "کامو و چوگان", 19 },
                    { 700, new Guid("b08d87b2-0c87-43a5-aa12-c8eac240bb4c"), "چمگردان", 19 },
                    { 699, new Guid("3211e95f-8001-437a-a562-f1d6604ecce0"), "چرمهين", 19 },
                    { 698, new Guid("ec8dd664-783e-4b78-8000-b5145dd63bd2"), "چادگان", 19 },
                    { 697, new Guid("920e7d14-e4de-4435-bff7-f731e03ce7e5"), "پير بکران", 19 },
                    { 696, new Guid("503ee790-da34-4d48-b7d7-1db59c5178b6"), "ونک", 19 },
                    { 695, new Guid("b7871b65-82ae-477b-a7f2-26137707b0c1"), "وزوان", 19 },
                    { 694, new Guid("9f5106c7-10e5-4d7d-a069-be9c9bf12d05"), "ورنامخواست", 19 },
                    { 701, new Guid("c0d48c82-c6e2-4522-8a26-f4427638560d"), "کاشان", 19 },
                    { 692, new Guid("5fb40988-54f4-4414-9f01-cb9986fefa9b"), "هرند", 19 },
                    { 711, new Guid("9605717c-7357-4a40-b899-d819b19dad56"), "گز برخوار", 19 },
                    { 713, new Guid("edd596e0-a5e0-4c64-9807-b33cfbbbbac5"), "گلشن", 19 },
                    { 729, new Guid("72ded125-c9bf-45b8-a23d-ac04fe4892b4"), "سراب باغ", 20 },
                    { 728, new Guid("125ccd92-63f2-461c-bd82-87225cacca70"), "زرنه", 20 },
                    { 727, new Guid("0cea24d3-194f-4fa2-a4fd-56228720f3df"), "دهلران", 20 },
                    { 726, new Guid("a7f24faa-42d1-4811-9919-d580ba4cc5d1"), "دلگشا", 20 },
                    { 725, new Guid("112d4781-d56a-4b14-8791-8ac09186bfb1"), "دره شهر", 20 },
                    { 724, new Guid("1c2bf5bf-4d11-4fb4-b896-46b2ca700957"), "توحيد", 20 },
                    { 723, new Guid("95eccaa1-cf18-4cbb-a3b5-ab0cdc75b2b8"), "بلاوه", 20 },
                    { 712, new Guid("34fa22ce-d1de-4f73-94ed-7246ada208d7"), "گلدشت", 19 },
                    { 722, new Guid("0578cadd-9f5e-4e35-9412-8f07b71912ba"), "بدره", 20 },
                    { 720, new Guid("b5c38085-bb86-403b-9361-c258984b353e"), "ايلام", 20 },
                    { 719, new Guid("11228bf2-3c55-4702-b2bc-3bb460baaf57"), "ارکواز", 20 },
                    { 718, new Guid("ae20539d-01af-4e62-984c-271c203aacab"), "آسمان آباد", 20 },
                    { 717, new Guid("af8efc0e-e511-4ab0-88bd-4a694e849999"), "آبدانان", 20 },
                    { 716, new Guid("bb734a27-ff21-44b4-83f4-37394d5e4d54"), "گوگد", 19 },
                    { 715, new Guid("7c6643e3-66e1-43f2-9541-62a15f8dbb9e"), "گلپايگان", 19 },
                    { 714, new Guid("d526593b-58e0-4342-9494-043da263e3c6"), "گلشهر", 19 },
                    { 721, new Guid("da4393ed-4f15-4f2a-83a0-25c620308292"), "ايوان", 20 },
                    { 927, new Guid("3e8f3362-dc94-4508-98b0-0e8c6cceb215"), "مشکان", 23 },
                    { 928, new Guid("ccf0e55f-3679-4608-aa90-eab5ddba38a3"), "مصيري", 23 },
                    { 929, new Guid("f1b9faf9-fb22-4925-9454-15417dbb41e4"), "مهر", 23 },
                    { 1141, new Guid("e5364527-45e9-48b6-a4cc-8b49ed273d97"), "بردسير", 29 },
                    { 1140, new Guid("c8cf6679-e9a4-44ba-a9e7-ee5006ff494a"), "بافت", 29 },
                    { 1139, new Guid("c238ede6-2c2c-4b37-adff-e1f31adb9f5c"), "باغين", 29 },
                    { 1138, new Guid("ccae0f88-69af-469b-a3b1-e66812136f7d"), "اندوهجرد", 29 },
                    { 1137, new Guid("5b67b8f8-a88a-4267-80e6-787630430f21"), "انار", 29 },
                    { 1136, new Guid("fff4e787-e129-490d-b675-2122dbfd7b37"), "امين شهر", 29 },
                    { 1135, new Guid("adee4b23-d71b-416f-ad0c-7be1314bd2ea"), "ارزوئيه", 29 },
                    { 1134, new Guid("c23d366e-22e3-41ff-9b77-14c07c2bec3d"), "اختيار آباد", 29 },
                    { 1133, new Guid("1559eb9e-a38f-48c9-9560-bd8745a164dd"), "گيان", 28 },
                    { 1132, new Guid("d53e58a6-5b72-4ad9-b008-72c5f7eface5"), "گل تپه", 28 },
                    { 1131, new Guid("66641838-6cd4-4483-a874-571cc9c159cf"), "کبودر آهنگ", 28 },
                    { 1130, new Guid("8de3a32d-1119-4530-b634-a81c0380d7c4"), "همدان", 28 },
                    { 1129, new Guid("ef55b00d-6ccb-40f7-8926-096be4c8928d"), "نهاوند", 28 },
                    { 1128, new Guid("8d3cb3f7-23c2-4e60-bbf7-0d1147428d18"), "مهاجران", 28 },
                    { 1127, new Guid("c5ba441c-e323-447a-a992-289d7c00719a"), "ملاير", 28 },
                    { 1142, new Guid("a28e0699-2698-4551-8f50-765d03478390"), "بروات", 29 },
                    { 1143, new Guid("9ac6c9d4-727e-43a7-9ef6-42b6a81f830f"), "بزنجان", 29 },
                    { 1144, new Guid("118dde33-013d-4eea-bb41-d5ac7de03f7b"), "بلورد", 29 },
                    { 1145, new Guid("8ecf30df-177c-4782-b6d4-7acfb24d2dfe"), "بلوک", 29 },
                    { 1161, new Guid("20a121d0-e3c9-43e9-b8b9-3eda8833186b"), "راور", 29 },
                    { 1160, new Guid("0f605575-1866-4946-814c-4b5b5b5cdaaf"), "رابر", 29 },
                    { 1159, new Guid("3a285670-71e8-4818-92e6-bbf608a1fc52"), "دوساري", 29 },
                    { 1158, new Guid("0450d8bd-5d9f-4ec3-ab71-36c1dd132890"), "دهج", 29 },
                    { 1157, new Guid("7bb95c7f-9430-4f8b-9669-6057d53e8139"), "دشتکار", 29 },
                    { 1156, new Guid("8af96c90-c6d2-47f2-bb3c-fae3bcfbea72"), "درب بهشت", 29 },
                    { 1155, new Guid("86656e95-c034-4379-86ea-765ff178f604"), "خورسند", 29 },
                    { 1126, new Guid("b7fce07b-c248-4055-8dca-557a14bff391"), "مريانج", 28 },
                    { 1154, new Guid("b04e033e-7599-4ff6-925f-b2cf2475182f"), "خواجوشهر", 29 },
                    { 1152, new Guid("c26243c3-5cc2-46b0-afab-83296b5393f2"), "خاتون آباد", 29 },
                    { 1151, new Guid("72257466-a977-42c7-bf9c-46edf2a287d6"), "جيرفت", 29 },
                    { 1150, new Guid("e5cd8944-5516-4b9c-b513-62fad43e0d53"), "جوپار", 29 },
                    { 1149, new Guid("ab8f9170-b054-4947-b57d-19b320de1943"), "جوزم", 29 },
                    { 1148, new Guid("b6596789-b76c-4c76-bcdc-a6bfec6b587d"), "جبالبارز", 29 },
                    { 1147, new Guid("7350779a-9c26-44a3-b26b-ae2a81d0ce81"), "بهرمان", 29 },
                    { 1146, new Guid("6622d7ba-ddbe-407b-94f1-7c965ebff0c6"), "بم", 29 },
                    { 1153, new Guid("f544b99b-b725-4f98-b22b-e8ccb45f2230"), "خانوک", 29 },
                    { 1162, new Guid("630ca23d-14c4-4e79-80e7-c154eede41ff"), "راين", 29 },
                    { 1125, new Guid("fb3c616c-85ec-4e4b-b90f-45268a0dc28d"), "لالجين", 28 },
                    { 1123, new Guid("cf7cc5e6-8921-435a-9985-9ef129dd6274"), "قروه در جزين", 28 },
                    { 1102, new Guid("c0e3aaeb-87b2-4dd9-8661-10e47eb055db"), "کوچصفهان", 27 },
                    { 1101, new Guid("270e73ba-1a7b-4d67-9233-41f359719ddc"), "کومله", 27 },
                    { 1100, new Guid("2b2c8174-22f9-49e4-9868-984b679328a8"), "کلاچاي", 27 },
                    { 1099, new Guid("444ef31b-972e-4d46-b011-1a3a7ce69db6"), "چوبر", 27 },
                    { 1098, new Guid("5e68692f-9929-4860-80ac-c5be17192f1a"), "چاف و چمخاله", 27 },
                    { 1097, new Guid("96572232-cca9-45b1-a445-0dedd335e10a"), "چابکسر", 27 },
                    { 1096, new Guid("4a58655c-240e-4671-ae2d-91abd1f54721"), "پره سر", 27 },
                    { 1095, new Guid("ae5441bb-957b-4424-8137-9100391763c2"), "واجارگاه", 27 },
                    { 1094, new Guid("1816e8f6-0948-4e64-af9e-55b73d0ec781"), "هشتپر", 27 },
                    { 1093, new Guid("9af89ba6-1a3f-4b4d-ab67-483168e5fef1"), "منجيل", 27 },
                    { 1092, new Guid("4119ac12-c460-4400-a141-65a00a8a9121"), "مرجقل", 27 },
                    { 1091, new Guid("0853d7a4-1ef0-48fb-9383-b1292c2ba93d"), "ماکلوان", 27 },
                    { 1090, new Guid("633c62b0-e5c9-4539-99c8-76f304db4f3c"), "ماسوله", 27 },
                    { 1089, new Guid("3cf4a3f8-cb2b-4bec-9777-245aeee1a0c8"), "ماسال", 27 },
                    { 1088, new Guid("b4876d51-20ab-49e5-99a7-1fa9dd406472"), "ليسار", 27 },
                    { 1103, new Guid("bbaaf524-921a-44c3-ab54-5c6a2b58b8db"), "کياشهر", 27 },
                    { 1104, new Guid("aeb22d20-0a0b-47a2-9f8a-e85f56d8b37e"), "گوراب زرميخ", 27 },
                    { 1105, new Guid("1da6339e-5e0e-423c-acde-d48dc5d7856f"), "آجين", 28 },
                    { 1106, new Guid("4bff84c1-05ee-47e8-a67c-b8345c6ee883"), "ازندريان", 28 },
                    { 1122, new Guid("0ad5593e-d552-4b29-9582-99c2b60046e3"), "فيروزان", 28 },
                    { 1121, new Guid("f22163f4-de1e-4068-a548-ecb9b95b66ec"), "فرسفج", 28 },
                    { 1120, new Guid("86f3e549-2adb-401c-88b8-d34e2389368c"), "فامنين", 28 },
                    { 1119, new Guid("42d062db-9e77-49ca-a5c9-2c9cce28ef27"), "صالح آباد", 28 },
                    { 1118, new Guid("493c3c64-c096-4fc0-85c9-3c5b5a947f3b"), "شيرين سو", 28 },
                    { 1117, new Guid("e6a6b409-92e1-477f-a57b-7553169e90a6"), "سرکان", 28 },
                    { 1116, new Guid("290eb4a6-2e24-416b-8c9a-806e534fbf62"), "سامن", 28 },
                    { 1124, new Guid("e67606f0-6d57-4459-9518-05428ee0e8e8"), "قهاوند", 28 },
                    { 1115, new Guid("6444eed6-1298-4f0f-bce4-f47fd631bb25"), "زنگنه", 28 },
                    { 1113, new Guid("9fbaf7f8-2ed4-4d06-bafc-a71894d0a240"), "دمق", 28 },
                    { 1112, new Guid("b9e53b31-7e2e-49b1-8d8d-19cc4d8385a7"), "جوکار", 28 },
                    { 1111, new Guid("61ffec86-bc95-4ffb-9c36-3b6a4e4d2b21"), "جورقان", 28 },
                    { 1110, new Guid("c8d7cffb-c64b-4176-aee6-2f63d709795f"), "تويسرکان", 28 },
                    { 1109, new Guid("9d17a58e-2384-44a5-975d-417e2ec3cd4d"), "بهار", 28 },
                    { 1108, new Guid("ac418376-ec52-4c71-ae6b-439af872a958"), "برزول", 28 },
                    { 1107, new Guid("584d1e61-844b-4134-b34c-f21c872e11a7"), "اسد آباد", 28 },
                    { 1114, new Guid("d274ed0a-c3c1-4e10-aedf-826d13780144"), "رزن", 28 },
                    { 1163, new Guid("afb985d3-4a51-4b7e-9734-68a3c5986b14"), "رفسنجان", 29 },
                    { 1164, new Guid("4329e10a-d867-43af-afd9-07bbc759d9aa"), "رودبار", 29 },
                    { 1165, new Guid("713247a1-8b51-4673-b0cc-a9bdfd3c47b6"), "ريحان", 29 },
                    { 1220, new Guid("0d878a7b-7e5f-41a4-ad08-e79888c3f932"), "ميامي", 30 },
                    { 1219, new Guid("c6c3fedb-ea7b-4cbb-81eb-0bccb1da43db"), "مهدي شهر", 30 },
                    { 1218, new Guid("b34f70fb-e370-466a-9d8c-7ee65b34e2ef"), "مجن", 30 },
                    { 1217, new Guid("7180dcdf-0c86-4656-8ecc-17de16103126"), "شهميرزاد", 30 },
                    { 1216, new Guid("dc774755-0bac-413d-adc9-06a3fe245c9f"), "شاهرود", 30 },
                    { 1215, new Guid("8ed2a437-34d2-4e43-b903-f85ba8ec5407"), "سمنان", 30 },
                    { 1214, new Guid("58bf548b-64eb-448c-8708-82b7500abd86"), "سرخه", 30 },
                    { 1213, new Guid("d4e8c7b2-22c3-468d-b18d-ee49d2bb147d"), "روديان", 30 },
                    { 1212, new Guid("e6908f61-5dff-4f03-86c3-a5d0b1c78a2e"), "ديباج", 30 },
                    { 1211, new Guid("342c0df2-351d-459f-91b6-2fd883c427f1"), "درجزين", 30 },
                    { 1210, new Guid("c73ceb9e-86d9-4c10-b220-ffcc37106435"), "دامغان", 30 },
                    { 1209, new Guid("c9d1019c-7a2c-4a59-9322-fdac3f7eeafc"), "بيارجمند", 30 },
                    { 1208, new Guid("624aca4d-b3a0-4f34-917a-6bc998b3f61c"), "بسطام", 30 },
                    { 1207, new Guid("eb1a3960-6133-4640-8e30-ef41bac3baf2"), "ايوانکي", 30 },
                    { 1206, new Guid("0eb484aa-22e7-4551-a353-e9c6b3d961a9"), "اميريه", 30 },
                    { 1221, new Guid("9343a786-89fa-45fa-8538-9cea9255c67d"), "کلاته", 30 },
                    { 1222, new Guid("726edb8f-4133-47e1-a9a0-7107f11b8fec"), "کلاته خيج", 30 },
                    { 1223, new Guid("094b50a2-39fc-4567-9f7e-607d6915d636"), "کهن آباد", 30 },
                    { 1224, new Guid("4293b7dc-1719-409c-bfc4-eb2761201b40"), "گرمسار", 30 },
                    { 1240, new Guid("10a11e97-1827-4539-ab57-d2cbfb88a75e"), "چيتاب", 31 },
                    { 1239, new Guid("c3edd367-f226-4bbf-a492-fc3a843455de"), "چرام", 31 },
                    { 1238, new Guid("9491df3b-9190-4e1c-ac9a-8aecfa829511"), "پاتاوه", 31 },
                    { 1237, new Guid("8f2a0f06-de8a-4545-b88e-a72a3f021ddb"), "ياسوج", 31 },
                    { 1236, new Guid("f28ea859-3c3a-44b7-892e-8a0094fc958b"), "مارگون", 31 },
                    { 1235, new Guid("5f84f240-4a63-4f73-9e33-4aa7bf20791f"), "مادوان", 31 },
                    { 1234, new Guid("c0f1b74a-b859-470c-84eb-be34dcad93ad"), "ليکک", 31 },
                    { 1205, new Guid("f5c4426d-b1a8-4c8a-a8a3-0c9942675714"), "آرادان", 30 },
                    { 1233, new Guid("c4bf17b2-cb31-475a-966b-4bb51946dcbf"), "لنده", 31 },
                    { 1231, new Guid("b3743f0f-5896-4685-af14-cbd286f214e5"), "سي سخت", 31 },
                    { 1230, new Guid("9c029536-8c6f-4151-b4a2-76a660d34f97"), "سوق", 31 },
                    { 1229, new Guid("ee3d2021-b00e-4861-9d08-c19ed8667135"), "سرفارياب", 31 },
                    { 1228, new Guid("b9da8103-da34-44bd-a15b-872df21fe928"), "ديشموک", 31 },
                    { 1227, new Guid("31bfbd51-aa86-435c-8ff7-ca1274a0aeb1"), "دوگنبدان", 31 },
                    { 1226, new Guid("f62a1768-9472-4e01-bf69-6c7cc8de9e4c"), "دهدشت", 31 },
                    { 1225, new Guid("e54c2e1b-2381-4474-9648-aed1be1d3133"), "باشت", 31 },
                    { 1232, new Guid("a5320618-3ce9-4b7b-84e7-fd34325086d1"), "قلعه رئيسي", 31 },
                    { 1204, new Guid("b2e07ead-c953-4338-9ed6-aa293428eab9"), "گنبکي", 29 },
                    { 1203, new Guid("9bdd7e14-d3d5-44f6-aff8-eea032053540"), "گلزار", 29 },
                    { 1202, new Guid("cad0d106-8443-4f89-a59a-f8e8a21fa1e6"), "گلباف", 29 },
                    { 1181, new Guid("a88731fb-8871-4434-9255-fbb6f12eac4b"), "محي آباد", 29 },
                    { 1180, new Guid("955843ab-3a49-48f0-8205-1a81bd7bc834"), "محمد آباد", 29 },
                    { 1179, new Guid("c44b871c-29db-4eca-bc7e-8907b81493b0"), "ماهان", 29 },
                    { 1178, new Guid("068668ba-793c-4c55-b122-ea649ffe0dfa"), "لاله زار", 29 },
                    { 1177, new Guid("bb4016bc-4546-4bf4-beaf-db94ab344709"), "قلعه گنج", 29 },
                    { 1176, new Guid("a8444181-58cb-4b13-9bf7-46d6aad5eea2"), "فهرج", 29 },
                    { 1175, new Guid("e9bf3bbc-59a3-4d0d-b9b2-7e24fa718c6e"), "فارياب", 29 },
                    { 1182, new Guid("4658ee6d-2958-46c3-9b0b-f497c467e28b"), "مردهک", 29 },
                    { 1174, new Guid("906ae487-cb77-437f-904e-f4e4210971df"), "عنبر آباد", 29 },
                    { 1172, new Guid("4c0353cf-4d41-4006-87a5-c5de079417ed"), "شهر بابک", 29 },
                    { 1171, new Guid("8fda8fca-dd11-4252-bec9-c3c1b0334d7e"), "شهداد", 29 },
                    { 1170, new Guid("4c4ff384-7bb4-4ef7-8bff-f8fd1e486e33"), "سيرجان", 29 },
                    { 1169, new Guid("2a5f200d-bd73-4388-ae65-56673434798a"), "زيد آباد", 29 },
                    { 1168, new Guid("bbfeaeb8-b23c-4e5c-8528-fd1baf0c9261"), "زهکلوت", 29 },
                    { 1167, new Guid("3dce2ac1-8c6a-46f1-895b-0a7741bbb34e"), "زنگي آباد", 29 },
                    { 1166, new Guid("1d928424-b084-41fc-b8ad-6f96a9f0fc2e"), "زرند", 29 },
                    { 1173, new Guid("4c489e3f-0a18-486c-9a49-0bdaa7e62843"), "صفائيه", 29 },
                    { 1087, new Guid("0588edce-563b-4e86-a662-2cd5fedc5768"), "لوندويل", 27 },
                    { 1183, new Guid("78d19ec2-56a4-41c4-a143-8e8992d6a6dd"), "مس سرچشمه", 29 },
                    { 1185, new Guid("da24d58a-22cf-4d98-a901-b85926b95fc7"), "نجف شهر", 29 },
                    { 1201, new Guid("a262ac5b-7752-4f30-b9bb-b08ada9428c5"), "کيانشهر", 29 },
                    { 1200, new Guid("c1b4391b-d9d5-4e5b-a13b-b99e20694cc9"), "کوهبنان", 29 },
                    { 1199, new Guid("138c3f6d-2c04-4bd2-b93b-b0df1cccb6da"), "کهنوج", 29 },
                    { 1198, new Guid("5644501d-7f08-49c9-a488-3be908171088"), "کشکوئيه", 29 },
                    { 1197, new Guid("93af6b60-26e2-4dfc-b5be-b4446ac10e64"), "کرمان", 29 },
                    { 1196, new Guid("3eda92e4-5683-4de7-96f8-57641f6bb2b2"), "کاظم آباد", 29 },
                    { 1195, new Guid("0403e130-ffb2-4625-9554-21fd1f75d133"), "چترود", 29 },
                    { 1184, new Guid("c9f7990f-5155-4478-ab84-a13c9e1e232e"), "منوجان", 29 },
                    { 1194, new Guid("79caedfa-4cc4-4fed-b0bb-e50efdc95254"), "پاريز", 29 },
                    { 1192, new Guid("991b04c2-5abc-4f57-aba6-4d22912d541a"), "هنزا", 29 },
                    { 1191, new Guid("c8bfa98b-a745-4467-96f9-818c654aae38"), "هماشهر", 29 },
                    { 1190, new Guid("9a9012f3-a436-40d2-a541-1215f63d9d44"), "هجدک", 29 },
                    { 1189, new Guid("a313758b-2c44-4148-b008-7d421bdcd401"), "نگار", 29 },
                    { 1188, new Guid("b842e407-e5df-43e2-9693-d38b945dc481"), "نودژ", 29 },
                    { 1187, new Guid("e8ece94e-4903-4957-97a5-870b80bc1739"), "نظام شهر", 29 },
                    { 1186, new Guid("c944c8fe-dd45-43eb-b0f5-ee12c01c62b3"), "نرماشير", 29 },
                    { 1193, new Guid("961b5d60-2e2d-474f-a2b4-d58c7376c0b4"), "يزدان شهر", 29 },
                    { 1086, new Guid("7399c8de-6ab8-4d8b-9a9a-80234a1e5551"), "لولمان", 27 },
                    { 1085, new Guid("e1f356d7-958e-40e9-87ad-8ca20fa873f0"), "لوشان", 27 },
                    { 1084, new Guid("d978cb0d-ede5-47ea-a86f-79c5d16d05c7"), "لنگرود", 27 },
                    { 984, new Guid("4a7a6560-233a-4f56-b32a-37ce14fab516"), "بندر عباس", 25 },
                    { 983, new Guid("b07296d5-5fab-4845-9507-0940209b46ba"), "بندر جاسک", 25 },
                    { 982, new Guid("ece2d00f-0c61-4bdc-9a41-751eb546e158"), "بستک", 25 },
                    { 981, new Guid("d8e7d848-cddc-4ed8-b4bd-d4dd752939f6"), "ابوموسي", 25 },
                    { 980, new Guid("9b74329b-ea5c-48c1-ac22-c56b4e507a53"), "گيلانغرب", 24 },
                    { 979, new Guid("c63ebb74-3de1-4ddc-ae06-e265aea9a23e"), "گودين", 24 },
                    { 978, new Guid("35f1c930-2122-48f3-a9d2-186f9b829f11"), "گهواره", 24 },
                    { 977, new Guid("4c39ccee-c079-471c-bb65-156522e0e4eb"), "کوزران", 24 },
                    { 976, new Guid("d4231901-f152-4b3d-98e6-9ccac9b46687"), "کنگاور", 24 },
                    { 975, new Guid("f361819d-8f50-4b64-a5a9-c773b1664ecf"), "کرند غرب", 24 },
                    { 974, new Guid("e4296982-bd1a-4c41-936f-56c2b8a7ad61"), "کرمانشاه", 24 },
                    { 973, new Guid("2b046b96-4d60-4cd9-b001-ab866c4cb1e7"), "پاوه", 24 },
                    { 972, new Guid("6082c3b3-3742-4ea6-af6c-219df28b2afa"), "هلشي", 24 },
                    { 971, new Guid("bf65d50f-ce09-4301-91d9-b3742fc3eed1"), "هرسين", 24 },
                    { 970, new Guid("3bff0ab6-263b-483b-8a0c-b85d6347bb93"), "نوسود", 24 },
                    { 985, new Guid("78f191aa-4e01-40a8-9773-a453358c6622"), "بندر لنگه", 25 },
                    { 986, new Guid("a482c5f6-c44c-4165-b3bf-f1cbf044bd9a"), "بيکاه", 25 },
                    { 987, new Guid("c7a9c6a8-65b5-42f9-8c64-82404dd8f26e"), "تازيان پائين", 25 },
                    { 988, new Guid("2aeadf30-21ef-4064-b97f-74bd9898bbc9"), "تخت", 25 },
                    { 1004, new Guid("826d2c41-fd14-40e0-a896-c84e76aa4641"), "فين", 25 },
                    { 1003, new Guid("ae97cf35-5aea-4af6-981c-f051482290ec"), "فارغان", 25 },
                    { 1002, new Guid("15f57c22-9418-4251-967c-2ef6ab2afabe"), "سيريک", 25 },
                    { 1001, new Guid("3fb25bdb-29d6-4531-9b13-d2b76c0673b0"), "سوزا", 25 },
                    { 1000, new Guid("de5f0e5c-bd26-46dc-a6fd-4db279c0c4c2"), "سندرک", 25 },
                    { 999, new Guid("5e82a89e-7209-4d65-8935-ac85b11b79db"), "سرگز", 25 },
                    { 998, new Guid("9e60750b-d64e-4a40-bb18-a072bd20c749"), "سردشت", 25 },
                    { 969, new Guid("d0989b45-c31e-4532-8a6b-c67e29841763"), "نودشه", 24 },
                    { 997, new Guid("584aa5bc-85b9-4edb-b423-edbd948db93d"), "زيارتعلي", 25 },
                    { 995, new Guid("64712b37-0b87-4e6b-9557-50542e5994e5"), "دهبارز", 25 },
                    { 994, new Guid("55b68f5d-795d-4f27-b09c-2b431efb4584"), "دشتي", 25 },
                    { 993, new Guid("049dad2a-8144-4fc8-81d0-01b82ff997d6"), "درگهان", 25 },
                    { 992, new Guid("7e459bc9-c747-44d0-9b0b-12d4588b983f"), "خمير", 25 },
                    { 991, new Guid("6d016b09-e35f-4a2f-806f-f539b78a1800"), "حاجي آباد", 25 },
                    { 990, new Guid("097a6253-da7c-4c77-84cb-4a39f76bd56f"), "جناح", 25 },
                    { 989, new Guid("86bd43b6-7795-46aa-9f05-6491ba2e0a09"), "تيرور", 25 },
                    { 996, new Guid("030f9a9a-15c0-4291-aa27-7a412b7b77fa"), "رويدر", 25 },
                    { 968, new Guid("ab576003-6d38-4174-a843-c1bd5da3aae0"), "ميان راهان", 24 },
                    { 967, new Guid("2d61a91d-f5e2-4252-b752-c58a3a66ce32"), "قصر شيرين", 24 },
                    { 966, new Guid("0549b40c-808c-4145-9f09-cd38a5a35af0"), "صحنه", 24 },
                    { 945, new Guid("80164c00-4b46-498f-96c6-7c9feb271084"), "کوهنجان", 23 },
                    { 944, new Guid("2c633fb4-1ae3-49f4-ab9b-9f17436a0740"), "کوار", 23 },
                    { 943, new Guid("677eca4d-d5b1-4e9a-aa69-7aaba1d39803"), "کنار تخته", 23 },
                    { 942, new Guid("1acddb4d-8e7c-44dc-af83-67efba49e5d0"), "کره اي", 23 },
                    { 941, new Guid("4c63c7e4-ca86-4dbc-975e-a4e3a97b303d"), "کامفيروز", 23 },
                    { 940, new Guid("973b69bc-b67e-4999-b3de-f32e2b803275"), "کازرون", 23 },
                    { 939, new Guid("da1f54ff-dcb1-41e0-8002-97078fe1fb97"), "کارزين", 23 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 946, new Guid("b86f76eb-1871-4f84-af12-fe2ab2e05667"), "کوپن", 23 },
                    { 938, new Guid("612946bf-862d-443b-ac3b-c4dab94f61d6"), "وراوي", 23 },
                    { 936, new Guid("98bcb741-79fa-4b88-a373-32ecad7a3813"), "ني ريز", 23 },
                    { 935, new Guid("4208654a-a7ac-497e-bc80-8d2f2c3d9db4"), "نورآباد", 23 },
                    { 934, new Guid("f2fb97f8-bd53-4c94-9e80-0b3e2942e983"), "نودان", 23 },
                    { 933, new Guid("8f5c56af-bab7-44c2-8b9c-ac82827cdde5"), "نوجين", 23 },
                    { 932, new Guid("0a1a2bae-4e34-4f4c-8824-fad3e31e20d5"), "نوبندگان", 23 },
                    { 931, new Guid("969baf77-52ea-4f6a-ba3d-f2f364d69a1d"), "ميمند", 23 },
                    { 930, new Guid("6499e75f-0c33-446e-b570-f231ee80b4ad"), "ميانشهر", 23 },
                    { 937, new Guid("2871867b-c260-4434-a256-6bf5270e2adb"), "هماشهر", 23 },
                    { 1005, new Guid("07151834-29d0-498b-9b2b-be6b1462fa5f"), "قشم", 25 },
                    { 947, new Guid("f9cca930-86e2-49ab-b6cb-549c9c6faaa9"), "گراش", 23 },
                    { 949, new Guid("e2d06b2f-d6b3-4b3e-88ad-d09729a2753a"), "ازگله", 24 },
                    { 965, new Guid("d50bcf0f-4ea3-46cd-8057-556fad4c8ef6"), "شاهو", 24 },
                    { 964, new Guid("9d375adf-347a-48d7-a8d5-e1677c3e5227"), "سومار", 24 },
                    { 963, new Guid("41122600-f50e-44d9-a662-e4d39179b417"), "سنقر", 24 },
                    { 962, new Guid("d18805e4-1289-443f-a70c-c288f0a0aa54"), "سطر", 24 },
                    { 961, new Guid("4eb63346-7542-4e19-9044-d27b288c2e16"), "سرمست", 24 },
                    { 960, new Guid("74fefc44-2be3-4f30-a656-ab933c623661"), "سر پل ذهاب", 24 },
                    { 959, new Guid("0bfc9b68-6ef9-4bf6-8f6d-84344b28f6d3"), "ريجاب", 24 },
                    { 948, new Guid("2a405257-6a12-4d13-a11d-e859451538ab"), "گله دار", 23 },
                    { 958, new Guid("028dc06f-208d-4aa4-9500-04842acde27c"), "روانسر", 24 },
                    { 956, new Guid("c8e949bb-747a-440a-9c8c-28ce997a2b03"), "حميل", 24 },
                    { 955, new Guid("0038adc6-c797-49e2-a9a4-cd95f7f2a57d"), "جوانرود", 24 },
                    { 954, new Guid("8bd4bcae-f27f-4853-aa20-972de98c8a0d"), "تازه آباد", 24 },
                    { 953, new Guid("ee5142da-8160-4e37-8a32-1f7c8dd24d75"), "بيستون", 24 },
                    { 952, new Guid("eeda1f98-d3af-46ac-8155-eb98674b5363"), "باينگان", 24 },
                    { 951, new Guid("8cfa884a-194f-466e-b0fc-d4bf9689fb48"), "بانوره", 24 },
                    { 950, new Guid("6e8017a2-bf5d-4bca-941b-82deef1450de"), "اسلام آباد غرب", 24 },
                    { 957, new Guid("851dd0bc-f033-4cd5-8f94-b07b5a0e829e"), "رباط", 24 },
                    { 614, new Guid("adcd8759-c079-4af5-b5dc-ff9bc12edd30"), "اردستان", 19 },
                    { 1006, new Guid("ecf3bd5c-6152-4398-b704-d1532186ab60"), "قلعه قاضي", 25 },
                    { 1008, new Guid("973f3cb7-a81c-4cd1-a08e-ce9446f42cea"), "ميناب", 25 },
                    { 1063, new Guid("799eb5c3-0e7d-4125-90c5-00fa7bcefeaa"), "جيرنده", 27 },
                    { 1062, new Guid("5d9e206b-7e86-4d10-98a0-bfd1867fac52"), "توتکابن", 27 },
                    { 1061, new Guid("6b3a784a-ddc2-44ba-b351-d1570f40ad9f"), "بندر انزلي", 27 },
                    { 1060, new Guid("f5c52b90-072a-4f24-ad4d-f28fe259bdfb"), "بره سر", 27 },
                    { 1059, new Guid("a5829075-12aa-4f51-899a-81b96918e801"), "بازار جمعه", 27 },
                    { 1058, new Guid("2dd1215b-ccca-4d50-8ce6-cca8daf528b9"), "املش", 27 },
                    { 1057, new Guid("58f5f6ba-f9e1-4bc8-b27b-7dc616161168"), "اطاقور", 27 },
                    { 1056, new Guid("146c41ae-8807-4cd9-9595-e08b891020c3"), "اسالم", 27 },
                    { 1055, new Guid("2bd3f66b-1e83-4dbc-96d7-f1baf8c50c36"), "احمد سرگوراب", 27 },
                    { 1054, new Guid("d8287a8d-095d-4b86-8ce7-9edb0402bd78"), "آستانه اشرفيه", 27 },
                    { 1053, new Guid("53c99e10-e43f-4496-a478-3fd5a716fc5a"), "آستارا", 27 },
                    { 1052, new Guid("cd310b48-734d-459d-92b6-e46c7bae1653"), "کميجان", 26 },
                    { 1051, new Guid("53c54f09-7208-4fc7-9a23-fac8c09baefc"), "کارچان", 26 },
                    { 1050, new Guid("f04c38ad-7dbb-4429-b077-05908d78aadf"), "پرندک", 26 },
                    { 1049, new Guid("9b2968ed-ceb9-4810-a530-c00fe91bbbe0"), "هندودر", 26 },
                    { 1064, new Guid("b9b57eed-4023-4291-8ad6-862760788e99"), "حويق", 27 },
                    { 1065, new Guid("bbc8d084-1176-4c00-8011-f15122b56023"), "خشکبيجار", 27 },
                    { 1066, new Guid("024dd938-d38a-49d7-9ca1-78a80dd3b3ae"), "خمام", 27 },
                    { 1067, new Guid("bab45b36-c63c-43fd-b7de-94c9fe529aad"), "ديلمان", 27 },
                    { 1083, new Guid("d042ac72-4e34-4991-ba04-0593ee03fd6e"), "لشت نشاء", 27 },
                    { 1082, new Guid("b401a286-edb0-4238-a7b2-d0183d7b4e04"), "لاهيجان", 27 },
                    { 1081, new Guid("8ed7a1a8-e2d7-4a8b-80a1-44c5016d7d5f"), "فومن", 27 },
                    { 1080, new Guid("9e920bb4-ce77-4d75-9b6b-d0245de50ef9"), "صومعه سرا", 27 },
                    { 1079, new Guid("78f156a5-3ce6-4afa-9187-1622b30ec91d"), "شلمان", 27 },
                    { 1078, new Guid("f73a76ae-29b8-4236-929f-0a2ac10cd7e2"), "شفت", 27 },
                    { 1077, new Guid("bc1ea9f1-cfd2-4172-b979-1652840cdd6a"), "سياهکل", 27 },
                    { 1048, new Guid("65ba0c02-e6e2-41c6-8ddb-8186d076b7a3"), "نيمور", 26 },
                    { 1076, new Guid("ded470d5-3465-43e2-a478-9b81ea91b071"), "سنگر", 27 },
                    { 1074, new Guid("9bd0f288-5f1e-465d-85ad-12bbd544a6a9"), "رودبنه", 27 },
                    { 1073, new Guid("5220407d-06b3-4fd1-a280-089bb397c3b3"), "رودبار", 27 },
                    { 1072, new Guid("f26527ee-f10b-4ac2-907d-c806bb32b690"), "رضوانشهر", 27 },
                    { 1071, new Guid("e68dae7c-9084-4f10-b0c4-2b787f730d58"), "رشت", 27 },
                    { 1070, new Guid("c847a982-3e64-4435-a14a-f8dd52c27b00"), "رستم آباد", 27 },
                    { 1069, new Guid("1014c8e6-f43e-444e-9875-2f1d30377aec"), "رحيم آباد", 27 },
                    { 1068, new Guid("801ec998-cc99-4898-ae8f-2b81e878f380"), "رانکوه", 27 },
                    { 1075, new Guid("63a3b0b6-ef72-453e-8235-772a3c0cc3b5"), "رودسر", 27 },
                    { 1047, new Guid("b127bc00-a662-4724-b9f6-c8b6101893ac"), "نوبران", 26 },
                    { 1046, new Guid("52dbb9b6-7f11-40b4-9c36-2fcaf437dd4f"), "نراق", 26 },
                    { 1045, new Guid("2e5dde9e-0538-4255-99d2-a4e8875f7835"), "ميلاجرد", 26 },
                    { 1024, new Guid("00e01df7-2869-40a5-9b65-e6b6263fdeb7"), "تفرش", 26 },
                    { 1023, new Guid("ee0308f5-67c0-4967-819f-3efd34656a15"), "اراک", 26 },
                    { 1022, new Guid("5a40f60e-f228-41f7-ab16-abb304c70e17"), "آوه", 26 },
                    { 1021, new Guid("e6ee6879-7c4e-497e-92c0-de4b37f09f91"), "آشتيان", 26 },
                    { 1020, new Guid("8da98c89-359e-4e7c-bd21-53b304513e07"), "آستانه", 26 },
                    { 1019, new Guid("d6712008-5a3e-43b5-9659-ce374bb193d5"), "گوهران", 25 },
                    { 1018, new Guid("cd11a932-1ff1-407d-8f5f-5dbeb4a49fd1"), "گروک", 25 },
                    { 1025, new Guid("43f8bdce-6bdc-44b4-9908-29ec972eb71a"), "توره", 26 },
                    { 1017, new Guid("ca2f96a0-d582-4414-a055-1f4cedb8c9a1"), "کيش", 25 },
                    { 1015, new Guid("0fe02b36-cb3b-483f-9f17-d631ff286fce"), "کوشکنار", 25 },
                    { 1014, new Guid("7de9f517-6c48-4264-b1f4-dbb6223417d7"), "کوخردهرنگ", 25 },
                    { 1013, new Guid("e03da1b7-cf41-4597-8ec6-0af85a924eb4"), "کنگ", 25 },
                    { 1012, new Guid("581f422c-c22f-4304-b8d0-a7d530cead00"), "چارک", 25 },
                    { 1011, new Guid("9074699f-e311-4854-86e0-2163cf0dc5b7"), "پارسيان", 25 },
                    { 1010, new Guid("4481de9d-9748-421e-a00a-a44a35008326"), "هشتبندي", 25 },
                    { 1009, new Guid("e8bf0513-2976-404d-8f2b-3296c8f3e425"), "هرمز", 25 },
                    { 1016, new Guid("20d290ce-92d1-452c-8fbd-ef91396dbb97"), "کوهستک", 25 },
                    { 1007, new Guid("6ead9bb2-773a-4a4e-b6e5-efc4aa09d57e"), "لمزان", 25 },
                    { 1026, new Guid("01593358-3505-404e-90cf-18da44c2399a"), "جاورسيان", 26 },
                    { 1028, new Guid("f22de0f9-9f42-48a3-9b0b-25701f3ae6e6"), "خمين", 26 },
                    { 1044, new Guid("7bf92754-3bb4-4fbc-848f-89d57c50afdf"), "محلات", 26 },
                    { 1043, new Guid("ffcae4ed-ba17-4c08-b3d4-f100617cc9c7"), "مامونيه", 26 },
                    { 1042, new Guid("c5b5931f-ed4c-4560-b6eb-e6ee11ce92ef"), "قورچي باشي", 26 },
                    { 1041, new Guid("7dde5ab6-a247-479e-9dbf-147b7f8371de"), "فرمهين", 26 },
                    { 1040, new Guid("e49697fd-c9bb-41da-8a5e-db7dbc80482e"), "غرق آباد", 26 },
                    { 1039, new Guid("71d8ae27-800f-4486-a25a-a6866102414d"), "شهر جديد مهاجران", 26 },
                    { 1038, new Guid("a567aae0-2c93-41cd-b65e-2852be1af5ad"), "شهباز", 26 },
                    { 1027, new Guid("c154d653-a480-468b-81ba-be3aeb1757e2"), "خشکرود", 26 },
                    { 1037, new Guid("de3e7280-2d72-47f4-acda-fca898c3c36a"), "شازند", 26 },
                    { 1035, new Guid("35539b45-5c8a-4435-9fd7-fe65c3b57638"), "ساروق", 26 },
                    { 1034, new Guid("08246eca-9f4e-4de7-8d72-092eb2c157bb"), "زاويه", 26 },
                    { 1033, new Guid("0f52a388-db40-46ed-b5bd-595fbc2a8e82"), "رازقان", 26 },
                    { 1032, new Guid("65640028-1f97-4959-b01a-a86950b47098"), "دليجان", 26 },
                    { 1031, new Guid("288b82e3-4a30-4907-a23d-d931b9d267e5"), "داود آباد", 26 },
                    { 1030, new Guid("b9b160ad-ce48-4cd2-8104-d95b8975d2db"), "خنداب", 26 },
                    { 1029, new Guid("dd3191bc-c0a8-4b3f-afc8-49938e2a8b8d"), "خنجين", 26 },
                    { 1036, new Guid("1d87c983-dfea-4bb3-a938-7a279b974266"), "ساوه", 26 },
                    { 613, new Guid("d113bd12-4478-4043-8785-2e7ca1babf24"), "ابوزيد آباد", 19 },
                    { 612, new Guid("796ac532-5b9f-4e6e-93f1-5ef231fd4a22"), "ابريشم", 19 },
                    { 611, new Guid("b554ddb7-5ca2-4b31-b065-77af3aa3c820"), "آران و بيدگل", 19 },
                    { 207, new Guid("1145941d-227e-4ea5-8d72-fdd313449116"), "سلامي", 8 },
                    { 206, new Guid("73bb1818-da62-47b0-80e7-24fd9a95ebd7"), "سفيد سنگ", 8 },
                    { 205, new Guid("28b5f9dc-f01e-469e-8b7f-77735571d408"), "سرخس", 8 },
                    { 204, new Guid("bee1e9c5-33dd-40b2-bbc8-b4666d9e9a57"), "سبزوار", 8 },
                    { 203, new Guid("a72497e3-2085-4529-9175-82bd9dba4da4"), "ريوش", 8 },
                    { 202, new Guid("20564b6a-ee64-4a01-b221-38fda6d125ad"), "روداب", 8 },
                    { 201, new Guid("f4642a05-2e9e-46f2-b167-2229e8dd4738"), "رضويه", 8 },
                    { 200, new Guid("bee3852a-199c-4ba7-96f6-98f587f85d7f"), "رشتخوار", 8 },
                    { 199, new Guid("e707133d-e7d8-4ebe-ae7b-c40d50592f9c"), "رباط سنگ", 8 },
                    { 198, new Guid("e203f8a1-5076-4526-ad2f-5fc9af3d3b02"), "دولت آباد", 8 },
                    { 197, new Guid("7b793cc8-fa15-41fe-8cea-4673ce0a25a0"), "درگز", 8 },
                    { 196, new Guid("b4a90988-e791-4817-bcc6-6d9c864fad1b"), "درود", 8 },
                    { 195, new Guid("f3f77468-853d-426f-981f-715a8e702a43"), "داورزن", 8 },
                    { 194, new Guid("82f356b9-8fef-45d4-a287-15982818ff88"), "خواف", 8 },
                    { 193, new Guid("59a2bfe5-02a3-4928-8c99-44f6449030cd"), "خليل آباد", 8 },
                    { 208, new Guid("370b1b6e-85ce-42cc-b489-a0d841ab89ba"), "سلطان آباد", 8 },
                    { 192, new Guid("822f301d-843e-40d7-a0d1-eae1ef91c8dd"), "خرو", 8 },
                    { 209, new Guid("10f182b3-dcb0-497a-8d23-86cb18847fcb"), "سنگان", 8 },
                    { 211, new Guid("1286223e-8d06-4790-8c94-b7777cc0cb25"), "شانديز", 8 },
                    { 226, new Guid("4aac07bb-3d8a-4f09-aec6-b3a600b51cce"), "لطف آباد", 8 },
                    { 225, new Guid("787a1646-a467-4f4e-b949-d1d37c8db630"), "قوچان", 8 },
                    { 224, new Guid("7c07470c-f424-4ea9-98cd-f565ce0a4977"), "قلندر آباد", 8 },
                    { 223, new Guid("6e9d1114-a841-4b09-9c82-7c6f163c02ca"), "قدمگاه", 8 },
                    { 222, new Guid("8674a52e-4ab7-4a84-a268-733c7f8a8b52"), "قاسم آباد", 8 },
                    { 221, new Guid("c78e0d9b-1139-4c51-83c9-a0c7d5335848"), "فيض آباد", 8 },
                    { 220, new Guid("0ac1eab0-e6b6-49cd-b344-492092da2fb4"), "فيروزه", 8 },
                    { 219, new Guid("fedd00bb-e19b-4b47-87af-300c806ee175"), "فريمان", 8 },
                    { 218, new Guid("96320370-7ac1-4682-9339-970ec0606233"), "فرهاد گرد", 8 },
                    { 217, new Guid("556bd4a3-fa56-43f0-bda9-5e1d688da9f5"), "عشق آباد", 8 },
                    { 216, new Guid("6cbfe326-d05f-4172-ade1-536afc3a1c48"), "طرقبه", 8 },
                    { 215, new Guid("0ac8ab03-d4e9-4dde-b68b-f0190ade4cda"), "صالح آباد", 8 },
                    { 214, new Guid("38b56b00-25c0-42c8-9204-2fa3e45b07dc"), "شهرآباد", 8 },
                    { 213, new Guid("45cf2d32-ad3c-4761-bb64-19caed9c3e06"), "شهر زو", 8 },
                    { 212, new Guid("9d9c3917-9524-4f61-9d81-98df4d2a6b22"), "ششتمد", 8 },
                    { 210, new Guid("c429cbab-de99-4963-809a-339224424c7e"), "شادمهر", 8 },
                    { 227, new Guid("f7eb7ba9-fb67-4bfc-80f1-d65147662f25"), "مزدآوند", 8 },
                    { 191, new Guid("108594bb-edcf-4f20-a92d-b509511db790"), "جنگل", 8 },
                    { 189, new Guid("d2da7ab4-19ec-4bcc-8150-33773af11147"), "تربت حيدريه", 8 },
                    { 169, new Guid("eb2488e8-8888-4fba-baae-6729cf9c569b"), "نازک عليا", 7 },
                    { 168, new Guid("cf134a32-07a6-43b3-ba7f-f81e553a115f"), "ميرآباد", 7 },
                    { 167, new Guid("7512328e-004c-4ffd-a2e8-708300b459ad"), "مياندوآب", 7 },
                    { 166, new Guid("fffa0e7f-b77b-49ac-b01a-dd6022ba7e25"), "مهاباد", 7 },
                    { 165, new Guid("323fc35e-7691-4448-b252-41383e98ef7f"), "مرگنلر", 7 },
                    { 164, new Guid("b7b8f9cf-e980-4b95-9748-c0fb84ea060f"), "محمود آباد", 7 },
                    { 163, new Guid("f8180fa0-10f4-4ed8-a0a3-093f9635e29d"), "محمد يار", 7 },
                    { 162, new Guid("62542202-d691-4872-857a-6f0df5cd8704"), "ماکو", 7 },
                    { 161, new Guid("a59601a1-7f59-4b4a-838c-7aa646eb012a"), "قوشچي", 7 },
                    { 160, new Guid("86a10441-0b81-4721-b7fb-6d9c615a9f4f"), "قطور", 7 },
                    { 159, new Guid("33a3e72b-3f5a-42ec-a1d6-a9804a8a9fba"), "قره ضياء الدين", 7 },
                    { 158, new Guid("1754e6cd-d0b9-4153-a0b2-a7e8a5c5749f"), "فيرورق", 7 },
                    { 157, new Guid("4108d876-df6d-4df5-978c-c28907f63362"), "شوط", 7 },
                    { 156, new Guid("1553a7f9-fcc0-46e6-ae2c-f21aee8bc979"), "شاهين دژ", 7 },
                    { 155, new Guid("6c262b20-6b86-409b-97f8-f39adb6ccb68"), "سيه چشمه", 7 },
                    { 170, new Guid("9f26cf67-3b58-40d5-96cd-c09645271dd1"), "نالوس", 7 },
                    { 190, new Guid("d0a90b41-c0a4-4854-a069-89db6db7417e"), "جغتاي", 8 },
                    { 171, new Guid("8ca89f67-6284-46ad-89b7-33f89c59ea62"), "نقده", 7 },
                    { 173, new Guid("3dd02007-a17b-4c60-9654-c4abed511bcc"), "پلدشت", 7 },
                    { 188, new Guid("c3b1cc8e-698b-4d66-a322-649214683176"), "تربت جام", 8 },
                    { 187, new Guid("68ce7389-874f-4794-893e-d955e202f9b4"), "تايباد", 8 },
                    { 186, new Guid("5460d763-10d3-4dd9-9023-52e0a9d0364f"), "بيدخت", 8 },
                    { 185, new Guid("4979db9d-59c1-43b6-98fe-4e250339f6e3"), "بردسکن", 8 },
                    { 184, new Guid("87690ebb-7758-456d-b3ec-5b995f4dbb8d"), "بجستان", 8 },
                    { 183, new Guid("d48d9fbd-b632-41a7-9b13-5160a60136e9"), "بايک", 8 },
                    { 182, new Guid("ccc36e42-2627-49ed-9a85-84f58f21d396"), "بار", 8 },
                    { 181, new Guid("c9a54fe9-b392-4f6f-a924-8bdec02dab23"), "باخرز", 8 },
                    { 180, new Guid("9cec2ce0-6c2a-4fbb-92fa-7e89c6d945ca"), "باجگيران", 8 },
                    { 179, new Guid("e662c31a-e01c-4fb0-89d5-5188cae99a70"), "انابد", 8 },
                    { 178, new Guid("1eaf2be1-175d-4656-9d6a-410b4f0b5f59"), "احمدآباد صولت", 8 },
                    { 177, new Guid("22e491c6-b787-4128-8f5a-813bac923031"), "گردکشانه", 7 },
                    { 176, new Guid("f0b185a6-1a5d-4a7a-a270-4bc3cc8cd433"), "کشاورز", 7 },
                    { 175, new Guid("6830d863-37f3-4073-a9e5-0ba433c2a3c0"), "چهار برج", 7 },
                    { 174, new Guid("759f9ac5-2640-44ae-9bbe-053bfab72fe8"), "پيرانشهر", 7 },
                    { 172, new Guid("891f49eb-4c86-409f-90a7-d7abe1a6d7ae"), "نوشين", 7 },
                    { 228, new Guid("29a3f92a-194c-43a7-9a6f-cd880b14fd8d"), "مشهد", 8 },
                    { 229, new Guid("52250871-3775-4533-ae58-dd3317389f60"), "مشهدريزه", 8 },
                    { 230, new Guid("4b080318-d01b-43cb-bd83-1fb1d4bc121f"), "ملک آباد", 8 },
                    { 284, new Guid("5dca8b34-06b5-4cd3-ab3a-a26cfb571f4e"), "کنارک", 9 },
                    { 283, new Guid("7467b23f-4082-4836-aacc-68c5b36599bc"), "چاه بهار", 9 },
                    { 282, new Guid("64389c15-6cde-4cb8-b183-dd4083275432"), "پيشين", 9 },
                    { 281, new Guid("e393541d-6c18-40dd-80f9-349105dc684b"), "هيدوچ", 9 },
                    { 280, new Guid("b06839e8-e1da-4be5-80e4-cd96600a2842"), "نگور", 9 },
                    { 279, new Guid("0c359227-9eda-4833-bfcb-0de578a685cc"), "نيک شهر", 9 },
                    { 278, new Guid("bd461223-749b-4e92-aec0-29991b5ccf93"), "نوک آباد", 9 },
                    { 277, new Guid("6f5d5e16-0c92-42cb-b2a9-6dc3e811a570"), "نصرت آباد", 9 },
                    { 276, new Guid("235b52ec-31d4-4728-ba2f-d80690e63129"), "ميرجاوه", 9 },
                    { 275, new Guid("439f1092-b941-48da-85bd-c4987cf9c14d"), "مهرستان", 9 },
                    { 274, new Guid("8f290849-0214-4005-a341-e7cd6188668a"), "محمدي", 9 },
                    { 273, new Guid("7efe6b48-4751-494f-a497-9d1202f343e0"), "محمدان", 9 },
                    { 272, new Guid("17f22547-ebe6-456e-bed3-bd9fe0bd722d"), "محمد آباد", 9 },
                    { 271, new Guid("28bec937-ae5a-4a23-b20c-e14ebafcc019"), "قصر قند", 9 },
                    { 270, new Guid("795d64e3-f2e2-4770-bde1-d562b43ce3c7"), "فنوج", 9 },
                    { 285, new Guid("f96684e8-8a73-473d-9e38-69ff033cb276"), "گشت", 9 },
                    { 269, new Guid("91e41bd0-643f-4793-98cf-d565603fd3bf"), "علي اکبر", 9 },
                    { 286, new Guid("c7a8d250-8bed-454f-bee0-561d1af14f58"), "گلمورتي", 9 },
                    { 288, new Guid("fc9c2d24-a2e3-4f3e-b1c3-cf997b0eacdb"), "آيسک", 10 },
                    { 303, new Guid("5f373ae3-9aea-44ad-a9cb-42600d13db61"), "شوسف", 10 },
                    { 302, new Guid("b788039a-ac3d-4ef1-81e8-1ca86b563f17"), "سه قلعه", 10 },
                    { 301, new Guid("6d5ffb15-833d-4754-b3d5-9e2e5822074b"), "سربيشه", 10 },
                    { 300, new Guid("a3065d26-7884-413a-9b41-b575edf2a576"), "سرايان", 10 },
                    { 299, new Guid("3b096f73-49e0-45de-a7e1-59c9959e1741"), "زهان", 10 },
                    { 298, new Guid("c91af6b3-a068-40ff-ae8c-76ea58ddd909"), "ديهوک", 10 },
                    { 1241, new Guid("e65af01c-f54f-4f8f-8b74-f65f15d6f6b9"), "گراب سفلي", 31 },
                    { 296, new Guid("06cd9290-8dc8-4ad1-9e4a-3e8212dc8551"), "خضري دشت بياض", 10 },
                    { 295, new Guid("dc466fac-81de-47be-a5af-bf3095a74179"), "حاجي آباد", 10 },
                    { 294, new Guid("85b80396-741e-4ee6-9c2a-7b0eac033db2"), "بيرجند", 10 },
                    { 293, new Guid("d0a2f42c-8b16-43c5-8d00-b04f2aea687a"), "بشرويه", 10 },
                    { 292, new Guid("ec429044-291b-48f4-bd38-272bb0e2a079"), "اسلاميه", 10 },
                    { 291, new Guid("9d7a7b63-c3ec-42c4-a88c-464b993c96ba"), "اسفدن", 10 },
                    { 290, new Guid("ec74cd24-e204-4c76-9dd9-57d52f498eb3"), "اسديه", 10 },
                    { 289, new Guid("d6a39182-3f0e-4572-888c-24dae32d3916"), "ارسک", 10 },
                    { 287, new Guid("2deb6fc7-cf29-4d26-b16a-ddf7c6a75650"), "آرين شهر", 10 },
                    { 268, new Guid("6fea83f4-4373-4c0f-826f-4bb2aafdfc12"), "سيرکان", 9 },
                    { 267, new Guid("d26ee731-2446-4f19-98c3-11fca0765a5d"), "سوران", 9 },
                    { 266, new Guid("4bafea02-b93e-4073-afe9-fdbd643c96fe"), "سرباز", 9 },
                    { 245, new Guid("92b536ee-8c64-4daa-988f-e1eb3e7a62a5"), "کدکن", 8 },
                    { 244, new Guid("6862b14b-56a1-4a52-b1c5-a9e0b6f370bf"), "کاشمر", 8 },
                    { 243, new Guid("94b6ba8b-08d6-418e-863f-f65c064c7f58"), "کاريز", 8 },
                    { 242, new Guid("d8856bc1-d5a3-49bd-9dbf-31067aa8ce08"), "کاخک", 8 },
                    { 241, new Guid("8637e97f-f5cb-42dc-85eb-fb4a84aae614"), "چکنه", 8 },
                    { 240, new Guid("2391333f-8879-413b-9a97-1159e8bfc802"), "چناران", 8 },
                    { 239, new Guid("681e5e2a-6eb4-4fec-8be3-a17d6b5d2b64"), "چاپشلو", 8 },
                    { 238, new Guid("983fea73-793b-425f-819e-586cc0c67a75"), "يونسي", 8 },
                    { 237, new Guid("42523a25-b0ff-4a08-bc84-32a126bec526"), "همت آباد", 8 },
                    { 236, new Guid("15c7ea68-bf69-4a22-a278-27810a2dd79a"), "نيل شهر", 8 },
                    { 235, new Guid("397b78a8-9f6e-4aba-afde-70fe6c1dc05c"), "نيشابور", 8 },
                    { 234, new Guid("a3283916-7957-4943-8c2c-3b6adc9718cd"), "نوخندان", 8 },
                    { 233, new Guid("688add27-e034-4c43-bd4c-359a61c6d46c"), "نقاب", 8 },
                    { 232, new Guid("f31ac92e-e1dd-4099-b224-47de9fa5a098"), "نصرآباد", 8 },
                    { 231, new Guid("0e7db68a-3c63-4a8f-8d4e-ceb77378cdd5"), "نشتيفان", 8 },
                    { 246, new Guid("6a2e1ef8-bda5-438a-ac67-aa272799bff7"), "کلات", 8 },
                    { 247, new Guid("233a5c6e-a8d8-4a9d-bbb8-63f94cd634ff"), "کندر", 8 },
                    { 248, new Guid("3936843f-13df-4144-95d7-84e6a00eddfe"), "گلمکان", 8 },
                    { 249, new Guid("f3e1c51f-72a9-48e2-bac6-a70239229e8c"), "گناباد", 8 },
                    { 265, new Guid("e6c4c3ef-d7fd-4699-9416-859ce304acb4"), "سراوان", 9 },
                    { 264, new Guid("b3a8e826-2e8d-48f5-b88b-0c23d5812f41"), "زهک", 9 },
                    { 263, new Guid("93f4ded9-1e31-4cb3-9509-d38686493659"), "زرآباد", 9 },
                    { 262, new Guid("f5883b38-258a-4247-9a05-6f1aedba2afd"), "زاهدان", 9 },
                    { 261, new Guid("73ae36b1-8ab8-4b9a-a50a-1e1143e4f6fd"), "زابل", 9 },
                    { 260, new Guid("d4bd3c1e-e960-4930-8a40-0964abecd5f1"), "راسک", 9 },
                    { 259, new Guid("64bc9dca-fd9a-42eb-ad15-f55a3546f1a0"), "دوست محمد", 9 },
                    { 154, new Guid("e6d6ebbe-250c-4595-b7c2-4e076042ec34"), "سيمينه", 7 },
                    { 258, new Guid("95b0b59d-b10d-49ec-9498-686f7205fd93"), "خاش", 9 },
                    { 256, new Guid("7016b0c4-139c-459f-8dff-d48e5febf70c"), "بنجار", 9 },
                    { 255, new Guid("15fc655a-6e25-4e41-9913-51dedc185318"), "بنت", 9 },
                    { 254, new Guid("f0d20971-1b2a-4ebd-b8f6-263eae1f2426"), "بمپور", 9 },
                    { 253, new Guid("1ce246ed-5859-45c5-a3a9-cee321d3b6fa"), "بزمان", 9 },
                    { 252, new Guid("7084e3fb-ccbf-44a8-ae24-aefc3796c3ad"), "ايرانشهر", 9 },
                    { 251, new Guid("c6efbe6e-bb8e-4dde-92fe-cbda4b32e285"), "اسپکه", 9 },
                    { 250, new Guid("3dee0716-efcc-485e-91b2-9d08df4e204c"), "اديمي", 9 },
                    { 257, new Guid("a89676a2-58c9-4adc-a999-3948b6de876b"), "جالق", 9 },
                    { 153, new Guid("22a56793-79ba-4da9-94c1-18a71b5bd451"), "سيلوانه", 7 },
                    { 152, new Guid("96a8ea0a-9aa8-4847-8a5a-84b6d192647b"), "سلماس", 7 },
                    { 151, new Guid("1979b84a-1d0e-43f2-bff7-2e2e7701f6a1"), "سرو", 7 },
                    { 54, new Guid("1ca476bc-adee-405a-af46-e2f9ccd069fe"), "پردنجان", 2 },
                    { 53, new Guid("6c124719-ddea-4639-bd57-f3695ba2d92f"), "وردنجان", 2 },
                    { 52, new Guid("7171c57a-fc24-4e4e-b970-080d2a6648c9"), "هفشجان", 2 },
                    { 51, new Guid("55dc9d07-081e-44f9-8db8-0d08b48e8477"), "هاروني", 2 },
                    { 50, new Guid("0e346264-1d1b-48a4-97bb-3b42675f7131"), "نقنه", 2 },
                    { 49, new Guid("4e999862-ffd5-449e-aef6-107f07c4f735"), "نافچ", 2 },
                    { 48, new Guid("dd944e64-1d63-4907-9581-ca5ab693b94a"), "ناغان", 2 },
                    { 47, new Guid("bc44dbc8-1499-46db-a208-ebd84aafe917"), "منج", 2 },
                    { 46, new Guid("9787453a-f7b3-429c-b9e4-a43576bd1103"), "مال خليفه", 2 },
                    { 45, new Guid("85061b31-27a1-4a80-97a6-600eb1b71460"), "لردگان", 2 },
                    { 44, new Guid("23752603-d8b1-4719-b323-e90a1661a6b1"), "فرخ شهر", 2 },
                    { 43, new Guid("40d7e0ba-a6fe-4e7a-a3b1-3734cdedef5f"), "فرادنبه", 2 },
                    { 42, new Guid("1ad4b861-86b5-4168-93f2-33a350035f2b"), "فارسان", 2 },
                    { 41, new Guid("8141a9c7-d3e3-4fce-812e-f5e71b634c78"), "طاقانک", 2 },
                    { 40, new Guid("d8134016-b95e-42de-ad0e-cc2ee25bdec1"), "صمصامي", 2 },
                    { 55, new Guid("ff5cba48-c43d-4164-8aaf-2ef2235da217"), "چليچه", 2 },
                    { 39, new Guid("fc387e58-7c1d-487e-8113-d5144e142ec7"), "شهرکرد", 2 },
                    { 56, new Guid("4dc6853c-aa94-4b92-b065-9b60aa3db7d2"), "چلگرد", 2 },
                    { 58, new Guid("a4a0d93a-dc0a-493c-9b75-69a3887e8948"), "کيان", 2 },
                    { 73, new Guid("afa125e3-13a2-4a65-b795-00afdb0b4321"), "سنخواست", 3 },
                    { 72, new Guid("6da6ee64-128d-4ae0-8196-6208495a9e84"), "زيارت", 3 },
                    { 71, new Guid("005d1e5f-a1d1-4ea4-8725-427429eabfc8"), "راز", 3 },
                    { 70, new Guid("9f905362-bd30-491e-b844-1f7cea32cda4"), "درق", 3 },
                    { 69, new Guid("0d718620-64b7-434a-9131-e549668a5235"), "حصارگرمخان", 3 },
                    { 68, new Guid("5ac0090e-00d9-4217-ab51-25f541513a09"), "جاجرم", 3 },
                    { 67, new Guid("7cb03fef-ee19-4863-82dd-1ac67a7100fe"), "تيتکانلو", 3 },
                    { 66, new Guid("80af9007-52d0-45cb-ab51-009c9b927b88"), "بجنورد", 3 },
                    { 65, new Guid("69ca0be8-dbb6-488a-bd82-45baf88aeaab"), "ايور", 3 },
                    { 64, new Guid("ad44c5ec-e52d-4b30-a72a-85c03fcda325"), "اسفراين", 3 },
                    { 63, new Guid("d6dd3742-87d4-4afc-8d4a-01cd347ba76e"), "آوا", 3 },
                    { 62, new Guid("af510fbf-e8d1-4650-b626-704c4c49976a"), "آشخانه", 3 },
                    { 61, new Guid("e4f23d16-aff7-4ff4-b5f8-9f7a0dd8ed69"), "گوجان", 2 },
                    { 60, new Guid("987a01ed-f26b-4242-8744-37d28e31a64c"), "گهرو", 2 },
                    { 59, new Guid("2c0e60cc-6305-469a-807b-652b48a6195f"), "گندمان", 2 },
                    { 57, new Guid("2348c882-1a59-4d62-9534-d4ad1efb8e06"), "کاج", 2 },
                    { 38, new Guid("271d9435-3bf5-4873-b56d-826955b0fe89"), "شلمزار", 2 },
                    { 37, new Guid("4ef55ec7-fc9f-48f3-987c-cd882111353d"), "سورشجان", 2 },
                    { 36, new Guid("21c0e858-61bb-4a41-b463-8544b86b8b7f"), "سودجان", 2 },
                    { 15, new Guid("caade28d-2d9c-437d-ac70-224acbb194b6"), "مهردشت", 1 },
                    { 14, new Guid("494da5a6-9334-417a-b140-c0c592d7aaac"), "مروست", 1 },
                    { 13, new Guid("db62f62d-29d7-444f-b74d-561d91980d29"), "عقدا", 1 },
                    { 12, new Guid("d5ccd0d2-c1fa-439d-a87a-6009113914ef"), "شاهديه", 1 },
                    { 11, new Guid("ca84ec53-7626-4045-8686-67a03935dd89"), "زارچ", 1 },
                    { 10, new Guid("920b4d1c-fa09-424f-b61b-74fde321a258"), "خضر آباد", 1 },
                    { 9, new Guid("16c9098d-546b-4560-aafd-e0b9f37fd35f"), "حميديا", 1 },
                    { 8, new Guid("dc4494ad-16ba-447a-af97-8168fcb9a5e3"), "تفت", 1 },
                    { 7, new Guid("38975418-c99a-49d0-8637-09e4e2a49b28"), "بهاباد", 1 },
                    { 6, new Guid("d0b681b0-2fe1-405c-8162-04cc306ccb26"), "بفروئيه", 1 },
                    { 5, new Guid("b358b511-1d87-4b31-9cb4-71dc4d0b6a16"), "بافق", 1 },
                    { 4, new Guid("49320f47-248b-43fd-8fe2-874410a4ea98"), "اشکذر", 1 },
                    { 3, new Guid("06dc90d2-f46f-417f-859a-1129b3a3c483"), "اردکان", 1 },
                    { 2, new Guid("6e2ee37a-6c02-43d0-8a88-4cd78d0de9f8"), "احمد آباد", 1 },
                    { 1, new Guid("9c01330d-0e06-4e3a-bcef-977055a4273c"), "ابرکوه", 1 },
                    { 16, new Guid("8c0be99f-585c-4ce0-b5a4-093942ee739d"), "مهريز", 1 },
                    { 17, new Guid("02c4333f-4848-439f-97f0-201a3cde09a9"), "ميبد", 1 },
                    { 18, new Guid("285b6a72-a2cd-4065-8277-df695b55ef33"), "ندوشن", 1 },
                    { 19, new Guid("2ff646db-e06e-4dc7-a898-daa1ff9ebe9f"), "نير", 1 },
                    { 35, new Guid("eb76c344-50eb-42de-b579-db4621f73e34"), "سفيد دشت", 2 },
                    { 34, new Guid("f9eefc78-c176-451e-97ce-618bf502a128"), "سردشت لردگان", 2 },
                    { 33, new Guid("739f44d0-9da8-4667-a44e-9f09668fccd6"), "سرخون", 2 },
                    { 32, new Guid("f0cf5a18-3b5a-4305-965d-9f30b2f98891"), "سامان", 2 },
                    { 31, new Guid("112ae6f6-2b66-4bb6-a7a0-514cb564624a"), "دشتک", 2 },
                    { 30, new Guid("9e0dad69-be1e-4875-bf91-97bcaf4abeb2"), "دستناء", 2 },
                    { 29, new Guid("021b1a70-9033-44af-ae65-cdd9a50c18d8"), "جونقان", 2 },
                    { 74, new Guid("d11bad1d-72e6-42fd-8be4-8048df0ed968"), "شوقان", 3 },
                    { 28, new Guid("c895dd5c-c7ce-40f0-864b-d8817a33f7c6"), "بن", 2 },
                    { 26, new Guid("d043b490-3723-40d3-9c9c-c7fd105b4225"), "بروجن", 2 },
                    { 25, new Guid("25c14709-1f8d-43bf-8727-573ffac57f61"), "بازفت", 2 },
                    { 24, new Guid("801d43a4-80ee-4c3f-aabb-a6b3ea66fd02"), "باباحيدر", 2 },
                    { 23, new Guid("7d92c222-a4cd-4caa-84fc-059daa92269c"), "اردل", 2 },
                    { 22, new Guid("3b5300ee-9d29-4e82-b6c9-e21be7536202"), "آلوني", 2 },
                    { 21, new Guid("caf8eb65-fee6-411d-813a-28159283dae0"), "يزد", 1 },
                    { 20, new Guid("dc028569-fae4-4ae7-b5a3-150b7daa63dd"), "هرات", 1 },
                    { 27, new Guid("9428df4a-6fa6-4476-8344-8b69eb4f529c"), "بلداجي", 2 },
                    { 304, new Guid("e53eb754-3bb1-4023-822b-83b5f3ddd72c"), "طبس", 10 },
                    { 75, new Guid("0c6d18bf-85b0-473f-a7d0-6c131d37c66a"), "شيروان", 3 },
                    { 77, new Guid("c9b76bfc-ee6a-4b9e-be04-dc62a41f51ac"), "فاروج", 3 },
                    { 131, new Guid("72d4be50-1fd0-4477-b5b9-e2742aec8ebb"), "پيرتاج", 6 },
                    { 130, new Guid("0e325554-7be6-42c9-af9f-00d0bbd1854c"), "ياسوکند", 6 },
                    { 129, new Guid("cef46dab-c913-4982-9c63-73c8a0528b11"), "موچش", 6 },
                    { 128, new Guid("55ac1b97-8d3a-41cd-9931-3d97af363289"), "مريوان", 6 },
                    { 127, new Guid("6db878a7-358e-4523-a64d-02d13b0ba536"), "قروه", 6 },
                    { 126, new Guid("ab255a5b-0623-4397-9399-42e5b6e11c3c"), "صاحب", 6 },
                    { 125, new Guid("882bb73e-08e4-472e-9259-ea7227a3ea37"), "شويشه", 6 },
                    { 124, new Guid("fd0e3e7a-a36d-466a-a471-3bbf25e408c7"), "سنندج", 6 },
                    { 123, new Guid("b40e92c0-1e81-4d88-80e6-3d1114250eee"), "سقز", 6 },
                    { 122, new Guid("47c41d58-df5b-49ab-b366-f12f06a92b51"), "سريش آباد", 6 },
                    { 121, new Guid("06c3593f-98bf-4b9d-80c3-007b0b14f114"), "سرو آباد", 6 },
                    { 120, new Guid("4e42c2ca-e0e5-422f-8fed-c077018420d5"), "زرينه", 6 },
                    { 119, new Guid("8e788ec9-fe3f-441a-8659-afc51b9ca046"), "ديواندره", 6 },
                    { 118, new Guid("8909b2b8-03f4-4b3d-90b7-5f812bf28d84"), "دهگلان", 6 },
                    { 117, new Guid("7a528f12-c8ea-4ed6-8f0d-4a739ebbb839"), "دلبران", 6 },
                    { 132, new Guid("0c9440a2-58e4-4ee0-9e3b-a28b6d634376"), "چناره", 6 },
                    { 116, new Guid("0c0ee3a4-08bb-4d07-a322-cb4860db3420"), "دزج", 6 },
                    { 133, new Guid("462ac0f6-160c-4d1e-89c4-db4e82af93b1"), "کامياران", 6 },
                    { 135, new Guid("351e4925-a387-4d07-a4ca-96cbc33e23a3"), "کاني سور", 6 },
                    { 150, new Guid("63ba2ce6-0956-432e-848b-685545b7ca26"), "سردشت", 7 },
                    { 149, new Guid("739ba8ee-69c2-4afe-9bcf-3e0af6203744"), "زرآباد", 7 },
                    { 148, new Guid("16c7900d-6797-439e-bb4a-950221329f66"), "ربط", 7 },
                    { 147, new Guid("4d88ebf4-f9eb-4fa5-9dd6-8e4ebf631dc8"), "ديزج ديز", 7 },
                    { 146, new Guid("cb96bcae-c909-4cc7-8bdc-714f2610f3a3"), "خوي", 7 },
                    { 145, new Guid("2e566914-b950-4d9c-becf-356b9499bb9c"), "خليفان", 7 },
                    { 144, new Guid("104b330a-e728-45e7-b4c3-ad3d999baa11"), "تکاب", 7 },
                    { 143, new Guid("7ad87c2b-8fdd-46fd-8352-915ce94ccee1"), "تازه شهر", 7 },
                    { 142, new Guid("a6b79dfe-fa4d-4533-b2e9-ac48c9f86c79"), "بوکان", 7 },
                    { 141, new Guid("d280e441-2cfc-4c7e-9996-2f93d5626376"), "بازرگان", 7 },
                    { 140, new Guid("2b7d7cc0-ecd7-40fb-8cda-df693832e8ed"), "باروق", 7 },
                    { 139, new Guid("b74e0408-6ad6-45f2-a1a8-4dbf2673e9b7"), "ايواوغلي", 7 },
                    { 138, new Guid("c4098e5b-293a-4292-91b8-132c2a36f7a6"), "اشنويه", 7 },
                    { 137, new Guid("e88baa42-1068-4aed-9100-09205077ba13"), "اروميه", 7 },
                    { 136, new Guid("806e9405-2802-4f1c-8c12-f42400db55b3"), "آواجيق", 7 },
                    { 134, new Guid("eccaf200-64a9-447a-9707-78d78c06ace1"), "کاني دينار", 6 },
                    { 115, new Guid("54a6d608-b54f-4f55-877a-730ef226cb64"), "توپ آغاج", 6 },
                    { 114, new Guid("cc26027d-0e62-425a-ae82-cef567492a3a"), "بيجار", 6 },
                    { 113, new Guid("644d2b2f-3961-48a2-9d8a-357f70993cbd"), "بوئين سفلي", 6 },
                    { 92, new Guid("1805a52c-4ba9-4e5e-a49b-dc82fd1e664f"), "مشکين دشت", 4 },
                    { 91, new Guid("20af44de-9356-466d-9351-d191d7b12990"), "محمد شهر", 4 },
                    { 90, new Guid("e6560ed6-ef40-4b3c-8b63-31b580e7dee1"), "ماهدشت", 4 },
                    { 89, new Guid("a87a595c-cbe5-40f5-bc88-942c9e1daa50"), "فرديس", 4 },
                    { 88, new Guid("65b9b842-bfb6-41aa-b10d-e107378b38e0"), "طالقان", 4 },
                    { 87, new Guid("299faa08-3fae-4762-b71a-2cdb75e90516"), "شهر جديد هشتگرد", 4 },
                    { 86, new Guid("b4dc87e1-ac4b-4067-b431-d745cb9ddc0c"), "تنکمان", 4 },
                    { 85, new Guid("45029b19-9deb-45fc-839a-ac509dbf4ae7"), "اشتهارد", 4 },
                    { 84, new Guid("e5b4d8b1-94c8-46f7-a6c2-c0ce4ff85824"), "آسارا", 4 },
                    { 83, new Guid("cf445b40-8e88-4f7c-aed6-6cbfd7b0a1b1"), "گرمه", 3 },
                    { 82, new Guid("294bd486-d10f-4b8f-9a9e-7f020a283025"), "چناران شهر", 3 },
                    { 81, new Guid("dcd9bf48-43cc-4f1e-822e-fde34071b791"), "پيش قلعه", 3 },
                    { 80, new Guid("55f1c162-2e75-4a4b-9858-4d77de6761b8"), "لوجلي", 3 },
                    { 79, new Guid("ece72a50-b848-4686-a7df-82af77c0f26a"), "قوشخانه", 3 },
                    { 78, new Guid("d5d28a25-2180-4e5b-be77-51221b0437a9"), "قاضي", 3 },
                    { 93, new Guid("91b701a2-00c7-4b86-b14c-663c7c4cbd36"), "نظر آباد", 4 },
                    { 94, new Guid("24a9cf42-452b-49b8-a8a0-4a7dc1176751"), "هشتگرد", 4 },
                    { 95, new Guid("a6967f58-85e7-46d5-a864-e2266ac24518"), "چهارباغ", 4 },
                    { 96, new Guid("d9f48e04-dfb5-4304-ad01-a7b789331000"), "کرج", 4 },
                    { 112, new Guid("b70167c8-930a-403f-a846-99adcf7b14e2"), "بلبان آباد", 6 },
                    { 111, new Guid("365e500a-f41a-4e17-b9e2-73176f901c6f"), "برده رشه", 6 },
                    { 110, new Guid("a23090d5-7f8c-4071-9ef5-7b2f6b001d94"), "بانه", 6 },
                    { 109, new Guid("bd234225-927d-4c5f-ac60-cc953ec218f0"), "بابارشاني", 6 },
                    { 108, new Guid("8616ff97-0e67-494a-800e-e6aefb17322a"), "اورامان تخت", 6 },
                    { 107, new Guid("e5d7f067-6195-4a17-806a-c2d708e3c066"), "آرمرده", 6 },
                    { 106, new Guid("d15d3392-5da8-4788-86a7-29dedc562725"), "کهک", 5 },
                    { 76, new Guid("e1de1d6e-70e0-4bf0-858c-ae61c868da48"), "صفي آباد", 3 },
                    { 105, new Guid("9abb8d12-674f-4e5e-8e5f-0e137d5c71c9"), "قنوات", 5 },
                    { 103, new Guid("09744936-0cdc-461f-8753-f24f59285ccf"), "سلفچگان", 5 },
                    { 102, new Guid("bd4b53e1-8fb7-4685-b535-7c0fa0b2c7ce"), "دستجرد", 5 },
                    { 101, new Guid("7ebf5291-7609-403e-a41c-296b97f54e13"), "جعفريه", 5 },
                    { 100, new Guid("5535d5c5-9eef-440b-9d6a-87dd60d21eaf"), "گلسار", 4 },
                    { 99, new Guid("706d0aab-ec91-4bfa-a439-c5e049fd31e7"), "گرمدره", 4 },
                    { 98, new Guid("3af4ead9-4698-4d1f-a275-e5b1a20e974c"), "کوهسار", 4 },
                    { 97, new Guid("04355bc8-5243-48cd-93d4-23ebc97ccfb2"), "کمال شهر", 4 },
                    { 104, new Guid("f38701b8-3a43-4066-9d10-7d7189ffc357"), "قم", 5 },
                    { 305, new Guid("cf0bb75f-d6aa-42e8-be0a-58fefbd2b71f"), "طبس مسينا", 10 },
                    { 297, new Guid("9940fa76-5399-4954-a1b7-7017b3ccb542"), "خوسف", 10 },
                    { 307, new Guid("8f1d04f0-c8ef-4a1a-9085-f7c12ce2fb05"), "فردوس", 10 },
                    { 514, new Guid("0b524268-117a-4d60-8067-f1e68cf56ff1"), "نشتارود", 15 },
                    { 513, new Guid("a641ab21-a1a8-4c6b-9be4-3dbc0dfe4bf8"), "مرزيکلا", 15 },
                    { 512, new Guid("39c2ba58-e1a6-44ad-9f98-0770e35d917c"), "مرزن آباد", 15 },
                    { 511, new Guid("4999cd98-6eba-4e3c-a572-e59920e42229"), "محمود آباد", 15 },
                    { 510, new Guid("2d6a1976-010b-4485-949c-119626235ad2"), "قائم شهر", 15 },
                    { 509, new Guid("bd7aeba8-a874-424c-85a2-2aca52926caa"), "فريم", 15 },
                    { 508, new Guid("da83ebcc-27aa-4e8e-aa0d-df92194f3faa"), "فريدونکنار", 15 },
                    { 507, new Guid("952d7ccf-cec4-4da9-860a-24b62ccf2d33"), "عباس آباد", 15 },
                    { 506, new Guid("c4394bab-b576-4cfc-ac7f-6d52e10cc7a1"), "شيرگاه", 15 },
                    { 505, new Guid("89007eff-57c6-4308-a966-d4a35ba4e9d6"), "شيرود", 15 },
                    { 504, new Guid("750259fd-f735-42d2-a56a-17a5a0f462c7"), "سورک", 15 },
                    { 503, new Guid("bbc3f5fa-6891-4cb2-bf00-6df0365bfea5"), "سلمان شهر", 15 },
                    { 502, new Guid("17a876e1-3143-45c7-8577-cf0d48db8292"), "سرخرود", 15 },
                    { 501, new Guid("fb6aa93e-ce40-47ad-9aea-4d30dc51cf5b"), "ساري", 15 },
                    { 500, new Guid("e01545e6-242f-45be-b259-84d8a40d1add"), "زيرآب", 15 },
                    { 515, new Guid("db636f29-cbd4-41c4-962e-5930309cb407"), "نور", 15 },
                    { 499, new Guid("7654e85c-90bf-4e10-bb00-d487f3a9a498"), "زرگر محله", 15 },
                    { 516, new Guid("6625f58c-2f98-4760-a46b-a1d3619ea17f"), "نوشهر", 15 },
                    { 518, new Guid("a999f9b0-e559-4945-9d33-0dc4ae3d9ef0"), "هادي شهر", 15 },
                    { 533, new Guid("2b6f7f24-71b7-4f08-bfb5-c009ad9c2b65"), "گزنک", 15 },
                    { 532, new Guid("c4885c13-1de9-47ae-8c7c-1753eeb7adf2"), "گتاب", 15 },
                    { 531, new Guid("004714c6-330f-48ee-a2a4-7b133c1a57e3"), "کياکلا", 15 },
                    { 530, new Guid("d3d5a9ad-1ff2-4faf-87b8-5819e9447af5"), "کياسر", 15 },
                    { 529, new Guid("60db61d8-35a6-42e7-a888-91b04f2e47f2"), "کوهي خيل", 15 },
                    { 528, new Guid("7b10d001-f7dc-416c-bded-dd5df8b5431f"), "کلاردشت", 15 },
                    { 527, new Guid("4fcc152d-8db0-40ec-8e33-5124e24b1122"), "کلارآباد", 15 },
                    { 526, new Guid("2ae79b4d-2aa0-4baf-8320-717c563f702c"), "کجور", 15 },
                    { 525, new Guid("745c9c77-8330-4ff6-9a25-09cd257d938c"), "کتالم و سادات شهر", 15 },
                    { 524, new Guid("dbb2697b-deb4-4f05-8764-de0fd244d248"), "چمستان", 15 },
                    { 523, new Guid("923c5661-a965-4d98-a145-b60d9ca0ec0f"), "چالوس", 15 },
                    { 522, new Guid("1597154b-47e4-4f34-af3f-f23f7fb2025c"), "پول", 15 },
                    { 521, new Guid("f8fee01e-8d0c-4e34-a724-73d55edbc663"), "پل سفيد", 15 },
                    { 520, new Guid("95cdc14a-55e7-48a4-9677-cb479813029b"), "پايين هولار", 15 },
                    { 519, new Guid("ba5db523-013d-4cba-b1fc-8084d8490fcc"), "هچيرود", 15 },
                    { 517, new Guid("4c516d3e-b5fa-4ff9-bd8b-e92f4ea0abf8"), "نکا", 15 },
                    { 534, new Guid("f3685ae7-c094-4c81-b145-08bae0f2ba52"), "گلوگاه", 15 },
                    { 498, new Guid("31467aa6-5d8b-4561-83f0-e13e2683fbd0"), "رينه", 15 },
                    { 496, new Guid("d70a7529-fa59-4550-81b6-99c06c1d95e2"), "رستمکلا", 15 },
                    { 476, new Guid("6246f2fe-d4ab-4655-b0e4-a27a4ec5f0d7"), "گميش تپه", 14 },
                    { 475, new Guid("d4f87cd9-1001-45ae-9828-09ce08feaf88"), "گرگان", 14 },
                    { 474, new Guid("5b4c80fb-1a35-4b64-88a9-c051b22a84fa"), "گاليکش", 14 },
                    { 473, new Guid("f7d04b26-4992-4d67-89f1-2f5caf428c16"), "کلاله", 14 },
                    { 472, new Guid("08d27149-bd2f-4abd-91c3-46a62f9115cd"), "کرد کوي", 14 },
                    { 471, new Guid("0296efd7-6ef0-4c0a-a900-35b1fb9f0b90"), "نگين شهر", 14 },
                    { 470, new Guid("d2b37253-7731-4ddb-a0f2-7a0d2f393e26"), "نوکنده", 14 },
                    { 469, new Guid("ef32c119-0a8f-430f-ab0f-4441145068a2"), "نوده خاندوز", 14 },
                    { 306, new Guid("df40771a-568c-444a-bca9-d2cb0e092ea3"), "عشق آباد", 10 },
                    { 467, new Guid("9524fecc-e3a9-41e7-a9b7-c8744330292d"), "مزرعه", 14 },
                    { 466, new Guid("b8c1b20a-f0f1-4f16-9ea2-48c3a7ef9685"), "مراوه تپه", 14 },
                    { 465, new Guid("3b4a7856-7d09-4b03-bbcf-9a50d5187aa8"), "فراغي", 14 },
                    { 464, new Guid("af0638bb-b11a-4903-80ea-a196282fd6fd"), "فاضل آباد", 14 },
                    { 463, new Guid("745158c7-80db-4b98-9f0b-6ff15e2a7809"), "علي آباد", 14 },
                    { 462, new Guid("dafda3cf-694a-4fa4-9d38-56edbcdb56c7"), "سيمين شهر", 14 },
                    { 477, new Guid("eacdb3e8-9c01-4845-a0ff-3cbfcbfba89a"), "گنبدکاووس", 14 },
                    { 497, new Guid("3142c279-360a-4e78-b025-102569d84b31"), "رويان", 15 },
                    { 478, new Guid("f2ec0fb6-f097-4221-af4b-d19f449a6acf"), "آلاشت", 15 },
                    { 480, new Guid("3210a87e-1da8-4962-af09-47681143527d"), "ارطه", 15 },
                    { 495, new Guid("b7aa3441-4310-425e-a2cf-6116ab496651"), "رامسر", 15 },
                    { 494, new Guid("6f0b9ea5-c9b2-4f21-b0af-cad8a101c0f9"), "دابودشت", 15 },
                    { 493, new Guid("8620a711-1ed2-4980-be94-370612702f9b"), "خوش رودپي", 15 },
                    { 492, new Guid("7a8eb64f-f1e4-42dd-aca5-fb6baed87d30"), "خليل شهر", 15 },
                    { 491, new Guid("bb516e61-f390-40a7-bd22-1577849243dc"), "خرم آباد", 15 },
                    { 490, new Guid("f9f1e50a-bc2d-41aa-a369-003efc81b985"), "جويبار", 15 },
                    { 489, new Guid("7b9fa50d-04e1-470f-a643-679cda2f4ac8"), "تنکابن", 15 },
                    { 488, new Guid("3512ebea-fa0d-4746-a31c-631f1d9a3d92"), "بهنمير", 15 },
                    { 487, new Guid("1c003bce-2340-4748-8928-0495349fb26e"), "بهشهر", 15 },
                    { 486, new Guid("c9005897-6fcc-49bc-8630-e591a276d28e"), "بلده", 15 },
                    { 485, new Guid("6e47ffb3-7e45-408a-93eb-b3a47fc385bc"), "بابلسر", 15 },
                    { 484, new Guid("f033020f-3664-4f16-8331-00aa43ff855f"), "بابل", 15 },
                    { 483, new Guid("f4aee4e7-b5b6-4392-a4f8-8aab281a9059"), "ايزد شهر", 15 },
                    { 482, new Guid("848989ea-9945-4959-a102-3cc6d9aac045"), "امير کلا", 15 },
                    { 481, new Guid("50f097f3-4c8f-4050-a35f-8d966ccfcef3"), "امامزاده عبدالله", 15 },
                    { 479, new Guid("817f0c64-3123-4e9e-bd36-bb537d042b21"), "آمل", 15 },
                    { 535, new Guid("2546c910-dc83-4869-a031-cbd49c401616"), "آبيک", 16 },
                    { 536, new Guid("ec21165e-1eb8-4841-95e3-2758e020a70a"), "آبگرم", 16 },
                    { 537, new Guid("339b3184-8564-4d76-8046-7c657c34dd36"), "آوج", 16 },
                    { 591, new Guid("0297a27c-6448-409c-8f21-ba052abeac16"), "تازه کند انگوت", 18 },
                    { 590, new Guid("01957e24-2284-49d4-a60e-70e72e8ea38d"), "تازه کند", 18 },
                    { 589, new Guid("fe5046ce-cd8d-458e-b79a-d8fa67d62f9d"), "بيله سوار", 18 },
                    { 588, new Guid("4eb3c7c6-dcad-463c-9b4d-eefd079697e4"), "اصلاندوز", 18 },
                    { 587, new Guid("93bbcd30-80b7-47d7-b466-7540368daf4c"), "اسلام آباد", 18 },
                    { 586, new Guid("d92e3bb1-6b72-48ae-aeca-86a769f56f1c"), "اردبيل", 18 },
                    { 585, new Guid("de8aba01-d839-47b4-b773-098d21cd5bfb"), "آبي بيگلو", 18 },
                    { 584, new Guid("6781ed4c-1d66-4ac7-a12d-4281746e4a36"), "گراب", 17 },
                    { 583, new Guid("d4f65f09-cb57-4edb-beb8-f41a5cc3c9cf"), "کوهناني", 17 },
                    { 582, new Guid("da5f72bb-c236-4034-915e-fa98cc2bc654"), "کوهدشت", 17 },
                    { 581, new Guid("f7633c86-afb6-40d5-84be-81ecb0f6f9b1"), "چقابل", 17 },
                    { 580, new Guid("afc11795-b5c5-4dda-a0e3-0f0cc14304b1"), "چالانچولان", 17 },
                    { 579, new Guid("eacd9464-8a3c-4c29-9d67-4bba0cda6d09"), "پلدختر", 17 },
                    { 578, new Guid("75b76902-b066-46de-a5ba-ee21f9f7c330"), "ويسيان", 17 },
                    { 577, new Guid("cb1abe80-1658-439c-ae55-bf11e411c8ec"), "هفت چشمه", 17 },
                    { 592, new Guid("b92405ef-9fc8-48ae-ac0e-d9490c2c0287"), "جعفر آباد", 18 },
                    { 576, new Guid("105f4536-d7fe-4055-b088-7f86f701add8"), "نورآباد", 17 },
                    { 593, new Guid("9c0a607d-f564-48d2-bd3c-982ee1afe9b2"), "خلخال", 18 },
                    { 595, new Guid("fd9b105a-7cf4-4bbb-8ba4-91e1927626cc"), "سرعين", 18 },
                    { 610, new Guid("0ae92f1a-6223-4685-97af-e5a9e3813626"), "گيوي", 18 },
                    { 609, new Guid("1951e4e9-3c12-4479-8951-3a08aacdc3ce"), "گرمي", 18 },
                    { 608, new Guid("d2b34c6f-7dcf-4c5a-90b1-aa1e0f64ee7a"), "کورائيم", 18 },
                    { 607, new Guid("ee706685-2439-4d30-be62-5a8571d60196"), "کلور", 18 },
                    { 606, new Guid("c6c4e575-6433-4b18-99f4-7a06cae4a359"), "پارس آباد", 18 },
                    { 605, new Guid("0ed35ea3-c564-4c75-92a5-cbf2e68406ba"), "هير", 18 },
                    { 604, new Guid("9acd099a-3d53-4718-8ba7-3b1f783b02d0"), "هشتجين", 18 },
                    { 603, new Guid("57d260db-d5a3-4a64-afb9-61aee2e1ec21"), "نير", 18 },
                    { 602, new Guid("4eeda655-ecf2-4370-adf5-4fba9f97f37d"), "نمين", 18 },
                    { 601, new Guid("fa773708-9b40-4006-a934-faa6e605d85e"), "مشگين شهر", 18 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityID", "CityGUID", "Name", "ProvinceID" },
                values: new object[,]
                {
                    { 600, new Guid("005e648f-f928-4944-854c-e60316488274"), "مرادلو", 18 },
                    { 599, new Guid("55e7e096-5450-430b-aad6-96ff79c90185"), "لاهرود", 18 },
                    { 598, new Guid("2812efdc-c4be-490b-882b-1584959a2f07"), "قصابه", 18 },
                    { 597, new Guid("7aa48098-0ea2-49c9-a208-d3fbff0430e9"), "فخرآباد", 18 },
                    { 596, new Guid("e6feed57-d973-4e57-8c0a-d06d8163d355"), "عنبران", 18 },
                    { 594, new Guid("6795d46d-f515-4b20-904a-7a0960e36c1c"), "رضي", 18 },
                    { 575, new Guid("f7222f80-6c9e-4e35-b572-d33705594968"), "مومن آباد", 17 },
                    { 574, new Guid("df12976b-82e1-41a1-9f4e-3102c4ec900c"), "معمولان", 17 },
                    { 573, new Guid("20cea538-e1b0-4b9a-a166-c25ef4931735"), "فيروزآباد", 17 },
                    { 552, new Guid("9b7d9aeb-d1dc-4c49-b744-1d136077ebb5"), "شريفيه", 16 },
                    { 551, new Guid("679af883-e81d-47ea-8833-eac15307fd79"), "شال", 16 },
                    { 550, new Guid("7c5f4b62-78f9-4fa1-a54f-5caa9f439620"), "سگز آباد", 16 },
                    { 549, new Guid("90b8dd15-f617-4ea0-9e73-bdd098429fc3"), "سيردان", 16 },
                    { 548, new Guid("c257c6a4-2640-4930-8497-061508dc5cd5"), "رازميان", 16 },
                    { 547, new Guid("64c29ece-f8dc-4bcc-9fa2-4fda28a18263"), "دانسفهان", 16 },
                    { 546, new Guid("d4444963-d995-4dcc-b758-15ebffaa147c"), "خرمدشت", 16 },
                    { 545, new Guid("e8f2a124-7823-4eac-ac37-211ddc01a710"), "خاکعلي", 16 },
                    { 544, new Guid("51af84a5-228e-40d1-8e66-8b3e4e0e0e6d"), "تاکستان", 16 },
                    { 543, new Guid("872f10bc-4a1b-4fa3-bc2f-1cbb508480b4"), "بيدستان", 16 },
                    { 542, new Guid("91e98052-5c2a-4397-aa4a-8edb7c14b3ef"), "بوئين زهرا", 16 },
                    { 541, new Guid("2cfef79a-50ed-4d06-9398-f6bc54b57557"), "الوند", 16 },
                    { 540, new Guid("989d3d18-704b-4c08-a90d-8f12f8dd4996"), "اقباليه", 16 },
                    { 539, new Guid("46dc486f-975e-462a-930c-6cc3ff85c5c2"), "اسفرورين", 16 },
                    { 538, new Guid("841cbb29-82f1-4171-9129-ee510727434f"), "ارداق", 16 },
                    { 553, new Guid("b05db0b6-36b4-445d-a96f-cccaa6ee29bb"), "ضياء آباد", 16 },
                    { 554, new Guid("200513ea-dc80-4667-941e-d617718bd513"), "قزوين", 16 },
                    { 555, new Guid("57e215c3-9ea7-46ad-8ee0-7e14a2f9abff"), "محمديه", 16 },
                    { 556, new Guid("1a5aef4f-556c-4591-857c-4137abfa5ad6"), "محمود آباد نمونه", 16 },
                    { 572, new Guid("c46f54f8-76b6-42e1-8e5e-dc75d45c4eb7"), "شول آباد", 17 },
                    { 571, new Guid("8f90613c-8ca2-4fb2-9580-6f50c5cceee1"), "سپيد دشت", 17 },
                    { 570, new Guid("6e015dce-6531-4c60-8625-cc316de6956d"), "سراب دوره", 17 },
                    { 569, new Guid("a70c74b2-c3ad-4cf3-9446-476d6f16c862"), "زاغه", 17 },
                    { 568, new Guid("e3471d75-1c82-4993-a262-f1b54747cfd1"), "دورود", 17 },
                    { 567, new Guid("716ef7d1-a7c8-42c5-8a35-25ae319971be"), "درب گنبد", 17 },
                    { 566, new Guid("2f12943d-6745-4cbd-acda-6c639727aad3"), "خرم آباد", 17 },
                    { 461, new Guid("addf446a-13fd-4f4e-bf6b-70faf60d6946"), "سنگدوين", 14 },
                    { 565, new Guid("ca250ec4-5153-4c7c-8256-ef8b9f1bc0c9"), "بيرانشهر", 17 },
                    { 563, new Guid("05c0f202-65d8-4e37-b4cf-1cce09e31b55"), "اليگودرز", 17 },
                    { 562, new Guid("7fe6366e-fea3-49d4-a69e-533ffc7a8109"), "الشتر", 17 },
                    { 561, new Guid("f6f710b8-f37f-4243-8c8e-1c51ac5f4a3b"), "اشترينان", 17 },
                    { 560, new Guid("68bab453-19e8-4c09-aadf-7b3d810949ab"), "ازنا", 17 },
                    { 559, new Guid("1d134d2a-d5f7-406f-9f7f-e1dd64cd0ba2"), "کوهين", 16 },
                    { 558, new Guid("03f12b7d-8513-4fea-b471-79bec628bb1f"), "نرجه", 16 },
                    { 557, new Guid("9a6e5a3b-607c-43ab-abf4-81c7fd7b0144"), "معلم کلايه", 16 },
                    { 564, new Guid("8f733656-cb07-46ac-b476-e59f00dc9088"), "بروجرد", 17 },
                    { 460, new Guid("45514117-4b08-47d4-bd71-a1843e71355c"), "سرخنکلاته", 14 },
                    { 468, new Guid("88ed4a43-6529-4167-a21a-5845bac9acda"), "مينودشت", 14 },
                    { 458, new Guid("df78dac5-be6e-4c93-925d-f9104cd639f8"), "دلند", 14 },
                    { 361, new Guid("d9d7ec26-86a5-468b-babd-fe01cf940723"), "شوش", 11 },
                    { 360, new Guid("c38f18bf-0f7c-47a1-b2dc-37d0009a8c4c"), "شهر امام", 11 },
                    { 359, new Guid("bf4d3b49-589c-4d7c-8209-a752f40ca8b9"), "شمس آباد", 11 },
                    { 358, new Guid("1081c37d-e009-4d4d-8cf2-7a5908219433"), "شرافت", 11 },
                    { 357, new Guid("6f9ee716-d689-4488-a097-f9ba38767be0"), "شاوور", 11 },
                    { 356, new Guid("2c5af97c-121e-4fc6-a1d3-e34e6c30e056"), "شادگان", 11 },
                    { 355, new Guid("8538de7b-938f-4b67-98cc-94db268118de"), "سياه منصور", 11 },
                    { 354, new Guid("ce17779c-c0e5-4666-9bed-6877fecc2e8c"), "سوسنگرد", 11 },
                    { 353, new Guid("0c39363d-d0a4-4ed2-bbd2-55ded1a3a3a9"), "سماله", 11 },
                    { 352, new Guid("71f21368-fb77-4b37-9382-c8cb5787011b"), "سردشت", 11 },
                    { 351, new Guid("662e2b53-c3e8-4da1-91f2-fe015b3e43a2"), "سرداران", 11 },
                    { 350, new Guid("f6ce106a-7297-4844-ba56-23122bd9e122"), "سالند", 11 },
                    { 349, new Guid("791c0734-342f-4f3a-849d-aaf61f96888e"), "زهره", 11 },
                    { 348, new Guid("afc1f858-7fa1-434e-b777-37fef6a1d537"), "رفيع", 11 },
                    { 347, new Guid("f1292c16-665b-4376-b902-4068ee316bd5"), "رامهرمز", 11 },
                    { 362, new Guid("08605066-5301-4a00-8500-0f56cf4ec33a"), "شوشتر", 11 },
                    { 346, new Guid("3f984037-9e72-42cf-b042-8e9a3a034236"), "رامشير", 11 },
                    { 363, new Guid("e2638b78-ed50-405f-a99f-b48212c39d4b"), "شيبان", 11 },
                    { 365, new Guid("75520fc3-6c9d-43f9-99e5-7edec66a4fdf"), "صفي آباد", 11 },
                    { 380, new Guid("c6b99612-068d-4d14-b831-cd88223582e5"), "هنديجان", 11 },
                    { 379, new Guid("c14064ac-91c3-4eee-a9f3-811e2e9999f6"), "هفتگل", 11 },
                    { 378, new Guid("def353a1-50b1-4785-b308-6118e7734207"), "مينوشهر", 11 },
                    { 377, new Guid("2147d5c8-746a-4774-bbd0-9192e4fcc08c"), "ميداود", 11 },
                    { 376, new Guid("f94b983e-3605-4610-816c-abfeb16a817d"), "ميانرود", 11 },
                    { 375, new Guid("06b0159e-ba57-4a99-87c3-57fa1aaba763"), "منصوريه", 11 },
                    { 459, new Guid("7c37c5ce-956c-4811-8a8a-a42678fd2e87"), "راميان", 14 },
                    { 373, new Guid("a606ec60-b1ae-425b-a027-bdad4936a71b"), "مقاومت", 11 },
                    { 372, new Guid("fca4067f-68e6-4ca5-890a-7561f78b6751"), "مشراگه", 11 },
                    { 371, new Guid("479eead0-ba6d-45cb-b377-d65244485eb9"), "مسجد سليمان", 11 },
                    { 370, new Guid("bf56e25d-5217-4291-a5a0-678c361f7647"), "لالي", 11 },
                    { 369, new Guid("99b6e042-e746-44bd-93e7-573e8cb8da22"), "قلعه خواجه", 11 },
                    { 368, new Guid("96b77612-c1b0-4523-a9e8-24c535d6959e"), "قلعه تل", 11 },
                    { 367, new Guid("be523f0b-ec2e-44d2-86f5-2d6d3b30204d"), "فتح المبين", 11 },
                    { 366, new Guid("81499b65-6c28-47a2-a68b-3a9c3273eb43"), "صيدون", 11 },
                    { 364, new Guid("a4ff707f-bbcf-40af-b1a5-152dd7fb26d8"), "صالح شهر", 11 },
                    { 345, new Guid("68c9d695-855e-431c-a538-6126690c787b"), "دهدز", 11 },
                    { 344, new Guid("0f9aec98-ab8b-4e41-a952-3f068033109b"), "دزفول", 11 },
                    { 343, new Guid("d19f91de-c8d9-4102-9925-b1acd44fa55c"), "دارخوين", 11 },
                    { 322, new Guid("1fcc0d86-35d6-45cb-b8a0-693bf0e404ba"), "الوان", 11 },
                    { 321, new Guid("c50af59c-dab4-43e0-9266-a11717861a27"), "الهايي", 11 },
                    { 320, new Guid("717ef3b9-0ec4-4125-978b-5cb0f96cff00"), "اروند کنار", 11 },
                    { 319, new Guid("986f64f8-8c1a-40e8-8b3e-bfd0a55366ea"), "ابوحميظه", 11 },
                    { 318, new Guid("64e3a34b-8aca-4ae9-846b-286da8eb8aae"), "آغاجاري", 11 },
                    { 317, new Guid("85f1491d-098a-4c45-bd02-5c1e15e918c0"), "آزادي", 11 },
                    { 316, new Guid("56c17eef-958f-4b06-93de-1f2e4095bf30"), "آبژدان", 11 },
                    { 315, new Guid("9e645541-3064-40e1-a237-f32bfcd1eb37"), "آبادان", 11 },
                    { 314, new Guid("41f7bfed-d193-463e-811c-7765602bc937"), "گزيک", 10 },
                    { 313, new Guid("cf8651ad-39eb-400a-81a7-9973b1ee66cb"), "نيمبلوک", 10 },
                    { 312, new Guid("5a07f4e3-a471-48db-99a1-7d48fc562da7"), "نهبندان", 10 },
                    { 311, new Guid("b065bc97-0178-4562-b48d-9f0362edd866"), "مود", 10 },
                    { 310, new Guid("ce9d5682-5eb4-41e5-9fad-0a8a85d16f4f"), "محمدشهر", 10 },
                    { 309, new Guid("fb988f5f-8d64-4730-baf6-65d3e96cf551"), "قهستان", 10 },
                    { 308, new Guid("e03d8c97-1436-46a3-ba96-0ab16b8a05ad"), "قائن", 10 },
                    { 323, new Guid("d516a8be-7e8c-4de7-b52c-1fc97de089fc"), "اميديه", 11 },
                    { 324, new Guid("95224bfe-3702-4ce5-baee-c61eafce895f"), "انديمشک", 11 },
                    { 325, new Guid("9b36b335-35f2-4f6b-aea1-0b1ca6be41cb"), "اهواز", 11 },
                    { 326, new Guid("2d03855c-d3b9-4375-a1a0-f7ecf67289c0"), "ايذه", 11 },
                    { 342, new Guid("758be42a-5021-4d24-a3ab-cd37b9a7346d"), "خنافره", 11 },
                    { 341, new Guid("ce71c81e-5175-486e-a24a-9afc9576970a"), "خرمشهر", 11 },
                    { 340, new Guid("c24367a1-9d90-41a1-84ba-8d707ad56cfb"), "حميديه", 11 },
                    { 339, new Guid("2db3ee07-df68-4fc3-9977-d739b0d201a9"), "حمزه", 11 },
                    { 338, new Guid("1dfd9824-e9fb-4475-9844-ae74a6bcf548"), "حسينيه", 11 },
                    { 337, new Guid("af39a50c-64fe-4b68-8496-1f1772e479a3"), "حر", 11 },
                    { 336, new Guid("0c59d534-a42d-41b1-9739-8b52c111b57e"), "جنت مکان", 11 },
                    { 381, new Guid("b36b516a-6d85-4106-90d0-8e874c3f91ca"), "هويزه", 11 },
                    { 335, new Guid("3d2b24c2-ded8-4269-a190-8477d72d2459"), "جايزان", 11 },
                    { 333, new Guid("a50f4800-c62e-4126-8db9-405a55407fa3"), "ترکالکي", 11 },
                    { 332, new Guid("fe40f4fd-e603-4599-8fe2-3aa56ea561fa"), "بيدروبه", 11 },
                    { 331, new Guid("ab2fad75-7541-4de9-8be6-e724007683db"), "بهبهان", 11 },
                    { 330, new Guid("aee08020-48b5-4d8b-b991-6b9b6d007216"), "بندر ماهشهر", 11 },
                    { 329, new Guid("f881d3c1-86ac-47fa-9674-9b0723aa8461"), "بندر امام خميني", 11 },
                    { 328, new Guid("11b74147-11ab-4b32-8d4e-dbbbf505fa46"), "بستان", 11 },
                    { 327, new Guid("e65154f1-decd-49c7-9571-b575e8169ce1"), "باغ ملک", 11 },
                    { 334, new Guid("2987cb67-be11-47f2-a871-6e30e6596768"), "تشان", 11 },
                    { 382, new Guid("a545123d-8e95-4e55-99d1-6fcd3aefccb8"), "ويس", 11 },
                    { 374, new Guid("dbf9ad5f-8925-48e9-aaaf-2699f08146f2"), "ملاثاني", 11 },
                    { 384, new Guid("ba4e275c-a85d-4009-9537-739dc1aaa75b"), "چم گلک", 11 },
                    { 438, new Guid("cc7cc0da-8cb5-41d2-85bd-2e56013e4593"), "سلطانيه", 13 },
                    { 437, new Guid("45e33e21-fb94-4779-85ef-f658236d1c99"), "سجاس", 13 },
                    { 436, new Guid("ddfb8c97-84b3-4f7c-b26c-72171905750b"), "زنجان", 13 },
                    { 435, new Guid("3726d413-0ae0-43b6-b00b-96fdf7aa111b"), "زرين رود", 13 },
                    { 434, new Guid("b50df567-e855-4ec8-8b46-340c19a8cbc3"), "زرين آباد", 13 },
                    { 433, new Guid("207cf7c9-1806-4be4-806f-1363ac077d27"), "دندي", 13 },
                    { 432, new Guid("475be4e9-c0ae-4b94-952a-beff4d0141b0"), "خرمدره", 13 },
                    { 431, new Guid("23dd5299-1eb9-4ce4-8cca-6316a1429238"), "حلب", 13 },
                    { 383, new Guid("3a292a9c-b338-4893-badb-4eee1eff7bfa"), "چغاميش", 11 },
                    { 429, new Guid("ba917bff-bbe5-48c4-bd58-ea378b81e170"), "ابهر", 13 },
                    { 428, new Guid("a66c7b55-3130-4943-9953-ab555c11091e"), "آب بر", 13 },
                    { 427, new Guid("1343ed7e-5750-471b-99e5-1267b0db72ec"), "کلمه", 12 },
                    { 426, new Guid("40ea4b4c-b68f-4965-a19b-0322b7f690b1"), "کاکي", 12 },
                    { 425, new Guid("2c8994e3-ec4a-4c5f-9fbc-c2b481419143"), "چغادک", 12 },
                    { 424, new Guid("6116ef59-cc6c-4c56-b92f-cd26113e423e"), "وحدتيه", 12 },
                    { 439, new Guid("a5d04757-1883-4922-8fda-7267a0c4f3c3"), "سهرورد", 13 },
                    { 423, new Guid("d754a02b-d740-4a98-b2bc-658025cc5ab0"), "نخل تقي", 12 },
                    { 440, new Guid("e6fef2cc-d2f6-49db-ae39-c5ab62efffb5"), "صائين قلعه", 13 },
                    { 442, new Guid("93f48f31-5a5a-4992-aebc-18fe17b2b458"), "ماه نشان", 13 },
                    { 457, new Guid("7fef58bb-3413-4259-92bc-6a7dae69d27c"), "خان ببين", 14 },
                    { 456, new Guid("09e21c05-f755-4e0b-ab1c-db9944501410"), "جلين", 14 },
                    { 455, new Guid("ac46be4f-1068-4155-b65b-ea17efb1d159"), "تاتار عليا", 14 },
                    { 454, new Guid("e835b630-55c1-4bc3-bdc3-86e86399fa0a"), "بندر گز", 14 },
                    { 453, new Guid("6b072ffc-6a41-4ca5-9b76-3a20126f7db3"), "بندر ترکمن", 14 },
                    { 452, new Guid("2d7aa8ea-b135-4b82-97e2-e3a2dad63a08"), "اينچه برون", 14 },
                    { 451, new Guid("da0f0231-7b1a-480b-bef9-a9fe33833723"), "انبار آلوم", 14 },
                    { 450, new Guid("a4ef5803-8f6a-4c9a-bc00-12959b62c6cd"), "آق قلا", 14 },
                    { 449, new Guid("f3fea147-e09f-4ce0-874a-9f7c113ce250"), "آزاد شهر", 14 },
                    { 448, new Guid("00b7e855-97f8-4ccc-a409-699f0ef93c41"), "گرماب", 13 },
                    { 447, new Guid("de43465c-6133-4798-ad64-d07941c3d0e4"), "کرسف", 13 },
                    { 446, new Guid("d32a0a86-89fe-4685-947c-2e837c4488ac"), "چورزق", 13 },
                    { 445, new Guid("638e42a4-a466-491a-a246-2bb586055c65"), "هيدج", 13 },
                    { 444, new Guid("34764104-039e-42cf-847b-7b48dad19c74"), "نيک پي", 13 },
                    { 443, new Guid("97a49ae7-945a-4f51-ac79-d7fe439acd12"), "نوربهار", 13 },
                    { 441, new Guid("9aa29d98-fa6a-46b4-b0b3-db2bf8ffd1b1"), "قيدار", 13 },
                    { 422, new Guid("8fe9ff2c-9f33-4c6d-be8a-0acb0e000240"), "عسلويه", 12 },
                    { 430, new Guid("bbb39af4-85b5-4dd9-b5f0-3193c0af521e"), "ارمخانخانه", 13 },
                    { 420, new Guid("e4d4ee4b-5ffb-4ec9-9e35-fbfdb22d22e3"), "شبانکاره", 12 },
                    { 399, new Guid("eb5b5548-d90c-49f0-a984-d9113075bb7f"), "برازجان", 12 },
                    { 398, new Guid("31bbb74a-98d6-4917-baf5-dbdc411ceac6"), "بادوله", 12 },
                    { 397, new Guid("67e02575-321e-4b03-9214-3fba0db256a4"), "اهرم", 12 },
                    { 396, new Guid("b92b5181-fde4-46c6-aa1c-196b70a1cb40"), "انارستان", 12 },
                    { 395, new Guid("e6d61a20-4c57-447a-b6b6-11d777c7ffeb"), "امام حسن", 12 },
                    { 394, new Guid("06a2fedb-88e2-40c4-9bf6-e60837ddf1b5"), "آبپخش", 12 },
                    { 421, new Guid("fd7ad939-d201-4e6f-a700-ed77c73930a3"), "شنبه", 12 },
                    { 392, new Guid("35929c65-51c4-4d85-8b57-325ac68d91ec"), "آباد", 12 },
                    { 391, new Guid("80786a06-dc64-4df1-a684-94be308fc661"), "گوريه", 11 },
                    { 390, new Guid("94b041a3-f822-409b-8f7b-0e2182d2fdb8"), "گلگير", 11 },
                    { 389, new Guid("9d806f31-7e11-45dd-a6a1-860a0dede5de"), "گتوند", 11 },
                    { 388, new Guid("81cdeea1-b11b-4bae-bbc9-ccae9bd014a7"), "کوت عبدالله", 11 },
                    { 387, new Guid("213a0227-77af-4ef7-af2c-6b256eef86c7"), "کوت سيدنعيم", 11 },
                    { 386, new Guid("7007a1bc-3409-4dfa-b687-a56ea1a32a6b"), "چوئبده", 11 },
                    { 385, new Guid("7de69453-a960-4f56-87cc-a0ea211d9560"), "چمران", 11 },
                    { 400, new Guid("84b7a81f-0c9c-4acf-a78e-b507a1012f61"), "بردخون", 12 },
                    { 401, new Guid("3f32a684-e56b-40e7-827b-ec4610044c51"), "بردستان", 12 },
                    { 393, new Guid("79dcba52-f6df-46fd-9faf-73b7617653b9"), "آبدان", 12 },
                    { 403, new Guid("16d25ec5-178d-4690-a0d2-056ea6baf965"), "بندر ديلم", 12 },
                    { 402, new Guid("e5dbc340-d649-4df7-8888-9f2ab2ed9514"), "بندر دير", 12 },
                    { 419, new Guid("f7423558-4c6a-4b9c-aa3b-41caba5a413d"), "سيراف", 12 },
                    { 418, new Guid("75e3c80d-2204-4173-96dc-8768547250b8"), "سعد آباد", 12 },
                    { 417, new Guid("9883c96f-588d-47b5-b90b-d39dc801faac"), "ريز", 12 },
                    { 416, new Guid("e391fe60-dc20-41ee-a325-bfba28bf2afb"), "دوراهک", 12 },
                    { 414, new Guid("f36487d4-8c80-49e8-aaf9-00a8b21de804"), "دالکي", 12 },
                    { 413, new Guid("23b61936-dbf6-4b5f-a338-3b7be8f3a9f7"), "خورموج", 12 },
                    { 412, new Guid("5e73f8a6-84fe-4334-8aa5-7b1f1c1ab27c"), "خارک", 12 },
                    { 415, new Guid("2348ed29-9a74-4f36-a854-9e8d0bbcc993"), "دلوار", 12 },
                    { 410, new Guid("9e8f510a-4190-4e90-8639-da6ecdcbb313"), "تنگ ارم", 12 },
                    { 409, new Guid("26dfc531-6914-45ed-9425-afe947f02645"), "بوشکان", 12 },
                    { 408, new Guid("28b9b7de-c256-493c-89b9-18201d31e12a"), "بوشهر", 12 },
                    { 407, new Guid("e5489854-21af-4947-9f43-c90fef79f9cb"), "بنک", 12 },
                    { 406, new Guid("e2c36cde-4ca4-4b39-adbe-5deff43f586c"), "بندر گناوه", 12 },
                    { 405, new Guid("a9084f83-3b97-4007-8159-8a1167bbf13e"), "بندر کنگان", 12 },
                    { 404, new Guid("f52b8739-1f2d-4637-8c0f-de4d1b9951db"), "بندر ريگ", 12 },
                    { 411, new Guid("c727c118-06ba-43ef-ac23-1eaaca77243a"), "جم", 12 }
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
                table: "SMSSetting",
                columns: new[] { "SMSSettingID", "ModifiedDate", "Name", "SMSProviderConfigurationID", "SMSSettingGUID" },
                values: new object[] { 1, new DateTime(2020, 6, 10, 14, 41, 38, 245, DateTimeKind.Local).AddTicks(7950), "Kavenegar", 1, new Guid("cc90d39f-1169-48f2-bd74-40c7250abcbf") });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 5, null, null, new Guid("6cad6634-e31f-4580-a11a-23e590262169"), null, null, "تاسیسات", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7464), 3, null, 1 },
                    { 31, null, null, new Guid("c66482f1-3242-4d59-ac08-bd4b25ccf912"), null, null, "سرویس و تعمیر خودرو", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7781), 4, null, 3 },
                    { 30, null, null, new Guid("0d15f2cf-9d8f-4bec-8704-fade67470fed"), null, null, "اجاره خودرو", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7771), 4, null, 2 },
                    { 29, null, null, new Guid("382f3ea2-93f0-47ad-b317-df3433bfff51"), null, null, "اتوبار", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7763), 4, null, 1 },
                    { 21, null, null, new Guid("6c3cf5f8-371b-42e0-a33a-13be33692811"), null, null, "کار در ارتفاع", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7661), 3, null, 17 },
                    { 20, null, null, new Guid("c260d698-7913-4718-81c4-ba22870b0e94"), null, null, "آسانسور و بالابر", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7653), 3, null, 16 },
                    { 19, null, null, new Guid("2b28813e-4a38-43ee-8cd6-1cb7490f21ad"), null, null, "نجاری", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7644), 3, null, 15 },
                    { 18, null, null, new Guid("9c27b1f5-2e7d-4eae-9724-54c736edb99d"), null, null, "تعمیرات لوازم خانگی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7636), 3, null, 14 },
                    { 16, null, null, new Guid("9cc5664d-dae0-4290-891a-75b628284293"), null, null, "عایق کاری", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7621), 3, null, 12 },
                    { 15, null, null, new Guid("38f69780-fc31-4fb6-913f-81c7c0c926ba"), null, null, "عایق کاری", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7614), 3, null, 11 },
                    { 17, null, null, new Guid("e86215a3-12c0-4aa7-89d0-602153920f8f"), null, null, "نرده و حفاظ استیل", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7629), 3, null, 13 },
                    { 13, null, null, new Guid("ee35bb19-5e38-4bb6-bfbc-c70c51059c32"), null, null, "بنایی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7596), 3, null, 9 },
                    { 12, null, null, new Guid("ff85be72-882a-4647-80bc-3ff7c46656b2"), null, null, "دکوراسیون داخلی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7588), 3, null, 8 },
                    { 11, null, null, new Guid("cf285c94-b6f7-4ded-9813-46688a0579f7"), null, null, "کابینت سازی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7580), 3, null, 7 },
                    { 10, null, null, new Guid("87f80a89-3219-4659-91e3-5027341a78ba"), null, null, "شیشه بری و قابسازی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7516), 3, null, 6 },
                    { 9, null, null, new Guid("254af750-05e8-4e23-905e-52f4f972b9e0"), null, null, "آلومینیوم سازی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7509), 3, null, 5 },
                    { 8, null, null, new Guid("12c0b98c-65bd-43e1-a9de-17e3ecb7651e"), null, null, "مبلمان", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7501), 3, null, 4 },
                    { 7, null, null, new Guid("f3742a44-2f8f-4c01-8962-8084ad1ddf99"), null, null, "ایمنی و امنیت", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7493), 3, null, 3 },
                    { 6, null, null, new Guid("90ada9b1-d59b-4618-aede-af795b2d3a97"), null, null, "الکتریکی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7472), 3, null, 2 },
                    { 14, null, null, new Guid("3fd42685-bed8-4ea5-af82-9ac5a0d916c0"), null, null, "آهنگری", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7604), 3, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "SMSTemplate",
                columns: new[] { "SMSTemplateID", "ModifiedDate", "Name", "SMSSettingID", "SMSTemplateGUID" },
                values: new object[] { 1, new DateTime(2020, 6, 10, 14, 41, 38, 246, DateTimeKind.Local).AddTicks(3923), "VerifyAccount", 1, new Guid("f3662ab3-2cd2-4b2c-a024-a196f46f1b34") });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FirstName", "GenderCodeID", "IsActive", "IsRegister", "LastName", "ModifiedDate", "PhoneNumber", "ProfileDocumentID", "RegisteredDate", "RoleID", "UserGUID" },
                values: new object[,]
                {
                    { 4, "white.luciferrr@gmail.com", "محمد", 8, true, true, "میرزایی", new DateTime(2020, 6, 10, 14, 41, 38, 249, DateTimeKind.Local).AddTicks(47), "09147830093", null, new DateTime(2020, 6, 10, 14, 41, 38, 249, DateTimeKind.Local).AddTicks(44), 2, new Guid("d9c1f618-8418-418b-916b-fc5c9ed8db02") },
                    { 1, "mahdiroudaki@hotmail.com", "سید مهدی", 8, true, true, "رودکی", new DateTime(2020, 6, 10, 14, 41, 38, 248, DateTimeKind.Local).AddTicks(7323), "09227204305", null, new DateTime(2020, 6, 10, 14, 41, 38, 248, DateTimeKind.Local).AddTicks(6814), 1, new Guid("c1db5525-bb03-4ce7-ba96-9627d5cc6156") },
                    { 2, "roozbehshamekhi@hotmail.com", "روزبه", 8, true, true, "شامخی", new DateTime(2020, 6, 10, 14, 41, 38, 248, DateTimeKind.Local).AddTicks(9988), "09128277075", null, new DateTime(2020, 6, 10, 14, 41, 38, 248, DateTimeKind.Local).AddTicks(9962), 3, new Guid("d24b74d8-b645-4010-a15d-a04aa0b1f63d") },
                    { 3, "dead.hh98@gmail.com", "حامد", 8, true, true, "حقیقیان", new DateTime(2020, 6, 10, 14, 41, 38, 249, DateTimeKind.Local).AddTicks(33), "09108347428", null, new DateTime(2020, 6, 10, 14, 41, 38, 249, DateTimeKind.Local).AddTicks(29), 2, new Guid("774ddaf9-a66e-4494-aa7b-3ce22b121649") }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminGUID", "IsDelete", "ModifiedDate", "UserID" },
                values: new object[] { 1, new Guid("4e510278-67c3-4810-834d-eb6a0dcce9ee"), false, new DateTime(2020, 6, 10, 14, 41, 38, 249, DateTimeKind.Local).AddTicks(2414), 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Abstract", "ActiveIconDocumentID", "CategoryGUID", "CoverDocumentID", "Description", "DisplayName", "InactiveIconDocumentID", "IsActive", "ModifiedDate", "ParentCategoryID", "QuadMenuDocumentID", "Sort" },
                values: new object[,]
                {
                    { 22, null, null, new Guid("d51a4107-8588-48d2-9bbb-3ce5e48f288c"), null, null, "سرویس کولر آبی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7670), 5, null, 1 },
                    { 23, null, null, new Guid("258d7746-505f-4036-bba8-d7631a7a11bb"), null, null, "نقاشی ساختمان", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7680), 5, null, 2 },
                    { 24, null, null, new Guid("db04518d-c1cc-4da4-89d2-75eb0d9c0190"), null, null, "رنگ کاری مبل", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7687), 8, null, 1 },
                    { 25, null, null, new Guid("c52be504-1d35-45eb-9f93-34ae3e988506"), null, null, "تعمیر صندلی اداری", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7695), 8, null, 2 },
                    { 26, null, null, new Guid("f7bef4c4-6fe1-4e38-94b3-64a78b778a37"), null, null, "ساخت مبلمان", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7702), 8, null, 3 },
                    { 27, null, null, new Guid("bfc35196-9ee2-4745-ade7-500fe3f9beb6"), null, null, "دوخت کاور مبل", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7749), 8, null, 4 },
                    { 28, null, null, new Guid("9d4d0eb6-3d3c-4f73-a425-6ee1e00ccc83"), null, null, "تعمیر مبل", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7756), 8, null, 5 },
                    { 32, null, null, new Guid("2c97dce5-964b-451a-885d-e60e94dc1b7d"), null, null, "وانت بار", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7788), 29, null, 1 },
                    { 33, null, null, new Guid("78e9e34a-186d-47ff-83e1-254ca5f710c8"), null, null, "باربری و اتوبار", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7795), 29, null, 2 },
                    { 34, null, null, new Guid("ff175da8-46d7-43bc-a33e-a7227f99249d"), null, null, "کارگر اسباب کشی", null, true, new DateTime(2020, 6, 10, 14, 41, 38, 254, DateTimeKind.Local).AddTicks(7803), 29, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientID", "CityID", "ClientGUID", "ModifiedDate", "UserID" },
                values: new object[] { 1, 751, new Guid("6070156a-45d5-43c7-92c1-22ea0839d27e"), new DateTime(2020, 6, 10, 14, 41, 38, 249, DateTimeKind.Local).AddTicks(7139), 2 });

            migrationBuilder.InsertData(
                table: "Contractor",
                columns: new[] { "ContractorID", "AverageRate", "BusinessTypeCodeID", "CityID", "ContractorGUID", "Credit", "Latitude", "Longitude", "ModifiedDate", "UserID" },
                values: new object[,]
                {
                    { 1, null, 4, 751, new Guid("96e04030-374b-4a81-a306-e0e620761bb4"), 0, "1", "2", new DateTime(2020, 6, 10, 14, 41, 38, 251, DateTimeKind.Local).AddTicks(3698), 3 },
                    { 2, null, 4, 751, new Guid("61eb62bf-b4fd-4d8a-b5f5-e30ec5209e0b"), 10000, "1", "2", new DateTime(2020, 6, 10, 14, 41, 38, 251, DateTimeKind.Local).AddTicks(4466), 4 }
                });

            migrationBuilder.InsertData(
                table: "ContractorCategory",
                columns: new[] { "ContractorCategoryID", "CategoryID", "ContractorCategoryGUID", "ContractorID" },
                values: new object[,]
                {
                    { 1, 4, new Guid("fc620337-38ba-4d12-818f-87647856c544"), 1 },
                    { 2, 5, new Guid("b77ea6ee-e17b-4834-98cd-bb117914b48e"), 1 },
                    { 3, 14, new Guid("092a9edb-5477-4605-9499-ac6f0d71dd5f"), 1 },
                    { 4, 22, new Guid("b2e405c3-6dc2-44b5-a28d-903630adac1c"), 1 },
                    { 5, 25, new Guid("1bcbbc89-d3ec-4f31-abef-8bf0fd69880c"), 1 },
                    { 6, 30, new Guid("a7b5fe22-5611-4d02-9032-4cfe734e527a"), 1 },
                    { 7, 33, new Guid("f6dc13be-1e3f-4da5-8c42-b52141d4c12d"), 1 },
                    { 8, 34, new Guid("388c0322-9a41-4c37-b39c-e0c791c4893d"), 1 },
                    { 9, 27, new Guid("c0ec05ed-623d-4521-abd7-5e884ab7de56"), 1 },
                    { 10, 20, new Guid("e39b13a2-f6d6-451a-882c-4e83be2056e5"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CategoryID", "ClientID", "Comment", "ContractorID", "Cost", "DeadlineDate", "Description", "ModifiedDate", "OrderGUID", "Rate", "StateCodeID", "Title" },
                values: new object[,]
                {
                    { 1, 14, 1, null, null, null, null, "توضیح", new DateTime(2020, 6, 10, 14, 41, 38, 252, DateTimeKind.Local).AddTicks(5749), new Guid("23545ac6-928f-418a-a230-de7bd71d8b88"), null, 9, "تیتر" },
                    { 2, 22, 1, null, null, null, null, "کولر ماشین مشکل داره", new DateTime(2020, 6, 10, 14, 41, 38, 252, DateTimeKind.Local).AddTicks(6369), new Guid("c9e32e93-951a-47ee-a5be-7295d9494964"), null, 9, "مشکل" }
                });

            migrationBuilder.InsertData(
                table: "OrderRequest",
                columns: new[] { "OrderRequestID", "ContractorID", "IsAllow", "Message", "ModifiedDate", "OfferedPrice", "OrderID", "OrderRequestGUID" },
                values: new object[] { 1, 1, true, "پیام", new DateTime(2020, 6, 10, 14, 41, 38, 253, DateTimeKind.Local).AddTicks(3751), 250000L, 1, new Guid("2f017ce4-844f-4da6-9d67-6c112d15f290") });

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
                name: "IX_Tbl_SMSProviderNumber_SPN_SPCID",
                table: "SMSProviderNumber",
                column: "SMSProviderConfigurationID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSResponse_SMS_STID",
                table: "SMSResponse",
                column: "SMSTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_SMSResponse_UserID",
                table: "SMSResponse",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSSetting_SS_SPCID",
                table: "SMSSetting",
                column: "SMSProviderConfigurationID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SMSTemplate_ST_SSID",
                table: "SMSTemplate",
                column: "SMSSettingID");

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
                name: "SMSProviderNumber");

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
                name: "SMSSetting");

            migrationBuilder.DropTable(
                name: "PermissionGroup");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Contractor");

            migrationBuilder.DropTable(
                name: "SMSProviderConfiguration");

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
