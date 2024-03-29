# Infoplus.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderNo** | **decimal?** |  | [optional] 
**CustomerOrderNo** | **string** |  | [optional] 
**LobId** | **int?** |  | 
**WarehouseId** | **int?** |  | 
**OrderDate** | **DateTime?** |  | [optional] 
**CustomerNo** | **string** |  | [optional] 
**UseOrderNoRoot** | **int?** |  | [optional] 
**ShippingMethod** | **string** |  | [optional] 
**FirstShipDate** | **DateTime?** |  | [optional] 
**LastShipDate** | **DateTime?** |  | [optional] 
**DeliverOnDate** | **DateTime?** |  | [optional] 
**NeedByDate** | **DateTime?** |  | [optional] 
**CarrierId** | **int?** |  | [optional] 
**ShipVia** | **string** |  | [optional] 
**MediaCode** | **string** |  | [optional] 
**LegacyRestrictionType** | **string** |  | [optional] 
**AlcoholOrderType** | **string** |  | [optional] 
**AlternateUsage** | **string** |  | [optional] 
**AuthorizationAmount** | **decimal?** |  | [optional] 
**AuthorizedBy** | **string** |  | [optional] 
**BalanceDue** | **decimal?** |  | [optional] 
**BatchNo** | **string** |  | [optional] 
**BillToAttention** | **string** |  | [optional] 
**BillToCompany** | **string** |  | [optional] 
**BillToStreet** | **string** |  | [optional] 
**BillToStreet2** | **string** |  | [optional] 
**BillToStreet3** | **string** |  | [optional] 
**BillToCity** | **string** |  | [optional] 
**BillToState** | **string** |  | [optional] 
**BillToZip** | **string** |  | [optional] 
**BillToCountry** | **string** |  | [optional] 
**BillToPhone** | **string** |  | [optional] 
**BillToEmail** | **string** |  | [optional] 
**NumberOfCartons** | **int?** |  | [optional] 
**NumberOfPallets** | **int?** |  | [optional] 
**CompletionStatus** | **string** |  | [optional] 
**ParcelAccountId** | **int?** |  | [optional] 
**ThirdPartyParcelAccountId** | **int?** |  | [optional] 
**CostCenter** | **string** |  | [optional] 
**CreateDate** | **DateTime?** |  | [optional] 
**CustomerPONo** | **string** |  | [optional] 
**DistributionChannel** | **string** |  | [optional] 
**DistributionCharges** | **decimal?** |  | [optional] 
**Division** | **int?** |  | [optional] 
**EnteredBy** | **string** |  | [optional] 
**PreAllocationEstimatedWeight** | **decimal?** |  | [optional] 
**EstimatedWeightLbs** | **decimal?** |  | [optional] 
**Freight** | **decimal?** |  | [optional] 
**FulfillabilityDetails** | **string** |  | [optional] 
**GiftMessageTo** | **string** |  | [optional] 
**GiftMessageFrom** | **string** |  | [optional] 
**GiftMessage** | **string** |  | [optional] 
**GroupOrderId** | **decimal?** |  | [optional] 
**ParentKODOrderId** | **decimal?** |  | [optional] 
**HoldCode** | **string** |  | [optional] 
**IntegrationPartnerId** | **int?** |  | [optional] 
**NumberOfLineItems** | **int?** |  | [optional] 
**EstimatedNumberOfPicks** | **int?** |  | [optional] 
**ModifyDate** | **DateTime?** |  | [optional] 
**OmsOrderID** | **int?** |  | [optional] 
**OmsOrderNo** | **int?** |  | [optional] 
**OmsCustomerId** | **int?** |  | [optional] 
**OrderLoadProgramId** | **int?** |  | [optional] 
**OrderMessage** | **string** |  | [optional] 
**OrderReason** | **int?** |  | [optional] 
**OrderSourceId** | **int?** |  | [optional] 
**PackingSlipTemplateId** | **int?** |  | [optional] 
**OrderInvoiceTemplateId** | **int?** |  | [optional] 
**OrderEmailTemplateId** | **int?** |  | [optional] 
**ShipmentEmailTemplateId** | **int?** |  | [optional] 
**OutForDeliveryEmailTemplateId** | **int?** |  | [optional] 
**DeliveredEmailTemplateId** | **int?** |  | [optional] 
**PriceLevel** | **string** |  | [optional] 
**PriceMode** | **string** |  | [optional] 
**PriorityCode** | **int?** |  | [optional] 
**FulfillmentProcessId** | **int?** |  | [optional] 
**ShipBy** | **DateTime?** |  | [optional] 
**ShipCode** | **string** |  | [optional] 
**ShipDate** | **DateTime?** |  | [optional] 
**ShippedDate** | **DateTime?** |  | [optional] 
**ShipToAttention** | **string** |  | [optional] 
**ShipToCompany** | **string** |  | [optional] 
**ShipToStreet** | **string** |  | [optional] 
**ShipToStreet2** | **string** |  | [optional] 
**ShipToStreet3** | **string** |  | [optional] 
**ShipToCity** | **string** |  | [optional] 
**ShipToState** | **string** |  | [optional] 
**ShipToZip** | **string** |  | [optional] 
**ShipToCountry** | **string** |  | [optional] 
**ShipToPhone** | **string** |  | [optional] 
**ShipToEmail** | **string** |  | [optional] 
**ShippingCharge** | **decimal?** |  | [optional] 
**Status** | **string** |  | [optional] 
**StopBackOrders** | **string** |  | [optional] 
**Subtotal** | **decimal?** |  | [optional] 
**Tax** | **decimal?** |  | [optional] 
**Total** | **decimal?** |  | [optional] 
**TotalDiscount** | **decimal?** |  | [optional] 
**TotalPaid** | **decimal?** |  | [optional] 
**TotalQty** | **int?** |  | [optional] 
**WeightLbs** | **decimal?** |  | [optional] 
**OrderAssemblyInstructions** | **string** |  | [optional] 
**ParcelLabelRef1** | **string** |  | [optional] 
**ParcelLabelRef2** | **string** |  | [optional] 
**ParcelLabelRef3** | **string** |  | [optional] 
**LineItems** | [**List&lt;OrderLine&gt;**](OrderLine.md) |  | 
**RequestedParcelAccessories** | [**List&lt;ReqParcelAccessoryData&gt;**](ReqParcelAccessoryData.md) |  | [optional] 
**ExtraOrderData** | [**List&lt;OrderExtraOrderData&gt;**](OrderExtraOrderData.md) |  | [optional] 
**ExtraLineItemData** | [**List&lt;OrderExtraLineItemData&gt;**](OrderExtraLineItemData.md) |  | [optional] 
**ExternalShippingSystemId** | **int?** |  | [optional] 
**ServiceTypeId** | **string** |  | [optional] 
**WarehouseServiceTypeId** | **int?** |  | [optional] 
**WarehouseServiceLevelId** | **int?** |  | [optional] 
**SlaDate** | **DateTime?** |  | [optional] 
**SlaStatus** | **string** |  | [optional] 
**ProductionType** | **string** |  | [optional] 
**BackOrderStatus** | **string** |  | [optional] 
**BackOrderReleaseDate** | **DateTime?** |  | [optional] 
**EstimatedNumberOfCartons** | **int?** |  | [optional] 
**EstimatedCartonizationPlan** | **string** |  | [optional] 
**ManifestScriptId** | **int?** |  | [optional] 
**StoreNo** | **string** |  | [optional] 
**StoreName** | **string** |  | [optional] 
**DepartmentNo** | **string** |  | [optional] 
**DepartmentName** | **string** |  | [optional] 
**VendorNo** | **string** |  | [optional] 
**InternalUse91** | **string** |  | [optional] 
**DeliveryDays** | **int?** |  | [optional] 
**DeliveryDateGuaranteed** | **bool?** |  | [optional] [default to false]
**Fulfillability** | **string** |  | [optional] 
**CustomFields** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

