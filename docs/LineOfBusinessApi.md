# Infoplus.Api.LineOfBusinessApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLineOfBusiness**](LineOfBusinessApi.md#addlineofbusiness) | **POST** /v3.0/lineOfBusiness | Create a lineOfBusiness
[**AddLineOfBusinessAudit**](LineOfBusinessApi.md#addlineofbusinessaudit) | **PUT** /v3.0/lineOfBusiness/{lineOfBusinessId}/audit/{lineOfBusinessAudit} | Add new audit for a lineOfBusiness
[**AddLineOfBusinessFile**](LineOfBusinessApi.md#addlineofbusinessfile) | **POST** /v3.0/lineOfBusiness/{lineOfBusinessId}/file/{fileName} | Attach a file to a lineOfBusiness
[**AddLineOfBusinessFileByURL**](LineOfBusinessApi.md#addlineofbusinessfilebyurl) | **POST** /v3.0/lineOfBusiness/{lineOfBusinessId}/file | Attach a file to a lineOfBusiness by URL.
[**AddLineOfBusinessTag**](LineOfBusinessApi.md#addlineofbusinesstag) | **PUT** /v3.0/lineOfBusiness/{lineOfBusinessId}/tag/{lineOfBusinessTag} | Add new tags for a lineOfBusiness.
[**DeleteLineOfBusinessFile**](LineOfBusinessApi.md#deletelineofbusinessfile) | **DELETE** /v3.0/lineOfBusiness/{lineOfBusinessId}/file/{fileId} | Delete a file for a lineOfBusiness.
[**DeleteLineOfBusinessTag**](LineOfBusinessApi.md#deletelineofbusinesstag) | **DELETE** /v3.0/lineOfBusiness/{lineOfBusinessId}/tag/{lineOfBusinessTag} | Delete a tag for a lineOfBusiness.
[**GetDuplicateLineOfBusinessById**](LineOfBusinessApi.md#getduplicatelineofbusinessbyid) | **GET** /v3.0/lineOfBusiness/duplicate/{lineOfBusinessId} | Get a duplicated a lineOfBusiness by id
[**GetLineOfBusinessByFilter**](LineOfBusinessApi.md#getlineofbusinessbyfilter) | **GET** /v3.0/lineOfBusiness/search | Search lineOfBusinesses by filter
[**GetLineOfBusinessById**](LineOfBusinessApi.md#getlineofbusinessbyid) | **GET** /v3.0/lineOfBusiness/{lineOfBusinessId} | Get a lineOfBusiness by id
[**GetLineOfBusinessFiles**](LineOfBusinessApi.md#getlineofbusinessfiles) | **GET** /v3.0/lineOfBusiness/{lineOfBusinessId}/file | Get the files for a lineOfBusiness.
[**GetLineOfBusinessTags**](LineOfBusinessApi.md#getlineofbusinesstags) | **GET** /v3.0/lineOfBusiness/{lineOfBusinessId}/tag | Get the tags for a lineOfBusiness.
[**UpdateLineOfBusiness**](LineOfBusinessApi.md#updatelineofbusiness) | **PUT** /v3.0/lineOfBusiness | Update a lineOfBusiness
[**UpdateLineOfBusinessCustomFields**](LineOfBusinessApi.md#updatelineofbusinesscustomfields) | **PUT** /v3.0/lineOfBusiness/customFields | Update a lineOfBusiness custom fields


<a name="addlineofbusiness"></a>
# **AddLineOfBusiness**
> LineOfBusiness AddLineOfBusiness (LineOfBusiness body)

Create a lineOfBusiness

Inserts a new lineOfBusiness using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLineOfBusinessExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var body = new LineOfBusiness(); // LineOfBusiness | LineOfBusiness to be inserted.

            try
            {
                // Create a lineOfBusiness
                LineOfBusiness result = apiInstance.AddLineOfBusiness(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.AddLineOfBusiness: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LineOfBusiness**](LineOfBusiness.md)| LineOfBusiness to be inserted. | 

### Return type

[**LineOfBusiness**](LineOfBusiness.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlineofbusinessaudit"></a>
# **AddLineOfBusinessAudit**
> void AddLineOfBusinessAudit (int? lineOfBusinessId, string lineOfBusinessAudit)

Add new audit for a lineOfBusiness

Adds an audit to an existing lineOfBusiness.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLineOfBusinessAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to add an audit to
            var lineOfBusinessAudit = lineOfBusinessAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a lineOfBusiness
                apiInstance.AddLineOfBusinessAudit(lineOfBusinessId, lineOfBusinessAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.AddLineOfBusinessAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to add an audit to | 
 **lineOfBusinessAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlineofbusinessfile"></a>
# **AddLineOfBusinessFile**
> void AddLineOfBusinessFile (int? lineOfBusinessId, string fileName)

Attach a file to a lineOfBusiness

Adds a file to an existing lineOfBusiness.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLineOfBusinessFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a lineOfBusiness
                apiInstance.AddLineOfBusinessFile(lineOfBusinessId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.AddLineOfBusinessFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlineofbusinessfilebyurl"></a>
# **AddLineOfBusinessFileByURL**
> void AddLineOfBusinessFileByURL (RecordFile body, int? lineOfBusinessId)

Attach a file to a lineOfBusiness by URL.

Adds a file to an existing lineOfBusiness by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLineOfBusinessFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to add an file to

            try
            {
                // Attach a file to a lineOfBusiness by URL.
                apiInstance.AddLineOfBusinessFileByURL(body, lineOfBusinessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.AddLineOfBusinessFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlineofbusinesstag"></a>
# **AddLineOfBusinessTag**
> void AddLineOfBusinessTag (int? lineOfBusinessId, string lineOfBusinessTag)

Add new tags for a lineOfBusiness.

Adds a tag to an existing lineOfBusiness.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLineOfBusinessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to add a tag to
            var lineOfBusinessTag = lineOfBusinessTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a lineOfBusiness.
                apiInstance.AddLineOfBusinessTag(lineOfBusinessId, lineOfBusinessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.AddLineOfBusinessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to add a tag to | 
 **lineOfBusinessTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelineofbusinessfile"></a>
# **DeleteLineOfBusinessFile**
> void DeleteLineOfBusinessFile (int? lineOfBusinessId, int? fileId)

Delete a file for a lineOfBusiness.

Deletes an existing lineOfBusiness file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLineOfBusinessFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a lineOfBusiness.
                apiInstance.DeleteLineOfBusinessFile(lineOfBusinessId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.DeleteLineOfBusinessFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelineofbusinesstag"></a>
# **DeleteLineOfBusinessTag**
> void DeleteLineOfBusinessTag (int? lineOfBusinessId, string lineOfBusinessTag)

Delete a tag for a lineOfBusiness.

Deletes an existing lineOfBusiness tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLineOfBusinessTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to remove tag from
            var lineOfBusinessTag = lineOfBusinessTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a lineOfBusiness.
                apiInstance.DeleteLineOfBusinessTag(lineOfBusinessId, lineOfBusinessTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.DeleteLineOfBusinessTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to remove tag from | 
 **lineOfBusinessTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatelineofbusinessbyid"></a>
# **GetDuplicateLineOfBusinessById**
> LineOfBusiness GetDuplicateLineOfBusinessById (int? lineOfBusinessId)

Get a duplicated a lineOfBusiness by id

Returns a duplicated lineOfBusiness identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLineOfBusinessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to be duplicated.

            try
            {
                // Get a duplicated a lineOfBusiness by id
                LineOfBusiness result = apiInstance.GetDuplicateLineOfBusinessById(lineOfBusinessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.GetDuplicateLineOfBusinessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to be duplicated. | 

### Return type

[**LineOfBusiness**](LineOfBusiness.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlineofbusinessbyfilter"></a>
# **GetLineOfBusinessByFilter**
> List<LineOfBusiness> GetLineOfBusinessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search lineOfBusinesses by filter

Returns the list of lineOfBusinesses that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLineOfBusinessByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search lineOfBusinesses by filter
                List&lt;LineOfBusiness&gt; result = apiInstance.GetLineOfBusinessByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.GetLineOfBusinessByFilter: " + e.Message );
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

[**List<LineOfBusiness>**](LineOfBusiness.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlineofbusinessbyid"></a>
# **GetLineOfBusinessById**
> LineOfBusiness GetLineOfBusinessById (int? lineOfBusinessId)

Get a lineOfBusiness by id

Returns the lineOfBusiness identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLineOfBusinessByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to be returned.

            try
            {
                // Get a lineOfBusiness by id
                LineOfBusiness result = apiInstance.GetLineOfBusinessById(lineOfBusinessId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.GetLineOfBusinessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to be returned. | 

### Return type

[**LineOfBusiness**](LineOfBusiness.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlineofbusinessfiles"></a>
# **GetLineOfBusinessFiles**
> void GetLineOfBusinessFiles (int? lineOfBusinessId)

Get the files for a lineOfBusiness.

Get all existing lineOfBusiness files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLineOfBusinessFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to get files for

            try
            {
                // Get the files for a lineOfBusiness.
                apiInstance.GetLineOfBusinessFiles(lineOfBusinessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.GetLineOfBusinessFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlineofbusinesstags"></a>
# **GetLineOfBusinessTags**
> void GetLineOfBusinessTags (int? lineOfBusinessId)

Get the tags for a lineOfBusiness.

Get all existing lineOfBusiness tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLineOfBusinessTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var lineOfBusinessId = 56;  // int? | Id of the lineOfBusiness to get tags for

            try
            {
                // Get the tags for a lineOfBusiness.
                apiInstance.GetLineOfBusinessTags(lineOfBusinessId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.GetLineOfBusinessTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineOfBusinessId** | **int?**| Id of the lineOfBusiness to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelineofbusiness"></a>
# **UpdateLineOfBusiness**
> void UpdateLineOfBusiness (LineOfBusiness body)

Update a lineOfBusiness

Updates an existing lineOfBusiness using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLineOfBusinessExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var body = new LineOfBusiness(); // LineOfBusiness | LineOfBusiness to be updated.

            try
            {
                // Update a lineOfBusiness
                apiInstance.UpdateLineOfBusiness(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.UpdateLineOfBusiness: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LineOfBusiness**](LineOfBusiness.md)| LineOfBusiness to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelineofbusinesscustomfields"></a>
# **UpdateLineOfBusinessCustomFields**
> void UpdateLineOfBusinessCustomFields (LineOfBusiness body)

Update a lineOfBusiness custom fields

Updates an existing lineOfBusiness custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLineOfBusinessCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LineOfBusinessApi();
            var body = new LineOfBusiness(); // LineOfBusiness | LineOfBusiness to be updated.

            try
            {
                // Update a lineOfBusiness custom fields
                apiInstance.UpdateLineOfBusinessCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LineOfBusinessApi.UpdateLineOfBusinessCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LineOfBusiness**](LineOfBusiness.md)| LineOfBusiness to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

