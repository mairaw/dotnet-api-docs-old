    ' Show how to use OpenMachineConfiguration(string).
    ' It gets the machine.config file applicabe to the
    ' specified resource and displays section 
    ' basic information. 
    Shared Sub OpenMachineConfiguration2()
        ' Get the machine.config file applicabe to the
        ' specified reosurce.
        Dim config As System.Configuration.Configuration = _
        WebConfigurationManager.OpenMachineConfiguration( _
        "configTest")

        ' Loop to get the sections. Display basic information.
        Console.WriteLine("Name, Allow Definition")
        Dim i As Integer = 0
        Dim section As ConfigurationSection
        For Each section In config.Sections
            Console.WriteLine((section.SectionInformation.Name + _
            ControlChars.Tab + _
            section.SectionInformation.AllowExeDefinition.ToString()))
            i += 1
        Next section
        Console.WriteLine("[Total number of sections: {0}]", i)

        ' Display machine.config path.
        Console.WriteLine("[File path: {0}]", config.FilePath)
    End Sub 'OpenMachineConfiguration2

