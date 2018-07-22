Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class WodTypeTable3
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Wods", "wodTypeID", Function(c) c.Int(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Wods", "wodTypeID")
        End Sub
    End Class
End Namespace
