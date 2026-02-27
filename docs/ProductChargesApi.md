# Infoplus.Api.ProductChargesApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProductCharges**](ProductChargesApi.md#addproductcharges) | **POST** /beta/productCharges | Create a productCharges
[**AddProductChargesAudit**](ProductChargesApi.md#addproductchargesaudit) | **PUT** /beta/productCharges/{productChargesId}/audit/{productChargesAudit} | Add new audit for a productCharges
[**AddProductChargesFile**](ProductChargesApi.md#addproductchargesfile) | **POST** /beta/productCharges/{productChargesId}/file/{fileName} | Attach a file to a productCharges
[**AddProductChargesFileByURL**](ProductChargesApi.md#addproductchargesfilebyurl) | **POST** /beta/productCharges/{productChargesId}/file | Attach a file to a productCharges by URL.
[**AddProductChargesTag**](ProductChargesApi.md#addproductchargestag) | **PUT** /beta/productCharges/{productChargesId}/tag/{productChargesTag} | Add new tags for a productCharges.
[**DeleteProductCharges**](ProductChargesApi.md#deleteproductcharges) | **DELETE** /beta/productCharges/{productChargesId} | Delete a productCharges
[**DeleteProductChargesFile**](ProductChargesApi.md#deleteproductchargesfile) | **DELETE** /beta/productCharges/{productChargesId}/file/{fileId} | Delete a file for a productCharges.
[**DeleteProductChargesTag**](ProductChargesApi.md#deleteproductchargestag) | **DELETE** /beta/productCharges/{productChargesId}/tag/{productChargesTag} | Delete a tag for a productCharges.
[**GetDuplicateProductChargesById**](ProductChargesApi.md#getduplicateproductchargesbyid) | **GET** /beta/productCharges/duplicate/{productChargesId} | Get a duplicated a productCharges by id
[**GetProductChargesByFilter**](ProductChargesApi.md#getproductchargesbyfilter) | **GET** /beta/productCharges/search | Search productChargeses by filter
[**GetProductChargesById**](ProductChargesApi.md#getproductchargesbyid) | **GET** /beta/productCharges/{productChargesId} | Get a productCharges by id
[**GetProductChargesFiles**](ProductChargesApi.md#getproductchargesfiles) | **GET** /beta/productCharges/{productChargesId}/file | Get the files for a productCharges.
[**GetProductChargesTags**](ProductChargesApi.md#getproductchargestags) | **GET** /beta/productCharges/{productChargesId}/tag | Get the tags for a productCharges.
[**UpdateProductCharges**](ProductChargesApi.md#updateproductcharges) | **PUT** /beta/productCharges | Update a productCharges


<a name="addproductcharges"></a>
# **AddProductCharges**
> ProductCharges AddProductCharges (ProductCharges body)

Create a productCharges

Inserts a new productCharges using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductChargesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var body = new ProductCharges(); // ProductCharges | ProductCharges to be inserted.

            try
            {
                // Create a productCharges
                ProductCharges result = apiInstance.AddProductCharges(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.AddProductCharges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductCharges**](ProductCharges.md)| ProductCharges to be inserted. | 

### Return type

[**ProductCharges**](ProductCharges.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductchargesaudit"></a>
# **AddProductChargesAudit**
> void AddProductChargesAudit (int? productChargesId, string productChargesAudit)

Add new audit for a productCharges

Adds an audit to an existing productCharges.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductChargesAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to add an audit to
            var productChargesAudit = productChargesAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a productCharges
                apiInstance.AddProductChargesAudit(productChargesId, productChargesAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.AddProductChargesAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to add an audit to | 
 **productChargesAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductchargesfile"></a>
# **AddProductChargesFile**
> void AddProductChargesFile (int? productChargesId, string fileName)

Attach a file to a productCharges

Adds a file to an existing productCharges.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductChargesFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a productCharges
                apiInstance.AddProductChargesFile(productChargesId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.AddProductChargesFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductchargesfilebyurl"></a>
# **AddProductChargesFileByURL**
> void AddProductChargesFileByURL (RecordFile body, int? productChargesId)

Attach a file to a productCharges by URL.

Adds a file to an existing productCharges by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductChargesFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var productChargesId = 56;  // int? | Id of the productCharges to add an file to

            try
            {
                // Attach a file to a productCharges by URL.
                apiInstance.AddProductChargesFileByURL(body, productChargesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.AddProductChargesFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **productChargesId** | **int?**| Id of the productCharges to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addproductchargestag"></a>
# **AddProductChargesTag**
> void AddProductChargesTag (int? productChargesId, string productChargesTag)

Add new tags for a productCharges.

Adds a tag to an existing productCharges.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddProductChargesTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to add a tag to
            var productChargesTag = productChargesTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a productCharges.
                apiInstance.AddProductChargesTag(productChargesId, productChargesTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.AddProductChargesTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to add a tag to | 
 **productChargesTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductcharges"></a>
# **DeleteProductCharges**
> void DeleteProductCharges (int? productChargesId)

Delete a productCharges

Deletes the productCharges identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteProductChargesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to be deleted.

            try
            {
                // Delete a productCharges
                apiInstance.DeleteProductCharges(productChargesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.DeleteProductCharges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductchargesfile"></a>
# **DeleteProductChargesFile**
> void DeleteProductChargesFile (int? productChargesId, int? fileId)

Delete a file for a productCharges.

Deletes an existing productCharges file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteProductChargesFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a productCharges.
                apiInstance.DeleteProductChargesFile(productChargesId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.DeleteProductChargesFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductchargestag"></a>
# **DeleteProductChargesTag**
> void DeleteProductChargesTag (int? productChargesId, string productChargesTag)

Delete a tag for a productCharges.

Deletes an existing productCharges tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteProductChargesTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to remove tag from
            var productChargesTag = productChargesTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a productCharges.
                apiInstance.DeleteProductChargesTag(productChargesId, productChargesTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.DeleteProductChargesTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to remove tag from | 
 **productChargesTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateproductchargesbyid"></a>
# **GetDuplicateProductChargesById**
> ProductCharges GetDuplicateProductChargesById (int? productChargesId)

Get a duplicated a productCharges by id

Returns a duplicated productCharges identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateProductChargesByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to be duplicated.

            try
            {
                // Get a duplicated a productCharges by id
                ProductCharges result = apiInstance.GetDuplicateProductChargesById(productChargesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.GetDuplicateProductChargesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to be duplicated. | 

### Return type

[**ProductCharges**](ProductCharges.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductchargesbyfilter"></a>
# **GetProductChargesByFilter**
> List<ProductCharges> GetProductChargesByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search productChargeses by filter

Returns the list of productChargeses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductChargesByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search productChargeses by filter
                List&lt;ProductCharges&gt; result = apiInstance.GetProductChargesByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.GetProductChargesByFilter: " + e.Message );
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

[**List<ProductCharges>**](ProductCharges.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductchargesbyid"></a>
# **GetProductChargesById**
> ProductCharges GetProductChargesById (int? productChargesId)

Get a productCharges by id

Returns the productCharges identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductChargesByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to be returned.

            try
            {
                // Get a productCharges by id
                ProductCharges result = apiInstance.GetProductChargesById(productChargesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.GetProductChargesById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to be returned. | 

### Return type

[**ProductCharges**](ProductCharges.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductchargesfiles"></a>
# **GetProductChargesFiles**
> void GetProductChargesFiles (int? productChargesId)

Get the files for a productCharges.

Get all existing productCharges files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductChargesFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to get files for

            try
            {
                // Get the files for a productCharges.
                apiInstance.GetProductChargesFiles(productChargesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.GetProductChargesFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductchargestags"></a>
# **GetProductChargesTags**
> void GetProductChargesTags (int? productChargesId)

Get the tags for a productCharges.

Get all existing productCharges tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetProductChargesTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var productChargesId = 56;  // int? | Id of the productCharges to get tags for

            try
            {
                // Get the tags for a productCharges.
                apiInstance.GetProductChargesTags(productChargesId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.GetProductChargesTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productChargesId** | **int?**| Id of the productCharges to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductcharges"></a>
# **UpdateProductCharges**
> void UpdateProductCharges (ProductCharges body)

Update a productCharges

Updates an existing productCharges using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateProductChargesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ProductChargesApi();
            var body = new ProductCharges(); // ProductCharges | ProductCharges to be updated.

            try
            {
                // Update a productCharges
                apiInstance.UpdateProductCharges(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductChargesApi.UpdateProductCharges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductCharges**](ProductCharges.md)| ProductCharges to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

