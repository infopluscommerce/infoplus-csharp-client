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
    public partial class Work :  IEquatable<Work>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Work" /> class.
        /// Initializes a new instance of the <see cref="Work" />class.
        /// </summary>
        /// <param name="SourceWarehouseId">SourceWarehouseId (required).</param>
        /// <param name="SourceBuildingId">SourceBuildingId (required).</param>
        /// <param name="SourceLocation">SourceLocation (required).</param>
        /// <param name="DestinationWarehouseId">DestinationWarehouseId (required).</param>
        /// <param name="DestinationBuildingId">DestinationBuildingId (required).</param>
        /// <param name="DestinationLocation">DestinationLocation (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="PriorityCode">PriorityCode (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="WorkBatchId">WorkBatchId.</param>

        public Work(int? SourceWarehouseId = null, int? SourceBuildingId = null, string SourceLocation = null, int? DestinationWarehouseId = null, int? DestinationBuildingId = null, string DestinationLocation = null, string Type = null, int? PriorityCode = null, string Status = null, int? UserId = null, int? WorkBatchId = null)
        {
            // to ensure "SourceWarehouseId" is required (not null)
            if (SourceWarehouseId == null)
            {
                throw new InvalidDataException("SourceWarehouseId is a required property for Work and cannot be null");
            }
            else
            {
                this.SourceWarehouseId = SourceWarehouseId;
            }
            // to ensure "SourceBuildingId" is required (not null)
            if (SourceBuildingId == null)
            {
                throw new InvalidDataException("SourceBuildingId is a required property for Work and cannot be null");
            }
            else
            {
                this.SourceBuildingId = SourceBuildingId;
            }
            // to ensure "SourceLocation" is required (not null)
            if (SourceLocation == null)
            {
                throw new InvalidDataException("SourceLocation is a required property for Work and cannot be null");
            }
            else
            {
                this.SourceLocation = SourceLocation;
            }
            // to ensure "DestinationWarehouseId" is required (not null)
            if (DestinationWarehouseId == null)
            {
                throw new InvalidDataException("DestinationWarehouseId is a required property for Work and cannot be null");
            }
            else
            {
                this.DestinationWarehouseId = DestinationWarehouseId;
            }
            // to ensure "DestinationBuildingId" is required (not null)
            if (DestinationBuildingId == null)
            {
                throw new InvalidDataException("DestinationBuildingId is a required property for Work and cannot be null");
            }
            else
            {
                this.DestinationBuildingId = DestinationBuildingId;
            }
            // to ensure "DestinationLocation" is required (not null)
            if (DestinationLocation == null)
            {
                throw new InvalidDataException("DestinationLocation is a required property for Work and cannot be null");
            }
            else
            {
                this.DestinationLocation = DestinationLocation;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Work and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "PriorityCode" is required (not null)
            if (PriorityCode == null)
            {
                throw new InvalidDataException("PriorityCode is a required property for Work and cannot be null");
            }
            else
            {
                this.PriorityCode = PriorityCode;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for Work and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for Work and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            this.WorkBatchId = WorkBatchId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets SourceWarehouseId
        /// </summary>
        [DataMember(Name="sourceWarehouseId", EmitDefaultValue=false)]
        public int? SourceWarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceBuildingId
        /// </summary>
        [DataMember(Name="sourceBuildingId", EmitDefaultValue=false)]
        public int? SourceBuildingId { get; set; }
    
        /// <summary>
        /// Gets or Sets SourceLocation
        /// </summary>
        [DataMember(Name="sourceLocation", EmitDefaultValue=false)]
        public string SourceLocation { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationWarehouseId
        /// </summary>
        [DataMember(Name="destinationWarehouseId", EmitDefaultValue=false)]
        public int? DestinationWarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationBuildingId
        /// </summary>
        [DataMember(Name="destinationBuildingId", EmitDefaultValue=false)]
        public int? DestinationBuildingId { get; set; }
    
        /// <summary>
        /// Gets or Sets DestinationLocation
        /// </summary>
        [DataMember(Name="destinationLocation", EmitDefaultValue=false)]
        public string DestinationLocation { get; set; }
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
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
        /// Gets or Sets PriorityCode
        /// </summary>
        [DataMember(Name="priorityCode", EmitDefaultValue=false)]
        public int? PriorityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
    
        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Work {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SourceWarehouseId: ").Append(SourceWarehouseId).Append("\n");
            sb.Append("  SourceBuildingId: ").Append(SourceBuildingId).Append("\n");
            sb.Append("  SourceLocation: ").Append(SourceLocation).Append("\n");
            sb.Append("  DestinationWarehouseId: ").Append(DestinationWarehouseId).Append("\n");
            sb.Append("  DestinationBuildingId: ").Append(DestinationBuildingId).Append("\n");
            sb.Append("  DestinationLocation: ").Append(DestinationLocation).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  PriorityCode: ").Append(PriorityCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
            
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
            return this.Equals(obj as Work);
        }

        /// <summary>
        /// Returns true if Work instances are equal
        /// </summary>
        /// <param name="other">Instance of Work to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Work other)
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
                    this.SourceWarehouseId == other.SourceWarehouseId ||
                    this.SourceWarehouseId != null &&
                    this.SourceWarehouseId.Equals(other.SourceWarehouseId)
                ) && 
                (
                    this.SourceBuildingId == other.SourceBuildingId ||
                    this.SourceBuildingId != null &&
                    this.SourceBuildingId.Equals(other.SourceBuildingId)
                ) && 
                (
                    this.SourceLocation == other.SourceLocation ||
                    this.SourceLocation != null &&
                    this.SourceLocation.Equals(other.SourceLocation)
                ) && 
                (
                    this.DestinationWarehouseId == other.DestinationWarehouseId ||
                    this.DestinationWarehouseId != null &&
                    this.DestinationWarehouseId.Equals(other.DestinationWarehouseId)
                ) && 
                (
                    this.DestinationBuildingId == other.DestinationBuildingId ||
                    this.DestinationBuildingId != null &&
                    this.DestinationBuildingId.Equals(other.DestinationBuildingId)
                ) && 
                (
                    this.DestinationLocation == other.DestinationLocation ||
                    this.DestinationLocation != null &&
                    this.DestinationLocation.Equals(other.DestinationLocation)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    this.PriorityCode == other.PriorityCode ||
                    this.PriorityCode != null &&
                    this.PriorityCode.Equals(other.PriorityCode)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.WorkBatchId == other.WorkBatchId ||
                    this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(other.WorkBatchId)
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
                
                if (this.SourceWarehouseId != null)
                    hash = hash * 59 + this.SourceWarehouseId.GetHashCode();
                
                if (this.SourceBuildingId != null)
                    hash = hash * 59 + this.SourceBuildingId.GetHashCode();
                
                if (this.SourceLocation != null)
                    hash = hash * 59 + this.SourceLocation.GetHashCode();
                
                if (this.DestinationWarehouseId != null)
                    hash = hash * 59 + this.DestinationWarehouseId.GetHashCode();
                
                if (this.DestinationBuildingId != null)
                    hash = hash * 59 + this.DestinationBuildingId.GetHashCode();
                
                if (this.DestinationLocation != null)
                    hash = hash * 59 + this.DestinationLocation.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.PriorityCode != null)
                    hash = hash * 59 + this.PriorityCode.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.WorkBatchId != null)
                    hash = hash * 59 + this.WorkBatchId.GetHashCode();
                
                return hash;
            }
        }

    }
}
