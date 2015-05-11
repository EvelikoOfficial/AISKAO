// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/0009-000093")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/0009-000093", IsNullable=false)]
    public partial class AdministrativeServiceDeliveryLetter : InformationObject<AdministrativeServiceDeliveryLetter> {
        
        private ElectronicAdministrativeServiceURI electronicAdministrativeServiceURIField;
        
        private ElectronicServiceProviderBasicData electronicServiceProviderBasicDataField;
        
        private DocumentURI documentURIField;
        
        private string aISCorrespondenceAccessIdentifierField;
        
        private string aISCaseAccessIdentifierField;
        
        private ElectronicDocumentXml electronicAdministrativeServiceApplicationXmlField;
        
        private ElectronicDocumentXml receiptAcknowledgedMessageXmlField;
        
        private ElectronicDocumentXml paymentRequestXmlField;
        
        private System.DateTime messageCreationTimeField;
        
        private XMLDigitalSignature xMLDigitalSignatureField;
        
        /// <summary>
        /// AdministrativeServiceDeliveryLetter class constructor
        /// </summary>
        public AdministrativeServiceDeliveryLetter() {
            this.xMLDigitalSignatureField = new XMLDigitalSignature();
            this.paymentRequestXmlField = new ElectronicDocumentXml();
            this.receiptAcknowledgedMessageXmlField = new ElectronicDocumentXml();
            this.electronicAdministrativeServiceApplicationXmlField = new ElectronicDocumentXml();
            this.documentURIField = new DocumentURI();
            this.electronicServiceProviderBasicDataField = new ElectronicServiceProviderBasicData();
            this.electronicAdministrativeServiceURIField = new ElectronicAdministrativeServiceURI();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ElectronicAdministrativeServiceURI ElectronicAdministrativeServiceURI {
            get {
                return this.electronicAdministrativeServiceURIField;
            }
            set {
                if ((this.electronicAdministrativeServiceURIField != null)) {
                    if ((electronicAdministrativeServiceURIField.Equals(value) != true)) {
                        this.electronicAdministrativeServiceURIField = value;
                        this.OnPropertyChanged("ElectronicAdministrativeServiceURI");
                    }
                }
                else {
                    this.electronicAdministrativeServiceURIField = value;
                    this.OnPropertyChanged("ElectronicAdministrativeServiceURI");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ElectronicServiceProviderBasicData ElectronicServiceProviderBasicData {
            get {
                return this.electronicServiceProviderBasicDataField;
            }
            set {
                if ((this.electronicServiceProviderBasicDataField != null)) {
                    if ((electronicServiceProviderBasicDataField.Equals(value) != true)) {
                        this.electronicServiceProviderBasicDataField = value;
                        this.OnPropertyChanged("ElectronicServiceProviderBasicData");
                    }
                }
                else {
                    this.electronicServiceProviderBasicDataField = value;
                    this.OnPropertyChanged("ElectronicServiceProviderBasicData");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DocumentURI DocumentURI {
            get {
                return this.documentURIField;
            }
            set {
                if ((this.documentURIField != null)) {
                    if ((documentURIField.Equals(value) != true)) {
                        this.documentURIField = value;
                        this.OnPropertyChanged("DocumentURI");
                    }
                }
                else {
                    this.documentURIField = value;
                    this.OnPropertyChanged("DocumentURI");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string AISCorrespondenceAccessIdentifier {
            get {
                return this.aISCorrespondenceAccessIdentifierField;
            }
            set {
                if ((this.aISCorrespondenceAccessIdentifierField != null)) {
                    if ((aISCorrespondenceAccessIdentifierField.Equals(value) != true)) {
                        this.aISCorrespondenceAccessIdentifierField = value;
                        this.OnPropertyChanged("AISCorrespondenceAccessIdentifier");
                    }
                }
                else {
                    this.aISCorrespondenceAccessIdentifierField = value;
                    this.OnPropertyChanged("AISCorrespondenceAccessIdentifier");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string AISCaseAccessIdentifier {
            get {
                return this.aISCaseAccessIdentifierField;
            }
            set {
                if ((this.aISCaseAccessIdentifierField != null)) {
                    if ((aISCaseAccessIdentifierField.Equals(value) != true)) {
                        this.aISCaseAccessIdentifierField = value;
                        this.OnPropertyChanged("AISCaseAccessIdentifier");
                    }
                }
                else {
                    this.aISCaseAccessIdentifierField = value;
                    this.OnPropertyChanged("AISCaseAccessIdentifier");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ElectronicDocumentXml ElectronicAdministrativeServiceApplicationXml {
            get {
                return this.electronicAdministrativeServiceApplicationXmlField;
            }
            set {
                if ((this.electronicAdministrativeServiceApplicationXmlField != null)) {
                    if ((electronicAdministrativeServiceApplicationXmlField.Equals(value) != true)) {
                        this.electronicAdministrativeServiceApplicationXmlField = value;
                        this.OnPropertyChanged("ElectronicAdministrativeServiceApplicationXml");
                    }
                }
                else {
                    this.electronicAdministrativeServiceApplicationXmlField = value;
                    this.OnPropertyChanged("ElectronicAdministrativeServiceApplicationXml");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public ElectronicDocumentXml ReceiptAcknowledgedMessageXml {
            get {
                return this.receiptAcknowledgedMessageXmlField;
            }
            set {
                if ((this.receiptAcknowledgedMessageXmlField != null)) {
                    if ((receiptAcknowledgedMessageXmlField.Equals(value) != true)) {
                        this.receiptAcknowledgedMessageXmlField = value;
                        this.OnPropertyChanged("ReceiptAcknowledgedMessageXml");
                    }
                }
                else {
                    this.receiptAcknowledgedMessageXmlField = value;
                    this.OnPropertyChanged("ReceiptAcknowledgedMessageXml");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public ElectronicDocumentXml PaymentRequestXml {
            get {
                return this.paymentRequestXmlField;
            }
            set {
                if ((this.paymentRequestXmlField != null)) {
                    if ((paymentRequestXmlField.Equals(value) != true)) {
                        this.paymentRequestXmlField = value;
                        this.OnPropertyChanged("PaymentRequestXml");
                    }
                }
                else {
                    this.paymentRequestXmlField = value;
                    this.OnPropertyChanged("PaymentRequestXml");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public System.DateTime MessageCreationTime {
            get {
                return this.messageCreationTimeField;
            }
            set {
                if ((messageCreationTimeField.Equals(value) != true)) {
                    this.messageCreationTimeField = value;
                    this.OnPropertyChanged("MessageCreationTime");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public XMLDigitalSignature XMLDigitalSignature {
            get {
                return this.xMLDigitalSignatureField;
            }
            set {
                if ((this.xMLDigitalSignatureField != null)) {
                    if ((xMLDigitalSignatureField.Equals(value) != true)) {
                        this.xMLDigitalSignatureField = value;
                        this.OnPropertyChanged("XMLDigitalSignature");
                    }
                }
                else {
                    this.xMLDigitalSignatureField = value;
                    this.OnPropertyChanged("XMLDigitalSignature");
                }
            }
        }
    }
}