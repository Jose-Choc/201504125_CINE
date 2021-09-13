Module GuardarDatos
    Public indice As Integer
    Public subTotal(8) As String
    Public descuent1(8) As String
    Public descuent2(8) As String
    Public total(8) As String

    REM Funcion que verifica el precio del cine y función.
    Public Function precios(ByVal Cine As Integer, ByVal Funcion As Integer) As Integer
        'Declarar una matriz multidimensional
        Dim resultadoPrecio As Integer
        Dim PrecioCineFuncion(2, 3) As Integer
        PrecioCineFuncion(0, 0) = 30
        PrecioCineFuncion(0, 1) = 35
        PrecioCineFuncion(0, 2) = 40
        PrecioCineFuncion(0, 3) = 40
        PrecioCineFuncion(1, 0) = 24
        PrecioCineFuncion(1, 1) = 34
        PrecioCineFuncion(1, 2) = 44
        PrecioCineFuncion(1, 3) = 44
        PrecioCineFuncion(2, 0) = 35
        PrecioCineFuncion(2, 1) = 40
        PrecioCineFuncion(2, 2) = 50
        PrecioCineFuncion(2, 3) = 50

        resultadoPrecio = PrecioCineFuncion(Cine, Funcion)

        Return resultadoPrecio
    End Function
    Public Function valCine(ByVal Cine As String) As Integer
        Dim resultado As Integer
        If Cine Is "Cine A" Then
            resultado = 0
        ElseIf Cine Is "Cine B" Then
            resultado = 1
        ElseIf Cine Is "Cine C" Then
            resultado = 2
        End If
        Return resultado
    End Function
    Public Function valFuncion(ByVal Funcion As String) As Integer
        Dim resultado As Integer
        If Funcion Is "Función 1" Then
            resultado = 0
        ElseIf Funcion Is "Función 2" Then
            resultado = 1
        ElseIf Funcion Is "Función 3" Then
            resultado = 2
        ElseIf Funcion Is "Función 4" Then
            resultado = 3
        End If
        Return resultado
    End Function
    Public Function calcDescuent1(ByVal cine As Integer, ByVal funcion As Integer) As Double
        Dim resultado As Double
        If funcion = 2 Or funcion = 3 And cine = 2 Or cine = 1 Then
            resultado = 0.055
        ElseIf funcion = 0 And cine = 2 Or cine = 1 Then
            resultado = 0.03
        ElseIf funcion = 1 And cine = 0 Then
            resultado = 0.015
        Else
            resultado = 0
        End If
        Return resultado
    End Function
    Public Function calcDescuent2(ByVal subtotal As Double) As Double
        Dim resultado As Double
        If subtotal >= 100 And subtotal <= 300 Then
            resultado = 0.02
        ElseIf subtotal >= 300 And subtotal <= 500 Then
            resultado = 0.04
        ElseIf subtotal >= 500 And subtotal <= 1000 Then
            resultado = 0.06
        Else
            resultado = 0
        End If
        Return resultado
    End Function
    Public Function sumaSubTotal(ByVal indice As Integer) As Double
        Dim resultado As Double
        For i = 0 To indice
            resultado += subTotal(indice)
        Next
        Return resultado
    End Function
    Public Function sumaDescuent1(ByVal indice As Integer) As Double
        Dim resultado As Double
        For i = 0 To indice
            resultado += descuent1(indice)
        Next
        Return resultado
    End Function
    Public Function sumaDescuent2(ByVal indice As Integer) As Double
        Dim resultado As Double
        For i = 0 To indice
            resultado += descuent2(indice)
        Next
        Return resultado
    End Function
    Public Function sumaTotal(ByVal indice As Integer) As Double
        Dim resultado As Double
        For i = 0 To indice
            resultado += total(indice)
        Next
        Return resultado
    End Function
End Module
