        ' Declare a string variable and set it to the result
        ' of a call to the ApplyAppPathModifier method.
        ' Then set the NavigateUrl property of a Hyperlink control
        ' to the string's value.
        Dim urlConverted As String = Response.ApplyAppPathModifier("TestPage.aspx")
        hlTest1.NavigateUrl = urlConverted