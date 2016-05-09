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
    public partial class InventoryAdjustment :  IEquatable<InventoryAdjustment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAdjustment" /> class.
        /// Initializes a new instance of the <see cref="InventoryAdjustment" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Lob">Lob.</param>
        /// <param name="SkuId">SkuId.</param>
        /// <param name="PoNoId">PoNoId.</param>
        /// <param name="AdjustmentDate">AdjustmentDate.</param>
        /// <param name="AdjustmentTime">AdjustmentTime.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Qty">Qty.</param>
        /// <param name="Note">Note.</param>
        /// <param name="AuthorizedBy">AuthorizedBy.</param>
        /// <param name="Printed">Printed.</param>
        /// <param name="OrderNo">OrderNo.</param>
        /// <param name="AdjustmentCode">AdjustmentCode.</param>

        public InventoryAdjustment(int? Id = null, int? Lob = null, int? SkuId = null, int? PoNoId = null, DateTime? AdjustmentDate = null, string AdjustmentTime = null, string Location = null, int? Qty = null, string Note = null, string AuthorizedBy = null, string Printed = null, double? OrderNo = null, string AdjustmentCode = null)
        {
            this.Id = Id;
            this.Lob = Lob;
            this.SkuId = SkuId;
            this.PoNoId = PoNoId;
            this.AdjustmentDate = AdjustmentDate;
            this.AdjustmentTime = AdjustmentTime;
            this.Location = Location;
            this.Qty = Qty;
            this.Note = Note;
            this.AuthorizedBy = AuthorizedBy;
            this.Printed = Printed;
            this.OrderNo = OrderNo;
            this.AdjustmentCode = AdjustmentCode;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Lob
        /// </summary>
        [DataMember(Name="lob", EmitDefaultValue=false)]
        public int? Lob { get; set; }
    
        /// <summary>
        /// Gets or Sets SkuId
        /// </summary>
        [DataMember(Name="skuId", EmitDefaultValue=false)]
        public int? SkuId { get; set; }
    
        /// <summary>
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; set; }
    
        /// <summary>
        /// Gets or Sets AdjustmentDate
        /// </summary>
        [DataMember(Name="adjustmentDate", EmitDefaultValue=false)]
        public DateTime? AdjustmentDate { get; set; }
    
        /// <summary>
        /// Gets or Sets AdjustmentTime
        /// </summary>
        [DataMember(Name="adjustmentTime", EmitDefaultValue=false)]
        public string AdjustmentTime { get; set; }
    
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
    
        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="qty", EmitDefaultValue=false)]
        public int? Qty { get; set; }
    
        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
    
        /// <summary>
        /// Gets or Sets AuthorizedBy
        /// </summary>
        [DataMember(Name="authorizedBy", EmitDefaultValue=false)]
        public string AuthorizedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets Printed
        /// </summary>
        [DataMember(Name="printed", EmitDefaultValue=false)]
        public string Printed { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; set; }
    
        /// <summary>
        /// Gets or Sets AdjustmentCode
        /// </summary>
        [DataMember(Name="adjustmentCode", EmitDefaultValue=false)]
        public string AdjustmentCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryAdjustment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Lob: ").Append(Lob).Append("\n");
            sb.Append("  SkuId: ").Append(SkuId).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  AdjustmentDate: ").Append(AdjustmentDate).Append("\n");
            sb.Append("  AdjustmentTime: ").Append(AdjustmentTime).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  AuthorizedBy: ").Append(AuthorizedBy).Append("\n");
            sb.Append("  Printed: ").Append(Printed).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  AdjustmentCode: ").Append(AdjustmentCode).Append("\n");
            
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
            return this.Equals(obj as InventoryAdjustment);
        }

        /// <summary>
        /// Returns true if InventoryAdjustment instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryAdjustment other)
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
                    this.Lob == other.Lob ||
                    this.Lob != null &&
                    this.Lob.Equals(other.Lob)
                ) && 
                (
                    this.SkuId == other.SkuId ||
                    this.SkuId != null &&
                    this.SkuId.Equals(other.SkuId)
                ) && 
                (
                    this.PoNoId == other.PoNoId ||
                    this.PoNoId != null &&
                    this.PoNoId.Equals(other.PoNoId)
                ) && 
                (
                    this.AdjustmentDate == other.AdjustmentDate ||
                    this.AdjustmentDate != null &&
                    this.AdjustmentDate.Equals(other.AdjustmentDate)
                ) && 
                (
                    this.AdjustmentTime == other.AdjustmentTime ||
                    this.AdjustmentTime != null &&
                    this.AdjustmentTime.Equals(other.AdjustmentTime)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Qty == other.Qty ||
                    this.Qty != null &&
                    this.Qty.Equals(other.Qty)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.AuthorizedBy == other.AuthorizedBy ||
                    this.AuthorizedBy != null &&
                    this.AuthorizedBy.Equals(other.AuthorizedBy)
                ) && 
                (
                    this.Printed == other.Printed ||
                    this.Printed != null &&
                    this.Printed.Equals(other.Printed)
                ) && 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.AdjustmentCode == other.AdjustmentCode ||
                    this.AdjustmentCode != null &&
                    this.AdjustmentCode.Equals(other.AdjustmentCode)
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
                
                if (this.Lob != null)
                    hash = hash * 59 + this.Lob.GetHashCode();
                
                if (this.SkuId != null)
                    hash = hash * 59 + this.SkuId.GetHashCode();
                
                if (this.PoNoId != null)
                    hash = hash * 59 + this.PoNoId.GetHashCode();
                
                if (this.AdjustmentDate != null)
                    hash = hash * 59 + this.AdjustmentDate.GetHashCode();
                
                if (this.AdjustmentTime != null)
                    hash = hash * 59 + this.AdjustmentTime.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                
                if (this.Qty != null)
                    hash = hash * 59 + this.Qty.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                if (this.AuthorizedBy != null)
                    hash = hash * 59 + this.AuthorizedBy.GetHashCode();
                
                if (this.Printed != null)
                    hash = hash * 59 + this.Printed.GetHashCode();
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.AdjustmentCode != null)
                    hash = hash * 59 + this.AdjustmentCode.GetHashCode();
                
                return hash;
            }
        }

    }
}
