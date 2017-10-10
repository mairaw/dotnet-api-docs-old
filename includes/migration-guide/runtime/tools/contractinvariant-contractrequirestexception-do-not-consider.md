### Contract.Invariant or Contract.Requires<TException> do not consider String.IsNullOrEmpty to be pure

|   |   |
|---|---|
|Details|For apps that target the .NET Framework 4.6.1, if the invariant contract for <xref:System.Diagnostics.Contracts.Contract.Invariant%2A?displayProperty=nameWithType> or the precondition contract for <xref:System.Diagnostics.Contracts.Contract.Requires%2A?displayProperty=nameWithType)> calls the <xref:System.String.IsNullOrEmpty%2A?displayProperty=nameWithType> method, the rewriter emits compiler warning CC1036: &quot;Detected call to method &#39;System.String.IsNullOirWhteSpace(System.String)&#39; without [Pure] in method.&quot; This is a compiler warning rather than a compiler error.|
|Suggestion|This behavior was addressed in <a href="https://github.com/Microsoft/CodeContracts/issues/339">GitHub Issue #339</a>. To eliminate this warning, you can download and compile an updated version of the source code for the Code Contracts tool from <a href="https://github.com/Microsoft/CodeContracts/blob/master/README.md">GitHub</a>. Download information is found at the bottom of the page.|
|Scope|Minor|
|Version|4.6.1|
|Type|Runtime|
|Affected APIs|<ul><li><xref:System.Diagnostics.Contracts.Contract.Invariant(System.Boolean)?displayProperty=nameWithType></li><li><xref:System.Diagnostics.Contracts.Contract.Requires(System.Boolean)?displayProperty=nameWithType></li></ul>|

