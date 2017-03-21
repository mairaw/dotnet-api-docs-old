        ' Shadow the control properties with design-time properties.
        Protected Overrides Sub PreFilterProperties( _
            ByVal properties As IDictionary)

            ' Call the base method first.
            MyBase.PreFilterProperties(properties)

            ' Make the Page visible in the Properties grid.
            Dim selectProp As PropertyDescriptor = _
                CType(properties("Page"), PropertyDescriptor)
            properties("Page") = _
                TypeDescriptor.CreateProperty(selectProp.ComponentType, _
                    selectProp, BrowsableAttribute.Yes)
        End Sub ' PreFilterProperties