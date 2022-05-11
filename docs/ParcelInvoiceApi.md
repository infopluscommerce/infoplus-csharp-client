# Infoplus.Api.ParcelInvoiceApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddParcelInvoiceAudit**](ParcelInvoiceApi.md#addparcelinvoiceaudit) | **PUT** /v3.0/parcelInvoice/{parcelInvoiceId}/audit/{parcelInvoiceAudit} | Add new audit for a parcelInvoice
[**AddParcelInvoiceFile**](ParcelInvoiceApi.md#addparcelinvoicefile) | **POST** /v3.0/parcelInvoice/{parcelInvoiceId}/file/{fileName} | Attach a file to a parcelInvoice
[**AddParcelInvoiceFileByURL**](ParcelInvoiceApi.md#addparcelinvoicefilebyurl) | **POST** /v3.0/parcelInvoice/{parcelInvoiceId}/file | Attach a file to a parcelInvoice by URL.
[**AddParcelInvoiceTag**](ParcelInvoiceApi.md#addparcelinvoicetag) | **PUT** /v3.0/parcelInvoice/{parcelInvoiceId}/tag/{parcelInvoiceTag} | Add new tags for a parcelInvoice.
[**DeleteParcelInvoice**](ParcelInvoiceApi.md#deleteparcelinvoice) | **DELETE** /v3.0/parcelInvoice/{parcelInvoiceId} | Delete a parcelInvoice
[**DeleteParcelInvoiceFile**](ParcelInvoiceApi.md#deleteparcelinvoicefile) | **DELETE** /v3.0/parcelInvoice/{parcelInvoiceId}/file/{fileId} | Delete a file for a parcelInvoice.
[**DeleteParcelInvoiceTag**](ParcelInvoiceApi.md#deleteparcelinvoicetag) | **DELETE** /v3.0/parcelInvoice/{parcelInvoiceId}/tag/{parcelInvoiceTag} | Delete a tag for a parcelInvoice.
[**GetDuplicateParcelInvoiceById**](ParcelInvoiceApi.md#getduplicateparcelinvoicebyid) | **GET** /v3.0/parcelInvoice/duplicate/{parcelInvoiceId} | Get a duplicated a parcelInvoice by id
[**GetParcelInvoiceByFilter**](ParcelInvoiceApi.md#getparcelinvoicebyfilter) | **GET** /v3.0/parcelInvoice/search | Search parcelInvoices by filter
[**GetParcelInvoiceById**](ParcelInvoiceApi.md#getparcelinvoicebyid) | **GET** /v3.0/parcelInvoice/{parcelInvoiceId} | Get a parcelInvoice by id
[**GetParcelInvoiceFiles**](ParcelInvoiceApi.md#getparcelinvoicefiles) | **GET** /v3.0/parcelInvoice/{parcelInvoiceId}/file | Get the files for a parcelInvoice.
[**GetParcelInvoiceTags**](ParcelInvoiceApi.md#getparcelinvoicetags) | **GET** /v3.0/parcelInvoice/{parcelInvoiceId}/tag | Get the tags for a parcelInvoice.


<a name="addparcelinvoiceaudit"></a>
# **AddParcelInvoiceAudit**
> void AddParcelInvoiceAudit (int? parcelInvoiceId, string parcelInvoiceAudit)

Add new audit for a parcelInvoice

Adds an audit to an existing parcelInvoice.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelInvoiceAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to add an audit to
            var parcelInvoiceAudit = parcelInvoiceAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a parcelInvoice
                apiInstance.AddParcelInvoiceAudit(parcelInvoiceId, parcelInvoiceAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.AddParcelInvoiceAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to add an audit to | 
 **parcelInvoiceAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelinvoicefile"></a>
# **AddParcelInvoiceFile**
> void AddParcelInvoiceFile (int? parcelInvoiceId, string fileName)

Attach a file to a parcelInvoice

Adds a file to an existing parcelInvoice.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelInvoiceFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a parcelInvoice
                apiInstance.AddParcelInvoiceFile(parcelInvoiceId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.AddParcelInvoiceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelinvoicefilebyurl"></a>
# **AddParcelInvoiceFileByURL**
> void AddParcelInvoiceFileByURL (RecordFile body, int? parcelInvoiceId)

Attach a file to a parcelInvoice by URL.

Adds a file to an existing parcelInvoice by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelInvoiceFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to add an file to

            try
            {
                // Attach a file to a parcelInvoice by URL.
                apiInstance.AddParcelInvoiceFileByURL(body, parcelInvoiceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.AddParcelInvoiceFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelinvoicetag"></a>
# **AddParcelInvoiceTag**
> void AddParcelInvoiceTag (int? parcelInvoiceId, string parcelInvoiceTag)

Add new tags for a parcelInvoice.

Adds a tag to an existing parcelInvoice.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelInvoiceTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to add a tag to
            var parcelInvoiceTag = parcelInvoiceTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a parcelInvoice.
                apiInstance.AddParcelInvoiceTag(parcelInvoiceId, parcelInvoiceTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.AddParcelInvoiceTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to add a tag to | 
 **parcelInvoiceTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparcelinvoice"></a>
# **DeleteParcelInvoice**
> void DeleteParcelInvoice (int? parcelInvoiceId)

Delete a parcelInvoice

Deletes the parcelInvoice identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteParcelInvoiceExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to be deleted.

            try
            {
                // Delete a parcelInvoice
                apiInstance.DeleteParcelInvoice(parcelInvoiceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.DeleteParcelInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparcelinvoicefile"></a>
# **DeleteParcelInvoiceFile**
> void DeleteParcelInvoiceFile (int? parcelInvoiceId, int? fileId)

Delete a file for a parcelInvoice.

Deletes an existing parcelInvoice file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteParcelInvoiceFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a parcelInvoice.
                apiInstance.DeleteParcelInvoiceFile(parcelInvoiceId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.DeleteParcelInvoiceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparcelinvoicetag"></a>
# **DeleteParcelInvoiceTag**
> void DeleteParcelInvoiceTag (int? parcelInvoiceId, string parcelInvoiceTag)

Delete a tag for a parcelInvoice.

Deletes an existing parcelInvoice tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteParcelInvoiceTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to remove tag from
            var parcelInvoiceTag = parcelInvoiceTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a parcelInvoice.
                apiInstance.DeleteParcelInvoiceTag(parcelInvoiceId, parcelInvoiceTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.DeleteParcelInvoiceTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to remove tag from | 
 **parcelInvoiceTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateparcelinvoicebyid"></a>
# **GetDuplicateParcelInvoiceById**
> ParcelInvoice GetDuplicateParcelInvoiceById (int? parcelInvoiceId)

Get a duplicated a parcelInvoice by id

Returns a duplicated parcelInvoice identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateParcelInvoiceByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to be duplicated.

            try
            {
                // Get a duplicated a parcelInvoice by id
                ParcelInvoice result = apiInstance.GetDuplicateParcelInvoiceById(parcelInvoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.GetDuplicateParcelInvoiceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to be duplicated. | 

### Return type

[**ParcelInvoice**](ParcelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelinvoicebyfilter"></a>
# **GetParcelInvoiceByFilter**
> List<ParcelInvoice> GetParcelInvoiceByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search parcelInvoices by filter

Returns the list of parcelInvoices that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelInvoiceByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search parcelInvoices by filter
                List&lt;ParcelInvoice&gt; result = apiInstance.GetParcelInvoiceByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.GetParcelInvoiceByFilter: " + e.Message );
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

[**List<ParcelInvoice>**](ParcelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelinvoicebyid"></a>
# **GetParcelInvoiceById**
> ParcelInvoice GetParcelInvoiceById (int? parcelInvoiceId)

Get a parcelInvoice by id

Returns the parcelInvoice identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelInvoiceByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to be returned.

            try
            {
                // Get a parcelInvoice by id
                ParcelInvoice result = apiInstance.GetParcelInvoiceById(parcelInvoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.GetParcelInvoiceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to be returned. | 

### Return type

[**ParcelInvoice**](ParcelInvoice.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelinvoicefiles"></a>
# **GetParcelInvoiceFiles**
> void GetParcelInvoiceFiles (int? parcelInvoiceId)

Get the files for a parcelInvoice.

Get all existing parcelInvoice files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelInvoiceFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to get files for

            try
            {
                // Get the files for a parcelInvoice.
                apiInstance.GetParcelInvoiceFiles(parcelInvoiceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.GetParcelInvoiceFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelinvoicetags"></a>
# **GetParcelInvoiceTags**
> void GetParcelInvoiceTags (int? parcelInvoiceId)

Get the tags for a parcelInvoice.

Get all existing parcelInvoice tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelInvoiceTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelInvoiceApi();
            var parcelInvoiceId = 56;  // int? | Id of the parcelInvoice to get tags for

            try
            {
                // Get the tags for a parcelInvoice.
                apiInstance.GetParcelInvoiceTags(parcelInvoiceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelInvoiceApi.GetParcelInvoiceTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelInvoiceId** | **int?**| Id of the parcelInvoice to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

