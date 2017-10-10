### Icon.ToBitmap successfully converts icons with PNG frames into Bitmap objects

|   |   |
|---|---|
|Details|Starting with the apps that target the .NET Framework 4.6, the <xref:System.Drawing.Icon.ToBitmap%2A?displayProperty=fullName> method successfully converts icons with PNG frames into Bitmap objects.In apps that target the .NET Framework 4.5.2 and earlier versions, the  <xref:System.Drawing.Icon.ToBitmap%2A?displayProperty=fullName> method throws an <xref:System.ArgumentOutOfRangeException> exception if the Icon object has PNG frames.This change affects apps that are recompiled to target the .NET Framework 4.6 and that implement special handling for the <xref:System.ArgumentOutOfRangeException> that is thrown when an Icon object has PNG frames. When running under the .NET Framework 4.6, the conversion is successful, an <xref:System.ArgumentOutOfRangeException> is no longer thrown, and therefore the exception handler is no longer invoked.<ul><li>[X] Quirked // Uses some mechanism to turn the feature on or off, usually using runtime targeting, AppContext or config files. Needs to be turned on automatically for some situations.</li><li>[ ] Build-time break // Causes a break if attempted to recompile</li></ul>|
|Suggestion|If this behavior is undesirable, you can retain the previous behavior by adding the following element to the <code>&lt;runtime&gt;</code> section of your app.config file:<pre><code>&lt;AppContextSwitchOverrides<br />value=&quot;Switch.System.Drawing.DontSupportPngFramesInIcons=true&quot; /&gt;</code></pre>If the app.config file already contains the <code>AppContextSwitchOverrides</code> element, the new value should be merged with the value attribute like this:<pre><code>&lt;AppContextSwitchOverrides<br />value=&quot;Switch.System.Drawing.DontSupportPngFramesInIcons=true;&lt;previous key&gt;=&lt;previous value&gt;&quot; /&gt;</code></pre>|
|Scope|Minor|
|Version|4.6|
|Type|Runtime|
|Affected APIs|<ul><li><xref:System.Drawing.Icon.ToBitmap?displayProperty=nameWithType></li></ul>|

