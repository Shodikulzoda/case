Imports System.Runtime.InteropServices
Imports System.Threading

Module Program
    Sub Main(args As String())
        'Dim a As Integer = Console.ReadLine
        'Case1.Дано целое число в диапазоне 1–7. Вывести строку — название дня
        'недели, соответствующее данному числу (1 — «понедельник», 2 — «вторник» и т.д.).
        'Select Case a
        '    Case 1
        '        Console.WriteLine("ponedelinik")
        '    Case 2
        '        Console.WriteLine("vtornik")
        '    Case 3
        '        Console.WriteLine("sreda")
        '    Case 4
        '        Console.WriteLine("chetverg")
        '    Case 5
        '        Console.WriteLine("pyatnisa")
        '    Case 6
        '        Console.WriteLine("subbota")
        '    Case 7
        '        Console.WriteLine("voskrisenia")
        '        '    Case Else
        '        '        Console.WriteLine("encorect erorr")
        '        'End Select
        'Case 2.Дано целое число K. Вывести строку-описание оценки, соответствую -
        'щей числу K (1 — «плохо», 2 — «неудовлетворительно», 3 — «удовлетвори-
        'тельно», 4 — «хорошо», 5 — «отлично»). Если K не лежит в диапазоне 1–5,
        ''то вывести строку «ошибка».
        'Dim a As Integer = Console.ReadLine
        'Select Case a
        '    Case 1
        '        Console.WriteLine("bad")
        '    Case 2
        '        Console.WriteLine("xub ne")
        '    Case 3
        '        Console.WriteLine("xub")
        '    Case 4
        '        Console.WriteLine("xubtar")
        '    Case 5
        '        Console.WriteLine("oli")
        'End Select
        'Case3.Дан номер месяца — целое число в диапазоне 1–12 (1 — январь, 2 — фе-
        ' враль и т.д.). Вывести название соответствующего времени года («зима»,
        '«весна», «лето», «осень»).
        'Dim a As String = Console.ReadLine
        'Select Case a
        '    Case "январ", "декабр", "феврал"
        '        Console.WriteLine("zima")
        '    Case "март", "апрел", "май"
        '        Console.WriteLine("vesna")
        '    Case "июн", "июл", "август"
        '        Console.WriteLine("leto")
        '    Case "сентябр", "октиябр", "ноябр"
        '        Console.WriteLine("тирамох")
        'End Select
        '        Case4 ◦ . Дан номер месяца — целое число в диапазоне 1–12 (1 — январь, 2 —
        'февраль и т.д.). Определить количество дней в этом месяце для невисо-
        'косного года.
        'Dim a As Integer = Console.ReadLine
        'Dim v As Integer
        'Select Case a
        '    Case 1, 3, 5, 7, 8, 10, 12
        '        v = 31
        '    Case 4, 6, 9, 11
        '        v = 30
        '    Case 2
        '        v = 28
        'End Select
        'Console.WriteLine(v)
        '        Case5.Арифметические действия над числами пронумерованы следующим
        'образом: 1 — сложение, 2 — вычитание, 3 — умножение, 4 — деление. Дан
        'номер действия N (целое число в диапазоне 1–4) и вещественные числа A
        'и B(В не равно 0).Выполнить над числами указанное действие и вывести
        'результат.
        'Dim a As Single = Console.ReadLine
        'Dim b As Single = Console.ReadLine
        'Dim c As Single = Console.ReadLine
        'Select Case a And b
        '    Case 1
        '        c = a * b
        '    Case 2
        '        c = a / b
        '    Case 3
        '        c = a + b
        '    Case 4
        '        c = a - b
        'End Select
        '        'Console.WriteLine(c)
        '        'Case6. Единицы длины пронумерованы следующим образом: 1 — дециметр,
        '2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр. Дан номер
        'единицы длины(целое число в диапазоне 1–5) и длина отрезка в этих
        'единицах(вещественное число).Найти длину отрезка в метрах.
        'Dim d As Integer = Console.ReadLine
        'Dim s As Double = Console.ReadLine
        'Dim f As Double
        'Select Case s
        '    Case 1
        '        'ds
        '        f = d * 0.1
        '    Case 2
        '        'km
        '        f = d * 1000
        '    Case 3
        '        f = d
        '    Case 4
        '        'mm
        '        f = d * 0.001
        '    Case 5
        '        'sm
        '        f = d * 0.01
        'End Select
        'Console.WriteLine(f)
        'Case7.Единицы массы пронумерованы следующим образом:  1 — килограмм,
        '2 — миллиграмм, 3 — грамм, 4 — тонна, 5 — центнер. Дан номер едини-
        'цы массы(целое число в диапазоне 1–5) и масса тела в этих единицах
        '(вещественное число). Найти массу тела в килограммах.
        'Dim d As Integer = Console.ReadLine
        'Dim s As Double = Console.ReadLine
        'Dim f As Double
        'Select Case s
        '    Case 1
        '        'kg
        '        f = d
        '    Case 2, 3
        '        'mg
        '        f = d * 0.001
        '    Case 4
        '        'tonna
        '        f = d * 1000
        '    Case 5
        '        'sentner
        '        f = d * 100
        'End Select
        'Console.WriteLine(f)
        'Case8. Даны два целых числа: D (день) и M (месяц), определяющие пра-
        'вильную дату невисокосного года. Вывести значения D и M для даты,
        'предшествующей указанной.
        'Dim d As Integer = Console.ReadLine
        'Dim m As Integer = Console.ReadLine
        'If d <= 1 And m <= 1 Then
        '    Console.WriteLine("neverniy chislo")
        '    Return
        'End If
        'Select Case m
        '    Case 1 ' janu
        '        If d > 1 Then
        '            d -= 1
        '        Else
        '            d = 31
        '            m = 12
        '        End If
        '    Case 2 ' fev
        '        If d > 1 Then
        '            d -= 1
        '        Else
        '            d = 31
        '            m -= 1
        '        End If
        '    Case 3, 5, 7, 8, 10, 12
        '        If d > 1 Then
        '            d -= 1
        '        Else
        '            d = 30
        '            m -= 1
        '        End If
        '    Case 4, 6, 9, 11
        '        If d > 1 Then
        '            d -= 1
        '        Else
        '            d = 31
        '            m -= 1
        '        End If
        'End Select
        'case 10
        'Case10.Робот может перемещаться в четырех направлениях («С» — север,
        '«З» — запад, «Ю» — юг, «В» — восток) и принимать три цифровые ко-
        'манды: 0 — продолжать движение, 1 — поворот налево, −1 — поворот
        'направо.Дан символ C — исходное направление робота и целое число N
        '— посланная ему команда. Вывести направление робота после выполне-
        'ния полученной команды.
        'Dim s As String = Console.ReadLine()
        'Dim ss As Integer = Console.ReadLine
        'Select Case ss
        '    Case 0
        '        s = s
        '    Case 1
        '        If s = "c" Then
        '            s = "З"
        '        ElseIf s = "З" Then
        '            s = "Ю"
        '        ElseIf s = "Ю" Then
        '            s = "В"
        '        ElseIf s = "В" Then
        '            s = "3"
        '        End If
        '    Case -1
        '        If s = "c" Then
        '            s = "В"
        '        ElseIf s = "З" Then
        '            s = "c"
        '        ElseIf s = "Ю" Then
        '            s = "З"
        '        ElseIf s = "В" Then
        '            s = "Ю"
        '        End If
        'End Select
        'Console.WriteLine(s)
        'Case11.Локатор ориентирован на одну из сторон света («С» — север, «З» —
        'запад, «Ю» — юг, «В» — восток) и может принимать три цифровые коман-
        'ды поворота:  1 — поворот налево, −1 — поворот направо, 2 — поворот на
        '180 ◦ . Дан символ C — исходная ориентация локатора и целые числа N 1
        'и N 2 — две посланные команды. Вывести ориентацию локатора после
        'выполнения этих команд.
        'Dim s As String = Console.ReadLine()
        'Dim ss As Integer = Console.ReadLine
        'Select Case ss
        '    Case 2
        '        s = "180 degree"
        '    Case 1
        '        If s = "c" Then
        '            s = "З"
        '        ElseIf s = "З" Then
        '            s = "Ю"
        '        ElseIf s = "Ю" Then
        '            s = "В"
        '        ElseIf s = "В" Then
        '            s = "3"
        '        End If
        '    Case -1
        '        If s = "c" Then
        '            s = "В"
        '        ElseIf s = "З" Then
        '            s = "c"
        '        ElseIf s = "Ю" Then
        '            s = "З"
        '        ElseIf s = "В" Then
        '            s = "Ю"
        '        End If
        'End Select
        'Console.WriteLine(s)
        'Case12. Элементы окружности пронумерованы следующим образом: 1 — ра-
        'диус R, 2 — диаметр D = 2·R, 3 — длина L = 2·π·R, 4 — площадь кру-
        'га S = π·R 2 . Дан номер одного из этих элементов и его значение. Вывести
        'значения остальных элементов данной окружности (в том же порядке). В
        'качестве значения π использовать 3.14.
        'Dim n As Integer = Console.ReadLine
        'Dim v As Double = Console.ReadLine
        'Dim R As Double
        'Dim D As Double
        'Dim L As Double
        'Dim S As Double
        'Select Case n
        '    Case 1
        '        R = v
        '        D = 2 * R
        '        L = 2 * Math.PI * R
        '        S = Math.PI * R ^ 2
        '    Case 2
        '        R = v / 2
        '        D = 2 * R
        '        L = 2 * Math.PI * R
        '        S = Math.PI * R ^ 2
        '    Case 3
        '        R = v / (2 * Math.PI)
        '        D = 2 * R
        '        S = Math.PI * R ^ 2
        '    Case 4
        '        R = Math.Sqrt(v / Math.PI)
        '        D = 2 * R
        '        L = 2 * Math.PI * R
        'End Select
        'Console.WriteLine("radius={0}", R)
        'Console.WriteLine("diametr={0}", D)
        'Console.WriteLine("dlina={0}", L)
        'Console.WriteLine("ploshad={0}", S)
        'Case13. Элементы равнобедренного прямоугольного треугольника пронуме-
        'рованы следующим образом:  1 — катет a, 2 — гипотенуза c = a· √ 2, 3 —
        'высота h, опущенная на гипотенузу (h = c/2), 4 — площадь S = c·h/2.
        'Дан номер одного из этих элементов и его значение. Вывести значения
        'остальных элементов данного треугольника (в том же порядке).
        'Dim a As Double, c As Double, s As Double, x As Double, n As Integer, h As Double
        'n = Console.ReadLine
        'x = Console.ReadLine
        'Select Case n
        '    Case 1
        '        a = x
        '        c = a * Math.Sqrt(2)
        '        h = c / 2
        '        s = c * h / 2
        '    Case 2
        '        c = x
        '        a = c / Math.Sqrt(2)
        '        h = c / 2
        '        s = c * h / 2
        '    Case 3
        '        h = x
        '        c = 2 * h
        '        a = c / Math.Sqrt(2)
        '        s = c * h / 2
        '    Case 4
        '        s = x
        '        h = Math.Sqrt(s)
        '        c = 2 * h
        '        a = c / Math.Sqrt(2)
        'End Select
        'Console.WriteLine(a)
        'Console.WriteLine(h)
        'Console.WriteLine(c)
        'Console.WriteLine(s)
        'Case15. Мастям игральных карт присвоены порядковые номера: 1 — пики,
        '2 — трефы, 3 — бубны, 4 — червы. Достоинству карт, старших десятки,
        'присвоены номера:  11 — валет, 12 — дама, 13 — король, 14 — туз. Даны
        'два целых числа: n — достоинство (6 ≤ N ≤ 14) и M — масть карты
        '(1 ≤ M ≤ 4). Вывести название соответствующей карты вида «шестерка
        'бубен», «дама червей», «туз треф» и т.п.
        ''Dim m As Byte = Console.ReadLine
        'Dim n As Byte = Console.ReadLine
        'Select Case n
        '    Case 6
        '
        'Console.WriteLine()WriteLine("шестёрка ")
        '    Case 7
        '        Console.WriteLine("семёрка ")
        '    Case 8
        '        Console.WriteLine("восьмёрка ")
        '    Case 9
        '        Console.WriteLine("девятка ")
        '    Case 10
        '        Console.WriteLine("десятка ")
        '    Case 11
        '        Console.WriteLine("валет ")
        '    Case 12
        '        Console.WriteLine("дама ")
        '    Case 13
        'Console.WriteLine("король ")
        'Case 14
        'Console.WriteLine("туз ")
        ''End Select
        ''Select Case m4
        'Case 1
        'Console.WriteLine("пик\n")
        'Case 2
        'Console.WriteLine("треф\n")
        'Case 3
        'Console.WriteLine("бубен\n")
        'Case 4
        'Console.WriteLine("червей\n")
        'End Select
        'Dim a(9) As Integer
        'Dim d As Integer
        'For i As Integer = 0 To 9 Step 1

        '    d = Console.ReadLine()
        '    If d Mod 2 = 0 Then
        '        a(i) = d

        '    End If
        'Next
        'For Each ab As Integer In a
        '    Console.WriteLine(ab)
        'Next
        'Dim a(10) As Integer
        'Dim b As Integer
        'For Each ad As Integer In a
        '    b += ad

        'Next
        'Console.WriteLine(b)
        'for 1
        'Dim n As Integer = Console.ReadLine()
        '    Dim k As Integer = Console.ReadLine
        '    For i As Integer = 1 To n
        '        Console.Write(k)
        '    Next
        'for 2
        'Dim a As Integer = Console.ReadLine
        'Dim b As Integer = Console.ReadLine
        'Dim s As Integer = 0
        'For i As Integer = a To b
        '    Console.WriteLine(i)
        '    s += 1
        'Next
        'Console.WriteLine("kol =" & s)
        'For3.Даны два целых числа A и B (A < B). Вывести в порядке убывания все
        'целые числа, расположенные между A и B (не включая числа A и B), а
        'также количество N этих чисел.
        'Dim a As Integer = Console.ReadLine
        'Dim b As Integer = Console.ReadLine
        'For i As Integer = -a To b
        '    Console.WriteLine(Math.Abs(i))
        'Next
        'for4
        'Dim narh As Integer = Console.ReadLine
        'For i As Double = 1 To 10
        '    Console.WriteLine(i * narh)
        'Next
        'for5
        'Dim narh As Double = Console.ReadLine
        'For i As Double = 1 To 10
        '    Console.WriteLine((i * narh) / 10)
        'Next
        'for7
        'Dim a As Integer = Console.ReadLine
        'Dim b As Integer = Console.ReadLine
        'Dim s As Integer = 0

        'For i As Integer = a To b
        '    s += i

        'Next
        'Console.WriteLine(s)
        'for8
        'Dim a As Integer = Console.ReadLine
        'Dim b As Integer = Console.ReadLine
        'Dim v As Integer
        'For i As Integer = a To b

        '    Console.WriteLine(v)
        'Next
        'for9
        'Dim a As Integer = Console.ReadLine
        'Dim b As Integer = Console.ReadLine
        'Dim s As Integer = 0
        'For i As Integer = a To b
        '    s = i * i
        '    Console.WriteLine(s)
        'Next
        'for10
        'Dim a As Integer = Console.ReadLine
        'Dim c As Double = 0
        'For i As Integer = 1 To a
        '    c = c + 1 / i
        '    Console.WriteLine(c)
        'Next
        'for11
        'Dim n As Integer = Console.ReadLine
        'Dim a As Double
        'For i As Integer = 1 To n
        '    a = n ^ 2 + (n + i) ^ 2 + (2 * n) ^ 2
        '    Console.WriteLine(a)
        ''Next
        'Dim n As Double = Console.ReadLine
        'Dim s As Double = 1
        'For i As Double = 1 To n Step 0.1
        '    s = i + s - i + s

        '    Console.WriteLine(s)
        'Next
        ' for12 
        'Dim n As Integer = Console.ReadLine
        'Dim s As Integer = 0
        'For i As Integer = 1 To n
        '    s += i + (2 * n - 1)
        'Next
        'Console.WriteLine(s ^ 2)    A N = A·A·...·A
        'for15
        'Dim n As Double = Console.ReadLine
        'Dim s As Double = 1
        'Dim a As double = Console.ReadLine
        'For i As Integer = 0 To n
        's *= n
        'Console.WriteLine(s^2)
        ''Next
        'for16
        'Dim n As Double = Console.ReadLine
        'Dim a As Double = Console.ReadLine
        'Dim s As Double = 1
        'For i As Double = 1 To n
        '    s *= a
        '    Console.WriteLine(s)
        'Next
        ''for17
        'Dim n As Integer = Console.ReadLine
        'Dim a As Integer = Console.ReadLine
        'Dim d As Integer = 0
        'For i As Integer = 1 To n
        '    d += a ^ i
        'Next
        'Console.WriteLine(d)
        'N 2 = 1 + 3 + 5 ++ (2·N −1).
        'Dim a As Integer = 100
        'Dim v As Integer
        'For i As Integer = 1 To a Step 2
        '    v += i + (2 * a - 1)
        'Next
        'Console.WriteLine(v)
        ''ие выражения 1 − A + A 2 − A 3 + ... + (−1) N ·A N
        'Dim n As Integer = 100
        'Dim s As Double
        'For i As Integer = 1 To n
        '    s += 1 - (1) ^ i * (n) ^ i
        '    Console.WriteLine(s)
        'Next
        'for 19
        'Dim n As Double = Console.ReadLine
        'Dim a As Double = 1
        'For i As Integer = 1 To n

        '    a *= i
        '    Console.WriteLine(a)
        'Next
        ''for 20
        'Dim n As Double = Console.ReadLine
        'Dim a As Double = 1
        'For i As Integer = 1 To n
        '    a *= i
        '    Console.WriteLine(a)
        'Next
        ''for 21
        'Dim n As Double = Console.ReadLine
        'Dim a As Double = 1
        'Dim d As Double = 1
        'For i As Integer = 1 To n
        '    d *= i
        '    a += 1 / (d)
        '    Console.WriteLine(a)
        'Next
        '1 + X + X2 /(2!) + ... + X N /(N!)
        '            Dim n As Integer = Console.ReadLine
        '        Dim x As Double = 1
        '        Dim s As Double = 1
        '        For i As Integer = 1 To n
        'x *= i
        '            s += x ^ i
        '        Next
        'Dim a As Integer = 12
        'Dim b As Integer = 0
        'Dim s As Integer = 0
        'For i As Integer = 1 To a
        '    If i Mod 2 = 0 Then
        '        b =
        '    End If
        'Next
        Dim a As Integer = Console.ReadLine
        Dim i As Integer = 1
        Dim четни As String = ""
        Dim нечетни As String = ""
        For i = 1 To a
            If i Mod 2 = 0 Then
                четни += i & " "








    End Sub
End Module
