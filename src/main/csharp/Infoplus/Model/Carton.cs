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
    public partial class Carton :  IEquatable<Carton>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Carton" /> class.
        /// Initializes a new instance of the <see cref="Carton" />class.
        /// </summary>
        /// <param name="OrderNo">OrderNo (required).</param>
        /// <param name="CartonNo">CartonNo.</param>
        /// <param name="CartonTypeId">CartonTypeId (required).</param>
        /// <param name="CartonLPN">CartonLPN.</param>
        /// <param name="WeightLbs">WeightLbs.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Carton(double? OrderNo = null, int? CartonNo = null, int? CartonTypeId = null, string CartonLPN = null, double? WeightLbs = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "OrderNo" is required (not null)
            if (OrderNo == null)
            {
                throw new InvalidDataException("OrderNo is a required property for Carton and cannot be null");
            }
            else
            {
                this.OrderNo = OrderNo;
            }
            // to ensure "CartonTypeId" is required (not null)
            if (CartonTypeId == null)
            {
                throw new InvalidDataException("CartonTypeId is a required property for Carton and cannot be null");
            }
            else
            {
                this.CartonTypeId = CartonTypeId;
            }
            this.CartonNo = CartonNo;
            this.CartonLPN = CartonLPN;
            this.WeightLbs = WeightLbs;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonNo
        /// </summary>
        [DataMember(Name="cartonNo", EmitDefaultValue=false)]
        public int? CartonNo { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonTypeId
        /// </summary>
        [DataMember(Name="cartonTypeId", EmitDefaultValue=false)]
        public int? CartonTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets CartonLPN
        /// </summary>
        [DataMember(Name="cartonLPN", EmitDefaultValue=false)]
        public string CartonLPN { get; set; }
    
        /// <summary>
        /// Gets or Sets WeightLbs
        /// </summary>
        [DataMember(Name="weightLbs", EmitDefaultValue=false)]
        public double? WeightLbs { get; set; }
    
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
            sb.Append("class Carton {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  CartonNo: ").Append(CartonNo).Append("\n");
            sb.Append("  CartonTypeId: ").Append(CartonTypeId).Append("\n");
            sb.Append("  CartonLPN: ").Append(CartonLPN).Append("\n");
            sb.Append("  WeightLbs: ").Append(WeightLbs).Append("\n");
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
            return this.Equals(obj as Carton);
        }

        /// <summary>
        /// Returns true if Carton instances are equal
        /// </summary>
        /// <param name="other">Instance of Carton to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Carton other)
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
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.CartonNo == other.CartonNo ||
                    this.CartonNo != null &&
                    this.CartonNo.Equals(other.CartonNo)
                ) && 
                (
                    this.CartonTypeId == other.CartonTypeId ||
                    this.CartonTypeId != null &&
                    this.CartonTypeId.Equals(other.CartonTypeId)
                ) && 
                (
                    this.CartonLPN == other.CartonLPN ||
                    this.CartonLPN != null &&
                    this.CartonLPN.Equals(other.CartonLPN)
                ) && 
                (
                    this.WeightLbs == other.WeightLbs ||
                    this.WeightLbs != null &&
                    this.WeightLbs.Equals(other.WeightLbs)
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
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.CartonNo != null)
                    hash = hash * 59 + this.CartonNo.GetHashCode();
                
                if (this.CartonTypeId != null)
                    hash = hash * 59 + this.CartonTypeId.GetHashCode();
                
                if (this.CartonLPN != null)
                    hash = hash * 59 + this.CartonLPN.GetHashCode();
                
                if (this.WeightLbs != null)
                    hash = hash * 59 + this.WeightLbs.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
