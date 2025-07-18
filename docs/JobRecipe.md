# Infoplus.Model.JobRecipe
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**CreateDate** | **DateTime?** |  | [optional] 
**ModifyDate** | **DateTime?** |  | [optional] 
**WarehouseId** | **int?** |  | [optional] 
**LobId** | **int?** |  | 
**Name** | **string** |  | 
**AssemblyInstructions** | **string** |  | [optional] 
**Inputs** | [**List&lt;JobRecipeInput&gt;**](JobRecipeInput.md) |  | [optional] 
**Outputs** | [**List&lt;JobRecipeOutput&gt;**](JobRecipeOutput.md) |  | [optional] 
**Steps** | [**List&lt;JobRecipeStep&gt;**](JobRecipeStep.md) |  | [optional] 
**FulfillmentPlanId** | **int?** |  | 
**Layout** | **string** |  | 
**TrackAssemblies** | **bool?** |  | [default to false]
**TrackSteps** | **bool?** |  | [default to false]
**CustomFields** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

