   // Build an in-memory representation from persistent
   // storage, and return the root node of the site map.
   virtual SiteMapNode ^ BuildSiteMap() override
   {
      // Since the SiteMap class is static, make sure that it is
      // not modified while the site map is built.
      System::Threading::Monitor::Enter( this );
      try
      {
         
         // If there is no initialization, this method is being
         // called out of order.
         if (  !IsInitialized )
         {
            throw gcnew Exception( "BuildSiteMap called incorrectly." );
         }
         
         // If there is no root node, then there is no site map.
         if ( nullptr == rootNode )
         {
            
            // Start with a clean slate
            Clear();
            
            // Select the root node of the site map from Microsoft Access.
            int rootNodeId = -1;
            if ( accessConnection->State == ConnectionState::Closed )
               accessConnection->Open();
            
            OleDbCommand^ rootNodeCommand = gcnew OleDbCommand
               ("SELECT nodeid, url, name FROM SiteMap WHERE parentnodeid IS NULL", accessConnection);
            OleDbDataReader^ rootNodeReader = rootNodeCommand->ExecuteReader();
            if ( rootNodeReader->HasRows )
            {
               rootNodeReader->Read();
               rootNodeId = rootNodeReader->GetInt32( 0 );
               
               // Create a SiteMapNode that references the current StaticSiteMapProvider.
               rootNode = gcnew SiteMapNode(this, rootNodeId.ToString(), 
                  rootNodeReader->GetString( 1 ),rootNodeReader->GetString( 2 ));
            }
            else
               return nullptr;
            rootNodeReader->Close();
            
            // Select the child nodes of the root node.
            OleDbCommand^ childNodesCommand = gcnew OleDbCommand
               ("SELECT nodeid, url, name FROM SiteMap WHERE parentnodeid = ?", accessConnection);
            OleDbParameter^ rootParam = gcnew OleDbParameter( "parentid", OleDbType::Integer);
            rootParam->Value = rootNodeId;
            childNodesCommand->Parameters->Add( rootParam );
            OleDbDataReader^ childNodesReader = childNodesCommand->ExecuteReader();
            if ( childNodesReader->HasRows )
            {
               SiteMapNode ^ childNode = nullptr;
               while ( childNodesReader->Read() )
               {
                  childNode = gcnew SiteMapNode( this, 
					  System::Convert::ToString(childNodesReader->GetInt32( 0 )),
                     childNodesReader->GetString( 1 ),
                     childNodesReader->GetString( 2 ) 
                  );
                  // Use the SiteMapNode AddNode method to add
                  // the SiteMapNode to the ChildNodes collection.
                  AddNode( childNode, rootNode );
               }
            }
            childNodesReader->Close();
            accessConnection->Close();
         }
         return rootNode;
      }
      finally
      {
         System::Threading::Monitor::Exit( this );
      }

   }
