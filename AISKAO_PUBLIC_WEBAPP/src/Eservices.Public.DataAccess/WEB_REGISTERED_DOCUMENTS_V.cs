//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnoLogica.Eservices.Public.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEB_REGISTERED_DOCUMENTS_V
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int DOCUMENT_TYPE_ID { get; set; }
        public string DOCUMENT_TYPE { get; set; }
        public int CONTENT_ID { get; set; }
        public int CONTENT_TYPE { get; set; }
        public string CONTENT_MIME_TYPE { get; set; }
        public int IS_XML_DOC { get; set; }
        public string TRANSPORT_TYPE { get; set; }
        public System.DateTime CREATED_ON { get; set; }
        public string CREATED_BY { get; set; }
        public System.DateTime REGISTERED_ON { get; set; }
        public string REGISTERED_BY { get; set; }
        public string URI { get; set; }
        public string ACCESS_IDENTIFIER { get; set; }
        public Nullable<int> SERVICE_TYPE_ID { get; set; }
    }
}