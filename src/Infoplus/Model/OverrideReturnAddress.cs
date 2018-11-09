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
    /// OverrideReturnAddress
    /// </summary>
    [DataContract]
    public partial class OverrideReturnAddress :  IEquatable<OverrideReturnAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideReturnAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OverrideReturnAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideReturnAddress" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="OrderSourceId">OrderSourceId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Attention">Attention.</param>
        /// <param name="Street">Street (required).</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="Street3Province">Street3Province.</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State.</param>
        /// <param name="Zip">Zip (required).</param>
        /// <param name="Country">Country.</param>
        /// <param name="Phone">Phone (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public OverrideReturnAddress(int? LobId = default(int?), int? WarehouseId = default(int?), int? OrderSourceId = default(int?), string Name = default(string), string Attention = default(string), string Street = default(string), string Street2 = default(string), string Street3Province = default(string), string City = default(string), string State = default(string), string Zip = default(string), string Country = default(string), string Phone = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
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
            this.Street3Province = Street3Province;
            this.State = State;
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
            sb.Append("  Street3Province: ").Append(Street3Province).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OverrideReturnAddress);
        }

        /// <summary>
        /// Returns true if OverrideReturnAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of OverrideReturnAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverrideReturnAddress input)
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
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.OrderSourceId == input.OrderSourceId ||
                    (this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(input.OrderSourceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Attention == input.Attention ||
                    (this.Attention != null &&
                    this.Attention.Equals(input.Attention))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
                ) && 
                (
                    this.Street3Province == input.Street3Province ||
                    (this.Street3Province != null &&
                    this.Street3Province.Equals(input.Street3Province))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.OrderSourceId != null)
                    hashCode = hashCode * 59 + this.OrderSourceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Attention != null)
                    hashCode = hashCode * 59 + this.Attention.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Street2 != null)
                    hashCode = hashCode * 59 + this.Street2.GetHashCode();
                if (this.Street3Province != null)
                    hashCode = hashCode * 59 + this.Street3Province.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
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