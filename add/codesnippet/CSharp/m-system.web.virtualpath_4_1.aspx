    StringBuilder sb2 = new StringBuilder();
    String pathstring1 = Context.Request.CurrentExecutionFilePath.ToString();
    sb2.Append("Current Executing File Path = " + pathstring1.ToString() + "<br />");
    sb2.Append("Is Absolute = " + VirtualPathUtility.IsAbsolute(pathstring1).ToString() + "<br />");
    sb2.Append("Is AppRelative = " + VirtualPathUtility.IsAppRelative(pathstring1).ToString() + "<br />");
    sb2.Append("Make AppRelative = " + VirtualPathUtility.ToAppRelative(pathstring1).ToString() + "<br />");
    Response.Write(sb2.ToString());