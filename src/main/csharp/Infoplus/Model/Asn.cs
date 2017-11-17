using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infoplus.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Asn :  IEquatable<Asn>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Asn" /> class.
        /// Initializes a new instance of the <see cref="Asn" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="PoNo">PoNo (required).</param>
        /// <param name="VendorId">VendorId (required).</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="OrderDate">OrderDate (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="BillingName">BillingName.</param>
        /// <param name="BillingAttention">BillingAttention.</param>
        /// <param name="BillingStreet1">BillingStreet1.</param>
        /// <param name="BillingStreet2">BillingStreet2.</param>
        /// <param name="BillingCity">BillingCity.</param>
        /// <param name="BillingState">BillingState.</param>
        /// <param name="BillingZipCode">BillingZipCode.</param>
        /// <param name="BillingPhone">BillingPhone.</param>
        /// <param name="ShipToName">ShipToName.</param>
        /// <param name="ShipToAddress">ShipToAddress.</param>
        /// <param name="ShipToStreet1">ShipToStreet1.</param>
        /// <param name="ShipToStreet2">ShipToStreet2.</param>
        /// <param name="ShipToCity">ShipToCity.</param>
        /// <param name="ShipToState">ShipToState.</param>
        /// <param name="ShipToZipCode">ShipToZipCode.</param>
        /// <param name="ShipToPhone">ShipToPhone.</param>
        /// <param name="CorporateName">CorporateName.</param>
        /// <param name="CorporateAttention">CorporateAttention.</param>
        /// <param name="CorporateStreet1">CorporateStreet1.</param>
        /// <param name="CorporateStreet2">CorporateStreet2.</param>
        /// <param name="CorporateCity">CorporateCity.</param>
        /// <param name="CorporateState">CorporateState.</param>
        /// <param name="CorporateZipCode">CorporateZipCode.</param>
        /// <param name="AccountCode">AccountCode.</param>
        /// <param name="Buyer">Buyer.</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="ConfTo">ConfTo.</param>
        /// <param name="Fob">Fob.</param>
        /// <param name="ProjectNo">ProjectNo.</param>
        /// <param name="Remarks">Remarks.</param>
        /// <param name="RequestBy">RequestBy.</param>
        /// <param name="Terms">Terms.</param>
        /// <param name="UsedBy">UsedBy.</param>
        /// <param name="LineItems">LineItems.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Asn(int? LobId = null, string PoNo = null, int? VendorId = null, int? WarehouseId = null, DateTime? OrderDate = null, string Type = null, string BillingName = null, string BillingAttention = null, string BillingStreet1 = null, string BillingStreet2 = null, string BillingCity = null, string BillingState = null, string BillingZipCode = null, string BillingPhone = null, string ShipToName = null, string ShipToAddress = null, string ShipToStreet1 = null, string ShipToStreet2 = null, string ShipToCity = null, string ShipToState = null, string ShipToZipCode = null, string ShipToPhone = null, string CorporateName = null, string CorporateAttention = null, string CorporateStreet1 = null, string CorporateStreet2 = null, string CorporateCity = null, string CorporateState = null, string CorporateZipCode = null, string AccountCode = null, int? Buyer = null, int? Carrier = null, string ConfTo = null, string Fob = null, int? ProjectNo = null, string Remarks = null, string RequestBy = null, string Terms = null, string UsedBy = null, List<ItemReceipt> LineItems = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Asn and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "PoNo" is required (not null)
            if (PoNo == null)
            {
                throw new InvalidDataException("PoNo is a required property for Asn and cannot be null");
            }
            else
            {
                this.PoNo = PoNo;
            }
            // to ensure "VendorId" is required (not null)
            if (VendorId == null)
            {
                throw new InvalidDataException("VendorId is a required property for Asn and cannot be null");
            }
            else
            {
                this.VendorId = VendorId;
            }
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Asn and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "OrderDate" is required (not null)
            if (OrderDate == null)
            {
                throw new InvalidDataException("OrderDate is a required property for Asn and cannot be null");
            }
            else
            {
                this.OrderDate = OrderDate;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Asn and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.BillingName = BillingName;
            this.BillingAttention = BillingAttention;
            this.BillingStreet1 = BillingStreet1;
            this.BillingStreet2 = BillingStreet2;
            this.BillingCity = BillingCity;
            this.BillingState = BillingState;
            this.BillingZipCode = BillingZipCode;
            this.BillingPhone = BillingPhone;
            this.ShipToName = ShipToName;
            this.ShipToAddress = ShipToAddress;
            this.ShipToStreet1 = ShipToStreet1;
            this.ShipToStreet2 = ShipToStreet2;
            this.ShipToCity = ShipToCity;
            this.ShipToState = ShipToState;
            this.ShipToZipCode = ShipToZipCode;
            this.ShipToPhone = ShipToPhone;
            this.CorporateName = CorporateName;
            this.CorporateAttention = CorporateAttention;
            this.CorporateStreet1 = CorporateStreet1;
            this.CorporateStreet2 = CorporateStreet2;
            this.CorporateCity = CorporateCity;
            this.CorporateState = CorporateState;
            this.CorporateZipCode = CorporateZipCode;
            this.AccountCode = AccountCode;
            this.Buyer = Buyer;
            this.Carrier = Carrier;
            this.ConfTo = ConfTo;
            this.Fob = Fob;
            this.ProjectNo = ProjectNo;
            this.Remarks = Remarks;
            this.RequestBy = RequestBy;
            this.Terms = Terms;
            this.UsedBy = UsedBy;
            this.LineItems = LineItems;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets PoNo
        /// </summary>
        [DataMember(Name="poNo", EmitDefaultValue=false)]
        public string PoNo { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="orderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingName
        /// </summary>
        [DataMember(Name="billingName", EmitDefaultValue=false)]
        public string BillingName { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAttention
        /// </summary>
        [DataMember(Name="billingAttention", EmitDefaultValue=false)]
        public string BillingAttention { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingStreet1
        /// </summary>
        [DataMember(Name="billingStreet1", EmitDefaultValue=false)]
        public string BillingStreet1 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingStreet2
        /// </summary>
        [DataMember(Name="billingStreet2", EmitDefaultValue=false)]
        public string BillingStreet2 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingCity
        /// </summary>
        [DataMember(Name="billingCity", EmitDefaultValue=false)]
        public string BillingCity { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingState
        /// </summary>
        [DataMember(Name="billingState", EmitDefaultValue=false)]
        public string BillingState { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingZipCode
        /// </summary>
        [DataMember(Name="billingZipCode", EmitDefaultValue=false)]
        public string BillingZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingPhone
        /// </summary>
        [DataMember(Name="billingPhone", EmitDefaultValue=false)]
        public string BillingPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToName
        /// </summary>
        [DataMember(Name="shipToName", EmitDefaultValue=false)]
        public string ShipToName { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToAddress
        /// </summary>
        [DataMember(Name="shipToAddress", EmitDefaultValue=false)]
        public string ShipToAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToStreet1
        /// </summary>
        [DataMember(Name="shipToStreet1", EmitDefaultValue=false)]
        public string ShipToStreet1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToStreet2
        /// </summary>
        [DataMember(Name="shipToStreet2", EmitDefaultValue=false)]
        public string ShipToStreet2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToCity
        /// </summary>
        [DataMember(Name="shipToCity", EmitDefaultValue=false)]
        public string ShipToCity { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToState
        /// </summary>
        [DataMember(Name="shipToState", EmitDefaultValue=false)]
        public string ShipToState { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToZipCode
        /// </summary>
        [DataMember(Name="shipToZipCode", EmitDefaultValue=false)]
        public string ShipToZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToPhone
        /// </summary>
        [DataMember(Name="shipToPhone", EmitDefaultValue=false)]
        public string ShipToPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets CorporateName
        /// </summary>
        [DataMember(Name="corporateName", EmitDefaultValue=false)]
        public string CorporateName { get; set; }
    
        /// <summary>
        /// Gets or Sets CorporateAttention
        /// </summary>
        [DataMember(Name="corporateAttention", EmitDefaultValue=false)]
        public string CorporateAttention { get; set; }
    
        /// <summary>
        /// Gets or Sets CorporateStreet1
        /// </summary>
        [DataMember(Name="corporateStreet1", EmitDefaultValue=false)]
        public string CorporateStreet1 { get; set; }
    
        /// <summary>
        /// Gets or Sets CorporateStreet2
        /// </summary>
        [DataMember(Name="corporateStreet2", EmitDefaultValue=false)]
        public string CorporateStreet2 { get; set; }
    
        /// <summary>
        /// Gets or Sets CorporateCity
        /// </summary>
        [DataMember(Name="corporateCity", EmitDefaultValue=false)]
        public string CorporateCity { get; set; }
    
        /// <summary>
        /// Gets or Sets CorporateState
        /// </summary>
        [DataMember(Name="corporateState", EmitDefaultValue=false)]
        public string CorporateState { get; set; }
    
        /// <summary>
        /// Gets or Sets CorporateZipCode
        /// </summary>
        [DataMember(Name="corporateZipCode", EmitDefaultValue=false)]
        public string CorporateZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountCode
        /// </summary>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Buyer
        /// </summary>
        [DataMember(Name="buyer", EmitDefaultValue=false)]
        public int? Buyer { get; set; }
    
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public int? Carrier { get; set; }
    
        /// <summary>
        /// Gets or Sets ConfTo
        /// </summary>
        [DataMember(Name="confTo", EmitDefaultValue=false)]
        public string ConfTo { get; set; }
    
        /// <summary>
        /// Gets or Sets Fob
        /// </summary>
        [DataMember(Name="fob", EmitDefaultValue=false)]
        public string Fob { get; set; }
    
        /// <summary>
        /// Gets or Sets Printed
        /// </summary>
        [DataMember(Name="printed", EmitDefaultValue=false)]
        public string Printed { get; private set; }
    
        /// <summary>
        /// Gets or Sets ProjectNo
        /// </summary>
        [DataMember(Name="projectNo", EmitDefaultValue=false)]
        public int? ProjectNo { get; set; }
    
        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }
    
        /// <summary>
        /// Gets or Sets RequestBy
        /// </summary>
        [DataMember(Name="requestBy", EmitDefaultValue=false)]
        public string RequestBy { get; set; }
    
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public string Terms { get; set; }
    
        /// <summary>
        /// Gets or Sets UsedBy
        /// </summary>
        [DataMember(Name="usedBy", EmitDefaultValue=false)]
        public string UsedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<ItemReceipt> LineItems { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asn {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  PoNo: ").Append(PoNo).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BillingName: ").Append(BillingName).Append("\n");
            sb.Append("  BillingAttention: ").Append(BillingAttention).Append("\n");
            sb.Append("  BillingStreet1: ").Append(BillingStreet1).Append("\n");
            sb.Append("  BillingStreet2: ").Append(BillingStreet2).Append("\n");
            sb.Append("  BillingCity: ").Append(BillingCity).Append("\n");
            sb.Append("  BillingState: ").Append(BillingState).Append("\n");
            sb.Append("  BillingZipCode: ").Append(BillingZipCode).Append("\n");
            sb.Append("  BillingPhone: ").Append(BillingPhone).Append("\n");
            sb.Append("  ShipToName: ").Append(ShipToName).Append("\n");
            sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
            sb.Append("  ShipToStreet1: ").Append(ShipToStreet1).Append("\n");
            sb.Append("  ShipToStreet2: ").Append(ShipToStreet2).Append("\n");
            sb.Append("  ShipToCity: ").Append(ShipToCity).Append("\n");
            sb.Append("  ShipToState: ").Append(ShipToState).Append("\n");
            sb.Append("  ShipToZipCode: ").Append(ShipToZipCode).Append("\n");
            sb.Append("  ShipToPhone: ").Append(ShipToPhone).Append("\n");
            sb.Append("  CorporateName: ").Append(CorporateName).Append("\n");
            sb.Append("  CorporateAttention: ").Append(CorporateAttention).Append("\n");
            sb.Append("  CorporateStreet1: ").Append(CorporateStreet1).Append("\n");
            sb.Append("  CorporateStreet2: ").Append(CorporateStreet2).Append("\n");
            sb.Append("  CorporateCity: ").Append(CorporateCity).Append("\n");
            sb.Append("  CorporateState: ").Append(CorporateState).Append("\n");
            sb.Append("  CorporateZipCode: ").Append(CorporateZipCode).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Buyer: ").Append(Buyer).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  ConfTo: ").Append(ConfTo).Append("\n");
            sb.Append("  Fob: ").Append(Fob).Append("\n");
            sb.Append("  Printed: ").Append(Printed).Append("\n");
            sb.Append("  ProjectNo: ").Append(ProjectNo).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  RequestBy: ").Append(RequestBy).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  UsedBy: ").Append(UsedBy).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Asn);
        }

        /// <summary>
        /// Returns true if Asn instances are equal
        /// </summary>
        /// <param name="other">Instance of Asn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.PoNo == other.PoNo ||
                    this.PoNo != null &&
                    this.PoNo.Equals(other.PoNo)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.OrderDate == other.OrderDate ||
                    this.OrderDate != null &&
                    this.OrderDate.Equals(other.OrderDate)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.BillingName == other.BillingName ||
                    this.BillingName != null &&
                    this.BillingName.Equals(other.BillingName)
                ) && 
                (
                    this.BillingAttention == other.BillingAttention ||
                    this.BillingAttention != null &&
                    this.BillingAttention.Equals(other.BillingAttention)
                ) && 
                (
                    this.BillingStreet1 == other.BillingStreet1 ||
                    this.BillingStreet1 != null &&
                    this.BillingStreet1.Equals(other.BillingStreet1)
                ) && 
                (
                    this.BillingStreet2 == other.BillingStreet2 ||
                    this.BillingStreet2 != null &&
                    this.BillingStreet2.Equals(other.BillingStreet2)
                ) && 
                (
                    this.BillingCity == other.BillingCity ||
                    this.BillingCity != null &&
                    this.BillingCity.Equals(other.BillingCity)
                ) && 
                (
                    this.BillingState == other.BillingState ||
                    this.BillingState != null &&
                    this.BillingState.Equals(other.BillingState)
                ) && 
                (
                    this.BillingZipCode == other.BillingZipCode ||
                    this.BillingZipCode != null &&
                    this.BillingZipCode.Equals(other.BillingZipCode)
                ) && 
                (
                    this.BillingPhone == other.BillingPhone ||
                    this.BillingPhone != null &&
                    this.BillingPhone.Equals(other.BillingPhone)
                ) && 
                (
                    this.ShipToName == other.ShipToName ||
                    this.ShipToName != null &&
                    this.ShipToName.Equals(other.ShipToName)
                ) && 
                (
                    this.ShipToAddress == other.ShipToAddress ||
                    this.ShipToAddress != null &&
                    this.ShipToAddress.Equals(other.ShipToAddress)
                ) && 
                (
                    this.ShipToStreet1 == other.ShipToStreet1 ||
                    this.ShipToStreet1 != null &&
                    this.ShipToStreet1.Equals(other.ShipToStreet1)
                ) && 
                (
                    this.ShipToStreet2 == other.ShipToStreet2 ||
                    this.ShipToStreet2 != null &&
                    this.ShipToStreet2.Equals(other.ShipToStreet2)
                ) && 
                (
                    this.ShipToCity == other.ShipToCity ||
                    this.ShipToCity != null &&
                    this.ShipToCity.Equals(other.ShipToCity)
                ) && 
                (
                    this.ShipToState == other.ShipToState ||
                    this.ShipToState != null &&
                    this.ShipToState.Equals(other.ShipToState)
                ) && 
                (
                    this.ShipToZipCode == other.ShipToZipCode ||
                    this.ShipToZipCode != null &&
                    this.ShipToZipCode.Equals(other.ShipToZipCode)
                ) && 
                (
                    this.ShipToPhone == other.ShipToPhone ||
                    this.ShipToPhone != null &&
                    this.ShipToPhone.Equals(other.ShipToPhone)
                ) && 
                (
                    this.CorporateName == other.CorporateName ||
                    this.CorporateName != null &&
                    this.CorporateName.Equals(other.CorporateName)
                ) && 
                (
                    this.CorporateAttention == other.CorporateAttention ||
                    this.CorporateAttention != null &&
                    this.CorporateAttention.Equals(other.CorporateAttention)
                ) && 
                (
                    this.CorporateStreet1 == other.CorporateStreet1 ||
                    this.CorporateStreet1 != null &&
                    this.CorporateStreet1.Equals(other.CorporateStreet1)
                ) && 
                (
                    this.CorporateStreet2 == other.CorporateStreet2 ||
                    this.CorporateStreet2 != null &&
                    this.CorporateStreet2.Equals(other.CorporateStreet2)
                ) && 
                (
                    this.CorporateCity == other.CorporateCity ||
                    this.CorporateCity != null &&
                    this.CorporateCity.Equals(other.CorporateCity)
                ) && 
                (
                    this.CorporateState == other.CorporateState ||
                    this.CorporateState != null &&
                    this.CorporateState.Equals(other.CorporateState)
                ) && 
                (
                    this.CorporateZipCode == other.CorporateZipCode ||
                    this.CorporateZipCode != null &&
                    this.CorporateZipCode.Equals(other.CorporateZipCode)
                ) && 
                (
                    this.AccountCode == other.AccountCode ||
                    this.AccountCode != null &&
                    this.AccountCode.Equals(other.AccountCode)
                ) && 
                (
                    this.Buyer == other.Buyer ||
                    this.Buyer != null &&
                    this.Buyer.Equals(other.Buyer)
                ) && 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.ConfTo == other.ConfTo ||
                    this.ConfTo != null &&
                    this.ConfTo.Equals(other.ConfTo)
                ) && 
                (
                    this.Fob == other.Fob ||
                    this.Fob != null &&
                    this.Fob.Equals(other.Fob)
                ) && 
                (
                    this.Printed == other.Printed ||
                    this.Printed != null &&
                    this.Printed.Equals(other.Printed)
                ) && 
                (
                    this.ProjectNo == other.ProjectNo ||
                    this.ProjectNo != null &&
                    this.ProjectNo.Equals(other.ProjectNo)
                ) && 
                (
                    this.Remarks == other.Remarks ||
                    this.Remarks != null &&
                    this.Remarks.Equals(other.Remarks)
                ) && 
                (
                    this.RequestBy == other.RequestBy ||
                    this.RequestBy != null &&
                    this.RequestBy.Equals(other.RequestBy)
                ) && 
                (
                    this.Terms == other.Terms ||
                    this.Terms != null &&
                    this.Terms.Equals(other.Terms)
                ) && 
                (
                    this.UsedBy == other.UsedBy ||
                    this.UsedBy != null &&
                    this.UsedBy.Equals(other.UsedBy)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.PoNo != null)
                    hash = hash * 59 + this.PoNo.GetHashCode();
                
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.OrderDate != null)
                    hash = hash * 59 + this.OrderDate.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.BillingName != null)
                    hash = hash * 59 + this.BillingName.GetHashCode();
                
                if (this.BillingAttention != null)
                    hash = hash * 59 + this.BillingAttention.GetHashCode();
                
                if (this.BillingStreet1 != null)
                    hash = hash * 59 + this.BillingStreet1.GetHashCode();
                
                if (this.BillingStreet2 != null)
                    hash = hash * 59 + this.BillingStreet2.GetHashCode();
                
                if (this.BillingCity != null)
                    hash = hash * 59 + this.BillingCity.GetHashCode();
                
                if (this.BillingState != null)
                    hash = hash * 59 + this.BillingState.GetHashCode();
                
                if (this.BillingZipCode != null)
                    hash = hash * 59 + this.BillingZipCode.GetHashCode();
                
                if (this.BillingPhone != null)
                    hash = hash * 59 + this.BillingPhone.GetHashCode();
                
                if (this.ShipToName != null)
                    hash = hash * 59 + this.ShipToName.GetHashCode();
                
                if (this.ShipToAddress != null)
                    hash = hash * 59 + this.ShipToAddress.GetHashCode();
                
                if (this.ShipToStreet1 != null)
                    hash = hash * 59 + this.ShipToStreet1.GetHashCode();
                
                if (this.ShipToStreet2 != null)
                    hash = hash * 59 + this.ShipToStreet2.GetHashCode();
                
                if (this.ShipToCity != null)
                    hash = hash * 59 + this.ShipToCity.GetHashCode();
                
                if (this.ShipToState != null)
                    hash = hash * 59 + this.ShipToState.GetHashCode();
                
                if (this.ShipToZipCode != null)
                    hash = hash * 59 + this.ShipToZipCode.GetHashCode();
                
                if (this.ShipToPhone != null)
                    hash = hash * 59 + this.ShipToPhone.GetHashCode();
                
                if (this.CorporateName != null)
                    hash = hash * 59 + this.CorporateName.GetHashCode();
                
                if (this.CorporateAttention != null)
                    hash = hash * 59 + this.CorporateAttention.GetHashCode();
                
                if (this.CorporateStreet1 != null)
                    hash = hash * 59 + this.CorporateStreet1.GetHashCode();
                
                if (this.CorporateStreet2 != null)
                    hash = hash * 59 + this.CorporateStreet2.GetHashCode();
                
                if (this.CorporateCity != null)
                    hash = hash * 59 + this.CorporateCity.GetHashCode();
                
                if (this.CorporateState != null)
                    hash = hash * 59 + this.CorporateState.GetHashCode();
                
                if (this.CorporateZipCode != null)
                    hash = hash * 59 + this.CorporateZipCode.GetHashCode();
                
                if (this.AccountCode != null)
                    hash = hash * 59 + this.AccountCode.GetHashCode();
                
                if (this.Buyer != null)
                    hash = hash * 59 + this.Buyer.GetHashCode();
                
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                
                if (this.ConfTo != null)
                    hash = hash * 59 + this.ConfTo.GetHashCode();
                
                if (this.Fob != null)
                    hash = hash * 59 + this.Fob.GetHashCode();
                
                if (this.Printed != null)
                    hash = hash * 59 + this.Printed.GetHashCode();
                
                if (this.ProjectNo != null)
                    hash = hash * 59 + this.ProjectNo.GetHashCode();
                
                if (this.Remarks != null)
                    hash = hash * 59 + this.Remarks.GetHashCode();
                
                if (this.RequestBy != null)
                    hash = hash * 59 + this.RequestBy.GetHashCode();
                
                if (this.Terms != null)
                    hash = hash * 59 + this.Terms.GetHashCode();
                
                if (this.UsedBy != null)
                    hash = hash * 59 + this.UsedBy.GetHashCode();
                
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
