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
    public partial class BillOfLadingOrderInfoLine :  IEquatable<BillOfLadingOrderInfoLine>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillOfLadingOrderInfoLine" /> class.
        /// Initializes a new instance of the <see cref="BillOfLadingOrderInfoLine" />class.
        /// </summary>
        /// <param name="CustomerOrderNo">CustomerOrderNo.</param>
        /// <param name="NoPackages">NoPackages.</param>
        /// <param name="Weight">Weight.</param>
        /// <param name="Palletslip">Palletslip (default to false).</param>
        /// <param name="AdditionalShipperInfo">AdditionalShipperInfo (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public BillOfLadingOrderInfoLine(string CustomerOrderNo = null, int? NoPackages = null, int? Weight = null, bool? Palletslip = null, string AdditionalShipperInfo = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "AdditionalShipperInfo" is required (not null)
            if (AdditionalShipperInfo == null)
            {
                throw new InvalidDataException("AdditionalShipperInfo is a required property for BillOfLadingOrderInfoLine and cannot be null");
            }
            else
            {
                this.AdditionalShipperInfo = AdditionalShipperInfo;
            }
            this.CustomerOrderNo = CustomerOrderNo;
            this.NoPackages = NoPackages;
            this.Weight = Weight;
            // use default value if no "Palletslip" provided
            if (Palletslip == null)
            {
                this.Palletslip = false;
            }
            else
            {
                this.Palletslip = Palletslip;
            }
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CustomerOrderNo
        /// </summary>
        [DataMember(Name="customerOrderNo", EmitDefaultValue=false)]
        public string CustomerOrderNo { get; set; }
    
        /// <summary>
        /// Gets or Sets NoPackages
        /// </summary>
        [DataMember(Name="noPackages", EmitDefaultValue=false)]
        public int? NoPackages { get; set; }
    
        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }
    
        /// <summary>
        /// Gets or Sets Palletslip
        /// </summary>
        [DataMember(Name="palletslip", EmitDefaultValue=false)]
        public bool? Palletslip { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalShipperInfo
        /// </summary>
        [DataMember(Name="additionalShipperInfo", EmitDefaultValue=false)]
        public string AdditionalShipperInfo { get; set; }
    
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
            sb.Append("class BillOfLadingOrderInfoLine {\n");
            sb.Append("  CustomerOrderNo: ").Append(CustomerOrderNo).Append("\n");
            sb.Append("  NoPackages: ").Append(NoPackages).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Palletslip: ").Append(Palletslip).Append("\n");
            sb.Append("  AdditionalShipperInfo: ").Append(AdditionalShipperInfo).Append("\n");
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
            return this.Equals(obj as BillOfLadingOrderInfoLine);
        }

        /// <summary>
        /// Returns true if BillOfLadingOrderInfoLine instances are equal
        /// </summary>
        /// <param name="other">Instance of BillOfLadingOrderInfoLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillOfLadingOrderInfoLine other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerOrderNo == other.CustomerOrderNo ||
                    this.CustomerOrderNo != null &&
                    this.CustomerOrderNo.Equals(other.CustomerOrderNo)
                ) && 
                (
                    this.NoPackages == other.NoPackages ||
                    this.NoPackages != null &&
                    this.NoPackages.Equals(other.NoPackages)
                ) && 
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) && 
                (
                    this.Palletslip == other.Palletslip ||
                    this.Palletslip != null &&
                    this.Palletslip.Equals(other.Palletslip)
                ) && 
                (
                    this.AdditionalShipperInfo == other.AdditionalShipperInfo ||
                    this.AdditionalShipperInfo != null &&
                    this.AdditionalShipperInfo.Equals(other.AdditionalShipperInfo)
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
                
                if (this.CustomerOrderNo != null)
                    hash = hash * 59 + this.CustomerOrderNo.GetHashCode();
                
                if (this.NoPackages != null)
                    hash = hash * 59 + this.NoPackages.GetHashCode();
                
                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                
                if (this.Palletslip != null)
                    hash = hash * 59 + this.Palletslip.GetHashCode();
                
                if (this.AdditionalShipperInfo != null)
                    hash = hash * 59 + this.AdditionalShipperInfo.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
