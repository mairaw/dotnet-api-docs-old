      // Display message box parented to the main form. 
      // The Help button opens the Mspaint.chm Help file, 
      // shows index with the "ovals" keyword selected, and displays the
      // associated topic.
      System::Windows::Forms::DialogResult r6 = MessageBox::Show( this, "Message with Help file and Help navigator with additional parameter.", "Help Caption", MessageBoxButtons::OK, MessageBoxIcon::Question, MessageBoxDefaultButton::Button1, (MessageBoxOptions)0, "mspaint.chm", HelpNavigator::KeywordIndex, "ovals" );