        XmlDocument^ document = gcnew XmlDocument();
        document->Load("contosoBooks.xml");
        XPathNavigator^ navigator = document->CreateNavigator();

        navigator->MoveToChild("bookstore", "http://www.contoso.com/books");
        navigator->MoveToChild("book", "http://www.contoso.com/books");
        navigator->MoveToChild("price", "http://www.contoso.com/books");

        navigator->InsertElementAfter(navigator->Prefix, "pages", navigator->LookupNamespace(navigator->Prefix), "100");

        navigator->MoveToParent();
        Console::WriteLine(navigator->OuterXml);