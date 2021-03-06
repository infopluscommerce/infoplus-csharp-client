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
    /// ProcessOutputAPIModel
    /// </summary>
    [DataContract]
    public partial class ProcessOutputAPIModel :  IEquatable<ProcessOutputAPIModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessOutputAPIModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="MessageList">MessageList.</param>
        public ProcessOutputAPIModel(Object Id = default(Object), string Status = default(string), Object Entity = default(Object), List<string> MessageList = default(List<string>))
        {
            this.Id = Id;
            this.Status = Status;
            this.Entity = Entity;
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
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Object Entity { get; set; }

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
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProcessOutputAPIModel);
        }

        /// <summary>
        /// Returns true if ProcessOutputAPIModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessOutputAPIModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessOutputAPIModel input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.MessageList == input.MessageList ||
                    this.MessageList != null &&
                    this.MessageList.SequenceEqual(input.MessageList)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.MessageList != null)
                    hashCode = hashCode * 59 + this.MessageList.GetHashCode();
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
