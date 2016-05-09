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
    public partial class Customer :  IEquatable<Customer>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer" /> class.
        /// Initializes a new instance of the <see cref="Customer" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="CustomerNo">CustomerNo (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Attention">Attention.</param>
        /// <param name="Street">Street (required).</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="Street3Province">Street3Province.</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State.</param>
        /// <param name="ZipCode">ZipCode (required).</param>
        /// <param name="Country">Country (required).</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Fax">Fax.</param>
        /// <param name="Email">Email.</param>
        /// <param name="BossBranch">BossBranch.</param>
        /// <param name="PackageCarrierId">PackageCarrierId (required).</param>
        /// <param name="TruckCarrierId">TruckCarrierId (required).</param>
        /// <param name="WeightBreak">WeightBreak (required).</param>
        /// <param name="Sector">Sector.</param>
        /// <param name="Division">Division.</param>
        /// <param name="CostCenter">CostCenter.</param>
        /// <param name="County">County.</param>
        /// <param name="Area">Area.</param>
        /// <param name="CustomerType">CustomerType.</param>
        /// <param name="MassLevel">MassLevel.</param>
        /// <param name="MassFactor">MassFactor.</param>
        /// <param name="PriceLevel">PriceLevel.</param>
        /// <param name="CloseDate">CloseDate.</param>
        /// <param name="RestrictionPercent">RestrictionPercent.</param>
        /// <param name="ExternalId">ExternalId.</param>
        /// <param name="CycleDate">CycleDate.</param>
        /// <param name="Manager">Manager.</param>
        /// <param name="AlternateInventory">AlternateInventory.</param>
        /// <param name="Pin">Pin.</param>
        /// <param name="FaxGone">FaxGone.</param>
        /// <param name="Residential">Residential (required).</param>
        /// <param name="CsrBranch">CsrBranch.</param>
        /// <param name="ExtrinsicText1">ExtrinsicText1.</param>
        /// <param name="ExtrinsicText2">ExtrinsicText2.</param>
        /// <param name="ExtrinsicText3">ExtrinsicText3.</param>
        /// <param name="ExtrinsicNumber1">ExtrinsicNumber1.</param>
        /// <param name="ExtrinsicNumber2">ExtrinsicNumber2.</param>
        /// <param name="ExtrinsicDecimal1">ExtrinsicDecimal1.</param>
        /// <param name="ExtrinsicDecimal2">ExtrinsicDecimal2.</param>
        /// <param name="ModifyDate">ModifyDate.</param>

        public Customer(int? LobId = null, string CustomerNo = null, string Name = null, string Attention = null, string Street = null, string Street2 = null, string Street3Province = null, string City = null, string State = null, string ZipCode = null, string Country = null, string Phone = null, string Fax = null, string Email = null, string BossBranch = null, int? PackageCarrierId = null, int? TruckCarrierId = null, int? WeightBreak = null, string Sector = null, int? Division = null, string CostCenter = null, string County = null, string Area = null, string CustomerType = null, string MassLevel = null, double? MassFactor = null, string PriceLevel = null, DateTime? CloseDate = null, int? RestrictionPercent = null, string ExternalId = null, DateTime? CycleDate = null, string Manager = null, int? AlternateInventory = null, string Pin = null, string FaxGone = null, string Residential = null, string CsrBranch = null, string ExtrinsicText1 = null, string ExtrinsicText2 = null, string ExtrinsicText3 = null, int? ExtrinsicNumber1 = null, int? ExtrinsicNumber2 = null, double? ExtrinsicDecimal1 = null, double? ExtrinsicDecimal2 = null, DateTime? ModifyDate = null, )
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Customer and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "CustomerNo" is required (not null)
            if (CustomerNo == null)
            {
                throw new InvalidDataException("CustomerNo is a required property for Customer and cannot be null");
            }
            else
            {
                this.CustomerNo = CustomerNo;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Customer and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for Customer and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for Customer and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "ZipCode" is required (not null)
            if (ZipCode == null)
            {
                throw new InvalidDataException("ZipCode is a required property for Customer and cannot be null");
            }
            else
            {
                this.ZipCode = ZipCode;
            }
            // to ensure "Country" is required (not null)
            if (Country == null)
            {
                throw new InvalidDataException("Country is a required property for Customer and cannot be null");
            }
            else
            {
                this.Country = Country;
            }
            // to ensure "PackageCarrierId" is required (not null)
            if (PackageCarrierId == null)
            {
                throw new InvalidDataException("PackageCarrierId is a required property for Customer and cannot be null");
            }
            else
            {
                this.PackageCarrierId = PackageCarrierId;
            }
            // to ensure "TruckCarrierId" is required (not null)
            if (TruckCarrierId == null)
            {
                throw new InvalidDataException("TruckCarrierId is a required property for Customer and cannot be null");
            }
            else
            {
                this.TruckCarrierId = TruckCarrierId;
            }
            // to ensure "WeightBreak" is required (not null)
            if (WeightBreak == null)
            {
                throw new InvalidDataException("WeightBreak is a required property for Customer and cannot be null");
            }
            else
            {
                this.WeightBreak = WeightBreak;
            }
            // to ensure "Residential" is required (not null)
            if (Residential == null)
            {
                throw new InvalidDataException("Residential is a required property for Customer and cannot be null");
            }
            else
            {
                this.Residential = Residential;
            }
            this.Attention = Attention;
            this.Street2 = Street2;
            this.Street3Province = Street3Province;
            this.State = State;
            this.Phone = Phone;
            this.Fax = Fax;
            this.Email = Email;
            this.BossBranch = BossBranch;
            this.Sector = Sector;
            this.Division = Division;
            this.CostCenter = CostCenter;
            this.County = County;
            this.Area = Area;
            this.CustomerType = CustomerType;
            this.MassLevel = MassLevel;
            this.MassFactor = MassFactor;
            this.PriceLevel = PriceLevel;
            this.CloseDate = CloseDate;
            this.RestrictionPercent = RestrictionPercent;
            this.ExternalId = ExternalId;
            this.CycleDate = CycleDate;
            this.Manager = Manager;
            this.AlternateInventory = AlternateInventory;
            this.Pin = Pin;
            this.FaxGone = FaxGone;
            this.CsrBranch = CsrBranch;
            this.ExtrinsicText1 = ExtrinsicText1;
            this.ExtrinsicText2 = ExtrinsicText2;
            this.ExtrinsicText3 = ExtrinsicText3;
            this.ExtrinsicNumber1 = ExtrinsicNumber1;
            this.ExtrinsicNumber2 = ExtrinsicNumber2;
            this.ExtrinsicDecimal1 = ExtrinsicDecimal1;
            this.ExtrinsicDecimal2 = ExtrinsicDecimal2;
            this.ModifyDate = ModifyDate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerNo
        /// </summary>
        [DataMember(Name="customerNo", EmitDefaultValue=false)]
        public string CustomerNo { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name="attention", EmitDefaultValue=false)]
        public string Attention { get; set; }
    
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
        /// Gets or Sets Street3Province
        /// </summary>
        [DataMember(Name="street3Province", EmitDefaultValue=false)]
        public string Street3Province { get; set; }
    
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
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="zipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
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
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets BossBranch
        /// </summary>
        [DataMember(Name="bossBranch", EmitDefaultValue=false)]
        public string BossBranch { get; set; }
    
        /// <summary>
        /// Gets or Sets PackageCarrierId
        /// </summary>
        [DataMember(Name="packageCarrierId", EmitDefaultValue=false)]
        public int? PackageCarrierId { get; set; }
    
        /// <summary>
        /// Gets or Sets TruckCarrierId
        /// </summary>
        [DataMember(Name="truckCarrierId", EmitDefaultValue=false)]
        public int? TruckCarrierId { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightBreak
        /// </summary>
        [DataMember(Name="weightBreak", EmitDefaultValue=false)]
        public int? WeightBreak { get; set; }
    
        /// <summary>
        /// Gets or Sets Sector
        /// </summary>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; set; }
    
        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public int? Division { get; set; }
    
        /// <summary>
        /// Gets or Sets CostCenter
        /// </summary>
        [DataMember(Name="costCenter", EmitDefaultValue=false)]
        public string CostCenter { get; set; }
    
        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }
    
        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomerType
        /// </summary>
        [DataMember(Name="customerType", EmitDefaultValue=false)]
        public string CustomerType { get; set; }
    
        /// <summary>
        /// Gets or Sets MassLevel
        /// </summary>
        [DataMember(Name="massLevel", EmitDefaultValue=false)]
        public string MassLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets MassFactor
        /// </summary>
        [DataMember(Name="massFactor", EmitDefaultValue=false)]
        public double? MassFactor { get; set; }
    
        /// <summary>
        /// Gets or Sets PriceLevel
        /// </summary>
        [DataMember(Name="priceLevel", EmitDefaultValue=false)]
        public string PriceLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets OpenDate
        /// </summary>
        [DataMember(Name="openDate", EmitDefaultValue=false)]
        public DateTime? OpenDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets CloseDate
        /// </summary>
        [DataMember(Name="closeDate", EmitDefaultValue=false)]
        public DateTime? CloseDate { get; set; }
    
        /// <summary>
        /// Gets or Sets RestrictionPercent
        /// </summary>
        [DataMember(Name="restrictionPercent", EmitDefaultValue=false)]
        public int? RestrictionPercent { get; set; }
    
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or Sets CycleDate
        /// </summary>
        [DataMember(Name="cycleDate", EmitDefaultValue=false)]
        public DateTime? CycleDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public string Manager { get; set; }
    
        /// <summary>
        /// Gets or Sets AlternateInventory
        /// </summary>
        [DataMember(Name="alternateInventory", EmitDefaultValue=false)]
        public int? AlternateInventory { get; set; }
    
        /// <summary>
        /// Gets or Sets Pin
        /// </summary>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        public string Pin { get; set; }
    
        /// <summary>
        /// Gets or Sets FaxGone
        /// </summary>
        [DataMember(Name="faxGone", EmitDefaultValue=false)]
        public string FaxGone { get; set; }
    
        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        [DataMember(Name="residential", EmitDefaultValue=false)]
        public string Residential { get; set; }
    
        /// <summary>
        /// Gets or Sets CsrBranch
        /// </summary>
        [DataMember(Name="csrBranch", EmitDefaultValue=false)]
        public string CsrBranch { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText1
        /// </summary>
        [DataMember(Name="extrinsicText1", EmitDefaultValue=false)]
        public string ExtrinsicText1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText2
        /// </summary>
        [DataMember(Name="extrinsicText2", EmitDefaultValue=false)]
        public string ExtrinsicText2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicText3
        /// </summary>
        [DataMember(Name="extrinsicText3", EmitDefaultValue=false)]
        public string ExtrinsicText3 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicNumber1
        /// </summary>
        [DataMember(Name="extrinsicNumber1", EmitDefaultValue=false)]
        public int? ExtrinsicNumber1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicNumber2
        /// </summary>
        [DataMember(Name="extrinsicNumber2", EmitDefaultValue=false)]
        public int? ExtrinsicNumber2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicDecimal1
        /// </summary>
        [DataMember(Name="extrinsicDecimal1", EmitDefaultValue=false)]
        public double? ExtrinsicDecimal1 { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtrinsicDecimal2
        /// </summary>
        [DataMember(Name="extrinsicDecimal2", EmitDefaultValue=false)]
        public double? ExtrinsicDecimal2 { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }
    
        /// <summary>
        /// Gets or Sets OmsCustomerId
        /// </summary>
        [DataMember(Name="omsCustomerId", EmitDefaultValue=false)]
        public int? OmsCustomerId { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  CustomerNo: ").Append(CustomerNo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Street3Province: ").Append(Street3Province).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BossBranch: ").Append(BossBranch).Append("\n");
            sb.Append("  PackageCarrierId: ").Append(PackageCarrierId).Append("\n");
            sb.Append("  TruckCarrierId: ").Append(TruckCarrierId).Append("\n");
            sb.Append("  WeightBreak: ").Append(WeightBreak).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  CostCenter: ").Append(CostCenter).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  CustomerType: ").Append(CustomerType).Append("\n");
            sb.Append("  MassLevel: ").Append(MassLevel).Append("\n");
            sb.Append("  MassFactor: ").Append(MassFactor).Append("\n");
            sb.Append("  PriceLevel: ").Append(PriceLevel).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  CloseDate: ").Append(CloseDate).Append("\n");
            sb.Append("  RestrictionPercent: ").Append(RestrictionPercent).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  CycleDate: ").Append(CycleDate).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  AlternateInventory: ").Append(AlternateInventory).Append("\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
            sb.Append("  FaxGone: ").Append(FaxGone).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
            sb.Append("  CsrBranch: ").Append(CsrBranch).Append("\n");
            sb.Append("  ExtrinsicText1: ").Append(ExtrinsicText1).Append("\n");
            sb.Append("  ExtrinsicText2: ").Append(ExtrinsicText2).Append("\n");
            sb.Append("  ExtrinsicText3: ").Append(ExtrinsicText3).Append("\n");
            sb.Append("  ExtrinsicNumber1: ").Append(ExtrinsicNumber1).Append("\n");
            sb.Append("  ExtrinsicNumber2: ").Append(ExtrinsicNumber2).Append("\n");
            sb.Append("  ExtrinsicDecimal1: ").Append(ExtrinsicDecimal1).Append("\n");
            sb.Append("  ExtrinsicDecimal2: ").Append(ExtrinsicDecimal2).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  OmsCustomerId: ").Append(OmsCustomerId).Append("\n");
            
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
            return this.Equals(obj as Customer);
        }

        /// <summary>
        /// Returns true if Customer instances are equal
        /// </summary>
        /// <param name="other">Instance of Customer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customer other)
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
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.CustomerNo == other.CustomerNo ||
                    this.CustomerNo != null &&
                    this.CustomerNo.Equals(other.CustomerNo)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Attention == other.Attention ||
                    this.Attention != null &&
                    this.Attention.Equals(other.Attention)
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
                    this.Street3Province == other.Street3Province ||
                    this.Street3Province != null &&
                    this.Street3Province.Equals(other.Street3Province)
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
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.BossBranch == other.BossBranch ||
                    this.BossBranch != null &&
                    this.BossBranch.Equals(other.BossBranch)
                ) && 
                (
                    this.PackageCarrierId == other.PackageCarrierId ||
                    this.PackageCarrierId != null &&
                    this.PackageCarrierId.Equals(other.PackageCarrierId)
                ) && 
                (
                    this.TruckCarrierId == other.TruckCarrierId ||
                    this.TruckCarrierId != null &&
                    this.TruckCarrierId.Equals(other.TruckCarrierId)
                ) && 
                (
                    this.WeightBreak == other.WeightBreak ||
                    this.WeightBreak != null &&
                    this.WeightBreak.Equals(other.WeightBreak)
                ) && 
                (
                    this.Sector == other.Sector ||
                    this.Sector != null &&
                    this.Sector.Equals(other.Sector)
                ) && 
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) && 
                (
                    this.CostCenter == other.CostCenter ||
                    this.CostCenter != null &&
                    this.CostCenter.Equals(other.CostCenter)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.Area == other.Area ||
                    this.Area != null &&
                    this.Area.Equals(other.Area)
                ) && 
                (
                    this.CustomerType == other.CustomerType ||
                    this.CustomerType != null &&
                    this.CustomerType.Equals(other.CustomerType)
                ) && 
                (
                    this.MassLevel == other.MassLevel ||
                    this.MassLevel != null &&
                    this.MassLevel.Equals(other.MassLevel)
                ) && 
                (
                    this.MassFactor == other.MassFactor ||
                    this.MassFactor != null &&
                    this.MassFactor.Equals(other.MassFactor)
                ) && 
                (
                    this.PriceLevel == other.PriceLevel ||
                    this.PriceLevel != null &&
                    this.PriceLevel.Equals(other.PriceLevel)
                ) && 
                (
                    this.OpenDate == other.OpenDate ||
                    this.OpenDate != null &&
                    this.OpenDate.Equals(other.OpenDate)
                ) && 
                (
                    this.CloseDate == other.CloseDate ||
                    this.CloseDate != null &&
                    this.CloseDate.Equals(other.CloseDate)
                ) && 
                (
                    this.RestrictionPercent == other.RestrictionPercent ||
                    this.RestrictionPercent != null &&
                    this.RestrictionPercent.Equals(other.RestrictionPercent)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.CycleDate == other.CycleDate ||
                    this.CycleDate != null &&
                    this.CycleDate.Equals(other.CycleDate)
                ) && 
                (
                    this.Manager == other.Manager ||
                    this.Manager != null &&
                    this.Manager.Equals(other.Manager)
                ) && 
                (
                    this.AlternateInventory == other.AlternateInventory ||
                    this.AlternateInventory != null &&
                    this.AlternateInventory.Equals(other.AlternateInventory)
                ) && 
                (
                    this.Pin == other.Pin ||
                    this.Pin != null &&
                    this.Pin.Equals(other.Pin)
                ) && 
                (
                    this.FaxGone == other.FaxGone ||
                    this.FaxGone != null &&
                    this.FaxGone.Equals(other.FaxGone)
                ) && 
                (
                    this.Residential == other.Residential ||
                    this.Residential != null &&
                    this.Residential.Equals(other.Residential)
                ) && 
                (
                    this.CsrBranch == other.CsrBranch ||
                    this.CsrBranch != null &&
                    this.CsrBranch.Equals(other.CsrBranch)
                ) && 
                (
                    this.ExtrinsicText1 == other.ExtrinsicText1 ||
                    this.ExtrinsicText1 != null &&
                    this.ExtrinsicText1.Equals(other.ExtrinsicText1)
                ) && 
                (
                    this.ExtrinsicText2 == other.ExtrinsicText2 ||
                    this.ExtrinsicText2 != null &&
                    this.ExtrinsicText2.Equals(other.ExtrinsicText2)
                ) && 
                (
                    this.ExtrinsicText3 == other.ExtrinsicText3 ||
                    this.ExtrinsicText3 != null &&
                    this.ExtrinsicText3.Equals(other.ExtrinsicText3)
                ) && 
                (
                    this.ExtrinsicNumber1 == other.ExtrinsicNumber1 ||
                    this.ExtrinsicNumber1 != null &&
                    this.ExtrinsicNumber1.Equals(other.ExtrinsicNumber1)
                ) && 
                (
                    this.ExtrinsicNumber2 == other.ExtrinsicNumber2 ||
                    this.ExtrinsicNumber2 != null &&
                    this.ExtrinsicNumber2.Equals(other.ExtrinsicNumber2)
                ) && 
                (
                    this.ExtrinsicDecimal1 == other.ExtrinsicDecimal1 ||
                    this.ExtrinsicDecimal1 != null &&
                    this.ExtrinsicDecimal1.Equals(other.ExtrinsicDecimal1)
                ) && 
                (
                    this.ExtrinsicDecimal2 == other.ExtrinsicDecimal2 ||
                    this.ExtrinsicDecimal2 != null &&
                    this.ExtrinsicDecimal2.Equals(other.ExtrinsicDecimal2)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.OmsCustomerId == other.OmsCustomerId ||
                    this.OmsCustomerId != null &&
                    this.OmsCustomerId.Equals(other.OmsCustomerId)
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
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.CustomerNo != null)
                    hash = hash * 59 + this.CustomerNo.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Attention != null)
                    hash = hash * 59 + this.Attention.GetHashCode();
                
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
                if (this.Street3Province != null)
                    hash = hash * 59 + this.Street3Province.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.Fax != null)
                    hash = hash * 59 + this.Fax.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.BossBranch != null)
                    hash = hash * 59 + this.BossBranch.GetHashCode();
                
                if (this.PackageCarrierId != null)
                    hash = hash * 59 + this.PackageCarrierId.GetHashCode();
                
                if (this.TruckCarrierId != null)
                    hash = hash * 59 + this.TruckCarrierId.GetHashCode();
                
                if (this.WeightBreak != null)
                    hash = hash * 59 + this.WeightBreak.GetHashCode();
                
                if (this.Sector != null)
                    hash = hash * 59 + this.Sector.GetHashCode();
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.CostCenter != null)
                    hash = hash * 59 + this.CostCenter.GetHashCode();
                
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                
                if (this.Area != null)
                    hash = hash * 59 + this.Area.GetHashCode();
                
                if (this.CustomerType != null)
                    hash = hash * 59 + this.CustomerType.GetHashCode();
                
                if (this.MassLevel != null)
                    hash = hash * 59 + this.MassLevel.GetHashCode();
                
                if (this.MassFactor != null)
                    hash = hash * 59 + this.MassFactor.GetHashCode();
                
                if (this.PriceLevel != null)
                    hash = hash * 59 + this.PriceLevel.GetHashCode();
                
                if (this.OpenDate != null)
                    hash = hash * 59 + this.OpenDate.GetHashCode();
                
                if (this.CloseDate != null)
                    hash = hash * 59 + this.CloseDate.GetHashCode();
                
                if (this.RestrictionPercent != null)
                    hash = hash * 59 + this.RestrictionPercent.GetHashCode();
                
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                
                if (this.CycleDate != null)
                    hash = hash * 59 + this.CycleDate.GetHashCode();
                
                if (this.Manager != null)
                    hash = hash * 59 + this.Manager.GetHashCode();
                
                if (this.AlternateInventory != null)
                    hash = hash * 59 + this.AlternateInventory.GetHashCode();
                
                if (this.Pin != null)
                    hash = hash * 59 + this.Pin.GetHashCode();
                
                if (this.FaxGone != null)
                    hash = hash * 59 + this.FaxGone.GetHashCode();
                
                if (this.Residential != null)
                    hash = hash * 59 + this.Residential.GetHashCode();
                
                if (this.CsrBranch != null)
                    hash = hash * 59 + this.CsrBranch.GetHashCode();
                
                if (this.ExtrinsicText1 != null)
                    hash = hash * 59 + this.ExtrinsicText1.GetHashCode();
                
                if (this.ExtrinsicText2 != null)
                    hash = hash * 59 + this.ExtrinsicText2.GetHashCode();
                
                if (this.ExtrinsicText3 != null)
                    hash = hash * 59 + this.ExtrinsicText3.GetHashCode();
                
                if (this.ExtrinsicNumber1 != null)
                    hash = hash * 59 + this.ExtrinsicNumber1.GetHashCode();
                
                if (this.ExtrinsicNumber2 != null)
                    hash = hash * 59 + this.ExtrinsicNumber2.GetHashCode();
                
                if (this.ExtrinsicDecimal1 != null)
                    hash = hash * 59 + this.ExtrinsicDecimal1.GetHashCode();
                
                if (this.ExtrinsicDecimal2 != null)
                    hash = hash * 59 + this.ExtrinsicDecimal2.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.OmsCustomerId != null)
                    hash = hash * 59 + this.OmsCustomerId.GetHashCode();
                
                return hash;
            }
        }

    }
}
