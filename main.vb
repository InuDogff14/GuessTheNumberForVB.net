Imports System

Module GuessTheNumber
    Sub Main()
        Dim random As New Random()
        Dim secretNumber As Integer = random.Next(1, 101)
        Dim guess As Integer
        Dim attempts As Integer = 0

        Console.WriteLine("数当てゲームへようこそ！ 1から100までの数を当ててください。")

        Do
            Console.Write("あなたの予想は？: ")
            Dim input As String = Console.ReadLine()

            If Not Integer.TryParse(input, guess) Then
                Console.WriteLine("無効な入力です。もう一度入力してください。")
                Continue Do
            End If

            attempts += 1

            If guess < secretNumber Then
                Console.WriteLine("もっと大きい数です。")
            ElseIf guess > secretNumber Then
                Console.WriteLine("もっと小さい数です。")
            Else
                Console.WriteLine("おめでとうございます！正解です！")
                Console.WriteLine($"あなたの試行回数: {attempts}")
                Exit Do
            End If

        Loop

    End Sub
End Module
