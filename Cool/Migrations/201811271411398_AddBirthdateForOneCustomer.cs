namespace Cool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateForOneCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = 1995/02/22 WHERE Id = 1 ");
        }
        
        public override void Down()
        {
        }
    }
}
