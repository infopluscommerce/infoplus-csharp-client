# Infoplus.Api.ProductionLotApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProductionLot**](ProductionLotApi.md#addproductionlot) | **POST** /beta/productionLot | Create a productionLot
[**AddProductionLotAudit**](ProductionLotApi.md#addproductionlotaudit) | **PUT** /beta/productionLot/{productionLotId}/audit/{productionLotAudit} | Add new audit for a productionLot
[**AddProductionLotTag**](ProductionLotApi.md#addproductionlottag) | **PUT** /beta/productionLot/{productionLotId}/tag/{productionLotTag} | Add new tags for a productionLot.
[**DeleteProductionLot**](ProductionLotApi.md#deleteproductionlot) | **DELETE** /beta/productionLot/{productionLotId} | Delete a productionLot
[**DeleteProductionLotTag**](ProductionLotApi.md#deleteproductionlottag) | **DELETE** /beta/productionLot/{productionLotId}/tag/{productionLotTag} | Delete a tag for a productionLot.
[**GetDuplicateProductionLotById**](ProductionLotApi.md#getduplicateproductionlotbyid) | **GET** /beta/productionLot/duplicate/{productionLotId} | Get a duplicated a productionLot by id
[**GetProductionLotByFilter**](ProductionLotApi.md#getproductionlotbyfilter) | **GET** /beta/productionLot/search | Search productionLots by filter
[**GetProductionLotById**](ProductionLotApi.md#getproductionlotbyid) | **GET** /beta/productionLot/{productionLotId} | Get a productionLot by id
[**GetProductionLotTags**](ProductionLotApi.md#getproductionlottags) | **GET** /beta/productionLot/{productionLotId}/tag | Get the tags for a productionLot.
[**UpdateProductionLot**](ProductionLotApi.md#updateproductionlot) | **PUT** /beta/productionLot | Update a productionLot
[**UpdateProductionLotCustomFields**](ProductionLotApi.md#updateproductionlotcustomfields) | **PUT** /beta/productionLot/customFields | Update a productionLot custom fields


<a name="addproductionlot"></a>
# **AddProductionLot**
> ProductionLot AddProductionLot (ProductionLot body)

Create a productionLot

Inserts a new productionLot using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductionLotExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var body = new ProductionLot(); // ProductionLot | ProductionLot to be inserted.

            try
            {
                // Create a productionLot
                ProductionLot result = apiInstance.AddProductionLot(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.AddProductionLot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductionLot**](ProductionLot.md)| ProductionLot to be inserted. | 

### Return type

[**ProductionLot**](ProductionLot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductionlotaudit"></a>
# **AddProductionLotAudit**
> void AddProductionLotAudit (int? productionLotId, string productionLotAudit)

Add new audit for a productionLot

Adds an audit to an existing productionLot.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductionLotAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to add an audit to
            var productionLotAudit = productionLotAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a productionLot
                apiInstance.AddProductionLotAudit(productionLotId, productionLotAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.AddProductionLotAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to add an audit to | 
 **productionLotAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductionlottag"></a>
# **AddProductionLotTag**
> void AddProductionLotTag (int? productionLotId, string productionLotTag)

Add new tags for a productionLot.

Adds a tag to an existing productionLot.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductionLotTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to add a tag to
            var productionLotTag = productionLotTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a productionLot.
                apiInstance.AddProductionLotTag(productionLotId, productionLotTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.AddProductionLotTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to add a tag to | 
 **productionLotTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductionlot"></a>
# **DeleteProductionLot**
> void DeleteProductionLot (int? productionLotId)

Delete a productionLot

Deletes the productionLot identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteProductionLotExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to be deleted.

            try
            {
                // Delete a productionLot
                apiInstance.DeleteProductionLot(productionLotId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.DeleteProductionLot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductionlottag"></a>
# **DeleteProductionLotTag**
> void DeleteProductionLotTag (int? productionLotId, string productionLotTag)

Delete a tag for a productionLot.

Deletes an existing productionLot tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteProductionLotTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to remove tag from
            var productionLotTag = productionLotTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a productionLot.
                apiInstance.DeleteProductionLotTag(productionLotId, productionLotTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.DeleteProductionLotTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to remove tag from | 
 **productionLotTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateproductionlotbyid"></a>
# **GetDuplicateProductionLotById**
> ProductionLot GetDuplicateProductionLotById (int? productionLotId)

Get a duplicated a productionLot by id

Returns a duplicated productionLot identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateProductionLotByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to be duplicated.

            try
            {
                // Get a duplicated a productionLot by id
                ProductionLot result = apiInstance.GetDuplicateProductionLotById(productionLotId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.GetDuplicateProductionLotById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to be duplicated. | 

### Return type

[**ProductionLot**](ProductionLot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductionlotbyfilter"></a>
# **GetProductionLotByFilter**
> List<ProductionLot> GetProductionLotByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search productionLots by filter

Returns the list of productionLots that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionLotByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search productionLots by filter
                List&lt;ProductionLot&gt; result = apiInstance.GetProductionLotByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.GetProductionLotByFilter: " + e.Message );
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

[**List<ProductionLot>**](ProductionLot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductionlotbyid"></a>
# **GetProductionLotById**
> ProductionLot GetProductionLotById (int? productionLotId)

Get a productionLot by id

Returns the productionLot identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionLotByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to be returned.

            try
            {
                // Get a productionLot by id
                ProductionLot result = apiInstance.GetProductionLotById(productionLotId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.GetProductionLotById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to be returned. | 

### Return type

[**ProductionLot**](ProductionLot.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductionlottags"></a>
# **GetProductionLotTags**
> void GetProductionLotTags (int? productionLotId)

Get the tags for a productionLot.

Get all existing productionLot tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductionLotTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var productionLotId = 56;  // int? | Id of the productionLot to get tags for

            try
            {
                // Get the tags for a productionLot.
                apiInstance.GetProductionLotTags(productionLotId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.GetProductionLotTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productionLotId** | **int?**| Id of the productionLot to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductionlot"></a>
# **UpdateProductionLot**
> void UpdateProductionLot (ProductionLot body)

Update a productionLot

Updates an existing productionLot using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateProductionLotExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var body = new ProductionLot(); // ProductionLot | ProductionLot to be updated.

            try
            {
                // Update a productionLot
                apiInstance.UpdateProductionLot(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.UpdateProductionLot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductionLot**](ProductionLot.md)| ProductionLot to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductionlotcustomfields"></a>
# **UpdateProductionLotCustomFields**
> void UpdateProductionLotCustomFields (ProductionLot body)

Update a productionLot custom fields

Updates an existing productionLot custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateProductionLotCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductionLotApi();
            var body = new ProductionLot(); // ProductionLot | ProductionLot to be updated.

            try
            {
                // Update a productionLot custom fields
                apiInstance.UpdateProductionLotCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductionLotApi.UpdateProductionLotCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductionLot**](ProductionLot.md)| ProductionLot to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

