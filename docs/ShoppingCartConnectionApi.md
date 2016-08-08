# Infoplus.Api.ShoppingCartConnectionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddShoppingCartConnection**](ShoppingCartConnectionApi.md#addshoppingcartconnection) | **POST** /beta/shoppingCartConnection | Create a shoppingCartConnection
[**DeleteShoppingCartConnection**](ShoppingCartConnectionApi.md#deleteshoppingcartconnection) | **DELETE** /beta/shoppingCartConnection/{shoppingCartConnectionId} | Delete a shoppingCartConnection
[**GetShoppingCartConnectionByFilter**](ShoppingCartConnectionApi.md#getshoppingcartconnectionbyfilter) | **GET** /beta/shoppingCartConnection/search | Search shoppingCartConnections by filter
[**GetShoppingCartConnectionById**](ShoppingCartConnectionApi.md#getshoppingcartconnectionbyid) | **GET** /beta/shoppingCartConnection/{shoppingCartConnectionId} | Get a shoppingCartConnection by id
[**UpdateShoppingCartConnection**](ShoppingCartConnectionApi.md#updateshoppingcartconnection) | **PUT** /beta/shoppingCartConnection | Update a shoppingCartConnection
[**UpdateShoppingCartConnectionCustomFields**](ShoppingCartConnectionApi.md#updateshoppingcartconnectioncustomfields) | **PUT** /beta/shoppingCartConnection/customFields | Update a shoppingCartConnection custom fields


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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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

