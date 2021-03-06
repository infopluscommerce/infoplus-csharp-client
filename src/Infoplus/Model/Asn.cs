/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Infoplus.Client.SwaggerDateConverter;

namespace Infoplus.Model
{
    /// <summary>
    /// Asn
    /// </summary>
    [DataContract]
    public partial class Asn :  IEquatable<Asn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Asn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Asn" /> class.
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
        public Asn(int? LobId = default(int?), string PoNo = default(string), int? VendorId = default(int?), int? WarehouseId = default(int?), DateTime? OrderDate = default(DateTime?), string Type = default(string), string BillingName = default(string), string BillingAttention = default(string), string BillingStreet1 = default(string), string BillingStreet2 = default(string), string BillingCity = default(string), string BillingState = default(string), string BillingZipCode = default(string), string BillingPhone = default(string), string ShipToName = default(string), string ShipToAddress = default(string), string ShipToStreet1 = default(string), string ShipToStreet2 = default(string), string ShipToCity = default(string), string ShipToState = default(string), string ShipToZipCode = default(string), string ShipToPhone = default(string), string CorporateName = default(string), string CorporateAttention = default(string), string CorporateStreet1 = default(string), string CorporateStreet2 = default(string), string CorporateCity = default(string), string CorporateState = default(string), string CorporateZipCode = default(string), string AccountCode = default(string), int? Buyer = default(int?), int? Carrier = default(int?), string ConfTo = default(string), string Fob = default(string), int? ProjectNo = default(int?), string Remarks = default(string), string RequestBy = default(string), string Terms = default(string), string UsedBy = default(string), List<ItemReceipt> LineItems = default(List<ItemReceipt>), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
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
        /// Gets or Sets TransferOrderId
        /// </summary>
        [DataMember(Name="transferOrderId", EmitDefaultValue=false)]
        public decimal? TransferOrderId { get; private set; }

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
            sb.Append("  TransferOrderId: ").Append(TransferOrderId).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Asn);
        }

        /// <summary>
        /// Returns true if Asn instances are equal
        /// </summary>
        /// <param name="input">Instance of Asn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.PoNo == input.PoNo ||
                    (this.PoNo != null &&
                    this.PoNo.Equals(input.PoNo))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BillingName == input.BillingName ||
                    (this.BillingName != null &&
                    this.BillingName.Equals(input.BillingName))
                ) && 
                (
                    this.BillingAttention == input.BillingAttention ||
                    (this.BillingAttention != null &&
                    this.BillingAttention.Equals(input.BillingAttention))
                ) && 
                (
                    this.BillingStreet1 == input.BillingStreet1 ||
                    (this.BillingStreet1 != null &&
                    this.BillingStreet1.Equals(input.BillingStreet1))
                ) && 
                (
                    this.BillingStreet2 == input.BillingStreet2 ||
                    (this.BillingStreet2 != null &&
                    this.BillingStreet2.Equals(input.BillingStreet2))
                ) && 
                (
                    this.BillingCity == input.BillingCity ||
                    (this.BillingCity != null &&
                    this.BillingCity.Equals(input.BillingCity))
                ) && 
                (
                    this.BillingState == input.BillingState ||
                    (this.BillingState != null &&
                    this.BillingState.Equals(input.BillingState))
                ) && 
                (
                    this.BillingZipCode == input.BillingZipCode ||
                    (this.BillingZipCode != null &&
                    this.BillingZipCode.Equals(input.BillingZipCode))
                ) && 
                (
                    this.BillingPhone == input.BillingPhone ||
                    (this.BillingPhone != null &&
                    this.BillingPhone.Equals(input.BillingPhone))
                ) && 
                (
                    this.ShipToName == input.ShipToName ||
                    (this.ShipToName != null &&
                    this.ShipToName.Equals(input.ShipToName))
                ) && 
                (
                    this.ShipToAddress == input.ShipToAddress ||
                    (this.ShipToAddress != null &&
                    this.ShipToAddress.Equals(input.ShipToAddress))
                ) && 
                (
                    this.ShipToStreet1 == input.ShipToStreet1 ||
                    (this.ShipToStreet1 != null &&
                    this.ShipToStreet1.Equals(input.ShipToStreet1))
                ) && 
                (
                    this.ShipToStreet2 == input.ShipToStreet2 ||
                    (this.ShipToStreet2 != null &&
                    this.ShipToStreet2.Equals(input.ShipToStreet2))
                ) && 
                (
                    this.ShipToCity == input.ShipToCity ||
                    (this.ShipToCity != null &&
                    this.ShipToCity.Equals(input.ShipToCity))
                ) && 
                (
                    this.ShipToState == input.ShipToState ||
                    (this.ShipToState != null &&
                    this.ShipToState.Equals(input.ShipToState))
                ) && 
                (
                    this.ShipToZipCode == input.ShipToZipCode ||
                    (this.ShipToZipCode != null &&
                    this.ShipToZipCode.Equals(input.ShipToZipCode))
                ) && 
                (
                    this.ShipToPhone == input.ShipToPhone ||
                    (this.ShipToPhone != null &&
                    this.ShipToPhone.Equals(input.ShipToPhone))
                ) && 
                (
                    this.CorporateName == input.CorporateName ||
                    (this.CorporateName != null &&
                    this.CorporateName.Equals(input.CorporateName))
                ) && 
                (
                    this.CorporateAttention == input.CorporateAttention ||
                    (this.CorporateAttention != null &&
                    this.CorporateAttention.Equals(input.CorporateAttention))
                ) && 
                (
                    this.CorporateStreet1 == input.CorporateStreet1 ||
                    (this.CorporateStreet1 != null &&
                    this.CorporateStreet1.Equals(input.CorporateStreet1))
                ) && 
                (
                    this.CorporateStreet2 == input.CorporateStreet2 ||
                    (this.CorporateStreet2 != null &&
                    this.CorporateStreet2.Equals(input.CorporateStreet2))
                ) && 
                (
                    this.CorporateCity == input.CorporateCity ||
                    (this.CorporateCity != null &&
                    this.CorporateCity.Equals(input.CorporateCity))
                ) && 
                (
                    this.CorporateState == input.CorporateState ||
                    (this.CorporateState != null &&
                    this.CorporateState.Equals(input.CorporateState))
                ) && 
                (
                    this.CorporateZipCode == input.CorporateZipCode ||
                    (this.CorporateZipCode != null &&
                    this.CorporateZipCode.Equals(input.CorporateZipCode))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.Buyer == input.Buyer ||
                    (this.Buyer != null &&
                    this.Buyer.Equals(input.Buyer))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.ConfTo == input.ConfTo ||
                    (this.ConfTo != null &&
                    this.ConfTo.Equals(input.ConfTo))
                ) && 
                (
                    this.Fob == input.Fob ||
                    (this.Fob != null &&
                    this.Fob.Equals(input.Fob))
                ) && 
                (
                    this.Printed == input.Printed ||
                    (this.Printed != null &&
                    this.Printed.Equals(input.Printed))
                ) && 
                (
                    this.ProjectNo == input.ProjectNo ||
                    (this.ProjectNo != null &&
                    this.ProjectNo.Equals(input.ProjectNo))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.RequestBy == input.RequestBy ||
                    (this.RequestBy != null &&
                    this.RequestBy.Equals(input.RequestBy))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && 
                (
                    this.UsedBy == input.UsedBy ||
                    (this.UsedBy != null &&
                    this.UsedBy.Equals(input.UsedBy))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TransferOrderId == input.TransferOrderId ||
                    (this.TransferOrderId != null &&
                    this.TransferOrderId.Equals(input.TransferOrderId))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.PoNo != null)
                    hashCode = hashCode * 59 + this.PoNo.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.OrderDate != null)
                    hashCode = hashCode * 59 + this.OrderDate.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BillingName != null)
                    hashCode = hashCode * 59 + this.BillingName.GetHashCode();
                if (this.BillingAttention != null)
                    hashCode = hashCode * 59 + this.BillingAttention.GetHashCode();
                if (this.BillingStreet1 != null)
                    hashCode = hashCode * 59 + this.BillingStreet1.GetHashCode();
                if (this.BillingStreet2 != null)
                    hashCode = hashCode * 59 + this.BillingStreet2.GetHashCode();
                if (this.BillingCity != null)
                    hashCode = hashCode * 59 + this.BillingCity.GetHashCode();
                if (this.BillingState != null)
                    hashCode = hashCode * 59 + this.BillingState.GetHashCode();
                if (this.BillingZipCode != null)
                    hashCode = hashCode * 59 + this.BillingZipCode.GetHashCode();
                if (this.BillingPhone != null)
                    hashCode = hashCode * 59 + this.BillingPhone.GetHashCode();
                if (this.ShipToName != null)
                    hashCode = hashCode * 59 + this.ShipToName.GetHashCode();
                if (this.ShipToAddress != null)
                    hashCode = hashCode * 59 + this.ShipToAddress.GetHashCode();
                if (this.ShipToStreet1 != null)
                    hashCode = hashCode * 59 + this.ShipToStreet1.GetHashCode();
                if (this.ShipToStreet2 != null)
                    hashCode = hashCode * 59 + this.ShipToStreet2.GetHashCode();
                if (this.ShipToCity != null)
                    hashCode = hashCode * 59 + this.ShipToCity.GetHashCode();
                if (this.ShipToState != null)
                    hashCode = hashCode * 59 + this.ShipToState.GetHashCode();
                if (this.ShipToZipCode != null)
                    hashCode = hashCode * 59 + this.ShipToZipCode.GetHashCode();
                if (this.ShipToPhone != null)
                    hashCode = hashCode * 59 + this.ShipToPhone.GetHashCode();
                if (this.CorporateName != null)
                    hashCode = hashCode * 59 + this.CorporateName.GetHashCode();
                if (this.CorporateAttention != null)
                    hashCode = hashCode * 59 + this.CorporateAttention.GetHashCode();
                if (this.CorporateStreet1 != null)
                    hashCode = hashCode * 59 + this.CorporateStreet1.GetHashCode();
                if (this.CorporateStreet2 != null)
                    hashCode = hashCode * 59 + this.CorporateStreet2.GetHashCode();
                if (this.CorporateCity != null)
                    hashCode = hashCode * 59 + this.CorporateCity.GetHashCode();
                if (this.CorporateState != null)
                    hashCode = hashCode * 59 + this.CorporateState.GetHashCode();
                if (this.CorporateZipCode != null)
                    hashCode = hashCode * 59 + this.CorporateZipCode.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.Buyer != null)
                    hashCode = hashCode * 59 + this.Buyer.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.ConfTo != null)
                    hashCode = hashCode * 59 + this.ConfTo.GetHashCode();
                if (this.Fob != null)
                    hashCode = hashCode * 59 + this.Fob.GetHashCode();
                if (this.Printed != null)
                    hashCode = hashCode * 59 + this.Printed.GetHashCode();
                if (this.ProjectNo != null)
                    hashCode = hashCode * 59 + this.ProjectNo.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.RequestBy != null)
                    hashCode = hashCode * 59 + this.RequestBy.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this.UsedBy != null)
                    hashCode = hashCode * 59 + this.UsedBy.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TransferOrderId != null)
                    hashCode = hashCode * 59 + this.TransferOrderId.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
