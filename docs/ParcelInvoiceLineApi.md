# Infoplus.Api.ParcelInvoiceLineApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddParcelInvoiceLineAudit**](ParcelInvoiceLineApi.md#addparcelinvoicelineaudit) | **PUT** /beta/parcelInvoiceLine/{parcelInvoiceLineId}/audit/{parcelInvoiceLineAudit} | Add new audit for a parcelInvoiceLine
[**AddParcelInvoiceLineFile**](ParcelInvoiceLineApi.md#addparcelinvoicelinefile) | **POST** /beta/parcelInvoiceLine/{parcelInvoiceLineId}/file/{fileName} | Attach a file to a parcelInvoiceLine
[**AddParcelInvoiceLineTag**](ParcelInvoiceLineApi.md#addparcelinvoicelinetag) | **PUT** /beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag/{parcelInvoiceLineTag} | Add new tags for a parcelInvoiceLine.
[**DeleteParcelInvoiceLineTag**](ParcelInvoiceLineApi.md#deleteparcelinvoicelinetag) | **DELETE** /beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag/{parcelInvoiceLineTag} | Delete a tag for a parcelInvoiceLine.
[**GetDuplicateParcelInvoiceLineById**](ParcelInvoiceLineApi.md#getduplicateparcelinvoicelinebyid) | **GET** /beta/parcelInvoiceLine/duplicate/{parcelInvoiceLineId} | Get a duplicated a parcelInvoiceLine by id
[**GetParcelInvoiceLineByFilter**](ParcelInvoiceLineApi.md#getparcelinvoicelinebyfilter) | **GET** /beta/parcelInvoiceLine/search | Search parcelInvoiceLines by filter
[**GetParcelInvoiceLineById**](ParcelInvoiceLineApi.md#getparcelinvoicelinebyid) | **GET** /beta/parcelInvoiceLine/{parcelInvoiceLineId} | Get a parcelInvoiceLine by id
[**GetParcelInvoiceLineTags**](ParcelInvoiceLineApi.md#getparcelinvoicelinetags) | **GET** /beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag | Get the tags for a parcelInvoiceLine.
[**UpdateParcelInvoiceLine**](ParcelInvoiceLineApi.md#updateparcelinvoiceline) | **PUT** /beta/parcelInvoiceLine | Update a parcelInvoiceLine


<a name="addparcelinvoicelineaudit"></a>
# **AddParcelInvoiceLineAudit**
> void AddParcelInvoiceLineAudit (int? parcelInvoiceLineId, string parcelInvoiceLineAudit)

Add new audit for a parcelInvoiceLine

Adds an audit to an existing parcelInvoiceLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelInvoiceLineAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var parcelInvoiceLineId = 56;  // int? | Id of the parcelInvoiceLine to add an audit to
            var parcelInvoiceLineAudit = parcelInvoiceLineAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a parcelInvoiceLine
                apiInstance.AddParcelInvoiceLineAudit(parcelInvoiceLineId, parcelInvoiceLineAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.AddParcelInvoiceLineAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceLineId** | **int?**| Id of the parcelInvoiceLine to add an audit to | 
 **parcelInvoiceLineAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelinvoicelinefile"></a>
# **AddParcelInvoiceLineFile**
> void AddParcelInvoiceLineFile (int? parcelInvoiceLineId, string fileName)

Attach a file to a parcelInvoiceLine

Adds a file to an existing parcelInvoiceLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelInvoiceLineFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var parcelInvoiceLineId = 56;  // int? | Id of the parcelInvoiceLine to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a parcelInvoiceLine
                apiInstance.AddParcelInvoiceLineFile(parcelInvoiceLineId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.AddParcelInvoiceLineFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceLineId** | **int?**| Id of the parcelInvoiceLine to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelinvoicelinetag"></a>
# **AddParcelInvoiceLineTag**
> void AddParcelInvoiceLineTag (int? parcelInvoiceLineId, string parcelInvoiceLineTag)

Add new tags for a parcelInvoiceLine.

Adds a tag to an existing parcelInvoiceLine.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelInvoiceLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var parcelInvoiceLineId = 56;  // int? | Id of the parcelInvoiceLine to add a tag to
            var parcelInvoiceLineTag = parcelInvoiceLineTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a parcelInvoiceLine.
                apiInstance.AddParcelInvoiceLineTag(parcelInvoiceLineId, parcelInvoiceLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.AddParcelInvoiceLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceLineId** | **int?**| Id of the parcelInvoiceLine to add a tag to | 
 **parcelInvoiceLineTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparcelinvoicelinetag"></a>
# **DeleteParcelInvoiceLineTag**
> void DeleteParcelInvoiceLineTag (int? parcelInvoiceLineId, string parcelInvoiceLineTag)

Delete a tag for a parcelInvoiceLine.

Deletes an existing parcelInvoiceLine tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteParcelInvoiceLineTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var parcelInvoiceLineId = 56;  // int? | Id of the parcelInvoiceLine to remove tag from
            var parcelInvoiceLineTag = parcelInvoiceLineTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a parcelInvoiceLine.
                apiInstance.DeleteParcelInvoiceLineTag(parcelInvoiceLineId, parcelInvoiceLineTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.DeleteParcelInvoiceLineTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceLineId** | **int?**| Id of the parcelInvoiceLine to remove tag from | 
 **parcelInvoiceLineTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateparcelinvoicelinebyid"></a>
# **GetDuplicateParcelInvoiceLineById**
> ParcelInvoiceLine GetDuplicateParcelInvoiceLineById (int? parcelInvoiceLineId)

Get a duplicated a parcelInvoiceLine by id

Returns a duplicated parcelInvoiceLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateParcelInvoiceLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var parcelInvoiceLineId = 56;  // int? | Id of the parcelInvoiceLine to be duplicated.

            try
            {
                // Get a duplicated a parcelInvoiceLine by id
                ParcelInvoiceLine result = apiInstance.GetDuplicateParcelInvoiceLineById(parcelInvoiceLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.GetDuplicateParcelInvoiceLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceLineId** | **int?**| Id of the parcelInvoiceLine to be duplicated. | 

### Return type

[**ParcelInvoiceLine**](ParcelInvoiceLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelinvoicelinebyfilter"></a>
# **GetParcelInvoiceLineByFilter**
> List<ParcelInvoiceLine> GetParcelInvoiceLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search parcelInvoiceLines by filter

Returns the list of parcelInvoiceLines that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelInvoiceLineByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search parcelInvoiceLines by filter
                List&lt;ParcelInvoiceLine&gt; result = apiInstance.GetParcelInvoiceLineByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.GetParcelInvoiceLineByFilter: " + e.Message );
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

[**List<ParcelInvoiceLine>**](ParcelInvoiceLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelinvoicelinebyid"></a>
# **GetParcelInvoiceLineById**
> ParcelInvoiceLine GetParcelInvoiceLineById (int? parcelInvoiceLineId)

Get a parcelInvoiceLine by id

Returns the parcelInvoiceLine identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelInvoiceLineByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var parcelInvoiceLineId = 56;  // int? | Id of the parcelInvoiceLine to be returned.

            try
            {
                // Get a parcelInvoiceLine by id
                ParcelInvoiceLine result = apiInstance.GetParcelInvoiceLineById(parcelInvoiceLineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.GetParcelInvoiceLineById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceLineId** | **int?**| Id of the parcelInvoiceLine to be returned. | 

### Return type

[**ParcelInvoiceLine**](ParcelInvoiceLine.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelinvoicelinetags"></a>
# **GetParcelInvoiceLineTags**
> void GetParcelInvoiceLineTags (int? parcelInvoiceLineId)

Get the tags for a parcelInvoiceLine.

Get all existing parcelInvoiceLine tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelInvoiceLineTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var parcelInvoiceLineId = 56;  // int? | Id of the parcelInvoiceLine to get tags for

            try
            {
                // Get the tags for a parcelInvoiceLine.
                apiInstance.GetParcelInvoiceLineTags(parcelInvoiceLineId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.GetParcelInvoiceLineTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceLineId** | **int?**| Id of the parcelInvoiceLine to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateparcelinvoiceline"></a>
# **UpdateParcelInvoiceLine**
> void UpdateParcelInvoiceLine (ParcelInvoiceLine body)

Update a parcelInvoiceLine

Updates an existing parcelInvoiceLine using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateParcelInvoiceLineExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceLineApi();
            var body = new ParcelInvoiceLine(); // ParcelInvoiceLine | ParcelInvoiceLine to be updated.

            try
            {
                // Update a parcelInvoiceLine
                apiInstance.UpdateParcelInvoiceLine(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceLineApi.UpdateParcelInvoiceLine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ParcelInvoiceLine**](ParcelInvoiceLine.md)| ParcelInvoiceLine to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

