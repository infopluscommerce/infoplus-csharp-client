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
    /// CustomerInvoiceTemplate
    /// </summary>
    [DataContract]
    public partial class CustomerInvoiceTemplate :  IEquatable<CustomerInvoiceTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerInvoiceTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplate" /> class.
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
        /// <param name="LineItems">LineItems.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public CustomerInvoiceTemplate(string Name = default(string), string PoNo = default(string), string CostCenter = default(string), string Description = default(string), string Notes = default(string), string Terms = default(string), string SpecialInstructions = default(string), int? LobId = default(int?), string BillingPeriod = default(string), string RemitToAttention = default(string), string RemitToCompany = default(string), string RemitToStreet = default(string), string RemitToStreet2 = default(string), string RemitToStreet3 = default(string), string RemitToCity = default(string), string RemitToState = default(string), string RemitToZip = default(string), string RemitToCountry = default(string), string RemitToPhone = default(string), string RemitToEmail = default(string), string BillToAttention = default(string), string BillToCompany = default(string), string BillToStreet = default(string), string BillToStreet2 = default(string), string BillToStreet3 = default(string), string BillToCity = default(string), string BillToState = default(string), string BillToZip = default(string), string BillToCountry = default(string), string BillToPhone = default(string), string BillToEmail = default(string), List<CustomerInvoiceTemplateLine> LineItems = default(List<CustomerInvoiceTemplateLine>), Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
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
            this.LineItems = LineItems;
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
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<CustomerInvoiceTemplateLine> LineItems { get; set; }

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
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
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
            return this.Equals(input as CustomerInvoiceTemplate);
        }

        /// <summary>
        /// Returns true if CustomerInvoiceTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerInvoiceTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerInvoiceTemplate input)
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
                    this.PoNo == input.PoNo ||
                    (this.PoNo != null &&
                    this.PoNo.Equals(input.PoNo))
                ) && 
                (
                    this.CostCenter == input.CostCenter ||
                    (this.CostCenter != null &&
                    this.CostCenter.Equals(input.CostCenter))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && 
                (
                    this.SpecialInstructions == input.SpecialInstructions ||
                    (this.SpecialInstructions != null &&
                    this.SpecialInstructions.Equals(input.SpecialInstructions))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.BillingPeriod == input.BillingPeriod ||
                    (this.BillingPeriod != null &&
                    this.BillingPeriod.Equals(input.BillingPeriod))
                ) && 
                (
                    this.RemitToAttention == input.RemitToAttention ||
                    (this.RemitToAttention != null &&
                    this.RemitToAttention.Equals(input.RemitToAttention))
                ) && 
                (
                    this.RemitToCompany == input.RemitToCompany ||
                    (this.RemitToCompany != null &&
                    this.RemitToCompany.Equals(input.RemitToCompany))
                ) && 
                (
                    this.RemitToStreet == input.RemitToStreet ||
                    (this.RemitToStreet != null &&
                    this.RemitToStreet.Equals(input.RemitToStreet))
                ) && 
                (
                    this.RemitToStreet2 == input.RemitToStreet2 ||
                    (this.RemitToStreet2 != null &&
                    this.RemitToStreet2.Equals(input.RemitToStreet2))
                ) && 
                (
                    this.RemitToStreet3 == input.RemitToStreet3 ||
                    (this.RemitToStreet3 != null &&
                    this.RemitToStreet3.Equals(input.RemitToStreet3))
                ) && 
                (
                    this.RemitToCity == input.RemitToCity ||
                    (this.RemitToCity != null &&
                    this.RemitToCity.Equals(input.RemitToCity))
                ) && 
                (
                    this.RemitToState == input.RemitToState ||
                    (this.RemitToState != null &&
                    this.RemitToState.Equals(input.RemitToState))
                ) && 
                (
                    this.RemitToZip == input.RemitToZip ||
                    (this.RemitToZip != null &&
                    this.RemitToZip.Equals(input.RemitToZip))
                ) && 
                (
                    this.RemitToCountry == input.RemitToCountry ||
                    (this.RemitToCountry != null &&
                    this.RemitToCountry.Equals(input.RemitToCountry))
                ) && 
                (
                    this.RemitToPhone == input.RemitToPhone ||
                    (this.RemitToPhone != null &&
                    this.RemitToPhone.Equals(input.RemitToPhone))
                ) && 
                (
                    this.RemitToEmail == input.RemitToEmail ||
                    (this.RemitToEmail != null &&
                    this.RemitToEmail.Equals(input.RemitToEmail))
                ) && 
                (
                    this.BillToAttention == input.BillToAttention ||
                    (this.BillToAttention != null &&
                    this.BillToAttention.Equals(input.BillToAttention))
                ) && 
                (
                    this.BillToCompany == input.BillToCompany ||
                    (this.BillToCompany != null &&
                    this.BillToCompany.Equals(input.BillToCompany))
                ) && 
                (
                    this.BillToStreet == input.BillToStreet ||
                    (this.BillToStreet != null &&
                    this.BillToStreet.Equals(input.BillToStreet))
                ) && 
                (
                    this.BillToStreet2 == input.BillToStreet2 ||
                    (this.BillToStreet2 != null &&
                    this.BillToStreet2.Equals(input.BillToStreet2))
                ) && 
                (
                    this.BillToStreet3 == input.BillToStreet3 ||
                    (this.BillToStreet3 != null &&
                    this.BillToStreet3.Equals(input.BillToStreet3))
                ) && 
                (
                    this.BillToCity == input.BillToCity ||
                    (this.BillToCity != null &&
                    this.BillToCity.Equals(input.BillToCity))
                ) && 
                (
                    this.BillToState == input.BillToState ||
                    (this.BillToState != null &&
                    this.BillToState.Equals(input.BillToState))
                ) && 
                (
                    this.BillToZip == input.BillToZip ||
                    (this.BillToZip != null &&
                    this.BillToZip.Equals(input.BillToZip))
                ) && 
                (
                    this.BillToCountry == input.BillToCountry ||
                    (this.BillToCountry != null &&
                    this.BillToCountry.Equals(input.BillToCountry))
                ) && 
                (
                    this.BillToPhone == input.BillToPhone ||
                    (this.BillToPhone != null &&
                    this.BillToPhone.Equals(input.BillToPhone))
                ) && 
                (
                    this.BillToEmail == input.BillToEmail ||
                    (this.BillToEmail != null &&
                    this.BillToEmail.Equals(input.BillToEmail))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
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
                if (this.PoNo != null)
                    hashCode = hashCode * 59 + this.PoNo.GetHashCode();
                if (this.CostCenter != null)
                    hashCode = hashCode * 59 + this.CostCenter.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this.SpecialInstructions != null)
                    hashCode = hashCode * 59 + this.SpecialInstructions.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.BillingPeriod != null)
                    hashCode = hashCode * 59 + this.BillingPeriod.GetHashCode();
                if (this.RemitToAttention != null)
                    hashCode = hashCode * 59 + this.RemitToAttention.GetHashCode();
                if (this.RemitToCompany != null)
                    hashCode = hashCode * 59 + this.RemitToCompany.GetHashCode();
                if (this.RemitToStreet != null)
                    hashCode = hashCode * 59 + this.RemitToStreet.GetHashCode();
                if (this.RemitToStreet2 != null)
                    hashCode = hashCode * 59 + this.RemitToStreet2.GetHashCode();
                if (this.RemitToStreet3 != null)
                    hashCode = hashCode * 59 + this.RemitToStreet3.GetHashCode();
                if (this.RemitToCity != null)
                    hashCode = hashCode * 59 + this.RemitToCity.GetHashCode();
                if (this.RemitToState != null)
                    hashCode = hashCode * 59 + this.RemitToState.GetHashCode();
                if (this.RemitToZip != null)
                    hashCode = hashCode * 59 + this.RemitToZip.GetHashCode();
                if (this.RemitToCountry != null)
                    hashCode = hashCode * 59 + this.RemitToCountry.GetHashCode();
                if (this.RemitToPhone != null)
                    hashCode = hashCode * 59 + this.RemitToPhone.GetHashCode();
                if (this.RemitToEmail != null)
                    hashCode = hashCode * 59 + this.RemitToEmail.GetHashCode();
                if (this.BillToAttention != null)
                    hashCode = hashCode * 59 + this.BillToAttention.GetHashCode();
                if (this.BillToCompany != null)
                    hashCode = hashCode * 59 + this.BillToCompany.GetHashCode();
                if (this.BillToStreet != null)
                    hashCode = hashCode * 59 + this.BillToStreet.GetHashCode();
                if (this.BillToStreet2 != null)
                    hashCode = hashCode * 59 + this.BillToStreet2.GetHashCode();
                if (this.BillToStreet3 != null)
                    hashCode = hashCode * 59 + this.BillToStreet3.GetHashCode();
                if (this.BillToCity != null)
                    hashCode = hashCode * 59 + this.BillToCity.GetHashCode();
                if (this.BillToState != null)
                    hashCode = hashCode * 59 + this.BillToState.GetHashCode();
                if (this.BillToZip != null)
                    hashCode = hashCode * 59 + this.BillToZip.GetHashCode();
                if (this.BillToCountry != null)
                    hashCode = hashCode * 59 + this.BillToCountry.GetHashCode();
                if (this.BillToPhone != null)
                    hashCode = hashCode * 59 + this.BillToPhone.GetHashCode();
                if (this.BillToEmail != null)
                    hashCode = hashCode * 59 + this.BillToEmail.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
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
