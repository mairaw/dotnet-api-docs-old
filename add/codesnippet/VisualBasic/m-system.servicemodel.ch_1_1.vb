			Dim binding As New CustomBinding()
			Dim bpCol As New BindingParameterCollection()
			Dim context As New BindingContext(binding, bpCol)
			context.CanBuildInnerChannelListener(Of IDuplexChannel)()