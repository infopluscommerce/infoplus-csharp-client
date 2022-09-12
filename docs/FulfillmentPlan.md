# Infoplus.Model.FulfillmentPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**CreateDate** | **DateTime?** |  | [optional] 
**ModifyDate** | **DateTime?** |  | [optional] 
**Name** | **string** |  | 
**Description** | **string** |  | [optional] 
**WarehouseId** | **int?** |  | 
**PriorityCode** | **int?** |  | [optional] 
**LastRunTime** | **DateTime?** |  | [optional] 
**OrderSmartFilterId** | **int?** |  | 
**LocationSmartFilterId** | **int?** |  | [optional] 
**MaxOrders** | **int?** |  | [optional] 
**BatchSizeMax** | **int?** |  | [optional] 
**BatchSizeMin** | **int?** |  | [optional] 
**MaxCartons** | **int?** |  | [optional] 
**Version** | **string** |  | [optional] 
**IsMassDistribution** | **bool?** |  | [optional] [default to false]
**CreatePickWork** | **bool?** |  | [default to false]
**PickingRule** | **string** |  | [optional] 
**PickBatchGroupId** | **string** |  | [optional] 
**MaxSKUsPerBatch** | **int?** |  | [optional] 
**LayoutRule** | **string** |  | [optional] 
**PickSortRule** | **string** |  | [optional] 
**LocationSort** | **string** |  | [optional] 
**CreatePickList** | **bool?** |  | [optional] [default to false]
**PickListFormat** | **string** |  | [optional] 
**PickListLayout** | **string** |  | [optional] 
**PickListGroup** | **string** |  | [optional] 
**PickListSort** | **string** |  | [optional] 
**PickListLocationSort** | **string** |  | [optional] 
**CreatePickSummary** | **bool?** |  | [optional] [default to false]
**PickSummaryFormat** | **string** |  | [optional] 
**PickSummaryLayout** | **string** |  | [optional] 
**PickSummarySort** | **string** |  | [optional] 
**PickScanSchemeId** | **int?** |  | 
**CartonizeOrders** | **bool?** |  | [default to false]
**CartonizationScriptId** | **int?** |  | [optional] 
**AutoShipCasebreakCartons** | **bool?** |  | [optional] [default to false]
**AutoShipOrders** | **bool?** |  | [optional] [default to false]
**PreGenerateParcelLabels** | **bool?** |  | [optional] [default to false]
**LabelSort** | **string** |  | [optional] 
**CreatePackingSlip** | **string** |  | 
**OverridePackingSlipTemplateId** | **int?** |  | [optional] 
**CreateOrderAssemblyGuide** | **bool?** |  | [optional] [default to false]
**OrderAssemblyGuideLayout** | **string** |  | [optional] 
**CreateOrderInvoice** | **string** |  | 
**OverrideOrderInvoiceTemplateId** | **int?** |  | [optional] 
**CreateCartonGS1128Labels** | **string** |  | [optional] 
**CreateLineItemEachGS1128Labels** | **string** |  | [optional] 
**SendToExternalShippingSystem** | **bool?** |  | [default to false]
**ExternalShippingSystemId** | **int?** |  | [optional] 
**CustomFields** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

