    private void GetCopyright()
    {
        // Get the file version for the notepad.
        FileVersionInfo myFileVersionInfo =
            FileVersionInfo.GetVersionInfo(Environment.SystemDirectory + "\\Notepad.exe");

        // Print the copyright notice.
        textBox1.Text = "Copyright notice: " + myFileVersionInfo.LegalCopyright;
    }