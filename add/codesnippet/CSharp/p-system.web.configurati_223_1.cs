                        // Get the deviceFilters section.
                        DefaultSection deviceFilters =
                            systemWeb.DeviceFilters;
                        // Read section information.
                        info =
                            deviceFilters.SectionInformation;

                        name = info.SectionName;
                        type = info.Type;
                        declared = info.IsDeclared.ToString();
                        msg = String.Format(
                            "Name:     {0}\nDeclared: {1}\nType:     {2}\n",
                            name, declared, type);