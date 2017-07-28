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
    public partial class ParcelInvoiceLine :  IEquatable<ParcelInvoiceLine>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelInvoiceLine" /> class.
        /// Initializes a new instance of the <see cref="ParcelInvoiceLine" />class.
        /// </summary>
        /// <param name="LobId">LobId.</param>
        /// <param name="OrderId">OrderId.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ParcelInvoiceLine(int? LobId = null, double? OrderId = null, Dictionary<string, Object> CustomFields = null)
        {
            this.LobId = LobId;
            this.OrderId = OrderId;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets InvoiceNoId
        /// </summary>
        [DataMember(Name="invoiceNoId", EmitDefaultValue=false)]
        public int? InvoiceNoId { get; private set; }
    
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
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public double? OrderId { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipmentId
        /// </summary>
        [DataMember(Name="shipmentId", EmitDefaultValue=false)]
        public int? ShipmentId { get; private set; }
    
        /// <summary>
        /// Gets or Sets TrackingNo
        /// </summary>
        [DataMember(Name="trackingNo", EmitDefaultValue=false)]
        public string TrackingNo { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="shipDate", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name="zone", EmitDefaultValue=false)]
        public string Zone { get; private set; }
    
        /// <summary>
        /// Gets or Sets Dim1
        /// </summary>
        [DataMember(Name="dim1", EmitDefaultValue=false)]
        public double? Dim1 { get; private set; }
    
        /// <summary>
        /// Gets or Sets Dim2
        /// </summary>
        [DataMember(Name="dim2", EmitDefaultValue=false)]
        public double? Dim2 { get; private set; }
    
        /// <summary>
        /// Gets or Sets Dim3
        /// </summary>
        [DataMember(Name="dim3", EmitDefaultValue=false)]
        public double? Dim3 { get; private set; }
    
        /// <summary>
        /// Gets or Sets EnteredWeight
        /// </summary>
        [DataMember(Name="enteredWeight", EmitDefaultValue=false)]
        public double? EnteredWeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets ActualWeight
        /// </summary>
        [DataMember(Name="actualWeight", EmitDefaultValue=false)]
        public double? ActualWeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets BilledWeight
        /// </summary>
        [DataMember(Name="billedWeight", EmitDefaultValue=false)]
        public double? BilledWeight { get; private set; }
    
        /// <summary>
        /// Gets or Sets EnteredWeightUnit
        /// </summary>
        [DataMember(Name="enteredWeightUnit", EmitDefaultValue=false)]
        public string EnteredWeightUnit { get; private set; }
    
        /// <summary>
        /// Gets or Sets ActualWeightUnit
        /// </summary>
        [DataMember(Name="actualWeightUnit", EmitDefaultValue=false)]
        public string ActualWeightUnit { get; private set; }
    
        /// <summary>
        /// Gets or Sets BilledWeightUnit
        /// </summary>
        [DataMember(Name="billedWeightUnit", EmitDefaultValue=false)]
        public string BilledWeightUnit { get; private set; }
    
        /// <summary>
        /// Gets or Sets CustomerReference
        /// </summary>
        [DataMember(Name="customerReference", EmitDefaultValue=false)]
        public string CustomerReference { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipmentReference
        /// </summary>
        [DataMember(Name="shipmentReference", EmitDefaultValue=false)]
        public string ShipmentReference { get; private set; }
    
        /// <summary>
        /// Gets or Sets Reference3
        /// </summary>
        [DataMember(Name="reference3", EmitDefaultValue=false)]
        public string Reference3 { get; private set; }
    
        /// <summary>
        /// Gets or Sets Reference4
        /// </summary>
        [DataMember(Name="reference4", EmitDefaultValue=false)]
        public string Reference4 { get; private set; }
    
        /// <summary>
        /// Gets or Sets Reference5
        /// </summary>
        [DataMember(Name="reference5", EmitDefaultValue=false)]
        public string Reference5 { get; private set; }
    
        /// <summary>
        /// Gets or Sets Reference6
        /// </summary>
        [DataMember(Name="reference6", EmitDefaultValue=false)]
        public string Reference6 { get; private set; }
    
        /// <summary>
        /// Gets or Sets Reference7
        /// </summary>
        [DataMember(Name="reference7", EmitDefaultValue=false)]
        public string Reference7 { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromName
        /// </summary>
        [DataMember(Name="shipFromName", EmitDefaultValue=false)]
        public string ShipFromName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromCompany
        /// </summary>
        [DataMember(Name="shipFromCompany", EmitDefaultValue=false)]
        public string ShipFromCompany { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromStreet1
        /// </summary>
        [DataMember(Name="shipFromStreet1", EmitDefaultValue=false)]
        public string ShipFromStreet1 { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromStreet2
        /// </summary>
        [DataMember(Name="shipFromStreet2", EmitDefaultValue=false)]
        public string ShipFromStreet2 { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromCity
        /// </summary>
        [DataMember(Name="shipFromCity", EmitDefaultValue=false)]
        public string ShipFromCity { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromState
        /// </summary>
        [DataMember(Name="shipFromState", EmitDefaultValue=false)]
        public string ShipFromState { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromZip
        /// </summary>
        [DataMember(Name="shipFromZip", EmitDefaultValue=false)]
        public string ShipFromZip { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipFromCountry
        /// </summary>
        [DataMember(Name="shipFromCountry", EmitDefaultValue=false)]
        public string ShipFromCountry { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToName
        /// </summary>
        [DataMember(Name="shipToName", EmitDefaultValue=false)]
        public string ShipToName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToCompany
        /// </summary>
        [DataMember(Name="shipToCompany", EmitDefaultValue=false)]
        public string ShipToCompany { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToStreet1
        /// </summary>
        [DataMember(Name="shipToStreet1", EmitDefaultValue=false)]
        public string ShipToStreet1 { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToStreet2
        /// </summary>
        [DataMember(Name="shipToStreet2", EmitDefaultValue=false)]
        public string ShipToStreet2 { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToCity
        /// </summary>
        [DataMember(Name="shipToCity", EmitDefaultValue=false)]
        public string ShipToCity { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToState
        /// </summary>
        [DataMember(Name="shipToState", EmitDefaultValue=false)]
        public string ShipToState { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToZip
        /// </summary>
        [DataMember(Name="shipToZip", EmitDefaultValue=false)]
        public string ShipToZip { get; private set; }
    
        /// <summary>
        /// Gets or Sets ShipToCountry
        /// </summary>
        [DataMember(Name="shipToCountry", EmitDefaultValue=false)]
        public string ShipToCountry { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToName
        /// </summary>
        [DataMember(Name="originalShipToName", EmitDefaultValue=false)]
        public string OriginalShipToName { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToCompany
        /// </summary>
        [DataMember(Name="originalShipToCompany", EmitDefaultValue=false)]
        public string OriginalShipToCompany { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToStreet1
        /// </summary>
        [DataMember(Name="originalShipToStreet1", EmitDefaultValue=false)]
        public string OriginalShipToStreet1 { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToStreet2
        /// </summary>
        [DataMember(Name="originalShipToStreet2", EmitDefaultValue=false)]
        public string OriginalShipToStreet2 { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToCity
        /// </summary>
        [DataMember(Name="originalShipToCity", EmitDefaultValue=false)]
        public string OriginalShipToCity { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToState
        /// </summary>
        [DataMember(Name="originalShipToState", EmitDefaultValue=false)]
        public string OriginalShipToState { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToZip
        /// </summary>
        [DataMember(Name="originalShipToZip", EmitDefaultValue=false)]
        public string OriginalShipToZip { get; private set; }
    
        /// <summary>
        /// Gets or Sets OriginalShipToCountry
        /// </summary>
        [DataMember(Name="originalShipToCountry", EmitDefaultValue=false)]
        public string OriginalShipToCountry { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyName
        /// </summary>
        [DataMember(Name="thirdPartyName", EmitDefaultValue=false)]
        public string ThirdPartyName { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyCompany
        /// </summary>
        [DataMember(Name="thirdPartyCompany", EmitDefaultValue=false)]
        public string ThirdPartyCompany { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyStreet1
        /// </summary>
        [DataMember(Name="thirdPartyStreet1", EmitDefaultValue=false)]
        public string ThirdPartyStreet1 { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyStreet2
        /// </summary>
        [DataMember(Name="thirdPartyStreet2", EmitDefaultValue=false)]
        public string ThirdPartyStreet2 { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyCity
        /// </summary>
        [DataMember(Name="thirdPartyCity", EmitDefaultValue=false)]
        public string ThirdPartyCity { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyState
        /// </summary>
        [DataMember(Name="thirdPartyState", EmitDefaultValue=false)]
        public string ThirdPartyState { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyZip
        /// </summary>
        [DataMember(Name="thirdPartyZip", EmitDefaultValue=false)]
        public string ThirdPartyZip { get; private set; }
    
        /// <summary>
        /// Gets or Sets ThirdPartyCountry
        /// </summary>
        [DataMember(Name="thirdPartyCountry", EmitDefaultValue=false)]
        public string ThirdPartyCountry { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToName
        /// </summary>
        [DataMember(Name="soldToName", EmitDefaultValue=false)]
        public string SoldToName { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToCompany
        /// </summary>
        [DataMember(Name="soldToCompany", EmitDefaultValue=false)]
        public string SoldToCompany { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToStreet1
        /// </summary>
        [DataMember(Name="soldToStreet1", EmitDefaultValue=false)]
        public string SoldToStreet1 { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToStreet2
        /// </summary>
        [DataMember(Name="soldToStreet2", EmitDefaultValue=false)]
        public string SoldToStreet2 { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToCity
        /// </summary>
        [DataMember(Name="soldToCity", EmitDefaultValue=false)]
        public string SoldToCity { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToState
        /// </summary>
        [DataMember(Name="soldToState", EmitDefaultValue=false)]
        public string SoldToState { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToZip
        /// </summary>
        [DataMember(Name="soldToZip", EmitDefaultValue=false)]
        public string SoldToZip { get; private set; }
    
        /// <summary>
        /// Gets or Sets SoldToCountry
        /// </summary>
        [DataMember(Name="soldToCountry", EmitDefaultValue=false)]
        public string SoldToCountry { get; private set; }
    
        /// <summary>
        /// Gets or Sets FreightServiceType
        /// </summary>
        [DataMember(Name="freightServiceType", EmitDefaultValue=false)]
        public string FreightServiceType { get; private set; }
    
        /// <summary>
        /// Gets or Sets NetCharges
        /// </summary>
        [DataMember(Name="netCharges", EmitDefaultValue=false)]
        public double? NetCharges { get; private set; }
    
        /// <summary>
        /// Gets or Sets BaseFreight
        /// </summary>
        [DataMember(Name="baseFreight", EmitDefaultValue=false)]
        public double? BaseFreight { get; private set; }
    
        /// <summary>
        /// Gets or Sets GrossCharges
        /// </summary>
        [DataMember(Name="grossCharges", EmitDefaultValue=false)]
        public double? GrossCharges { get; private set; }
    
        /// <summary>
        /// Gets or Sets FuelCharge
        /// </summary>
        [DataMember(Name="fuelCharge", EmitDefaultValue=false)]
        public double? FuelCharge { get; private set; }
    
        /// <summary>
        /// Gets or Sets ResidentialCharge
        /// </summary>
        [DataMember(Name="residentialCharge", EmitDefaultValue=false)]
        public double? ResidentialCharge { get; private set; }
    
        /// <summary>
        /// Gets or Sets AdultSignatureCharge
        /// </summary>
        [DataMember(Name="adultSignatureCharge", EmitDefaultValue=false)]
        public double? AdultSignatureCharge { get; private set; }
    
        /// <summary>
        /// Gets or Sets DeliveryAreaCharge
        /// </summary>
        [DataMember(Name="deliveryAreaCharge", EmitDefaultValue=false)]
        public double? DeliveryAreaCharge { get; private set; }
    
        /// <summary>
        /// Gets or Sets DeliveryAreaChargeExtended
        /// </summary>
        [DataMember(Name="deliveryAreaChargeExtended", EmitDefaultValue=false)]
        public double? DeliveryAreaChargeExtended { get; private set; }
    
        /// <summary>
        /// Gets or Sets AddressCorrectionCharge
        /// </summary>
        [DataMember(Name="addressCorrectionCharge", EmitDefaultValue=false)]
        public double? AddressCorrectionCharge { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge1Name
        /// </summary>
        [DataMember(Name="extraCharge1Name", EmitDefaultValue=false)]
        public string ExtraCharge1Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge1Amount
        /// </summary>
        [DataMember(Name="extraCharge1Amount", EmitDefaultValue=false)]
        public double? ExtraCharge1Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge2Name
        /// </summary>
        [DataMember(Name="extraCharge2Name", EmitDefaultValue=false)]
        public string ExtraCharge2Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge2Amount
        /// </summary>
        [DataMember(Name="extraCharge2Amount", EmitDefaultValue=false)]
        public double? ExtraCharge2Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge3Name
        /// </summary>
        [DataMember(Name="extraCharge3Name", EmitDefaultValue=false)]
        public string ExtraCharge3Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge3Amount
        /// </summary>
        [DataMember(Name="extraCharge3Amount", EmitDefaultValue=false)]
        public double? ExtraCharge3Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge4Name
        /// </summary>
        [DataMember(Name="extraCharge4Name", EmitDefaultValue=false)]
        public string ExtraCharge4Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge4Amount
        /// </summary>
        [DataMember(Name="extraCharge4Amount", EmitDefaultValue=false)]
        public double? ExtraCharge4Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge5Name
        /// </summary>
        [DataMember(Name="extraCharge5Name", EmitDefaultValue=false)]
        public string ExtraCharge5Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge5Amount
        /// </summary>
        [DataMember(Name="extraCharge5Amount", EmitDefaultValue=false)]
        public double? ExtraCharge5Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge6Name
        /// </summary>
        [DataMember(Name="extraCharge6Name", EmitDefaultValue=false)]
        public string ExtraCharge6Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge6Amount
        /// </summary>
        [DataMember(Name="extraCharge6Amount", EmitDefaultValue=false)]
        public double? ExtraCharge6Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge7Name
        /// </summary>
        [DataMember(Name="extraCharge7Name", EmitDefaultValue=false)]
        public string ExtraCharge7Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge7Amount
        /// </summary>
        [DataMember(Name="extraCharge7Amount", EmitDefaultValue=false)]
        public double? ExtraCharge7Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge8Name
        /// </summary>
        [DataMember(Name="extraCharge8Name", EmitDefaultValue=false)]
        public string ExtraCharge8Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge8Amount
        /// </summary>
        [DataMember(Name="extraCharge8Amount", EmitDefaultValue=false)]
        public double? ExtraCharge8Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge9Name
        /// </summary>
        [DataMember(Name="extraCharge9Name", EmitDefaultValue=false)]
        public string ExtraCharge9Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge9Amount
        /// </summary>
        [DataMember(Name="extraCharge9Amount", EmitDefaultValue=false)]
        public double? ExtraCharge9Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge10Name
        /// </summary>
        [DataMember(Name="extraCharge10Name", EmitDefaultValue=false)]
        public string ExtraCharge10Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge10Amount
        /// </summary>
        [DataMember(Name="extraCharge10Amount", EmitDefaultValue=false)]
        public double? ExtraCharge10Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge11Name
        /// </summary>
        [DataMember(Name="extraCharge11Name", EmitDefaultValue=false)]
        public string ExtraCharge11Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge11Amount
        /// </summary>
        [DataMember(Name="extraCharge11Amount", EmitDefaultValue=false)]
        public double? ExtraCharge11Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge12Name
        /// </summary>
        [DataMember(Name="extraCharge12Name", EmitDefaultValue=false)]
        public string ExtraCharge12Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge12Amount
        /// </summary>
        [DataMember(Name="extraCharge12Amount", EmitDefaultValue=false)]
        public double? ExtraCharge12Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge13Name
        /// </summary>
        [DataMember(Name="extraCharge13Name", EmitDefaultValue=false)]
        public string ExtraCharge13Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge13Amount
        /// </summary>
        [DataMember(Name="extraCharge13Amount", EmitDefaultValue=false)]
        public double? ExtraCharge13Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge14Name
        /// </summary>
        [DataMember(Name="extraCharge14Name", EmitDefaultValue=false)]
        public string ExtraCharge14Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge14Amount
        /// </summary>
        [DataMember(Name="extraCharge14Amount", EmitDefaultValue=false)]
        public double? ExtraCharge14Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge15Name
        /// </summary>
        [DataMember(Name="extraCharge15Name", EmitDefaultValue=false)]
        public string ExtraCharge15Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge15Amount
        /// </summary>
        [DataMember(Name="extraCharge15Amount", EmitDefaultValue=false)]
        public double? ExtraCharge15Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge16Name
        /// </summary>
        [DataMember(Name="extraCharge16Name", EmitDefaultValue=false)]
        public string ExtraCharge16Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge16Amount
        /// </summary>
        [DataMember(Name="extraCharge16Amount", EmitDefaultValue=false)]
        public double? ExtraCharge16Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge17Name
        /// </summary>
        [DataMember(Name="extraCharge17Name", EmitDefaultValue=false)]
        public string ExtraCharge17Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge17Amount
        /// </summary>
        [DataMember(Name="extraCharge17Amount", EmitDefaultValue=false)]
        public double? ExtraCharge17Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge18Name
        /// </summary>
        [DataMember(Name="extraCharge18Name", EmitDefaultValue=false)]
        public string ExtraCharge18Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge18Amount
        /// </summary>
        [DataMember(Name="extraCharge18Amount", EmitDefaultValue=false)]
        public double? ExtraCharge18Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge19Name
        /// </summary>
        [DataMember(Name="extraCharge19Name", EmitDefaultValue=false)]
        public string ExtraCharge19Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge19Amount
        /// </summary>
        [DataMember(Name="extraCharge19Amount", EmitDefaultValue=false)]
        public double? ExtraCharge19Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge20Name
        /// </summary>
        [DataMember(Name="extraCharge20Name", EmitDefaultValue=false)]
        public string ExtraCharge20Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge20Amount
        /// </summary>
        [DataMember(Name="extraCharge20Amount", EmitDefaultValue=false)]
        public double? ExtraCharge20Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge21Name
        /// </summary>
        [DataMember(Name="extraCharge21Name", EmitDefaultValue=false)]
        public string ExtraCharge21Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge21Amount
        /// </summary>
        [DataMember(Name="extraCharge21Amount", EmitDefaultValue=false)]
        public double? ExtraCharge21Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge22Name
        /// </summary>
        [DataMember(Name="extraCharge22Name", EmitDefaultValue=false)]
        public string ExtraCharge22Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge22Amount
        /// </summary>
        [DataMember(Name="extraCharge22Amount", EmitDefaultValue=false)]
        public double? ExtraCharge22Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge23Name
        /// </summary>
        [DataMember(Name="extraCharge23Name", EmitDefaultValue=false)]
        public string ExtraCharge23Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge23Amount
        /// </summary>
        [DataMember(Name="extraCharge23Amount", EmitDefaultValue=false)]
        public double? ExtraCharge23Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge24Name
        /// </summary>
        [DataMember(Name="extraCharge24Name", EmitDefaultValue=false)]
        public string ExtraCharge24Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge24Amount
        /// </summary>
        [DataMember(Name="extraCharge24Amount", EmitDefaultValue=false)]
        public double? ExtraCharge24Amount { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge25Name
        /// </summary>
        [DataMember(Name="extraCharge25Name", EmitDefaultValue=false)]
        public string ExtraCharge25Name { get; private set; }
    
        /// <summary>
        /// Gets or Sets ExtraCharge25Amount
        /// </summary>
        [DataMember(Name="extraCharge25Amount", EmitDefaultValue=false)]
        public double? ExtraCharge25Amount { get; private set; }
    
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
            sb.Append("class ParcelInvoiceLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceNoId: ").Append(InvoiceNoId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  TrackingNo: ").Append(TrackingNo).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  Dim1: ").Append(Dim1).Append("\n");
            sb.Append("  Dim2: ").Append(Dim2).Append("\n");
            sb.Append("  Dim3: ").Append(Dim3).Append("\n");
            sb.Append("  EnteredWeight: ").Append(EnteredWeight).Append("\n");
            sb.Append("  ActualWeight: ").Append(ActualWeight).Append("\n");
            sb.Append("  BilledWeight: ").Append(BilledWeight).Append("\n");
            sb.Append("  EnteredWeightUnit: ").Append(EnteredWeightUnit).Append("\n");
            sb.Append("  ActualWeightUnit: ").Append(ActualWeightUnit).Append("\n");
            sb.Append("  BilledWeightUnit: ").Append(BilledWeightUnit).Append("\n");
            sb.Append("  CustomerReference: ").Append(CustomerReference).Append("\n");
            sb.Append("  ShipmentReference: ").Append(ShipmentReference).Append("\n");
            sb.Append("  Reference3: ").Append(Reference3).Append("\n");
            sb.Append("  Reference4: ").Append(Reference4).Append("\n");
            sb.Append("  Reference5: ").Append(Reference5).Append("\n");
            sb.Append("  Reference6: ").Append(Reference6).Append("\n");
            sb.Append("  Reference7: ").Append(Reference7).Append("\n");
            sb.Append("  ShipFromName: ").Append(ShipFromName).Append("\n");
            sb.Append("  ShipFromCompany: ").Append(ShipFromCompany).Append("\n");
            sb.Append("  ShipFromStreet1: ").Append(ShipFromStreet1).Append("\n");
            sb.Append("  ShipFromStreet2: ").Append(ShipFromStreet2).Append("\n");
            sb.Append("  ShipFromCity: ").Append(ShipFromCity).Append("\n");
            sb.Append("  ShipFromState: ").Append(ShipFromState).Append("\n");
            sb.Append("  ShipFromZip: ").Append(ShipFromZip).Append("\n");
            sb.Append("  ShipFromCountry: ").Append(ShipFromCountry).Append("\n");
            sb.Append("  ShipToName: ").Append(ShipToName).Append("\n");
            sb.Append("  ShipToCompany: ").Append(ShipToCompany).Append("\n");
            sb.Append("  ShipToStreet1: ").Append(ShipToStreet1).Append("\n");
            sb.Append("  ShipToStreet2: ").Append(ShipToStreet2).Append("\n");
            sb.Append("  ShipToCity: ").Append(ShipToCity).Append("\n");
            sb.Append("  ShipToState: ").Append(ShipToState).Append("\n");
            sb.Append("  ShipToZip: ").Append(ShipToZip).Append("\n");
            sb.Append("  ShipToCountry: ").Append(ShipToCountry).Append("\n");
            sb.Append("  OriginalShipToName: ").Append(OriginalShipToName).Append("\n");
            sb.Append("  OriginalShipToCompany: ").Append(OriginalShipToCompany).Append("\n");
            sb.Append("  OriginalShipToStreet1: ").Append(OriginalShipToStreet1).Append("\n");
            sb.Append("  OriginalShipToStreet2: ").Append(OriginalShipToStreet2).Append("\n");
            sb.Append("  OriginalShipToCity: ").Append(OriginalShipToCity).Append("\n");
            sb.Append("  OriginalShipToState: ").Append(OriginalShipToState).Append("\n");
            sb.Append("  OriginalShipToZip: ").Append(OriginalShipToZip).Append("\n");
            sb.Append("  OriginalShipToCountry: ").Append(OriginalShipToCountry).Append("\n");
            sb.Append("  ThirdPartyName: ").Append(ThirdPartyName).Append("\n");
            sb.Append("  ThirdPartyCompany: ").Append(ThirdPartyCompany).Append("\n");
            sb.Append("  ThirdPartyStreet1: ").Append(ThirdPartyStreet1).Append("\n");
            sb.Append("  ThirdPartyStreet2: ").Append(ThirdPartyStreet2).Append("\n");
            sb.Append("  ThirdPartyCity: ").Append(ThirdPartyCity).Append("\n");
            sb.Append("  ThirdPartyState: ").Append(ThirdPartyState).Append("\n");
            sb.Append("  ThirdPartyZip: ").Append(ThirdPartyZip).Append("\n");
            sb.Append("  ThirdPartyCountry: ").Append(ThirdPartyCountry).Append("\n");
            sb.Append("  SoldToName: ").Append(SoldToName).Append("\n");
            sb.Append("  SoldToCompany: ").Append(SoldToCompany).Append("\n");
            sb.Append("  SoldToStreet1: ").Append(SoldToStreet1).Append("\n");
            sb.Append("  SoldToStreet2: ").Append(SoldToStreet2).Append("\n");
            sb.Append("  SoldToCity: ").Append(SoldToCity).Append("\n");
            sb.Append("  SoldToState: ").Append(SoldToState).Append("\n");
            sb.Append("  SoldToZip: ").Append(SoldToZip).Append("\n");
            sb.Append("  SoldToCountry: ").Append(SoldToCountry).Append("\n");
            sb.Append("  FreightServiceType: ").Append(FreightServiceType).Append("\n");
            sb.Append("  NetCharges: ").Append(NetCharges).Append("\n");
            sb.Append("  BaseFreight: ").Append(BaseFreight).Append("\n");
            sb.Append("  GrossCharges: ").Append(GrossCharges).Append("\n");
            sb.Append("  FuelCharge: ").Append(FuelCharge).Append("\n");
            sb.Append("  ResidentialCharge: ").Append(ResidentialCharge).Append("\n");
            sb.Append("  AdultSignatureCharge: ").Append(AdultSignatureCharge).Append("\n");
            sb.Append("  DeliveryAreaCharge: ").Append(DeliveryAreaCharge).Append("\n");
            sb.Append("  DeliveryAreaChargeExtended: ").Append(DeliveryAreaChargeExtended).Append("\n");
            sb.Append("  AddressCorrectionCharge: ").Append(AddressCorrectionCharge).Append("\n");
            sb.Append("  ExtraCharge1Name: ").Append(ExtraCharge1Name).Append("\n");
            sb.Append("  ExtraCharge1Amount: ").Append(ExtraCharge1Amount).Append("\n");
            sb.Append("  ExtraCharge2Name: ").Append(ExtraCharge2Name).Append("\n");
            sb.Append("  ExtraCharge2Amount: ").Append(ExtraCharge2Amount).Append("\n");
            sb.Append("  ExtraCharge3Name: ").Append(ExtraCharge3Name).Append("\n");
            sb.Append("  ExtraCharge3Amount: ").Append(ExtraCharge3Amount).Append("\n");
            sb.Append("  ExtraCharge4Name: ").Append(ExtraCharge4Name).Append("\n");
            sb.Append("  ExtraCharge4Amount: ").Append(ExtraCharge4Amount).Append("\n");
            sb.Append("  ExtraCharge5Name: ").Append(ExtraCharge5Name).Append("\n");
            sb.Append("  ExtraCharge5Amount: ").Append(ExtraCharge5Amount).Append("\n");
            sb.Append("  ExtraCharge6Name: ").Append(ExtraCharge6Name).Append("\n");
            sb.Append("  ExtraCharge6Amount: ").Append(ExtraCharge6Amount).Append("\n");
            sb.Append("  ExtraCharge7Name: ").Append(ExtraCharge7Name).Append("\n");
            sb.Append("  ExtraCharge7Amount: ").Append(ExtraCharge7Amount).Append("\n");
            sb.Append("  ExtraCharge8Name: ").Append(ExtraCharge8Name).Append("\n");
            sb.Append("  ExtraCharge8Amount: ").Append(ExtraCharge8Amount).Append("\n");
            sb.Append("  ExtraCharge9Name: ").Append(ExtraCharge9Name).Append("\n");
            sb.Append("  ExtraCharge9Amount: ").Append(ExtraCharge9Amount).Append("\n");
            sb.Append("  ExtraCharge10Name: ").Append(ExtraCharge10Name).Append("\n");
            sb.Append("  ExtraCharge10Amount: ").Append(ExtraCharge10Amount).Append("\n");
            sb.Append("  ExtraCharge11Name: ").Append(ExtraCharge11Name).Append("\n");
            sb.Append("  ExtraCharge11Amount: ").Append(ExtraCharge11Amount).Append("\n");
            sb.Append("  ExtraCharge12Name: ").Append(ExtraCharge12Name).Append("\n");
            sb.Append("  ExtraCharge12Amount: ").Append(ExtraCharge12Amount).Append("\n");
            sb.Append("  ExtraCharge13Name: ").Append(ExtraCharge13Name).Append("\n");
            sb.Append("  ExtraCharge13Amount: ").Append(ExtraCharge13Amount).Append("\n");
            sb.Append("  ExtraCharge14Name: ").Append(ExtraCharge14Name).Append("\n");
            sb.Append("  ExtraCharge14Amount: ").Append(ExtraCharge14Amount).Append("\n");
            sb.Append("  ExtraCharge15Name: ").Append(ExtraCharge15Name).Append("\n");
            sb.Append("  ExtraCharge15Amount: ").Append(ExtraCharge15Amount).Append("\n");
            sb.Append("  ExtraCharge16Name: ").Append(ExtraCharge16Name).Append("\n");
            sb.Append("  ExtraCharge16Amount: ").Append(ExtraCharge16Amount).Append("\n");
            sb.Append("  ExtraCharge17Name: ").Append(ExtraCharge17Name).Append("\n");
            sb.Append("  ExtraCharge17Amount: ").Append(ExtraCharge17Amount).Append("\n");
            sb.Append("  ExtraCharge18Name: ").Append(ExtraCharge18Name).Append("\n");
            sb.Append("  ExtraCharge18Amount: ").Append(ExtraCharge18Amount).Append("\n");
            sb.Append("  ExtraCharge19Name: ").Append(ExtraCharge19Name).Append("\n");
            sb.Append("  ExtraCharge19Amount: ").Append(ExtraCharge19Amount).Append("\n");
            sb.Append("  ExtraCharge20Name: ").Append(ExtraCharge20Name).Append("\n");
            sb.Append("  ExtraCharge20Amount: ").Append(ExtraCharge20Amount).Append("\n");
            sb.Append("  ExtraCharge21Name: ").Append(ExtraCharge21Name).Append("\n");
            sb.Append("  ExtraCharge21Amount: ").Append(ExtraCharge21Amount).Append("\n");
            sb.Append("  ExtraCharge22Name: ").Append(ExtraCharge22Name).Append("\n");
            sb.Append("  ExtraCharge22Amount: ").Append(ExtraCharge22Amount).Append("\n");
            sb.Append("  ExtraCharge23Name: ").Append(ExtraCharge23Name).Append("\n");
            sb.Append("  ExtraCharge23Amount: ").Append(ExtraCharge23Amount).Append("\n");
            sb.Append("  ExtraCharge24Name: ").Append(ExtraCharge24Name).Append("\n");
            sb.Append("  ExtraCharge24Amount: ").Append(ExtraCharge24Amount).Append("\n");
            sb.Append("  ExtraCharge25Name: ").Append(ExtraCharge25Name).Append("\n");
            sb.Append("  ExtraCharge25Amount: ").Append(ExtraCharge25Amount).Append("\n");
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
            return this.Equals(obj as ParcelInvoiceLine);
        }

        /// <summary>
        /// Returns true if ParcelInvoiceLine instances are equal
        /// </summary>
        /// <param name="other">Instance of ParcelInvoiceLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParcelInvoiceLine other)
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
                    this.InvoiceNoId == other.InvoiceNoId ||
                    this.InvoiceNoId != null &&
                    this.InvoiceNoId.Equals(other.InvoiceNoId)
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
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.ShipmentId == other.ShipmentId ||
                    this.ShipmentId != null &&
                    this.ShipmentId.Equals(other.ShipmentId)
                ) && 
                (
                    this.TrackingNo == other.TrackingNo ||
                    this.TrackingNo != null &&
                    this.TrackingNo.Equals(other.TrackingNo)
                ) && 
                (
                    this.ShipDate == other.ShipDate ||
                    this.ShipDate != null &&
                    this.ShipDate.Equals(other.ShipDate)
                ) && 
                (
                    this.Zone == other.Zone ||
                    this.Zone != null &&
                    this.Zone.Equals(other.Zone)
                ) && 
                (
                    this.Dim1 == other.Dim1 ||
                    this.Dim1 != null &&
                    this.Dim1.Equals(other.Dim1)
                ) && 
                (
                    this.Dim2 == other.Dim2 ||
                    this.Dim2 != null &&
                    this.Dim2.Equals(other.Dim2)
                ) && 
                (
                    this.Dim3 == other.Dim3 ||
                    this.Dim3 != null &&
                    this.Dim3.Equals(other.Dim3)
                ) && 
                (
                    this.EnteredWeight == other.EnteredWeight ||
                    this.EnteredWeight != null &&
                    this.EnteredWeight.Equals(other.EnteredWeight)
                ) && 
                (
                    this.ActualWeight == other.ActualWeight ||
                    this.ActualWeight != null &&
                    this.ActualWeight.Equals(other.ActualWeight)
                ) && 
                (
                    this.BilledWeight == other.BilledWeight ||
                    this.BilledWeight != null &&
                    this.BilledWeight.Equals(other.BilledWeight)
                ) && 
                (
                    this.EnteredWeightUnit == other.EnteredWeightUnit ||
                    this.EnteredWeightUnit != null &&
                    this.EnteredWeightUnit.Equals(other.EnteredWeightUnit)
                ) && 
                (
                    this.ActualWeightUnit == other.ActualWeightUnit ||
                    this.ActualWeightUnit != null &&
                    this.ActualWeightUnit.Equals(other.ActualWeightUnit)
                ) && 
                (
                    this.BilledWeightUnit == other.BilledWeightUnit ||
                    this.BilledWeightUnit != null &&
                    this.BilledWeightUnit.Equals(other.BilledWeightUnit)
                ) && 
                (
                    this.CustomerReference == other.CustomerReference ||
                    this.CustomerReference != null &&
                    this.CustomerReference.Equals(other.CustomerReference)
                ) && 
                (
                    this.ShipmentReference == other.ShipmentReference ||
                    this.ShipmentReference != null &&
                    this.ShipmentReference.Equals(other.ShipmentReference)
                ) && 
                (
                    this.Reference3 == other.Reference3 ||
                    this.Reference3 != null &&
                    this.Reference3.Equals(other.Reference3)
                ) && 
                (
                    this.Reference4 == other.Reference4 ||
                    this.Reference4 != null &&
                    this.Reference4.Equals(other.Reference4)
                ) && 
                (
                    this.Reference5 == other.Reference5 ||
                    this.Reference5 != null &&
                    this.Reference5.Equals(other.Reference5)
                ) && 
                (
                    this.Reference6 == other.Reference6 ||
                    this.Reference6 != null &&
                    this.Reference6.Equals(other.Reference6)
                ) && 
                (
                    this.Reference7 == other.Reference7 ||
                    this.Reference7 != null &&
                    this.Reference7.Equals(other.Reference7)
                ) && 
                (
                    this.ShipFromName == other.ShipFromName ||
                    this.ShipFromName != null &&
                    this.ShipFromName.Equals(other.ShipFromName)
                ) && 
                (
                    this.ShipFromCompany == other.ShipFromCompany ||
                    this.ShipFromCompany != null &&
                    this.ShipFromCompany.Equals(other.ShipFromCompany)
                ) && 
                (
                    this.ShipFromStreet1 == other.ShipFromStreet1 ||
                    this.ShipFromStreet1 != null &&
                    this.ShipFromStreet1.Equals(other.ShipFromStreet1)
                ) && 
                (
                    this.ShipFromStreet2 == other.ShipFromStreet2 ||
                    this.ShipFromStreet2 != null &&
                    this.ShipFromStreet2.Equals(other.ShipFromStreet2)
                ) && 
                (
                    this.ShipFromCity == other.ShipFromCity ||
                    this.ShipFromCity != null &&
                    this.ShipFromCity.Equals(other.ShipFromCity)
                ) && 
                (
                    this.ShipFromState == other.ShipFromState ||
                    this.ShipFromState != null &&
                    this.ShipFromState.Equals(other.ShipFromState)
                ) && 
                (
                    this.ShipFromZip == other.ShipFromZip ||
                    this.ShipFromZip != null &&
                    this.ShipFromZip.Equals(other.ShipFromZip)
                ) && 
                (
                    this.ShipFromCountry == other.ShipFromCountry ||
                    this.ShipFromCountry != null &&
                    this.ShipFromCountry.Equals(other.ShipFromCountry)
                ) && 
                (
                    this.ShipToName == other.ShipToName ||
                    this.ShipToName != null &&
                    this.ShipToName.Equals(other.ShipToName)
                ) && 
                (
                    this.ShipToCompany == other.ShipToCompany ||
                    this.ShipToCompany != null &&
                    this.ShipToCompany.Equals(other.ShipToCompany)
                ) && 
                (
                    this.ShipToStreet1 == other.ShipToStreet1 ||
                    this.ShipToStreet1 != null &&
                    this.ShipToStreet1.Equals(other.ShipToStreet1)
                ) && 
                (
                    this.ShipToStreet2 == other.ShipToStreet2 ||
                    this.ShipToStreet2 != null &&
                    this.ShipToStreet2.Equals(other.ShipToStreet2)
                ) && 
                (
                    this.ShipToCity == other.ShipToCity ||
                    this.ShipToCity != null &&
                    this.ShipToCity.Equals(other.ShipToCity)
                ) && 
                (
                    this.ShipToState == other.ShipToState ||
                    this.ShipToState != null &&
                    this.ShipToState.Equals(other.ShipToState)
                ) && 
                (
                    this.ShipToZip == other.ShipToZip ||
                    this.ShipToZip != null &&
                    this.ShipToZip.Equals(other.ShipToZip)
                ) && 
                (
                    this.ShipToCountry == other.ShipToCountry ||
                    this.ShipToCountry != null &&
                    this.ShipToCountry.Equals(other.ShipToCountry)
                ) && 
                (
                    this.OriginalShipToName == other.OriginalShipToName ||
                    this.OriginalShipToName != null &&
                    this.OriginalShipToName.Equals(other.OriginalShipToName)
                ) && 
                (
                    this.OriginalShipToCompany == other.OriginalShipToCompany ||
                    this.OriginalShipToCompany != null &&
                    this.OriginalShipToCompany.Equals(other.OriginalShipToCompany)
                ) && 
                (
                    this.OriginalShipToStreet1 == other.OriginalShipToStreet1 ||
                    this.OriginalShipToStreet1 != null &&
                    this.OriginalShipToStreet1.Equals(other.OriginalShipToStreet1)
                ) && 
                (
                    this.OriginalShipToStreet2 == other.OriginalShipToStreet2 ||
                    this.OriginalShipToStreet2 != null &&
                    this.OriginalShipToStreet2.Equals(other.OriginalShipToStreet2)
                ) && 
                (
                    this.OriginalShipToCity == other.OriginalShipToCity ||
                    this.OriginalShipToCity != null &&
                    this.OriginalShipToCity.Equals(other.OriginalShipToCity)
                ) && 
                (
                    this.OriginalShipToState == other.OriginalShipToState ||
                    this.OriginalShipToState != null &&
                    this.OriginalShipToState.Equals(other.OriginalShipToState)
                ) && 
                (
                    this.OriginalShipToZip == other.OriginalShipToZip ||
                    this.OriginalShipToZip != null &&
                    this.OriginalShipToZip.Equals(other.OriginalShipToZip)
                ) && 
                (
                    this.OriginalShipToCountry == other.OriginalShipToCountry ||
                    this.OriginalShipToCountry != null &&
                    this.OriginalShipToCountry.Equals(other.OriginalShipToCountry)
                ) && 
                (
                    this.ThirdPartyName == other.ThirdPartyName ||
                    this.ThirdPartyName != null &&
                    this.ThirdPartyName.Equals(other.ThirdPartyName)
                ) && 
                (
                    this.ThirdPartyCompany == other.ThirdPartyCompany ||
                    this.ThirdPartyCompany != null &&
                    this.ThirdPartyCompany.Equals(other.ThirdPartyCompany)
                ) && 
                (
                    this.ThirdPartyStreet1 == other.ThirdPartyStreet1 ||
                    this.ThirdPartyStreet1 != null &&
                    this.ThirdPartyStreet1.Equals(other.ThirdPartyStreet1)
                ) && 
                (
                    this.ThirdPartyStreet2 == other.ThirdPartyStreet2 ||
                    this.ThirdPartyStreet2 != null &&
                    this.ThirdPartyStreet2.Equals(other.ThirdPartyStreet2)
                ) && 
                (
                    this.ThirdPartyCity == other.ThirdPartyCity ||
                    this.ThirdPartyCity != null &&
                    this.ThirdPartyCity.Equals(other.ThirdPartyCity)
                ) && 
                (
                    this.ThirdPartyState == other.ThirdPartyState ||
                    this.ThirdPartyState != null &&
                    this.ThirdPartyState.Equals(other.ThirdPartyState)
                ) && 
                (
                    this.ThirdPartyZip == other.ThirdPartyZip ||
                    this.ThirdPartyZip != null &&
                    this.ThirdPartyZip.Equals(other.ThirdPartyZip)
                ) && 
                (
                    this.ThirdPartyCountry == other.ThirdPartyCountry ||
                    this.ThirdPartyCountry != null &&
                    this.ThirdPartyCountry.Equals(other.ThirdPartyCountry)
                ) && 
                (
                    this.SoldToName == other.SoldToName ||
                    this.SoldToName != null &&
                    this.SoldToName.Equals(other.SoldToName)
                ) && 
                (
                    this.SoldToCompany == other.SoldToCompany ||
                    this.SoldToCompany != null &&
                    this.SoldToCompany.Equals(other.SoldToCompany)
                ) && 
                (
                    this.SoldToStreet1 == other.SoldToStreet1 ||
                    this.SoldToStreet1 != null &&
                    this.SoldToStreet1.Equals(other.SoldToStreet1)
                ) && 
                (
                    this.SoldToStreet2 == other.SoldToStreet2 ||
                    this.SoldToStreet2 != null &&
                    this.SoldToStreet2.Equals(other.SoldToStreet2)
                ) && 
                (
                    this.SoldToCity == other.SoldToCity ||
                    this.SoldToCity != null &&
                    this.SoldToCity.Equals(other.SoldToCity)
                ) && 
                (
                    this.SoldToState == other.SoldToState ||
                    this.SoldToState != null &&
                    this.SoldToState.Equals(other.SoldToState)
                ) && 
                (
                    this.SoldToZip == other.SoldToZip ||
                    this.SoldToZip != null &&
                    this.SoldToZip.Equals(other.SoldToZip)
                ) && 
                (
                    this.SoldToCountry == other.SoldToCountry ||
                    this.SoldToCountry != null &&
                    this.SoldToCountry.Equals(other.SoldToCountry)
                ) && 
                (
                    this.FreightServiceType == other.FreightServiceType ||
                    this.FreightServiceType != null &&
                    this.FreightServiceType.Equals(other.FreightServiceType)
                ) && 
                (
                    this.NetCharges == other.NetCharges ||
                    this.NetCharges != null &&
                    this.NetCharges.Equals(other.NetCharges)
                ) && 
                (
                    this.BaseFreight == other.BaseFreight ||
                    this.BaseFreight != null &&
                    this.BaseFreight.Equals(other.BaseFreight)
                ) && 
                (
                    this.GrossCharges == other.GrossCharges ||
                    this.GrossCharges != null &&
                    this.GrossCharges.Equals(other.GrossCharges)
                ) && 
                (
                    this.FuelCharge == other.FuelCharge ||
                    this.FuelCharge != null &&
                    this.FuelCharge.Equals(other.FuelCharge)
                ) && 
                (
                    this.ResidentialCharge == other.ResidentialCharge ||
                    this.ResidentialCharge != null &&
                    this.ResidentialCharge.Equals(other.ResidentialCharge)
                ) && 
                (
                    this.AdultSignatureCharge == other.AdultSignatureCharge ||
                    this.AdultSignatureCharge != null &&
                    this.AdultSignatureCharge.Equals(other.AdultSignatureCharge)
                ) && 
                (
                    this.DeliveryAreaCharge == other.DeliveryAreaCharge ||
                    this.DeliveryAreaCharge != null &&
                    this.DeliveryAreaCharge.Equals(other.DeliveryAreaCharge)
                ) && 
                (
                    this.DeliveryAreaChargeExtended == other.DeliveryAreaChargeExtended ||
                    this.DeliveryAreaChargeExtended != null &&
                    this.DeliveryAreaChargeExtended.Equals(other.DeliveryAreaChargeExtended)
                ) && 
                (
                    this.AddressCorrectionCharge == other.AddressCorrectionCharge ||
                    this.AddressCorrectionCharge != null &&
                    this.AddressCorrectionCharge.Equals(other.AddressCorrectionCharge)
                ) && 
                (
                    this.ExtraCharge1Name == other.ExtraCharge1Name ||
                    this.ExtraCharge1Name != null &&
                    this.ExtraCharge1Name.Equals(other.ExtraCharge1Name)
                ) && 
                (
                    this.ExtraCharge1Amount == other.ExtraCharge1Amount ||
                    this.ExtraCharge1Amount != null &&
                    this.ExtraCharge1Amount.Equals(other.ExtraCharge1Amount)
                ) && 
                (
                    this.ExtraCharge2Name == other.ExtraCharge2Name ||
                    this.ExtraCharge2Name != null &&
                    this.ExtraCharge2Name.Equals(other.ExtraCharge2Name)
                ) && 
                (
                    this.ExtraCharge2Amount == other.ExtraCharge2Amount ||
                    this.ExtraCharge2Amount != null &&
                    this.ExtraCharge2Amount.Equals(other.ExtraCharge2Amount)
                ) && 
                (
                    this.ExtraCharge3Name == other.ExtraCharge3Name ||
                    this.ExtraCharge3Name != null &&
                    this.ExtraCharge3Name.Equals(other.ExtraCharge3Name)
                ) && 
                (
                    this.ExtraCharge3Amount == other.ExtraCharge3Amount ||
                    this.ExtraCharge3Amount != null &&
                    this.ExtraCharge3Amount.Equals(other.ExtraCharge3Amount)
                ) && 
                (
                    this.ExtraCharge4Name == other.ExtraCharge4Name ||
                    this.ExtraCharge4Name != null &&
                    this.ExtraCharge4Name.Equals(other.ExtraCharge4Name)
                ) && 
                (
                    this.ExtraCharge4Amount == other.ExtraCharge4Amount ||
                    this.ExtraCharge4Amount != null &&
                    this.ExtraCharge4Amount.Equals(other.ExtraCharge4Amount)
                ) && 
                (
                    this.ExtraCharge5Name == other.ExtraCharge5Name ||
                    this.ExtraCharge5Name != null &&
                    this.ExtraCharge5Name.Equals(other.ExtraCharge5Name)
                ) && 
                (
                    this.ExtraCharge5Amount == other.ExtraCharge5Amount ||
                    this.ExtraCharge5Amount != null &&
                    this.ExtraCharge5Amount.Equals(other.ExtraCharge5Amount)
                ) && 
                (
                    this.ExtraCharge6Name == other.ExtraCharge6Name ||
                    this.ExtraCharge6Name != null &&
                    this.ExtraCharge6Name.Equals(other.ExtraCharge6Name)
                ) && 
                (
                    this.ExtraCharge6Amount == other.ExtraCharge6Amount ||
                    this.ExtraCharge6Amount != null &&
                    this.ExtraCharge6Amount.Equals(other.ExtraCharge6Amount)
                ) && 
                (
                    this.ExtraCharge7Name == other.ExtraCharge7Name ||
                    this.ExtraCharge7Name != null &&
                    this.ExtraCharge7Name.Equals(other.ExtraCharge7Name)
                ) && 
                (
                    this.ExtraCharge7Amount == other.ExtraCharge7Amount ||
                    this.ExtraCharge7Amount != null &&
                    this.ExtraCharge7Amount.Equals(other.ExtraCharge7Amount)
                ) && 
                (
                    this.ExtraCharge8Name == other.ExtraCharge8Name ||
                    this.ExtraCharge8Name != null &&
                    this.ExtraCharge8Name.Equals(other.ExtraCharge8Name)
                ) && 
                (
                    this.ExtraCharge8Amount == other.ExtraCharge8Amount ||
                    this.ExtraCharge8Amount != null &&
                    this.ExtraCharge8Amount.Equals(other.ExtraCharge8Amount)
                ) && 
                (
                    this.ExtraCharge9Name == other.ExtraCharge9Name ||
                    this.ExtraCharge9Name != null &&
                    this.ExtraCharge9Name.Equals(other.ExtraCharge9Name)
                ) && 
                (
                    this.ExtraCharge9Amount == other.ExtraCharge9Amount ||
                    this.ExtraCharge9Amount != null &&
                    this.ExtraCharge9Amount.Equals(other.ExtraCharge9Amount)
                ) && 
                (
                    this.ExtraCharge10Name == other.ExtraCharge10Name ||
                    this.ExtraCharge10Name != null &&
                    this.ExtraCharge10Name.Equals(other.ExtraCharge10Name)
                ) && 
                (
                    this.ExtraCharge10Amount == other.ExtraCharge10Amount ||
                    this.ExtraCharge10Amount != null &&
                    this.ExtraCharge10Amount.Equals(other.ExtraCharge10Amount)
                ) && 
                (
                    this.ExtraCharge11Name == other.ExtraCharge11Name ||
                    this.ExtraCharge11Name != null &&
                    this.ExtraCharge11Name.Equals(other.ExtraCharge11Name)
                ) && 
                (
                    this.ExtraCharge11Amount == other.ExtraCharge11Amount ||
                    this.ExtraCharge11Amount != null &&
                    this.ExtraCharge11Amount.Equals(other.ExtraCharge11Amount)
                ) && 
                (
                    this.ExtraCharge12Name == other.ExtraCharge12Name ||
                    this.ExtraCharge12Name != null &&
                    this.ExtraCharge12Name.Equals(other.ExtraCharge12Name)
                ) && 
                (
                    this.ExtraCharge12Amount == other.ExtraCharge12Amount ||
                    this.ExtraCharge12Amount != null &&
                    this.ExtraCharge12Amount.Equals(other.ExtraCharge12Amount)
                ) && 
                (
                    this.ExtraCharge13Name == other.ExtraCharge13Name ||
                    this.ExtraCharge13Name != null &&
                    this.ExtraCharge13Name.Equals(other.ExtraCharge13Name)
                ) && 
                (
                    this.ExtraCharge13Amount == other.ExtraCharge13Amount ||
                    this.ExtraCharge13Amount != null &&
                    this.ExtraCharge13Amount.Equals(other.ExtraCharge13Amount)
                ) && 
                (
                    this.ExtraCharge14Name == other.ExtraCharge14Name ||
                    this.ExtraCharge14Name != null &&
                    this.ExtraCharge14Name.Equals(other.ExtraCharge14Name)
                ) && 
                (
                    this.ExtraCharge14Amount == other.ExtraCharge14Amount ||
                    this.ExtraCharge14Amount != null &&
                    this.ExtraCharge14Amount.Equals(other.ExtraCharge14Amount)
                ) && 
                (
                    this.ExtraCharge15Name == other.ExtraCharge15Name ||
                    this.ExtraCharge15Name != null &&
                    this.ExtraCharge15Name.Equals(other.ExtraCharge15Name)
                ) && 
                (
                    this.ExtraCharge15Amount == other.ExtraCharge15Amount ||
                    this.ExtraCharge15Amount != null &&
                    this.ExtraCharge15Amount.Equals(other.ExtraCharge15Amount)
                ) && 
                (
                    this.ExtraCharge16Name == other.ExtraCharge16Name ||
                    this.ExtraCharge16Name != null &&
                    this.ExtraCharge16Name.Equals(other.ExtraCharge16Name)
                ) && 
                (
                    this.ExtraCharge16Amount == other.ExtraCharge16Amount ||
                    this.ExtraCharge16Amount != null &&
                    this.ExtraCharge16Amount.Equals(other.ExtraCharge16Amount)
                ) && 
                (
                    this.ExtraCharge17Name == other.ExtraCharge17Name ||
                    this.ExtraCharge17Name != null &&
                    this.ExtraCharge17Name.Equals(other.ExtraCharge17Name)
                ) && 
                (
                    this.ExtraCharge17Amount == other.ExtraCharge17Amount ||
                    this.ExtraCharge17Amount != null &&
                    this.ExtraCharge17Amount.Equals(other.ExtraCharge17Amount)
                ) && 
                (
                    this.ExtraCharge18Name == other.ExtraCharge18Name ||
                    this.ExtraCharge18Name != null &&
                    this.ExtraCharge18Name.Equals(other.ExtraCharge18Name)
                ) && 
                (
                    this.ExtraCharge18Amount == other.ExtraCharge18Amount ||
                    this.ExtraCharge18Amount != null &&
                    this.ExtraCharge18Amount.Equals(other.ExtraCharge18Amount)
                ) && 
                (
                    this.ExtraCharge19Name == other.ExtraCharge19Name ||
                    this.ExtraCharge19Name != null &&
                    this.ExtraCharge19Name.Equals(other.ExtraCharge19Name)
                ) && 
                (
                    this.ExtraCharge19Amount == other.ExtraCharge19Amount ||
                    this.ExtraCharge19Amount != null &&
                    this.ExtraCharge19Amount.Equals(other.ExtraCharge19Amount)
                ) && 
                (
                    this.ExtraCharge20Name == other.ExtraCharge20Name ||
                    this.ExtraCharge20Name != null &&
                    this.ExtraCharge20Name.Equals(other.ExtraCharge20Name)
                ) && 
                (
                    this.ExtraCharge20Amount == other.ExtraCharge20Amount ||
                    this.ExtraCharge20Amount != null &&
                    this.ExtraCharge20Amount.Equals(other.ExtraCharge20Amount)
                ) && 
                (
                    this.ExtraCharge21Name == other.ExtraCharge21Name ||
                    this.ExtraCharge21Name != null &&
                    this.ExtraCharge21Name.Equals(other.ExtraCharge21Name)
                ) && 
                (
                    this.ExtraCharge21Amount == other.ExtraCharge21Amount ||
                    this.ExtraCharge21Amount != null &&
                    this.ExtraCharge21Amount.Equals(other.ExtraCharge21Amount)
                ) && 
                (
                    this.ExtraCharge22Name == other.ExtraCharge22Name ||
                    this.ExtraCharge22Name != null &&
                    this.ExtraCharge22Name.Equals(other.ExtraCharge22Name)
                ) && 
                (
                    this.ExtraCharge22Amount == other.ExtraCharge22Amount ||
                    this.ExtraCharge22Amount != null &&
                    this.ExtraCharge22Amount.Equals(other.ExtraCharge22Amount)
                ) && 
                (
                    this.ExtraCharge23Name == other.ExtraCharge23Name ||
                    this.ExtraCharge23Name != null &&
                    this.ExtraCharge23Name.Equals(other.ExtraCharge23Name)
                ) && 
                (
                    this.ExtraCharge23Amount == other.ExtraCharge23Amount ||
                    this.ExtraCharge23Amount != null &&
                    this.ExtraCharge23Amount.Equals(other.ExtraCharge23Amount)
                ) && 
                (
                    this.ExtraCharge24Name == other.ExtraCharge24Name ||
                    this.ExtraCharge24Name != null &&
                    this.ExtraCharge24Name.Equals(other.ExtraCharge24Name)
                ) && 
                (
                    this.ExtraCharge24Amount == other.ExtraCharge24Amount ||
                    this.ExtraCharge24Amount != null &&
                    this.ExtraCharge24Amount.Equals(other.ExtraCharge24Amount)
                ) && 
                (
                    this.ExtraCharge25Name == other.ExtraCharge25Name ||
                    this.ExtraCharge25Name != null &&
                    this.ExtraCharge25Name.Equals(other.ExtraCharge25Name)
                ) && 
                (
                    this.ExtraCharge25Amount == other.ExtraCharge25Amount ||
                    this.ExtraCharge25Amount != null &&
                    this.ExtraCharge25Amount.Equals(other.ExtraCharge25Amount)
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
                
                if (this.InvoiceNoId != null)
                    hash = hash * 59 + this.InvoiceNoId.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                
                if (this.ShipmentId != null)
                    hash = hash * 59 + this.ShipmentId.GetHashCode();
                
                if (this.TrackingNo != null)
                    hash = hash * 59 + this.TrackingNo.GetHashCode();
                
                if (this.ShipDate != null)
                    hash = hash * 59 + this.ShipDate.GetHashCode();
                
                if (this.Zone != null)
                    hash = hash * 59 + this.Zone.GetHashCode();
                
                if (this.Dim1 != null)
                    hash = hash * 59 + this.Dim1.GetHashCode();
                
                if (this.Dim2 != null)
                    hash = hash * 59 + this.Dim2.GetHashCode();
                
                if (this.Dim3 != null)
                    hash = hash * 59 + this.Dim3.GetHashCode();
                
                if (this.EnteredWeight != null)
                    hash = hash * 59 + this.EnteredWeight.GetHashCode();
                
                if (this.ActualWeight != null)
                    hash = hash * 59 + this.ActualWeight.GetHashCode();
                
                if (this.BilledWeight != null)
                    hash = hash * 59 + this.BilledWeight.GetHashCode();
                
                if (this.EnteredWeightUnit != null)
                    hash = hash * 59 + this.EnteredWeightUnit.GetHashCode();
                
                if (this.ActualWeightUnit != null)
                    hash = hash * 59 + this.ActualWeightUnit.GetHashCode();
                
                if (this.BilledWeightUnit != null)
                    hash = hash * 59 + this.BilledWeightUnit.GetHashCode();
                
                if (this.CustomerReference != null)
                    hash = hash * 59 + this.CustomerReference.GetHashCode();
                
                if (this.ShipmentReference != null)
                    hash = hash * 59 + this.ShipmentReference.GetHashCode();
                
                if (this.Reference3 != null)
                    hash = hash * 59 + this.Reference3.GetHashCode();
                
                if (this.Reference4 != null)
                    hash = hash * 59 + this.Reference4.GetHashCode();
                
                if (this.Reference5 != null)
                    hash = hash * 59 + this.Reference5.GetHashCode();
                
                if (this.Reference6 != null)
                    hash = hash * 59 + this.Reference6.GetHashCode();
                
                if (this.Reference7 != null)
                    hash = hash * 59 + this.Reference7.GetHashCode();
                
                if (this.ShipFromName != null)
                    hash = hash * 59 + this.ShipFromName.GetHashCode();
                
                if (this.ShipFromCompany != null)
                    hash = hash * 59 + this.ShipFromCompany.GetHashCode();
                
                if (this.ShipFromStreet1 != null)
                    hash = hash * 59 + this.ShipFromStreet1.GetHashCode();
                
                if (this.ShipFromStreet2 != null)
                    hash = hash * 59 + this.ShipFromStreet2.GetHashCode();
                
                if (this.ShipFromCity != null)
                    hash = hash * 59 + this.ShipFromCity.GetHashCode();
                
                if (this.ShipFromState != null)
                    hash = hash * 59 + this.ShipFromState.GetHashCode();
                
                if (this.ShipFromZip != null)
                    hash = hash * 59 + this.ShipFromZip.GetHashCode();
                
                if (this.ShipFromCountry != null)
                    hash = hash * 59 + this.ShipFromCountry.GetHashCode();
                
                if (this.ShipToName != null)
                    hash = hash * 59 + this.ShipToName.GetHashCode();
                
                if (this.ShipToCompany != null)
                    hash = hash * 59 + this.ShipToCompany.GetHashCode();
                
                if (this.ShipToStreet1 != null)
                    hash = hash * 59 + this.ShipToStreet1.GetHashCode();
                
                if (this.ShipToStreet2 != null)
                    hash = hash * 59 + this.ShipToStreet2.GetHashCode();
                
                if (this.ShipToCity != null)
                    hash = hash * 59 + this.ShipToCity.GetHashCode();
                
                if (this.ShipToState != null)
                    hash = hash * 59 + this.ShipToState.GetHashCode();
                
                if (this.ShipToZip != null)
                    hash = hash * 59 + this.ShipToZip.GetHashCode();
                
                if (this.ShipToCountry != null)
                    hash = hash * 59 + this.ShipToCountry.GetHashCode();
                
                if (this.OriginalShipToName != null)
                    hash = hash * 59 + this.OriginalShipToName.GetHashCode();
                
                if (this.OriginalShipToCompany != null)
                    hash = hash * 59 + this.OriginalShipToCompany.GetHashCode();
                
                if (this.OriginalShipToStreet1 != null)
                    hash = hash * 59 + this.OriginalShipToStreet1.GetHashCode();
                
                if (this.OriginalShipToStreet2 != null)
                    hash = hash * 59 + this.OriginalShipToStreet2.GetHashCode();
                
                if (this.OriginalShipToCity != null)
                    hash = hash * 59 + this.OriginalShipToCity.GetHashCode();
                
                if (this.OriginalShipToState != null)
                    hash = hash * 59 + this.OriginalShipToState.GetHashCode();
                
                if (this.OriginalShipToZip != null)
                    hash = hash * 59 + this.OriginalShipToZip.GetHashCode();
                
                if (this.OriginalShipToCountry != null)
                    hash = hash * 59 + this.OriginalShipToCountry.GetHashCode();
                
                if (this.ThirdPartyName != null)
                    hash = hash * 59 + this.ThirdPartyName.GetHashCode();
                
                if (this.ThirdPartyCompany != null)
                    hash = hash * 59 + this.ThirdPartyCompany.GetHashCode();
                
                if (this.ThirdPartyStreet1 != null)
                    hash = hash * 59 + this.ThirdPartyStreet1.GetHashCode();
                
                if (this.ThirdPartyStreet2 != null)
                    hash = hash * 59 + this.ThirdPartyStreet2.GetHashCode();
                
                if (this.ThirdPartyCity != null)
                    hash = hash * 59 + this.ThirdPartyCity.GetHashCode();
                
                if (this.ThirdPartyState != null)
                    hash = hash * 59 + this.ThirdPartyState.GetHashCode();
                
                if (this.ThirdPartyZip != null)
                    hash = hash * 59 + this.ThirdPartyZip.GetHashCode();
                
                if (this.ThirdPartyCountry != null)
                    hash = hash * 59 + this.ThirdPartyCountry.GetHashCode();
                
                if (this.SoldToName != null)
                    hash = hash * 59 + this.SoldToName.GetHashCode();
                
                if (this.SoldToCompany != null)
                    hash = hash * 59 + this.SoldToCompany.GetHashCode();
                
                if (this.SoldToStreet1 != null)
                    hash = hash * 59 + this.SoldToStreet1.GetHashCode();
                
                if (this.SoldToStreet2 != null)
                    hash = hash * 59 + this.SoldToStreet2.GetHashCode();
                
                if (this.SoldToCity != null)
                    hash = hash * 59 + this.SoldToCity.GetHashCode();
                
                if (this.SoldToState != null)
                    hash = hash * 59 + this.SoldToState.GetHashCode();
                
                if (this.SoldToZip != null)
                    hash = hash * 59 + this.SoldToZip.GetHashCode();
                
                if (this.SoldToCountry != null)
                    hash = hash * 59 + this.SoldToCountry.GetHashCode();
                
                if (this.FreightServiceType != null)
                    hash = hash * 59 + this.FreightServiceType.GetHashCode();
                
                if (this.NetCharges != null)
                    hash = hash * 59 + this.NetCharges.GetHashCode();
                
                if (this.BaseFreight != null)
                    hash = hash * 59 + this.BaseFreight.GetHashCode();
                
                if (this.GrossCharges != null)
                    hash = hash * 59 + this.GrossCharges.GetHashCode();
                
                if (this.FuelCharge != null)
                    hash = hash * 59 + this.FuelCharge.GetHashCode();
                
                if (this.ResidentialCharge != null)
                    hash = hash * 59 + this.ResidentialCharge.GetHashCode();
                
                if (this.AdultSignatureCharge != null)
                    hash = hash * 59 + this.AdultSignatureCharge.GetHashCode();
                
                if (this.DeliveryAreaCharge != null)
                    hash = hash * 59 + this.DeliveryAreaCharge.GetHashCode();
                
                if (this.DeliveryAreaChargeExtended != null)
                    hash = hash * 59 + this.DeliveryAreaChargeExtended.GetHashCode();
                
                if (this.AddressCorrectionCharge != null)
                    hash = hash * 59 + this.AddressCorrectionCharge.GetHashCode();
                
                if (this.ExtraCharge1Name != null)
                    hash = hash * 59 + this.ExtraCharge1Name.GetHashCode();
                
                if (this.ExtraCharge1Amount != null)
                    hash = hash * 59 + this.ExtraCharge1Amount.GetHashCode();
                
                if (this.ExtraCharge2Name != null)
                    hash = hash * 59 + this.ExtraCharge2Name.GetHashCode();
                
                if (this.ExtraCharge2Amount != null)
                    hash = hash * 59 + this.ExtraCharge2Amount.GetHashCode();
                
                if (this.ExtraCharge3Name != null)
                    hash = hash * 59 + this.ExtraCharge3Name.GetHashCode();
                
                if (this.ExtraCharge3Amount != null)
                    hash = hash * 59 + this.ExtraCharge3Amount.GetHashCode();
                
                if (this.ExtraCharge4Name != null)
                    hash = hash * 59 + this.ExtraCharge4Name.GetHashCode();
                
                if (this.ExtraCharge4Amount != null)
                    hash = hash * 59 + this.ExtraCharge4Amount.GetHashCode();
                
                if (this.ExtraCharge5Name != null)
                    hash = hash * 59 + this.ExtraCharge5Name.GetHashCode();
                
                if (this.ExtraCharge5Amount != null)
                    hash = hash * 59 + this.ExtraCharge5Amount.GetHashCode();
                
                if (this.ExtraCharge6Name != null)
                    hash = hash * 59 + this.ExtraCharge6Name.GetHashCode();
                
                if (this.ExtraCharge6Amount != null)
                    hash = hash * 59 + this.ExtraCharge6Amount.GetHashCode();
                
                if (this.ExtraCharge7Name != null)
                    hash = hash * 59 + this.ExtraCharge7Name.GetHashCode();
                
                if (this.ExtraCharge7Amount != null)
                    hash = hash * 59 + this.ExtraCharge7Amount.GetHashCode();
                
                if (this.ExtraCharge8Name != null)
                    hash = hash * 59 + this.ExtraCharge8Name.GetHashCode();
                
                if (this.ExtraCharge8Amount != null)
                    hash = hash * 59 + this.ExtraCharge8Amount.GetHashCode();
                
                if (this.ExtraCharge9Name != null)
                    hash = hash * 59 + this.ExtraCharge9Name.GetHashCode();
                
                if (this.ExtraCharge9Amount != null)
                    hash = hash * 59 + this.ExtraCharge9Amount.GetHashCode();
                
                if (this.ExtraCharge10Name != null)
                    hash = hash * 59 + this.ExtraCharge10Name.GetHashCode();
                
                if (this.ExtraCharge10Amount != null)
                    hash = hash * 59 + this.ExtraCharge10Amount.GetHashCode();
                
                if (this.ExtraCharge11Name != null)
                    hash = hash * 59 + this.ExtraCharge11Name.GetHashCode();
                
                if (this.ExtraCharge11Amount != null)
                    hash = hash * 59 + this.ExtraCharge11Amount.GetHashCode();
                
                if (this.ExtraCharge12Name != null)
                    hash = hash * 59 + this.ExtraCharge12Name.GetHashCode();
                
                if (this.ExtraCharge12Amount != null)
                    hash = hash * 59 + this.ExtraCharge12Amount.GetHashCode();
                
                if (this.ExtraCharge13Name != null)
                    hash = hash * 59 + this.ExtraCharge13Name.GetHashCode();
                
                if (this.ExtraCharge13Amount != null)
                    hash = hash * 59 + this.ExtraCharge13Amount.GetHashCode();
                
                if (this.ExtraCharge14Name != null)
                    hash = hash * 59 + this.ExtraCharge14Name.GetHashCode();
                
                if (this.ExtraCharge14Amount != null)
                    hash = hash * 59 + this.ExtraCharge14Amount.GetHashCode();
                
                if (this.ExtraCharge15Name != null)
                    hash = hash * 59 + this.ExtraCharge15Name.GetHashCode();
                
                if (this.ExtraCharge15Amount != null)
                    hash = hash * 59 + this.ExtraCharge15Amount.GetHashCode();
                
                if (this.ExtraCharge16Name != null)
                    hash = hash * 59 + this.ExtraCharge16Name.GetHashCode();
                
                if (this.ExtraCharge16Amount != null)
                    hash = hash * 59 + this.ExtraCharge16Amount.GetHashCode();
                
                if (this.ExtraCharge17Name != null)
                    hash = hash * 59 + this.ExtraCharge17Name.GetHashCode();
                
                if (this.ExtraCharge17Amount != null)
                    hash = hash * 59 + this.ExtraCharge17Amount.GetHashCode();
                
                if (this.ExtraCharge18Name != null)
                    hash = hash * 59 + this.ExtraCharge18Name.GetHashCode();
                
                if (this.ExtraCharge18Amount != null)
                    hash = hash * 59 + this.ExtraCharge18Amount.GetHashCode();
                
                if (this.ExtraCharge19Name != null)
                    hash = hash * 59 + this.ExtraCharge19Name.GetHashCode();
                
                if (this.ExtraCharge19Amount != null)
                    hash = hash * 59 + this.ExtraCharge19Amount.GetHashCode();
                
                if (this.ExtraCharge20Name != null)
                    hash = hash * 59 + this.ExtraCharge20Name.GetHashCode();
                
                if (this.ExtraCharge20Amount != null)
                    hash = hash * 59 + this.ExtraCharge20Amount.GetHashCode();
                
                if (this.ExtraCharge21Name != null)
                    hash = hash * 59 + this.ExtraCharge21Name.GetHashCode();
                
                if (this.ExtraCharge21Amount != null)
                    hash = hash * 59 + this.ExtraCharge21Amount.GetHashCode();
                
                if (this.ExtraCharge22Name != null)
                    hash = hash * 59 + this.ExtraCharge22Name.GetHashCode();
                
                if (this.ExtraCharge22Amount != null)
                    hash = hash * 59 + this.ExtraCharge22Amount.GetHashCode();
                
                if (this.ExtraCharge23Name != null)
                    hash = hash * 59 + this.ExtraCharge23Name.GetHashCode();
                
                if (this.ExtraCharge23Amount != null)
                    hash = hash * 59 + this.ExtraCharge23Amount.GetHashCode();
                
                if (this.ExtraCharge24Name != null)
                    hash = hash * 59 + this.ExtraCharge24Name.GetHashCode();
                
                if (this.ExtraCharge24Amount != null)
                    hash = hash * 59 + this.ExtraCharge24Amount.GetHashCode();
                
                if (this.ExtraCharge25Name != null)
                    hash = hash * 59 + this.ExtraCharge25Name.GetHashCode();
                
                if (this.ExtraCharge25Amount != null)
                    hash = hash * 59 + this.ExtraCharge25Amount.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
