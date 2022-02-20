'Name
'Details
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Count, Number As Integer
        Dim Correct As Boolean
        Dim Guess As String

        Randomize()
        Number = Int(Rnd() * 100) * 1 'Select random number to guess
        Correct = False
        Count = 1
        Do While Count < 11 And Correct = False 'Gives the user 10 guesses
            Guess = InputBox("Enter your guess", "Attempt" & Count)
            If Val(Guess) = Number Then
                Correct = True
            Else 'If the guess is incorrect
                If Guess < Number Then
                    MsgBox("Too low ", vbExclamation, "Attempt" & Count) 'Guess having a too low value
                Else
                    MsgBox("Too high ", vbExclamation, "Attempt" & Count) 'Guess having a high value
                End If
                Count = Count + 1
            End If
        Loop
        MsgBox("The Number was" & Number)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
