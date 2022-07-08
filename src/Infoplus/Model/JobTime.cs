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
    /// JobTime
    /// </summary>
    [DataContract]
    public partial class JobTime :  IEquatable<JobTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTime" /> class.
        /// </summary>
        /// <param name="SecondDuration">SecondDuration (required).</param>
        /// <param name="Date">Date.</param>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="JobTypeId">JobTypeId (required).</param>
        /// <param name="Note">Note.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public JobTime(int? SecondDuration = default(int?), DateTime? Date = default(DateTime?), int? UserId = default(int?), int? LobId = default(int?), int? JobTypeId = default(int?), string Note = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "SecondDuration" is required (not null)
            if (SecondDuration == null)
            {
                throw new InvalidDataException("SecondDuration is a required property for JobTime and cannot be null");
            }
            else
            {
                this.SecondDuration = SecondDuration;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for JobTime and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for JobTime and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "JobTypeId" is required (not null)
            if (JobTypeId == null)
            {
                throw new InvalidDataException("JobTypeId is a required property for JobTime and cannot be null");
            }
            else
            {
                this.JobTypeId = JobTypeId;
            }
            this.Date = Date;
            this.Note = Note;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

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
        /// Gets or Sets SecondDuration
        /// </summary>
        [DataMember(Name="secondDuration", EmitDefaultValue=false)]
        public int? SecondDuration { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets JobTypeId
        /// </summary>
        [DataMember(Name="jobTypeId", EmitDefaultValue=false)]
        public int? JobTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

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
            sb.Append("class JobTime {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  SecondDuration: ").Append(SecondDuration).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  JobTypeId: ").Append(JobTypeId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(input as JobTime);
        }

        /// <summary>
        /// Returns true if JobTime instances are equal
        /// </summary>
        /// <param name="input">Instance of JobTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTime input)
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
                    this.SecondDuration == input.SecondDuration ||
                    (this.SecondDuration != null &&
                    this.SecondDuration.Equals(input.SecondDuration))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                    this.JobTypeId == input.JobTypeId ||
                    (this.JobTypeId != null &&
                    this.JobTypeId.Equals(input.JobTypeId))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.SecondDuration != null)
                    hashCode = hashCode * 59 + this.SecondDuration.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.JobTypeId != null)
                    hashCode = hashCode * 59 + this.JobTypeId.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
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
