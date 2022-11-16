using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Views.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                                    CREATE VIEW vm_PersonOrders
                                    AS
                                    SELECT TOP 100 p.Name, COUNT(*) [Count] FROM Persons p 
                                    Inner Join Orders o ON o.PersonId = p.PersonId
                                    GROUP BY p.Name
                                    ORDER BY [Count] DESC
                                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP VIEW vm_PersonOrders");
        }
    }
}
