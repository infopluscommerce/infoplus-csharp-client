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
    public partial class Warehouse :  IEquatable<Warehouse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Warehouse" /> class.
        /// Initializes a new instance of the <see cref="Warehouse" />class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Address">Address.</param>
        /// <param name="Company">Company (required).</param>
        /// <param name="Street1">Street1 (required).</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="Street3">Street3.</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State (required).</param>
        /// <param name="Zip">Zip (required).</param>
        /// <param name="Country">Country.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="LocationBarcodePrefix">LocationBarcodePrefix.</param>
        /// <param name="LpnPrefix">LpnPrefix.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Warehouse(string Name = null, string Address = null, string Company = null, string Street1 = null, string Street2 = null, string Street3 = null, string City = null, string State = null, string Zip = null, string Country = null, string Phone = null, string LocationBarcodePrefix = null, string LpnPrefix = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Warehouse and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Company" is required (not null)
            if (Company == null)
            {
                throw new InvalidDataException("Company is a required property for Warehouse and cannot be null");
            }
            else
            {
                this.Company = Company;
            }
            // to ensure "Street1" is required (not null)
            if (Street1 == null)
            {
                throw new InvalidDataException("Street1 is a required property for Warehouse and cannot be null");
            }
            else
            {
                this.Street1 = Street1;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for Warehouse and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for Warehouse and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "Zip" is required (not null)
            if (Zip == null)
            {
                throw new InvalidDataException("Zip is a required property for Warehouse and cannot be null");
            }
            else
            {
                this.Zip = Zip;
            }
            this.Address = Address;
            this.Street2 = Street2;
            this.Street3 = Street3;
            this.Country = Country;
            this.Phone = Phone;
            this.LocationBarcodePrefix = LocationBarcodePrefix;
            this.LpnPrefix = LpnPrefix;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Client
        /// </summary>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public int? Client { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
    
        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        [DataMember(Name="street1", EmitDefaultValue=false)]
        public string Street1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Street3
        /// </summary>
        [DataMember(Name="street3", EmitDefaultValue=false)]
        public string Street3 { get; set; }
    
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
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
    
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
        /// Gets or Sets LocationBarcodePrefix
        /// </summary>
        [DataMember(Name="locationBarcodePrefix", EmitDefaultValue=false)]
        public string LocationBarcodePrefix { get; set; }
    
        /// <summary>
        /// Gets or Sets LpnPrefix
        /// </summary>
        [DataMember(Name="lpnPrefix", EmitDefaultValue=false)]
        public string LpnPrefix { get; set; }
    
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
            sb.Append("class Warehouse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Street3: ").Append(Street3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  LocationBarcodePrefix: ").Append(LocationBarcodePrefix).Append("\n");
            sb.Append("  LpnPrefix: ").Append(LpnPrefix).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
            return this.Equals(obj as Warehouse);
        }

        /// <summary>
        /// Returns true if Warehouse instances are equal
        /// </summary>
        /// <param name="other">Instance of Warehouse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Warehouse other)
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
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Street1 == other.Street1 ||
                    this.Street1 != null &&
                    this.Street1.Equals(other.Street1)
                ) && 
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) && 
                (
                    this.Street3 == other.Street3 ||
                    this.Street3 != null &&
                    this.Street3.Equals(other.Street3)
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
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
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
                    this.LocationBarcodePrefix == other.LocationBarcodePrefix ||
                    this.LocationBarcodePrefix != null &&
                    this.LocationBarcodePrefix.Equals(other.LocationBarcodePrefix)
                ) && 
                (
                    this.LpnPrefix == other.LpnPrefix ||
                    this.LpnPrefix != null &&
                    this.LpnPrefix.Equals(other.LpnPrefix)
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
                
                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                
                if (this.Street1 != null)
                    hash = hash * 59 + this.Street1.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
                if (this.Street3 != null)
                    hash = hash * 59 + this.Street3.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.LocationBarcodePrefix != null)
                    hash = hash * 59 + this.LocationBarcodePrefix.GetHashCode();
                
                if (this.LpnPrefix != null)
                    hash = hash * 59 + this.LpnPrefix.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
