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
    public partial class ProcessOutputAPIModel :  IEquatable<ProcessOutputAPIModel>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessOutputAPIModel" /> class.
        /// Initializes a new instance of the <see cref="ProcessOutputAPIModel" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Status">Status.</param>
        /// <param name="MessageList">MessageList.</param>

        public ProcessOutputAPIModel(Object Id = null, string Status = null, List<string> MessageList = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.MessageList = MessageList;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Object Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets MessageList
        /// </summary>
        [DataMember(Name="messageList", EmitDefaultValue=false)]
        public List<string> MessageList { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessOutputAPIModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MessageList: ").Append(MessageList).Append("\n");
            
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
            return this.Equals(obj as ProcessOutputAPIModel);
        }

        /// <summary>
        /// Returns true if ProcessOutputAPIModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ProcessOutputAPIModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessOutputAPIModel other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.MessageList == other.MessageList ||
                    this.MessageList != null &&
                    this.MessageList.SequenceEqual(other.MessageList)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.MessageList != null)
                    hash = hash * 59 + this.MessageList.GetHashCode();
                
                return hash;
            }
        }

    }
}
