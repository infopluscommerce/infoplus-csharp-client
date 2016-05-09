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
    public partial class ShoppingCartConnection :  IEquatable<ShoppingCartConnection>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartConnection" /> class.
        /// Initializes a new instance of the <see cref="ShoppingCartConnection" />class.
        /// </summary>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="OrderSourceId">OrderSourceId (required).</param>
        /// <param name="IntegrationPartnerId">IntegrationPartnerId (required).</param>
        /// <param name="ConnectionType">ConnectionType (required).</param>
        /// <param name="ItemFilterId">ItemFilterId.</param>
        /// <param name="InfoplusSKUFieldToMap">InfoplusSKUFieldToMap (required).</param>
        /// <param name="ShoppingCartSKUFieldToMap">ShoppingCartSKUFieldToMap (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="ShoppingCartStoreURL">ShoppingCartStoreURL (required).</param>
        /// <param name="AccessCode">AccessCode.</param>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="SyncOrders">SyncOrders (required) (default to false).</param>
        /// <param name="SyncInventory">SyncInventory (required) (default to false).</param>
        /// <param name="SyncTrackingData">SyncTrackingData (required) (default to false).</param>

        public ShoppingCartConnection(int? LobId = null, int? OrderSourceId = null, int? IntegrationPartnerId = null, string ConnectionType = null, int? ItemFilterId = null, string InfoplusSKUFieldToMap = null, string ShoppingCartSKUFieldToMap = null, string Name = null, string ShoppingCartStoreURL = null, string AccessCode = null, string AccessToken = null, bool? SyncOrders = null, bool? SyncInventory = null, bool? SyncTrackingData = null, )
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "OrderSourceId" is required (not null)
            if (OrderSourceId == null)
            {
                throw new InvalidDataException("OrderSourceId is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.OrderSourceId = OrderSourceId;
            }
            // to ensure "IntegrationPartnerId" is required (not null)
            if (IntegrationPartnerId == null)
            {
                throw new InvalidDataException("IntegrationPartnerId is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.IntegrationPartnerId = IntegrationPartnerId;
            }
            // to ensure "ConnectionType" is required (not null)
            if (ConnectionType == null)
            {
                throw new InvalidDataException("ConnectionType is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.ConnectionType = ConnectionType;
            }
            // to ensure "InfoplusSKUFieldToMap" is required (not null)
            if (InfoplusSKUFieldToMap == null)
            {
                throw new InvalidDataException("InfoplusSKUFieldToMap is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.InfoplusSKUFieldToMap = InfoplusSKUFieldToMap;
            }
            // to ensure "ShoppingCartSKUFieldToMap" is required (not null)
            if (ShoppingCartSKUFieldToMap == null)
            {
                throw new InvalidDataException("ShoppingCartSKUFieldToMap is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.ShoppingCartSKUFieldToMap = ShoppingCartSKUFieldToMap;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ShoppingCartStoreURL" is required (not null)
            if (ShoppingCartStoreURL == null)
            {
                throw new InvalidDataException("ShoppingCartStoreURL is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.ShoppingCartStoreURL = ShoppingCartStoreURL;
            }
            // to ensure "SyncOrders" is required (not null)
            if (SyncOrders == null)
            {
                throw new InvalidDataException("SyncOrders is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.SyncOrders = SyncOrders;
            }
            // to ensure "SyncInventory" is required (not null)
            if (SyncInventory == null)
            {
                throw new InvalidDataException("SyncInventory is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.SyncInventory = SyncInventory;
            }
            // to ensure "SyncTrackingData" is required (not null)
            if (SyncTrackingData == null)
            {
                throw new InvalidDataException("SyncTrackingData is a required property for ShoppingCartConnection and cannot be null");
            }
            else
            {
                this.SyncTrackingData = SyncTrackingData;
            }
            this.ItemFilterId = ItemFilterId;
            this.AccessCode = AccessCode;
            this.AccessToken = AccessToken;
            
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
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public int? ClientId { get; private set; }
    
        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public string Nonce { get; private set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderSourceId
        /// </summary>
        [DataMember(Name="orderSourceId", EmitDefaultValue=false)]
        public int? OrderSourceId { get; set; }
    
        /// <summary>
        /// Gets or Sets IntegrationPartnerId
        /// </summary>
        [DataMember(Name="integrationPartnerId", EmitDefaultValue=false)]
        public int? IntegrationPartnerId { get; set; }
    
        /// <summary>
        /// Gets or Sets ConnectionType
        /// </summary>
        [DataMember(Name="connectionType", EmitDefaultValue=false)]
        public string ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or Sets ItemFilterId
        /// </summary>
        [DataMember(Name="itemFilterId", EmitDefaultValue=false)]
        public int? ItemFilterId { get; set; }
    
        /// <summary>
        /// Gets or Sets InfoplusSKUFieldToMap
        /// </summary>
        [DataMember(Name="infoplusSKUFieldToMap", EmitDefaultValue=false)]
        public string InfoplusSKUFieldToMap { get; set; }
    
        /// <summary>
        /// Gets or Sets ShoppingCartSKUFieldToMap
        /// </summary>
        [DataMember(Name="shoppingCartSKUFieldToMap", EmitDefaultValue=false)]
        public string ShoppingCartSKUFieldToMap { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets ShoppingCartStoreURL
        /// </summary>
        [DataMember(Name="shoppingCartStoreURL", EmitDefaultValue=false)]
        public string ShoppingCartStoreURL { get; set; }
    
        /// <summary>
        /// Gets or Sets AccessCode
        /// </summary>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
    
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
    
        /// <summary>
        /// Gets or Sets SyncOrders
        /// </summary>
        [DataMember(Name="syncOrders", EmitDefaultValue=false)]
        public bool? SyncOrders { get; set; }
    
        /// <summary>
        /// Gets or Sets SyncInventory
        /// </summary>
        [DataMember(Name="syncInventory", EmitDefaultValue=false)]
        public bool? SyncInventory { get; set; }
    
        /// <summary>
        /// Gets or Sets SyncTrackingData
        /// </summary>
        [DataMember(Name="syncTrackingData", EmitDefaultValue=false)]
        public bool? SyncTrackingData { get; set; }
    
        /// <summary>
        /// Gets or Sets SyncInventoryLevelsLastRunTime
        /// </summary>
        [DataMember(Name="syncInventoryLevelsLastRunTime", EmitDefaultValue=false)]
        public DateTime? SyncInventoryLevelsLastRunTime { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShoppingCartConnection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  OrderSourceId: ").Append(OrderSourceId).Append("\n");
            sb.Append("  IntegrationPartnerId: ").Append(IntegrationPartnerId).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  ItemFilterId: ").Append(ItemFilterId).Append("\n");
            sb.Append("  InfoplusSKUFieldToMap: ").Append(InfoplusSKUFieldToMap).Append("\n");
            sb.Append("  ShoppingCartSKUFieldToMap: ").Append(ShoppingCartSKUFieldToMap).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShoppingCartStoreURL: ").Append(ShoppingCartStoreURL).Append("\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  SyncOrders: ").Append(SyncOrders).Append("\n");
            sb.Append("  SyncInventory: ").Append(SyncInventory).Append("\n");
            sb.Append("  SyncTrackingData: ").Append(SyncTrackingData).Append("\n");
            sb.Append("  SyncInventoryLevelsLastRunTime: ").Append(SyncInventoryLevelsLastRunTime).Append("\n");
            
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
            return this.Equals(obj as ShoppingCartConnection);
        }

        /// <summary>
        /// Returns true if ShoppingCartConnection instances are equal
        /// </summary>
        /// <param name="other">Instance of ShoppingCartConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShoppingCartConnection other)
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
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.Nonce == other.Nonce ||
                    this.Nonce != null &&
                    this.Nonce.Equals(other.Nonce)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.OrderSourceId == other.OrderSourceId ||
                    this.OrderSourceId != null &&
                    this.OrderSourceId.Equals(other.OrderSourceId)
                ) && 
                (
                    this.IntegrationPartnerId == other.IntegrationPartnerId ||
                    this.IntegrationPartnerId != null &&
                    this.IntegrationPartnerId.Equals(other.IntegrationPartnerId)
                ) && 
                (
                    this.ConnectionType == other.ConnectionType ||
                    this.ConnectionType != null &&
                    this.ConnectionType.Equals(other.ConnectionType)
                ) && 
                (
                    this.ItemFilterId == other.ItemFilterId ||
                    this.ItemFilterId != null &&
                    this.ItemFilterId.Equals(other.ItemFilterId)
                ) && 
                (
                    this.InfoplusSKUFieldToMap == other.InfoplusSKUFieldToMap ||
                    this.InfoplusSKUFieldToMap != null &&
                    this.InfoplusSKUFieldToMap.Equals(other.InfoplusSKUFieldToMap)
                ) && 
                (
                    this.ShoppingCartSKUFieldToMap == other.ShoppingCartSKUFieldToMap ||
                    this.ShoppingCartSKUFieldToMap != null &&
                    this.ShoppingCartSKUFieldToMap.Equals(other.ShoppingCartSKUFieldToMap)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShoppingCartStoreURL == other.ShoppingCartStoreURL ||
                    this.ShoppingCartStoreURL != null &&
                    this.ShoppingCartStoreURL.Equals(other.ShoppingCartStoreURL)
                ) && 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.SyncOrders == other.SyncOrders ||
                    this.SyncOrders != null &&
                    this.SyncOrders.Equals(other.SyncOrders)
                ) && 
                (
                    this.SyncInventory == other.SyncInventory ||
                    this.SyncInventory != null &&
                    this.SyncInventory.Equals(other.SyncInventory)
                ) && 
                (
                    this.SyncTrackingData == other.SyncTrackingData ||
                    this.SyncTrackingData != null &&
                    this.SyncTrackingData.Equals(other.SyncTrackingData)
                ) && 
                (
                    this.SyncInventoryLevelsLastRunTime == other.SyncInventoryLevelsLastRunTime ||
                    this.SyncInventoryLevelsLastRunTime != null &&
                    this.SyncInventoryLevelsLastRunTime.Equals(other.SyncInventoryLevelsLastRunTime)
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
                
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                
                if (this.Nonce != null)
                    hash = hash * 59 + this.Nonce.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.OrderSourceId != null)
                    hash = hash * 59 + this.OrderSourceId.GetHashCode();
                
                if (this.IntegrationPartnerId != null)
                    hash = hash * 59 + this.IntegrationPartnerId.GetHashCode();
                
                if (this.ConnectionType != null)
                    hash = hash * 59 + this.ConnectionType.GetHashCode();
                
                if (this.ItemFilterId != null)
                    hash = hash * 59 + this.ItemFilterId.GetHashCode();
                
                if (this.InfoplusSKUFieldToMap != null)
                    hash = hash * 59 + this.InfoplusSKUFieldToMap.GetHashCode();
                
                if (this.ShoppingCartSKUFieldToMap != null)
                    hash = hash * 59 + this.ShoppingCartSKUFieldToMap.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ShoppingCartStoreURL != null)
                    hash = hash * 59 + this.ShoppingCartStoreURL.GetHashCode();
                
                if (this.AccessCode != null)
                    hash = hash * 59 + this.AccessCode.GetHashCode();
                
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                
                if (this.SyncOrders != null)
                    hash = hash * 59 + this.SyncOrders.GetHashCode();
                
                if (this.SyncInventory != null)
                    hash = hash * 59 + this.SyncInventory.GetHashCode();
                
                if (this.SyncTrackingData != null)
                    hash = hash * 59 + this.SyncTrackingData.GetHashCode();
                
                if (this.SyncInventoryLevelsLastRunTime != null)
                    hash = hash * 59 + this.SyncInventoryLevelsLastRunTime.GetHashCode();
                
                return hash;
            }
        }

    }
}
