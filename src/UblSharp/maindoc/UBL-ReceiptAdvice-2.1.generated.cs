// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UblSharp.CommonAggregateComponents;
    using UblSharp.UnqualifiedDataTypes;
    using UblSharp.CommonExtensionComponents;
    
    
    /// <summary>
    /// A document used to describe the receipt of goods and services.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Receipt Advice. Details
    /// <para />ObjectClass: Receipt Advice
    /// <para />AlternativeBusinessTerms: Receipt, Delivery Acknowledgement
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ReceiptAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ReceiptAdvice-2")]
    [System.Xml.Serialization.XmlRootAttribute("ReceiptAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ReceiptAdvice-2", IsNullable=false)]
    public partial class ReceiptAdviceType : BaseDocument, IBaseDocument
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public CodeType @__DocumentStatusCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiptAdviceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public CodeType @__ReceiptAdviceTypeCode;
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public TextType[] @__Note
        {
            get
            {
                return _note?.ToArray();
            }
            set
            {
                _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public NumericType @__LineCountNumeric;
        
        private System.Collections.Generic.List<OrderReferenceType> _orderReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=14)]
        public OrderReferenceType[] @__OrderReference
        {
            get
            {
                return _orderReference?.ToArray();
            }
            set
            {
                _orderReference = value == null ? null : new System.Collections.Generic.List<OrderReferenceType>(value);
            }
        }
        
        private System.Collections.Generic.List<DocumentReferenceType> _despatchDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public DocumentReferenceType[] @__DespatchDocumentReference
        {
            get
            {
                return _despatchDocumentReference?.ToArray();
            }
            set
            {
                _despatchDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
            }
        }
        
        private System.Collections.Generic.List<DocumentReferenceType> _additionalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public DocumentReferenceType[] @__AdditionalDocumentReference
        {
            get
            {
                return _additionalDocumentReference?.ToArray();
            }
            set
            {
                _additionalDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
            }
        }
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DeliveryCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public CustomerPartyType @__DeliveryCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DespatchSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public SupplierPartyType @__DespatchSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("BuyerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public CustomerPartyType @__BuyerCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public ShipmentType @__Shipment;
        
        private System.Collections.Generic.List<ReceiptLineType> _receiptLine;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public ReceiptLineType[] @__ReceiptLine
        {
            get
            {
                return _receiptLine?.ToArray();
            }
            set
            {
                _receiptLine = value == null ? null : new System.Collections.Generic.List<ReceiptLineType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// A reference to an Order associated with this Receipt Advice.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Order Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Order Reference
        /// <para />AssociatedObjectClass: Order Reference
        /// <para />RepresentationTerm: Order Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<OrderReferenceType> OrderReference
        {
            get { return _orderReference ?? (_orderReference = new System.Collections.Generic.List<OrderReferenceType>()); }
            set { _orderReference = value; }
        }

        
        /// <summary>
        /// A reference to a Despatch Advice associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Despatch_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTermQualifier: Despatch
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> DespatchDocumentReference
        {
            get { return _despatchDocumentReference ?? (_despatchDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
            set { _despatchDocumentReference = value; }
        }

        
        /// <summary>
        /// A reference to an additional document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Additional_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTermQualifier: Additional
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> AdditionalDocumentReference
        {
            get { return _additionalDocumentReference ?? (_additionalDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
            set { _additionalDocumentReference = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// A line detailing a kind of item received.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Receipt Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Receipt Line
        /// <para />AssociatedObjectClass: Receipt Line
        /// <para />RepresentationTerm: Receipt Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ReceiptLineType> ReceiptLine
        {
            get { return _receiptLine ?? (_receiptLine = new System.Collections.Generic.List<ReceiptLineType>()); }
            set { _receiptLine = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0.5</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>NES</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the subset of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BasicProcurementProcess</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// A code signifying the status of the Receipt Advice with respect to its original state. This code may be used if the document precedes the event and is subsequently found to be incorrect and in need of cancellation or revision.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Document Status Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Document Status Code
        /// <para />RepresentationTerm: Code
        /// <para />DataTypeQualifier: Document Status
        /// <para />DataType: Document Status_ Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType DocumentStatusCode
        {
            get
            {
                if (__DocumentStatusCode == null) { __DocumentStatusCode = new CodeType(); }
                return __DocumentStatusCode;
            }
            set
            {
                __DocumentStatusCode = value;
            }
        }

        
        /// <summary>
        /// A code signifying the type of the Receipt Advice.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Receipt Advice Type Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Receipt Advice Type Code
        /// <para />RepresentationTerm: Code
        /// <para />DataTypeQualifier: Receipt Advice Type
        /// <para />DataType: Receipt Advice Type_ Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType ReceiptAdviceTypeCode
        {
            get
            {
                if (__ReceiptAdviceTypeCode == null) { __ReceiptAdviceTypeCode = new CodeType(); }
                return __ReceiptAdviceTypeCode;
            }
            set
            {
                __ReceiptAdviceTypeCode = value;
            }
        }

        
        /// <summary>
        /// The number of Receipt Lines in this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Receipt Advice. Line Count. Numeric
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Line Count
        /// <para />RepresentationTerm: Numeric
        /// <para />DataType: Numeric. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public NumericType LineCountNumeric
        {
            get
            {
                if (__LineCountNumeric == null) { __LineCountNumeric = new NumericType(); }
                return __LineCountNumeric;
            }
            set
            {
                __LineCountNumeric = value;
            }
        }

        
        /// <summary>
        /// The customer party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Delivery_ Customer Party. Customer Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTermQualifier: Delivery
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType DeliveryCustomerParty
        {
            get
            {
                if (__DeliveryCustomerParty == null) { __DeliveryCustomerParty = new CustomerPartyType(); }
                return __DeliveryCustomerParty;
            }
            set
            {
                __DeliveryCustomerParty = value;
            }
        }

        
        /// <summary>
        /// The supplier party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Despatch_ Supplier Party. Supplier Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTermQualifier: Despatch
        /// <para />PropertyTerm: Supplier Party
        /// <para />AssociatedObjectClass: Supplier Party
        /// <para />RepresentationTerm: Supplier Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public SupplierPartyType DespatchSupplierParty
        {
            get
            {
                if (__DespatchSupplierParty == null) { __DespatchSupplierParty = new SupplierPartyType(); }
                return __DespatchSupplierParty;
            }
            set
            {
                __DespatchSupplierParty = value;
            }
        }

        
        /// <summary>
        /// The buyer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Buyer_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTermQualifier: Buyer
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                if (__BuyerCustomerParty == null) { __BuyerCustomerParty = new CustomerPartyType(); }
                return __BuyerCustomerParty;
            }
            set
            {
                __BuyerCustomerParty = value;
            }
        }

        
        /// <summary>
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTermQualifier: Seller
        /// <para />PropertyTerm: Supplier Party
        /// <para />AssociatedObjectClass: Supplier Party
        /// <para />RepresentationTerm: Supplier Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
                return __SellerSupplierParty;
            }
            set
            {
                __SellerSupplierParty = value;
            }
        }

        
        /// <summary>
        /// Details about the Shipment.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Receipt Advice. Shipment
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Receipt Advice
        /// <para />PropertyTerm: Shipment
        /// <para />AssociatedObjectClass: Shipment
        /// <para />RepresentationTerm: Shipment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ShipmentType Shipment
        {
            get
            {
                if (__Shipment == null) { __Shipment = new ShipmentType(); }
                return __Shipment;
            }
            set
            {
                __Shipment = value;
            }
        }

    }
}
