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
    public partial class ParcelInvoice :  IEquatable<ParcelInvoice>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelInvoice" /> class.
        /// Initializes a new instance of the <see cref="ParcelInvoice" />class.
        /// </summary>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="InvoiceNo">InvoiceNo.</param>
        /// <param name="AccountNo">AccountNo.</param>
        /// <param name="InvoiceDate">InvoiceDate.</param>
        /// <param name="InvoiceAmount">InvoiceAmount.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ParcelInvoice(DateTime? CreateDate = null, DateTime? ModifyDate = null, string Carrier = null, string InvoiceNo = null, string AccountNo = null, DateTime? InvoiceDate = null, double? InvoiceAmount = null, Dictionary<string, Object> CustomFields = null)
        {
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            this.Carrier = Carrier;
            this.InvoiceNo = InvoiceNo;
            this.AccountNo = AccountNo;
            this.InvoiceDate = InvoiceDate;
            this.InvoiceAmount = InvoiceAmount;
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
        public DateTime? CreateDate { get; set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }
    
        /// <summary>
        /// Gets or Sets InvoiceNo
        /// </summary>
        [DataMember(Name="invoiceNo", EmitDefaultValue=false)]
        public string InvoiceNo { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountNo
        /// </summary>
        [DataMember(Name="accountNo", EmitDefaultValue=false)]
        public string AccountNo { get; set; }
    
        /// <summary>
        /// Gets or Sets InvoiceDate
        /// </summary>
        [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
        public DateTime? InvoiceDate { get; set; }
    
        /// <summary>
        /// Gets or Sets InvoiceAmount
        /// </summary>
        [DataMember(Name="invoiceAmount", EmitDefaultValue=false)]
        public double? InvoiceAmount { get; set; }
    
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
            sb.Append("class ParcelInvoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
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
            return this.Equals(obj as ParcelInvoice);
        }

        /// <summary>
        /// Returns true if ParcelInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of ParcelInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelInvoice other)
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
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.InvoiceNo == other.InvoiceNo ||
                    this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(other.InvoiceNo)
                ) && 
                (
                    this.AccountNo == other.AccountNo ||
                    this.AccountNo != null &&
                    this.AccountNo.Equals(other.AccountNo)
                ) && 
                (
                    this.InvoiceDate == other.InvoiceDate ||
                    this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(other.InvoiceDate)
                ) && 
                (
                    this.InvoiceAmount == other.InvoiceAmount ||
                    this.InvoiceAmount != null &&
                    this.InvoiceAmount.Equals(other.InvoiceAmount)
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
                
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                
                if (this.InvoiceNo != null)
                    hash = hash * 59 + this.InvoiceNo.GetHashCode();
                
                if (this.AccountNo != null)
                    hash = hash * 59 + this.AccountNo.GetHashCode();
                
                if (this.InvoiceDate != null)
                    hash = hash * 59 + this.InvoiceDate.GetHashCode();
                
                if (this.InvoiceAmount != null)
                    hash = hash * 59 + this.InvoiceAmount.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
