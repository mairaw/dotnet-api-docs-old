
// Get the current HeartBeatInterval property value.
TimeSpan heartBeatIntervalValue = healthMonitoringSection.HeartbeatInterval;

// Set the HeartBeatInterval property to
// TimeSpan.Parse("00:10:00").
healthMonitoringSection.HeartbeatInterval = TimeSpan.Parse("00:10:00");
