---
title: "Entity Framework Terminology | Microsoft Docs"
ms.custom: ""
ms.date: "03/30/2017"
ms.prod: ".net-framework"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "dotnet-ado"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: fa2a1bd1-6118-487b-8673-eebc66b92945
caps.latest.revision: 4
author: "JennieHubbard"
ms.author: "jhubbard"
manager: "jhubbard"
---
# Entity Framework Terminology
This topic defines terms frequently referenced in [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] documentation. Links are provided to relevant topics where additional information is available.  
  
|Term|Definition|  
|----------|----------------|  
|association|The definition of a relationship between entity types.<br /><br /> For more information, see [Association Element (CSDL)](http://msdn.microsoft.com/en-us/c305169a-8af7-432f-9ba7-800a163aed41) and [association type](../../../../../docs/framework/data/adonet/association-type.md).|  
|association set|A logical container for instances of associations of the same type.<br /><br /> For more information, see [AssociationSet Element (CSDL)](http://msdn.microsoft.com/en-us/512cbb75-cebe-4f3f-970d-3419deeff684) and [association set](../../../../../docs/framework/data/adonet/association-set.md).|  
|Code First|Starting with the Entity Framework 4.1 you can create a model programmatically using Code First development. There are two different scenarios for Code First development. In both cases, the developer defines a model by coding .NET Framework class definitions, and then optionally specifies additional mapping or configuration by using Data Annotations or the fluent API.<br /><br /> Note, that Code First development is part of the [Entity Framework 5.0](http://go.microsoft.com/fwlink/?LinkId=234900). The Entity Framework 5.0 is not part of the .NET Framework, but is built on .NET Framework 4.5. The Entity Framework 5.0 is available as the [‘Entity Framework’](http://go.microsoft.com/fwlink/?LinkID=215714)[NuGet](http://go.microsoft.com/fwlink/?LinkId=232488) package. For more information, see [Entity Framework Releases and Versioning](http://go.microsoft.com/fwlink/?LinkId=234899).|  
|command tree|A common, programmatic representation of all [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] queries that are composed of one or more expressions.<br /><br /> For more information, see [Entity Framework Overview](../../../../../docs/framework/data/adonet/ef/overview.md).|  
|complex type|A [!INCLUDE[dnprdnshort](../../../../../includes/dnprdnshort-md.md)] class that represents a complex property as defined in the conceptual model. Complex types enable scalar properties to be organized within entities. Complex objects are instances of complex types. For more information, see [ComplexType Element (CSDL)](http://msdn.microsoft.com/en-us/f1c2f311-9889-4b87-abd8-a94f322052e3) and [complex type](../../../../../docs/framework/data/adonet/complex-type.md).|  
|ComplexType|The specification for a data type that represents a non-scalar property of an entity type that does not have a key property.<br /><br /> For more information, see [ComplexType Element (CSDL)](http://msdn.microsoft.com/en-us/f1c2f311-9889-4b87-abd8-a94f322052e3) and [complex type](../../../../../docs/framework/data/adonet/complex-type.md).|  
|conceptual model|An abstract specification for the entity types, complex types, associations, entity containers, entity sets, and association sets in the domain of an application in the [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)]. The conceptual model is defined in CSDL in the .csdl file.<br /><br /> For more information, see [Modeling and Mapping](../../../../../docs/framework/data/adonet/ef/modeling-and-mapping.md).|  
|.csdl file|An XML file that contains the conceptual model, expressed in CSDL.|  
|conceptual schema definition language (CSDL)|An XML-based language that is used to define the entity types, associations, entity containers, entity sets, and association sets of a conceptual model.<br /><br /> For more information, see [CSDL Specification](../../../../../docs/framework/data/adonet/ef/language-reference/csdl-specification.md).|  
|container|A logical grouping of entity and association sets.<br /><br /> For more information, see [EntityContainer Element (CSDL)](http://msdn.microsoft.com/en-us/06d03ecb-3b7a-4e7f-95d5-b95307d47a27) and [entity container](../../../../../docs/framework/data/adonet/entity-container.md).|  
|concurrency|A process that allows multiple users to access and change shared data at the same time. By default, the [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] implements an optimistic concurrency model.|  
|direction|Refers to the asymmetrical nature of some associations. Direction is specified with `FromRole` and `ToRole` attributes of a `NavigationProperty` or `ReferentialConstraint` element in a schema.<br /><br /> For more information, see [NavigationProperty Element (CSDL)](http://msdn.microsoft.com/en-us/5829a238-a50e-4c81-901d-7b54fc00f27e) and [navigation property](../../../../../docs/framework/data/adonet/navigation-property.md).|  
|eager loading|The process of loading a specific set of related objects along with the objects that were explicitly requested in the query.|  
|.edmx file|An XML file that contains the conceptual model (in CSDL), the storage model (in SSDL), and the mappings between them (in MSL). The .edmx file is created by the [!INCLUDE[adonet_edm](../../../../../includes/adonet-edm-md.md)] Tools. For more information, see [.edmx File Overview](http://msdn.microsoft.com/en-us/f4c8e7ce-1db6-417e-9759-15f8b55155d4).|  
|end|A participating entity in an association.<br /><br /> For more information, see [End Element (CSDL)](http://msdn.microsoft.com/en-us/04f3c141-95bc-424b-989b-1c071b449e7c) and [association end](../../../../../docs/framework/data/adonet/association-end.md).|  
|entity|A concept in the domain of an application from which a data type is defined.<br /><br /> For more information, see [EntityType Element (CSDL)](http://msdn.microsoft.com/en-us/19562e9f-fd70-4b59-bc15-3e289cbb6054) and [entity type](../../../../../docs/framework/data/adonet/entity-type.md).|  
|EntityClient|A storage-independent [!INCLUDE[vstecado](../../../../../includes/vstecado-md.md)] data provider that contains classes such as `EntityConnection`, `EntityCommand`, and `EntityDataReader`. Works with [!INCLUDE[esql](../../../../../includes/esql-md.md)] and connects to storage specific [!INCLUDE[vstecado](../../../../../includes/vstecado-md.md)] data providers, such as `SqlClient`.<br /><br /> For more information, see [EntityClient Provider for the Entity Framework](../../../../../docs/framework/data/adonet/ef/entityclient-provider-for-the-entity-framework.md).|  
|entity container|Specifies entity sets and association sets that will be implemented in a specified namespace.<br /><br /> For more information, see [EntityContainer Element (CSDL)](http://msdn.microsoft.com/en-us/06d03ecb-3b7a-4e7f-95d5-b95307d47a27) and [entity container](../../../../../docs/framework/data/adonet/entity-container.md).|  
|Entity Data Model (EDM)|A set of concepts that describe the structure of data, as entities and relationships, regardless of its stored form.<br /><br /> For more information, see [Entity Data Model](../../../../../docs/framework/data/adonet/entity-data-model.md).|  
|Entity Framework|A set of technologies that supports development of data-oriented software applications by enabling developers to work with conceptual models that are mapped to logical schemas in data sources.<br /><br /> For more information, see [Entity Framework Overview](../../../../../docs/framework/data/adonet/ef/overview.md).|  
|entity set|A logical container for entities of a given type and its subtypes. Entity sets are mapped to tables in a database.<br /><br /> For more information, see [EntitySet Element (CSDL)](http://msdn.microsoft.com/en-us/ec56db77-718d-4c0e-adc9-f1d33c896287) and [entity set](../../../../../docs/framework/data/adonet/entity-set.md).|  
|Entity SQL|A storage-independent dialect of SQL that works directly with conceptual entity schemas and that supports conceptual model concepts such as inheritance and relationships.<br /><br /> For more information, see [Entity SQL Language](../../../../../docs/framework/data/adonet/ef/language-reference/entity-sql-language.md).|  
|entity type|A [!INCLUDE[dnprdnshort](../../../../../includes/dnprdnshort-md.md)] class that represents an entity as it is defined in the conceptual model. Entity types may have scalar, complex, and navigation properties. Objects are instances of entity types. For more information, see [Working with Objects](../../../../../docs/framework/data/adonet/ef/working-with-objects.md).|  
|EntityType|The specification for a data type that includes a key and a named set of properties and represents a top-level item in a conceptual model or storage model.<br /><br /> For more information, see [EntityType Element (CSDL)](http://msdn.microsoft.com/en-us/19562e9f-fd70-4b59-bc15-3e289cbb6054) and [entity type](../../../../../docs/framework/data/adonet/entity-type.md).|  
|explicit loading|When objects are returned by a query, related objects are not loaded at the same time. By default, they are not loaded until explicitly requested using the `Load` method on a navigation property.|  
|foreign key association|An association between entities that is managed through foreign key properties.|  
|identifying relationship|A relationship where the primary key of the principal entity is part of the primary key of the dependent entity. In this kind of relationship, the dependent entity cannot exist without the principal entity.|  
|independent association|An association between entities that is represented and tracked by an independent object.|  
|key|The attribute of an entity type that specifies which property or set of properties is used to identify unique instances of the entity type. Represented in the object layer by the <xref:System.Data.EntityKey> class.<br /><br /> For more information, see [Key Element (CSDL)](http://msdn.microsoft.com/en-us/0cdb1402-dbc7-4a04-a11e-5729cdf7431b) and [entity key](../../../../../docs/framework/data/adonet/entity-key.md).|  
|lazy loading|When objects are returned by a query, related objects are not loaded at the same time. Instead they are loaded automatically when the navigation property is accessed.|  
|[!INCLUDE[linq_entities](../../../../../includes/linq-entities-md.md)]|A query syntax that defines a set of query operators that allow traversal, filter, and projection operations to be expressed in a direct, declarative way in [!INCLUDE[csprcs](../../../../../includes/csprcs-md.md)] and [!INCLUDE[vbprvb](../../../../../includes/vbprvb-md.md)].<br /><br /> For more information, see [LINQ to Entities](../../../../../docs/framework/data/adonet/ef/language-reference/linq-to-entities.md).|  
|mapping|A specification of the correspondences between items in a conceptual model and items in a storage model.<br /><br /> For more information, see [MSL Specification](../../../../../docs/framework/data/adonet/ef/language-reference/msl-specification.md).|  
|.msl file|An XML file that contains the mapping between the conceptual model and the storage model, expressed in MSL.|  
|mapping specification language (MSL)|An XML-based language that is used to map items defined in a conceptual model to items in a storage model.<br /><br /> For more information, see [MSL Specification](../../../../../docs/framework/data/adonet/ef/language-reference/msl-specification.md).|  
|modification functions|Stored procedures that are used to insert, update, and delete data that is in the data source. These functions are used in place of [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] generated commands. Modification functions are defined by the `Function` element in the storage model. The [ModificationFunctionMapping](http://msdn.microsoft.com/en-us/b44b5b13-9937-448b-ba36-7a0cfefea782) element maps these modification functions to insert, update, and delete operations against entities that are defined in the conceptual model.|  
|multiplicity|The number of entities that can exist on each side of a relationship, as defined by an association. Also known as cardinality.<br /><br /> For more information, see [End Element (CSDL)](http://msdn.microsoft.com/en-us/04f3c141-95bc-424b-989b-1c071b449e7c) and [association end](../../../../../docs/framework/data/adonet/association-end.md).|  
|multiple entity sets per type|The ability for an entity type to be defined in more than one entity set.<br /><br /> For more information, see [EntitySet Element (CSDL)](http://msdn.microsoft.com/en-us/ec56db77-718d-4c0e-adc9-f1d33c896287) and [How to: Define a Model with Multiple Entity Sets per Type](http://msdn.microsoft.com/en-us/61aa4fca-5ac0-4f47-9bc8-46e8c2965ef7).|  
|navigation property|A property of an entity type that represents a relationship to another entity type, as defined by an association. Navigation properties are used to return related objects as an <xref:System.Data.Objects.DataClasses.EntityCollection%601> or an <xref:System.Data.Objects.DataClasses.EntityReference%601>, depending on the multiplicity at the other end of the association.<br /><br /> For more information, see [NavigationProperty Element (CSDL)](http://msdn.microsoft.com/en-us/5829a238-a50e-4c81-901d-7b54fc00f27e) and [navigation property](../../../../../docs/framework/data/adonet/navigation-property.md).|  
|query path|A string representation of a path that specifies which related objects to return when an object query is executed. A query path is defined by calling the <xref:System.Data.Objects.ObjectQuery%601.Include%2A> method on an <xref:System.Data.Objects.ObjectQuery%601>.<br /><br /> For more information, see [Loading Related Objects](http://msdn.microsoft.com/en-us/452347d2-7b3b-44cd-9001-231299a28cb1).|  
|object context|Represents the entity container defined in the conceptual model. It contains a connection to the underlying data source and provides services such as change tracking and identity resolution. An object cont ext is represented by an instance of the <xref:System.Data.Objects.ObjectContext> or `DbContext` class.<br /><br /> `DbContext` is part of the [Entity Framework 5.0](http://go.microsoft.com/fwlink/?LinkId=234900). The Entity Framework 5.0 is not part of the .NET Framework, but is built on .NET Framework 4.5. The Entity Framework 5.0 is available as the [‘Entity Framework’](http://go.microsoft.com/fwlink/?LinkID=215714)[NuGet](http://go.microsoft.com/fwlink/?LinkId=232488) package. For more information, see [Entity Framework Releases and Versioning](http://go.microsoft.com/fwlink/?LinkId=234899).|  
|object layer|The entity types and object context definitions that are used by the Entity Framework.|  
|object query|A query executed within an object context against a conceptual model that returns data as objects.<br /><br /> For more information, see [Object Queries](http://msdn.microsoft.com/en-us/0768033c-876f-471d-85d5-264884349276).|  
|object-relational mapping|A technique for transforming data from a relational database into data types that can be used in object-oriented software applications.<br /><br /> The [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] provides object-relational mapping services by mapping relational data, as defined in the storage model, to data types, as defined in the conceptual model.<br /><br /> For more information, see [Modeling and Mapping](../../../../../docs/framework/data/adonet/ef/modeling-and-mapping.md).|  
|Object Services|Services provided by the [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] that enable application code to operate on entities like [!INCLUDE[dnprdnshort](../../../../../includes/dnprdnshort-md.md)] objects.|  
|persistence-ignorant object|An object that does not contain any logic that is related to data storage. Also known as a POCO entity.|  
|POCO|Plain Old CLR Object. An object that does not inherit from another class or implement an interface.|  
|POCO entity|An entity in the [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] that does not inherit from <xref:System.Data.Objects.DataClasses.EntityObject> or <xref:System.Data.Objects.DataClasses.ComplexObject> and does not implement the [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] interfaces. Frequently, POCO entities are existing domain objects that you use in an [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] application. These entities support persistence ignorance. For more information, see [Working with POCO Entities](http://msdn.microsoft.com/en-us/5e0fb82a-b6d1-41a1-b37b-c12db61629d3).|  
|proxy object|An object that derives from a POCO class and is generated by the [!INCLUDE[adonet_ef](../../../../../includes/adonet-ef-md.md)] to support change tracking and lazy loading. For more information, see [Requirements for Creating POCO Proxies](http://msdn.microsoft.com/en-us/dcdbf982-9b9d-4582-806a-64de4a1c03c8).|  
|referential constraint|A constraint that is defined in a conceptual model that indicates that an entity has a dependent relationship to another entity. This constraint means that an instance of a dependent entity cannot exist without a corresponding instance of the principle entity<br /><br /> For more information, see [ReferentialConstraint Element (CSDL)](http://msdn.microsoft.com/en-us/24f96a80-85b5-4f2e-a14c-0e3eb6796fa0) and [referential integrity constraint](../../../../../docs/framework/data/adonet/referential-integrity-constraint.md).|  
|relationship|A logical connection between entities.|  
|role|The name given to each `End` of an association to clarify the semantics of the relationship.<br /><br /> For more information, see [End Element (CSDL)](http://msdn.microsoft.com/en-us/04f3c141-95bc-424b-989b-1c071b449e7c) and [association end](../../../../../docs/framework/data/adonet/association-end.md).|  
|scalar property|A property of an entity that maps to a single field in the storage model.|  
|self-tracking entity|An entity built from a Text Template Transformation Toolkit (T4) that has the ability to record changes to scalar, complex, and navigation properties.|  
|simple type|A primitive type that is used for defining properties in the conceptual model.<br /><br /> For more information, see [Conceptual Model Types (CSDL)](http://msdn.microsoft.com/en-us/987b995f-e429-4569-9559-b4146744def4) and [Entity Data Model: Primitive Data Types](../../../../../docs/framework/data/adonet/entity-data-model-primitive-data-types.md).|  
|split entity|An entity type that is mapped to two separate types in the storage model.<br /><br /> For more information, see [How to: Define a Model with a Single Entity Mapped to Two Tables](http://msdn.microsoft.com/en-us/01762517-e4ab-439d-99e6-564ab7d6f3ed).|  
|storage model|A definition for the logical model of data in a supported data source, such as a relational database. The storage model is defined in SSDL in the .ssdl file.<br /><br /> For more information, see [Modeling and Mapping](../../../../../docs/framework/data/adonet/ef/modeling-and-mapping.md) and [SSDL Specification](../../../../../docs/framework/data/adonet/ef/language-reference/ssdl-specification.md).|  
|.ssdl file|An XML file that contains the storage model, expressed in SSDL.|  
|store schema definition language (SSDL)|An XML-based language that is used to define the entity types, associations, entity containers, entity sets, and association sets of a storage model that frequently corresponds to a database schema.<br /><br /> For more information, see [SSDL Specification](../../../../../docs/framework/data/adonet/ef/language-reference/ssdl-specification.md).|  
|table-per-hierarchy|A method of modeling a type hierarchy in a database that includes the attributes of all the types in the hierarchy in one table.|  
|table-per-type|A method of modeling a type hierarchy in a database that uses multiple tables with one-to-one relationships to model the various types.|  
  
## See Also  
 [ADO.NET Entity Framework](../../../../../docs/framework/data/adonet/ef/index.md)   
 [Entity Framework Overview](../../../../../docs/framework/data/adonet/ef/overview.md)   
 [Getting Started](../../../../../docs/framework/data/adonet/ef/getting-started.md)   
 [Entity Framework Resources](../../../../../docs/framework/data/adonet/ef/resources.md)