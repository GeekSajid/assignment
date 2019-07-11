namespace A4AeroAssisgment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDBwithagentstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessEntities",
                c => new
                    {
                        BusinessId = c.Long(nullable: false, identity: true),
                        Code = c.String(maxLength: 50),
                        Email = c.String(),
                        Name = c.String(),
                        Street = c.String(),
                        City = c.String(maxLength: 150),
                        State = c.String(maxLength: 150),
                        Zip = c.String(maxLength: 50),
                        Country = c.String(maxLength: 150),
                        Mobile = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        ContactPerson = c.String(),
                        ReferredBy = c.String(maxLength: 50),
                        Logo = c.String(),
                        Status = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LoginUrl = c.String(maxLength: 50),
                        SecurityCode = c.String(maxLength: 50),
                        SMTPServer = c.String(maxLength: 50),
                        SMTPPort = c.Int(nullable: false),
                        SMTPUsername = c.String(maxLength: 50),
                        SMTPPassword = c.String(maxLength: 50),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOnUtc = c.DateTime(),
                        UpdatedOnUtc = c.DateTime(),
                        CurrentBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BusinessId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusinessEntities");
        }
    }
}
