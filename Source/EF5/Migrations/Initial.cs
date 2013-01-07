namespace EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingridients",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IngridientPizzas",
                c => new
                    {
                        Ingridient_Id = c.Guid(nullable: false),
                        Pizza_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ingridient_Id, t.Pizza_Id })
                .ForeignKey("dbo.Ingridients", t => t.Ingridient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_Id, cascadeDelete: true)
                .Index(t => t.Ingridient_Id)
                .Index(t => t.Pizza_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.IngridientPizzas", new[] { "Pizza_Id" });
            DropIndex("dbo.IngridientPizzas", new[] { "Ingridient_Id" });
            DropForeignKey("dbo.IngridientPizzas", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.IngridientPizzas", "Ingridient_Id", "dbo.Ingridients");
            DropTable("dbo.IngridientPizzas");
            DropTable("dbo.Ingridients");
            DropTable("dbo.Pizzas");
        }
    }
}
