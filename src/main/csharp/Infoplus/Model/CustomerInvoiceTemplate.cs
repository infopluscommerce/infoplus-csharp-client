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
    public partial class CustomerInvoiceTemplate :  IEquatable<CustomerInvoiceTemplate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplate" /> class.
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplate" />class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="PoNo">PoNo.</param>
        /// <param name="CostCenter">CostCenter.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Terms">Terms.</param>
        /// <param name="SpecialInstructions">SpecialInstructions.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="BillingPeriod">BillingPeriod (required).</param>
        /// <param name="RemitToAttention">RemitToAttention.</param>
        /// <param name="RemitToCompany">RemitToCompany.</param>
        /// <param name="RemitToStreet">RemitToStreet.</param>
        /// <param name="RemitToStreet2">RemitToStreet2.</param>
        /// <param name="RemitToStreet3">RemitToStreet3.</param>
        /// <param name="RemitToCity">RemitToCity.</param>
        /// <param name="RemitToState">RemitToState.</param>
        /// <param name="RemitToZip">RemitToZip.</param>
        /// <param name="RemitToCountry">RemitToCountry.</param>
        /// <param name="RemitToPhone">RemitToPhone.</param>
        /// <param name="RemitToEmail">RemitToEmail.</param>
        /// <param name="BillToAttention">BillToAttention.</param>
        /// <param name="BillToCompany">BillToCompany.</param>
        /// <param name="BillToStreet">BillToStreet.</param>
        /// <param name="BillToStreet2">BillToStreet2.</param>
        /// <param name="BillToStreet3">BillToStreet3.</param>
        /// <param name="BillToCity">BillToCity.</param>
        /// <param name="BillToState">BillToState.</param>
        /// <param name="BillToZip">BillToZip.</param>
        /// <param name="BillToCountry">BillToCountry.</param>
        /// <param name="BillToPhone">BillToPhone.</param>
        /// <param name="BillToEmail">BillToEmail.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public CustomerInvoiceTemplate(string Name = null, string PoNo = null, string CostCenter = null, string Description = null, string Notes = null, string Terms = null, string SpecialInstructions = null, int? LobId = null, string BillingPeriod = null, string RemitToAttention = null, string RemitToCompany = null, string RemitToStreet = null, string RemitToStreet2 = null, string RemitToStreet3 = null, string RemitToCity = null, string RemitToState = null, string RemitToZip = null, string RemitToCountry = null, string RemitToPhone = null, string RemitToEmail = null, string BillToAttention = null, string BillToCompany = null, string BillToStreet = null, string BillToStreet2 = null, string BillToStreet3 = null, string BillToCity = null, string BillToState = null, string BillToZip = null, string BillToCountry = null, string BillToPhone = null, string BillToEmail = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CustomerInvoiceTemplate and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for CustomerInvoiceTemplate and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "BillingPeriod" is required (not null)
            if (BillingPeriod == null)
            {
                throw new InvalidDataException("BillingPeriod is a required property for CustomerInvoiceTemplate and cannot be null");
            }
            else
            {
                this.BillingPeriod = BillingPeriod;
            }
            this.PoNo = PoNo;
            this.CostCenter = CostCenter;
            this.Description = Description;
            this.Notes = Notes;
            this.Terms = Terms;
            this.SpecialInstructions = SpecialInstructions;
            this.RemitToAttention = RemitToAttention;
            this.RemitToCompany = RemitToCompany;
            this.RemitToStreet = RemitToStreet;
            this.RemitToStreet2 = RemitToStreet2;
            this.RemitToStreet3 = RemitToStreet3;
            this.RemitToCity = RemitToCity;
            this.RemitToState = RemitToState;
            this.RemitToZip = RemitToZip;
            this.RemitToCountry = RemitToCountry;
            this.RemitToPhone = RemitToPhone;
            this.RemitToEmail = RemitToEmail;
            this.BillToAttention = BillToAttention;
            this.BillToCompany = BillToCompany;
            this.BillToStreet = BillToStreet;
            this.BillToStreet2 = BillToStreet2;
            this.BillToStreet3 = BillToStreet3;
            this.BillToCity = BillToCity;
            this.BillToState = BillToState;
            this.BillToZip = BillToZip;
            this.BillToCountry = BillToCountry;
            this.BillToPhone = BillToPhone;
            this.BillToEmail = BillToEmail;
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
        /// Gets or Sets PoNo
        /// </summary>
        [DataMember(Name="poNo", EmitDefaultValue=false)]
        public string PoNo { get; set; }
    
        /// <summary>
        /// Gets or Sets CostCenter
        /// </summary>
        [DataMember(Name="costCenter", EmitDefaultValue=false)]
        public string CostCenter { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public string Terms { get; set; }
    
        /// <summary>
        /// Gets or Sets SpecialInstructions
        /// </summary>
        [DataMember(Name="specialInstructions", EmitDefaultValue=false)]
        public string SpecialInstructions { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingPeriod
        /// </summary>
        [DataMember(Name="billingPeriod", EmitDefaultValue=false)]
        public string BillingPeriod { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToAttention
        /// </summary>
        [DataMember(Name="remitToAttention", EmitDefaultValue=false)]
        public string RemitToAttention { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToCompany
        /// </summary>
        [DataMember(Name="remitToCompany", EmitDefaultValue=false)]
        public string RemitToCompany { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToStreet
        /// </summary>
        [DataMember(Name="remitToStreet", EmitDefaultValue=false)]
        public string RemitToStreet { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToStreet2
        /// </summary>
        [DataMember(Name="remitToStreet2", EmitDefaultValue=false)]
        public string RemitToStreet2 { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToStreet3
        /// </summary>
        [DataMember(Name="remitToStreet3", EmitDefaultValue=false)]
        public string RemitToStreet3 { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToCity
        /// </summary>
        [DataMember(Name="remitToCity", EmitDefaultValue=false)]
        public string RemitToCity { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToState
        /// </summary>
        [DataMember(Name="remitToState", EmitDefaultValue=false)]
        public string RemitToState { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToZip
        /// </summary>
        [DataMember(Name="remitToZip", EmitDefaultValue=false)]
        public string RemitToZip { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToCountry
        /// </summary>
        [DataMember(Name="remitToCountry", EmitDefaultValue=false)]
        public string RemitToCountry { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToPhone
        /// </summary>
        [DataMember(Name="remitToPhone", EmitDefaultValue=false)]
        public string RemitToPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets RemitToEmail
        /// </summary>
        [DataMember(Name="remitToEmail", EmitDefaultValue=false)]
        public string RemitToEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToAttention
        /// </summary>
        [DataMember(Name="billToAttention", EmitDefaultValue=false)]
        public string BillToAttention { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToCompany
        /// </summary>
        [DataMember(Name="billToCompany", EmitDefaultValue=false)]
        public string BillToCompany { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToStreet
        /// </summary>
        [DataMember(Name="billToStreet", EmitDefaultValue=false)]
        public string BillToStreet { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToStreet2
        /// </summary>
        [DataMember(Name="billToStreet2", EmitDefaultValue=false)]
        public string BillToStreet2 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToStreet3
        /// </summary>
        [DataMember(Name="billToStreet3", EmitDefaultValue=false)]
        public string BillToStreet3 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToCity
        /// </summary>
        [DataMember(Name="billToCity", EmitDefaultValue=false)]
        public string BillToCity { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToState
        /// </summary>
        [DataMember(Name="billToState", EmitDefaultValue=false)]
        public string BillToState { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToZip
        /// </summary>
        [DataMember(Name="billToZip", EmitDefaultValue=false)]
        public string BillToZip { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToCountry
        /// </summary>
        [DataMember(Name="billToCountry", EmitDefaultValue=false)]
        public string BillToCountry { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToPhone
        /// </summary>
        [DataMember(Name="billToPhone", EmitDefaultValue=false)]
        public string BillToPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets BillToEmail
        /// </summary>
        [DataMember(Name="billToEmail", EmitDefaultValue=false)]
        public string BillToEmail { get; set; }
    
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
            sb.Append("class CustomerInvoiceTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PoNo: ").Append(PoNo).Append("\n");
            sb.Append("  CostCenter: ").Append(CostCenter).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  SpecialInstructions: ").Append(SpecialInstructions).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
            sb.Append("  RemitToAttention: ").Append(RemitToAttention).Append("\n");
            sb.Append("  RemitToCompany: ").Append(RemitToCompany).Append("\n");
            sb.Append("  RemitToStreet: ").Append(RemitToStreet).Append("\n");
            sb.Append("  RemitToStreet2: ").Append(RemitToStreet2).Append("\n");
            sb.Append("  RemitToStreet3: ").Append(RemitToStreet3).Append("\n");
            sb.Append("  RemitToCity: ").Append(RemitToCity).Append("\n");
            sb.Append("  RemitToState: ").Append(RemitToState).Append("\n");
            sb.Append("  RemitToZip: ").Append(RemitToZip).Append("\n");
            sb.Append("  RemitToCountry: ").Append(RemitToCountry).Append("\n");
            sb.Append("  RemitToPhone: ").Append(RemitToPhone).Append("\n");
            sb.Append("  RemitToEmail: ").Append(RemitToEmail).Append("\n");
            sb.Append("  BillToAttention: ").Append(BillToAttention).Append("\n");
            sb.Append("  BillToCompany: ").Append(BillToCompany).Append("\n");
            sb.Append("  BillToStreet: ").Append(BillToStreet).Append("\n");
            sb.Append("  BillToStreet2: ").Append(BillToStreet2).Append("\n");
            sb.Append("  BillToStreet3: ").Append(BillToStreet3).Append("\n");
            sb.Append("  BillToCity: ").Append(BillToCity).Append("\n");
            sb.Append("  BillToState: ").Append(BillToState).Append("\n");
            sb.Append("  BillToZip: ").Append(BillToZip).Append("\n");
            sb.Append("  BillToCountry: ").Append(BillToCountry).Append("\n");
            sb.Append("  BillToPhone: ").Append(BillToPhone).Append("\n");
            sb.Append("  BillToEmail: ").Append(BillToEmail).Append("\n");
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
            return this.Equals(obj as CustomerInvoiceTemplate);
        }

        /// <summary>
        /// Returns true if CustomerInvoiceTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerInvoiceTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerInvoiceTemplate other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PoNo == other.PoNo ||
                    this.PoNo != null &&
                    this.PoNo.Equals(other.PoNo)
                ) && 
                (
                    this.CostCenter == other.CostCenter ||
                    this.CostCenter != null &&
                    this.CostCenter.Equals(other.CostCenter)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Terms == other.Terms ||
                    this.Terms != null &&
                    this.Terms.Equals(other.Terms)
                ) && 
                (
                    this.SpecialInstructions == other.SpecialInstructions ||
                    this.SpecialInstructions != null &&
                    this.SpecialInstructions.Equals(other.SpecialInstructions)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.BillingPeriod == other.BillingPeriod ||
                    this.BillingPeriod != null &&
                    this.BillingPeriod.Equals(other.BillingPeriod)
                ) && 
                (
                    this.RemitToAttention == other.RemitToAttention ||
                    this.RemitToAttention != null &&
                    this.RemitToAttention.Equals(other.RemitToAttention)
                ) && 
                (
                    this.RemitToCompany == other.RemitToCompany ||
                    this.RemitToCompany != null &&
                    this.RemitToCompany.Equals(other.RemitToCompany)
                ) && 
                (
                    this.RemitToStreet == other.RemitToStreet ||
                    this.RemitToStreet != null &&
                    this.RemitToStreet.Equals(other.RemitToStreet)
                ) && 
                (
                    this.RemitToStreet2 == other.RemitToStreet2 ||
                    this.RemitToStreet2 != null &&
                    this.RemitToStreet2.Equals(other.RemitToStreet2)
                ) && 
                (
                    this.RemitToStreet3 == other.RemitToStreet3 ||
                    this.RemitToStreet3 != null &&
                    this.RemitToStreet3.Equals(other.RemitToStreet3)
                ) && 
                (
                    this.RemitToCity == other.RemitToCity ||
                    this.RemitToCity != null &&
                    this.RemitToCity.Equals(other.RemitToCity)
                ) && 
                (
                    this.RemitToState == other.RemitToState ||
                    this.RemitToState != null &&
                    this.RemitToState.Equals(other.RemitToState)
                ) && 
                (
                    this.RemitToZip == other.RemitToZip ||
                    this.RemitToZip != null &&
                    this.RemitToZip.Equals(other.RemitToZip)
                ) && 
                (
                    this.RemitToCountry == other.RemitToCountry ||
                    this.RemitToCountry != null &&
                    this.RemitToCountry.Equals(other.RemitToCountry)
                ) && 
                (
                    this.RemitToPhone == other.RemitToPhone ||
                    this.RemitToPhone != null &&
                    this.RemitToPhone.Equals(other.RemitToPhone)
                ) && 
                (
                    this.RemitToEmail == other.RemitToEmail ||
                    this.RemitToEmail != null &&
                    this.RemitToEmail.Equals(other.RemitToEmail)
                ) && 
                (
                    this.BillToAttention == other.BillToAttention ||
                    this.BillToAttention != null &&
                    this.BillToAttention.Equals(other.BillToAttention)
                ) && 
                (
                    this.BillToCompany == other.BillToCompany ||
                    this.BillToCompany != null &&
                    this.BillToCompany.Equals(other.BillToCompany)
                ) && 
                (
                    this.BillToStreet == other.BillToStreet ||
                    this.BillToStreet != null &&
                    this.BillToStreet.Equals(other.BillToStreet)
                ) && 
                (
                    this.BillToStreet2 == other.BillToStreet2 ||
                    this.BillToStreet2 != null &&
                    this.BillToStreet2.Equals(other.BillToStreet2)
                ) && 
                (
                    this.BillToStreet3 == other.BillToStreet3 ||
                    this.BillToStreet3 != null &&
                    this.BillToStreet3.Equals(other.BillToStreet3)
                ) && 
                (
                    this.BillToCity == other.BillToCity ||
                    this.BillToCity != null &&
                    this.BillToCity.Equals(other.BillToCity)
                ) && 
                (
                    this.BillToState == other.BillToState ||
                    this.BillToState != null &&
                    this.BillToState.Equals(other.BillToState)
                ) && 
                (
                    this.BillToZip == other.BillToZip ||
                    this.BillToZip != null &&
                    this.BillToZip.Equals(other.BillToZip)
                ) && 
                (
                    this.BillToCountry == other.BillToCountry ||
                    this.BillToCountry != null &&
                    this.BillToCountry.Equals(other.BillToCountry)
                ) && 
                (
                    this.BillToPhone == other.BillToPhone ||
                    this.BillToPhone != null &&
                    this.BillToPhone.Equals(other.BillToPhone)
                ) && 
                (
                    this.BillToEmail == other.BillToEmail ||
                    this.BillToEmail != null &&
                    this.BillToEmail.Equals(other.BillToEmail)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.PoNo != null)
                    hash = hash * 59 + this.PoNo.GetHashCode();
                
                if (this.CostCenter != null)
                    hash = hash * 59 + this.CostCenter.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.Terms != null)
                    hash = hash * 59 + this.Terms.GetHashCode();
                
                if (this.SpecialInstructions != null)
                    hash = hash * 59 + this.SpecialInstructions.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.BillingPeriod != null)
                    hash = hash * 59 + this.BillingPeriod.GetHashCode();
                
                if (this.RemitToAttention != null)
                    hash = hash * 59 + this.RemitToAttention.GetHashCode();
                
                if (this.RemitToCompany != null)
                    hash = hash * 59 + this.RemitToCompany.GetHashCode();
                
                if (this.RemitToStreet != null)
                    hash = hash * 59 + this.RemitToStreet.GetHashCode();
                
                if (this.RemitToStreet2 != null)
                    hash = hash * 59 + this.RemitToStreet2.GetHashCode();
                
                if (this.RemitToStreet3 != null)
                    hash = hash * 59 + this.RemitToStreet3.GetHashCode();
                
                if (this.RemitToCity != null)
                    hash = hash * 59 + this.RemitToCity.GetHashCode();
                
                if (this.RemitToState != null)
                    hash = hash * 59 + this.RemitToState.GetHashCode();
                
                if (this.RemitToZip != null)
                    hash = hash * 59 + this.RemitToZip.GetHashCode();
                
                if (this.RemitToCountry != null)
                    hash = hash * 59 + this.RemitToCountry.GetHashCode();
                
                if (this.RemitToPhone != null)
                    hash = hash * 59 + this.RemitToPhone.GetHashCode();
                
                if (this.RemitToEmail != null)
                    hash = hash * 59 + this.RemitToEmail.GetHashCode();
                
                if (this.BillToAttention != null)
                    hash = hash * 59 + this.BillToAttention.GetHashCode();
                
                if (this.BillToCompany != null)
                    hash = hash * 59 + this.BillToCompany.GetHashCode();
                
                if (this.BillToStreet != null)
                    hash = hash * 59 + this.BillToStreet.GetHashCode();
                
                if (this.BillToStreet2 != null)
                    hash = hash * 59 + this.BillToStreet2.GetHashCode();
                
                if (this.BillToStreet3 != null)
                    hash = hash * 59 + this.BillToStreet3.GetHashCode();
                
                if (this.BillToCity != null)
                    hash = hash * 59 + this.BillToCity.GetHashCode();
                
                if (this.BillToState != null)
                    hash = hash * 59 + this.BillToState.GetHashCode();
                
                if (this.BillToZip != null)
                    hash = hash * 59 + this.BillToZip.GetHashCode();
                
                if (this.BillToCountry != null)
                    hash = hash * 59 + this.BillToCountry.GetHashCode();
                
                if (this.BillToPhone != null)
                    hash = hash * 59 + this.BillToPhone.GetHashCode();
                
                if (this.BillToEmail != null)
                    hash = hash * 59 + this.BillToEmail.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
