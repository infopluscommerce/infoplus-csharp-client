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
    public partial class CartonType :  IEquatable<CartonType>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonType" /> class.
        /// Initializes a new instance of the <see cref="CartonType" />class.
        /// </summary>
        /// <param name="Abbreviation">Abbreviation (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="LengthIn">LengthIn (required).</param>
        /// <param name="WidthIn">WidthIn (required).</param>
        /// <param name="HeightIn">HeightIn (required).</param>
        /// <param name="InnerLengthIn">InnerLengthIn (required).</param>
        /// <param name="InnerWidthIn">InnerWidthIn (required).</param>
        /// <param name="InnerHeightIn">InnerHeightIn (required).</param>
        /// <param name="WeightLbs">WeightLbs.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="IsActive">IsActive (required) (default to false).</param>
        /// <param name="PredefinedPackageTypeId">PredefinedPackageTypeId.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public CartonType(string Abbreviation = null, string Name = null, double? LengthIn = null, double? WidthIn = null, double? HeightIn = null, double? InnerLengthIn = null, double? InnerWidthIn = null, double? InnerHeightIn = null, double? WeightLbs = null, int? LobId = null, bool? IsActive = null, int? PredefinedPackageTypeId = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "Abbreviation" is required (not null)
            if (Abbreviation == null)
            {
                throw new InvalidDataException("Abbreviation is a required property for CartonType and cannot be null");
            }
            else
            {
                this.Abbreviation = Abbreviation;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CartonType and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "LengthIn" is required (not null)
            if (LengthIn == null)
            {
                throw new InvalidDataException("LengthIn is a required property for CartonType and cannot be null");
            }
            else
            {
                this.LengthIn = LengthIn;
            }
            // to ensure "WidthIn" is required (not null)
            if (WidthIn == null)
            {
                throw new InvalidDataException("WidthIn is a required property for CartonType and cannot be null");
            }
            else
            {
                this.WidthIn = WidthIn;
            }
            // to ensure "HeightIn" is required (not null)
            if (HeightIn == null)
            {
                throw new InvalidDataException("HeightIn is a required property for CartonType and cannot be null");
            }
            else
            {
                this.HeightIn = HeightIn;
            }
            // to ensure "InnerLengthIn" is required (not null)
            if (InnerLengthIn == null)
            {
                throw new InvalidDataException("InnerLengthIn is a required property for CartonType and cannot be null");
            }
            else
            {
                this.InnerLengthIn = InnerLengthIn;
            }
            // to ensure "InnerWidthIn" is required (not null)
            if (InnerWidthIn == null)
            {
                throw new InvalidDataException("InnerWidthIn is a required property for CartonType and cannot be null");
            }
            else
            {
                this.InnerWidthIn = InnerWidthIn;
            }
            // to ensure "InnerHeightIn" is required (not null)
            if (InnerHeightIn == null)
            {
                throw new InvalidDataException("InnerHeightIn is a required property for CartonType and cannot be null");
            }
            else
            {
                this.InnerHeightIn = InnerHeightIn;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for CartonType and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "IsActive" is required (not null)
            if (IsActive == null)
            {
                throw new InvalidDataException("IsActive is a required property for CartonType and cannot be null");
            }
            else
            {
                this.IsActive = IsActive;
            }
            this.WeightLbs = WeightLbs;
            this.PredefinedPackageTypeId = PredefinedPackageTypeId;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets LengthIn
        /// </summary>
        [DataMember(Name="lengthIn", EmitDefaultValue=false)]
        public double? LengthIn { get; set; }
    
        /// <summary>
        /// Gets or Sets WidthIn
        /// </summary>
        [DataMember(Name="widthIn", EmitDefaultValue=false)]
        public double? WidthIn { get; set; }
    
        /// <summary>
        /// Gets or Sets HeightIn
        /// </summary>
        [DataMember(Name="heightIn", EmitDefaultValue=false)]
        public double? HeightIn { get; set; }
    
        /// <summary>
        /// Gets or Sets InnerLengthIn
        /// </summary>
        [DataMember(Name="innerLengthIn", EmitDefaultValue=false)]
        public double? InnerLengthIn { get; set; }
    
        /// <summary>
        /// Gets or Sets InnerWidthIn
        /// </summary>
        [DataMember(Name="innerWidthIn", EmitDefaultValue=false)]
        public double? InnerWidthIn { get; set; }
    
        /// <summary>
        /// Gets or Sets InnerHeightIn
        /// </summary>
        [DataMember(Name="innerHeightIn", EmitDefaultValue=false)]
        public double? InnerHeightIn { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightLbs
        /// </summary>
        [DataMember(Name="weightLbs", EmitDefaultValue=false)]
        public double? WeightLbs { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or Sets PredefinedPackageTypeId
        /// </summary>
        [DataMember(Name="predefinedPackageTypeId", EmitDefaultValue=false)]
        public int? PredefinedPackageTypeId { get; set; }
    
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
            sb.Append("class CartonType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LengthIn: ").Append(LengthIn).Append("\n");
            sb.Append("  WidthIn: ").Append(WidthIn).Append("\n");
            sb.Append("  HeightIn: ").Append(HeightIn).Append("\n");
            sb.Append("  InnerLengthIn: ").Append(InnerLengthIn).Append("\n");
            sb.Append("  InnerWidthIn: ").Append(InnerWidthIn).Append("\n");
            sb.Append("  InnerHeightIn: ").Append(InnerHeightIn).Append("\n");
            sb.Append("  WeightLbs: ").Append(WeightLbs).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  PredefinedPackageTypeId: ").Append(PredefinedPackageTypeId).Append("\n");
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
            return this.Equals(obj as CartonType);
        }

        /// <summary>
        /// Returns true if CartonType instances are equal
        /// </summary>
        /// <param name="other">Instance of CartonType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartonType other)
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
                    this.Abbreviation == other.Abbreviation ||
                    this.Abbreviation != null &&
                    this.Abbreviation.Equals(other.Abbreviation)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.LengthIn == other.LengthIn ||
                    this.LengthIn != null &&
                    this.LengthIn.Equals(other.LengthIn)
                ) && 
                (
                    this.WidthIn == other.WidthIn ||
                    this.WidthIn != null &&
                    this.WidthIn.Equals(other.WidthIn)
                ) && 
                (
                    this.HeightIn == other.HeightIn ||
                    this.HeightIn != null &&
                    this.HeightIn.Equals(other.HeightIn)
                ) && 
                (
                    this.InnerLengthIn == other.InnerLengthIn ||
                    this.InnerLengthIn != null &&
                    this.InnerLengthIn.Equals(other.InnerLengthIn)
                ) && 
                (
                    this.InnerWidthIn == other.InnerWidthIn ||
                    this.InnerWidthIn != null &&
                    this.InnerWidthIn.Equals(other.InnerWidthIn)
                ) && 
                (
                    this.InnerHeightIn == other.InnerHeightIn ||
                    this.InnerHeightIn != null &&
                    this.InnerHeightIn.Equals(other.InnerHeightIn)
                ) && 
                (
                    this.WeightLbs == other.WeightLbs ||
                    this.WeightLbs != null &&
                    this.WeightLbs.Equals(other.WeightLbs)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) && 
                (
                    this.PredefinedPackageTypeId == other.PredefinedPackageTypeId ||
                    this.PredefinedPackageTypeId != null &&
                    this.PredefinedPackageTypeId.Equals(other.PredefinedPackageTypeId)
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
                
                if (this.Abbreviation != null)
                    hash = hash * 59 + this.Abbreviation.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.LengthIn != null)
                    hash = hash * 59 + this.LengthIn.GetHashCode();
                
                if (this.WidthIn != null)
                    hash = hash * 59 + this.WidthIn.GetHashCode();
                
                if (this.HeightIn != null)
                    hash = hash * 59 + this.HeightIn.GetHashCode();
                
                if (this.InnerLengthIn != null)
                    hash = hash * 59 + this.InnerLengthIn.GetHashCode();
                
                if (this.InnerWidthIn != null)
                    hash = hash * 59 + this.InnerWidthIn.GetHashCode();
                
                if (this.InnerHeightIn != null)
                    hash = hash * 59 + this.InnerHeightIn.GetHashCode();
                
                if (this.WeightLbs != null)
                    hash = hash * 59 + this.WeightLbs.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                
                if (this.PredefinedPackageTypeId != null)
                    hash = hash * 59 + this.PredefinedPackageTypeId.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
