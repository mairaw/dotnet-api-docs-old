private:
   void CopyMyMenus()
   {
      // Create empty array to store MenuItem objects.
      array<MenuItem^>^ myItems = gcnew array<MenuItem^>(
         menuItem1->MenuItems->Count + menuItem2->MenuItems->Count );
      
      // Copy elements of the first MenuItem collection to array.
      menuItem1->MenuItems->CopyTo( myItems, 0 );
      // Copy elements of the second MenuItem collection, after the first set.
      menuItem2->MenuItems->CopyTo( myItems, myItems->Length );
      
      // Add the array to the menu item collection of the ContextMenu.
      contextMenu1->MenuItems->AddRange( myItems );
   }