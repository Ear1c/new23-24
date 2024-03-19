Public Class CoinSlot
    Public Event dispense(p As Image)

    Public Event coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property Dollars As Integer
    Public Property Quarters As Integer
    Public Property dimes As Integer
    Public Property nickles As Integer

    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = Dollars + Quarters * 0.25 + dimes * 0.1 + nickles * 0.05
            Return _total
        End Get

    End Property
    Public Sub coinreturn()
        RaiseEvent coinreturnevent(Dollars, Quarters, dimes, nickles)
        Dollars = 0
        Quarters = 0
        dimes = 0
        nickles = 0

    End Sub

    Public Sub insertquarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub insertdime()
        dimes = dimes + 1
    End Sub
    Public Sub insertnickle()
        nickles = nickles + 1
    End Sub
    Public Sub insertdollar()
        Dollars = Dollars + 1
    End Sub
    Public Sub buy(p As productcontrol)
        If p.productcount > 0 And total >= p.price Then
            p.buy()
            _total = _total - p.price
            Dollars = 0
            Quarters = 0
            dimes = 0
            nickles = _total / 0.05
            RaiseEvent dispense(p.picture)
        End If
    End Sub
End Class
