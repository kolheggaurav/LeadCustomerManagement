namespace LeadCustomerManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedLeadModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Leads", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Leads", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Leads", "Contact", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Leads", "Company", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Leads", "Company", c => c.String());
            AlterColumn("dbo.Leads", "Contact", c => c.String());
            AlterColumn("dbo.Leads", "Email", c => c.String());
            AlterColumn("dbo.Leads", "Name", c => c.String());
        }
    }
}
