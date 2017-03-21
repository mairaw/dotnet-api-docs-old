          // Get the Web application configuration.
          System.Configuration.Configuration webConfig =
          WebConfigurationManager.OpenWebConfiguration("/aspnetTest");

         // Get the section.

          string configPath = 
              "system.web/caching/outputCacheSettings";
          System.Web.Configuration.OutputCacheSettingsSection outputCacheSettings =
          (System.Web.Configuration.OutputCacheSettingsSection)webConfig.GetSection(
          configPath);

        // Get the profile at zero index.
        System.Web.Configuration.OutputCacheProfile outputCacheProfile = 
          outputCacheSettings.OutputCacheProfiles[0];
