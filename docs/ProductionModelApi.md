# Infoplus.Api.ProductionModelApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProductionModel**](ProductionModelApi.md#addproductionmodel) | **POST** /beta/productionModel | Create a productionModel
[**AddProductionModelAudit**](ProductionModelApi.md#addproductionmodelaudit) | **PUT** /beta/productionModel/{productionModelId}/audit/{productionModelAudit} | Add new audit for a productionModel
[**AddProductionModelFile**](ProductionModelApi.md#addproductionmodelfile) | **POST** /beta/productionModel/{productionModelId}/file/{fileName} | Attach a file to a productionModel
[**AddProductionModelTag**](ProductionModelApi.md#addproductionmodeltag) | **PUT** /beta/productionModel/{productionModelId}/tag/{productionModelTag} | Add new tags for a productionModel.
[**DeleteProductionModel**](ProductionModelApi.md#deleteproductionmodel) | **DELETE** /beta/productionModel/{productionModelId} | Delete a productionModel
[**DeleteProductionModelTag**](ProductionModelApi.md#deleteproductionmodeltag) | **DELETE** /beta/productionModel/{productionModelId}/tag/{productionModelTag} | Delete a tag for a productionModel.
[**GetDuplicateProductionModelById**](ProductionModelApi.md#getduplicateproductionmodelbyid) | **GET** /beta/productionModel/duplicate/{productionModelId} | Get a duplicated a productionModel by id
[**GetProductionModelByFilter**](ProductionModelApi.md#getproductionmodelbyfilter) | **GET** /beta/productionModel/search | Search productionModels by filter
[**GetProductionModelById**](ProductionModelApi.md#getproductionmodelbyid) | **GET** /beta/productionModel/{productionModelId} | Get a productionModel by id
[**GetProductionModelTags**](ProductionModelApi.md#getproductionmodeltags) | **GET** /beta/productionModel/{productionModelId}/tag | Get the tags for a productionModel.
[**UpdateProductionModel**](ProductionModelApi.md#updateproductionmodel) | **PUT** /beta/productionModel | Update a productionModel
[**UpdateProductionModelCustomFields**](ProductionModelApi.md#updateproductionmodelcustomfields) | **PUT** /beta/productionModel/customFields | Update a productionModel custom fields


<a name="addproductionmodel"></a>
# **AddProductionModel**
> ProductionModel AddProductionModel (ProductionModel body)

Create a productionModel

Inserts a new productionModel using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductionModelExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var body = new ProductionModel(); // ProductionModel | ProductionModel to be inserted.

            try
            {
                // Create a productionModel
                ProductionModel result = apiInstance.AddProductionModel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.AddProductionModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductionModel**](ProductionModel.md)| ProductionModel to be inserted. | 

### Return type

[**ProductionModel**](ProductionModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductionmodelaudit"></a>
# **AddProductionModelAudit**
> void AddProductionModelAudit (int? productionModelId, string productionModelAudit)

Add new audit for a productionModel

Adds an audit to an existing productionModel.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductionModelAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to add an audit to
            var productionModelAudit = productionModelAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a productionModel
                apiInstance.AddProductionModelAudit(productionModelId, productionModelAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.AddProductionModelAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to add an audit to | 
 **productionModelAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductionmodelfile"></a>
# **AddProductionModelFile**
> void AddProductionModelFile (int? productionModelId, string fileName)

Attach a file to a productionModel

Adds a file to an existing productionModel.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductionModelFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a productionModel
                apiInstance.AddProductionModelFile(productionModelId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.AddProductionModelFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductionmodeltag"></a>
# **AddProductionModelTag**
> void AddProductionModelTag (int? productionModelId, string productionModelTag)

Add new tags for a productionModel.

Adds a tag to an existing productionModel.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductionModelTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to add a tag to
            var productionModelTag = productionModelTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a productionModel.
                apiInstance.AddProductionModelTag(productionModelId, productionModelTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.AddProductionModelTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to add a tag to | 
 **productionModelTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductionmodel"></a>
# **DeleteProductionModel**
> void DeleteProductionModel (int? productionModelId)

Delete a productionModel

Deletes the productionModel identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteProductionModelExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to be deleted.

            try
            {
                // Delete a productionModel
                apiInstance.DeleteProductionModel(productionModelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.DeleteProductionModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductionmodeltag"></a>
# **DeleteProductionModelTag**
> void DeleteProductionModelTag (int? productionModelId, string productionModelTag)

Delete a tag for a productionModel.

Deletes an existing productionModel tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteProductionModelTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to remove tag from
            var productionModelTag = productionModelTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a productionModel.
                apiInstance.DeleteProductionModelTag(productionModelId, productionModelTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.DeleteProductionModelTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to remove tag from | 
 **productionModelTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateproductionmodelbyid"></a>
# **GetDuplicateProductionModelById**
> ProductionModel GetDuplicateProductionModelById (int? productionModelId)

Get a duplicated a productionModel by id

Returns a duplicated productionModel identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateProductionModelByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to be duplicated.

            try
            {
                // Get a duplicated a productionModel by id
                ProductionModel result = apiInstance.GetDuplicateProductionModelById(productionModelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.GetDuplicateProductionModelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to be duplicated. | 

### Return type

[**ProductionModel**](ProductionModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductionmodelbyfilter"></a>
# **GetProductionModelByFilter**
> List<ProductionModel> GetProductionModelByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search productionModels by filter

Returns the list of productionModels that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionModelByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search productionModels by filter
                List&lt;ProductionModel&gt; result = apiInstance.GetProductionModelByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.GetProductionModelByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Query string, used to filter results. | [optional] 
 **page** | **int?**| Result page number.  Defaults to 1. | [optional] 
 **limit** | **int?**| Maximum results per page.  Defaults to 20.  Max allowed value is 250. | [optional] 
 **sort** | **string**| Sort results by specified field. | [optional] 

### Return type

[**List<ProductionModel>**](ProductionModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductionmodelbyid"></a>
# **GetProductionModelById**
> ProductionModel GetProductionModelById (int? productionModelId)

Get a productionModel by id

Returns the productionModel identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionModelByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to be returned.

            try
            {
                // Get a productionModel by id
                ProductionModel result = apiInstance.GetProductionModelById(productionModelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.GetProductionModelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to be returned. | 

### Return type

[**ProductionModel**](ProductionModel.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductionmodeltags"></a>
# **GetProductionModelTags**
> void GetProductionModelTags (int? productionModelId)

Get the tags for a productionModel.

Get all existing productionModel tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionModelTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var productionModelId = 56;  // int? | Id of the productionModel to get tags for

            try
            {
                // Get the tags for a productionModel.
                apiInstance.GetProductionModelTags(productionModelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.GetProductionModelTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionModelId** | **int?**| Id of the productionModel to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductionmodel"></a>
# **UpdateProductionModel**
> void UpdateProductionModel (ProductionModel body)

Update a productionModel

Updates an existing productionModel using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateProductionModelExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var body = new ProductionModel(); // ProductionModel | ProductionModel to be updated.

            try
            {
                // Update a productionModel
                apiInstance.UpdateProductionModel(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.UpdateProductionModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductionModel**](ProductionModel.md)| ProductionModel to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductionmodelcustomfields"></a>
# **UpdateProductionModelCustomFields**
> void UpdateProductionModelCustomFields (ProductionModel body)

Update a productionModel custom fields

Updates an existing productionModel custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateProductionModelCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionModelApi();
            var body = new ProductionModel(); // ProductionModel | ProductionModel to be updated.

            try
            {
                // Update a productionModel custom fields
                apiInstance.UpdateProductionModelCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionModelApi.UpdateProductionModelCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductionModel**](ProductionModel.md)| ProductionModel to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

