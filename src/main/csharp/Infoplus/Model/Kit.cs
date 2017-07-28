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
    public partial class Kit :  IEquatable<Kit>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Kit" /> class.
        /// Initializes a new instance of the <see cref="Kit" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="KitSKU">KitSKU (required).</param>
        /// <param name="PackagingType">PackagingType.</param>
        /// <param name="Other">Other.</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="Line1">Line1.</param>
        /// <param name="Line2">Line2.</param>
        /// <param name="Line3">Line3.</param>
        /// <param name="Line4">Line4.</param>
        /// <param name="Line5">Line5.</param>
        /// <param name="Line6">Line6.</param>
        /// <param name="Line7">Line7.</param>
        /// <param name="Line8">Line8.</param>
        /// <param name="Touches">Touches (required).</param>
        /// <param name="MinInvQty">MinInvQty.</param>
        /// <param name="MidInvQty">MidInvQty.</param>
        /// <param name="MaxInvQty">MaxInvQty.</param>
        /// <param name="IsKOD">IsKOD (required).</param>
        /// <param name="KodType">KodType (required).</param>
        /// <param name="KitComponentList">KitComponentList (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Kit(int? LobId = null, string KitSKU = null, string PackagingType = null, string Other = null, DateTime? CreateDate = null, DateTime? ModifyDate = null, string Line1 = null, string Line2 = null, string Line3 = null, string Line4 = null, string Line5 = null, string Line6 = null, string Line7 = null, string Line8 = null, int? Touches = null, int? MinInvQty = null, int? MidInvQty = null, int? MaxInvQty = null, string IsKOD = null, string KodType = null, List<KitComponent> KitComponentList = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for Kit and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "KitSKU" is required (not null)
            if (KitSKU == null)
            {
                throw new InvalidDataException("KitSKU is a required property for Kit and cannot be null");
            }
            else
            {
                this.KitSKU = KitSKU;
            }
            // to ensure "Touches" is required (not null)
            if (Touches == null)
            {
                throw new InvalidDataException("Touches is a required property for Kit and cannot be null");
            }
            else
            {
                this.Touches = Touches;
            }
            // to ensure "IsKOD" is required (not null)
            if (IsKOD == null)
            {
                throw new InvalidDataException("IsKOD is a required property for Kit and cannot be null");
            }
            else
            {
                this.IsKOD = IsKOD;
            }
            // to ensure "KodType" is required (not null)
            if (KodType == null)
            {
                throw new InvalidDataException("KodType is a required property for Kit and cannot be null");
            }
            else
            {
                this.KodType = KodType;
            }
            // to ensure "KitComponentList" is required (not null)
            if (KitComponentList == null)
            {
                throw new InvalidDataException("KitComponentList is a required property for Kit and cannot be null");
            }
            else
            {
                this.KitComponentList = KitComponentList;
            }
            this.PackagingType = PackagingType;
            this.Other = Other;
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.Line1 = Line1;
            this.Line2 = Line2;
            this.Line3 = Line3;
            this.Line4 = Line4;
            this.Line5 = Line5;
            this.Line6 = Line6;
            this.Line7 = Line7;
            this.Line8 = Line8;
            this.MinInvQty = MinInvQty;
            this.MidInvQty = MidInvQty;
            this.MaxInvQty = MaxInvQty;
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
        /// Gets or Sets KitSKU
        /// </summary>
        [DataMember(Name="kitSKU", EmitDefaultValue=false)]
        public string KitSKU { get; set; }
    
        /// <summary>
        /// Gets or Sets PackagingType
        /// </summary>
        [DataMember(Name="packagingType", EmitDefaultValue=false)]
        public string PackagingType { get; set; }
    
        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public string Other { get; set; }
    
        /// <summary>
        /// Gets or Sets NumberOfComponents
        /// </summary>
        [DataMember(Name="numberOfComponents", EmitDefaultValue=false)]
        public int? NumberOfComponents { get; private set; }
    
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
        /// Gets or Sets Line1
        /// </summary>
        [DataMember(Name="line1", EmitDefaultValue=false)]
        public string Line1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line2
        /// </summary>
        [DataMember(Name="line2", EmitDefaultValue=false)]
        public string Line2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line3
        /// </summary>
        [DataMember(Name="line3", EmitDefaultValue=false)]
        public string Line3 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line4
        /// </summary>
        [DataMember(Name="line4", EmitDefaultValue=false)]
        public string Line4 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line5
        /// </summary>
        [DataMember(Name="line5", EmitDefaultValue=false)]
        public string Line5 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line6
        /// </summary>
        [DataMember(Name="line6", EmitDefaultValue=false)]
        public string Line6 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line7
        /// </summary>
        [DataMember(Name="line7", EmitDefaultValue=false)]
        public string Line7 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line8
        /// </summary>
        [DataMember(Name="line8", EmitDefaultValue=false)]
        public string Line8 { get; set; }
    
        /// <summary>
        /// Gets or Sets Touches
        /// </summary>
        [DataMember(Name="touches", EmitDefaultValue=false)]
        public int? Touches { get; set; }
    
        /// <summary>
        /// Gets or Sets MinInvQty
        /// </summary>
        [DataMember(Name="minInvQty", EmitDefaultValue=false)]
        public int? MinInvQty { get; set; }
    
        /// <summary>
        /// Gets or Sets MidInvQty
        /// </summary>
        [DataMember(Name="midInvQty", EmitDefaultValue=false)]
        public int? MidInvQty { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxInvQty
        /// </summary>
        [DataMember(Name="maxInvQty", EmitDefaultValue=false)]
        public int? MaxInvQty { get; set; }
    
        /// <summary>
        /// Gets or Sets IsKOD
        /// </summary>
        [DataMember(Name="isKOD", EmitDefaultValue=false)]
        public string IsKOD { get; set; }
    
        /// <summary>
        /// Gets or Sets KodType
        /// </summary>
        [DataMember(Name="kodType", EmitDefaultValue=false)]
        public string KodType { get; set; }
    
        /// <summary>
        /// Gets or Sets KitComponentList
        /// </summary>
        [DataMember(Name="kitComponentList", EmitDefaultValue=false)]
        public List<KitComponent> KitComponentList { get; set; }
    
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
            sb.Append("class Kit {\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  KitSKU: ").Append(KitSKU).Append("\n");
            sb.Append("  PackagingType: ").Append(PackagingType).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  NumberOfComponents: ").Append(NumberOfComponents).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Line3: ").Append(Line3).Append("\n");
            sb.Append("  Line4: ").Append(Line4).Append("\n");
            sb.Append("  Line5: ").Append(Line5).Append("\n");
            sb.Append("  Line6: ").Append(Line6).Append("\n");
            sb.Append("  Line7: ").Append(Line7).Append("\n");
            sb.Append("  Line8: ").Append(Line8).Append("\n");
            sb.Append("  Touches: ").Append(Touches).Append("\n");
            sb.Append("  MinInvQty: ").Append(MinInvQty).Append("\n");
            sb.Append("  MidInvQty: ").Append(MidInvQty).Append("\n");
            sb.Append("  MaxInvQty: ").Append(MaxInvQty).Append("\n");
            sb.Append("  IsKOD: ").Append(IsKOD).Append("\n");
            sb.Append("  KodType: ").Append(KodType).Append("\n");
            sb.Append("  KitComponentList: ").Append(KitComponentList).Append("\n");
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
            return this.Equals(obj as Kit);
        }

        /// <summary>
        /// Returns true if Kit instances are equal
        /// </summary>
        /// <param name="other">Instance of Kit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Kit other)
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
                    this.KitSKU == other.KitSKU ||
                    this.KitSKU != null &&
                    this.KitSKU.Equals(other.KitSKU)
                ) && 
                (
                    this.PackagingType == other.PackagingType ||
                    this.PackagingType != null &&
                    this.PackagingType.Equals(other.PackagingType)
                ) && 
                (
                    this.Other == other.Other ||
                    this.Other != null &&
                    this.Other.Equals(other.Other)
                ) && 
                (
                    this.NumberOfComponents == other.NumberOfComponents ||
                    this.NumberOfComponents != null &&
                    this.NumberOfComponents.Equals(other.NumberOfComponents)
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
                    this.Line1 == other.Line1 ||
                    this.Line1 != null &&
                    this.Line1.Equals(other.Line1)
                ) && 
                (
                    this.Line2 == other.Line2 ||
                    this.Line2 != null &&
                    this.Line2.Equals(other.Line2)
                ) && 
                (
                    this.Line3 == other.Line3 ||
                    this.Line3 != null &&
                    this.Line3.Equals(other.Line3)
                ) && 
                (
                    this.Line4 == other.Line4 ||
                    this.Line4 != null &&
                    this.Line4.Equals(other.Line4)
                ) && 
                (
                    this.Line5 == other.Line5 ||
                    this.Line5 != null &&
                    this.Line5.Equals(other.Line5)
                ) && 
                (
                    this.Line6 == other.Line6 ||
                    this.Line6 != null &&
                    this.Line6.Equals(other.Line6)
                ) && 
                (
                    this.Line7 == other.Line7 ||
                    this.Line7 != null &&
                    this.Line7.Equals(other.Line7)
                ) && 
                (
                    this.Line8 == other.Line8 ||
                    this.Line8 != null &&
                    this.Line8.Equals(other.Line8)
                ) && 
                (
                    this.Touches == other.Touches ||
                    this.Touches != null &&
                    this.Touches.Equals(other.Touches)
                ) && 
                (
                    this.MinInvQty == other.MinInvQty ||
                    this.MinInvQty != null &&
                    this.MinInvQty.Equals(other.MinInvQty)
                ) && 
                (
                    this.MidInvQty == other.MidInvQty ||
                    this.MidInvQty != null &&
                    this.MidInvQty.Equals(other.MidInvQty)
                ) && 
                (
                    this.MaxInvQty == other.MaxInvQty ||
                    this.MaxInvQty != null &&
                    this.MaxInvQty.Equals(other.MaxInvQty)
                ) && 
                (
                    this.IsKOD == other.IsKOD ||
                    this.IsKOD != null &&
                    this.IsKOD.Equals(other.IsKOD)
                ) && 
                (
                    this.KodType == other.KodType ||
                    this.KodType != null &&
                    this.KodType.Equals(other.KodType)
                ) && 
                (
                    this.KitComponentList == other.KitComponentList ||
                    this.KitComponentList != null &&
                    this.KitComponentList.SequenceEqual(other.KitComponentList)
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
                
                if (this.KitSKU != null)
                    hash = hash * 59 + this.KitSKU.GetHashCode();
                
                if (this.PackagingType != null)
                    hash = hash * 59 + this.PackagingType.GetHashCode();
                
                if (this.Other != null)
                    hash = hash * 59 + this.Other.GetHashCode();
                
                if (this.NumberOfComponents != null)
                    hash = hash * 59 + this.NumberOfComponents.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.Line1 != null)
                    hash = hash * 59 + this.Line1.GetHashCode();
                
                if (this.Line2 != null)
                    hash = hash * 59 + this.Line2.GetHashCode();
                
                if (this.Line3 != null)
                    hash = hash * 59 + this.Line3.GetHashCode();
                
                if (this.Line4 != null)
                    hash = hash * 59 + this.Line4.GetHashCode();
                
                if (this.Line5 != null)
                    hash = hash * 59 + this.Line5.GetHashCode();
                
                if (this.Line6 != null)
                    hash = hash * 59 + this.Line6.GetHashCode();
                
                if (this.Line7 != null)
                    hash = hash * 59 + this.Line7.GetHashCode();
                
                if (this.Line8 != null)
                    hash = hash * 59 + this.Line8.GetHashCode();
                
                if (this.Touches != null)
                    hash = hash * 59 + this.Touches.GetHashCode();
                
                if (this.MinInvQty != null)
                    hash = hash * 59 + this.MinInvQty.GetHashCode();
                
                if (this.MidInvQty != null)
                    hash = hash * 59 + this.MidInvQty.GetHashCode();
                
                if (this.MaxInvQty != null)
                    hash = hash * 59 + this.MaxInvQty.GetHashCode();
                
                if (this.IsKOD != null)
                    hash = hash * 59 + this.IsKOD.GetHashCode();
                
                if (this.KodType != null)
                    hash = hash * 59 + this.KodType.GetHashCode();
                
                if (this.KitComponentList != null)
                    hash = hash * 59 + this.KitComponentList.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
