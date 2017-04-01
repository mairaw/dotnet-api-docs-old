   void CloneMyMainMenu()
   {
      // Create the main menu.
      MainMenu^ mainMenu1 = gcnew MainMenu;

      // Create the menu items to add.
      MenuItem^ menuItem1 = gcnew MenuItem;
      MenuItem^ menuItem2 = gcnew MenuItem;
      MenuItem^ menuItem3 = gcnew MenuItem;

      // Set the caption for the menu items.
      menuItem1->Text = "File";
      menuItem2->Text = "Edit";
      menuItem3->Text = "View";

      // Add the menu item to mainMenu1.
      mainMenu1->MenuItems->Add( menuItem1 );
      mainMenu1->MenuItems->Add( menuItem2 );
      mainMenu1->MenuItems->Add( menuItem3 );

      // Clone the mainMenu1 and name it mainMenu2.
      MainMenu^ mainMenu2 = mainMenu1->CloneMenu();

      // Assign mainMenu2 to the form.
      Menu = mainMenu2;
   }