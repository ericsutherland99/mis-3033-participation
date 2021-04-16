Imports System.Web.Mvc

Namespace Controllers
    Public Class ChuckController
        Inherits Controller

        ' GET: Chuck
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace