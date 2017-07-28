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
    public partial class ReceivingProcess :  IEquatable<ReceivingProcess>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingProcess" /> class.
        /// Initializes a new instance of the <see cref="ReceivingProcess" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="WorkBatchId">WorkBatchId.</param>
        /// <param name="ReceivingWorksheetId">ReceivingWorksheetId.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ReceivingProcess(int? WarehouseId = null, string Status = null, int? WorkBatchId = null, int? ReceivingWorksheetId = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for ReceivingProcess and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for ReceivingProcess and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.WorkBatchId = WorkBatchId;
            this.ReceivingWorksheetId = ReceivingWorksheetId;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceivingWorksheetId
        /// </summary>
        [DataMember(Name="receivingWorksheetId", EmitDefaultValue=false)]
        public int? ReceivingWorksheetId { get; set; }
    
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
            sb.Append("class ReceivingProcess {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
            sb.Append("  ReceivingWorksheetId: ").Append(ReceivingWorksheetId).Append("\n");
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
            return this.Equals(obj as ReceivingProcess);
        }

        /// <summary>
        /// Returns true if ReceivingProcess instances are equal
        /// </summary>
        /// <param name="other">Instance of ReceivingProcess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivingProcess other)
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
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.WorkBatchId == other.WorkBatchId ||
                    this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(other.WorkBatchId)
                ) && 
                (
                    this.ReceivingWorksheetId == other.ReceivingWorksheetId ||
                    this.ReceivingWorksheetId != null &&
                    this.ReceivingWorksheetId.Equals(other.ReceivingWorksheetId)
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
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.WorkBatchId != null)
                    hash = hash * 59 + this.WorkBatchId.GetHashCode();
                
                if (this.ReceivingWorksheetId != null)
                    hash = hash * 59 + this.ReceivingWorksheetId.GetHashCode();
                
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
