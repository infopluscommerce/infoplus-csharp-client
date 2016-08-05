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
    public partial class Supplement :  IEquatable<Supplement>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Supplement" /> class.
        /// Initializes a new instance of the <see cref="Supplement" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="OriginalSKUId">OriginalSKUId (required).</param>
        /// <param name="SupplementSKUId">SupplementSKUId (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="SupplementQuantity">SupplementQuantity (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Supplement(int? LobId = null, DateTime? CreateDate = null, DateTime? ModifyDate = null, int? OriginalSKUId = null, int? SupplementSKUId = null, string Type = null, double? SupplementQuantity = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Supplement and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "OriginalSKUId" is required (not null)
            if (OriginalSKUId == null)
            {
                throw new InvalidDataException("OriginalSKUId is a required property for Supplement and cannot be null");
            }
            else
            {
                this.OriginalSKUId = OriginalSKUId;
            }
            // to ensure "SupplementSKUId" is required (not null)
            if (SupplementSKUId == null)
            {
                throw new InvalidDataException("SupplementSKUId is a required property for Supplement and cannot be null");
            }
            else
            {
                this.SupplementSKUId = SupplementSKUId;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Supplement and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "SupplementQuantity" is required (not null)
            if (SupplementQuantity == null)
            {
                throw new InvalidDataException("SupplementQuantity is a required property for Supplement and cannot be null");
            }
            else
            {
                this.SupplementQuantity = SupplementQuantity;
            }
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
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
        /// Gets or Sets OriginalSKUId
        /// </summary>
        [DataMember(Name="originalSKUId", EmitDefaultValue=false)]
        public int? OriginalSKUId { get; set; }
    
        /// <summary>
        /// Gets or Sets SupplementSKUId
        /// </summary>
        [DataMember(Name="supplementSKUId", EmitDefaultValue=false)]
        public int? SupplementSKUId { get; set; }
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or Sets SupplementQuantity
        /// </summary>
        [DataMember(Name="supplementQuantity", EmitDefaultValue=false)]
        public double? SupplementQuantity { get; set; }
    
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
            sb.Append("class Supplement {\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  OriginalSKUId: ").Append(OriginalSKUId).Append("\n");
            sb.Append("  SupplementSKUId: ").Append(SupplementSKUId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SupplementQuantity: ").Append(SupplementQuantity).Append("\n");
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
            return this.Equals(obj as Supplement);
        }

        /// <summary>
        /// Returns true if Supplement instances are equal
        /// </summary>
        /// <param name="other">Instance of Supplement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Supplement other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
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
                    this.OriginalSKUId == other.OriginalSKUId ||
                    this.OriginalSKUId != null &&
                    this.OriginalSKUId.Equals(other.OriginalSKUId)
                ) && 
                (
                    this.SupplementSKUId == other.SupplementSKUId ||
                    this.SupplementSKUId != null &&
                    this.SupplementSKUId.Equals(other.SupplementSKUId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.SupplementQuantity == other.SupplementQuantity ||
                    this.SupplementQuantity != null &&
                    this.SupplementQuantity.Equals(other.SupplementQuantity)
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
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.OriginalSKUId != null)
                    hash = hash * 59 + this.OriginalSKUId.GetHashCode();
                
                if (this.SupplementSKUId != null)
                    hash = hash * 59 + this.SupplementSKUId.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.SupplementQuantity != null)
                    hash = hash * 59 + this.SupplementQuantity.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
