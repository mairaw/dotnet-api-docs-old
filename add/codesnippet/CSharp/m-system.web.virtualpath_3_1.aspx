    StringBuilder sb = new StringBuilder();
    String pathstring = Context.Request.FilePath.ToString();
    sb.Append("Current file path = " + pathstring + "<br />");
    sb.Append("File name = " + VirtualPathUtility.GetFileName(pathstring).ToString() + "<br />");
    sb.Append("File extension = " + VirtualPathUtility.GetExtension(pathstring).ToString() + "<br />");
    sb.Append("Directory = " + VirtualPathUtility.GetDirectory(pathstring).ToString() + "<br />");
    Response.Write(sb.ToString());