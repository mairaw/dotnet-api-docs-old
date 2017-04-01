                        // Get the httpHandlers section.
                        HttpHandlersSection httpHandlers =
                            systemWeb.HttpHandlers;
                        // Read section information.
                        info =
                            httpHandlers.SectionInformation;
                        name = info.SectionName;
                        type = info.Type;
                        declared = info.IsDeclared.ToString();
                        msg = String.Format(
                            "Name:     {0}\nDeclared: {1}\nType:     {2}\n",
                            name, declared, type);