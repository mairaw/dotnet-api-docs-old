      ' Get the DelayNotificationTimeout property value.
      Response.Write("DelayNotificationTimeout: " & _
        configSection.DelayNotificationTimeout.ToString() & "<br>")

      ' Set the DelayNotificationTimeout property value to 10 seconds.
      configSection.DelayNotificationTimeout = TimeSpan.FromSeconds(10)