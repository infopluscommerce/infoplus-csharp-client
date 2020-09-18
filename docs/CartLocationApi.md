# Infoplus.Api.CartLocationApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCartLocationAudit**](CartLocationApi.md#addcartlocationaudit) | **PUT** /beta/cartLocation/{cartLocationId}/audit/{cartLocationAudit} | Add new audit for a cartLocation
[**AddCartLocationFile**](CartLocationApi.md#addcartlocationfile) | **POST** /beta/cartLocation/{cartLocationId}/file/{fileName} | Attach a file to a cartLocation
[**AddCartLocationFileByURL**](CartLocationApi.md#addcartlocationfilebyurl) | **POST** /beta/cartLocation/{cartLocationId}/file | Attach a file to a cartLocation by URL.
[**AddCartLocationTag**](CartLocationApi.md#addcartlocationtag) | **PUT** /beta/cartLocation/{cartLocationId}/tag/{cartLocationTag} | Add new tags for a cartLocation.
[**DeleteCartLocationFile**](CartLocationApi.md#deletecartlocationfile) | **DELETE** /beta/cartLocation/{cartLocationId}/file/{fileId} | Delete a file for a cartLocation.
[**DeleteCartLocationTag**](CartLocationApi.md#deletecartlocationtag) | **DELETE** /beta/cartLocation/{cartLocationId}/tag/{cartLocationTag} | Delete a tag for a cartLocation.
[**GetCartLocationByFilter**](CartLocationApi.md#getcartlocationbyfilter) | **GET** /beta/cartLocation/search | Search cartLocations by filter
[**GetCartLocationById**](CartLocationApi.md#getcartlocationbyid) | **GET** /beta/cartLocation/{cartLocationId} | Get a cartLocation by id
[**GetCartLocationFiles**](CartLocationApi.md#getcartlocationfiles) | **GET** /beta/cartLocation/{cartLocationId}/file | Get the files for a cartLocation.
[**GetCartLocationTags**](CartLocationApi.md#getcartlocationtags) | **GET** /beta/cartLocation/{cartLocationId}/tag | Get the tags for a cartLocation.
[**GetDuplicateCartLocationById**](CartLocationApi.md#getduplicatecartlocationbyid) | **GET** /beta/cartLocation/duplicate/{cartLocationId} | Get a duplicated a cartLocation by id


<a name="addcartlocationaudit"></a>
# **AddCartLocationAudit**
> void AddCartLocationAudit (int? cartLocationId, string cartLocationAudit)

Add new audit for a cartLocation

Adds an audit to an existing cartLocation.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartLocationAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to add an audit to
            var cartLocationAudit = cartLocationAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a cartLocation
                apiInstance.AddCartLocationAudit(cartLocationId, cartLocationAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.AddCartLocationAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to add an audit to | 
 **cartLocationAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartlocationfile"></a>
# **AddCartLocationFile**
> void AddCartLocationFile (int? cartLocationId, string fileName)

Attach a file to a cartLocation

Adds a file to an existing cartLocation.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartLocationFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a cartLocation
                apiInstance.AddCartLocationFile(cartLocationId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.AddCartLocationFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartlocationfilebyurl"></a>
# **AddCartLocationFileByURL**
> void AddCartLocationFileByURL (RecordFile body, int? cartLocationId)

Attach a file to a cartLocation by URL.

Adds a file to an existing cartLocation by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartLocationFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var cartLocationId = 56;  // int? | Id of the cartLocation to add an file to

            try
            {
                // Attach a file to a cartLocation by URL.
                apiInstance.AddCartLocationFileByURL(body, cartLocationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.AddCartLocationFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **cartLocationId** | **int?**| Id of the cartLocation to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartlocationtag"></a>
# **AddCartLocationTag**
> void AddCartLocationTag (int? cartLocationId, string cartLocationTag)

Add new tags for a cartLocation.

Adds a tag to an existing cartLocation.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartLocationTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to add a tag to
            var cartLocationTag = cartLocationTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a cartLocation.
                apiInstance.AddCartLocationTag(cartLocationId, cartLocationTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.AddCartLocationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to add a tag to | 
 **cartLocationTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartlocationfile"></a>
# **DeleteCartLocationFile**
> void DeleteCartLocationFile (int? cartLocationId, int? fileId)

Delete a file for a cartLocation.

Deletes an existing cartLocation file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartLocationFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a cartLocation.
                apiInstance.DeleteCartLocationFile(cartLocationId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.DeleteCartLocationFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartlocationtag"></a>
# **DeleteCartLocationTag**
> void DeleteCartLocationTag (int? cartLocationId, string cartLocationTag)

Delete a tag for a cartLocation.

Deletes an existing cartLocation tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartLocationTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to remove tag from
            var cartLocationTag = cartLocationTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a cartLocation.
                apiInstance.DeleteCartLocationTag(cartLocationId, cartLocationTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.DeleteCartLocationTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to remove tag from | 
 **cartLocationTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartlocationbyfilter"></a>
# **GetCartLocationByFilter**
> List<CartLocation> GetCartLocationByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search cartLocations by filter

Returns the list of cartLocations that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartLocationByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search cartLocations by filter
                List&lt;CartLocation&gt; result = apiInstance.GetCartLocationByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.GetCartLocationByFilter: " + e.Message );
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

[**List<CartLocation>**](CartLocation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartlocationbyid"></a>
# **GetCartLocationById**
> CartLocation GetCartLocationById (int? cartLocationId)

Get a cartLocation by id

Returns the cartLocation identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartLocationByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to be returned.

            try
            {
                // Get a cartLocation by id
                CartLocation result = apiInstance.GetCartLocationById(cartLocationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.GetCartLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to be returned. | 

### Return type

[**CartLocation**](CartLocation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartlocationfiles"></a>
# **GetCartLocationFiles**
> void GetCartLocationFiles (int? cartLocationId)

Get the files for a cartLocation.

Get all existing cartLocation files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartLocationFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to get files for

            try
            {
                // Get the files for a cartLocation.
                apiInstance.GetCartLocationFiles(cartLocationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.GetCartLocationFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartlocationtags"></a>
# **GetCartLocationTags**
> void GetCartLocationTags (int? cartLocationId)

Get the tags for a cartLocation.

Get all existing cartLocation tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartLocationTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to get tags for

            try
            {
                // Get the tags for a cartLocation.
                apiInstance.GetCartLocationTags(cartLocationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.GetCartLocationTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecartlocationbyid"></a>
# **GetDuplicateCartLocationById**
> CartLocation GetDuplicateCartLocationById (int? cartLocationId)

Get a duplicated a cartLocation by id

Returns a duplicated cartLocation identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCartLocationByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartLocationApi();
            var cartLocationId = 56;  // int? | Id of the cartLocation to be duplicated.

            try
            {
                // Get a duplicated a cartLocation by id
                CartLocation result = apiInstance.GetDuplicateCartLocationById(cartLocationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartLocationApi.GetDuplicateCartLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartLocationId** | **int?**| Id of the cartLocation to be duplicated. | 

### Return type

[**CartLocation**](CartLocation.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

