# Infoplus.Api.CartonTypeApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCartonType**](CartonTypeApi.md#addcartontype) | **POST** /v3.0/cartonType | Create a cartonType
[**AddCartonTypeAudit**](CartonTypeApi.md#addcartontypeaudit) | **PUT** /v3.0/cartonType/{cartonTypeId}/audit/{cartonTypeAudit} | Add new audit for a cartonType
[**AddCartonTypeFile**](CartonTypeApi.md#addcartontypefile) | **POST** /v3.0/cartonType/{cartonTypeId}/file/{fileName} | Attach a file to a cartonType
[**AddCartonTypeFileByURL**](CartonTypeApi.md#addcartontypefilebyurl) | **POST** /v3.0/cartonType/{cartonTypeId}/file | Attach a file to a cartonType by URL.
[**AddCartonTypeTag**](CartonTypeApi.md#addcartontypetag) | **PUT** /v3.0/cartonType/{cartonTypeId}/tag/{cartonTypeTag} | Add new tags for a cartonType.
[**DeleteCartonType**](CartonTypeApi.md#deletecartontype) | **DELETE** /v3.0/cartonType/{cartonTypeId} | Delete a cartonType
[**DeleteCartonTypeFile**](CartonTypeApi.md#deletecartontypefile) | **DELETE** /v3.0/cartonType/{cartonTypeId}/file/{fileId} | Delete a file for a cartonType.
[**DeleteCartonTypeTag**](CartonTypeApi.md#deletecartontypetag) | **DELETE** /v3.0/cartonType/{cartonTypeId}/tag/{cartonTypeTag} | Delete a tag for a cartonType.
[**GetCartonTypeByFilter**](CartonTypeApi.md#getcartontypebyfilter) | **GET** /v3.0/cartonType/search | Search cartonTypes by filter
[**GetCartonTypeById**](CartonTypeApi.md#getcartontypebyid) | **GET** /v3.0/cartonType/{cartonTypeId} | Get a cartonType by id
[**GetCartonTypeFiles**](CartonTypeApi.md#getcartontypefiles) | **GET** /v3.0/cartonType/{cartonTypeId}/file | Get the files for a cartonType.
[**GetCartonTypeTags**](CartonTypeApi.md#getcartontypetags) | **GET** /v3.0/cartonType/{cartonTypeId}/tag | Get the tags for a cartonType.
[**GetDuplicateCartonTypeById**](CartonTypeApi.md#getduplicatecartontypebyid) | **GET** /v3.0/cartonType/duplicate/{cartonTypeId} | Get a duplicated a cartonType by id
[**UpdateCartonType**](CartonTypeApi.md#updatecartontype) | **PUT** /v3.0/cartonType | Update a cartonType
[**UpdateCartonTypeCustomFields**](CartonTypeApi.md#updatecartontypecustomfields) | **PUT** /v3.0/cartonType/customFields | Update a cartonType custom fields


<a name="addcartontype"></a>
# **AddCartonType**
> CartonType AddCartonType (CartonType body)

Create a cartonType

Inserts a new cartonType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var body = new CartonType(); // CartonType | CartonType to be inserted.

            try
            {
                // Create a cartonType
                CartonType result = apiInstance.AddCartonType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.AddCartonType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonType**](CartonType.md)| CartonType to be inserted. | 

### Return type

[**CartonType**](CartonType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartontypeaudit"></a>
# **AddCartonTypeAudit**
> void AddCartonTypeAudit (int? cartonTypeId, string cartonTypeAudit)

Add new audit for a cartonType

Adds an audit to an existing cartonType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonTypeAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to add an audit to
            var cartonTypeAudit = cartonTypeAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a cartonType
                apiInstance.AddCartonTypeAudit(cartonTypeId, cartonTypeAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.AddCartonTypeAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to add an audit to | 
 **cartonTypeAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartontypefile"></a>
# **AddCartonTypeFile**
> void AddCartonTypeFile (int? cartonTypeId, string fileName)

Attach a file to a cartonType

Adds a file to an existing cartonType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a cartonType
                apiInstance.AddCartonTypeFile(cartonTypeId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.AddCartonTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartontypefilebyurl"></a>
# **AddCartonTypeFileByURL**
> void AddCartonTypeFileByURL (RecordFile body, int? cartonTypeId)

Attach a file to a cartonType by URL.

Adds a file to an existing cartonType by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonTypeFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var cartonTypeId = 56;  // int? | Id of the cartonType to add an file to

            try
            {
                // Attach a file to a cartonType by URL.
                apiInstance.AddCartonTypeFileByURL(body, cartonTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.AddCartonTypeFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **cartonTypeId** | **int?**| Id of the cartonType to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartontypetag"></a>
# **AddCartonTypeTag**
> void AddCartonTypeTag (int? cartonTypeId, string cartonTypeTag)

Add new tags for a cartonType.

Adds a tag to an existing cartonType.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartonTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to add a tag to
            var cartonTypeTag = cartonTypeTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a cartonType.
                apiInstance.AddCartonTypeTag(cartonTypeId, cartonTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.AddCartonTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to add a tag to | 
 **cartonTypeTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartontype"></a>
# **DeleteCartonType**
> void DeleteCartonType (int? cartonTypeId)

Delete a cartonType

Deletes the cartonType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to be deleted.

            try
            {
                // Delete a cartonType
                apiInstance.DeleteCartonType(cartonTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.DeleteCartonType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartontypefile"></a>
# **DeleteCartonTypeFile**
> void DeleteCartonTypeFile (int? cartonTypeId, int? fileId)

Delete a file for a cartonType.

Deletes an existing cartonType file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonTypeFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a cartonType.
                apiInstance.DeleteCartonTypeFile(cartonTypeId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.DeleteCartonTypeFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartontypetag"></a>
# **DeleteCartonTypeTag**
> void DeleteCartonTypeTag (int? cartonTypeId, string cartonTypeTag)

Delete a tag for a cartonType.

Deletes an existing cartonType tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartonTypeTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to remove tag from
            var cartonTypeTag = cartonTypeTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a cartonType.
                apiInstance.DeleteCartonTypeTag(cartonTypeId, cartonTypeTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.DeleteCartonTypeTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to remove tag from | 
 **cartonTypeTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartontypebyfilter"></a>
# **GetCartonTypeByFilter**
> List<CartonType> GetCartonTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search cartonTypes by filter

Returns the list of cartonTypes that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonTypeByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search cartonTypes by filter
                List&lt;CartonType&gt; result = apiInstance.GetCartonTypeByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.GetCartonTypeByFilter: " + e.Message );
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

[**List<CartonType>**](CartonType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartontypebyid"></a>
# **GetCartonTypeById**
> CartonType GetCartonTypeById (int? cartonTypeId)

Get a cartonType by id

Returns the cartonType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to be returned.

            try
            {
                // Get a cartonType by id
                CartonType result = apiInstance.GetCartonTypeById(cartonTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.GetCartonTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to be returned. | 

### Return type

[**CartonType**](CartonType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartontypefiles"></a>
# **GetCartonTypeFiles**
> void GetCartonTypeFiles (int? cartonTypeId)

Get the files for a cartonType.

Get all existing cartonType files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonTypeFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to get files for

            try
            {
                // Get the files for a cartonType.
                apiInstance.GetCartonTypeFiles(cartonTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.GetCartonTypeFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartontypetags"></a>
# **GetCartonTypeTags**
> void GetCartonTypeTags (int? cartonTypeId)

Get the tags for a cartonType.

Get all existing cartonType tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartonTypeTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to get tags for

            try
            {
                // Get the tags for a cartonType.
                apiInstance.GetCartonTypeTags(cartonTypeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.GetCartonTypeTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecartontypebyid"></a>
# **GetDuplicateCartonTypeById**
> CartonType GetDuplicateCartonTypeById (int? cartonTypeId)

Get a duplicated a cartonType by id

Returns a duplicated cartonType identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCartonTypeByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var cartonTypeId = 56;  // int? | Id of the cartonType to be duplicated.

            try
            {
                // Get a duplicated a cartonType by id
                CartonType result = apiInstance.GetDuplicateCartonTypeById(cartonTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.GetDuplicateCartonTypeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartonTypeId** | **int?**| Id of the cartonType to be duplicated. | 

### Return type

[**CartonType**](CartonType.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartontype"></a>
# **UpdateCartonType**
> void UpdateCartonType (CartonType body)

Update a cartonType

Updates an existing cartonType using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var body = new CartonType(); // CartonType | CartonType to be updated.

            try
            {
                // Update a cartonType
                apiInstance.UpdateCartonType(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.UpdateCartonType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonType**](CartonType.md)| CartonType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecartontypecustomfields"></a>
# **UpdateCartonTypeCustomFields**
> void UpdateCartonTypeCustomFields (CartonType body)

Update a cartonType custom fields

Updates an existing cartonType custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartonTypeCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartonTypeApi();
            var body = new CartonType(); // CartonType | CartonType to be updated.

            try
            {
                // Update a cartonType custom fields
                apiInstance.UpdateCartonTypeCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartonTypeApi.UpdateCartonTypeCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartonType**](CartonType.md)| CartonType to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

