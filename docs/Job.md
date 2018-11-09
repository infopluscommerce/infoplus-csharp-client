# Infoplus.Model.Job
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**CreateDate** | **DateTime?** |  | [optional] 
**ModifyDate** | **DateTime?** |  | [optional] 
**SourceJobRecipeId** | **int?** |  | [optional] 
**AssemblyQuantity** | **int?** |  | 
**WarehouseId** | **int?** |  | 
**LobId** | **int?** |  | 
**Status** | **string** |  | [optional] 
**OrderNoId** | **decimal?** |  | [optional] 
**PoNoId** | **int?** |  | [optional] 
**WorkBatchId** | **int?** |  | [optional] 
**Layout** | **string** |  | 
**TrackAssemblies** | **bool?** |  | [default to false]
**TrackSteps** | **bool?** |  | [default to false]
**JobNo** | **string** |  | [optional] 
**AssemblyInstructions** | **string** |  | [optional] 
**Inputs** | [**List&lt;JobInput&gt;**](JobInput.md) |  | [optional] 
**Outputs** | [**List&lt;JobOutput&gt;**](JobOutput.md) |  | [optional] 
**Steps** | [**List&lt;JobStep&gt;**](JobStep.md) |  | [optional] 
**FulfillmentPlanId** | **int?** |  | 
**TotalPicks** | **int?** |  | [optional] 
**CompletedPicks** | **int?** |  | [optional] 
**TotalAssemblies** | **int?** |  | [optional] 
**CompletedAssemblies** | **int?** |  | [optional] 
**TotalSteps** | **int?** |  | [optional] 
**CompletedSteps** | **int?** |  | [optional] 
**TotalReceipts** | **int?** |  | [optional] 
**CompletedReceipts** | **int?** |  | [optional] 
**TotalToDo** | **int?** |  | [optional] 
**CompletedToDo** | **int?** |  | [optional] 
**CustomFields** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

