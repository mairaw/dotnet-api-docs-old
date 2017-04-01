                    ' Get the httpRuntime section.
                    Dim httpRuntime _
                    As HttpRuntimeSection = _
                    systemWeb.HttpRuntime
                    ' Read section information.
                    info = httpRuntime.SectionInformation
                    name = info.SectionName
                    type = info.Type
                    declared = info.IsDeclared.ToString()
                    msg = String.Format("Name:     {0}" + _
                    ControlChars.Lf + "Declared: {1}" + _
                    ControlChars.Lf + "Type:     {2}" + _
                    ControlChars.Lf, name, declared, type)
