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
    public partial class OrderSource :  IEquatable<OrderSource>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSource" /> class.
        /// Initializes a new instance of the <see cref="OrderSource" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="PackingNotes">PackingNotes.</param>
        /// <param name="RequireCartonizedASN">RequireCartonizedASN (default to false).</param>
        /// <param name="RequireGS1128Label">RequireGS1128Label (default to false).</param>
        /// <param name="ShippingNotes">ShippingNotes.</param>
        /// <param name="PackingSlipId">PackingSlipId.</param>
        /// <param name="OrderConfirmationEmailId">OrderConfirmationEmailId.</param>
        /// <param name="ShipmentConfirmationEmailId">ShipmentConfirmationEmailId.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public OrderSource(int? LobId = null, string Name = null, string PackingNotes = null, bool? RequireCartonizedASN = null, bool? RequireGS1128Label = null, string ShippingNotes = null, int? PackingSlipId = null, int? OrderConfirmationEmailId = null, int? ShipmentConfirmationEmailId = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for OrderSource and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for OrderSource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.PackingNotes = PackingNotes;
            // use default value if no "RequireCartonizedASN" provided
            if (RequireCartonizedASN == null)
            {
                this.RequireCartonizedASN = false;
            }
            else
            {
                this.RequireCartonizedASN = RequireCartonizedASN;
            }
            // use default value if no "RequireGS1128Label" provided
            if (RequireGS1128Label == null)
            {
                this.RequireGS1128Label = false;
            }
            else
            {
                this.RequireGS1128Label = RequireGS1128Label;
            }
            this.ShippingNotes = ShippingNotes;
            this.PackingSlipId = PackingSlipId;
            this.OrderConfirmationEmailId = OrderConfirmationEmailId;
            this.ShipmentConfirmationEmailId = ShipmentConfirmationEmailId;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
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
        /// Gets or Sets PackingNotes
        /// </summary>
        [DataMember(Name="packingNotes", EmitDefaultValue=false)]
        public string PackingNotes { get; set; }
    
        /// <summary>
        /// Gets or Sets RequireCartonizedASN
        /// </summary>
        [DataMember(Name="requireCartonizedASN", EmitDefaultValue=false)]
        public bool? RequireCartonizedASN { get; set; }
    
        /// <summary>
        /// Gets or Sets RequireGS1128Label
        /// </summary>
        [DataMember(Name="requireGS1128Label", EmitDefaultValue=false)]
        public bool? RequireGS1128Label { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippingNotes
        /// </summary>
        [DataMember(Name="shippingNotes", EmitDefaultValue=false)]
        public string ShippingNotes { get; set; }
    
        /// <summary>
        /// Gets or Sets PackingSlipId
        /// </summary>
        [DataMember(Name="packingSlipId", EmitDefaultValue=false)]
        public int? PackingSlipId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderConfirmationEmailId
        /// </summary>
        [DataMember(Name="orderConfirmationEmailId", EmitDefaultValue=false)]
        public int? OrderConfirmationEmailId { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipmentConfirmationEmailId
        /// </summary>
        [DataMember(Name="shipmentConfirmationEmailId", EmitDefaultValue=false)]
        public int? ShipmentConfirmationEmailId { get; set; }
    
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
            sb.Append("class OrderSource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  PackingNotes: ").Append(PackingNotes).Append("\n");
            sb.Append("  RequireCartonizedASN: ").Append(RequireCartonizedASN).Append("\n");
            sb.Append("  RequireGS1128Label: ").Append(RequireGS1128Label).Append("\n");
            sb.Append("  ShippingNotes: ").Append(ShippingNotes).Append("\n");
            sb.Append("  PackingSlipId: ").Append(PackingSlipId).Append("\n");
            sb.Append("  OrderConfirmationEmailId: ").Append(OrderConfirmationEmailId).Append("\n");
            sb.Append("  ShipmentConfirmationEmailId: ").Append(ShipmentConfirmationEmailId).Append("\n");
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
            return this.Equals(obj as OrderSource);
        }

        /// <summary>
        /// Returns true if OrderSource instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderSource other)
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
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.PackingNotes == other.PackingNotes ||
                    this.PackingNotes != null &&
                    this.PackingNotes.Equals(other.PackingNotes)
                ) && 
                (
                    this.RequireCartonizedASN == other.RequireCartonizedASN ||
                    this.RequireCartonizedASN != null &&
                    this.RequireCartonizedASN.Equals(other.RequireCartonizedASN)
                ) && 
                (
                    this.RequireGS1128Label == other.RequireGS1128Label ||
                    this.RequireGS1128Label != null &&
                    this.RequireGS1128Label.Equals(other.RequireGS1128Label)
                ) && 
                (
                    this.ShippingNotes == other.ShippingNotes ||
                    this.ShippingNotes != null &&
                    this.ShippingNotes.Equals(other.ShippingNotes)
                ) && 
                (
                    this.PackingSlipId == other.PackingSlipId ||
                    this.PackingSlipId != null &&
                    this.PackingSlipId.Equals(other.PackingSlipId)
                ) && 
                (
                    this.OrderConfirmationEmailId == other.OrderConfirmationEmailId ||
                    this.OrderConfirmationEmailId != null &&
                    this.OrderConfirmationEmailId.Equals(other.OrderConfirmationEmailId)
                ) && 
                (
                    this.ShipmentConfirmationEmailId == other.ShipmentConfirmationEmailId ||
                    this.ShipmentConfirmationEmailId != null &&
                    this.ShipmentConfirmationEmailId.Equals(other.ShipmentConfirmationEmailId)
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
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.PackingNotes != null)
                    hash = hash * 59 + this.PackingNotes.GetHashCode();
                
                if (this.RequireCartonizedASN != null)
                    hash = hash * 59 + this.RequireCartonizedASN.GetHashCode();
                
                if (this.RequireGS1128Label != null)
                    hash = hash * 59 + this.RequireGS1128Label.GetHashCode();
                
                if (this.ShippingNotes != null)
                    hash = hash * 59 + this.ShippingNotes.GetHashCode();
                
                if (this.PackingSlipId != null)
                    hash = hash * 59 + this.PackingSlipId.GetHashCode();
                
                if (this.OrderConfirmationEmailId != null)
                    hash = hash * 59 + this.OrderConfirmationEmailId.GetHashCode();
                
                if (this.ShipmentConfirmationEmailId != null)
                    hash = hash * 59 + this.ShipmentConfirmationEmailId.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
