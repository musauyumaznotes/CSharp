using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stored_Procedures.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"CREATE PROCEDURE sp_PersonOrders
                                    AS
                                        SELECT p.Name,COUNT(*) [Count] FROM Persons p 
                                        Join Orders o
                                        	ON p.PersonId = o.PersonId
                                        GROUP BY p.Name
                                        ORDER BY COUNT(*) DESC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP PROC sp_PersonOrders");
        }
    }
}
