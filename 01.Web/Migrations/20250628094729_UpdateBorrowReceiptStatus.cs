using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullToping.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBorrowReceiptStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2001, 5001 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2003, 5002 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2003, 5003 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2011, 5003 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2004, 5004 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5005 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2006, 5006 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2007, 5007 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2009, 5007 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5008 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2001, 5009 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2002, 5010 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5010 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2010, 5011 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2011, 5012 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2012, 5013 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2001, 5014 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2008, 5015 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2002, 5016 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5016 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2009, 5017 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2002, 5018 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2008, 5018 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5019 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2015, 5020 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2016, 5031 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2017, 5032 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2018, 5033 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2019, 5034 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2020, 5035 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5036 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5037 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5038 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5039 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5040 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5041 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5042 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5043 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2028, 5044 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5045 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2028, 5046 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5047 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5048 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5049 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5050 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5051 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5052 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5053 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2017, 5054 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5055 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5056 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5057 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5058 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2016, 5059 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5060 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5061 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5062 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5063 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5064 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5065 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5066 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5067 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5068 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5069 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5070 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5071 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5072 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5073 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5074 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5075 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5076 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5077 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2016, 5078 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2010, 5079 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2017, 5080 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5081 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5082 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2012, 5083 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5084 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2015, 5085 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5086 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2008, 5087 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5088 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5089 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5090 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5091 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5092 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5093 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2028, 5094 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5095 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5096 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5097 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5098 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5099 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5100 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5101 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5102 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5103 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5104 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5105 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5021);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5022);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5023);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5024);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5025);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5026);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5027);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5028);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5029);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5030);

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5001, 6001 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5002, 6001 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5003, 6002 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5004, 6002 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5005, 6003 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5006, 6003 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5007, 6004 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5008, 6005 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5009, 6005 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5010, 6005 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5011, 6006 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5012, 6006 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5013, 6007 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5014, 6007 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5015, 6008 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5016, 6008 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5017, 6009 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5018, 6009 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5019, 6010 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5020, 6010 });

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6011);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6012);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6013);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6014);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6015);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6016);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6017);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6018);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6019);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6020);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6021);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6022);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6023);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6024);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6025);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3019);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5001);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5002);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5003);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5004);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5005);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5006);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5007);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5008);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5009);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5010);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5011);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5012);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5013);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5014);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5015);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5016);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5017);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5018);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5019);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5020);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5031);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5032);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5033);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5034);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5035);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5036);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5037);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5038);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5039);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5040);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5041);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5042);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5043);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5044);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5045);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5046);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5047);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5048);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5049);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5050);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5051);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5052);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5053);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5054);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5055);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5056);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5057);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5058);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5059);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5060);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5061);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5062);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5063);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5064);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5065);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5066);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5067);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5068);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5069);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5070);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5071);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5072);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5073);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5074);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5075);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5076);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5077);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5078);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5079);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5080);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5081);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5082);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5083);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5084);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5085);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5086);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5087);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5088);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5089);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5090);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5091);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5092);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5093);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5094);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5095);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5096);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5097);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5098);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5099);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5105);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6001);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6002);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6003);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6004);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6005);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6006);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6007);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6008);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6009);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6010);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3011);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4007);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3004);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3005);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3006);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3007);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3008);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3009);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3012);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3013);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3014);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3015);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3016);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3017);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3018);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3024);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3025);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3026);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3027);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3028);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3029);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3030);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4001);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4002);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4003);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4004);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4005);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4006);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4008);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4009);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4010);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4011);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4012);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4013);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4014);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4015);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4016);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1003);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Publishers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "4001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "3001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptId",
                table: "BorrowReceipts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "6001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "5001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "2001, 1");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "Nguyễn Nhật Ánh" },
                    { 2, "Hermione Granger" },
                    { 3, "Paulo Coelho" },
                    { 4, "Stephen Hawking" },
                    { 5, "Yuval Noah Harari" },
                    { 6, "J.K. Rowling" },
                    { 7, "Daniel Kahneman" },
                    { 8, "Tony Robbins" },
                    { 9, "Malcolm Gladwell" },
                    { 10, "George Orwell" },
                    { 11, "Harper Lee" },
                    { 12, "Fyodor Dostoevsky" },
                    { 13, "Gabriel Garcia Marquez" },
                    { 14, "Isaac Asimov" },
                    { 15, "Sun Tzu" },
                    { 16, "Ernest Hemingway" },
                    { 17, "Agatha Christie" },
                    { 18, "Edgar Allan Poe" },
                    { 19, "Ralph Waldo Emerson" },
                    { 20, "Đỗ Phấn" },
                    { 21, "Arthur C. Clarke" },
                    { 22, "Nicholas Sparks" },
                    { 23, "Dale Carnegie" },
                    { 24, "Robert Kiyosaki" },
                    { 25, "Stephen R. Covey" },
                    { 26, "Nguyễn Trãi" },
                    { 27, "William Shakespeare" },
                    { 28, "Sigmund Freud" },
                    { 29, "Noam Chomsky" },
                    { 30, "Trần Đại Nghĩa" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Văn học Việt Nam" },
                    { 2, "Văn học nước ngoài" },
                    { 3, "Nghiên cứu khoa học" },
                    { 4, "Lịch sử – Địa lý" },
                    { 5, "Công nghệ thông tin" },
                    { 6, "Tâm lý – Kỹ năng sống" },
                    { 7, "Thiếu nhi" },
                    { 8, "Kinh tế – Quản trị" },
                    { 9, "Y học – Sức khỏe" },
                    { 10, "Nghệ thuật – Kiến trúc" },
                    { 11, "Truyện tranh – Manga" },
                    { 12, "Tự lực – Phát triển bản thân" },
                    { 13, "Thơ ca" },
                    { 14, "Du lịch – Khám phá" },
                    { 15, "Ẩm thực – Nấu ăn" },
                    { 16, "Văn học trẻ" },
                    { 17, "Tiểu thuyết trinh thám" },
                    { 18, "Kinh dị – Giật gân" },
                    { 19, "Thơ cách mạng" },
                    { 20, "Tôn giáo – Triết học" },
                    { 21, "Khoa học viễn tưởng" },
                    { 22, "Lãng mạn – Tình cảm" },
                    { 23, "Phát triển bản thân" },
                    { 24, "Kinh doanh – Khởi nghiệp" },
                    { 25, "Sách kỹ năng mềm" },
                    { 26, "Văn hóa – Xã hội" },
                    { 27, "Sách thiếu nhi – Thiếu niên" },
                    { 28, "Sách luật pháp" },
                    { 29, "Sách đại học" },
                    { 30, "Sách chuyên ngành y" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Name" },
                values: new object[,]
                {
                    { 1, "NXB Giáo dục Việt Nam" },
                    { 2, "NXB Văn hóa – Thông tin" },
                    { 3, "NXB Khoa học và Kỹ thuật" },
                    { 4, "NXB Trẻ" },
                    { 5, "NXB Kim Đồng" },
                    { 6, "NXB Thống Kê" },
                    { 7, "NXB Đại học Quốc gia" },
                    { 8, "NXB Công nghệ Thông tin" },
                    { 9, "NXB Hội Nhà văn" },
                    { 10, "NXB Văn học" },
                    { 11, "NXB Phụ nữ" },
                    { 12, "NXB Tri thức" },
                    { 13, "NXB Phương Đông" },
                    { 14, "NXB Văn học Đông Á" },
                    { 15, "NXB Đại học Quốc gia TP.HCM" },
                    { 16, "NXB An ninh quốc gia" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "FullName", "Password", "Phone", "UserType", "Username" },
                values: new object[,]
                {
                    { 1, "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội", "vanvu@gmail.com", "Nguyễn Văn Vũ", null, "0912345678", "Customer", "nguyenvanvu" },
                    { 2, "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ", "thiba@gmail.com", "Trần Thị Ba", null, "0987654321", "Customer", "tranthiba" },
                    { 3, "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh", "vanchi@gmail.com", "Lê Văn Chi", null, "0901234567", "Customer", "levanchi" },
                    { 4, "Số 22, Đường Láng Hạ, Phường Láng Hạ, Quận Đống Đa, Hà Nội", "dungpham@gmail.com", "Phạm Thị Dung", null, "0918765432", "Customer", "phamthidung" },
                    { 5, "Số 99, Đường Trần Phú, Phường 5, TP. Vũng Tàu", "anvo@gmail.com", "Võ Văn An", null, "0932123456", "Customer", "vovan_an" },
                    { 6, "Số 5, Phố Hoàng Diệu, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng", "hienly@gmail.com", "Lý Thị Hiền", null, "0983344556", "Customer", "lythihien" },
                    { 7, "Số 150, Đường Cách Mạng Tháng 8, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh", "tuanngo@gmail.com", "Ngô Minh Tuấn", null, "0909988776", "Customer", "ngominhtuan" },
                    { 8, "Số 10, Đường Hai Bà Trưng, Phường Phạm Ngũ Lão, Quận 1, TP. Hồ Chí Minh", "lan.dang@gmail.com", "Đặng Thị Lan", null, "0911223344", "Customer", "dangthilan" },
                    { 9, "Số 8, Đường Nguyễn Thị Minh Khai, Phường 1, TP. Vĩnh Long", "vanhoa.phan@gmail.com", "Phan Văn Hòa", null, "0977554433", "Customer", "phanvanhoa" },
                    { 10, "Số 120, Đường Phan Đình Phùng, Phường Thành Nhất, TP. Buôn Ma Thuột", "maitruong@gmail.com", "Trương Thị Mai", null, "0911335577", "Customer", "truongthimai" },
                    { 11, "Số 33, Phố Lý Thường Kiệt, Phường Phủ Hà, TP. Lạng Sơn", "quocviet.bui@gmail.com", "Bùi Quốc Việt", null, "0987665544", "Customer", "buiquo cviet" },
                    { 12, "Số 27, Đường Hùng Vương, Phường Mỹ Xuyên, TP. Sóc Trăng", "phuongle@gmail.com", "Lê Thị Phương", null, "0968877665", "Customer", "lethiphuong" },
                    { 13, "Số 55, Đường Trần Hưng Đạo, Phường Lê Lợi, TP. Nam Định", "minhtu.do@gmail.com", "Đỗ Minh Tú", null, "0933445566", "Customer", "dominhtu" },
                    { 14, "Số 18, Đường Lê Lợi, Phường An Lạc, TP. Biên Hòa", "minhquan.pham@gmail.com", "Phạm Minh Quân", null, "0914556677", "Customer", "phamminhquan" },
                    { 15, "Số 66, Phố Trần Nhân Tông, Phường Nam Đàn, TP. Thanh Hóa", "ngocvu@gmail.com", "Vũ Thị Ngọc", null, "0988112233", "Customer", "vuthingoc" },
                    { 16, "Số 102, Đường Trần Phú, Phường Xuân Phú, TP. Huế", "quoccuong.nguyen@gmail.com", "Nguyễn Quốc Cường", null, "0902334455", "Customer", "nguyencuong" },
                    { 17, "Số 5, Đường Nguyễn Văn Trỗi, Phường Đông Vệ, TP. Thanh Hóa", "thuyhang.le@gmail.com", "Lê Thúy Hằng", null, "0977665544", "Customer", "lethuyhang" },
                    { 18, "Số 250, Đường Nguyễn Thái Học, Phường Phan Chu Trinh, TP. Quy Nhơn", "anhtuan.tran@gmail.com", "Trần Anh Tuấn", null, "0933667788", "Customer", "trananhtuan" },
                    { 19, "Số 14, Đường Nguyễn Huệ, Phường Phước Ninh, TP. Đà Nẵng", "hanhphan@gmail.com", "Phan Thị Hạnh", null, "0901778899", "Customer", "phanthihanh" },
                    { 20, "Số 77, Phố Phan Đình Phùng, Phường Đội Cấn, Quận Ba Đình, Hà Nội", "sontruong@gmail.com", "Trương Văn Sơn", null, "0977001122", "Customer", "truongvanson" },
                    { 21, "Số 33, Đường Trần Khánh Dư, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội", "leminhtam@gmail.com", "Lê Minh Tâm", null, "0912993344", "Customer", "leminhtam" },
                    { 22, "Số 55, Đường Đinh Tiên Hoàng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh", "phucdang@gmail.com", "Đặng Văn Phúc", null, "0933100234", "Customer", "dangvanphuc" },
                    { 23, "Số 99, Đường Lý Tự Trọng, Phường Phú Hòa, TP. Thủ Dầu Một", "kieuvo@gmail.com", "Võ Thị Kiều", null, "0988776655", "Customer", "vothikieu" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "PublisherId", "StockQuantity", "Title" },
                values: new object[,]
                {
                    { 1, 7, null, 5, 12, "Dế Mèn Phiêu Lưu Ký" },
                    { 2, 2, null, 2, 8, "Hoàng Tử Bé" },
                    { 3, 1, null, 4, 5, "Nhà Giả Kim" },
                    { 4, 3, null, 3, 3, "Lược Sử Thời Gian" },
                    { 5, 4, null, 3, 4, "Sapiens: Lược Sử Loài Người" },
                    { 6, 7, null, 5, 6, "Harry Potter và Hòn Đá Phù Thủy" },
                    { 7, 6, null, 8, 10, "Tư Duy, Nhanh và Chậm" },
                    { 8, 5, null, 8, 2, "Cấu Trúc Dữ Liệu và Giải Thuật" },
                    { 9, 1, null, 2, 5, "Trên Đường" },
                    { 10, 6, null, 1, 4, "21 Bài Học Cho Thế Kỷ 21" },
                    { 11, 2, null, 2, 7, "1984" },
                    { 12, 2, null, 2, 5, "To Kill a Mockingbird" },
                    { 13, 1, null, 3, 6, "Tội Ác và Hình Phạt" },
                    { 14, 1, null, 1, 4, "Nửa Xuân" },
                    { 15, 6, null, 8, 9, "The Power of Habit" },
                    { 16, 6, null, 1, 11, "Đi Tìm Lẽ Sống" },
                    { 17, 4, null, 3, 3, "Chiến Tranh và Hòa Bình" },
                    { 18, 8, null, 8, 8, "Bí Quyết Làm Giàu" },
                    { 19, 5, null, 8, 2, "Artificial Intelligence Basics" },
                    { 20, 4, null, 2, 7, "The Art of War" },
                    { 21, 11, null, 4, 20, "One Piece – Tập 1" },
                    { 22, 12, null, 8, 15, "Atomic Habits" },
                    { 23, 13, null, 2, 8, "Thơ Trẻ – Cố Quận" },
                    { 24, 14, null, 3, 10, "Lonely Planet Việt Nam" },
                    { 25, 15, null, 5, 12, "MasterChef – Công Thức Nấu Ăn" },
                    { 26, 11, null, 5, 25, "Doraemon – Tập 1" },
                    { 27, 12, null, 1, 7, "How to Win Friends & Influence People" },
                    { 28, 13, null, 7, 5, "Thơ Viết Cho Tuổi 20" },
                    { 29, 14, null, 6, 9, "1001 Địa Điểm Việt Nam" },
                    { 30, 15, null, 6, 14, "Cẩm Nang Nấu Ăn Gia Đình" },
                    { 31, 17, null, 9, 7, "Ông già và biển cả" },
                    { 32, 17, null, 10, 5, "Án mạng trên chuyến tàu tốc hành phương Đông" },
                    { 33, 18, null, 11, 4, "Con quạ và các truyện khác" },
                    { 34, 16, null, 9, 6, "Tản văn Du ký" },
                    { 35, 20, null, 11, 3, "Tinh thần triết học" },
                    { 36, 21, null, 12, 5, "2001: A Space Odyssey" },
                    { 37, 22, null, 13, 8, "Notebook – Nhật ký tình yêu" },
                    { 38, 23, null, 12, 10, "How to Win Friends" },
                    { 39, 24, null, 14, 7, "Rich Dad Poor Dad" },
                    { 40, 25, null, 13, 6, "7 Thói Quen Hiệu Quả" },
                    { 41, 26, null, 15, 5, "Lược sử phát minh" },
                    { 42, 27, null, 16, 7, "Harry Potter và Phòng Chứa Bí Ẩn" },
                    { 43, 28, null, 15, 3, "Luật Dân sự Việt Nam" },
                    { 44, 29, null, 15, 4, "Toán Cao Cấp – Đại cương" },
                    { 45, 30, null, 16, 6, "Y học cổ truyền Việt Nam" },
                    { 46, 5, null, 8, 15, "Lập Trình C# Toàn Tập" },
                    { 47, 5, null, 8, 8, "Thiết Kế Kiến Trúc Phần Mềm" },
                    { 48, 5, null, 8, 12, "Giải Thuật và Cấu Trúc Dữ Liệu" },
                    { 49, 5, null, 14, 10, "An Ninh Mạng Cơ Bản" },
                    { 50, 5, null, 12, 7, "Hướng Dẫn ReactJS" },
                    { 51, 25, null, 13, 9, "Kỹ Năng Giao Tiếp Trong Công Việc" },
                    { 52, 25, null, 13, 6, "Nghệ Thuật Thuyết Phục" },
                    { 53, 5, null, 8, 5, "Quản Trị Mạng CCNA" },
                    { 54, 5, null, 9, 11, "Phân Tích Dữ Liệu với Python" },
                    { 55, 5, null, 14, 4, "Machine Learning Cơ Bản" },
                    { 56, 5, null, 14, 5, "Deep Learning Cơ Bản" },
                    { 57, 25, null, 13, 8, "Kỹ Năng Lãnh Đạo" },
                    { 58, 5, null, 8, 7, "Phát Triển Ứng Dụng Android" },
                    { 59, 5, null, 9, 10, "C# Trong Thực Tiễn" },
                    { 60, 5, null, 12, 6, "Docker và Kubernetes" },
                    { 61, 6, null, 11, 9, "Phân Tích Hành Vi Người Dùng" },
                    { 62, 24, null, 10, 4, "Quản Trị Dự Án Agile" },
                    { 63, 5, null, 8, 5, "Kiến Trúc Microservices" },
                    { 64, 23, null, 9, 7, "Trò Chuyện Với Stanley" },
                    { 65, 14, null, 15, 3, "Hành Trình Về Phương Đông" },
                    { 66, 5, null, 12, 8, "Thiết Kế UX/UI Cơ Bản" },
                    { 67, 25, null, 13, 6, "Phương Pháp Đặt Câu Hỏi" },
                    { 68, 5, null, 8, 12, "Lập Trình Python" },
                    { 69, 9, null, 6, 5, "An Toàn Thực Phẩm" },
                    { 70, 14, null, 2, 7, "Kỹ Thuật Chụp Ảnh" },
                    { 71, 24, null, 10, 4, "Quản Lý Nhân Sự Hiện Đại" },
                    { 72, 12, null, 14, 9, "Sức Mạnh Thói Quen" },
                    { 73, 20, null, 3, 3, "Ngôn Ngữ Cơ Thể" },
                    { 74, 3, null, 1, 6, "Khoa Học Hành Vi" },
                    { 75, 25, null, 13, 8, "Thuyết Trình Tuyệt Đỉnh" },
                    { 76, 5, null, 14, 5, "Công Nghệ Blockchain" },
                    { 77, 28, null, 15, 4, "Luật Hình Sự Cơ Bản" },
                    { 78, 16, null, 9, 7, "Viết Kịch Bản Phim" },
                    { 79, 10, null, 2, 5, "Âm Nhạc Thế Kỷ 21" },
                    { 80, 24, null, 10, 6, "Khởi Nghiệp Tinh Gọn" },
                    { 81, 5, null, 8, 9, "Xử Lý Ngôn Ngữ Tự Nhiên" },
                    { 82, 6, null, 1, 10, "Psychology of Money" },
                    { 83, 24, null, 12, 5, "Nghiên Cứu Thị Trường" },
                    { 84, 25, null, 13, 7, "Châm Ngôn Thành Công" },
                    { 85, 6, null, 6, 4, "Sách Về Thiền Định" },
                    { 86, 10, null, 2, 6, "Lý Thuyết Âm Nhạc" },
                    { 87, 9, null, 6, 5, "Dinh Dưỡng Học" },
                    { 88, 29, null, 15, 3, "Thủy Văn Cơ Sở" },
                    { 89, 5, null, 8, 12, "Lập Trình Web Toàn Tập" },
                    { 90, 5, null, 14, 8, "Công Nghệ IoT" },
                    { 91, 24, null, 10, 5, "Quản Trị Rủi Ro" },
                    { 92, 13, null, 2, 7, "Thơ Tình Việt Nam" },
                    { 93, 14, null, 15, 6, "Du Lịch Tây Bắc" },
                    { 94, 5, null, 9, 4, "Quản Lý Dữ Liệu Lớn" },
                    { 95, 29, null, 15, 5, "Toán Rời Rạc" },
                    { 96, 5, null, 14, 3, "Blockchain trong Ngân Hàng" },
                    { 97, 5, null, 8, 7, "Xử Lý Ảnh Số" },
                    { 98, 24, null, 10, 5, "Phân Tích Tài Chính" },
                    { 99, 25, null, 13, 8, "Hạt Giống Tâm Hồn" },
                    { 100, 24, null, 10, 6, "Sách Về Chiến Lược" },
                    { 101, 5, null, 8, 9, "Thiết Kế Game" },
                    { 102, 24, null, 10, 4, "Quản Trị Công Nghệ" },
                    { 103, 5, null, 9, 7, "Phát Triển iOS" },
                    { 104, 13, null, 2, 5, "Thơ Trẻ" },
                    { 105, 15, null, 5, 10, "Ẩm Thực Việt" }
                });

            migrationBuilder.InsertData(
                table: "BorrowReceipts",
                columns: new[] { "ReceiptId", "BorrowDate", "ReturnDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1 },
                    { 2, new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 2 },
                    { 3, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overdue", 3 },
                    { 4, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotFullyReturned", 1 },
                    { 5, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 2 },
                    { 6, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 3 },
                    { 7, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 1 },
                    { 8, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 2 },
                    { 9, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 3 },
                    { 10, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 1 },
                    { 11, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 4 },
                    { 12, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 5 },
                    { 13, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 6 },
                    { 14, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 7 },
                    { 15, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotFullyReturned", 8 },
                    { 16, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 9 },
                    { 17, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 10 },
                    { 18, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 11 },
                    { 19, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overdue", 12 },
                    { 20, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotFullyReturned", 13 },
                    { 21, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 14 },
                    { 22, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 15 },
                    { 23, new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 16 },
                    { 24, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 17 },
                    { 25, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 18 }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 11, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 9, 7 },
                    { 14, 8 },
                    { 1, 9 },
                    { 2, 10 },
                    { 5, 10 },
                    { 10, 11 },
                    { 11, 12 },
                    { 12, 13 },
                    { 1, 14 },
                    { 8, 15 },
                    { 2, 16 },
                    { 5, 16 },
                    { 9, 17 },
                    { 2, 18 },
                    { 8, 18 },
                    { 14, 19 },
                    { 15, 20 },
                    { 16, 31 },
                    { 17, 32 },
                    { 18, 33 },
                    { 19, 34 },
                    { 20, 35 },
                    { 21, 36 },
                    { 22, 37 },
                    { 23, 38 },
                    { 24, 39 },
                    { 25, 40 },
                    { 26, 41 },
                    { 26, 42 },
                    { 27, 43 },
                    { 28, 44 },
                    { 29, 45 },
                    { 28, 46 },
                    { 29, 47 },
                    { 21, 48 },
                    { 21, 49 },
                    { 22, 50 },
                    { 23, 51 },
                    { 23, 52 },
                    { 14, 53 },
                    { 17, 54 },
                    { 24, 55 },
                    { 24, 56 },
                    { 25, 57 },
                    { 14, 58 },
                    { 16, 59 },
                    { 21, 60 },
                    { 27, 61 },
                    { 23, 62 },
                    { 22, 63 },
                    { 29, 64 },
                    { 26, 65 },
                    { 24, 66 },
                    { 25, 67 },
                    { 21, 68 },
                    { 27, 69 },
                    { 29, 70 },
                    { 23, 71 },
                    { 25, 72 },
                    { 29, 73 },
                    { 21, 74 },
                    { 23, 75 },
                    { 21, 76 },
                    { 22, 77 },
                    { 16, 78 },
                    { 10, 79 },
                    { 17, 80 },
                    { 14, 81 },
                    { 5, 82 },
                    { 12, 83 },
                    { 23, 84 },
                    { 15, 85 },
                    { 14, 86 },
                    { 8, 87 },
                    { 26, 88 },
                    { 21, 89 },
                    { 21, 90 },
                    { 23, 91 },
                    { 22, 92 },
                    { 26, 93 },
                    { 28, 94 },
                    { 27, 95 },
                    { 21, 96 },
                    { 24, 97 },
                    { 22, 98 },
                    { 25, 99 },
                    { 23, 100 },
                    { 22, 101 },
                    { 23, 102 },
                    { 22, 103 },
                    { 27, 104 },
                    { 26, 105 }
                });

            migrationBuilder.InsertData(
                table: "BorrowDetails",
                columns: new[] { "BookId", "ReceiptId", "ActualReturnDate", "FineAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 2, 1, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 3, 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 4, 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5, 3, null, null },
                    { 6, 3, null, null },
                    { 7, 4, null, null },
                    { 8, 5, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m },
                    { 9, 5, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000m },
                    { 10, 5, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.00m },
                    { 11, 6, null, null },
                    { 12, 6, null, null },
                    { 13, 7, null, null },
                    { 14, 7, null, null },
                    { 15, 8, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 16, 8, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 17, 9, null, null },
                    { 18, 9, null, null },
                    { 19, 10, null, null },
                    { 20, 10, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 19 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 15, 20 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 16, 31 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 17, 32 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 18, 33 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 19, 34 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 20, 35 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 36 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 37 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 38 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 24, 39 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 25, 40 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 26, 41 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 26, 42 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 27, 43 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 28, 44 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 29, 45 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 28, 46 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 29, 47 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 48 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 49 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 50 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 51 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 52 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 53 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 17, 54 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 24, 55 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 24, 56 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 25, 57 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 58 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 16, 59 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 60 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 27, 61 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 62 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 63 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 29, 64 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 26, 65 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 24, 66 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 25, 67 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 68 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 27, 69 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 29, 70 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 71 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 25, 72 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 29, 73 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 74 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 75 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 76 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 77 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 16, 78 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 10, 79 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 17, 80 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 81 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 5, 82 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 12, 83 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 84 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 15, 85 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 14, 86 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 8, 87 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 26, 88 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 89 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 90 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 91 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 92 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 26, 93 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 28, 94 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 27, 95 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 21, 96 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 24, 97 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 98 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 25, 99 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 100 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 101 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 23, 102 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 22, 103 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 27, 104 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 26, 105 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Publishers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "4001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "3001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptId",
                table: "BorrowReceipts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "6001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "5001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "2001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 2001, "Nguyễn Nhật Ánh" },
                    { 2002, "Hermione Granger" },
                    { 2003, "Paulo Coelho" },
                    { 2004, "Stephen Hawking" },
                    { 2005, "Yuval Noah Harari" },
                    { 2006, "J.K. Rowling" },
                    { 2007, "Daniel Kahneman" },
                    { 2008, "Tony Robbins" },
                    { 2009, "Malcolm Gladwell" },
                    { 2010, "George Orwell" },
                    { 2011, "Harper Lee" },
                    { 2012, "Fyodor Dostoevsky" },
                    { 2013, "Gabriel Garcia Marquez" },
                    { 2014, "Isaac Asimov" },
                    { 2015, "Sun Tzu" },
                    { 2016, "Ernest Hemingway" },
                    { 2017, "Agatha Christie" },
                    { 2018, "Edgar Allan Poe" },
                    { 2019, "Ralph Waldo Emerson" },
                    { 2020, "Đỗ Phấn" },
                    { 2021, "Arthur C. Clarke" },
                    { 2022, "Nicholas Sparks" },
                    { 2023, "Dale Carnegie" },
                    { 2024, "Robert Kiyosaki" },
                    { 2025, "Stephen R. Covey" },
                    { 2026, "Nguyễn Trãi" },
                    { 2027, "William Shakespeare" },
                    { 2028, "Sigmund Freud" },
                    { 2029, "Noam Chomsky" },
                    { 2030, "Trần Đại Nghĩa" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 3001, "Văn học Việt Nam" },
                    { 3002, "Văn học nước ngoài" },
                    { 3003, "Nghiên cứu khoa học" },
                    { 3004, "Lịch sử – Địa lý" },
                    { 3005, "Công nghệ thông tin" },
                    { 3006, "Tâm lý – Kỹ năng sống" },
                    { 3007, "Thiếu nhi" },
                    { 3008, "Kinh tế – Quản trị" },
                    { 3009, "Y học – Sức khỏe" },
                    { 3010, "Nghệ thuật – Kiến trúc" },
                    { 3011, "Truyện tranh – Manga" },
                    { 3012, "Tự lực – Phát triển bản thân" },
                    { 3013, "Thơ ca" },
                    { 3014, "Du lịch – Khám phá" },
                    { 3015, "Ẩm thực – Nấu ăn" },
                    { 3016, "Văn học trẻ" },
                    { 3017, "Tiểu thuyết trinh thám" },
                    { 3018, "Kinh dị – Giật gân" },
                    { 3019, "Thơ cách mạng" },
                    { 3020, "Tôn giáo – Triết học" },
                    { 3021, "Khoa học viễn tưởng" },
                    { 3022, "Lãng mạn – Tình cảm" },
                    { 3023, "Phát triển bản thân" },
                    { 3024, "Kinh doanh – Khởi nghiệp" },
                    { 3025, "Sách kỹ năng mềm" },
                    { 3026, "Văn hóa – Xã hội" },
                    { 3027, "Sách thiếu nhi – Thiếu niên" },
                    { 3028, "Sách luật pháp" },
                    { 3029, "Sách đại học" },
                    { 3030, "Sách chuyên ngành y" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Name" },
                values: new object[,]
                {
                    { 4001, "NXB Giáo dục Việt Nam" },
                    { 4002, "NXB Văn hóa – Thông tin" },
                    { 4003, "NXB Khoa học và Kỹ thuật" },
                    { 4004, "NXB Trẻ" },
                    { 4005, "NXB Kim Đồng" },
                    { 4006, "NXB Thống Kê" },
                    { 4007, "NXB Đại học Quốc gia" },
                    { 4008, "NXB Công nghệ Thông tin" },
                    { 4009, "NXB Hội Nhà văn" },
                    { 4010, "NXB Văn học" },
                    { 4011, "NXB Phụ nữ" },
                    { 4012, "NXB Tri thức" },
                    { 4013, "NXB Phương Đông" },
                    { 4014, "NXB Văn học Đông Á" },
                    { 4015, "NXB Đại học Quốc gia TP.HCM" },
                    { 4016, "NXB An ninh quốc gia" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "FullName", "Password", "Phone", "UserType", "Username" },
                values: new object[,]
                {
                    { 1001, "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội", "vanvu@gmail.com", "Nguyễn Văn Vũ", null, "0912345678", "Customer", "nguyenvanvu" },
                    { 1002, "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ", "thiba@gmail.com", "Trần Thị Ba", null, "0987654321", "Customer", "tranthiba" },
                    { 1003, "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh", "vanchi@gmail.com", "Lê Văn Chi", null, "0901234567", "Customer", "levanchi" },
                    { 1004, "Số 22, Đường Láng Hạ, Phường Láng Hạ, Quận Đống Đa, Hà Nội", "dungpham@gmail.com", "Phạm Thị Dung", null, "0918765432", "Customer", "phamthidung" },
                    { 1005, "Số 99, Đường Trần Phú, Phường 5, TP. Vũng Tàu", "anvo@gmail.com", "Võ Văn An", null, "0932123456", "Customer", "vovan_an" },
                    { 1006, "Số 5, Phố Hoàng Diệu, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng", "hienly@gmail.com", "Lý Thị Hiền", null, "0983344556", "Customer", "lythihien" },
                    { 1007, "Số 150, Đường Cách Mạng Tháng 8, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh", "tuanngo@gmail.com", "Ngô Minh Tuấn", null, "0909988776", "Customer", "ngominhtuan" },
                    { 1008, "Số 10, Đường Hai Bà Trưng, Phường Phạm Ngũ Lão, Quận 1, TP. Hồ Chí Minh", "lan.dang@gmail.com", "Đặng Thị Lan", null, "0911223344", "Customer", "dangthilan" },
                    { 1009, "Số 8, Đường Nguyễn Thị Minh Khai, Phường 1, TP. Vĩnh Long", "vanhoa.phan@gmail.com", "Phan Văn Hòa", null, "0977554433", "Customer", "phanvanhoa" },
                    { 1010, "Số 120, Đường Phan Đình Phùng, Phường Thành Nhất, TP. Buôn Ma Thuột", "maitruong@gmail.com", "Trương Thị Mai", null, "0911335577", "Customer", "truongthimai" },
                    { 1011, "Số 33, Phố Lý Thường Kiệt, Phường Phủ Hà, TP. Lạng Sơn", "quocviet.bui@gmail.com", "Bùi Quốc Việt", null, "0987665544", "Customer", "buiquo cviet" },
                    { 1012, "Số 27, Đường Hùng Vương, Phường Mỹ Xuyên, TP. Sóc Trăng", "phuongle@gmail.com", "Lê Thị Phương", null, "0968877665", "Customer", "lethiphuong" },
                    { 1013, "Số 55, Đường Trần Hưng Đạo, Phường Lê Lợi, TP. Nam Định", "minhtu.do@gmail.com", "Đỗ Minh Tú", null, "0933445566", "Customer", "dominhtu" },
                    { 1014, "Số 18, Đường Lê Lợi, Phường An Lạc, TP. Biên Hòa", "minhquan.pham@gmail.com", "Phạm Minh Quân", null, "0914556677", "Customer", "phamminhquan" },
                    { 1015, "Số 66, Phố Trần Nhân Tông, Phường Nam Đàn, TP. Thanh Hóa", "ngocvu@gmail.com", "Vũ Thị Ngọc", null, "0988112233", "Customer", "vuthingoc" },
                    { 1016, "Số 102, Đường Trần Phú, Phường Xuân Phú, TP. Huế", "quoccuong.nguyen@gmail.com", "Nguyễn Quốc Cường", null, "0902334455", "Customer", "nguyencuong" },
                    { 1017, "Số 5, Đường Nguyễn Văn Trỗi, Phường Đông Vệ, TP. Thanh Hóa", "thuyhang.le@gmail.com", "Lê Thúy Hằng", null, "0977665544", "Customer", "lethuyhang" },
                    { 1018, "Số 250, Đường Nguyễn Thái Học, Phường Phan Chu Trinh, TP. Quy Nhơn", "anhtuan.tran@gmail.com", "Trần Anh Tuấn", null, "0933667788", "Customer", "trananhtuan" },
                    { 1019, "Số 14, Đường Nguyễn Huệ, Phường Phước Ninh, TP. Đà Nẵng", "hanhphan@gmail.com", "Phan Thị Hạnh", null, "0901778899", "Customer", "phanthihanh" },
                    { 1020, "Số 77, Phố Phan Đình Phùng, Phường Đội Cấn, Quận Ba Đình, Hà Nội", "sontruong@gmail.com", "Trương Văn Sơn", null, "0977001122", "Customer", "truongvanson" },
                    { 1021, "Số 33, Đường Trần Khánh Dư, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội", "leminhtam@gmail.com", "Lê Minh Tâm", null, "0912993344", "Customer", "leminhtam" },
                    { 1022, "Số 55, Đường Đinh Tiên Hoàng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh", "phucdang@gmail.com", "Đặng Văn Phúc", null, "0933100234", "Customer", "dangvanphuc" },
                    { 1023, "Số 99, Đường Lý Tự Trọng, Phường Phú Hòa, TP. Thủ Dầu Một", "kieuvo@gmail.com", "Võ Thị Kiều", null, "0988776655", "Customer", "vothikieu" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "PublisherId", "StockQuantity", "Title" },
                values: new object[,]
                {
                    { 5001, 3007, null, 4005, 12, "Dế Mèn Phiêu Lưu Ký" },
                    { 5002, 3002, null, 4002, 8, "Hoàng Tử Bé" },
                    { 5003, 3001, null, 4004, 5, "Nhà Giả Kim" },
                    { 5004, 3003, null, 4003, 3, "Lược Sử Thời Gian" },
                    { 5005, 3004, null, 4003, 4, "Sapiens: Lược Sử Loài Người" },
                    { 5006, 3007, null, 4005, 6, "Harry Potter và Hòn Đá Phù Thủy" },
                    { 5007, 3006, null, 4008, 10, "Tư Duy, Nhanh và Chậm" },
                    { 5008, 3005, null, 4008, 2, "Cấu Trúc Dữ Liệu và Giải Thuật" },
                    { 5009, 3001, null, 4002, 5, "Trên Đường" },
                    { 5010, 3006, null, 4001, 4, "21 Bài Học Cho Thế Kỷ 21" },
                    { 5011, 3002, null, 4002, 7, "1984" },
                    { 5012, 3002, null, 4002, 5, "To Kill a Mockingbird" },
                    { 5013, 3001, null, 4003, 6, "Tội Ác và Hình Phạt" },
                    { 5014, 3001, null, 4001, 4, "Nửa Xuân" },
                    { 5015, 3006, null, 4008, 9, "The Power of Habit" },
                    { 5016, 3006, null, 4001, 11, "Đi Tìm Lẽ Sống" },
                    { 5017, 3004, null, 4003, 3, "Chiến Tranh và Hòa Bình" },
                    { 5018, 3008, null, 4008, 8, "Bí Quyết Làm Giàu" },
                    { 5019, 3005, null, 4008, 2, "Artificial Intelligence Basics" },
                    { 5020, 3004, null, 4002, 7, "The Art of War" },
                    { 5021, 3011, null, 4004, 20, "One Piece – Tập 1" },
                    { 5022, 3012, null, 4008, 15, "Atomic Habits" },
                    { 5023, 3013, null, 4002, 8, "Thơ Trẻ – Cố Quận" },
                    { 5024, 3014, null, 4003, 10, "Lonely Planet Việt Nam" },
                    { 5025, 3015, null, 4005, 12, "MasterChef – Công Thức Nấu Ăn" },
                    { 5026, 3011, null, 4005, 25, "Doraemon – Tập 1" },
                    { 5027, 3012, null, 4001, 7, "How to Win Friends & Influence People" },
                    { 5028, 3013, null, 4007, 5, "Thơ Viết Cho Tuổi 20" },
                    { 5029, 3014, null, 4006, 9, "1001 Địa Điểm Việt Nam" },
                    { 5030, 3015, null, 4006, 14, "Cẩm Nang Nấu Ăn Gia Đình" },
                    { 5031, 3017, null, 4009, 7, "Ông già và biển cả" },
                    { 5032, 3017, null, 4010, 5, "Án mạng trên chuyến tàu tốc hành phương Đông" },
                    { 5033, 3018, null, 4011, 4, "Con quạ và các truyện khác" },
                    { 5034, 3016, null, 4009, 6, "Tản văn Du ký" },
                    { 5035, 3020, null, 4011, 3, "Tinh thần triết học" },
                    { 5036, 3021, null, 4012, 5, "2001: A Space Odyssey" },
                    { 5037, 3022, null, 4013, 8, "Notebook – Nhật ký tình yêu" },
                    { 5038, 3023, null, 4012, 10, "How to Win Friends" },
                    { 5039, 3024, null, 4014, 7, "Rich Dad Poor Dad" },
                    { 5040, 3025, null, 4013, 6, "7 Thói Quen Hiệu Quả" },
                    { 5041, 3026, null, 4015, 5, "Lược sử phát minh" },
                    { 5042, 3027, null, 4016, 7, "Harry Potter và Phòng Chứa Bí Ẩn" },
                    { 5043, 3028, null, 4015, 3, "Luật Dân sự Việt Nam" },
                    { 5044, 3029, null, 4015, 4, "Toán Cao Cấp – Đại cương" },
                    { 5045, 3030, null, 4016, 6, "Y học cổ truyền Việt Nam" },
                    { 5046, 3005, null, 4008, 15, "Lập Trình C# Toàn Tập" },
                    { 5047, 3005, null, 4008, 8, "Thiết Kế Kiến Trúc Phần Mềm" },
                    { 5048, 3005, null, 4008, 12, "Giải Thuật và Cấu Trúc Dữ Liệu" },
                    { 5049, 3005, null, 4014, 10, "An Ninh Mạng Cơ Bản" },
                    { 5050, 3005, null, 4012, 7, "Hướng Dẫn ReactJS" },
                    { 5051, 3025, null, 4013, 9, "Kỹ Năng Giao Tiếp Trong Công Việc" },
                    { 5052, 3025, null, 4013, 6, "Nghệ Thuật Thuyết Phục" },
                    { 5053, 3005, null, 4008, 5, "Quản Trị Mạng CCNA" },
                    { 5054, 3005, null, 4009, 11, "Phân Tích Dữ Liệu với Python" },
                    { 5055, 3005, null, 4014, 4, "Machine Learning Cơ Bản" },
                    { 5056, 3005, null, 4014, 5, "Deep Learning Cơ Bản" },
                    { 5057, 3025, null, 4013, 8, "Kỹ Năng Lãnh Đạo" },
                    { 5058, 3005, null, 4008, 7, "Phát Triển Ứng Dụng Android" },
                    { 5059, 3005, null, 4009, 10, "C# Trong Thực Tiễn" },
                    { 5060, 3005, null, 4012, 6, "Docker và Kubernetes" },
                    { 5061, 3006, null, 4011, 9, "Phân Tích Hành Vi Người Dùng" },
                    { 5062, 3024, null, 4010, 4, "Quản Trị Dự Án Agile" },
                    { 5063, 3005, null, 4008, 5, "Kiến Trúc Microservices" },
                    { 5064, 3023, null, 4009, 7, "Trò Chuyện Với Stanley" },
                    { 5065, 3014, null, 4015, 3, "Hành Trình Về Phương Đông" },
                    { 5066, 3005, null, 4012, 8, "Thiết Kế UX/UI Cơ Bản" },
                    { 5067, 3025, null, 4013, 6, "Phương Pháp Đặt Câu Hỏi" },
                    { 5068, 3005, null, 4008, 12, "Lập Trình Python" },
                    { 5069, 3009, null, 4006, 5, "An Toàn Thực Phẩm" },
                    { 5070, 3014, null, 4002, 7, "Kỹ Thuật Chụp Ảnh" },
                    { 5071, 3024, null, 4010, 4, "Quản Lý Nhân Sự Hiện Đại" },
                    { 5072, 3012, null, 4014, 9, "Sức Mạnh Thói Quen" },
                    { 5073, 3020, null, 4003, 3, "Ngôn Ngữ Cơ Thể" },
                    { 5074, 3003, null, 4001, 6, "Khoa Học Hành Vi" },
                    { 5075, 3025, null, 4013, 8, "Thuyết Trình Tuyệt Đỉnh" },
                    { 5076, 3005, null, 4014, 5, "Công Nghệ Blockchain" },
                    { 5077, 3028, null, 4015, 4, "Luật Hình Sự Cơ Bản" },
                    { 5078, 3016, null, 4009, 7, "Viết Kịch Bản Phim" },
                    { 5079, 3010, null, 4002, 5, "Âm Nhạc Thế Kỷ 21" },
                    { 5080, 3024, null, 4010, 6, "Khởi Nghiệp Tinh Gọn" },
                    { 5081, 3005, null, 4008, 9, "Xử Lý Ngôn Ngữ Tự Nhiên" },
                    { 5082, 3006, null, 4001, 10, "Psychology of Money" },
                    { 5083, 3024, null, 4012, 5, "Nghiên Cứu Thị Trường" },
                    { 5084, 3025, null, 4013, 7, "Châm Ngôn Thành Công" },
                    { 5085, 3006, null, 4006, 4, "Sách Về Thiền Định" },
                    { 5086, 3010, null, 4002, 6, "Lý Thuyết Âm Nhạc" },
                    { 5087, 3009, null, 4006, 5, "Dinh Dưỡng Học" },
                    { 5088, 3029, null, 4015, 3, "Thủy Văn Cơ Sở" },
                    { 5089, 3005, null, 4008, 12, "Lập Trình Web Toàn Tập" },
                    { 5090, 3005, null, 4014, 8, "Công Nghệ IoT" },
                    { 5091, 3024, null, 4010, 5, "Quản Trị Rủi Ro" },
                    { 5092, 3013, null, 4002, 7, "Thơ Tình Việt Nam" },
                    { 5093, 3014, null, 4015, 6, "Du Lịch Tây Bắc" },
                    { 5094, 3005, null, 4009, 4, "Quản Lý Dữ Liệu Lớn" },
                    { 5095, 3029, null, 4015, 5, "Toán Rời Rạc" },
                    { 5096, 3005, null, 4014, 3, "Blockchain trong Ngân Hàng" },
                    { 5097, 3005, null, 4008, 7, "Xử Lý Ảnh Số" },
                    { 5098, 3024, null, 4010, 5, "Phân Tích Tài Chính" },
                    { 5099, 3025, null, 4013, 8, "Hạt Giống Tâm Hồn" },
                    { 5100, 3024, null, 4010, 6, "Sách Về Chiến Lược" },
                    { 5101, 3005, null, 4008, 9, "Thiết Kế Game" },
                    { 5102, 3024, null, 4010, 4, "Quản Trị Công Nghệ" },
                    { 5103, 3005, null, 4009, 7, "Phát Triển iOS" },
                    { 5104, 3013, null, 4002, 5, "Thơ Trẻ" },
                    { 5105, 3015, null, 4005, 10, "Ẩm Thực Việt" }
                });

            migrationBuilder.InsertData(
                table: "BorrowReceipts",
                columns: new[] { "ReceiptId", "BorrowDate", "ReturnDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 6001, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1001 },
                    { 6002, new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1002 },
                    { 6003, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1003 },
                    { 6004, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1001 },
                    { 6005, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1002 },
                    { 6006, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1003 },
                    { 6007, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1001 },
                    { 6008, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1002 },
                    { 6009, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1003 },
                    { 6010, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1001 },
                    { 6011, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1004 },
                    { 6012, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1005 },
                    { 6013, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1006 },
                    { 6014, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1007 },
                    { 6015, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1008 },
                    { 6016, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1009 },
                    { 6017, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1010 },
                    { 6018, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1011 },
                    { 6019, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1012 },
                    { 6020, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1013 },
                    { 6021, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1014 },
                    { 6022, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1015 },
                    { 6023, new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1016 },
                    { 6024, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1017 },
                    { 6025, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1018 }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 2001, 5001 },
                    { 2003, 5002 },
                    { 2003, 5003 },
                    { 2011, 5003 },
                    { 2004, 5004 },
                    { 2005, 5005 },
                    { 2006, 5006 },
                    { 2007, 5007 },
                    { 2009, 5007 },
                    { 2014, 5008 },
                    { 2001, 5009 },
                    { 2002, 5010 },
                    { 2005, 5010 },
                    { 2010, 5011 },
                    { 2011, 5012 },
                    { 2012, 5013 },
                    { 2001, 5014 },
                    { 2008, 5015 },
                    { 2002, 5016 },
                    { 2005, 5016 },
                    { 2009, 5017 },
                    { 2002, 5018 },
                    { 2008, 5018 },
                    { 2014, 5019 },
                    { 2015, 5020 },
                    { 2016, 5031 },
                    { 2017, 5032 },
                    { 2018, 5033 },
                    { 2019, 5034 },
                    { 2020, 5035 },
                    { 2021, 5036 },
                    { 2022, 5037 },
                    { 2023, 5038 },
                    { 2024, 5039 },
                    { 2025, 5040 },
                    { 2026, 5041 },
                    { 2026, 5042 },
                    { 2027, 5043 },
                    { 2028, 5044 },
                    { 2029, 5045 },
                    { 2028, 5046 },
                    { 2029, 5047 },
                    { 2021, 5048 },
                    { 2021, 5049 },
                    { 2022, 5050 },
                    { 2023, 5051 },
                    { 2023, 5052 },
                    { 2014, 5053 },
                    { 2017, 5054 },
                    { 2024, 5055 },
                    { 2024, 5056 },
                    { 2025, 5057 },
                    { 2014, 5058 },
                    { 2016, 5059 },
                    { 2021, 5060 },
                    { 2027, 5061 },
                    { 2023, 5062 },
                    { 2022, 5063 },
                    { 2029, 5064 },
                    { 2026, 5065 },
                    { 2024, 5066 },
                    { 2025, 5067 },
                    { 2021, 5068 },
                    { 2027, 5069 },
                    { 2029, 5070 },
                    { 2023, 5071 },
                    { 2025, 5072 },
                    { 2029, 5073 },
                    { 2021, 5074 },
                    { 2023, 5075 },
                    { 2021, 5076 },
                    { 2022, 5077 },
                    { 2016, 5078 },
                    { 2010, 5079 },
                    { 2017, 5080 },
                    { 2014, 5081 },
                    { 2005, 5082 },
                    { 2012, 5083 },
                    { 2023, 5084 },
                    { 2015, 5085 },
                    { 2014, 5086 },
                    { 2008, 5087 },
                    { 2026, 5088 },
                    { 2021, 5089 },
                    { 2021, 5090 },
                    { 2023, 5091 },
                    { 2022, 5092 },
                    { 2026, 5093 },
                    { 2028, 5094 },
                    { 2027, 5095 },
                    { 2021, 5096 },
                    { 2024, 5097 },
                    { 2022, 5098 },
                    { 2025, 5099 },
                    { 2023, 5100 },
                    { 2022, 5101 },
                    { 2023, 5102 },
                    { 2022, 5103 },
                    { 2027, 5104 },
                    { 2026, 5105 }
                });

            migrationBuilder.InsertData(
                table: "BorrowDetails",
                columns: new[] { "BookId", "ReceiptId", "ActualReturnDate", "FineAmount" },
                values: new object[,]
                {
                    { 5001, 6001, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5002, 6001, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5003, 6002, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5004, 6002, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5005, 6003, null, null },
                    { 5006, 6003, null, null },
                    { 5007, 6004, null, null },
                    { 5008, 6005, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m },
                    { 5009, 6005, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000m },
                    { 5010, 6005, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.00m },
                    { 5011, 6006, null, null },
                    { 5012, 6006, null, null },
                    { 5013, 6007, null, null },
                    { 5014, 6007, null, null },
                    { 5015, 6008, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5016, 6008, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5017, 6009, null, null },
                    { 5018, 6009, null, null },
                    { 5019, 6010, null, null },
                    { 5020, 6010, null, null }
                });
        }
    }
}
