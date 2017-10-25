### Crash in Selector when removing an item from a custom INCC collection

|   |   |
|---|---|
|Details|An &#39;T:System.InvalidOperationException` can occur in the following scenario:<ul><li>The ItemsSource for a <code>T:System.Windows.Controls.Primitives.Selector</code> is a collection with a custom implementation of <code>T:System.Collections.Specialized.INotifyCollectionChanged</code>.</li><li>The selected item is removed from the collection.</li><li>The <code>T:System.Collections.Specialized.NotifyCollectionChangedEventArgs</code> has <code>P:System.Collections.Specialized.NotifyCollectionChangedEventArgs.OldStartingIndex</code> = -1 (indicating an unknown position).</li></ul>The exception&#39;s callstack begins at System.Windows.Threading.Dispatcher.VerifyAccess() at System.Windows.DependencyObject.GetValue(DependencyProperty dp) at System.Windows.Controls.Primitives.Selector.GetIsSelected(DependencyObject element)This exception can occur in .Net 4.5 if the application has more than one Dispatcher thread. In .Net 4.7 the exception can also occur in applications with a single Dispatcher thread. The issue is fixed in .Net 4.7.1.|
|Suggestion|Upgrade to .Net 4.7.1.|
|Scope|Minor|
|Version|4.7|
|Type|Runtime|

