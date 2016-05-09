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
    public partial class Vendor :  IEquatable<Vendor>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Vendor" /> class.
        /// Initializes a new instance of the <see cref="Vendor" />class.
        /// </summary>
        /// <param name="VendorNo">VendorNo (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Street">Street (required).</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State (required).</param>
        /// <param name="Country">Country.</param>
        /// <param name="ZipCode">ZipCode (required).</param>
        /// <param name="Contact">Contact.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Fax">Fax.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="Terms">Terms.</param>
        /// <param name="Fob">Fob.</param>
        /// <param name="ShipVia">ShipVia.</param>
        /// <param name="RequestDays">RequestDays.</param>
        /// <param name="ActualDays">ActualDays.</param>
        /// <param name="SalesTaxCode">SalesTaxCode.</param>
        /// <param name="Product1">Product1.</param>
        /// <param name="Product2">Product2.</param>
        /// <param name="Product3">Product3.</param>
        /// <param name="Product4">Product4.</param>
        /// <param name="Product5">Product5.</param>
        /// <param name="Product6">Product6.</param>
        /// <param name="Product7">Product7.</param>
        /// <param name="Product8">Product8.</param>
        /// <param name="Product9">Product9.</param>
        /// <param name="PodDays">PodDays.</param>
        /// <param name="ChargeOut">ChargeOut.</param>
        /// <param name="ArEmail">ArEmail.</param>
        /// <param name="OrderEmail">OrderEmail.</param>
        /// <param name="OrderAttach">OrderAttach.</param>
        /// <param name="SendQuantityType">SendQuantityType.</param>
        /// <param name="Minority">Minority.</param>
        /// <param name="SendOutside">SendOutside.</param>
        /// <param name="PodOrderSuffix">PodOrderSuffix.</param>
        /// <param name="PodEmail">PodEmail.</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="Inactive">Inactive (required).</param>

        public Vendor(int? VendorNo = null, int? LobId = null, string Name = null, string Street = null, string Street2 = null, string City = null, string State = null, string Country = null, string ZipCode = null, string Contact = null, string Phone = null, string Fax = null, string ExternalId = null, string Terms = null, string Fob = null, int? ShipVia = null, int? RequestDays = null, int? ActualDays = null, string SalesTaxCode = null, int? Product1 = null, int? Product2 = null, int? Product3 = null, int? Product4 = null, int? Product5 = null, int? Product6 = null, int? Product7 = null, int? Product8 = null, int? Product9 = null, int? PodDays = null, string ChargeOut = null, string ArEmail = null, string OrderEmail = null, string OrderAttach = null, string SendQuantityType = null, string Minority = null, string SendOutside = null, int? PodOrderSuffix = null, string PodEmail = null, DateTime? CreateDate = null, DateTime? ModifyDate = null, string Inactive = null)
        {
            // to ensure "VendorNo" is required (not null)
            if (VendorNo == null)
            {
                throw new InvalidDataException("VendorNo is a required property for Vendor and cannot be null");
            }
            else
            {
                this.VendorNo = VendorNo;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Vendor and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Vendor and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for Vendor and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for Vendor and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for Vendor and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "ZipCode" is required (not null)
            if (ZipCode == null)
            {
                throw new InvalidDataException("ZipCode is a required property for Vendor and cannot be null");
            }
            else
            {
                this.ZipCode = ZipCode;
            }
            // to ensure "Inactive" is required (not null)
            if (Inactive == null)
            {
                throw new InvalidDataException("Inactive is a required property for Vendor and cannot be null");
            }
            else
            {
                this.Inactive = Inactive;
            }
            this.Street2 = Street2;
            this.Country = Country;
            this.Contact = Contact;
            this.Phone = Phone;
            this.Fax = Fax;
            this.ExternalId = ExternalId;
            this.Terms = Terms;
            this.Fob = Fob;
            this.ShipVia = ShipVia;
            this.RequestDays = RequestDays;
            this.ActualDays = ActualDays;
            this.SalesTaxCode = SalesTaxCode;
            this.Product1 = Product1;
            this.Product2 = Product2;
            this.Product3 = Product3;
            this.Product4 = Product4;
            this.Product5 = Product5;
            this.Product6 = Product6;
            this.Product7 = Product7;
            this.Product8 = Product8;
            this.Product9 = Product9;
            this.PodDays = PodDays;
            this.ChargeOut = ChargeOut;
            this.ArEmail = ArEmail;
            this.OrderEmail = OrderEmail;
            this.OrderAttach = OrderAttach;
            this.SendQuantityType = SendQuantityType;
            this.Minority = Minority;
            this.SendOutside = SendOutside;
            this.PodOrderSuffix = PodOrderSuffix;
            this.PodEmail = PodEmail;
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets VendorNo
        /// </summary>
        [DataMember(Name="vendorNo", EmitDefaultValue=false)]
        public int? VendorNo { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
    
        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="zipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
    
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public string Terms { get; set; }
    
        /// <summary>
        /// Gets or Sets Fob
        /// </summary>
        [DataMember(Name="fob", EmitDefaultValue=false)]
        public string Fob { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipVia
        /// </summary>
        [DataMember(Name="shipVia", EmitDefaultValue=false)]
        public int? ShipVia { get; set; }
    
        /// <summary>
        /// Gets or Sets RequestDays
        /// </summary>
        [DataMember(Name="requestDays", EmitDefaultValue=false)]
        public int? RequestDays { get; set; }
    
        /// <summary>
        /// Gets or Sets ActualDays
        /// </summary>
        [DataMember(Name="actualDays", EmitDefaultValue=false)]
        public int? ActualDays { get; set; }
    
        /// <summary>
        /// Gets or Sets SalesTaxCode
        /// </summary>
        [DataMember(Name="salesTaxCode", EmitDefaultValue=false)]
        public string SalesTaxCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Product1
        /// </summary>
        [DataMember(Name="product1", EmitDefaultValue=false)]
        public int? Product1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product2
        /// </summary>
        [DataMember(Name="product2", EmitDefaultValue=false)]
        public int? Product2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product3
        /// </summary>
        [DataMember(Name="product3", EmitDefaultValue=false)]
        public int? Product3 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product4
        /// </summary>
        [DataMember(Name="product4", EmitDefaultValue=false)]
        public int? Product4 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product5
        /// </summary>
        [DataMember(Name="product5", EmitDefaultValue=false)]
        public int? Product5 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product6
        /// </summary>
        [DataMember(Name="product6", EmitDefaultValue=false)]
        public int? Product6 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product7
        /// </summary>
        [DataMember(Name="product7", EmitDefaultValue=false)]
        public int? Product7 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product8
        /// </summary>
        [DataMember(Name="product8", EmitDefaultValue=false)]
        public int? Product8 { get; set; }
    
        /// <summary>
        /// Gets or Sets Product9
        /// </summary>
        [DataMember(Name="product9", EmitDefaultValue=false)]
        public int? Product9 { get; set; }
    
        /// <summary>
        /// Gets or Sets PodDays
        /// </summary>
        [DataMember(Name="podDays", EmitDefaultValue=false)]
        public int? PodDays { get; set; }
    
        /// <summary>
        /// Gets or Sets ChargeOut
        /// </summary>
        [DataMember(Name="chargeOut", EmitDefaultValue=false)]
        public string ChargeOut { get; set; }
    
        /// <summary>
        /// Gets or Sets ArEmail
        /// </summary>
        [DataMember(Name="arEmail", EmitDefaultValue=false)]
        public string ArEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderEmail
        /// </summary>
        [DataMember(Name="orderEmail", EmitDefaultValue=false)]
        public string OrderEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderAttach
        /// </summary>
        [DataMember(Name="orderAttach", EmitDefaultValue=false)]
        public string OrderAttach { get; set; }
    
        /// <summary>
        /// Gets or Sets SendQuantityType
        /// </summary>
        [DataMember(Name="sendQuantityType", EmitDefaultValue=false)]
        public string SendQuantityType { get; set; }
    
        /// <summary>
        /// Gets or Sets Minority
        /// </summary>
        [DataMember(Name="minority", EmitDefaultValue=false)]
        public string Minority { get; set; }
    
        /// <summary>
        /// Gets or Sets SendOutside
        /// </summary>
        [DataMember(Name="sendOutside", EmitDefaultValue=false)]
        public string SendOutside { get; set; }
    
        /// <summary>
        /// Gets or Sets PodOrderSuffix
        /// </summary>
        [DataMember(Name="podOrderSuffix", EmitDefaultValue=false)]
        public int? PodOrderSuffix { get; set; }
    
        /// <summary>
        /// Gets or Sets PodEmail
        /// </summary>
        [DataMember(Name="podEmail", EmitDefaultValue=false)]
        public string PodEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Inactive
        /// </summary>
        [DataMember(Name="inactive", EmitDefaultValue=false)]
        public string Inactive { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vendor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VendorNo: ").Append(VendorNo).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Fob: ").Append(Fob).Append("\n");
            sb.Append("  ShipVia: ").Append(ShipVia).Append("\n");
            sb.Append("  RequestDays: ").Append(RequestDays).Append("\n");
            sb.Append("  ActualDays: ").Append(ActualDays).Append("\n");
            sb.Append("  SalesTaxCode: ").Append(SalesTaxCode).Append("\n");
            sb.Append("  Product1: ").Append(Product1).Append("\n");
            sb.Append("  Product2: ").Append(Product2).Append("\n");
            sb.Append("  Product3: ").Append(Product3).Append("\n");
            sb.Append("  Product4: ").Append(Product4).Append("\n");
            sb.Append("  Product5: ").Append(Product5).Append("\n");
            sb.Append("  Product6: ").Append(Product6).Append("\n");
            sb.Append("  Product7: ").Append(Product7).Append("\n");
            sb.Append("  Product8: ").Append(Product8).Append("\n");
            sb.Append("  Product9: ").Append(Product9).Append("\n");
            sb.Append("  PodDays: ").Append(PodDays).Append("\n");
            sb.Append("  ChargeOut: ").Append(ChargeOut).Append("\n");
            sb.Append("  ArEmail: ").Append(ArEmail).Append("\n");
            sb.Append("  OrderEmail: ").Append(OrderEmail).Append("\n");
            sb.Append("  OrderAttach: ").Append(OrderAttach).Append("\n");
            sb.Append("  SendQuantityType: ").Append(SendQuantityType).Append("\n");
            sb.Append("  Minority: ").Append(Minority).Append("\n");
            sb.Append("  SendOutside: ").Append(SendOutside).Append("\n");
            sb.Append("  PodOrderSuffix: ").Append(PodOrderSuffix).Append("\n");
            sb.Append("  PodEmail: ").Append(PodEmail).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
            
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
            return this.Equals(obj as Vendor);
        }

        /// <summary>
        /// Returns true if Vendor instances are equal
        /// </summary>
        /// <param name="other">Instance of Vendor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vendor other)
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
                    this.VendorNo == other.VendorNo ||
                    this.VendorNo != null &&
                    this.VendorNo.Equals(other.VendorNo)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Fax == other.Fax ||
                    this.Fax != null &&
                    this.Fax.Equals(other.Fax)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Terms == other.Terms ||
                    this.Terms != null &&
                    this.Terms.Equals(other.Terms)
                ) && 
                (
                    this.Fob == other.Fob ||
                    this.Fob != null &&
                    this.Fob.Equals(other.Fob)
                ) && 
                (
                    this.ShipVia == other.ShipVia ||
                    this.ShipVia != null &&
                    this.ShipVia.Equals(other.ShipVia)
                ) && 
                (
                    this.RequestDays == other.RequestDays ||
                    this.RequestDays != null &&
                    this.RequestDays.Equals(other.RequestDays)
                ) && 
                (
                    this.ActualDays == other.ActualDays ||
                    this.ActualDays != null &&
                    this.ActualDays.Equals(other.ActualDays)
                ) && 
                (
                    this.SalesTaxCode == other.SalesTaxCode ||
                    this.SalesTaxCode != null &&
                    this.SalesTaxCode.Equals(other.SalesTaxCode)
                ) && 
                (
                    this.Product1 == other.Product1 ||
                    this.Product1 != null &&
                    this.Product1.Equals(other.Product1)
                ) && 
                (
                    this.Product2 == other.Product2 ||
                    this.Product2 != null &&
                    this.Product2.Equals(other.Product2)
                ) && 
                (
                    this.Product3 == other.Product3 ||
                    this.Product3 != null &&
                    this.Product3.Equals(other.Product3)
                ) && 
                (
                    this.Product4 == other.Product4 ||
                    this.Product4 != null &&
                    this.Product4.Equals(other.Product4)
                ) && 
                (
                    this.Product5 == other.Product5 ||
                    this.Product5 != null &&
                    this.Product5.Equals(other.Product5)
                ) && 
                (
                    this.Product6 == other.Product6 ||
                    this.Product6 != null &&
                    this.Product6.Equals(other.Product6)
                ) && 
                (
                    this.Product7 == other.Product7 ||
                    this.Product7 != null &&
                    this.Product7.Equals(other.Product7)
                ) && 
                (
                    this.Product8 == other.Product8 ||
                    this.Product8 != null &&
                    this.Product8.Equals(other.Product8)
                ) && 
                (
                    this.Product9 == other.Product9 ||
                    this.Product9 != null &&
                    this.Product9.Equals(other.Product9)
                ) && 
                (
                    this.PodDays == other.PodDays ||
                    this.PodDays != null &&
                    this.PodDays.Equals(other.PodDays)
                ) && 
                (
                    this.ChargeOut == other.ChargeOut ||
                    this.ChargeOut != null &&
                    this.ChargeOut.Equals(other.ChargeOut)
                ) && 
                (
                    this.ArEmail == other.ArEmail ||
                    this.ArEmail != null &&
                    this.ArEmail.Equals(other.ArEmail)
                ) && 
                (
                    this.OrderEmail == other.OrderEmail ||
                    this.OrderEmail != null &&
                    this.OrderEmail.Equals(other.OrderEmail)
                ) && 
                (
                    this.OrderAttach == other.OrderAttach ||
                    this.OrderAttach != null &&
                    this.OrderAttach.Equals(other.OrderAttach)
                ) && 
                (
                    this.SendQuantityType == other.SendQuantityType ||
                    this.SendQuantityType != null &&
                    this.SendQuantityType.Equals(other.SendQuantityType)
                ) && 
                (
                    this.Minority == other.Minority ||
                    this.Minority != null &&
                    this.Minority.Equals(other.Minority)
                ) && 
                (
                    this.SendOutside == other.SendOutside ||
                    this.SendOutside != null &&
                    this.SendOutside.Equals(other.SendOutside)
                ) && 
                (
                    this.PodOrderSuffix == other.PodOrderSuffix ||
                    this.PodOrderSuffix != null &&
                    this.PodOrderSuffix.Equals(other.PodOrderSuffix)
                ) && 
                (
                    this.PodEmail == other.PodEmail ||
                    this.PodEmail != null &&
                    this.PodEmail.Equals(other.PodEmail)
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
                    this.Inactive == other.Inactive ||
                    this.Inactive != null &&
                    this.Inactive.Equals(other.Inactive)
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
                
                if (this.VendorNo != null)
                    hash = hash * 59 + this.VendorNo.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.Fax != null)
                    hash = hash * 59 + this.Fax.GetHashCode();
                
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                
                if (this.Terms != null)
                    hash = hash * 59 + this.Terms.GetHashCode();
                
                if (this.Fob != null)
                    hash = hash * 59 + this.Fob.GetHashCode();
                
                if (this.ShipVia != null)
                    hash = hash * 59 + this.ShipVia.GetHashCode();
                
                if (this.RequestDays != null)
                    hash = hash * 59 + this.RequestDays.GetHashCode();
                
                if (this.ActualDays != null)
                    hash = hash * 59 + this.ActualDays.GetHashCode();
                
                if (this.SalesTaxCode != null)
                    hash = hash * 59 + this.SalesTaxCode.GetHashCode();
                
                if (this.Product1 != null)
                    hash = hash * 59 + this.Product1.GetHashCode();
                
                if (this.Product2 != null)
                    hash = hash * 59 + this.Product2.GetHashCode();
                
                if (this.Product3 != null)
                    hash = hash * 59 + this.Product3.GetHashCode();
                
                if (this.Product4 != null)
                    hash = hash * 59 + this.Product4.GetHashCode();
                
                if (this.Product5 != null)
                    hash = hash * 59 + this.Product5.GetHashCode();
                
                if (this.Product6 != null)
                    hash = hash * 59 + this.Product6.GetHashCode();
                
                if (this.Product7 != null)
                    hash = hash * 59 + this.Product7.GetHashCode();
                
                if (this.Product8 != null)
                    hash = hash * 59 + this.Product8.GetHashCode();
                
                if (this.Product9 != null)
                    hash = hash * 59 + this.Product9.GetHashCode();
                
                if (this.PodDays != null)
                    hash = hash * 59 + this.PodDays.GetHashCode();
                
                if (this.ChargeOut != null)
                    hash = hash * 59 + this.ChargeOut.GetHashCode();
                
                if (this.ArEmail != null)
                    hash = hash * 59 + this.ArEmail.GetHashCode();
                
                if (this.OrderEmail != null)
                    hash = hash * 59 + this.OrderEmail.GetHashCode();
                
                if (this.OrderAttach != null)
                    hash = hash * 59 + this.OrderAttach.GetHashCode();
                
                if (this.SendQuantityType != null)
                    hash = hash * 59 + this.SendQuantityType.GetHashCode();
                
                if (this.Minority != null)
                    hash = hash * 59 + this.Minority.GetHashCode();
                
                if (this.SendOutside != null)
                    hash = hash * 59 + this.SendOutside.GetHashCode();
                
                if (this.PodOrderSuffix != null)
                    hash = hash * 59 + this.PodOrderSuffix.GetHashCode();
                
                if (this.PodEmail != null)
                    hash = hash * 59 + this.PodEmail.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Inactive != null)
                    hash = hash * 59 + this.Inactive.GetHashCode();
                
                return hash;
            }
        }

    }
}
