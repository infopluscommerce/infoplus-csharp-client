# Infoplus.Api.DropshipApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDropshipAudit**](DropshipApi.md#adddropshipaudit) | **PUT** /beta/dropship/{dropshipId}/audit/{dropshipAudit} | Add new audit for a dropship
[**AddDropshipFile**](DropshipApi.md#adddropshipfile) | **POST** /beta/dropship/{dropshipId}/file/{fileName} | Attach a file to a dropship
[**AddDropshipFileByURL**](DropshipApi.md#adddropshipfilebyurl) | **POST** /beta/dropship/{dropshipId}/file | Attach a file to a dropship by URL.
[**AddDropshipTag**](DropshipApi.md#adddropshiptag) | **PUT** /beta/dropship/{dropshipId}/tag/{dropshipTag} | Add new tags for a dropship.
[**DeleteDropshipFile**](DropshipApi.md#deletedropshipfile) | **DELETE** /beta/dropship/{dropshipId}/file/{fileId} | Delete a file for a dropship.
[**DeleteDropshipTag**](DropshipApi.md#deletedropshiptag) | **DELETE** /beta/dropship/{dropshipId}/tag/{dropshipTag} | Delete a tag for a dropship.
[**GetDropshipByFilter**](DropshipApi.md#getdropshipbyfilter) | **GET** /beta/dropship/search | Search dropships by filter
[**GetDropshipById**](DropshipApi.md#getdropshipbyid) | **GET** /beta/dropship/{dropshipId} | Get a dropship by id
[**GetDropshipFiles**](DropshipApi.md#getdropshipfiles) | **GET** /beta/dropship/{dropshipId}/file | Get the files for a dropship.
[**GetDropshipTags**](DropshipApi.md#getdropshiptags) | **GET** /beta/dropship/{dropshipId}/tag | Get the tags for a dropship.
[**GetDuplicateDropshipById**](DropshipApi.md#getduplicatedropshipbyid) | **GET** /beta/dropship/duplicate/{dropshipId} | Get a duplicated a dropship by id
[**UpdateDropship**](DropshipApi.md#updatedropship) | **PUT** /beta/dropship | Update a dropship


<a name="adddropshipaudit"></a>
# **AddDropshipAudit**
> void AddDropshipAudit (int? dropshipId, string dropshipAudit)

Add new audit for a dropship

Adds an audit to an existing dropship.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDropshipAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to add an audit to
            var dropshipAudit = dropshipAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a dropship
                apiInstance.AddDropshipAudit(dropshipId, dropshipAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.AddDropshipAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to add an audit to | 
 **dropshipAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddropshipfile"></a>
# **AddDropshipFile**
> void AddDropshipFile (int? dropshipId, string fileName)

Attach a file to a dropship

Adds a file to an existing dropship.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDropshipFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a dropship
                apiInstance.AddDropshipFile(dropshipId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.AddDropshipFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddropshipfilebyurl"></a>
# **AddDropshipFileByURL**
> void AddDropshipFileByURL (RecordFile body, int? dropshipId)

Attach a file to a dropship by URL.

Adds a file to an existing dropship by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDropshipFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var dropshipId = 56;  // int? | Id of the dropship to add an file to

            try
            {
                // Attach a file to a dropship by URL.
                apiInstance.AddDropshipFileByURL(body, dropshipId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.AddDropshipFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **dropshipId** | **int?**| Id of the dropship to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adddropshiptag"></a>
# **AddDropshipTag**
> void AddDropshipTag (int? dropshipId, string dropshipTag)

Add new tags for a dropship.

Adds a tag to an existing dropship.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddDropshipTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to add a tag to
            var dropshipTag = dropshipTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a dropship.
                apiInstance.AddDropshipTag(dropshipId, dropshipTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.AddDropshipTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to add a tag to | 
 **dropshipTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedropshipfile"></a>
# **DeleteDropshipFile**
> void DeleteDropshipFile (int? dropshipId, int? fileId)

Delete a file for a dropship.

Deletes an existing dropship file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteDropshipFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a dropship.
                apiInstance.DeleteDropshipFile(dropshipId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.DeleteDropshipFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedropshiptag"></a>
# **DeleteDropshipTag**
> void DeleteDropshipTag (int? dropshipId, string dropshipTag)

Delete a tag for a dropship.

Deletes an existing dropship tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteDropshipTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to remove tag from
            var dropshipTag = dropshipTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a dropship.
                apiInstance.DeleteDropshipTag(dropshipId, dropshipTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.DeleteDropshipTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to remove tag from | 
 **dropshipTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdropshipbyfilter"></a>
# **GetDropshipByFilter**
> List<Dropship> GetDropshipByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search dropships by filter

Returns the list of dropships that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDropshipByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search dropships by filter
                List&lt;Dropship&gt; result = apiInstance.GetDropshipByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.GetDropshipByFilter: " + e.Message );
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

[**List<Dropship>**](Dropship.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdropshipbyid"></a>
# **GetDropshipById**
> Dropship GetDropshipById (int? dropshipId)

Get a dropship by id

Returns the dropship identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDropshipByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to be returned.

            try
            {
                // Get a dropship by id
                Dropship result = apiInstance.GetDropshipById(dropshipId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.GetDropshipById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to be returned. | 

### Return type

[**Dropship**](Dropship.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdropshipfiles"></a>
# **GetDropshipFiles**
> void GetDropshipFiles (int? dropshipId)

Get the files for a dropship.

Get all existing dropship files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDropshipFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to get files for

            try
            {
                // Get the files for a dropship.
                apiInstance.GetDropshipFiles(dropshipId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.GetDropshipFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdropshiptags"></a>
# **GetDropshipTags**
> void GetDropshipTags (int? dropshipId)

Get the tags for a dropship.

Get all existing dropship tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDropshipTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to get tags for

            try
            {
                // Get the tags for a dropship.
                apiInstance.GetDropshipTags(dropshipId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.GetDropshipTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatedropshipbyid"></a>
# **GetDuplicateDropshipById**
> Dropship GetDuplicateDropshipById (int? dropshipId)

Get a duplicated a dropship by id

Returns a duplicated dropship identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateDropshipByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var dropshipId = 56;  // int? | Id of the dropship to be duplicated.

            try
            {
                // Get a duplicated a dropship by id
                Dropship result = apiInstance.GetDuplicateDropshipById(dropshipId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.GetDuplicateDropshipById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dropshipId** | **int?**| Id of the dropship to be duplicated. | 

### Return type

[**Dropship**](Dropship.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedropship"></a>
# **UpdateDropship**
> void UpdateDropship (Dropship body)

Update a dropship

Updates an existing dropship using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateDropshipExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new DropshipApi();
            var body = new Dropship(); // Dropship | Dropship to be updated.

            try
            {
                // Update a dropship
                apiInstance.UpdateDropship(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DropshipApi.UpdateDropship: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dropship**](Dropship.md)| Dropship to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

