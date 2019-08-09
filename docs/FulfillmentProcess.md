# Infoplus.Model.FulfillmentProcess
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**CreateDate** | **DateTime?** |  | [optional] 
**ModifyDate** | **DateTime?** |  | [optional] 
**ProcessNo** | **int?** |  | [optional] 
**WorkBatchId** | **int?** |  | [optional] 
**WarehouseId** | **int?** |  | 
**FulfillmentPlanId** | **int?** |  | 
**PickScanSchemeId** | **int?** |  | 
**Status** | **string** |  | 
**OrderSmartFilterId** | **int?** |  | [optional] 
**LocationSmartFilterId** | **int?** |  | [optional] 
**MaxOrders** | **int?** |  | [optional] 
**BatchMaxSize** | **int?** |  | [optional] 
**BatchMinSize** | **int?** |  | [optional] 
**MaxSKUs** | **int?** |  | [optional] 
**MaxCartons** | **int?** |  | [optional] 
**Version** | **string** |  | [optional] 
**FulfillmentProcessGroup** | **int?** |  | [optional] 
**IsMassDistribution** | **bool?** |  | [optional] [default to false]
**PriorityCode** | **int?** |  | [optional] 
**NumberOfOrders** | **int?** |  | [optional] 
**NumberOfLines** | **int?** |  | [optional] 
**NumberOfSKUs** | **int?** |  | [optional] 
**CompletedPicks** | **int?** |  | [optional] 
**TotalPicks** | **int?** |  | [optional] 
**ShippedCasebreaks** | **int?** |  | [optional] 
**TotalCasebreaksToShip** | **int?** |  | [optional] 
**ShippedOrders** | **int?** |  | [optional] 
**TotalOrdersToShip** | **int?** |  | [optional] 
**CompletedToDo** | **int?** |  | [optional] 
**TotalToDo** | **int?** |  | [optional] 
**CreatePickWork** | **bool?** |  | [optional] [default to false]
**PickingRule** | **string** |  | [optional] 
**LayoutRule** | **string** |  | [optional] 
**PickSortRule** | **string** |  | [optional] 
**LocationSort** | **string** |  | [optional] 
**FirstPickPosition** | **int?** |  | [optional] 
**PickListFormat** | **string** |  | [optional] 
**PickListLayout** | **string** |  | [optional] 
**PickListGroup** | **string** |  | [optional] 
**PickListSort** | **string** |  | [optional] 
**PickListLocationSort** | **string** |  | [optional] 
**PickSummaryFormat** | **string** |  | [optional] 
**PickSummaryLayout** | **string** |  | [optional] 
**PickSummarySort** | **string** |  | [optional] 
**CreatePickSummary** | **bool?** |  | [optional] [default to false]
**CreatePickList** | **bool?** |  | [optional] [default to false]
**PreGenerateParcelLabels** | **bool?** |  | [optional] [default to false]
**LabelSort** | **string** |  | [optional] 
**ShipDate** | **DateTime?** |  | [optional] 
**AutoShipCasebreakCartons** | **bool?** |  | [optional] [default to false]
**AutoShipOrders** | **bool?** |  | [optional] [default to false]
**CartonizeOrders** | **bool?** |  | [optional] [default to false]
**CartonizationScriptId** | **int?** |  | [optional] 
**CreatePackingSlip** | **string** |  | 
**OverridePackingSlipTemplateId** | **int?** |  | [optional] 
**CreateOrderAssemblyGuide** | **bool?** |  | [optional] [default to false]
**CreateOrderInvoice** | **string** |  | 
**OverrideOrderInvoiceTemplateId** | **int?** |  | [optional] 
**SendToExternalShippingSystem** | **bool?** |  | [default to false]
**ExternalShippingSystemId** | **int?** |  | [optional] 
**CustomFields** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

