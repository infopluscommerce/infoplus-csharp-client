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
    public partial class BillOfLadingCarrierInfoLine :  IEquatable<BillOfLadingCarrierInfoLine>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillOfLadingCarrierInfoLine" /> class.
        /// Initializes a new instance of the <see cref="BillOfLadingCarrierInfoLine" />class.
        /// </summary>
        /// <param name="SeqNo">SeqNo.</param>
        /// <param name="HuQuantity">HuQuantity.</param>
        /// <param name="HuType">HuType.</param>
        /// <param name="PackageQuantity">PackageQuantity.</param>
        /// <param name="PackageType">PackageType.</param>
        /// <param name="Weight">Weight.</param>
        /// <param name="IsHazardousMaterial">IsHazardousMaterial (default to false).</param>
        /// <param name="CommodityDescription">CommodityDescription (required).</param>
        /// <param name="NfmcNo">NfmcNo.</param>
        /// <param name="CarrierClass">CarrierClass.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public BillOfLadingCarrierInfoLine(int? SeqNo = null, int? HuQuantity = null, string HuType = null, int? PackageQuantity = null, string PackageType = null, int? Weight = null, bool? IsHazardousMaterial = null, string CommodityDescription = null, string NfmcNo = null, string CarrierClass = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "CommodityDescription" is required (not null)
            if (CommodityDescription == null)
            {
                throw new InvalidDataException("CommodityDescription is a required property for BillOfLadingCarrierInfoLine and cannot be null");
            }
            else
            {
                this.CommodityDescription = CommodityDescription;
            }
            this.SeqNo = SeqNo;
            this.HuQuantity = HuQuantity;
            this.HuType = HuType;
            this.PackageQuantity = PackageQuantity;
            this.PackageType = PackageType;
            this.Weight = Weight;
            // use default value if no "IsHazardousMaterial" provided
            if (IsHazardousMaterial == null)
            {
                this.IsHazardousMaterial = false;
            }
            else
            {
                this.IsHazardousMaterial = IsHazardousMaterial;
            }
            this.NfmcNo = NfmcNo;
            this.CarrierClass = CarrierClass;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets SeqNo
        /// </summary>
        [DataMember(Name="seqNo", EmitDefaultValue=false)]
        public int? SeqNo { get; set; }
    
        /// <summary>
        /// Gets or Sets HuQuantity
        /// </summary>
        [DataMember(Name="huQuantity", EmitDefaultValue=false)]
        public int? HuQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets HuType
        /// </summary>
        [DataMember(Name="huType", EmitDefaultValue=false)]
        public string HuType { get; set; }
    
        /// <summary>
        /// Gets or Sets PackageQuantity
        /// </summary>
        [DataMember(Name="packageQuantity", EmitDefaultValue=false)]
        public int? PackageQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets PackageType
        /// </summary>
        [DataMember(Name="packageType", EmitDefaultValue=false)]
        public string PackageType { get; set; }
    
        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }
    
        /// <summary>
        /// Gets or Sets IsHazardousMaterial
        /// </summary>
        [DataMember(Name="isHazardousMaterial", EmitDefaultValue=false)]
        public bool? IsHazardousMaterial { get; set; }
    
        /// <summary>
        /// Gets or Sets CommodityDescription
        /// </summary>
        [DataMember(Name="commodityDescription", EmitDefaultValue=false)]
        public string CommodityDescription { get; set; }
    
        /// <summary>
        /// Gets or Sets NfmcNo
        /// </summary>
        [DataMember(Name="nfmcNo", EmitDefaultValue=false)]
        public string NfmcNo { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierClass
        /// </summary>
        [DataMember(Name="carrierClass", EmitDefaultValue=false)]
        public string CarrierClass { get; set; }
    
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
            sb.Append("class BillOfLadingCarrierInfoLine {\n");
            sb.Append("  SeqNo: ").Append(SeqNo).Append("\n");
            sb.Append("  HuQuantity: ").Append(HuQuantity).Append("\n");
            sb.Append("  HuType: ").Append(HuType).Append("\n");
            sb.Append("  PackageQuantity: ").Append(PackageQuantity).Append("\n");
            sb.Append("  PackageType: ").Append(PackageType).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  IsHazardousMaterial: ").Append(IsHazardousMaterial).Append("\n");
            sb.Append("  CommodityDescription: ").Append(CommodityDescription).Append("\n");
            sb.Append("  NfmcNo: ").Append(NfmcNo).Append("\n");
            sb.Append("  CarrierClass: ").Append(CarrierClass).Append("\n");
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
            return this.Equals(obj as BillOfLadingCarrierInfoLine);
        }

        /// <summary>
        /// Returns true if BillOfLadingCarrierInfoLine instances are equal
        /// </summary>
        /// <param name="other">Instance of BillOfLadingCarrierInfoLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillOfLadingCarrierInfoLine other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SeqNo == other.SeqNo ||
                    this.SeqNo != null &&
                    this.SeqNo.Equals(other.SeqNo)
                ) && 
                (
                    this.HuQuantity == other.HuQuantity ||
                    this.HuQuantity != null &&
                    this.HuQuantity.Equals(other.HuQuantity)
                ) && 
                (
                    this.HuType == other.HuType ||
                    this.HuType != null &&
                    this.HuType.Equals(other.HuType)
                ) && 
                (
                    this.PackageQuantity == other.PackageQuantity ||
                    this.PackageQuantity != null &&
                    this.PackageQuantity.Equals(other.PackageQuantity)
                ) && 
                (
                    this.PackageType == other.PackageType ||
                    this.PackageType != null &&
                    this.PackageType.Equals(other.PackageType)
                ) && 
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) && 
                (
                    this.IsHazardousMaterial == other.IsHazardousMaterial ||
                    this.IsHazardousMaterial != null &&
                    this.IsHazardousMaterial.Equals(other.IsHazardousMaterial)
                ) && 
                (
                    this.CommodityDescription == other.CommodityDescription ||
                    this.CommodityDescription != null &&
                    this.CommodityDescription.Equals(other.CommodityDescription)
                ) && 
                (
                    this.NfmcNo == other.NfmcNo ||
                    this.NfmcNo != null &&
                    this.NfmcNo.Equals(other.NfmcNo)
                ) && 
                (
                    this.CarrierClass == other.CarrierClass ||
                    this.CarrierClass != null &&
                    this.CarrierClass.Equals(other.CarrierClass)
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
                
                if (this.SeqNo != null)
                    hash = hash * 59 + this.SeqNo.GetHashCode();
                
                if (this.HuQuantity != null)
                    hash = hash * 59 + this.HuQuantity.GetHashCode();
                
                if (this.HuType != null)
                    hash = hash * 59 + this.HuType.GetHashCode();
                
                if (this.PackageQuantity != null)
                    hash = hash * 59 + this.PackageQuantity.GetHashCode();
                
                if (this.PackageType != null)
                    hash = hash * 59 + this.PackageType.GetHashCode();
                
                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                
                if (this.IsHazardousMaterial != null)
                    hash = hash * 59 + this.IsHazardousMaterial.GetHashCode();
                
                if (this.CommodityDescription != null)
                    hash = hash * 59 + this.CommodityDescription.GetHashCode();
                
                if (this.NfmcNo != null)
                    hash = hash * 59 + this.NfmcNo.GetHashCode();
                
                if (this.CarrierClass != null)
                    hash = hash * 59 + this.CarrierClass.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
