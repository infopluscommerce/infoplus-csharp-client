# Infoplus.Api.CommodityCodeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCommodityCodeAudit**](CommodityCodeApi.md#addcommoditycodeaudit) | **PUT** /beta/commodityCode/{commodityCodeId}/audit/{commodityCodeAudit} | Add new audit for a commodityCode
[**AddCommodityCodeFile**](CommodityCodeApi.md#addcommoditycodefile) | **POST** /beta/commodityCode/{commodityCodeId}/file/{fileName} | Attach a file to a commodityCode
[**AddCommodityCodeFileByURL**](CommodityCodeApi.md#addcommoditycodefilebyurl) | **POST** /beta/commodityCode/{commodityCodeId}/file | Attach a file to a commodityCode by URL.
[**AddCommodityCodeTag**](CommodityCodeApi.md#addcommoditycodetag) | **PUT** /beta/commodityCode/{commodityCodeId}/tag/{commodityCodeTag} | Add new tags for a commodityCode.
[**DeleteCommodityCodeFile**](CommodityCodeApi.md#deletecommoditycodefile) | **DELETE** /beta/commodityCode/{commodityCodeId}/file/{fileId} | Delete a file for a commodityCode.
[**DeleteCommodityCodeTag**](CommodityCodeApi.md#deletecommoditycodetag) | **DELETE** /beta/commodityCode/{commodityCodeId}/tag/{commodityCodeTag} | Delete a tag for a commodityCode.
[**GetCommodityCodeByFilter**](CommodityCodeApi.md#getcommoditycodebyfilter) | **GET** /beta/commodityCode/search | Search commodityCodes by filter
[**GetCommodityCodeById**](CommodityCodeApi.md#getcommoditycodebyid) | **GET** /beta/commodityCode/{commodityCodeId} | Get a commodityCode by id
[**GetCommodityCodeFiles**](CommodityCodeApi.md#getcommoditycodefiles) | **GET** /beta/commodityCode/{commodityCodeId}/file | Get the files for a commodityCode.
[**GetCommodityCodeTags**](CommodityCodeApi.md#getcommoditycodetags) | **GET** /beta/commodityCode/{commodityCodeId}/tag | Get the tags for a commodityCode.
[**GetDuplicateCommodityCodeById**](CommodityCodeApi.md#getduplicatecommoditycodebyid) | **GET** /beta/commodityCode/duplicate/{commodityCodeId} | Get a duplicated a commodityCode by id


<a name="addcommoditycodeaudit"></a>
# **AddCommodityCodeAudit**
> void AddCommodityCodeAudit (int? commodityCodeId, string commodityCodeAudit)

Add new audit for a commodityCode

Adds an audit to an existing commodityCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCommodityCodeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to add an audit to
            var commodityCodeAudit = commodityCodeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a commodityCode
                apiInstance.AddCommodityCodeAudit(commodityCodeId, commodityCodeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.AddCommodityCodeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to add an audit to | 
 **commodityCodeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcommoditycodefile"></a>
# **AddCommodityCodeFile**
> void AddCommodityCodeFile (int? commodityCodeId, string fileName)

Attach a file to a commodityCode

Adds a file to an existing commodityCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCommodityCodeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a commodityCode
                apiInstance.AddCommodityCodeFile(commodityCodeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.AddCommodityCodeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcommoditycodefilebyurl"></a>
# **AddCommodityCodeFileByURL**
> void AddCommodityCodeFileByURL (RecordFile body, int? commodityCodeId)

Attach a file to a commodityCode by URL.

Adds a file to an existing commodityCode by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCommodityCodeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var commodityCodeId = 56;  // int? | Id of the commodityCode to add an file to

            try
            {
                // Attach a file to a commodityCode by URL.
                apiInstance.AddCommodityCodeFileByURL(body, commodityCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.AddCommodityCodeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **commodityCodeId** | **int?**| Id of the commodityCode to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcommoditycodetag"></a>
# **AddCommodityCodeTag**
> void AddCommodityCodeTag (int? commodityCodeId, string commodityCodeTag)

Add new tags for a commodityCode.

Adds a tag to an existing commodityCode.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCommodityCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to add a tag to
            var commodityCodeTag = commodityCodeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a commodityCode.
                apiInstance.AddCommodityCodeTag(commodityCodeId, commodityCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.AddCommodityCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to add a tag to | 
 **commodityCodeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecommoditycodefile"></a>
# **DeleteCommodityCodeFile**
> void DeleteCommodityCodeFile (int? commodityCodeId, int? fileId)

Delete a file for a commodityCode.

Deletes an existing commodityCode file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCommodityCodeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a commodityCode.
                apiInstance.DeleteCommodityCodeFile(commodityCodeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.DeleteCommodityCodeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecommoditycodetag"></a>
# **DeleteCommodityCodeTag**
> void DeleteCommodityCodeTag (int? commodityCodeId, string commodityCodeTag)

Delete a tag for a commodityCode.

Deletes an existing commodityCode tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCommodityCodeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to remove tag from
            var commodityCodeTag = commodityCodeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a commodityCode.
                apiInstance.DeleteCommodityCodeTag(commodityCodeId, commodityCodeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.DeleteCommodityCodeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to remove tag from | 
 **commodityCodeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommoditycodebyfilter"></a>
# **GetCommodityCodeByFilter**
> List<CommodityCode> GetCommodityCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search commodityCodes by filter

Returns the list of commodityCodes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCommodityCodeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search commodityCodes by filter
                List&lt;CommodityCode&gt; result = apiInstance.GetCommodityCodeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.GetCommodityCodeByFilter: " + e.Message );
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

[**List<CommodityCode>**](CommodityCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommoditycodebyid"></a>
# **GetCommodityCodeById**
> CommodityCode GetCommodityCodeById (int? commodityCodeId)

Get a commodityCode by id

Returns the commodityCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCommodityCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to be returned.

            try
            {
                // Get a commodityCode by id
                CommodityCode result = apiInstance.GetCommodityCodeById(commodityCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.GetCommodityCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to be returned. | 

### Return type

[**CommodityCode**](CommodityCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommoditycodefiles"></a>
# **GetCommodityCodeFiles**
> void GetCommodityCodeFiles (int? commodityCodeId)

Get the files for a commodityCode.

Get all existing commodityCode files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCommodityCodeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to get files for

            try
            {
                // Get the files for a commodityCode.
                apiInstance.GetCommodityCodeFiles(commodityCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.GetCommodityCodeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommoditycodetags"></a>
# **GetCommodityCodeTags**
> void GetCommodityCodeTags (int? commodityCodeId)

Get the tags for a commodityCode.

Get all existing commodityCode tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCommodityCodeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to get tags for

            try
            {
                // Get the tags for a commodityCode.
                apiInstance.GetCommodityCodeTags(commodityCodeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.GetCommodityCodeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecommoditycodebyid"></a>
# **GetDuplicateCommodityCodeById**
> CommodityCode GetDuplicateCommodityCodeById (int? commodityCodeId)

Get a duplicated a commodityCode by id

Returns a duplicated commodityCode identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCommodityCodeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CommodityCodeApi();
            var commodityCodeId = 56;  // int? | Id of the commodityCode to be duplicated.

            try
            {
                // Get a duplicated a commodityCode by id
                CommodityCode result = apiInstance.GetDuplicateCommodityCodeById(commodityCodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommodityCodeApi.GetDuplicateCommodityCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commodityCodeId** | **int?**| Id of the commodityCode to be duplicated. | 

### Return type

[**CommodityCode**](CommodityCode.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

