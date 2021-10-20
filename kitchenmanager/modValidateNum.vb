' Converted from VB6

Option Explicit On

Module modValidateNum
    'Attribute VB_Name = "modValidateNum"

    ' max decimal places constants
    Public Const Unrestricted As Integer = -1  ' no restriction on decimal places
    Public Const CurrencyDigits As Integer = -2  ' Currency format with 2 decimal places

    Public Function ValidateNum(ByVal TestNumber As Object, ByVal sngLow As Single,
        ByVal sngHigh As Single, ByVal MaxDecimalPlaces As Integer) As Boolean

        ' testNumber is tested to see if it is a valid number within
        ' a low & High range and within specified number of decimal places
        Dim strMsg As String
        Dim sngMultTestNumber As Single, DecimalDigitsOK As Boolean

        If MaxDecimalPlaces = CurrencyDigits Then
            ' working with currency use the word "amount" in messages
            strMsg = " amount "
        Else
            ' Not working with currency, use the word "number" in messages
            strMsg = " number "
        End If

        ' Is TestNumber a null string?
        If TestNumber = "" Then
            ValidateNum = False
            MsgBox("A valid" & strMsg & "must be entered before proceeding", vbExclamation)
            Exit Function
        End If

        ' Is the tested number invalid?
        If IsNumeric(TestNumber) = False Then
            ValidateNum = False
            MsgBox("The" & strMsg & "entered is not a valid number", vbExclamation)
            Exit Function
        End If

        ' Is the tested number outside of the low and high range?
        If Val(TestNumber) < sngLow Or Val(TestNumber) > sngHigh Then
            ValidateNum = False
            MsgBox("The" & strMsg & "entered must be within the range" & vbCrLf &
            sngLow & " to " & sngHigh, vbExclamation)
            Exit Function
        End If

        ' Determine if a maximum number of decimal places has been set
        If MaxDecimalPlaces <> Unrestricted Then
            ' multiplying by powers of 10 should produce a whole number
            sngMultTestNumber = TestNumber * 10 ^ Math.Abs(MaxDecimalPlaces)
            DecimalDigitsOK = (sngMultTestNumber = Int(sngMultTestNumber))
            If MaxDecimalPlaces = 0 And Not DecimalDigitsOK Then
                ' Decimal places exist where Whole number is required
                ValidateNum = False
                MsgBox("The number entered must be a whole number" & vbCrLf &
                "with no decimal places", vbExclamation)
                Exit Function
            ElseIf Not DecimalDigitsOK Then
                ' There are too many decimal digits
                ValidateNum = False
                MsgBox("The" & strMsg & "entered must not contain" & vbCrLf &
                "more than " & Math.Abs(MaxDecimalPlaces) & " decimal places.", vbExclamation)
                Exit Function
            End If
        End If

        ValidateNum = True  ' This is a valid number that meets all of the criteria
    End Function

End Module
