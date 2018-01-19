# Infoplus.Api.AsnApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAsn**](AsnApi.md#addasn) | **POST** /beta/asn | Create an asn
[**AddAsnAudit**](AsnApi.md#addasnaudit) | **PUT** /beta/asn/{asnId}/audit/{asnAudit} | Add new audit for an asn
[**AddAsnTag**](AsnApi.md#addasntag) | **PUT** /beta/asn/{asnId}/tag/{asnTag} | Add new tags for an asn.
[**DeleteAsn**](AsnApi.md#deleteasn) | **DELETE** /beta/asn/{asnId} | Delete an asn
[**DeleteAsnTag**](AsnApi.md#deleteasntag) | **DELETE** /beta/asn/{asnId}/tag/{asnTag} | Delete a tag for an asn.
[**GetAsnByFilter**](AsnApi.md#getasnbyfilter) | **GET** /beta/asn/search | Search asns by filter
[**GetAsnById**](AsnApi.md#getasnbyid) | **GET** /beta/asn/{asnId} | Get an asn by id
[**GetAsnTags**](AsnApi.md#getasntags) | **GET** /beta/asn/{asnId}/tag | Get the tags for an asn.
[**GetDuplicateAsnById**](AsnApi.md#getduplicateasnbyid) | **GET** /beta/asn/duplicate/{asnId} | Get a duplicated an asn by id
[**UpdateAsn**](AsnApi.md#updateasn) | **PUT** /beta/asn | Update an asn
[**UpdateAsnCustomFields**](AsnApi.md#updateasncustomfields) | **PUT** /beta/asn/customFields | Update an asn custom fields


<a name="addasn"></a>
# **AddAsn**
> Asn AddAsn (Asn body)

Create an asn

Inserts a new asn using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddAsnExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var body = new Asn(); // Asn | Asn to be inserted.

            try
            {
                // Create an asn
                Asn result = apiInstance.AddAsn(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.AddAsn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asn**](Asn.md)| Asn to be inserted. | 

### Return type

[**Asn**](Asn.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addasnaudit"></a>
# **AddAsnAudit**
> void AddAsnAudit (int? asnId, string asnAudit)

Add new audit for an asn

Adds an audit to an existing asn.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddAsnAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var asnId = 56;  // int? | Id of the asn to add an audit to
            var asnAudit = asnAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an asn
                apiInstance.AddAsnAudit(asnId, asnAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.AddAsnAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asnId** | **int?**| Id of the asn to add an audit to | 
 **asnAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addasntag"></a>
# **AddAsnTag**
> void AddAsnTag (int? asnId, string asnTag)

Add new tags for an asn.

Adds a tag to an existing asn.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddAsnTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var asnId = 56;  // int? | Id of the asn to add a tag to
            var asnTag = asnTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an asn.
                apiInstance.AddAsnTag(asnId, asnTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.AddAsnTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asnId** | **int?**| Id of the asn to add a tag to | 
 **asnTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteasn"></a>
# **DeleteAsn**
> void DeleteAsn (int? asnId)

Delete an asn

Deletes the asn identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteAsnExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var asnId = 56;  // int? | Id of the asn to be deleted.

            try
            {
                // Delete an asn
                apiInstance.DeleteAsn(asnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.DeleteAsn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asnId** | **int?**| Id of the asn to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteasntag"></a>
# **DeleteAsnTag**
> void DeleteAsnTag (int? asnId, string asnTag)

Delete a tag for an asn.

Deletes an existing asn tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteAsnTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var asnId = 56;  // int? | Id of the asn to remove tag from
            var asnTag = asnTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an asn.
                apiInstance.DeleteAsnTag(asnId, asnTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.DeleteAsnTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asnId** | **int?**| Id of the asn to remove tag from | 
 **asnTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasnbyfilter"></a>
# **GetAsnByFilter**
> List<Asn> GetAsnByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search asns by filter

Returns the list of asns that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAsnByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search asns by filter
                List&lt;Asn&gt; result = apiInstance.GetAsnByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.GetAsnByFilter: " + e.Message );
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

[**List<Asn>**](Asn.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasnbyid"></a>
# **GetAsnById**
> Asn GetAsnById (int? asnId)

Get an asn by id

Returns the asn identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAsnByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var asnId = 56;  // int? | Id of the asn to be returned.

            try
            {
                // Get an asn by id
                Asn result = apiInstance.GetAsnById(asnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.GetAsnById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asnId** | **int?**| Id of the asn to be returned. | 

### Return type

[**Asn**](Asn.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasntags"></a>
# **GetAsnTags**
> void GetAsnTags (int? asnId)

Get the tags for an asn.

Get all existing asn tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetAsnTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var asnId = 56;  // int? | Id of the asn to get tags for

            try
            {
                // Get the tags for an asn.
                apiInstance.GetAsnTags(asnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.GetAsnTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asnId** | **int?**| Id of the asn to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateasnbyid"></a>
# **GetDuplicateAsnById**
> Asn GetDuplicateAsnById (int? asnId)

Get a duplicated an asn by id

Returns a duplicated asn identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateAsnByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var asnId = 56;  // int? | Id of the asn to be duplicated.

            try
            {
                // Get a duplicated an asn by id
                Asn result = apiInstance.GetDuplicateAsnById(asnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.GetDuplicateAsnById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asnId** | **int?**| Id of the asn to be duplicated. | 

### Return type

[**Asn**](Asn.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateasn"></a>
# **UpdateAsn**
> void UpdateAsn (Asn body)

Update an asn

Updates an existing asn using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateAsnExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var body = new Asn(); // Asn | Asn to be updated.

            try
            {
                // Update an asn
                apiInstance.UpdateAsn(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.UpdateAsn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asn**](Asn.md)| Asn to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateasncustomfields"></a>
# **UpdateAsnCustomFields**
> void UpdateAsnCustomFields (Asn body)

Update an asn custom fields

Updates an existing asn custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateAsnCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new AsnApi();
            var body = new Asn(); // Asn | Asn to be updated.

            try
            {
                // Update an asn custom fields
                apiInstance.UpdateAsnCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsnApi.UpdateAsnCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asn**](Asn.md)| Asn to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

