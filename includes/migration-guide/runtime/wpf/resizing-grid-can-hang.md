### Resizing a Grid can hang

|   |   |
|---|---|
|Details|An infinite loop can occur during layout of a <code>T:System.Windows.Controls.Grid</code> under the following circumstances:<ul><li>Row definitions contain two *-rows, both declaring a MinHeight and a MaxHeight.</li><li>Content of the *-rows doesn&#39;t exceed the corresponding MaxHeight</li><li>The Grid&#39;s available height is exceeded by the first MinHeight (plus any other fixed or Auto rows)</li><li>The app targets .Net 4.7, or opts in to the 4.7 allocation algorithm by setting <code>Switch.System.Windows.Controls.Grid.StarDefinitionsCanExceedAvailableSpace=false</code></li></ul>The loop would also happen with more than two rows, or in the analogous case for columns.The issue is fixed in .Net 4.7.1.|
|Suggestion|Upgrade to .Net 4.7.1.  Alternatively, if you don&#39;t need the 4.7 allocation algorithm you can use the following configuration setting:<pre><code>&lt;runtime&gt;&#13;&#10;&lt;AppContextSwitchOverrides value=&quot;Switch.System.Windows.Controls.Grid.StarDefinitionsCanExceedAvailableSpace=true&quot; /&gt;&#13;&#10;&lt;/runtime&gt;&#13;&#10;</code></pre>|
|Scope|Edge|
|Version|4.7|
|Type|Runtime|

