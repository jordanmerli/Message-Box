Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = "Codice Sorgente Visual BASIC"
        MsgBox(TextBox1.Text, Title:=TextBox2.Text)
        MsgBox("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")", Title:="CODICE VB")
        TextBox3.Text = ("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox3.Text = "Codice Sorgente Visual BASIC"
        MsgBox(TextBox1.Text, MsgBoxStyle.Exclamation, Title:=TextBox2.Text)
        MsgBox("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.Exclamation, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")", Title:="CODICE VB")
        TextBox3.Text = ("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.Exclamation, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Text = "Codice Sorgente Visual BASIC"
        MsgBox(TextBox1.Text, MsgBoxStyle.YesNo, Title:=TextBox2.Text)
        MsgBox("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.YesNo, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")", Title:="CODICE VB")
        TextBox3.Text = ("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.YesNo, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")")
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox3.Text = "Codice Sorgente Visual BASIC"
        MsgBox(TextBox1.Text, MsgBoxStyle.OkCancel, Title:=TextBox2.Text)
        MsgBox("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.OkCancel, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")", Title:="CODICE VB")
        TextBox3.Text = ("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.OkCancel, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox3.Text = "Codice Sorgente Visual BASIC"
        MsgBox(TextBox1.Text, MsgBoxStyle.Critical, Title:=TextBox2.Text)
        MsgBox("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.Critical, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")", Title:="CODICE VB")
        TextBox3.Text = ("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.Critical, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox3.Text = "Codice Sorgente Visual BASIC"
        MsgBox(TextBox1.Text, MsgBoxStyle.Information, Title:=TextBox2.Text)
        MsgBox("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.Information, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")", Title:="CODICE VB")
        TextBox3.Text = ("MsgBox(" + Label2.Text + TextBox1.Text + Label2.Text + ", " + "MsgBoxStyle.Information, " + "Title:=" + Label2.Text + TextBox2.Text + Label2.Text + ")")
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:joe_nanoteck@hotmail.it")
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://nanoteck.altervista.org")
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Clipboard.SetText(TextBox3.Text)
        MsgBox("Dati copiati correttamente negli appunti", MsgBoxStyle.Information, "Copia!")
    End Sub
End Class
