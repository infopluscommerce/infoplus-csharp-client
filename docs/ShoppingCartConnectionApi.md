# Infoplus.Api.ShoppingCartConnectionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddShoppingCartConnection**](ShoppingCartConnectionApi.md#addshoppingcartconnection) | **POST** /v3.0/shoppingCartConnection | Create a shoppingCartConnection
[**AddShoppingCartConnectionAudit**](ShoppingCartConnectionApi.md#addshoppingcartconnectionaudit) | **PUT** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/audit/{shoppingCartConnectionAudit} | Add new audit for a shoppingCartConnection
[**AddShoppingCartConnectionFile**](ShoppingCartConnectionApi.md#addshoppingcartconnectionfile) | **POST** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/file/{fileName} | Attach a file to a shoppingCartConnection
[**AddShoppingCartConnectionFileByURL**](ShoppingCartConnectionApi.md#addshoppingcartconnectionfilebyurl) | **POST** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/file | Attach a file to a shoppingCartConnection by URL.
[**AddShoppingCartConnectionTag**](ShoppingCartConnectionApi.md#addshoppingcartconnectiontag) | **PUT** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/tag/{shoppingCartConnectionTag} | Add new tags for a shoppingCartConnection.
[**DeleteShoppingCartConnection**](ShoppingCartConnectionApi.md#deleteshoppingcartconnection) | **DELETE** /v3.0/shoppingCartConnection/{shoppingCartConnectionId} | Delete a shoppingCartConnection
[**DeleteShoppingCartConnectionFile**](ShoppingCartConnectionApi.md#deleteshoppingcartconnectionfile) | **DELETE** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/file/{fileId} | Delete a file for a shoppingCartConnection.
[**DeleteShoppingCartConnectionTag**](ShoppingCartConnectionApi.md#deleteshoppingcartconnectiontag) | **DELETE** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/tag/{shoppingCartConnectionTag} | Delete a tag for a shoppingCartConnection.
[**GetDuplicateShoppingCartConnectionById**](ShoppingCartConnectionApi.md#getduplicateshoppingcartconnectionbyid) | **GET** /v3.0/shoppingCartConnection/duplicate/{shoppingCartConnectionId} | Get a duplicated a shoppingCartConnection by id
[**GetShoppingCartConnectionByFilter**](ShoppingCartConnectionApi.md#getshoppingcartconnectionbyfilter) | **GET** /v3.0/shoppingCartConnection/search | Search shoppingCartConnections by filter
[**GetShoppingCartConnectionById**](ShoppingCartConnectionApi.md#getshoppingcartconnectionbyid) | **GET** /v3.0/shoppingCartConnection/{shoppingCartConnectionId} | Get a shoppingCartConnection by id
[**GetShoppingCartConnectionFiles**](ShoppingCartConnectionApi.md#getshoppingcartconnectionfiles) | **GET** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/file | Get the files for a shoppingCartConnection.
[**GetShoppingCartConnectionTags**](ShoppingCartConnectionApi.md#getshoppingcartconnectiontags) | **GET** /v3.0/shoppingCartConnection/{shoppingCartConnectionId}/tag | Get the tags for a shoppingCartConnection.
[**UpdateShoppingCartConnection**](ShoppingCartConnectionApi.md#updateshoppingcartconnection) | **PUT** /v3.0/shoppingCartConnection | Update a shoppingCartConnection
[**UpdateShoppingCartConnectionCustomFields**](ShoppingCartConnectionApi.md#updateshoppingcartconnectioncustomfields) | **PUT** /v3.0/shoppingCartConnection/customFields | Update a shoppingCartConnection custom fields


<a name="addshoppingcartconnection"></a>
# **AddShoppingCartConnection**
> ShoppingCartConnection AddShoppingCartConnection (ShoppingCartConnection body)

Create a shoppingCartConnection

Inserts a new shoppingCartConnection using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShoppingCartConnectionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var body = new ShoppingCartConnection(); // ShoppingCartConnection | ShoppingCartConnection to be inserted.

            try
            {
                // Create a shoppingCartConnection
                ShoppingCartConnection result = apiInstance.AddShoppingCartConnection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.AddShoppingCartConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShoppingCartConnection**](ShoppingCartConnection.md)| ShoppingCartConnection to be inserted. | 

### Return type

[**ShoppingCartConnection**](ShoppingCartConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addshoppingcartconnectionaudit"></a>
# **AddShoppingCartConnectionAudit**
> void AddShoppingCartConnectionAudit (int? shoppingCartConnectionId, string shoppingCartConnectionAudit)

Add new audit for a shoppingCartConnection

Adds an audit to an existing shoppingCartConnection.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShoppingCartConnectionAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to add an audit to
            var shoppingCartConnectionAudit = shoppingCartConnectionAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a shoppingCartConnection
                apiInstance.AddShoppingCartConnectionAudit(shoppingCartConnectionId, shoppingCartConnectionAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.AddShoppingCartConnectionAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to add an audit to | 
 **shoppingCartConnectionAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addshoppingcartconnectionfile"></a>
# **AddShoppingCartConnectionFile**
> void AddShoppingCartConnectionFile (int? shoppingCartConnectionId, string fileName)

Attach a file to a shoppingCartConnection

Adds a file to an existing shoppingCartConnection.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShoppingCartConnectionFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a shoppingCartConnection
                apiInstance.AddShoppingCartConnectionFile(shoppingCartConnectionId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.AddShoppingCartConnectionFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addshoppingcartconnectionfilebyurl"></a>
# **AddShoppingCartConnectionFileByURL**
> void AddShoppingCartConnectionFileByURL (RecordFile body, int? shoppingCartConnectionId)

Attach a file to a shoppingCartConnection by URL.

Adds a file to an existing shoppingCartConnection by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShoppingCartConnectionFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to add an file to

            try
            {
                // Attach a file to a shoppingCartConnection by URL.
                apiInstance.AddShoppingCartConnectionFileByURL(body, shoppingCartConnectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.AddShoppingCartConnectionFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addshoppingcartconnectiontag"></a>
# **AddShoppingCartConnectionTag**
> void AddShoppingCartConnectionTag (int? shoppingCartConnectionId, string shoppingCartConnectionTag)

Add new tags for a shoppingCartConnection.

Adds a tag to an existing shoppingCartConnection.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShoppingCartConnectionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to add a tag to
            var shoppingCartConnectionTag = shoppingCartConnectionTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a shoppingCartConnection.
                apiInstance.AddShoppingCartConnectionTag(shoppingCartConnectionId, shoppingCartConnectionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.AddShoppingCartConnectionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to add a tag to | 
 **shoppingCartConnectionTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshoppingcartconnection"></a>
# **DeleteShoppingCartConnection**
> void DeleteShoppingCartConnection (int? shoppingCartConnectionId)

Delete a shoppingCartConnection

Deletes the shoppingCartConnection identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteShoppingCartConnectionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to be deleted.

            try
            {
                // Delete a shoppingCartConnection
                apiInstance.DeleteShoppingCartConnection(shoppingCartConnectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.DeleteShoppingCartConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshoppingcartconnectionfile"></a>
# **DeleteShoppingCartConnectionFile**
> void DeleteShoppingCartConnectionFile (int? shoppingCartConnectionId, int? fileId)

Delete a file for a shoppingCartConnection.

Deletes an existing shoppingCartConnection file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteShoppingCartConnectionFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a shoppingCartConnection.
                apiInstance.DeleteShoppingCartConnectionFile(shoppingCartConnectionId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.DeleteShoppingCartConnectionFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshoppingcartconnectiontag"></a>
# **DeleteShoppingCartConnectionTag**
> void DeleteShoppingCartConnectionTag (int? shoppingCartConnectionId, string shoppingCartConnectionTag)

Delete a tag for a shoppingCartConnection.

Deletes an existing shoppingCartConnection tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteShoppingCartConnectionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to remove tag from
            var shoppingCartConnectionTag = shoppingCartConnectionTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a shoppingCartConnection.
                apiInstance.DeleteShoppingCartConnectionTag(shoppingCartConnectionId, shoppingCartConnectionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.DeleteShoppingCartConnectionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to remove tag from | 
 **shoppingCartConnectionTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateshoppingcartconnectionbyid"></a>
# **GetDuplicateShoppingCartConnectionById**
> ShoppingCartConnection GetDuplicateShoppingCartConnectionById (int? shoppingCartConnectionId)

Get a duplicated a shoppingCartConnection by id

Returns a duplicated shoppingCartConnection identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateShoppingCartConnectionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to be duplicated.

            try
            {
                // Get a duplicated a shoppingCartConnection by id
                ShoppingCartConnection result = apiInstance.GetDuplicateShoppingCartConnectionById(shoppingCartConnectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.GetDuplicateShoppingCartConnectionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to be duplicated. | 

### Return type

[**ShoppingCartConnection**](ShoppingCartConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshoppingcartconnectionbyfilter"></a>
# **GetShoppingCartConnectionByFilter**
> List<ShoppingCartConnection> GetShoppingCartConnectionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search shoppingCartConnections by filter

Returns the list of shoppingCartConnections that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetShoppingCartConnectionByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search shoppingCartConnections by filter
                List&lt;ShoppingCartConnection&gt; result = apiInstance.GetShoppingCartConnectionByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.GetShoppingCartConnectionByFilter: " + e.Message );
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

[**List<ShoppingCartConnection>**](ShoppingCartConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshoppingcartconnectionbyid"></a>
# **GetShoppingCartConnectionById**
> ShoppingCartConnection GetShoppingCartConnectionById (int? shoppingCartConnectionId)

Get a shoppingCartConnection by id

Returns the shoppingCartConnection identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetShoppingCartConnectionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to be returned.

            try
            {
                // Get a shoppingCartConnection by id
                ShoppingCartConnection result = apiInstance.GetShoppingCartConnectionById(shoppingCartConnectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.GetShoppingCartConnectionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to be returned. | 

### Return type

[**ShoppingCartConnection**](ShoppingCartConnection.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshoppingcartconnectionfiles"></a>
# **GetShoppingCartConnectionFiles**
> void GetShoppingCartConnectionFiles (int? shoppingCartConnectionId)

Get the files for a shoppingCartConnection.

Get all existing shoppingCartConnection files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetShoppingCartConnectionFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to get files for

            try
            {
                // Get the files for a shoppingCartConnection.
                apiInstance.GetShoppingCartConnectionFiles(shoppingCartConnectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.GetShoppingCartConnectionFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshoppingcartconnectiontags"></a>
# **GetShoppingCartConnectionTags**
> void GetShoppingCartConnectionTags (int? shoppingCartConnectionId)

Get the tags for a shoppingCartConnection.

Get all existing shoppingCartConnection tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetShoppingCartConnectionTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var shoppingCartConnectionId = 56;  // int? | Id of the shoppingCartConnection to get tags for

            try
            {
                // Get the tags for a shoppingCartConnection.
                apiInstance.GetShoppingCartConnectionTags(shoppingCartConnectionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.GetShoppingCartConnectionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shoppingCartConnectionId** | **int?**| Id of the shoppingCartConnection to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshoppingcartconnection"></a>
# **UpdateShoppingCartConnection**
> void UpdateShoppingCartConnection (ShoppingCartConnection body)

Update a shoppingCartConnection

Updates an existing shoppingCartConnection using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateShoppingCartConnectionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var body = new ShoppingCartConnection(); // ShoppingCartConnection | ShoppingCartConnection to be updated.

            try
            {
                // Update a shoppingCartConnection
                apiInstance.UpdateShoppingCartConnection(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.UpdateShoppingCartConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShoppingCartConnection**](ShoppingCartConnection.md)| ShoppingCartConnection to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshoppingcartconnectioncustomfields"></a>
# **UpdateShoppingCartConnectionCustomFields**
> void UpdateShoppingCartConnectionCustomFields (ShoppingCartConnection body)

Update a shoppingCartConnection custom fields

Updates an existing shoppingCartConnection custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateShoppingCartConnectionCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShoppingCartConnectionApi();
            var body = new ShoppingCartConnection(); // ShoppingCartConnection | ShoppingCartConnection to be updated.

            try
            {
                // Update a shoppingCartConnection custom fields
                apiInstance.UpdateShoppingCartConnectionCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShoppingCartConnectionApi.UpdateShoppingCartConnectionCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShoppingCartConnection**](ShoppingCartConnection.md)| ShoppingCartConnection to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

