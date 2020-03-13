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
    /// Work
    /// </summary>
    [DataContract]
    public partial class Work :  IEquatable<Work>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Work" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Work() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Work" /> class.
        /// </summary>
        /// <param name="UserDefinedMessage">UserDefinedMessage.</param>
        /// <param name="WorkProductList">WorkProductList.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public Work(string UserDefinedMessage = default(string), List<WorkProduct> WorkProductList = default(List<WorkProduct>), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            this.UserDefinedMessage = UserDefinedMessage;
            this.WorkProductList = WorkProductList;
            this.CustomFields = CustomFields;
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
        public int? SourceWarehouseId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceBuildingId
        /// </summary>
        [DataMember(Name="sourceBuildingId", EmitDefaultValue=false)]
        public int? SourceBuildingId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceLocation
        /// </summary>
        [DataMember(Name="sourceLocation", EmitDefaultValue=false)]
        public string SourceLocation { get; private set; }

        /// <summary>
        /// Gets or Sets DestinationWarehouseId
        /// </summary>
        [DataMember(Name="destinationWarehouseId", EmitDefaultValue=false)]
        public int? DestinationWarehouseId { get; private set; }

        /// <summary>
        /// Gets or Sets DestinationBuildingId
        /// </summary>
        [DataMember(Name="destinationBuildingId", EmitDefaultValue=false)]
        public int? DestinationBuildingId { get; private set; }

        /// <summary>
        /// Gets or Sets DestinationLocation
        /// </summary>
        [DataMember(Name="destinationLocation", EmitDefaultValue=false)]
        public string DestinationLocation { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

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
        public int? PriorityCode { get; private set; }

        /// <summary>
        /// Gets or Sets UserDefinedMessage
        /// </summary>
        [DataMember(Name="userDefinedMessage", EmitDefaultValue=false)]
        public string UserDefinedMessage { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; private set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; private set; }

        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; private set; }

        /// <summary>
        /// Gets or Sets WorkProductList
        /// </summary>
        [DataMember(Name="workProductList", EmitDefaultValue=false)]
        public List<WorkProduct> WorkProductList { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentProcessId
        /// </summary>
        [DataMember(Name="fulfillmentProcessId", EmitDefaultValue=false)]
        public int? FulfillmentProcessId { get; private set; }

        /// <summary>
        /// Gets or Sets PickLineId
        /// </summary>
        [DataMember(Name="pickLineId", EmitDefaultValue=false)]
        public int? PickLineId { get; private set; }

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
            sb.Append("  UserDefinedMessage: ").Append(UserDefinedMessage).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
            sb.Append("  WorkProductList: ").Append(WorkProductList).Append("\n");
            sb.Append("  FulfillmentProcessId: ").Append(FulfillmentProcessId).Append("\n");
            sb.Append("  PickLineId: ").Append(PickLineId).Append("\n");
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
            return this.Equals(input as Work);
        }

        /// <summary>
        /// Returns true if Work instances are equal
        /// </summary>
        /// <param name="input">Instance of Work to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Work input)
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
                    this.SourceWarehouseId == input.SourceWarehouseId ||
                    (this.SourceWarehouseId != null &&
                    this.SourceWarehouseId.Equals(input.SourceWarehouseId))
                ) && 
                (
                    this.SourceBuildingId == input.SourceBuildingId ||
                    (this.SourceBuildingId != null &&
                    this.SourceBuildingId.Equals(input.SourceBuildingId))
                ) && 
                (
                    this.SourceLocation == input.SourceLocation ||
                    (this.SourceLocation != null &&
                    this.SourceLocation.Equals(input.SourceLocation))
                ) && 
                (
                    this.DestinationWarehouseId == input.DestinationWarehouseId ||
                    (this.DestinationWarehouseId != null &&
                    this.DestinationWarehouseId.Equals(input.DestinationWarehouseId))
                ) && 
                (
                    this.DestinationBuildingId == input.DestinationBuildingId ||
                    (this.DestinationBuildingId != null &&
                    this.DestinationBuildingId.Equals(input.DestinationBuildingId))
                ) && 
                (
                    this.DestinationLocation == input.DestinationLocation ||
                    (this.DestinationLocation != null &&
                    this.DestinationLocation.Equals(input.DestinationLocation))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.PriorityCode == input.PriorityCode ||
                    (this.PriorityCode != null &&
                    this.PriorityCode.Equals(input.PriorityCode))
                ) && 
                (
                    this.UserDefinedMessage == input.UserDefinedMessage ||
                    (this.UserDefinedMessage != null &&
                    this.UserDefinedMessage.Equals(input.UserDefinedMessage))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.WorkBatchId == input.WorkBatchId ||
                    (this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(input.WorkBatchId))
                ) && 
                (
                    this.WorkProductList == input.WorkProductList ||
                    this.WorkProductList != null &&
                    this.WorkProductList.SequenceEqual(input.WorkProductList)
                ) && 
                (
                    this.FulfillmentProcessId == input.FulfillmentProcessId ||
                    (this.FulfillmentProcessId != null &&
                    this.FulfillmentProcessId.Equals(input.FulfillmentProcessId))
                ) && 
                (
                    this.PickLineId == input.PickLineId ||
                    (this.PickLineId != null &&
                    this.PickLineId.Equals(input.PickLineId))
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
                if (this.SourceWarehouseId != null)
                    hashCode = hashCode * 59 + this.SourceWarehouseId.GetHashCode();
                if (this.SourceBuildingId != null)
                    hashCode = hashCode * 59 + this.SourceBuildingId.GetHashCode();
                if (this.SourceLocation != null)
                    hashCode = hashCode * 59 + this.SourceLocation.GetHashCode();
                if (this.DestinationWarehouseId != null)
                    hashCode = hashCode * 59 + this.DestinationWarehouseId.GetHashCode();
                if (this.DestinationBuildingId != null)
                    hashCode = hashCode * 59 + this.DestinationBuildingId.GetHashCode();
                if (this.DestinationLocation != null)
                    hashCode = hashCode * 59 + this.DestinationLocation.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.PriorityCode != null)
                    hashCode = hashCode * 59 + this.PriorityCode.GetHashCode();
                if (this.UserDefinedMessage != null)
                    hashCode = hashCode * 59 + this.UserDefinedMessage.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.WorkBatchId != null)
                    hashCode = hashCode * 59 + this.WorkBatchId.GetHashCode();
                if (this.WorkProductList != null)
                    hashCode = hashCode * 59 + this.WorkProductList.GetHashCode();
                if (this.FulfillmentProcessId != null)
                    hashCode = hashCode * 59 + this.FulfillmentProcessId.GetHashCode();
                if (this.PickLineId != null)
                    hashCode = hashCode * 59 + this.PickLineId.GetHashCode();
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
