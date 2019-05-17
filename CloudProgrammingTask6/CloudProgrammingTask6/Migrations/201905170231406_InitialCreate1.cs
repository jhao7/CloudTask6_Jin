namespace CloudProgrammingTask6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BookingRecords", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookingRecords", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookingRecords", "Gender", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookingRecords", "Departure", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookingRecords", "Arrival", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookingRecords", "FlightNumber", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BookingRecords", "FlightNumber", c => c.String());
            AlterColumn("dbo.BookingRecords", "Arrival", c => c.String());
            AlterColumn("dbo.BookingRecords", "Departure", c => c.String());
            AlterColumn("dbo.BookingRecords", "Gender", c => c.String());
            AlterColumn("dbo.BookingRecords", "LastName", c => c.String());
            AlterColumn("dbo.BookingRecords", "FirstName", c => c.String());
        }
    }
}
