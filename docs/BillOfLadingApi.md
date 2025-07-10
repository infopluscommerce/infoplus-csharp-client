# Infoplus.Api.BillOfLadingApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBillOfLading**](BillOfLadingApi.md#addbilloflading) | **POST** /beta/billOfLading | Create a billOfLading
[**AddBillOfLadingAudit**](BillOfLadingApi.md#addbillofladingaudit) | **PUT** /beta/billOfLading/{billOfLadingId}/audit/{billOfLadingAudit} | Add new audit for a billOfLading
[**AddBillOfLadingFile**](BillOfLadingApi.md#addbillofladingfile) | **POST** /beta/billOfLading/{billOfLadingId}/file/{fileName} | Attach a file to a billOfLading
[**AddBillOfLadingFileByURL**](BillOfLadingApi.md#addbillofladingfilebyurl) | **POST** /beta/billOfLading/{billOfLadingId}/file | Attach a file to a billOfLading by URL.
[**AddBillOfLadingTag**](BillOfLadingApi.md#addbillofladingtag) | **PUT** /beta/billOfLading/{billOfLadingId}/tag/{billOfLadingTag} | Add new tags for a billOfLading.
[**DeleteBillOfLading**](BillOfLadingApi.md#deletebilloflading) | **DELETE** /beta/billOfLading/{billOfLadingId} | Delete a billOfLading
[**DeleteBillOfLadingFile**](BillOfLadingApi.md#deletebillofladingfile) | **DELETE** /beta/billOfLading/{billOfLadingId}/file/{fileId} | Delete a file for a billOfLading.
[**DeleteBillOfLadingTag**](BillOfLadingApi.md#deletebillofladingtag) | **DELETE** /beta/billOfLading/{billOfLadingId}/tag/{billOfLadingTag} | Delete a tag for a billOfLading.
[**GetBillOfLadingByFilter**](BillOfLadingApi.md#getbillofladingbyfilter) | **GET** /beta/billOfLading/search | Search billOfLadings by filter
[**GetBillOfLadingById**](BillOfLadingApi.md#getbillofladingbyid) | **GET** /beta/billOfLading/{billOfLadingId} | Get a billOfLading by id
[**GetBillOfLadingFiles**](BillOfLadingApi.md#getbillofladingfiles) | **GET** /beta/billOfLading/{billOfLadingId}/file | Get the files for a billOfLading.
[**GetBillOfLadingTags**](BillOfLadingApi.md#getbillofladingtags) | **GET** /beta/billOfLading/{billOfLadingId}/tag | Get the tags for a billOfLading.
[**GetDuplicateBillOfLadingById**](BillOfLadingApi.md#getduplicatebillofladingbyid) | **GET** /beta/billOfLading/duplicate/{billOfLadingId} | Get a duplicated a billOfLading by id
[**UpdateBillOfLading**](BillOfLadingApi.md#updatebilloflading) | **PUT** /beta/billOfLading | Update a billOfLading
[**UpdateBillOfLadingCustomFields**](BillOfLadingApi.md#updatebillofladingcustomfields) | **PUT** /beta/billOfLading/customFields | Update a billOfLading custom fields


<a name="addbilloflading"></a>
# **AddBillOfLading**
> BillOfLading AddBillOfLading (BillOfLading body)

Create a billOfLading

Inserts a new billOfLading using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillOfLadingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var body = new BillOfLading(); // BillOfLading | BillOfLading to be inserted.

            try
            {
                // Create a billOfLading
                BillOfLading result = apiInstance.AddBillOfLading(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.AddBillOfLading: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfLading**](BillOfLading.md)| BillOfLading to be inserted. | 

### Return type

[**BillOfLading**](BillOfLading.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillofladingaudit"></a>
# **AddBillOfLadingAudit**
> void AddBillOfLadingAudit (int? billOfLadingId, string billOfLadingAudit)

Add new audit for a billOfLading

Adds an audit to an existing billOfLading.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillOfLadingAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to add an audit to
            var billOfLadingAudit = billOfLadingAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a billOfLading
                apiInstance.AddBillOfLadingAudit(billOfLadingId, billOfLadingAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.AddBillOfLadingAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to add an audit to | 
 **billOfLadingAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillofladingfile"></a>
# **AddBillOfLadingFile**
> void AddBillOfLadingFile (int? billOfLadingId, string fileName)

Attach a file to a billOfLading

Adds a file to an existing billOfLading.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillOfLadingFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a billOfLading
                apiInstance.AddBillOfLadingFile(billOfLadingId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.AddBillOfLadingFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillofladingfilebyurl"></a>
# **AddBillOfLadingFileByURL**
> void AddBillOfLadingFileByURL (RecordFile body, int? billOfLadingId)

Attach a file to a billOfLading by URL.

Adds a file to an existing billOfLading by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillOfLadingFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var billOfLadingId = 56;  // int? | Id of the billOfLading to add an file to

            try
            {
                // Attach a file to a billOfLading by URL.
                apiInstance.AddBillOfLadingFileByURL(body, billOfLadingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.AddBillOfLadingFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **billOfLadingId** | **int?**| Id of the billOfLading to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbillofladingtag"></a>
# **AddBillOfLadingTag**
> void AddBillOfLadingTag (int? billOfLadingId, string billOfLadingTag)

Add new tags for a billOfLading.

Adds a tag to an existing billOfLading.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBillOfLadingTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to add a tag to
            var billOfLadingTag = billOfLadingTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a billOfLading.
                apiInstance.AddBillOfLadingTag(billOfLadingId, billOfLadingTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.AddBillOfLadingTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to add a tag to | 
 **billOfLadingTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebilloflading"></a>
# **DeleteBillOfLading**
> void DeleteBillOfLading (int? billOfLadingId)

Delete a billOfLading

Deletes the billOfLading identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillOfLadingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to be deleted.

            try
            {
                // Delete a billOfLading
                apiInstance.DeleteBillOfLading(billOfLadingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.DeleteBillOfLading: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillofladingfile"></a>
# **DeleteBillOfLadingFile**
> void DeleteBillOfLadingFile (int? billOfLadingId, int? fileId)

Delete a file for a billOfLading.

Deletes an existing billOfLading file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillOfLadingFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a billOfLading.
                apiInstance.DeleteBillOfLadingFile(billOfLadingId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.DeleteBillOfLadingFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebillofladingtag"></a>
# **DeleteBillOfLadingTag**
> void DeleteBillOfLadingTag (int? billOfLadingId, string billOfLadingTag)

Delete a tag for a billOfLading.

Deletes an existing billOfLading tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBillOfLadingTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to remove tag from
            var billOfLadingTag = billOfLadingTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a billOfLading.
                apiInstance.DeleteBillOfLadingTag(billOfLadingId, billOfLadingTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.DeleteBillOfLadingTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to remove tag from | 
 **billOfLadingTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillofladingbyfilter"></a>
# **GetBillOfLadingByFilter**
> List<BillOfLading> GetBillOfLadingByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search billOfLadings by filter

Returns the list of billOfLadings that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillOfLadingByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search billOfLadings by filter
                List&lt;BillOfLading&gt; result = apiInstance.GetBillOfLadingByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.GetBillOfLadingByFilter: " + e.Message );
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

[**List<BillOfLading>**](BillOfLading.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillofladingbyid"></a>
# **GetBillOfLadingById**
> BillOfLading GetBillOfLadingById (int? billOfLadingId)

Get a billOfLading by id

Returns the billOfLading identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillOfLadingByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to be returned.

            try
            {
                // Get a billOfLading by id
                BillOfLading result = apiInstance.GetBillOfLadingById(billOfLadingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.GetBillOfLadingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to be returned. | 

### Return type

[**BillOfLading**](BillOfLading.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillofladingfiles"></a>
# **GetBillOfLadingFiles**
> void GetBillOfLadingFiles (int? billOfLadingId)

Get the files for a billOfLading.

Get all existing billOfLading files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillOfLadingFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to get files for

            try
            {
                // Get the files for a billOfLading.
                apiInstance.GetBillOfLadingFiles(billOfLadingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.GetBillOfLadingFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillofladingtags"></a>
# **GetBillOfLadingTags**
> void GetBillOfLadingTags (int? billOfLadingId)

Get the tags for a billOfLading.

Get all existing billOfLading tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBillOfLadingTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to get tags for

            try
            {
                // Get the tags for a billOfLading.
                apiInstance.GetBillOfLadingTags(billOfLadingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.GetBillOfLadingTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatebillofladingbyid"></a>
# **GetDuplicateBillOfLadingById**
> BillOfLading GetDuplicateBillOfLadingById (int? billOfLadingId)

Get a duplicated a billOfLading by id

Returns a duplicated billOfLading identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateBillOfLadingByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var billOfLadingId = 56;  // int? | Id of the billOfLading to be duplicated.

            try
            {
                // Get a duplicated a billOfLading by id
                BillOfLading result = apiInstance.GetDuplicateBillOfLadingById(billOfLadingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.GetDuplicateBillOfLadingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billOfLadingId** | **int?**| Id of the billOfLading to be duplicated. | 

### Return type

[**BillOfLading**](BillOfLading.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebilloflading"></a>
# **UpdateBillOfLading**
> void UpdateBillOfLading (BillOfLading body)

Update a billOfLading

Updates an existing billOfLading using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillOfLadingExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var body = new BillOfLading(); // BillOfLading | BillOfLading to be updated.

            try
            {
                // Update a billOfLading
                apiInstance.UpdateBillOfLading(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.UpdateBillOfLading: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfLading**](BillOfLading.md)| BillOfLading to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebillofladingcustomfields"></a>
# **UpdateBillOfLadingCustomFields**
> void UpdateBillOfLadingCustomFields (BillOfLading body)

Update a billOfLading custom fields

Updates an existing billOfLading custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBillOfLadingCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BillOfLadingApi();
            var body = new BillOfLading(); // BillOfLading | BillOfLading to be updated.

            try
            {
                // Update a billOfLading custom fields
                apiInstance.UpdateBillOfLadingCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillOfLadingApi.UpdateBillOfLadingCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BillOfLading**](BillOfLading.md)| BillOfLading to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

