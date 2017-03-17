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
    public partial class ExternalShippingSystem :  IEquatable<ExternalShippingSystem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShippingSystem" /> class.
        /// Initializes a new instance of the <see cref="ExternalShippingSystem" />class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="SystemType">SystemType (required).</param>
        /// <param name="ApiKey">ApiKey (required).</param>
        /// <param name="ApiSecret">ApiSecret (required).</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ExternalShippingSystem(string Name = null, string SystemType = null, string ApiKey = null, string ApiSecret = null, Dictionary<string, Object> CustomFields = null)
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ExternalShippingSystem);
        }

        /// <summary>
        /// Returns true if ExternalShippingSystem instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalShippingSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalShippingSystem other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SystemType == other.SystemType ||
                    this.SystemType != null &&
                    this.SystemType.Equals(other.SystemType)
                ) && 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.ApiSecret == other.ApiSecret ||
                    this.ApiSecret != null &&
                    this.ApiSecret.Equals(other.ApiSecret)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.SystemType != null)
                    hash = hash * 59 + this.SystemType.GetHashCode();
                
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                
                if (this.ApiSecret != null)
                    hash = hash * 59 + this.ApiSecret.GetHashCode();
                
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
