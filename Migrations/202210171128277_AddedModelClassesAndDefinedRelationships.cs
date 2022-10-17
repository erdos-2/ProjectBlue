namespace ProjectBlue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModelClassesAndDefinedRelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Username = c.String(),
                        AccountType = c.String(),
                        EmailType = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Offerings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceOptions = c.String(),
                        EWT = c.Int(nullable: false),
                        ETA = c.Int(nullable: false),
                        MealOfTheDay = c.String(),
                        CourseOfMeal = c.String(),
                        Cuisine = c.String(),
                        RestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                        Name = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        ServiceOptions = c.String(),
                        WorkingHours = c.String(),
                        ManagerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Managers", t => t.ManagerId, cascadeDelete: true)
                .Index(t => t.ManagerId);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Username = c.String(),
                        AccountType = c.String(),
                        EmailType = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomersOfferingsFav",
                c => new
                    {
                        FavoringCustomerId = c.Int(nullable: false),
                        FavoriteOfferingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FavoringCustomerId, t.FavoriteOfferingId })
                .ForeignKey("dbo.Customers", t => t.FavoringCustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Offerings", t => t.FavoriteOfferingId, cascadeDelete: true)
                .Index(t => t.FavoringCustomerId)
                .Index(t => t.FavoriteOfferingId);
            
            CreateTable(
                "dbo.CustomersRestaurantsFav",
                c => new
                    {
                        FavoringCustomerId = c.Int(nullable: false),
                        FavoriteRestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FavoringCustomerId, t.FavoriteRestaurantId })
                .ForeignKey("dbo.Customers", t => t.FavoringCustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.FavoriteRestaurantId, cascadeDelete: true)
                .Index(t => t.FavoringCustomerId)
                .Index(t => t.FavoriteRestaurantId);
            
            CreateTable(
                "dbo.CustomersOfferingsOrd",
                c => new
                    {
                        OrderingCustomerId = c.Int(nullable: false),
                        OrderedOfferingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderingCustomerId, t.OrderedOfferingId })
                .ForeignKey("dbo.Customers", t => t.OrderingCustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Offerings", t => t.OrderedOfferingId, cascadeDelete: true)
                .Index(t => t.OrderingCustomerId)
                .Index(t => t.OrderedOfferingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomersOfferingsOrd", "OrderedOfferingId", "dbo.Offerings");
            DropForeignKey("dbo.CustomersOfferingsOrd", "OrderingCustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomersRestaurantsFav", "FavoriteRestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.CustomersRestaurantsFav", "FavoringCustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomersOfferingsFav", "FavoriteOfferingId", "dbo.Offerings");
            DropForeignKey("dbo.CustomersOfferingsFav", "FavoringCustomerId", "dbo.Customers");
            DropForeignKey("dbo.Offerings", "RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurants", "ManagerId", "dbo.Managers");
            DropIndex("dbo.CustomersOfferingsOrd", new[] { "OrderedOfferingId" });
            DropIndex("dbo.CustomersOfferingsOrd", new[] { "OrderingCustomerId" });
            DropIndex("dbo.CustomersRestaurantsFav", new[] { "FavoriteRestaurantId" });
            DropIndex("dbo.CustomersRestaurantsFav", new[] { "FavoringCustomerId" });
            DropIndex("dbo.CustomersOfferingsFav", new[] { "FavoriteOfferingId" });
            DropIndex("dbo.CustomersOfferingsFav", new[] { "FavoringCustomerId" });
            DropIndex("dbo.Restaurants", new[] { "ManagerId" });
            DropIndex("dbo.Offerings", new[] { "RestaurantId" });
            DropTable("dbo.CustomersOfferingsOrd");
            DropTable("dbo.CustomersRestaurantsFav");
            DropTable("dbo.CustomersOfferingsFav");
            DropTable("dbo.Managers");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Offerings");
            DropTable("dbo.Customers");
        }
    }
}
