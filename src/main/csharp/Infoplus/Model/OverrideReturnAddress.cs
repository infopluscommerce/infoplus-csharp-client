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
    public partial class OverrideReturnAddress :  IEquatable<OverrideReturnAddress>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideReturnAddress" /> class.
        /// Initializes a new instance of the <see cref="OverrideReturnAddress" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="OrderSourceId">OrderSourceId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Attention">Attention.</param>
        /// <param name="Street">Street (required).</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State (required).</param>
        /// <param name="Zip">Zip (required).</param>
        /// <param name="Country">Country.</param>
        /// <param name="Phone">Phone (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public OverrideReturnAddress(int? LobId = null, int? WarehouseId = null, int? OrderSourceId = null, string Name = null, string Attention = null, string Street = null, string Street2 = null, string City = null, string State = null, string Zip = null, string Country = null, string Phone = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "OrderSourceId" is required (not null)
            if (OrderSourceId == null)
            {
                throw new InvalidDataException("OrderSourceId is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.OrderSourceId = OrderSourceId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "Zip" is required (not null)
            if (Zip == null)
            {
                throw new InvalidDataException("Zip is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.Zip = Zip;
            }
            // to ensure "Phone" is required (not null)
            if (Phone == null)
            {
                throw new InvalidDataException("Phone is a required property for OverrideReturnAddress and cannot be null");
            }
            else
            {
                this.Phone = Phone;
            }
            this.Attention = Attention;
            this.Street2 = Street2;
            this.Country = Country;
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
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderSourceId
        /// </summary>
        [DataMember(Name="orderSourceId", EmitDefaultValue=false)]
        public int? OrderSourceId { get; set; }
    
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
            sb.Append("class OverrideReturnAddress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  OrderSourceId: ").Append(OrderSourceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(obj as OverrideReturnAddress);
        }

        /// <summary>
        /// Returns true if OverrideReturnAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of OverrideReturnAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverrideReturnAddress other)
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
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.OrderSourceId == other.OrderSourceId ||
                    this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(other.OrderSourceId)
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
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.OrderSourceId != null)
                    hash = hash * 59 + this.OrderSourceId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Attention != null)
                    hash = hash * 59 + this.Attention.GetHashCode();
                
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
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
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
