        XmlDocument document = new XmlDocument();
        document.Load("contosoBooks.xml");
        XPathNavigator navigator = document.CreateNavigator();

        navigator.MoveToChild("bookstore", "http://www.contoso.com/books");
        navigator.MoveToChild("book", "http://www.contoso.com/books");
        navigator.MoveToChild("price", "http://www.contoso.com/books");

        navigator.ReplaceSelf("<pages>100</pages>");

        Console.WriteLine("Position after delete: {0}", navigator.Name);
        Console.WriteLine(navigator.OuterXml);