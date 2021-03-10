namespace TurkTicaretCRM.TT.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerDebitUp : DbMigration
    {
        public override void Up()
        {
            AddColumn("CustomerDebits", "DebitReason", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("CustomerDebits", "DebitReason");
        }
    }
}
