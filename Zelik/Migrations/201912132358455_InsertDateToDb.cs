namespace Zelik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDateToDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES(1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(3, 'Drame')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(5, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(6, 'Family')");

            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES(1, 0, 0, 0, 'Pay As you Go')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES(2, 30, 1, 10, 'Monthly')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES(3, 90, 3, 15, 'Quaterly')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES(4, 300, 12, 20, 'Yearly')");


        }

        public override void Down()
        {
        }
    }
}
