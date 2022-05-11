# Infoplus.Api.BillingCodeTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillingCodeType**](BillingCodeTypeApi.md#addbillingcodetype) | **POST** /v3.0/billingCodeType | Create a billingCodeType
[**AddBillingCodeTypeAudit**](BillingCodeTypeApi.md#addbillingcodetypeaudit) | **PUT** /v3.0/billingCodeType/{billingCodeTypeId}/audit/{billingCodeTypeAudit} | Add new audit for a billingCodeType
[**AddBillingCodeTypeFile**](BillingCodeTypeApi.md#addbillingcodetypefile) | **POST** /v3.0/billingCodeType/{billingCodeTypeId}/file/{fileName} | Attach a file to a billingCodeType
[**AddBillingCodeTypeFileByURL**](BillingCodeTypeApi.md#addbillingcodetypefilebyurl) | **POST** /v3.0/billingCodeType/{billingCodeTypeId}/file | Attach a file to a billingCodeType by URL.
[**AddBillingCodeTypeTag**](BillingCodeTypeApi.md#addbillingcodetypetag) | **PUT** /v3.0/billingCodeType/{billingCodeTypeId}/tag/{billingCodeTypeTag} | Add new tags for a billingCodeType.
[**DeleteBillingCodeType**](BillingCodeTypeApi.md#deletebillingcodetype) | **DELETE** /v3.0/billingCodeType/{billingCodeTypeId} | Delete a billingCodeType
[**DeleteBillingCodeTypeFile**](BillingCodeTypeApi.md#deletebillingcodetypefile) | **DELETE** /v3.0/billingCodeType/{billingCodeTypeId}/file/{fileId} | Delete a file for a billingCodeType.
[**DeleteBillingCodeTypeTag**](BillingCodeTypeApi.md#deletebillingcodetypetag) | **DELETE** /v3.0/billingCodeType/{billingCodeTypeId}/tag/{billingCodeTypeTag} | Delete a tag for a billingCodeType.
[**GetBillingCodeTypeByFilter**](BillingCodeTypeApi.md#getbillingcodetypebyfilter) | **GET** /v3.0/billingCodeType/search | Search billingCodeTypes by filter
[**GetBillingCodeTypeById**](BillingCodeTypeApi.md#getbillingcodetypebyid) | **GET** /v3.0/billingCodeType/{billingCodeTypeId} | Get a billingCodeType by id
[**GetBillingCodeTypeFiles**](BillingCodeTypeApi.md#getbillingcodetypefiles) | **GET** /v3.0/billingCodeType/{billingCodeTypeId}/file | Get the files for a billingCodeType.
[**GetBillingCodeTypeTags**](BillingCodeTypeApi.md#getbillingcodetypetags) | **GET** /v3.0/billingCodeType/{billingCodeTypeId}/tag | Get the tags for a billingCodeType.
[**GetDuplicateBillingCodeTypeById**](BillingCodeTypeApi.md#getduplicatebillingcodetypebyid) | **GET** /v3.0/billingCodeType/duplicate/{billingCodeTypeId} | Get a duplicated a billingCodeType by id
[**UpdateBillingCodeType**](BillingCodeTypeApi.md#updatebillingcodetype) | **PUT** /v3.0/billingCodeType | Update a billingCodeType
[**UpdateBillingCodeTypeCustomFields**](BillingCodeTypeApi.md#updatebillingcodetypecustomfields) | **PUT** /v3.0/billingCodeType/customFields | Update a billingCodeType custom fields


<a name="addbillingcodetype"></a>
# **AddBillingCodeType**
> BillingCodeType AddBillingCodeType (BillingCodeType body)

Create a billingCodeType

Inserts a new billingCodeType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var body = new BillingCodeType(); // BillingCodeType | BillingCodeType to be inserted.

            try
            {
                // Create a billingCodeType
                BillingCodeType result = apiInstance.AddBillingCodeType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.AddBillingCodeType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeType**](BillingCodeType.md)| BillingCodeType to be inserted. | 

### Return type

[**BillingCodeType**](BillingCodeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodetypeaudit"></a>
# **AddBillingCodeTypeAudit**
> void AddBillingCodeTypeAudit (int? billingCodeTypeId, string billingCodeTypeAudit)

Add new audit for a billingCodeType

Adds an audit to an existing billingCodeType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeTypeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to add an audit to
            var billingCodeTypeAudit = billingCodeTypeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a billingCodeType
                apiInstance.AddBillingCodeTypeAudit(billingCodeTypeId, billingCodeTypeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.AddBillingCodeTypeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to add an audit to | 
 **billingCodeTypeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodetypefile"></a>
# **AddBillingCodeTypeFile**
> void AddBillingCodeTypeFile (int? billingCodeTypeId, string fileName)

Attach a file to a billingCodeType

Adds a file to an existing billingCodeType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a billingCodeType
                apiInstance.AddBillingCodeTypeFile(billingCodeTypeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.AddBillingCodeTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodetypefilebyurl"></a>
# **AddBillingCodeTypeFileByURL**
> void AddBillingCodeTypeFileByURL (RecordFile body, int? billingCodeTypeId)

Attach a file to a billingCodeType by URL.

Adds a file to an existing billingCodeType by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeTypeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to add an file to

            try
            {
                // Attach a file to a billingCodeType by URL.
                apiInstance.AddBillingCodeTypeFileByURL(body, billingCodeTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.AddBillingCodeTypeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodetypetag"></a>
# **AddBillingCodeTypeTag**
> void AddBillingCodeTypeTag (int? billingCodeTypeId, string billingCodeTypeTag)

Add new tags for a billingCodeType.

Adds a tag to an existing billingCodeType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to add a tag to
            var billingCodeTypeTag = billingCodeTypeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a billingCodeType.
                apiInstance.AddBillingCodeTypeTag(billingCodeTypeId, billingCodeTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.AddBillingCodeTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to add a tag to | 
 **billingCodeTypeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodetype"></a>
# **DeleteBillingCodeType**
> void DeleteBillingCodeType (int? billingCodeTypeId)

Delete a billingCodeType

Deletes the billingCodeType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to be deleted.

            try
            {
                // Delete a billingCodeType
                apiInstance.DeleteBillingCodeType(billingCodeTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.DeleteBillingCodeType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodetypefile"></a>
# **DeleteBillingCodeTypeFile**
> void DeleteBillingCodeTypeFile (int? billingCodeTypeId, int? fileId)

Delete a file for a billingCodeType.

Deletes an existing billingCodeType file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a billingCodeType.
                apiInstance.DeleteBillingCodeTypeFile(billingCodeTypeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.DeleteBillingCodeTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodetypetag"></a>
# **DeleteBillingCodeTypeTag**
> void DeleteBillingCodeTypeTag (int? billingCodeTypeId, string billingCodeTypeTag)

Delete a tag for a billingCodeType.

Deletes an existing billingCodeType tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to remove tag from
            var billingCodeTypeTag = billingCodeTypeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a billingCodeType.
                apiInstance.DeleteBillingCodeTypeTag(billingCodeTypeId, billingCodeTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.DeleteBillingCodeTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to remove tag from | 
 **billingCodeTypeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodetypebyfilter"></a>
# **GetBillingCodeTypeByFilter**
> List<BillingCodeType> GetBillingCodeTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search billingCodeTypes by filter

Returns the list of billingCodeTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeTypeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search billingCodeTypes by filter
                List&lt;BillingCodeType&gt; result = apiInstance.GetBillingCodeTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.GetBillingCodeTypeByFilter: " + e.Message );
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

[**List<BillingCodeType>**](BillingCodeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodetypebyid"></a>
# **GetBillingCodeTypeById**
> BillingCodeType GetBillingCodeTypeById (int? billingCodeTypeId)

Get a billingCodeType by id

Returns the billingCodeType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to be returned.

            try
            {
                // Get a billingCodeType by id
                BillingCodeType result = apiInstance.GetBillingCodeTypeById(billingCodeTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.GetBillingCodeTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to be returned. | 

### Return type

[**BillingCodeType**](BillingCodeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodetypefiles"></a>
# **GetBillingCodeTypeFiles**
> void GetBillingCodeTypeFiles (int? billingCodeTypeId)

Get the files for a billingCodeType.

Get all existing billingCodeType files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeTypeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to get files for

            try
            {
                // Get the files for a billingCodeType.
                apiInstance.GetBillingCodeTypeFiles(billingCodeTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.GetBillingCodeTypeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodetypetags"></a>
# **GetBillingCodeTypeTags**
> void GetBillingCodeTypeTags (int? billingCodeTypeId)

Get the tags for a billingCodeType.

Get all existing billingCodeType tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeTypeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to get tags for

            try
            {
                // Get the tags for a billingCodeType.
                apiInstance.GetBillingCodeTypeTags(billingCodeTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.GetBillingCodeTypeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatebillingcodetypebyid"></a>
# **GetDuplicateBillingCodeTypeById**
> BillingCodeType GetDuplicateBillingCodeTypeById (int? billingCodeTypeId)

Get a duplicated a billingCodeType by id

Returns a duplicated billingCodeType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateBillingCodeTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var billingCodeTypeId = 56;  // int? | Id of the billingCodeType to be duplicated.

            try
            {
                // Get a duplicated a billingCodeType by id
                BillingCodeType result = apiInstance.GetDuplicateBillingCodeTypeById(billingCodeTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.GetDuplicateBillingCodeTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeTypeId** | **int?**| Id of the billingCodeType to be duplicated. | 

### Return type

[**BillingCodeType**](BillingCodeType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingcodetype"></a>
# **UpdateBillingCodeType**
> void UpdateBillingCodeType (BillingCodeType body)

Update a billingCodeType

Updates an existing billingCodeType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var body = new BillingCodeType(); // BillingCodeType | BillingCodeType to be updated.

            try
            {
                // Update a billingCodeType
                apiInstance.UpdateBillingCodeType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.UpdateBillingCodeType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeType**](BillingCodeType.md)| BillingCodeType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingcodetypecustomfields"></a>
# **UpdateBillingCodeTypeCustomFields**
> void UpdateBillingCodeTypeCustomFields (BillingCodeType body)

Update a billingCodeType custom fields

Updates an existing billingCodeType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeTypeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeTypeApi();
            var body = new BillingCodeType(); // BillingCodeType | BillingCodeType to be updated.

            try
            {
                // Update a billingCodeType custom fields
                apiInstance.UpdateBillingCodeTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeTypeApi.UpdateBillingCodeTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCodeType**](BillingCodeType.md)| BillingCodeType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

