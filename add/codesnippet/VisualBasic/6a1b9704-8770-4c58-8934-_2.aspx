        <asp:LinqDataSource  
          ContextTypeName="ExampleDataContext" 
          TableName="Products" 
          EnableUpdate="true" 
          ID="LinqDataSource1" 
          runat="server">
        </asp:LinqDataSource>
        <asp:DetailsView 
          DataSourceID="LinqDataSource1" 
          AllowPaging="True" 
          ID="DetailsView1" 
          runat="server" AutoGenerateRows="False">
          <Fields>
          <asp:templatefield HeaderText="Product ID">
				<itemtemplate>
					<asp:Label ID="IDLabel" runat="server" Text='<%# Bind("ProductID") %>'></asp:Label>
				</itemtemplate>
			</asp:templatefield>
          	<asp:templatefield HeaderText="Product Name">
				<itemtemplate>
					<asp:Label ID="NameLabel" runat="server" Text='<%# Bind("ProductName") %>'></asp:Label>
				</itemtemplate>
			</asp:templatefield>
          	<asp:templatefield HeaderText="Category">
				<itemtemplate>
					<asp:Label ID="CategoryLabel" runat="server" Text='<%# Bind("ProductCategory") %>'></asp:Label>
				</itemtemplate>
			</asp:templatefield>
			<asp:templatefield HeaderText="Color">
				<itemtemplate>
					<asp:Label ID="ColorLabel" runat="server" Text='<%# Bind("Color") %>'></asp:Label>
				</itemtemplate>
			</asp:templatefield>
          </Fields>
        </asp:DetailsView>
        <asp:button 
          ID="Button1"
          Text="Reset with default values" 
          runat="server" 
		  onclick="Add_Click" />