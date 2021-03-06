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
    /// CustomField
    /// </summary>
    [DataContract]
    public partial class CustomField :  IEquatable<CustomField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Label">Label (required).</param>
        /// <param name="Enabled">Enabled (required) (default to false).</param>
        /// <param name="FieldType">FieldType (required).</param>
        /// <param name="Searchable">Searchable (required) (default to false).</param>
        /// <param name="Tooltip">Tooltip.</param>
        /// <param name="TabLabel">TabLabel (required).</param>
        /// <param name="RecordType">RecordType (required).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public CustomField(string Name = default(string), string Label = default(string), bool? Enabled = false, string FieldType = default(string), bool? Searchable = false, string Tooltip = default(string), string TabLabel = default(string), string RecordType = default(string), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CustomField and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for CustomField and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for CustomField and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            // to ensure "FieldType" is required (not null)
            if (FieldType == null)
            {
                throw new InvalidDataException("FieldType is a required property for CustomField and cannot be null");
            }
            else
            {
                this.FieldType = FieldType;
            }
            // to ensure "Searchable" is required (not null)
            if (Searchable == null)
            {
                throw new InvalidDataException("Searchable is a required property for CustomField and cannot be null");
            }
            else
            {
                this.Searchable = Searchable;
            }
            // to ensure "TabLabel" is required (not null)
            if (TabLabel == null)
            {
                throw new InvalidDataException("TabLabel is a required property for CustomField and cannot be null");
            }
            else
            {
                this.TabLabel = TabLabel;
            }
            // to ensure "RecordType" is required (not null)
            if (RecordType == null)
            {
                throw new InvalidDataException("RecordType is a required property for CustomField and cannot be null");
            }
            else
            {
                this.RecordType = RecordType;
            }
            this.Tooltip = Tooltip;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// Gets or Sets Searchable
        /// </summary>
        [DataMember(Name="searchable", EmitDefaultValue=false)]
        public bool? Searchable { get; set; }

        /// <summary>
        /// Gets or Sets Tooltip
        /// </summary>
        [DataMember(Name="tooltip", EmitDefaultValue=false)]
        public string Tooltip { get; set; }

        /// <summary>
        /// Gets or Sets TabLabel
        /// </summary>
        [DataMember(Name="tabLabel", EmitDefaultValue=false)]
        public string TabLabel { get; set; }

        /// <summary>
        /// Gets or Sets RecordType
        /// </summary>
        [DataMember(Name="recordType", EmitDefaultValue=false)]
        public string RecordType { get; set; }

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
            sb.Append("class CustomField {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  Searchable: ").Append(Searchable).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
            sb.Append("  TabLabel: ").Append(TabLabel).Append("\n");
            sb.Append("  RecordType: ").Append(RecordType).Append("\n");
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
            return this.Equals(input as CustomField);
        }

        /// <summary>
        /// Returns true if CustomField instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomField input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.Searchable == input.Searchable ||
                    (this.Searchable != null &&
                    this.Searchable.Equals(input.Searchable))
                ) && 
                (
                    this.Tooltip == input.Tooltip ||
                    (this.Tooltip != null &&
                    this.Tooltip.Equals(input.Tooltip))
                ) && 
                (
                    this.TabLabel == input.TabLabel ||
                    (this.TabLabel != null &&
                    this.TabLabel.Equals(input.TabLabel))
                ) && 
                (
                    this.RecordType == input.RecordType ||
                    (this.RecordType != null &&
                    this.RecordType.Equals(input.RecordType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.Searchable != null)
                    hashCode = hashCode * 59 + this.Searchable.GetHashCode();
                if (this.Tooltip != null)
                    hashCode = hashCode * 59 + this.Tooltip.GetHashCode();
                if (this.TabLabel != null)
                    hashCode = hashCode * 59 + this.TabLabel.GetHashCode();
                if (this.RecordType != null)
                    hashCode = hashCode * 59 + this.RecordType.GetHashCode();
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
