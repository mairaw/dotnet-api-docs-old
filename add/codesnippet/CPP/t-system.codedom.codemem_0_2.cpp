         // This example demonstrates declaring a public constant type member field.

         // When declaring a public constant type member field, you must set a particular
         // access and scope mask to the member attributes of the field in order for the
         // code generator to properly generate the field as a constant field.

         // Declares an integer field using a CodeMemberField
         CodeMemberField^ constPublicField = gcnew CodeMemberField( int::typeid,"testConstPublicField" );
         
         // Resets the access and scope mask bit flags of the member attributes of the field
         // before setting the member attributes of the field to public and constant.
         constPublicField->Attributes = (MemberAttributes)((constPublicField->Attributes &  ~MemberAttributes::AccessMask &  ~MemberAttributes::ScopeMask) | MemberAttributes::Public | MemberAttributes::Const);