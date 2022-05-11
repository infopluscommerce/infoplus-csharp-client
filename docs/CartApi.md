# Infoplus.Api.CartApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCart**](CartApi.md#addcart) | **POST** /v3.0/cart | Create a cart
[**AddCartAudit**](CartApi.md#addcartaudit) | **PUT** /v3.0/cart/{cartId}/audit/{cartAudit} | Add new audit for a cart
[**AddCartFile**](CartApi.md#addcartfile) | **POST** /v3.0/cart/{cartId}/file/{fileName} | Attach a file to a cart
[**AddCartFileByURL**](CartApi.md#addcartfilebyurl) | **POST** /v3.0/cart/{cartId}/file | Attach a file to a cart by URL.
[**AddCartTag**](CartApi.md#addcarttag) | **PUT** /v3.0/cart/{cartId}/tag/{cartTag} | Add new tags for a cart.
[**DeleteCart**](CartApi.md#deletecart) | **DELETE** /v3.0/cart/{cartId} | Delete a cart
[**DeleteCartFile**](CartApi.md#deletecartfile) | **DELETE** /v3.0/cart/{cartId}/file/{fileId} | Delete a file for a cart.
[**DeleteCartTag**](CartApi.md#deletecarttag) | **DELETE** /v3.0/cart/{cartId}/tag/{cartTag} | Delete a tag for a cart.
[**GetCartByFilter**](CartApi.md#getcartbyfilter) | **GET** /v3.0/cart/search | Search carts by filter
[**GetCartById**](CartApi.md#getcartbyid) | **GET** /v3.0/cart/{cartId} | Get a cart by id
[**GetCartFiles**](CartApi.md#getcartfiles) | **GET** /v3.0/cart/{cartId}/file | Get the files for a cart.
[**GetCartTags**](CartApi.md#getcarttags) | **GET** /v3.0/cart/{cartId}/tag | Get the tags for a cart.
[**GetDuplicateCartById**](CartApi.md#getduplicatecartbyid) | **GET** /v3.0/cart/duplicate/{cartId} | Get a duplicated a cart by id
[**UpdateCart**](CartApi.md#updatecart) | **PUT** /v3.0/cart | Update a cart


<a name="addcart"></a>
# **AddCart**
> Cart AddCart (Cart body)

Create a cart

Inserts a new cart using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var body = new Cart(); // Cart | Cart to be inserted.

            try
            {
                // Create a cart
                Cart result = apiInstance.AddCart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.AddCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Cart**](Cart.md)| Cart to be inserted. | 

### Return type

[**Cart**](Cart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartaudit"></a>
# **AddCartAudit**
> void AddCartAudit (int? cartId, string cartAudit)

Add new audit for a cart

Adds an audit to an existing cart.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to add an audit to
            var cartAudit = cartAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a cart
                apiInstance.AddCartAudit(cartId, cartAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.AddCartAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to add an audit to | 
 **cartAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartfile"></a>
# **AddCartFile**
> void AddCartFile (int? cartId, string fileName)

Attach a file to a cart

Adds a file to an existing cart.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a cart
                apiInstance.AddCartFile(cartId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.AddCartFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcartfilebyurl"></a>
# **AddCartFileByURL**
> void AddCartFileByURL (RecordFile body, int? cartId)

Attach a file to a cart by URL.

Adds a file to an existing cart by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var cartId = 56;  // int? | Id of the cart to add an file to

            try
            {
                // Attach a file to a cart by URL.
                apiInstance.AddCartFileByURL(body, cartId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.AddCartFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **cartId** | **int?**| Id of the cart to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcarttag"></a>
# **AddCartTag**
> void AddCartTag (int? cartId, string cartTag)

Add new tags for a cart.

Adds a tag to an existing cart.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCartTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to add a tag to
            var cartTag = cartTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a cart.
                apiInstance.AddCartTag(cartId, cartTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.AddCartTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to add a tag to | 
 **cartTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecart"></a>
# **DeleteCart**
> void DeleteCart (int? cartId)

Delete a cart

Deletes the cart identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to be deleted.

            try
            {
                // Delete a cart
                apiInstance.DeleteCart(cartId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.DeleteCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecartfile"></a>
# **DeleteCartFile**
> void DeleteCartFile (int? cartId, int? fileId)

Delete a file for a cart.

Deletes an existing cart file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a cart.
                apiInstance.DeleteCartFile(cartId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.DeleteCartFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecarttag"></a>
# **DeleteCartTag**
> void DeleteCartTag (int? cartId, string cartTag)

Delete a tag for a cart.

Deletes an existing cart tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCartTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to remove tag from
            var cartTag = cartTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a cart.
                apiInstance.DeleteCartTag(cartId, cartTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.DeleteCartTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to remove tag from | 
 **cartTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartbyfilter"></a>
# **GetCartByFilter**
> List<Cart> GetCartByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search carts by filter

Returns the list of carts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search carts by filter
                List&lt;Cart&gt; result = apiInstance.GetCartByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.GetCartByFilter: " + e.Message );
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

[**List<Cart>**](Cart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartbyid"></a>
# **GetCartById**
> Cart GetCartById (int? cartId)

Get a cart by id

Returns the cart identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to be returned.

            try
            {
                // Get a cart by id
                Cart result = apiInstance.GetCartById(cartId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.GetCartById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to be returned. | 

### Return type

[**Cart**](Cart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcartfiles"></a>
# **GetCartFiles**
> void GetCartFiles (int? cartId)

Get the files for a cart.

Get all existing cart files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to get files for

            try
            {
                // Get the files for a cart.
                apiInstance.GetCartFiles(cartId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.GetCartFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcarttags"></a>
# **GetCartTags**
> void GetCartTags (int? cartId)

Get the tags for a cart.

Get all existing cart tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCartTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to get tags for

            try
            {
                // Get the tags for a cart.
                apiInstance.GetCartTags(cartId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.GetCartTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecartbyid"></a>
# **GetDuplicateCartById**
> Cart GetDuplicateCartById (int? cartId)

Get a duplicated a cart by id

Returns a duplicated cart identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCartByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var cartId = 56;  // int? | Id of the cart to be duplicated.

            try
            {
                // Get a duplicated a cart by id
                Cart result = apiInstance.GetDuplicateCartById(cartId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.GetDuplicateCartById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **int?**| Id of the cart to be duplicated. | 

### Return type

[**Cart**](Cart.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecart"></a>
# **UpdateCart**
> void UpdateCart (Cart body)

Update a cart

Updates an existing cart using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCartExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CartApi();
            var body = new Cart(); // Cart | Cart to be updated.

            try
            {
                // Update a cart
                apiInstance.UpdateCart(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.UpdateCart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Cart**](Cart.md)| Cart to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

