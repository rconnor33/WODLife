Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class WODTableChanges_Jul14_1530
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Wods", "wodDescription", Function(c) c.String())
            AddColumn("dbo.Wods", "wodTypeID", Function(c) c.Int(nullable := False))
            AddColumn("dbo.Wods", "wodType", Function(c) c.String(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Wods", "wodType")
            DropColumn("dbo.Wods", "wodTypeID")
            DropColumn("dbo.Wods", "wodDescription")
        End Sub
    End Class
End Namespace
