Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class ScoreTableAdded
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Scores",
                Function(c) New With
                    {
                        .scoreID = c.Int(nullable := False, identity := True),
                        .userID = c.Int(nullable := False),
                        .wodID = c.Int(nullable := False),
                        .scalingNotes = c.String(),
                        .scoreDate = c.DateTime(nullable := False),
                        .scoreRounds = c.Int(nullable := False),
                        .scoreReps = c.Int(nullable := False),
                        .scoreTime = c.DateTime(nullable := False),
                        .scoreWeight = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .User_Id = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.scoreID) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.User_Id) _
                .ForeignKey("dbo.Wods", Function(t) t.wodID, cascadeDelete := True) _
                .Index(Function(t) t.wodID) _
                .Index(Function(t) t.User_Id)
            
            CreateIndex("dbo.Wods", "wodTypeID")
            AddForeignKey("dbo.Wods", "wodTypeID", "dbo.WodTypes", "wodTypeID", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Scores", "wodID", "dbo.Wods")
            DropForeignKey("dbo.Scores", "User_Id", "dbo.AspNetUsers")
            DropForeignKey("dbo.Wods", "wodTypeID", "dbo.WodTypes")
            DropIndex("dbo.Scores", New String() { "User_Id" })
            DropIndex("dbo.Scores", New String() { "wodID" })
            DropIndex("dbo.Wods", New String() { "wodTypeID" })
            DropTable("dbo.Scores")
        End Sub
    End Class
End Namespace
