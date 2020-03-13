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
    /// InvoiceWorksheetLine
    /// </summary>
    [DataContract]
    public partial class InvoiceWorksheetLine :  IEquatable<InvoiceWorksheetLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceWorksheetLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceWorksheetLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceWorksheetLine" /> class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="SeqNo">SeqNo.</param>
        /// <param name="Description">Description.</param>
        /// <param name="AccountCode">AccountCode.</param>
        /// <param name="Department">Department.</param>
        /// <param name="ItemCode">ItemCode.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="ChargeRate">ChargeRate.</param>
        /// <param name="ExtendedCharge">ExtendedCharge.</param>
        /// <param name="BackupFile">BackupFile.</param>
        /// <param name="InvoiceWorksheetId">InvoiceWorksheetId (required).</param>
        /// <param name="InvoiceTemplateLineId">InvoiceTemplateLineId.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public InvoiceWorksheetLine(int? LobId = default(int?), int? SeqNo = default(int?), string Description = default(string), string AccountCode = default(string), string Department = default(string), string ItemCode = default(string), decimal? Quantity = default(decimal?), decimal? ChargeRate = default(decimal?), decimal? ExtendedCharge = default(decimal?), int? BackupFile = default(int?), int? InvoiceWorksheetId = default(int?), int? InvoiceTemplateLineId = default(int?), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for InvoiceWorksheetLine and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "InvoiceWorksheetId" is required (not null)
            if (InvoiceWorksheetId == null)
            {
                throw new InvalidDataException("InvoiceWorksheetId is a required property for InvoiceWorksheetLine and cannot be null");
            }
            else
            {
                this.InvoiceWorksheetId = InvoiceWorksheetId;
            }
            this.SeqNo = SeqNo;
            this.Description = Description;
            this.AccountCode = AccountCode;
            this.Department = Department;
            this.ItemCode = ItemCode;
            this.Quantity = Quantity;
            this.ChargeRate = ChargeRate;
            this.ExtendedCharge = ExtendedCharge;
            this.BackupFile = BackupFile;
            this.InvoiceTemplateLineId = InvoiceTemplateLineId;
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
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets SeqNo
        /// </summary>
        [DataMember(Name="seqNo", EmitDefaultValue=false)]
        public int? SeqNo { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AccountCode
        /// </summary>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets ItemCode
        /// </summary>
        [DataMember(Name="itemCode", EmitDefaultValue=false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ChargeRate
        /// </summary>
        [DataMember(Name="chargeRate", EmitDefaultValue=false)]
        public decimal? ChargeRate { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedCharge
        /// </summary>
        [DataMember(Name="extendedCharge", EmitDefaultValue=false)]
        public decimal? ExtendedCharge { get; set; }

        /// <summary>
        /// Gets or Sets BackupFile
        /// </summary>
        [DataMember(Name="backupFile", EmitDefaultValue=false)]
        public int? BackupFile { get; set; }

        /// <summary>
        /// Gets or Sets BackupDocument
        /// </summary>
        [DataMember(Name="backupDocument", EmitDefaultValue=false)]
        public string BackupDocument { get; private set; }

        /// <summary>
        /// Gets or Sets InvoiceWorksheetId
        /// </summary>
        [DataMember(Name="invoiceWorksheetId", EmitDefaultValue=false)]
        public int? InvoiceWorksheetId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceTemplateLineId
        /// </summary>
        [DataMember(Name="invoiceTemplateLineId", EmitDefaultValue=false)]
        public int? InvoiceTemplateLineId { get; set; }

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
            sb.Append("class InvoiceWorksheetLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  SeqNo: ").Append(SeqNo).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ChargeRate: ").Append(ChargeRate).Append("\n");
            sb.Append("  ExtendedCharge: ").Append(ExtendedCharge).Append("\n");
            sb.Append("  BackupFile: ").Append(BackupFile).Append("\n");
            sb.Append("  BackupDocument: ").Append(BackupDocument).Append("\n");
            sb.Append("  InvoiceWorksheetId: ").Append(InvoiceWorksheetId).Append("\n");
            sb.Append("  InvoiceTemplateLineId: ").Append(InvoiceTemplateLineId).Append("\n");
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
            return this.Equals(input as InvoiceWorksheetLine);
        }

        /// <summary>
        /// Returns true if InvoiceWorksheetLine instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceWorksheetLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceWorksheetLine input)
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
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.SeqNo == input.SeqNo ||
                    (this.SeqNo != null &&
                    this.SeqNo.Equals(input.SeqNo))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.ItemCode == input.ItemCode ||
                    (this.ItemCode != null &&
                    this.ItemCode.Equals(input.ItemCode))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.ChargeRate == input.ChargeRate ||
                    (this.ChargeRate != null &&
                    this.ChargeRate.Equals(input.ChargeRate))
                ) && 
                (
                    this.ExtendedCharge == input.ExtendedCharge ||
                    (this.ExtendedCharge != null &&
                    this.ExtendedCharge.Equals(input.ExtendedCharge))
                ) && 
                (
                    this.BackupFile == input.BackupFile ||
                    (this.BackupFile != null &&
                    this.BackupFile.Equals(input.BackupFile))
                ) && 
                (
                    this.BackupDocument == input.BackupDocument ||
                    (this.BackupDocument != null &&
                    this.BackupDocument.Equals(input.BackupDocument))
                ) && 
                (
                    this.InvoiceWorksheetId == input.InvoiceWorksheetId ||
                    (this.InvoiceWorksheetId != null &&
                    this.InvoiceWorksheetId.Equals(input.InvoiceWorksheetId))
                ) && 
                (
                    this.InvoiceTemplateLineId == input.InvoiceTemplateLineId ||
                    (this.InvoiceTemplateLineId != null &&
                    this.InvoiceTemplateLineId.Equals(input.InvoiceTemplateLineId))
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
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.SeqNo != null)
                    hashCode = hashCode * 59 + this.SeqNo.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.ItemCode != null)
                    hashCode = hashCode * 59 + this.ItemCode.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ChargeRate != null)
                    hashCode = hashCode * 59 + this.ChargeRate.GetHashCode();
                if (this.ExtendedCharge != null)
                    hashCode = hashCode * 59 + this.ExtendedCharge.GetHashCode();
                if (this.BackupFile != null)
                    hashCode = hashCode * 59 + this.BackupFile.GetHashCode();
                if (this.BackupDocument != null)
                    hashCode = hashCode * 59 + this.BackupDocument.GetHashCode();
                if (this.InvoiceWorksheetId != null)
                    hashCode = hashCode * 59 + this.InvoiceWorksheetId.GetHashCode();
                if (this.InvoiceTemplateLineId != null)
                    hashCode = hashCode * 59 + this.InvoiceTemplateLineId.GetHashCode();
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
