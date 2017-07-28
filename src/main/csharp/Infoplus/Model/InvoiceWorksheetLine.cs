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
    public partial class InvoiceWorksheetLine :  IEquatable<InvoiceWorksheetLine>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceWorksheetLine" /> class.
        /// Initializes a new instance of the <see cref="InvoiceWorksheetLine" />class.
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
        /// <param name="BackupFileUrl">BackupFileUrl.</param>
        /// <param name="InvoiceWorksheetId">InvoiceWorksheetId.</param>
        /// <param name="InvoiceTemplateLineId">InvoiceTemplateLineId.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public InvoiceWorksheetLine(int? LobId = null, int? SeqNo = null, string Description = null, string AccountCode = null, string Department = null, string ItemCode = null, double? Quantity = null, double? ChargeRate = null, double? ExtendedCharge = null, int? BackupFile = null, string BackupFileUrl = null, int? InvoiceWorksheetId = null, int? InvoiceTemplateLineId = null, Dictionary<string, Object> CustomFields = null)
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
            this.SeqNo = SeqNo;
            this.Description = Description;
            this.AccountCode = AccountCode;
            this.Department = Department;
            this.ItemCode = ItemCode;
            this.Quantity = Quantity;
            this.ChargeRate = ChargeRate;
            this.ExtendedCharge = ExtendedCharge;
            this.BackupFile = BackupFile;
            this.BackupFileUrl = BackupFileUrl;
            this.InvoiceWorksheetId = InvoiceWorksheetId;
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
        public double? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets ChargeRate
        /// </summary>
        [DataMember(Name="chargeRate", EmitDefaultValue=false)]
        public double? ChargeRate { get; set; }
    
        /// <summary>
        /// Gets or Sets ExtendedCharge
        /// </summary>
        [DataMember(Name="extendedCharge", EmitDefaultValue=false)]
        public double? ExtendedCharge { get; set; }
    
        /// <summary>
        /// Gets or Sets BackupFile
        /// </summary>
        [DataMember(Name="backupFile", EmitDefaultValue=false)]
        public int? BackupFile { get; set; }
    
        /// <summary>
        /// Gets or Sets BackupFileUrl
        /// </summary>
        [DataMember(Name="backupFileUrl", EmitDefaultValue=false)]
        public string BackupFileUrl { get; set; }
    
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
            sb.Append("  BackupFileUrl: ").Append(BackupFileUrl).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InvoiceWorksheetLine);
        }

        /// <summary>
        /// Returns true if InvoiceWorksheetLine instances are equal
        /// </summary>
        /// <param name="other">Instance of InvoiceWorksheetLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceWorksheetLine other)
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
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.SeqNo == other.SeqNo ||
                    this.SeqNo != null &&
                    this.SeqNo.Equals(other.SeqNo)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.AccountCode == other.AccountCode ||
                    this.AccountCode != null &&
                    this.AccountCode.Equals(other.AccountCode)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.ItemCode == other.ItemCode ||
                    this.ItemCode != null &&
                    this.ItemCode.Equals(other.ItemCode)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.ChargeRate == other.ChargeRate ||
                    this.ChargeRate != null &&
                    this.ChargeRate.Equals(other.ChargeRate)
                ) && 
                (
                    this.ExtendedCharge == other.ExtendedCharge ||
                    this.ExtendedCharge != null &&
                    this.ExtendedCharge.Equals(other.ExtendedCharge)
                ) && 
                (
                    this.BackupFile == other.BackupFile ||
                    this.BackupFile != null &&
                    this.BackupFile.Equals(other.BackupFile)
                ) && 
                (
                    this.BackupFileUrl == other.BackupFileUrl ||
                    this.BackupFileUrl != null &&
                    this.BackupFileUrl.Equals(other.BackupFileUrl)
                ) && 
                (
                    this.InvoiceWorksheetId == other.InvoiceWorksheetId ||
                    this.InvoiceWorksheetId != null &&
                    this.InvoiceWorksheetId.Equals(other.InvoiceWorksheetId)
                ) && 
                (
                    this.InvoiceTemplateLineId == other.InvoiceTemplateLineId ||
                    this.InvoiceTemplateLineId != null &&
                    this.InvoiceTemplateLineId.Equals(other.InvoiceTemplateLineId)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.SeqNo != null)
                    hash = hash * 59 + this.SeqNo.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.AccountCode != null)
                    hash = hash * 59 + this.AccountCode.GetHashCode();
                
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                
                if (this.ItemCode != null)
                    hash = hash * 59 + this.ItemCode.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.ChargeRate != null)
                    hash = hash * 59 + this.ChargeRate.GetHashCode();
                
                if (this.ExtendedCharge != null)
                    hash = hash * 59 + this.ExtendedCharge.GetHashCode();
                
                if (this.BackupFile != null)
                    hash = hash * 59 + this.BackupFile.GetHashCode();
                
                if (this.BackupFileUrl != null)
                    hash = hash * 59 + this.BackupFileUrl.GetHashCode();
                
                if (this.InvoiceWorksheetId != null)
                    hash = hash * 59 + this.InvoiceWorksheetId.GetHashCode();
                
                if (this.InvoiceTemplateLineId != null)
                    hash = hash * 59 + this.InvoiceTemplateLineId.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
