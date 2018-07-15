Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AdditonalWODDetails_July15_1220
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Wods", "wodNotes", Function(c) c.String())
            AlterColumn("dbo.Wods", "wodName", Function(c) c.String())
            AlterColumn("dbo.Wods", "wodType", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Wods", "wodType", Function(c) c.String(nullable := False))
            AlterColumn("dbo.Wods", "wodName", Function(c) c.String(nullable := False))
            DropColumn("dbo.Wods", "wodNotes")
        End Sub
    End Class
End Namespace
