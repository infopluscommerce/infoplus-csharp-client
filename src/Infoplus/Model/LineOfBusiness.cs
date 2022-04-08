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
    /// LineOfBusiness
    /// </summary>
    [DataContract]
    public partial class LineOfBusiness :  IEquatable<LineOfBusiness>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineOfBusiness" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineOfBusiness() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineOfBusiness" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Code">Code (required).</param>
        /// <param name="Label">Label.</param>
        /// <param name="DefaultWarehouseServiceTypeId">DefaultWarehouseServiceTypeId.</param>
        /// <param name="DefaultSLAServiceDays">DefaultSLAServiceDays.</param>
        /// <param name="DefaultSLACutoffTime">DefaultSLACutoffTime.</param>
        /// <param name="OnHold">OnHold (default to false).</param>
        /// <param name="OnHoldReason">OnHoldReason.</param>
        /// <param name="Gs1CompanyPrefix">Gs1CompanyPrefix.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public LineOfBusiness(string Name = default(string), string Code = default(string), string Label = default(string), int? DefaultWarehouseServiceTypeId = default(int?), int? DefaultSLAServiceDays = default(int?), string DefaultSLACutoffTime = default(string), bool? OnHold = false, string OnHoldReason = default(string), string Gs1CompanyPrefix = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for LineOfBusiness and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for LineOfBusiness and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            this.Label = Label;
            this.DefaultWarehouseServiceTypeId = DefaultWarehouseServiceTypeId;
            this.DefaultSLAServiceDays = DefaultSLAServiceDays;
            this.DefaultSLACutoffTime = DefaultSLACutoffTime;
            // use default value if no "OnHold" provided
            if (OnHold == null)
            {
                this.OnHold = false;
            }
            else
            {
                this.OnHold = OnHold;
            }
            this.OnHoldReason = OnHoldReason;
            this.Gs1CompanyPrefix = Gs1CompanyPrefix;
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
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets DefaultWarehouseServiceTypeId
        /// </summary>
        [DataMember(Name="defaultWarehouseServiceTypeId", EmitDefaultValue=false)]
        public int? DefaultWarehouseServiceTypeId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSLAServiceDays
        /// </summary>
        [DataMember(Name="defaultSLAServiceDays", EmitDefaultValue=false)]
        public int? DefaultSLAServiceDays { get; set; }

        /// <summary>
        /// Gets or Sets DefaultSLACutoffTime
        /// </summary>
        [DataMember(Name="defaultSLACutoffTime", EmitDefaultValue=false)]
        public string DefaultSLACutoffTime { get; set; }

        /// <summary>
        /// Gets or Sets OnHold
        /// </summary>
        [DataMember(Name="onHold", EmitDefaultValue=false)]
        public bool? OnHold { get; set; }

        /// <summary>
        /// Gets or Sets OnHoldReason
        /// </summary>
        [DataMember(Name="onHoldReason", EmitDefaultValue=false)]
        public string OnHoldReason { get; set; }

        /// <summary>
        /// Gets or Sets Gs1CompanyPrefix
        /// </summary>
        [DataMember(Name="gs1CompanyPrefix", EmitDefaultValue=false)]
        public string Gs1CompanyPrefix { get; set; }

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
            sb.Append("class LineOfBusiness {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  DefaultWarehouseServiceTypeId: ").Append(DefaultWarehouseServiceTypeId).Append("\n");
            sb.Append("  DefaultSLAServiceDays: ").Append(DefaultSLAServiceDays).Append("\n");
            sb.Append("  DefaultSLACutoffTime: ").Append(DefaultSLACutoffTime).Append("\n");
            sb.Append("  OnHold: ").Append(OnHold).Append("\n");
            sb.Append("  OnHoldReason: ").Append(OnHoldReason).Append("\n");
            sb.Append("  Gs1CompanyPrefix: ").Append(Gs1CompanyPrefix).Append("\n");
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
            return this.Equals(input as LineOfBusiness);
        }

        /// <summary>
        /// Returns true if LineOfBusiness instances are equal
        /// </summary>
        /// <param name="input">Instance of LineOfBusiness to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineOfBusiness input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.DefaultWarehouseServiceTypeId == input.DefaultWarehouseServiceTypeId ||
                    (this.DefaultWarehouseServiceTypeId != null &&
                    this.DefaultWarehouseServiceTypeId.Equals(input.DefaultWarehouseServiceTypeId))
                ) && 
                (
                    this.DefaultSLAServiceDays == input.DefaultSLAServiceDays ||
                    (this.DefaultSLAServiceDays != null &&
                    this.DefaultSLAServiceDays.Equals(input.DefaultSLAServiceDays))
                ) && 
                (
                    this.DefaultSLACutoffTime == input.DefaultSLACutoffTime ||
                    (this.DefaultSLACutoffTime != null &&
                    this.DefaultSLACutoffTime.Equals(input.DefaultSLACutoffTime))
                ) && 
                (
                    this.OnHold == input.OnHold ||
                    (this.OnHold != null &&
                    this.OnHold.Equals(input.OnHold))
                ) && 
                (
                    this.OnHoldReason == input.OnHoldReason ||
                    (this.OnHoldReason != null &&
                    this.OnHoldReason.Equals(input.OnHoldReason))
                ) && 
                (
                    this.Gs1CompanyPrefix == input.Gs1CompanyPrefix ||
                    (this.Gs1CompanyPrefix != null &&
                    this.Gs1CompanyPrefix.Equals(input.Gs1CompanyPrefix))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.DefaultWarehouseServiceTypeId != null)
                    hashCode = hashCode * 59 + this.DefaultWarehouseServiceTypeId.GetHashCode();
                if (this.DefaultSLAServiceDays != null)
                    hashCode = hashCode * 59 + this.DefaultSLAServiceDays.GetHashCode();
                if (this.DefaultSLACutoffTime != null)
                    hashCode = hashCode * 59 + this.DefaultSLACutoffTime.GetHashCode();
                if (this.OnHold != null)
                    hashCode = hashCode * 59 + this.OnHold.GetHashCode();
                if (this.OnHoldReason != null)
                    hashCode = hashCode * 59 + this.OnHoldReason.GetHashCode();
                if (this.Gs1CompanyPrefix != null)
                    hashCode = hashCode * 59 + this.Gs1CompanyPrefix.GetHashCode();
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
