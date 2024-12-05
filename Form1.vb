Public Class Form1
    Const ITERATIONS = 500000

    Private Sub Bt_Late_Click(sender As Object, e As EventArgs) Handles Bt_Late.Click
        ' Пример позднего связывания
        Dim obj As Object
        Dim i As Long
        Dim Start As DateTime = DateTime.Now
        ' Создание объекта с указанным ProgId
        obj = CreateObject("Lb3AutoSvrMyMath.1")
        txtOp3.Text = obj.Mul(txtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            txtOp3.Text = obj.Mul(txtOp1.Text, txtOp2.Text)
        Next
        txtTime1.Text = (DateTime.Now - Start).TotalMilliseconds
        obj = Nothing

    End Sub

    Private Sub Bt_Vtbl_Click(sender As Object, e As EventArgs) Handles Bt_Vtbl.Click
        ' Пример связывания через vtbl(оченьраннего связывания)
        Dim i As Long
        Dim obj As New Lb3AutoSvrLib.MyMath
        Dim Start As DateTime = DateTime.Now
        txtOp3.Text = obj.Mul(txtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            txtOp3.Text = obj.Mul(txtOp1.Text, txtOp2.Text)
        Next
        txtTime3.Text = (DateTime.Now - Start).TotalMilliseconds
    End Sub

    Private Sub Bt_ID_Click(sender As Object, e As EventArgs) Handles Bt_ID.Click
        ' Пример ID-связывания c указанием на TypeLib
        Dim obj As Lb3AutoSvrLib.MyMath
        Dim i As Long
        Dim Start As DateTime = DateTime.Now
        obj = New Lb3AutoSvrLib.MyMath
        txtOp3.Text = obj.Add(txtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            obj.Add(txtOp1.Text, txtOp2.Text)
        Next
        txtTime2.Text = (DateTime.Now - Start).TotalMilliseconds
    End Sub
End Class
