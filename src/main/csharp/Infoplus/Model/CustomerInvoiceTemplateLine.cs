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
    public partial class CustomerInvoiceTemplateLine :  IEquatable<CustomerInvoiceTemplateLine>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateLine" /> class.
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateLine" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="SeqNo">SeqNo.</param>
        /// <param name="AccountCode">AccountCode.</param>
        /// <param name="Active">Active (required) (default to false).</param>
        /// <param name="IncludeIfZero">IncludeIfZero (required) (default to false).</param>
        /// <param name="Department">Department.</param>
        /// <param name="ItemCode">ItemCode.</param>
        /// <param name="InvoiceTemplateId">InvoiceTemplateId.</param>
        /// <param name="BillingRuleId">BillingRuleId (required).</param>
        /// <param name="PriceLevelMode">PriceLevelMode (required).</param>
        /// <param name="ScriptId">ScriptId.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public CustomerInvoiceTemplateLine(int? LobId = null, string Description = null, int? SeqNo = null, string AccountCode = null, bool? Active = null, bool? IncludeIfZero = null, string Department = null, string ItemCode = null, int? InvoiceTemplateId = null, int? BillingRuleId = null, string PriceLevelMode = null, int? ScriptId = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.Active = Active;
            }
            // to ensure "IncludeIfZero" is required (not null)
            if (IncludeIfZero == null)
            {
                throw new InvalidDataException("IncludeIfZero is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.IncludeIfZero = IncludeIfZero;
            }
            // to ensure "BillingRuleId" is required (not null)
            if (BillingRuleId == null)
            {
                throw new InvalidDataException("BillingRuleId is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.BillingRuleId = BillingRuleId;
            }
            // to ensure "PriceLevelMode" is required (not null)
            if (PriceLevelMode == null)
            {
                throw new InvalidDataException("PriceLevelMode is a required property for CustomerInvoiceTemplateLine and cannot be null");
            }
            else
            {
                this.PriceLevelMode = PriceLevelMode;
            }
            this.Description = Description;
            this.SeqNo = SeqNo;
            this.AccountCode = AccountCode;
            this.Department = Department;
            this.ItemCode = ItemCode;
            this.InvoiceTemplateId = InvoiceTemplateId;
            this.ScriptId = ScriptId;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets SeqNo
        /// </summary>
        [DataMember(Name="seqNo", EmitDefaultValue=false)]
        public int? SeqNo { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountCode
        /// </summary>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
    
        /// <summary>
        /// Gets or Sets IncludeIfZero
        /// </summary>
        [DataMember(Name="includeIfZero", EmitDefaultValue=false)]
        public bool? IncludeIfZero { get; set; }
    
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
        /// Gets or Sets InvoiceTemplateId
        /// </summary>
        [DataMember(Name="invoiceTemplateId", EmitDefaultValue=false)]
        public int? InvoiceTemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingRuleId
        /// </summary>
        [DataMember(Name="billingRuleId", EmitDefaultValue=false)]
        public int? BillingRuleId { get; set; }
    
        /// <summary>
        /// Gets or Sets PriceLevelMode
        /// </summary>
        [DataMember(Name="priceLevelMode", EmitDefaultValue=false)]
        public string PriceLevelMode { get; set; }
    
        /// <summary>
        /// Gets or Sets ScriptId
        /// </summary>
        [DataMember(Name="scriptId", EmitDefaultValue=false)]
        public int? ScriptId { get; set; }
    
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
            sb.Append("class CustomerInvoiceTemplateLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SeqNo: ").Append(SeqNo).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  IncludeIfZero: ").Append(IncludeIfZero).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  InvoiceTemplateId: ").Append(InvoiceTemplateId).Append("\n");
            sb.Append("  BillingRuleId: ").Append(BillingRuleId).Append("\n");
            sb.Append("  PriceLevelMode: ").Append(PriceLevelMode).Append("\n");
            sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
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
            return this.Equals(obj as CustomerInvoiceTemplateLine);
        }

        /// <summary>
        /// Returns true if CustomerInvoiceTemplateLine instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerInvoiceTemplateLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerInvoiceTemplateLine other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.SeqNo == other.SeqNo ||
                    this.SeqNo != null &&
                    this.SeqNo.Equals(other.SeqNo)
                ) && 
                (
                    this.AccountCode == other.AccountCode ||
                    this.AccountCode != null &&
                    this.AccountCode.Equals(other.AccountCode)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.IncludeIfZero == other.IncludeIfZero ||
                    this.IncludeIfZero != null &&
                    this.IncludeIfZero.Equals(other.IncludeIfZero)
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
                    this.InvoiceTemplateId == other.InvoiceTemplateId ||
                    this.InvoiceTemplateId != null &&
                    this.InvoiceTemplateId.Equals(other.InvoiceTemplateId)
                ) && 
                (
                    this.BillingRuleId == other.BillingRuleId ||
                    this.BillingRuleId != null &&
                    this.BillingRuleId.Equals(other.BillingRuleId)
                ) && 
                (
                    this.PriceLevelMode == other.PriceLevelMode ||
                    this.PriceLevelMode != null &&
                    this.PriceLevelMode.Equals(other.PriceLevelMode)
                ) && 
                (
                    this.ScriptId == other.ScriptId ||
                    this.ScriptId != null &&
                    this.ScriptId.Equals(other.ScriptId)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.SeqNo != null)
                    hash = hash * 59 + this.SeqNo.GetHashCode();
                
                if (this.AccountCode != null)
                    hash = hash * 59 + this.AccountCode.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                if (this.IncludeIfZero != null)
                    hash = hash * 59 + this.IncludeIfZero.GetHashCode();
                
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                
                if (this.ItemCode != null)
                    hash = hash * 59 + this.ItemCode.GetHashCode();
                
                if (this.InvoiceTemplateId != null)
                    hash = hash * 59 + this.InvoiceTemplateId.GetHashCode();
                
                if (this.BillingRuleId != null)
                    hash = hash * 59 + this.BillingRuleId.GetHashCode();
                
                if (this.PriceLevelMode != null)
                    hash = hash * 59 + this.PriceLevelMode.GetHashCode();
                
                if (this.ScriptId != null)
                    hash = hash * 59 + this.ScriptId.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
