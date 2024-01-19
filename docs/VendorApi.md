# Infoplus.Api.VendorApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVendor**](VendorApi.md#addvendor) | **POST** /beta/vendor | Create a vendor
[**AddVendorAudit**](VendorApi.md#addvendoraudit) | **PUT** /beta/vendor/{vendorId}/audit/{vendorAudit} | Add new audit for a vendor
[**AddVendorFile**](VendorApi.md#addvendorfile) | **POST** /beta/vendor/{vendorId}/file/{fileName} | Attach a file to a vendor
[**AddVendorFileByURL**](VendorApi.md#addvendorfilebyurl) | **POST** /beta/vendor/{vendorId}/file | Attach a file to a vendor by URL.
[**AddVendorTag**](VendorApi.md#addvendortag) | **PUT** /beta/vendor/{vendorId}/tag/{vendorTag} | Add new tags for a vendor.
[**DeleteVendor**](VendorApi.md#deletevendor) | **DELETE** /beta/vendor/{vendorId} | Delete a vendor
[**DeleteVendorFile**](VendorApi.md#deletevendorfile) | **DELETE** /beta/vendor/{vendorId}/file/{fileId} | Delete a file for a vendor.
[**DeleteVendorTag**](VendorApi.md#deletevendortag) | **DELETE** /beta/vendor/{vendorId}/tag/{vendorTag} | Delete a tag for a vendor.
[**GetDuplicateVendorById**](VendorApi.md#getduplicatevendorbyid) | **GET** /beta/vendor/duplicate/{vendorId} | Get a duplicated a vendor by id
[**GetVendorByFilter**](VendorApi.md#getvendorbyfilter) | **GET** /beta/vendor/search | Search vendors by filter
[**GetVendorById**](VendorApi.md#getvendorbyid) | **GET** /beta/vendor/{vendorId} | Get a vendor by id
[**GetVendorFiles**](VendorApi.md#getvendorfiles) | **GET** /beta/vendor/{vendorId}/file | Get the files for a vendor.
[**GetVendorTags**](VendorApi.md#getvendortags) | **GET** /beta/vendor/{vendorId}/tag | Get the tags for a vendor.
[**UpdateVendor**](VendorApi.md#updatevendor) | **PUT** /beta/vendor | Update a vendor
[**UpdateVendorCustomFields**](VendorApi.md#updatevendorcustomfields) | **PUT** /beta/vendor/customFields | Update a vendor custom fields


<a name="addvendor"></a>
# **AddVendor**
> Vendor AddVendor (Vendor body)

Create a vendor

Inserts a new vendor using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var body = new Vendor(); // Vendor | Vendor to be inserted.

            try
            {
                // Create a vendor
                Vendor result = apiInstance.AddVendor(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.AddVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Vendor**](Vendor.md)| Vendor to be inserted. | 

### Return type

[**Vendor**](Vendor.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvendoraudit"></a>
# **AddVendorAudit**
> void AddVendorAudit (int? vendorId, string vendorAudit)

Add new audit for a vendor

Adds an audit to an existing vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to add an audit to
            var vendorAudit = vendorAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a vendor
                apiInstance.AddVendorAudit(vendorId, vendorAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.AddVendorAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to add an audit to | 
 **vendorAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvendorfile"></a>
# **AddVendorFile**
> void AddVendorFile (int? vendorId, string fileName)

Attach a file to a vendor

Adds a file to an existing vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a vendor
                apiInstance.AddVendorFile(vendorId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.AddVendorFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvendorfilebyurl"></a>
# **AddVendorFileByURL**
> void AddVendorFileByURL (RecordFile body, int? vendorId)

Attach a file to a vendor by URL.

Adds a file to an existing vendor by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var vendorId = 56;  // int? | Id of the vendor to add an file to

            try
            {
                // Attach a file to a vendor by URL.
                apiInstance.AddVendorFileByURL(body, vendorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.AddVendorFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **vendorId** | **int?**| Id of the vendor to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvendortag"></a>
# **AddVendorTag**
> void AddVendorTag (int? vendorId, string vendorTag)

Add new tags for a vendor.

Adds a tag to an existing vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddVendorTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to add a tag to
            var vendorTag = vendorTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a vendor.
                apiInstance.AddVendorTag(vendorId, vendorTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.AddVendorTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to add a tag to | 
 **vendorTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendor"></a>
# **DeleteVendor**
> void DeleteVendor (int? vendorId)

Delete a vendor

Deletes the vendor identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteVendorExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to be deleted.

            try
            {
                // Delete a vendor
                apiInstance.DeleteVendor(vendorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.DeleteVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendorfile"></a>
# **DeleteVendorFile**
> void DeleteVendorFile (int? vendorId, int? fileId)

Delete a file for a vendor.

Deletes an existing vendor file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteVendorFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a vendor.
                apiInstance.DeleteVendorFile(vendorId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.DeleteVendorFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevendortag"></a>
# **DeleteVendorTag**
> void DeleteVendorTag (int? vendorId, string vendorTag)

Delete a tag for a vendor.

Deletes an existing vendor tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteVendorTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to remove tag from
            var vendorTag = vendorTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a vendor.
                apiInstance.DeleteVendorTag(vendorId, vendorTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.DeleteVendorTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to remove tag from | 
 **vendorTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatevendorbyid"></a>
# **GetDuplicateVendorById**
> Vendor GetDuplicateVendorById (int? vendorId)

Get a duplicated a vendor by id

Returns a duplicated vendor identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateVendorByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to be duplicated.

            try
            {
                // Get a duplicated a vendor by id
                Vendor result = apiInstance.GetDuplicateVendorById(vendorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.GetDuplicateVendorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to be duplicated. | 

### Return type

[**Vendor**](Vendor.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendorbyfilter"></a>
# **GetVendorByFilter**
> List<Vendor> GetVendorByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search vendors by filter

Returns the list of vendors that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search vendors by filter
                List&lt;Vendor&gt; result = apiInstance.GetVendorByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.GetVendorByFilter: " + e.Message );
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

[**List<Vendor>**](Vendor.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendorbyid"></a>
# **GetVendorById**
> Vendor GetVendorById (int? vendorId)

Get a vendor by id

Returns the vendor identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to be returned.

            try
            {
                // Get a vendor by id
                Vendor result = apiInstance.GetVendorById(vendorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.GetVendorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to be returned. | 

### Return type

[**Vendor**](Vendor.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendorfiles"></a>
# **GetVendorFiles**
> void GetVendorFiles (int? vendorId)

Get the files for a vendor.

Get all existing vendor files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to get files for

            try
            {
                // Get the files for a vendor.
                apiInstance.GetVendorFiles(vendorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.GetVendorFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvendortags"></a>
# **GetVendorTags**
> void GetVendorTags (int? vendorId)

Get the tags for a vendor.

Get all existing vendor tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetVendorTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var vendorId = 56;  // int? | Id of the vendor to get tags for

            try
            {
                // Get the tags for a vendor.
                apiInstance.GetVendorTags(vendorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.GetVendorTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorId** | **int?**| Id of the vendor to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevendor"></a>
# **UpdateVendor**
> void UpdateVendor (Vendor body)

Update a vendor

Updates an existing vendor using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateVendorExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var body = new Vendor(); // Vendor | Vendor to be updated.

            try
            {
                // Update a vendor
                apiInstance.UpdateVendor(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.UpdateVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Vendor**](Vendor.md)| Vendor to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevendorcustomfields"></a>
# **UpdateVendorCustomFields**
> void UpdateVendorCustomFields (Vendor body)

Update a vendor custom fields

Updates an existing vendor custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateVendorCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new VendorApi();
            var body = new Vendor(); // Vendor | Vendor to be updated.

            try
            {
                // Update a vendor custom fields
                apiInstance.UpdateVendorCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.UpdateVendorCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Vendor**](Vendor.md)| Vendor to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

