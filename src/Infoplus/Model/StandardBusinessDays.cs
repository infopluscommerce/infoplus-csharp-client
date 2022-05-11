/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v3.0
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
    /// StandardBusinessDays
    /// </summary>
    [DataContract]
    public partial class StandardBusinessDays :  IEquatable<StandardBusinessDays>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardBusinessDays" /> class.
        /// </summary>
        /// <param name="Sunday">Sunday (default to false).</param>
        /// <param name="Monday">Monday (default to false).</param>
        /// <param name="Tuesday">Tuesday (default to false).</param>
        /// <param name="Wednesday">Wednesday (default to false).</param>
        /// <param name="Thursday">Thursday (default to false).</param>
        /// <param name="Friday">Friday (default to false).</param>
        /// <param name="Saturday">Saturday (default to false).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public StandardBusinessDays(bool? Sunday = false, bool? Monday = false, bool? Tuesday = false, bool? Wednesday = false, bool? Thursday = false, bool? Friday = false, bool? Saturday = false, Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // use default value if no "Sunday" provided
            if (Sunday == null)
            {
                this.Sunday = false;
            }
            else
            {
                this.Sunday = Sunday;
            }
            // use default value if no "Monday" provided
            if (Monday == null)
            {
                this.Monday = false;
            }
            else
            {
                this.Monday = Monday;
            }
            // use default value if no "Tuesday" provided
            if (Tuesday == null)
            {
                this.Tuesday = false;
            }
            else
            {
                this.Tuesday = Tuesday;
            }
            // use default value if no "Wednesday" provided
            if (Wednesday == null)
            {
                this.Wednesday = false;
            }
            else
            {
                this.Wednesday = Wednesday;
            }
            // use default value if no "Thursday" provided
            if (Thursday == null)
            {
                this.Thursday = false;
            }
            else
            {
                this.Thursday = Thursday;
            }
            // use default value if no "Friday" provided
            if (Friday == null)
            {
                this.Friday = false;
            }
            else
            {
                this.Friday = Friday;
            }
            // use default value if no "Saturday" provided
            if (Saturday == null)
            {
                this.Saturday = false;
            }
            else
            {
                this.Saturday = Saturday;
            }
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Sunday
        /// </summary>
        [DataMember(Name="sunday", EmitDefaultValue=false)]
        public bool? Sunday { get; set; }

        /// <summary>
        /// Gets or Sets Monday
        /// </summary>
        [DataMember(Name="monday", EmitDefaultValue=false)]
        public bool? Monday { get; set; }

        /// <summary>
        /// Gets or Sets Tuesday
        /// </summary>
        [DataMember(Name="tuesday", EmitDefaultValue=false)]
        public bool? Tuesday { get; set; }

        /// <summary>
        /// Gets or Sets Wednesday
        /// </summary>
        [DataMember(Name="wednesday", EmitDefaultValue=false)]
        public bool? Wednesday { get; set; }

        /// <summary>
        /// Gets or Sets Thursday
        /// </summary>
        [DataMember(Name="thursday", EmitDefaultValue=false)]
        public bool? Thursday { get; set; }

        /// <summary>
        /// Gets or Sets Friday
        /// </summary>
        [DataMember(Name="friday", EmitDefaultValue=false)]
        public bool? Friday { get; set; }

        /// <summary>
        /// Gets or Sets Saturday
        /// </summary>
        [DataMember(Name="saturday", EmitDefaultValue=false)]
        public bool? Saturday { get; set; }

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
            sb.Append("class StandardBusinessDays {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sunday: ").Append(Sunday).Append("\n");
            sb.Append("  Monday: ").Append(Monday).Append("\n");
            sb.Append("  Tuesday: ").Append(Tuesday).Append("\n");
            sb.Append("  Wednesday: ").Append(Wednesday).Append("\n");
            sb.Append("  Thursday: ").Append(Thursday).Append("\n");
            sb.Append("  Friday: ").Append(Friday).Append("\n");
            sb.Append("  Saturday: ").Append(Saturday).Append("\n");
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
            return this.Equals(input as StandardBusinessDays);
        }

        /// <summary>
        /// Returns true if StandardBusinessDays instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardBusinessDays to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardBusinessDays input)
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
                    this.Sunday == input.Sunday ||
                    (this.Sunday != null &&
                    this.Sunday.Equals(input.Sunday))
                ) && 
                (
                    this.Monday == input.Monday ||
                    (this.Monday != null &&
                    this.Monday.Equals(input.Monday))
                ) && 
                (
                    this.Tuesday == input.Tuesday ||
                    (this.Tuesday != null &&
                    this.Tuesday.Equals(input.Tuesday))
                ) && 
                (
                    this.Wednesday == input.Wednesday ||
                    (this.Wednesday != null &&
                    this.Wednesday.Equals(input.Wednesday))
                ) && 
                (
                    this.Thursday == input.Thursday ||
                    (this.Thursday != null &&
                    this.Thursday.Equals(input.Thursday))
                ) && 
                (
                    this.Friday == input.Friday ||
                    (this.Friday != null &&
                    this.Friday.Equals(input.Friday))
                ) && 
                (
                    this.Saturday == input.Saturday ||
                    (this.Saturday != null &&
                    this.Saturday.Equals(input.Saturday))
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
                if (this.Sunday != null)
                    hashCode = hashCode * 59 + this.Sunday.GetHashCode();
                if (this.Monday != null)
                    hashCode = hashCode * 59 + this.Monday.GetHashCode();
                if (this.Tuesday != null)
                    hashCode = hashCode * 59 + this.Tuesday.GetHashCode();
                if (this.Wednesday != null)
                    hashCode = hashCode * 59 + this.Wednesday.GetHashCode();
                if (this.Thursday != null)
                    hashCode = hashCode * 59 + this.Thursday.GetHashCode();
                if (this.Friday != null)
                    hashCode = hashCode * 59 + this.Friday.GetHashCode();
                if (this.Saturday != null)
                    hashCode = hashCode * 59 + this.Saturday.GetHashCode();
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
