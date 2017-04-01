                    ' Get the httpModules section.
                    Dim httpModules _
                    As HttpModulesSection = _
                    systemWeb.HttpModules
                    ' Read section information.
                    info = httpModules.SectionInformation
                    name = info.SectionName
                    type = info.Type
                    declared = info.IsDeclared.ToString()
                    msg = String.Format("Name:     {0}" + _
                    ControlChars.Lf + "Declared: {1}" + _
                    ControlChars.Lf + "Type:     {2}" + _
                    ControlChars.Lf, name, declared, type)
