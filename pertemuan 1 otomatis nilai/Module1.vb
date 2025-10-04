Module Module1
    Sub Main()
        ' ========== Bagian 1 : Input dan Output Biodata ==========
        Console.WriteLine("=== Input Data Diri ===")
        Console.Write("Masukkan Nama: ")
        Dim nama As String = Console.ReadLine()

        Console.Write("Masukkan Program Studi: ")
        Dim prodi As String = Console.ReadLine()

        Console.Write("Masukkan Nama Kampus: ")
        Dim kampus As String = Console.ReadLine()

        Console.Write("Masukkan Hobi: ")
        Dim hobi As String = Console.ReadLine()

        Console.WriteLine()
        Console.WriteLine("=== Output Data Diri ===")
        Console.WriteLine("Halo, nama saya adalah " & nama)
        Console.WriteLine("Saya kuliah pada jurusan " & prodi & " di " & kampus)
        Console.WriteLine("Saya memiliki hobi " & hobi)

        Console.WriteLine()
        ' ========== Bagian 2 : Operasi Matematika ==========
        Console.WriteLine("=== Operasi Matematika ===")
        Console.Write("Masukkan bilangan pertama: ")
        Dim a As Integer = CInt(Console.ReadLine())

        Console.Write("Masukkan bilangan kedua: ")
        Dim b As Integer = CInt(Console.ReadLine())

        ' Operasi matematika
        Dim tambah As Integer = a + b
        Dim kali As Integer = a * b
        Dim bagi As Integer
        Dim modulus As Integer

        ' Cek pembagian by zero
        If b <> 0 Then
            bagi = a \ b  ' pembagian bulat
            modulus = a Mod b
        Else
            bagi = 0
            modulus = 0
        End If

        ' Supaya hasil tidak minus → gunakan Math.Abs
        Console.WriteLine()
        Console.WriteLine("Hasil Penjumlahan : " & Math.Abs(tambah))
        Console.WriteLine("Hasil Perkalian   : " & Math.Abs(kali))
        Console.WriteLine("Hasil Pembagian   : " & Math.Abs(bagi))
        Console.WriteLine("Hasil Modulus     : " & Math.Abs(modulus))

        Console.WriteLine()
        Console.WriteLine("Tekan ENTER untuk keluar...")
        Console.ReadLine()
    End Sub
End Module