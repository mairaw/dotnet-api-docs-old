            ' Get the custom attributes for the trace source switch.

            For Each de In ts.Switch.Attributes
                Console.WriteLine(de.Key + "  " + de.Value)
            Next de 