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
    public partial class JobTime :  IEquatable<JobTime>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTime" /> class.
        /// Initializes a new instance of the <see cref="JobTime" />class.
        /// </summary>
        /// <param name="SecondDuration">SecondDuration (required).</param>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="JobTypeId">JobTypeId (required).</param>
        /// <param name="Note">Note.</param>

        public JobTime(int? SecondDuration = null, int? UserId = null, int? LobId = null, int? JobTypeId = null, string Note = null)
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
            this.Note = Note;
            
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
        public DateTime? Date { get; private set; }
    
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
            return this.Equals(obj as JobTime);
        }

        /// <summary>
        /// Returns true if JobTime instances are equal
        /// </summary>
        /// <param name="other">Instance of JobTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobTime other)
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
                    this.SecondDuration == other.SecondDuration ||
                    this.SecondDuration != null &&
                    this.SecondDuration.Equals(other.SecondDuration)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.JobTypeId == other.JobTypeId ||
                    this.JobTypeId != null &&
                    this.JobTypeId.Equals(other.JobTypeId)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.SecondDuration != null)
                    hash = hash * 59 + this.SecondDuration.GetHashCode();
                
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.JobTypeId != null)
                    hash = hash * 59 + this.JobTypeId.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                
                return hash;
            }
        }

    }
}
