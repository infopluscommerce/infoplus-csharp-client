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
    public partial class Shipment :  IEquatable<Shipment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// Initializes a new instance of the <see cref="Shipment" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="CartonNo">CartonNo.</param>
        /// <param name="NumberOfCartons">NumberOfCartons.</param>
        /// <param name="Shipped">Shipped (default to false).</param>
        /// <param name="CarrierServiceId">CarrierServiceId.</param>
        /// <param name="Dim1In">Dim1In.</param>
        /// <param name="Dim2In">Dim2In.</param>
        /// <param name="Dim3In">Dim3In.</param>
        /// <param name="EstimatedZone">EstimatedZone.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public Shipment(int? Id = null, int? WarehouseId = null, int? CartonNo = null, int? NumberOfCartons = null, bool? Shipped = null, int? CarrierServiceId = null, double? Dim1In = null, double? Dim2In = null, double? Dim3In = null, string EstimatedZone = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for Shipment and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            this.Id = Id;
            this.CartonNo = CartonNo;
            this.NumberOfCartons = NumberOfCartons;
            // use default value if no "Shipped" provided
            if (Shipped == null)
            {
                this.Shipped = false;
            }
            else
            {
                this.Shipped = Shipped;
            }
            this.CarrierServiceId = CarrierServiceId;
            this.Dim1In = Dim1In;
            this.Dim2In = Dim2In;
            this.Dim3In = Dim3In;
            this.EstimatedZone = EstimatedZone;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
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
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets DeliveredDate
        /// </summary>
        [DataMember(Name="deliveredDate", EmitDefaultValue=false)]
        public DateTime? DeliveredDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets TrackingNo
        /// </summary>
        [DataMember(Name="trackingNo", EmitDefaultValue=false)]
        public string TrackingNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; private set; }
    
        /// <summary>
        /// Gets or Sets OrderNo
        /// </summary>
        [DataMember(Name="orderNo", EmitDefaultValue=false)]
        public double? OrderNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets CartonNo
        /// </summary>
        [DataMember(Name="cartonNo", EmitDefaultValue=false)]
        public int? CartonNo { get; set; }
    
        /// <summary>
        /// Gets or Sets NumberOfCartons
        /// </summary>
        [DataMember(Name="numberOfCartons", EmitDefaultValue=false)]
        public int? NumberOfCartons { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
        /// <summary>
        /// Gets or Sets Shipped
        /// </summary>
        [DataMember(Name="shipped", EmitDefaultValue=false)]
        public bool? Shipped { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierServiceId
        /// </summary>
        [DataMember(Name="carrierServiceId", EmitDefaultValue=false)]
        public int? CarrierServiceId { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim1In
        /// </summary>
        [DataMember(Name="dim1In", EmitDefaultValue=false)]
        public double? Dim1In { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim2In
        /// </summary>
        [DataMember(Name="dim2In", EmitDefaultValue=false)]
        public double? Dim2In { get; set; }
    
        /// <summary>
        /// Gets or Sets Dim3In
        /// </summary>
        [DataMember(Name="dim3In", EmitDefaultValue=false)]
        public double? Dim3In { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedZone
        /// </summary>
        [DataMember(Name="estimatedZone", EmitDefaultValue=false)]
        public string EstimatedZone { get; set; }
    
        /// <summary>
        /// Gets or Sets ParcelAccountNo
        /// </summary>
        [DataMember(Name="parcelAccountNo", EmitDefaultValue=false)]
        public string ParcelAccountNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyParcelAccountNo
        /// </summary>
        [DataMember(Name="thirdPartyParcelAccountNo", EmitDefaultValue=false)]
        public string ThirdPartyParcelAccountNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets ManifestId
        /// </summary>
        [DataMember(Name="manifestId", EmitDefaultValue=false)]
        public int? ManifestId { get; private set; }
    
        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        [DataMember(Name="residential", EmitDefaultValue=false)]
        public bool? Residential { get; private set; }
    
        /// <summary>
        /// Gets or Sets BillingOption
        /// </summary>
        [DataMember(Name="billingOption", EmitDefaultValue=false)]
        public string BillingOption { get; private set; }
    
        /// <summary>
        /// Gets or Sets WeightLbs
        /// </summary>
        [DataMember(Name="weightLbs", EmitDefaultValue=false)]
        public double? WeightLbs { get; private set; }
    
        /// <summary>
        /// Gets or Sets DimWeight
        /// </summary>
        [DataMember(Name="dimWeight", EmitDefaultValue=false)]
        public double? DimWeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets LicensePlateNumber
        /// </summary>
        [DataMember(Name="licensePlateNumber", EmitDefaultValue=false)]
        public string LicensePlateNumber { get; private set; }
    
        /// <summary>
        /// Gets or Sets ChargedFreightAmount
        /// </summary>
        [DataMember(Name="chargedFreightAmount", EmitDefaultValue=false)]
        public double? ChargedFreightAmount { get; private set; }
    
        /// <summary>
        /// Gets or Sets PublishedFreightAmount
        /// </summary>
        [DataMember(Name="publishedFreightAmount", EmitDefaultValue=false)]
        public double? PublishedFreightAmount { get; private set; }
    
        /// <summary>
        /// Gets or Sets RetailFreightAmount
        /// </summary>
        [DataMember(Name="retailFreightAmount", EmitDefaultValue=false)]
        public double? RetailFreightAmount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExternalShippingSystemId
        /// </summary>
        [DataMember(Name="externalShippingSystemId", EmitDefaultValue=false)]
        public int? ExternalShippingSystemId { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipmentType
        /// </summary>
        [DataMember(Name="shipmentType", EmitDefaultValue=false)]
        public string ShipmentType { get; private set; }
    
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
            sb.Append("class Shipment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  DeliveredDate: ").Append(DeliveredDate).Append("\n");
            sb.Append("  TrackingNo: ").Append(TrackingNo).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  CartonNo: ").Append(CartonNo).Append("\n");
            sb.Append("  NumberOfCartons: ").Append(NumberOfCartons).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Shipped: ").Append(Shipped).Append("\n");
            sb.Append("  CarrierServiceId: ").Append(CarrierServiceId).Append("\n");
            sb.Append("  Dim1In: ").Append(Dim1In).Append("\n");
            sb.Append("  Dim2In: ").Append(Dim2In).Append("\n");
            sb.Append("  Dim3In: ").Append(Dim3In).Append("\n");
            sb.Append("  EstimatedZone: ").Append(EstimatedZone).Append("\n");
            sb.Append("  ParcelAccountNo: ").Append(ParcelAccountNo).Append("\n");
            sb.Append("  ThirdPartyParcelAccountNo: ").Append(ThirdPartyParcelAccountNo).Append("\n");
            sb.Append("  ManifestId: ").Append(ManifestId).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
            sb.Append("  BillingOption: ").Append(BillingOption).Append("\n");
            sb.Append("  WeightLbs: ").Append(WeightLbs).Append("\n");
            sb.Append("  DimWeight: ").Append(DimWeight).Append("\n");
            sb.Append("  LicensePlateNumber: ").Append(LicensePlateNumber).Append("\n");
            sb.Append("  ChargedFreightAmount: ").Append(ChargedFreightAmount).Append("\n");
            sb.Append("  PublishedFreightAmount: ").Append(PublishedFreightAmount).Append("\n");
            sb.Append("  RetailFreightAmount: ").Append(RetailFreightAmount).Append("\n");
            sb.Append("  ExternalShippingSystemId: ").Append(ExternalShippingSystemId).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
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
            return this.Equals(obj as Shipment);
        }

        /// <summary>
        /// Returns true if Shipment instances are equal
        /// </summary>
        /// <param name="other">Instance of Shipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shipment other)
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
                    this.ShipDate == other.ShipDate ||
                    this.ShipDate != null &&
                    this.ShipDate.Equals(other.ShipDate)
                ) && 
                (
                    this.DeliveredDate == other.DeliveredDate ||
                    this.DeliveredDate != null &&
                    this.DeliveredDate.Equals(other.DeliveredDate)
                ) && 
                (
                    this.TrackingNo == other.TrackingNo ||
                    this.TrackingNo != null &&
                    this.TrackingNo.Equals(other.TrackingNo)
                ) && 
                (
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.OrderNo == other.OrderNo ||
                    this.OrderNo != null &&
                    this.OrderNo.Equals(other.OrderNo)
                ) && 
                (
                    this.CartonNo == other.CartonNo ||
                    this.CartonNo != null &&
                    this.CartonNo.Equals(other.CartonNo)
                ) && 
                (
                    this.NumberOfCartons == other.NumberOfCartons ||
                    this.NumberOfCartons != null &&
                    this.NumberOfCartons.Equals(other.NumberOfCartons)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Shipped == other.Shipped ||
                    this.Shipped != null &&
                    this.Shipped.Equals(other.Shipped)
                ) && 
                (
                    this.CarrierServiceId == other.CarrierServiceId ||
                    this.CarrierServiceId != null &&
                    this.CarrierServiceId.Equals(other.CarrierServiceId)
                ) && 
                (
                    this.Dim1In == other.Dim1In ||
                    this.Dim1In != null &&
                    this.Dim1In.Equals(other.Dim1In)
                ) && 
                (
                    this.Dim2In == other.Dim2In ||
                    this.Dim2In != null &&
                    this.Dim2In.Equals(other.Dim2In)
                ) && 
                (
                    this.Dim3In == other.Dim3In ||
                    this.Dim3In != null &&
                    this.Dim3In.Equals(other.Dim3In)
                ) && 
                (
                    this.EstimatedZone == other.EstimatedZone ||
                    this.EstimatedZone != null &&
                    this.EstimatedZone.Equals(other.EstimatedZone)
                ) && 
                (
                    this.ParcelAccountNo == other.ParcelAccountNo ||
                    this.ParcelAccountNo != null &&
                    this.ParcelAccountNo.Equals(other.ParcelAccountNo)
                ) && 
                (
                    this.ThirdPartyParcelAccountNo == other.ThirdPartyParcelAccountNo ||
                    this.ThirdPartyParcelAccountNo != null &&
                    this.ThirdPartyParcelAccountNo.Equals(other.ThirdPartyParcelAccountNo)
                ) && 
                (
                    this.ManifestId == other.ManifestId ||
                    this.ManifestId != null &&
                    this.ManifestId.Equals(other.ManifestId)
                ) && 
                (
                    this.Residential == other.Residential ||
                    this.Residential != null &&
                    this.Residential.Equals(other.Residential)
                ) && 
                (
                    this.BillingOption == other.BillingOption ||
                    this.BillingOption != null &&
                    this.BillingOption.Equals(other.BillingOption)
                ) && 
                (
                    this.WeightLbs == other.WeightLbs ||
                    this.WeightLbs != null &&
                    this.WeightLbs.Equals(other.WeightLbs)
                ) && 
                (
                    this.DimWeight == other.DimWeight ||
                    this.DimWeight != null &&
                    this.DimWeight.Equals(other.DimWeight)
                ) && 
                (
                    this.LicensePlateNumber == other.LicensePlateNumber ||
                    this.LicensePlateNumber != null &&
                    this.LicensePlateNumber.Equals(other.LicensePlateNumber)
                ) && 
                (
                    this.ChargedFreightAmount == other.ChargedFreightAmount ||
                    this.ChargedFreightAmount != null &&
                    this.ChargedFreightAmount.Equals(other.ChargedFreightAmount)
                ) && 
                (
                    this.PublishedFreightAmount == other.PublishedFreightAmount ||
                    this.PublishedFreightAmount != null &&
                    this.PublishedFreightAmount.Equals(other.PublishedFreightAmount)
                ) && 
                (
                    this.RetailFreightAmount == other.RetailFreightAmount ||
                    this.RetailFreightAmount != null &&
                    this.RetailFreightAmount.Equals(other.RetailFreightAmount)
                ) && 
                (
                    this.ExternalShippingSystemId == other.ExternalShippingSystemId ||
                    this.ExternalShippingSystemId != null &&
                    this.ExternalShippingSystemId.Equals(other.ExternalShippingSystemId)
                ) && 
                (
                    this.ShipmentType == other.ShipmentType ||
                    this.ShipmentType != null &&
                    this.ShipmentType.Equals(other.ShipmentType)
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
                
                if (this.ShipDate != null)
                    hash = hash * 59 + this.ShipDate.GetHashCode();
                
                if (this.DeliveredDate != null)
                    hash = hash * 59 + this.DeliveredDate.GetHashCode();
                
                if (this.TrackingNo != null)
                    hash = hash * 59 + this.TrackingNo.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.OrderNo != null)
                    hash = hash * 59 + this.OrderNo.GetHashCode();
                
                if (this.CartonNo != null)
                    hash = hash * 59 + this.CartonNo.GetHashCode();
                
                if (this.NumberOfCartons != null)
                    hash = hash * 59 + this.NumberOfCartons.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Shipped != null)
                    hash = hash * 59 + this.Shipped.GetHashCode();
                
                if (this.CarrierServiceId != null)
                    hash = hash * 59 + this.CarrierServiceId.GetHashCode();
                
                if (this.Dim1In != null)
                    hash = hash * 59 + this.Dim1In.GetHashCode();
                
                if (this.Dim2In != null)
                    hash = hash * 59 + this.Dim2In.GetHashCode();
                
                if (this.Dim3In != null)
                    hash = hash * 59 + this.Dim3In.GetHashCode();
                
                if (this.EstimatedZone != null)
                    hash = hash * 59 + this.EstimatedZone.GetHashCode();
                
                if (this.ParcelAccountNo != null)
                    hash = hash * 59 + this.ParcelAccountNo.GetHashCode();
                
                if (this.ThirdPartyParcelAccountNo != null)
                    hash = hash * 59 + this.ThirdPartyParcelAccountNo.GetHashCode();
                
                if (this.ManifestId != null)
                    hash = hash * 59 + this.ManifestId.GetHashCode();
                
                if (this.Residential != null)
                    hash = hash * 59 + this.Residential.GetHashCode();
                
                if (this.BillingOption != null)
                    hash = hash * 59 + this.BillingOption.GetHashCode();
                
                if (this.WeightLbs != null)
                    hash = hash * 59 + this.WeightLbs.GetHashCode();
                
                if (this.DimWeight != null)
                    hash = hash * 59 + this.DimWeight.GetHashCode();
                
                if (this.LicensePlateNumber != null)
                    hash = hash * 59 + this.LicensePlateNumber.GetHashCode();
                
                if (this.ChargedFreightAmount != null)
                    hash = hash * 59 + this.ChargedFreightAmount.GetHashCode();
                
                if (this.PublishedFreightAmount != null)
                    hash = hash * 59 + this.PublishedFreightAmount.GetHashCode();
                
                if (this.RetailFreightAmount != null)
                    hash = hash * 59 + this.RetailFreightAmount.GetHashCode();
                
                if (this.ExternalShippingSystemId != null)
                    hash = hash * 59 + this.ExternalShippingSystemId.GetHashCode();
                
                if (this.ShipmentType != null)
                    hash = hash * 59 + this.ShipmentType.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
