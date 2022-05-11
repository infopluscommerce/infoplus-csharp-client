# Infoplus.Api.OverrideReturnAddressApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOverrideReturnAddress**](OverrideReturnAddressApi.md#addoverridereturnaddress) | **POST** /v3.0/overrideReturnAddress | Create an overrideReturnAddress
[**AddOverrideReturnAddressAudit**](OverrideReturnAddressApi.md#addoverridereturnaddressaudit) | **PUT** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/audit/{overrideReturnAddressAudit} | Add new audit for an overrideReturnAddress
[**AddOverrideReturnAddressFile**](OverrideReturnAddressApi.md#addoverridereturnaddressfile) | **POST** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/file/{fileName} | Attach a file to an overrideReturnAddress
[**AddOverrideReturnAddressFileByURL**](OverrideReturnAddressApi.md#addoverridereturnaddressfilebyurl) | **POST** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/file | Attach a file to an overrideReturnAddress by URL.
[**AddOverrideReturnAddressTag**](OverrideReturnAddressApi.md#addoverridereturnaddresstag) | **PUT** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/tag/{overrideReturnAddressTag} | Add new tags for an overrideReturnAddress.
[**DeleteOverrideReturnAddress**](OverrideReturnAddressApi.md#deleteoverridereturnaddress) | **DELETE** /v3.0/overrideReturnAddress/{overrideReturnAddressId} | Delete an overrideReturnAddress
[**DeleteOverrideReturnAddressFile**](OverrideReturnAddressApi.md#deleteoverridereturnaddressfile) | **DELETE** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/file/{fileId} | Delete a file for an overrideReturnAddress.
[**DeleteOverrideReturnAddressTag**](OverrideReturnAddressApi.md#deleteoverridereturnaddresstag) | **DELETE** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/tag/{overrideReturnAddressTag} | Delete a tag for an overrideReturnAddress.
[**GetDuplicateOverrideReturnAddressById**](OverrideReturnAddressApi.md#getduplicateoverridereturnaddressbyid) | **GET** /v3.0/overrideReturnAddress/duplicate/{overrideReturnAddressId} | Get a duplicated an overrideReturnAddress by id
[**GetOverrideReturnAddressByFilter**](OverrideReturnAddressApi.md#getoverridereturnaddressbyfilter) | **GET** /v3.0/overrideReturnAddress/search | Search overrideReturnAddresses by filter
[**GetOverrideReturnAddressById**](OverrideReturnAddressApi.md#getoverridereturnaddressbyid) | **GET** /v3.0/overrideReturnAddress/{overrideReturnAddressId} | Get an overrideReturnAddress by id
[**GetOverrideReturnAddressFiles**](OverrideReturnAddressApi.md#getoverridereturnaddressfiles) | **GET** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/file | Get the files for an overrideReturnAddress.
[**GetOverrideReturnAddressTags**](OverrideReturnAddressApi.md#getoverridereturnaddresstags) | **GET** /v3.0/overrideReturnAddress/{overrideReturnAddressId}/tag | Get the tags for an overrideReturnAddress.
[**UpdateOverrideReturnAddress**](OverrideReturnAddressApi.md#updateoverridereturnaddress) | **PUT** /v3.0/overrideReturnAddress | Update an overrideReturnAddress
[**UpdateOverrideReturnAddressCustomFields**](OverrideReturnAddressApi.md#updateoverridereturnaddresscustomfields) | **PUT** /v3.0/overrideReturnAddress/customFields | Update an overrideReturnAddress custom fields


<a name="addoverridereturnaddress"></a>
# **AddOverrideReturnAddress**
> OverrideReturnAddress AddOverrideReturnAddress (OverrideReturnAddress body)

Create an overrideReturnAddress

Inserts a new overrideReturnAddress using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOverrideReturnAddressExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var body = new OverrideReturnAddress(); // OverrideReturnAddress | OverrideReturnAddress to be inserted.

            try
            {
                // Create an overrideReturnAddress
                OverrideReturnAddress result = apiInstance.AddOverrideReturnAddress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.AddOverrideReturnAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverrideReturnAddress**](OverrideReturnAddress.md)| OverrideReturnAddress to be inserted. | 

### Return type

[**OverrideReturnAddress**](OverrideReturnAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addoverridereturnaddressaudit"></a>
# **AddOverrideReturnAddressAudit**
> void AddOverrideReturnAddressAudit (int? overrideReturnAddressId, string overrideReturnAddressAudit)

Add new audit for an overrideReturnAddress

Adds an audit to an existing overrideReturnAddress.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOverrideReturnAddressAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to add an audit to
            var overrideReturnAddressAudit = overrideReturnAddressAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an overrideReturnAddress
                apiInstance.AddOverrideReturnAddressAudit(overrideReturnAddressId, overrideReturnAddressAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.AddOverrideReturnAddressAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to add an audit to | 
 **overrideReturnAddressAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addoverridereturnaddressfile"></a>
# **AddOverrideReturnAddressFile**
> void AddOverrideReturnAddressFile (int? overrideReturnAddressId, string fileName)

Attach a file to an overrideReturnAddress

Adds a file to an existing overrideReturnAddress.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOverrideReturnAddressFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to an overrideReturnAddress
                apiInstance.AddOverrideReturnAddressFile(overrideReturnAddressId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.AddOverrideReturnAddressFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addoverridereturnaddressfilebyurl"></a>
# **AddOverrideReturnAddressFileByURL**
> void AddOverrideReturnAddressFileByURL (RecordFile body, int? overrideReturnAddressId)

Attach a file to an overrideReturnAddress by URL.

Adds a file to an existing overrideReturnAddress by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOverrideReturnAddressFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to add an file to

            try
            {
                // Attach a file to an overrideReturnAddress by URL.
                apiInstance.AddOverrideReturnAddressFileByURL(body, overrideReturnAddressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.AddOverrideReturnAddressFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addoverridereturnaddresstag"></a>
# **AddOverrideReturnAddressTag**
> void AddOverrideReturnAddressTag (int? overrideReturnAddressId, string overrideReturnAddressTag)

Add new tags for an overrideReturnAddress.

Adds a tag to an existing overrideReturnAddress.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddOverrideReturnAddressTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to add a tag to
            var overrideReturnAddressTag = overrideReturnAddressTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an overrideReturnAddress.
                apiInstance.AddOverrideReturnAddressTag(overrideReturnAddressId, overrideReturnAddressTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.AddOverrideReturnAddressTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to add a tag to | 
 **overrideReturnAddressTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoverridereturnaddress"></a>
# **DeleteOverrideReturnAddress**
> void DeleteOverrideReturnAddress (int? overrideReturnAddressId)

Delete an overrideReturnAddress

Deletes the overrideReturnAddress identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOverrideReturnAddressExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to be deleted.

            try
            {
                // Delete an overrideReturnAddress
                apiInstance.DeleteOverrideReturnAddress(overrideReturnAddressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.DeleteOverrideReturnAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoverridereturnaddressfile"></a>
# **DeleteOverrideReturnAddressFile**
> void DeleteOverrideReturnAddressFile (int? overrideReturnAddressId, int? fileId)

Delete a file for an overrideReturnAddress.

Deletes an existing overrideReturnAddress file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOverrideReturnAddressFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for an overrideReturnAddress.
                apiInstance.DeleteOverrideReturnAddressFile(overrideReturnAddressId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.DeleteOverrideReturnAddressFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoverridereturnaddresstag"></a>
# **DeleteOverrideReturnAddressTag**
> void DeleteOverrideReturnAddressTag (int? overrideReturnAddressId, string overrideReturnAddressTag)

Delete a tag for an overrideReturnAddress.

Deletes an existing overrideReturnAddress tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteOverrideReturnAddressTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to remove tag from
            var overrideReturnAddressTag = overrideReturnAddressTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an overrideReturnAddress.
                apiInstance.DeleteOverrideReturnAddressTag(overrideReturnAddressId, overrideReturnAddressTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.DeleteOverrideReturnAddressTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to remove tag from | 
 **overrideReturnAddressTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateoverridereturnaddressbyid"></a>
# **GetDuplicateOverrideReturnAddressById**
> OverrideReturnAddress GetDuplicateOverrideReturnAddressById (int? overrideReturnAddressId)

Get a duplicated an overrideReturnAddress by id

Returns a duplicated overrideReturnAddress identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateOverrideReturnAddressByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to be duplicated.

            try
            {
                // Get a duplicated an overrideReturnAddress by id
                OverrideReturnAddress result = apiInstance.GetDuplicateOverrideReturnAddressById(overrideReturnAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.GetDuplicateOverrideReturnAddressById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to be duplicated. | 

### Return type

[**OverrideReturnAddress**](OverrideReturnAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoverridereturnaddressbyfilter"></a>
# **GetOverrideReturnAddressByFilter**
> List<OverrideReturnAddress> GetOverrideReturnAddressByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search overrideReturnAddresses by filter

Returns the list of overrideReturnAddresses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOverrideReturnAddressByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search overrideReturnAddresses by filter
                List&lt;OverrideReturnAddress&gt; result = apiInstance.GetOverrideReturnAddressByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.GetOverrideReturnAddressByFilter: " + e.Message );
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

[**List<OverrideReturnAddress>**](OverrideReturnAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoverridereturnaddressbyid"></a>
# **GetOverrideReturnAddressById**
> OverrideReturnAddress GetOverrideReturnAddressById (int? overrideReturnAddressId)

Get an overrideReturnAddress by id

Returns the overrideReturnAddress identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOverrideReturnAddressByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to be returned.

            try
            {
                // Get an overrideReturnAddress by id
                OverrideReturnAddress result = apiInstance.GetOverrideReturnAddressById(overrideReturnAddressId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.GetOverrideReturnAddressById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to be returned. | 

### Return type

[**OverrideReturnAddress**](OverrideReturnAddress.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoverridereturnaddressfiles"></a>
# **GetOverrideReturnAddressFiles**
> void GetOverrideReturnAddressFiles (int? overrideReturnAddressId)

Get the files for an overrideReturnAddress.

Get all existing overrideReturnAddress files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOverrideReturnAddressFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to get files for

            try
            {
                // Get the files for an overrideReturnAddress.
                apiInstance.GetOverrideReturnAddressFiles(overrideReturnAddressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.GetOverrideReturnAddressFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoverridereturnaddresstags"></a>
# **GetOverrideReturnAddressTags**
> void GetOverrideReturnAddressTags (int? overrideReturnAddressId)

Get the tags for an overrideReturnAddress.

Get all existing overrideReturnAddress tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetOverrideReturnAddressTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var overrideReturnAddressId = 56;  // int? | Id of the overrideReturnAddress to get tags for

            try
            {
                // Get the tags for an overrideReturnAddress.
                apiInstance.GetOverrideReturnAddressTags(overrideReturnAddressId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.GetOverrideReturnAddressTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **overrideReturnAddressId** | **int?**| Id of the overrideReturnAddress to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateoverridereturnaddress"></a>
# **UpdateOverrideReturnAddress**
> void UpdateOverrideReturnAddress (OverrideReturnAddress body)

Update an overrideReturnAddress

Updates an existing overrideReturnAddress using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOverrideReturnAddressExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var body = new OverrideReturnAddress(); // OverrideReturnAddress | OverrideReturnAddress to be updated.

            try
            {
                // Update an overrideReturnAddress
                apiInstance.UpdateOverrideReturnAddress(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.UpdateOverrideReturnAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverrideReturnAddress**](OverrideReturnAddress.md)| OverrideReturnAddress to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateoverridereturnaddresscustomfields"></a>
# **UpdateOverrideReturnAddressCustomFields**
> void UpdateOverrideReturnAddressCustomFields (OverrideReturnAddress body)

Update an overrideReturnAddress custom fields

Updates an existing overrideReturnAddress custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateOverrideReturnAddressCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new OverrideReturnAddressApi();
            var body = new OverrideReturnAddress(); // OverrideReturnAddress | OverrideReturnAddress to be updated.

            try
            {
                // Update an overrideReturnAddress custom fields
                apiInstance.UpdateOverrideReturnAddressCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OverrideReturnAddressApi.UpdateOverrideReturnAddressCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverrideReturnAddress**](OverrideReturnAddress.md)| OverrideReturnAddress to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

