using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoredProcedures.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"CREATE PROCEDURE sp_bestSellingStaff
                                    AS
                                    Declare @name NVARCHAR(MAX), @count INT
                                    SELECT TOP 1 @name = p.Name,@count = COUNT(*) FROM Persons p 
                                    Join Orders o
                                    	ON p.PersonId = o.PersonId
                                    GROUP BY p.Name
                                    ORDER BY COUNT(*) DESC
                                    Return @count");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP PROCEDURE sp_bestSellingStaff");
        }
    }
}
