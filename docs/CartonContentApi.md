# Infoplus.Api.CartonContentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCartonContent**](CartonContentApi.md#addcartoncontent) | **POST** /v3.0/cartonContent | Create a cartonContent
[**AddCartonContentAudit**](CartonContentApi.md#addcartoncontentaudit) | **PUT** /v3.0/cartonContent/{cartonContentId}/audit/{cartonContentAudit} | Add new audit for a cartonContent
[**AddCartonContentFile**](CartonContentApi.md#addcartoncontentfile) | **POST** /v3.0/cartonContent/{cartonContentId}/file/{fileName} | Attach a file to a cartonContent
[**AddCartonContentFileByURL**](CartonContentApi.md#addcartoncontentfilebyurl) | **POST** /v3.0/cartonContent/{cartonContentId}/file | Attach a file to a cartonContent by URL.
[**AddCartonContentTag**](CartonContentApi.md#addcartoncontenttag) | **PUT** /v3.0/cartonContent/{cartonContentId}/tag/{cartonContentTag} | Add new tags for a cartonContent.
[**DeleteCartonContent**](CartonContentApi.md#deletecartoncontent) | **DELETE** /v3.0/cartonContent/{cartonContentId} | Delete a cartonContent
[**DeleteCartonContentFile**](CartonContentApi.md#deletecartoncontentfile) | **DELETE** /v3.0/cartonContent/{cartonContentId}/file/{fileId} | Delete a file for a cartonContent.
[**DeleteCartonContentTag**](CartonContentApi.md#deletecartoncontenttag) | **DELETE** /v3.0/cartonContent/{cartonContentId}/tag/{cartonContentTag} | Delete a tag for a cartonContent.
[**GetCartonContentByFilter**](CartonContentApi.md#getcartoncontentbyfilter) | **GET** /v3.0/cartonContent/search | Search cartonContents by filter
[**GetCartonContentById**](CartonContentApi.md#getcartoncontentbyid) | **GET** /v3.0/cartonContent/{cartonContentId} | Get a cartonContent by id
[**GetCartonContentFiles**](CartonContentApi.md#getcartoncontentfiles) | **GET** /v3.0/cartonContent/{cartonContentId}/file | Get the files for a cartonContent.
[**GetCartonContentTags**](CartonContentApi.md#getcartoncontenttags) | **GET** /v3.0/cartonContent/{cartonContentId}/tag | Get the tags for a cartonContent.
[**GetDuplicateCartonContentById**](CartonContentApi.md#getduplicatecartoncontentbyid) | **GET** /v3.0/cartonContent/duplicate/{cartonContentId} | Get a duplicated a cartonContent by id
[**UpdateCartonContent**](CartonContentApi.md#updatecartoncontent) | **PUT** /v3.0/cartonContent | Update a cartonContent
[**UpdateCartonContentCustomFields**](CartonContentApi.md#updatecartoncontentcustomfields) | **PUT** /v3.0/cartonContent/customFields | Update a cartonContent custom fields


<a name="addcartoncontent"></a>
# **AddCartonContent**
> CartonContent AddCartonContent (CartonContent body)

Create a cartonContent

Inserts a new cartonContent using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonContentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var body = new CartonContent(); // CartonContent | CartonContent to be inserted.

            try
            {
                // Create a cartonContent
                CartonContent result = apiInstance.AddCartonContent(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.AddCartonContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonContent**](CartonContent.md)| CartonContent to be inserted. | 

### Return type

[**CartonContent**](CartonContent.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartoncontentaudit"></a>
# **AddCartonContentAudit**
> void AddCartonContentAudit (int? cartonContentId, string cartonContentAudit)

Add new audit for a cartonContent

Adds an audit to an existing cartonContent.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonContentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to add an audit to
            var cartonContentAudit = cartonContentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a cartonContent
                apiInstance.AddCartonContentAudit(cartonContentId, cartonContentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.AddCartonContentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to add an audit to | 
 **cartonContentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartoncontentfile"></a>
# **AddCartonContentFile**
> void AddCartonContentFile (int? cartonContentId, string fileName)

Attach a file to a cartonContent

Adds a file to an existing cartonContent.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonContentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a cartonContent
                apiInstance.AddCartonContentFile(cartonContentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.AddCartonContentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartoncontentfilebyurl"></a>
# **AddCartonContentFileByURL**
> void AddCartonContentFileByURL (RecordFile body, int? cartonContentId)

Attach a file to a cartonContent by URL.

Adds a file to an existing cartonContent by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonContentFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var cartonContentId = 56;  // int? | Id of the cartonContent to add an file to

            try
            {
                // Attach a file to a cartonContent by URL.
                apiInstance.AddCartonContentFileByURL(body, cartonContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.AddCartonContentFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **cartonContentId** | **int?**| Id of the cartonContent to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartoncontenttag"></a>
# **AddCartonContentTag**
> void AddCartonContentTag (int? cartonContentId, string cartonContentTag)

Add new tags for a cartonContent.

Adds a tag to an existing cartonContent.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonContentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to add a tag to
            var cartonContentTag = cartonContentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a cartonContent.
                apiInstance.AddCartonContentTag(cartonContentId, cartonContentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.AddCartonContentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to add a tag to | 
 **cartonContentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartoncontent"></a>
# **DeleteCartonContent**
> void DeleteCartonContent (int? cartonContentId)

Delete a cartonContent

Deletes the cartonContent identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonContentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to be deleted.

            try
            {
                // Delete a cartonContent
                apiInstance.DeleteCartonContent(cartonContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.DeleteCartonContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartoncontentfile"></a>
# **DeleteCartonContentFile**
> void DeleteCartonContentFile (int? cartonContentId, int? fileId)

Delete a file for a cartonContent.

Deletes an existing cartonContent file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonContentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a cartonContent.
                apiInstance.DeleteCartonContentFile(cartonContentId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.DeleteCartonContentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartoncontenttag"></a>
# **DeleteCartonContentTag**
> void DeleteCartonContentTag (int? cartonContentId, string cartonContentTag)

Delete a tag for a cartonContent.

Deletes an existing cartonContent tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonContentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to remove tag from
            var cartonContentTag = cartonContentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a cartonContent.
                apiInstance.DeleteCartonContentTag(cartonContentId, cartonContentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.DeleteCartonContentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to remove tag from | 
 **cartonContentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartoncontentbyfilter"></a>
# **GetCartonContentByFilter**
> List<CartonContent> GetCartonContentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search cartonContents by filter

Returns the list of cartonContents that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonContentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search cartonContents by filter
                List&lt;CartonContent&gt; result = apiInstance.GetCartonContentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.GetCartonContentByFilter: " + e.Message );
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

[**List<CartonContent>**](CartonContent.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartoncontentbyid"></a>
# **GetCartonContentById**
> CartonContent GetCartonContentById (int? cartonContentId)

Get a cartonContent by id

Returns the cartonContent identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonContentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to be returned.

            try
            {
                // Get a cartonContent by id
                CartonContent result = apiInstance.GetCartonContentById(cartonContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.GetCartonContentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to be returned. | 

### Return type

[**CartonContent**](CartonContent.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartoncontentfiles"></a>
# **GetCartonContentFiles**
> void GetCartonContentFiles (int? cartonContentId)

Get the files for a cartonContent.

Get all existing cartonContent files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonContentFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to get files for

            try
            {
                // Get the files for a cartonContent.
                apiInstance.GetCartonContentFiles(cartonContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.GetCartonContentFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartoncontenttags"></a>
# **GetCartonContentTags**
> void GetCartonContentTags (int? cartonContentId)

Get the tags for a cartonContent.

Get all existing cartonContent tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonContentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to get tags for

            try
            {
                // Get the tags for a cartonContent.
                apiInstance.GetCartonContentTags(cartonContentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.GetCartonContentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecartoncontentbyid"></a>
# **GetDuplicateCartonContentById**
> CartonContent GetDuplicateCartonContentById (int? cartonContentId)

Get a duplicated a cartonContent by id

Returns a duplicated cartonContent identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCartonContentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var cartonContentId = 56;  // int? | Id of the cartonContent to be duplicated.

            try
            {
                // Get a duplicated a cartonContent by id
                CartonContent result = apiInstance.GetDuplicateCartonContentById(cartonContentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.GetDuplicateCartonContentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonContentId** | **int?**| Id of the cartonContent to be duplicated. | 

### Return type

[**CartonContent**](CartonContent.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartoncontent"></a>
# **UpdateCartonContent**
> void UpdateCartonContent (CartonContent body)

Update a cartonContent

Updates an existing cartonContent using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonContentExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var body = new CartonContent(); // CartonContent | CartonContent to be updated.

            try
            {
                // Update a cartonContent
                apiInstance.UpdateCartonContent(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.UpdateCartonContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonContent**](CartonContent.md)| CartonContent to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartoncontentcustomfields"></a>
# **UpdateCartonContentCustomFields**
> void UpdateCartonContentCustomFields (CartonContent body)

Update a cartonContent custom fields

Updates an existing cartonContent custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonContentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonContentApi();
            var body = new CartonContent(); // CartonContent | CartonContent to be updated.

            try
            {
                // Update a cartonContent custom fields
                apiInstance.UpdateCartonContentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonContentApi.UpdateCartonContentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonContent**](CartonContent.md)| CartonContent to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

