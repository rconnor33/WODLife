Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class WodTypeTable2
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.WodTypes",
                Function(c) New With
                    {
                        .wodTypeID = c.Int(nullable := False, identity := True),
                        .wodType = c.String()
                    }) _
                .PrimaryKey(Function(t) t.wodTypeID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.WodTypes")
        End Sub
    End Class
End Namespace
