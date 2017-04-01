      private void Create_Table()
      {
         // Create DataSet.
         myDataSet = new DataSet("myDataSet");
         // Create DataTable.
         DataTable myCustomerTable = new DataTable("Customers");
         // Create two columns, and add them to the table.
         DataColumn CustID = new DataColumn("CustID", typeof(int));
         DataColumn CustName = new DataColumn("CustName");
         myCustomerTable.Columns.Add(CustID);
         myCustomerTable.Columns.Add(CustName);
         // Add table to DataSet.
         myDataSet.Tables.Add(myCustomerTable);
         dataGrid1.SetDataBinding(myDataSet,"Customers");
         myTableStyle = new DataGridTableStyle();
         myTableStyle.MappingName = "Customers";
         myTableStyle.HeaderBackColorChanged += 
            new System.EventHandler(HeaderBackColorChangedHandler); 
         myTableStyle.HeaderForeColorChanged +=
            new System.EventHandler(HeaderForeColorChangedHandler); 
      }
      
      // Change header background color.
      private void OnHeaderBackColor_Click(object sender, System.EventArgs e)
      {
         dataGrid1.TableStyles.Clear ();
         switch(comboBox1.SelectedItem.ToString())
         {
            case "Red":
               myTableStyle.HeaderBackColor = Color.Red;
               break;
            case "Yellow":
               myTableStyle.HeaderBackColor = Color.Yellow ;
               break;
            case "Blue":
               myTableStyle.HeaderBackColor = Color.Blue ;
               break;
         }
         myTableStyle.AlternatingBackColor = Color.LightGray;
         dataGrid1.TableStyles.Add(myTableStyle);
      }