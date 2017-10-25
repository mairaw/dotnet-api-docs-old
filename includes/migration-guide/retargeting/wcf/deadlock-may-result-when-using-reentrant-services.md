### Deadlock may result when using Reentrant services

|   |   |
|---|---|
|Details|A deadlock may result in a Reentrant service, which restricts instances of the service to one thread of execution at a time. Services prone to encounter this problem will have the following <xref:System.ServiceModel.ServiceBehaviorAttribute> in their code:<pre><code>[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]&#13;&#10;</code></pre>|
|Suggestion|To address this issue, you can do the following:<ul><li>Set the service&#39;s concurrency mode to <xref:System.ServiceModel.ConcurrencyMode.Single?displayProperty=nameWithType> or &lt;System.ServiceModel.ConcurrencyMode.Multiple?displayProperty=nameWithType&gt;. For example:</li></ul><pre><code>[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single)]&#13;&#10;</code></pre><ul><li>Install the latest update to the .NET Framework 4.6.2, or upgrade to a later version of the .NET Framework. This disables the flow of the <xref:System.Threading.ExecutionContext> in <xref:System.ServiceModel.OperationContext.Current?displayProperty=nameWithType>. This behavior is configurable; it is equivalent to adding the following app setting to your configuration file:</li></ul><pre><code>&lt;appSettings&gt;&#13;&#10;&lt;add key=&quot;Switch.System.ServiceModel.DisableOperationContextAsyncFlow&quot; value=&quot;true&quot; /&gt;&#13;&#10;&lt;/appSettings&gt;&#13;&#10;&#13;&#10;The value of `Switch.System.ServiceModel.DisableOperationContextAsyncFlow` should never be set to `false` for Rentrant services.&#13;&#10;</code></pre>|
|Scope|Minor|
|Version|4.6.2|
|Type|Retargeting|
|Affected APIs|<ul><li><xref:System.ServiceModel.ServiceBehaviorAttribute?displayProperty=nameWithType></li><li><xref:System.ServiceModel.ConcurrencyMode.Reentrant?displayProperty=nameWithType></li></ul>|

