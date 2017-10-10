### SerialPort background thread exceptions

|   |   |
|---|---|
|Details|Background threads created with <code>T:System.IO.Ports.SerialPort</code> streams no longer terminate the process when OS exceptions are thrown.In applications that target the .NET Framework 4.7 and earlier versions, a process is terminated when an operating system exception is thrown on a background thread created with a T:System.IO.Ports.SerialPort stream.In applications that target the .NET Framework 4.7.1 or a later version, background threads wait for OS events related to the active serial port and could crash in some cases, such as sudden removal of the serial port.|
|Suggestion|For apps that target the .NET Framework 4.7.1, you can opt out of the exception handling if it is not desirable by adding the following to to the <code>&lt;runtime&gt;</code> section of your <code>app.config</code> file:<pre><code>&lt;runtime&gt;<br />&lt;AppContextSwitchOverrides value=&quot;Switch.System.IO.Ports.DoNotCatchSerialStreamThreadExceptions=true&quot; /&gt;<br />&lt;/runtime&gt;</code></pre>For apps that target earlier versions of the .NET Framework but run on the .NET Framework 4.7.1 or later, you can opt in to the exception handling by adding the following to to the <code>&lt;runtime&gt;</code> section of your <code>app.config</code> file:<pre><code>&lt;runtime&gt;<br />&lt;AppContextSwitchOverrides value=&quot;Switch.System.IO.Ports.DoNotCatchSerialStreamThreadExceptions=false&quot; /&gt;<br />&lt;/runtime&gt;</code></pre>|
|Scope|Minor|
|Version|4.7.1|
|Type|Retargeting|
|Affected APIs|<ul><li><xref:System.IO.Ports.SerialPort?displayProperty=nameWithType></li></ul>|

