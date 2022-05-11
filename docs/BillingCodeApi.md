# Infoplus.Api.BillingCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillingCode**](BillingCodeApi.md#addbillingcode) | **POST** /v3.0/billingCode | Create a billingCode
[**AddBillingCodeAudit**](BillingCodeApi.md#addbillingcodeaudit) | **PUT** /v3.0/billingCode/{billingCodeId}/audit/{billingCodeAudit} | Add new audit for a billingCode
[**AddBillingCodeFile**](BillingCodeApi.md#addbillingcodefile) | **POST** /v3.0/billingCode/{billingCodeId}/file/{fileName} | Attach a file to a billingCode
[**AddBillingCodeFileByURL**](BillingCodeApi.md#addbillingcodefilebyurl) | **POST** /v3.0/billingCode/{billingCodeId}/file | Attach a file to a billingCode by URL.
[**AddBillingCodeTag**](BillingCodeApi.md#addbillingcodetag) | **PUT** /v3.0/billingCode/{billingCodeId}/tag/{billingCodeTag} | Add new tags for a billingCode.
[**DeleteBillingCode**](BillingCodeApi.md#deletebillingcode) | **DELETE** /v3.0/billingCode/{billingCodeId} | Delete a billingCode
[**DeleteBillingCodeFile**](BillingCodeApi.md#deletebillingcodefile) | **DELETE** /v3.0/billingCode/{billingCodeId}/file/{fileId} | Delete a file for a billingCode.
[**DeleteBillingCodeTag**](BillingCodeApi.md#deletebillingcodetag) | **DELETE** /v3.0/billingCode/{billingCodeId}/tag/{billingCodeTag} | Delete a tag for a billingCode.
[**GetBillingCodeByFilter**](BillingCodeApi.md#getbillingcodebyfilter) | **GET** /v3.0/billingCode/search | Search billingCodes by filter
[**GetBillingCodeById**](BillingCodeApi.md#getbillingcodebyid) | **GET** /v3.0/billingCode/{billingCodeId} | Get a billingCode by id
[**GetBillingCodeFiles**](BillingCodeApi.md#getbillingcodefiles) | **GET** /v3.0/billingCode/{billingCodeId}/file | Get the files for a billingCode.
[**GetBillingCodeTags**](BillingCodeApi.md#getbillingcodetags) | **GET** /v3.0/billingCode/{billingCodeId}/tag | Get the tags for a billingCode.
[**GetDuplicateBillingCodeById**](BillingCodeApi.md#getduplicatebillingcodebyid) | **GET** /v3.0/billingCode/duplicate/{billingCodeId} | Get a duplicated a billingCode by id
[**UpdateBillingCode**](BillingCodeApi.md#updatebillingcode) | **PUT** /v3.0/billingCode | Update a billingCode
[**UpdateBillingCodeCustomFields**](BillingCodeApi.md#updatebillingcodecustomfields) | **PUT** /v3.0/billingCode/customFields | Update a billingCode custom fields


<a name="addbillingcode"></a>
# **AddBillingCode**
> BillingCode AddBillingCode (BillingCode body)

Create a billingCode

Inserts a new billingCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var body = new BillingCode(); // BillingCode | BillingCode to be inserted.

            try
            {
                // Create a billingCode
                BillingCode result = apiInstance.AddBillingCode(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.AddBillingCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCode**](BillingCode.md)| BillingCode to be inserted. | 

### Return type

[**BillingCode**](BillingCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodeaudit"></a>
# **AddBillingCodeAudit**
> void AddBillingCodeAudit (int? billingCodeId, string billingCodeAudit)

Add new audit for a billingCode

Adds an audit to an existing billingCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to add an audit to
            var billingCodeAudit = billingCodeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a billingCode
                apiInstance.AddBillingCodeAudit(billingCodeId, billingCodeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.AddBillingCodeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to add an audit to | 
 **billingCodeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodefile"></a>
# **AddBillingCodeFile**
> void AddBillingCodeFile (int? billingCodeId, string fileName)

Attach a file to a billingCode

Adds a file to an existing billingCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a billingCode
                apiInstance.AddBillingCodeFile(billingCodeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.AddBillingCodeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodefilebyurl"></a>
# **AddBillingCodeFileByURL**
> void AddBillingCodeFileByURL (RecordFile body, int? billingCodeId)

Attach a file to a billingCode by URL.

Adds a file to an existing billingCode by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var billingCodeId = 56;  // int? | Id of the billingCode to add an file to

            try
            {
                // Attach a file to a billingCode by URL.
                apiInstance.AddBillingCodeFileByURL(body, billingCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.AddBillingCodeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **billingCodeId** | **int?**| Id of the billingCode to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillingcodetag"></a>
# **AddBillingCodeTag**
> void AddBillingCodeTag (int? billingCodeId, string billingCodeTag)

Add new tags for a billingCode.

Adds a tag to an existing billingCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillingCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to add a tag to
            var billingCodeTag = billingCodeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a billingCode.
                apiInstance.AddBillingCodeTag(billingCodeId, billingCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.AddBillingCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to add a tag to | 
 **billingCodeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcode"></a>
# **DeleteBillingCode**
> void DeleteBillingCode (int? billingCodeId)

Delete a billingCode

Deletes the billingCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to be deleted.

            try
            {
                // Delete a billingCode
                apiInstance.DeleteBillingCode(billingCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.DeleteBillingCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodefile"></a>
# **DeleteBillingCodeFile**
> void DeleteBillingCodeFile (int? billingCodeId, int? fileId)

Delete a file for a billingCode.

Deletes an existing billingCode file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a billingCode.
                apiInstance.DeleteBillingCodeFile(billingCodeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.DeleteBillingCodeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillingcodetag"></a>
# **DeleteBillingCodeTag**
> void DeleteBillingCodeTag (int? billingCodeId, string billingCodeTag)

Delete a tag for a billingCode.

Deletes an existing billingCode tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillingCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to remove tag from
            var billingCodeTag = billingCodeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a billingCode.
                apiInstance.DeleteBillingCodeTag(billingCodeId, billingCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.DeleteBillingCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to remove tag from | 
 **billingCodeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodebyfilter"></a>
# **GetBillingCodeByFilter**
> List<BillingCode> GetBillingCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search billingCodes by filter

Returns the list of billingCodes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search billingCodes by filter
                List&lt;BillingCode&gt; result = apiInstance.GetBillingCodeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.GetBillingCodeByFilter: " + e.Message );
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

[**List<BillingCode>**](BillingCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodebyid"></a>
# **GetBillingCodeById**
> BillingCode GetBillingCodeById (int? billingCodeId)

Get a billingCode by id

Returns the billingCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to be returned.

            try
            {
                // Get a billingCode by id
                BillingCode result = apiInstance.GetBillingCodeById(billingCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.GetBillingCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to be returned. | 

### Return type

[**BillingCode**](BillingCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodefiles"></a>
# **GetBillingCodeFiles**
> void GetBillingCodeFiles (int? billingCodeId)

Get the files for a billingCode.

Get all existing billingCode files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to get files for

            try
            {
                // Get the files for a billingCode.
                apiInstance.GetBillingCodeFiles(billingCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.GetBillingCodeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcodetags"></a>
# **GetBillingCodeTags**
> void GetBillingCodeTags (int? billingCodeId)

Get the tags for a billingCode.

Get all existing billingCode tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillingCodeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to get tags for

            try
            {
                // Get the tags for a billingCode.
                apiInstance.GetBillingCodeTags(billingCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.GetBillingCodeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatebillingcodebyid"></a>
# **GetDuplicateBillingCodeById**
> BillingCode GetDuplicateBillingCodeById (int? billingCodeId)

Get a duplicated a billingCode by id

Returns a duplicated billingCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateBillingCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var billingCodeId = 56;  // int? | Id of the billingCode to be duplicated.

            try
            {
                // Get a duplicated a billingCode by id
                BillingCode result = apiInstance.GetDuplicateBillingCodeById(billingCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.GetDuplicateBillingCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingCodeId** | **int?**| Id of the billingCode to be duplicated. | 

### Return type

[**BillingCode**](BillingCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingcode"></a>
# **UpdateBillingCode**
> void UpdateBillingCode (BillingCode body)

Update a billingCode

Updates an existing billingCode using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var body = new BillingCode(); // BillingCode | BillingCode to be updated.

            try
            {
                // Update a billingCode
                apiInstance.UpdateBillingCode(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.UpdateBillingCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCode**](BillingCode.md)| BillingCode to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillingcodecustomfields"></a>
# **UpdateBillingCodeCustomFields**
> void UpdateBillingCodeCustomFields (BillingCode body)

Update a billingCode custom fields

Updates an existing billingCode custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillingCodeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillingCodeApi();
            var body = new BillingCode(); // BillingCode | BillingCode to be updated.

            try
            {
                // Update a billingCode custom fields
                apiInstance.UpdateBillingCodeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingCodeApi.UpdateBillingCodeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillingCode**](BillingCode.md)| BillingCode to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

