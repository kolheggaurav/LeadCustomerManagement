namespace LeadCustomerManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Leads",
                c => new
                    {
                        LeadId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.LeadId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leads");
            DropTable("dbo.Customers");
        }
    }
}
