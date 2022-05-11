# Infoplus.Api.CartonApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCarton**](CartonApi.md#addcarton) | **POST** /v3.0/carton | Create a carton
[**AddCartonAudit**](CartonApi.md#addcartonaudit) | **PUT** /v3.0/carton/{cartonId}/audit/{cartonAudit} | Add new audit for a carton
[**AddCartonFile**](CartonApi.md#addcartonfile) | **POST** /v3.0/carton/{cartonId}/file/{fileName} | Attach a file to a carton
[**AddCartonFileByURL**](CartonApi.md#addcartonfilebyurl) | **POST** /v3.0/carton/{cartonId}/file | Attach a file to a carton by URL.
[**AddCartonTag**](CartonApi.md#addcartontag) | **PUT** /v3.0/carton/{cartonId}/tag/{cartonTag} | Add new tags for a carton.
[**DeleteCarton**](CartonApi.md#deletecarton) | **DELETE** /v3.0/carton/{cartonId} | Delete a carton
[**DeleteCartonFile**](CartonApi.md#deletecartonfile) | **DELETE** /v3.0/carton/{cartonId}/file/{fileId} | Delete a file for a carton.
[**DeleteCartonTag**](CartonApi.md#deletecartontag) | **DELETE** /v3.0/carton/{cartonId}/tag/{cartonTag} | Delete a tag for a carton.
[**GetCartonByFilter**](CartonApi.md#getcartonbyfilter) | **GET** /v3.0/carton/search | Search cartons by filter
[**GetCartonById**](CartonApi.md#getcartonbyid) | **GET** /v3.0/carton/{cartonId} | Get a carton by id
[**GetCartonFiles**](CartonApi.md#getcartonfiles) | **GET** /v3.0/carton/{cartonId}/file | Get the files for a carton.
[**GetCartonTags**](CartonApi.md#getcartontags) | **GET** /v3.0/carton/{cartonId}/tag | Get the tags for a carton.
[**GetDuplicateCartonById**](CartonApi.md#getduplicatecartonbyid) | **GET** /v3.0/carton/duplicate/{cartonId} | Get a duplicated a carton by id
[**UpdateCarton**](CartonApi.md#updatecarton) | **PUT** /v3.0/carton | Update a carton
[**UpdateCartonCustomFields**](CartonApi.md#updatecartoncustomfields) | **PUT** /v3.0/carton/customFields | Update a carton custom fields


<a name="addcarton"></a>
# **AddCarton**
> Carton AddCarton (Carton body)

Create a carton

Inserts a new carton using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var body = new Carton(); // Carton | Carton to be inserted.

            try
            {
                // Create a carton
                Carton result = apiInstance.AddCarton(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.AddCarton: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Carton**](Carton.md)| Carton to be inserted. | 

### Return type

[**Carton**](Carton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartonaudit"></a>
# **AddCartonAudit**
> void AddCartonAudit (int? cartonId, string cartonAudit)

Add new audit for a carton

Adds an audit to an existing carton.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to add an audit to
            var cartonAudit = cartonAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a carton
                apiInstance.AddCartonAudit(cartonId, cartonAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.AddCartonAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to add an audit to | 
 **cartonAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartonfile"></a>
# **AddCartonFile**
> void AddCartonFile (int? cartonId, string fileName)

Attach a file to a carton

Adds a file to an existing carton.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a carton
                apiInstance.AddCartonFile(cartonId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.AddCartonFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartonfilebyurl"></a>
# **AddCartonFileByURL**
> void AddCartonFileByURL (RecordFile body, int? cartonId)

Attach a file to a carton by URL.

Adds a file to an existing carton by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var cartonId = 56;  // int? | Id of the carton to add an file to

            try
            {
                // Attach a file to a carton by URL.
                apiInstance.AddCartonFileByURL(body, cartonId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.AddCartonFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **cartonId** | **int?**| Id of the carton to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartontag"></a>
# **AddCartonTag**
> void AddCartonTag (int? cartonId, string cartonTag)

Add new tags for a carton.

Adds a tag to an existing carton.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to add a tag to
            var cartonTag = cartonTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a carton.
                apiInstance.AddCartonTag(cartonId, cartonTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.AddCartonTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to add a tag to | 
 **cartonTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecarton"></a>
# **DeleteCarton**
> void DeleteCarton (int? cartonId)

Delete a carton

Deletes the carton identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to be deleted.

            try
            {
                // Delete a carton
                apiInstance.DeleteCarton(cartonId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.DeleteCarton: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartonfile"></a>
# **DeleteCartonFile**
> void DeleteCartonFile (int? cartonId, int? fileId)

Delete a file for a carton.

Deletes an existing carton file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a carton.
                apiInstance.DeleteCartonFile(cartonId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.DeleteCartonFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartontag"></a>
# **DeleteCartonTag**
> void DeleteCartonTag (int? cartonId, string cartonTag)

Delete a tag for a carton.

Deletes an existing carton tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to remove tag from
            var cartonTag = cartonTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a carton.
                apiInstance.DeleteCartonTag(cartonId, cartonTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.DeleteCartonTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to remove tag from | 
 **cartonTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonbyfilter"></a>
# **GetCartonByFilter**
> List<Carton> GetCartonByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search cartons by filter

Returns the list of cartons that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search cartons by filter
                List&lt;Carton&gt; result = apiInstance.GetCartonByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.GetCartonByFilter: " + e.Message );
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

[**List<Carton>**](Carton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonbyid"></a>
# **GetCartonById**
> Carton GetCartonById (int? cartonId)

Get a carton by id

Returns the carton identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to be returned.

            try
            {
                // Get a carton by id
                Carton result = apiInstance.GetCartonById(cartonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.GetCartonById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to be returned. | 

### Return type

[**Carton**](Carton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartonfiles"></a>
# **GetCartonFiles**
> void GetCartonFiles (int? cartonId)

Get the files for a carton.

Get all existing carton files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to get files for

            try
            {
                // Get the files for a carton.
                apiInstance.GetCartonFiles(cartonId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.GetCartonFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartontags"></a>
# **GetCartonTags**
> void GetCartonTags (int? cartonId)

Get the tags for a carton.

Get all existing carton tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to get tags for

            try
            {
                // Get the tags for a carton.
                apiInstance.GetCartonTags(cartonId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.GetCartonTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecartonbyid"></a>
# **GetDuplicateCartonById**
> Carton GetDuplicateCartonById (int? cartonId)

Get a duplicated a carton by id

Returns a duplicated carton identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCartonByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var cartonId = 56;  // int? | Id of the carton to be duplicated.

            try
            {
                // Get a duplicated a carton by id
                Carton result = apiInstance.GetDuplicateCartonById(cartonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.GetDuplicateCartonById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonId** | **int?**| Id of the carton to be duplicated. | 

### Return type

[**Carton**](Carton.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecarton"></a>
# **UpdateCarton**
> void UpdateCarton (Carton body)

Update a carton

Updates an existing carton using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var body = new Carton(); // Carton | Carton to be updated.

            try
            {
                // Update a carton
                apiInstance.UpdateCarton(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.UpdateCarton: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Carton**](Carton.md)| Carton to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartoncustomfields"></a>
# **UpdateCartonCustomFields**
> void UpdateCartonCustomFields (Carton body)

Update a carton custom fields

Updates an existing carton custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonApi();
            var body = new Carton(); // Carton | Carton to be updated.

            try
            {
                // Update a carton custom fields
                apiInstance.UpdateCartonCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonApi.UpdateCartonCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Carton**](Carton.md)| Carton to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

