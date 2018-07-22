Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class WodTypeTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.Wods", "wodTypeID")
            DropColumn("dbo.Wods", "wodType")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Wods", "wodType", Function(c) c.String())
            AddColumn("dbo.Wods", "wodTypeID", Function(c) c.Int(nullable := False))
        End Sub
    End Class
End Namespace
