Public NotInheritable Class frmSplash

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'Заголовок приложения
        If My.Application.Info.Title <> "" Then
            ' ApplicationTitle.Text = My.Application.Info.ProductName
        Else
            'Если у приложения нет заголовка, использовать имя приложения без расширения
            ' ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If


        ' Version.Text = String.Format("Версия {0}", My.Application.Info.Version.ToString)

        'Информация об авторских правах
        ' Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
