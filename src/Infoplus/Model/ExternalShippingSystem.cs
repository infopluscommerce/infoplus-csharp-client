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
    /// ExternalShippingSystem
    /// </summary>
    [DataContract]
    public partial class ExternalShippingSystem :  IEquatable<ExternalShippingSystem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShippingSystem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalShippingSystem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShippingSystem" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="SystemType">SystemType (required).</param>
        /// <param name="ScriptId">ScriptId.</param>
        /// <param name="ApiKey">ApiKey (required).</param>
        /// <param name="ApiSecret">ApiSecret (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public ExternalShippingSystem(string Name = default(string), string SystemType = default(string), int? ScriptId = default(int?), string ApiKey = default(string), string ApiSecret = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ExternalShippingSystem and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "SystemType" is required (not null)
            if (SystemType == null)
            {
                throw new InvalidDataException("SystemType is a required property for ExternalShippingSystem and cannot be null");
            }
            else
            {
                this.SystemType = SystemType;
            }
            // to ensure "ApiKey" is required (not null)
            if (ApiKey == null)
            {
                throw new InvalidDataException("ApiKey is a required property for ExternalShippingSystem and cannot be null");
            }
            else
            {
                this.ApiKey = ApiKey;
            }
            // to ensure "ApiSecret" is required (not null)
            if (ApiSecret == null)
            {
                throw new InvalidDataException("ApiSecret is a required property for ExternalShippingSystem and cannot be null");
            }
            else
            {
                this.ApiSecret = ApiSecret;
            }
            this.ScriptId = ScriptId;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SystemType
        /// </summary>
        [DataMember(Name="systemType", EmitDefaultValue=false)]
        public string SystemType { get; set; }

        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public int? ScriptId { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets ApiSecret
        /// </summary>
        [DataMember(Name="apiSecret", EmitDefaultValue=false)]
        public string ApiSecret { get; set; }

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
            sb.Append("class ExternalShippingSystem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SystemType: ").Append(SystemType).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  ApiSecret: ").Append(ApiSecret).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalShippingSystem);
        }

        /// <summary>
        /// Returns true if ExternalShippingSystem instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalShippingSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalShippingSystem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SystemType == input.SystemType ||
                    (this.SystemType != null &&
                    this.SystemType.Equals(input.SystemType))
                ) && 
                (
                    this.ScriptId == input.ScriptId ||
                    (this.ScriptId != null &&
                    this.ScriptId.Equals(input.ScriptId))
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.ApiSecret == input.ApiSecret ||
                    (this.ApiSecret != null &&
                    this.ApiSecret.Equals(input.ApiSecret))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SystemType != null)
                    hashCode = hashCode * 59 + this.SystemType.GetHashCode();
                if (this.ScriptId != null)
                    hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.ApiSecret != null)
                    hashCode = hashCode * 59 + this.ApiSecret.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
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
