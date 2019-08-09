# Infoplus.Api.LegacyLowstockContactApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLegacyLowstockContact**](LegacyLowstockContactApi.md#addlegacylowstockcontact) | **POST** /beta/legacyLowstockContact | Create a legacyLowstockContact
[**AddLegacyLowstockContactAudit**](LegacyLowstockContactApi.md#addlegacylowstockcontactaudit) | **PUT** /beta/legacyLowstockContact/{legacyLowstockContactId}/audit/{legacyLowstockContactAudit} | Add new audit for a legacyLowstockContact
[**AddLegacyLowstockContactFile**](LegacyLowstockContactApi.md#addlegacylowstockcontactfile) | **POST** /beta/legacyLowstockContact/{legacyLowstockContactId}/file/{fileName} | Attach a file to a legacyLowstockContact
[**AddLegacyLowstockContactTag**](LegacyLowstockContactApi.md#addlegacylowstockcontacttag) | **PUT** /beta/legacyLowstockContact/{legacyLowstockContactId}/tag/{legacyLowstockContactTag} | Add new tags for a legacyLowstockContact.
[**DeleteLegacyLowstockContact**](LegacyLowstockContactApi.md#deletelegacylowstockcontact) | **DELETE** /beta/legacyLowstockContact/{legacyLowstockContactId} | Delete a legacyLowstockContact
[**DeleteLegacyLowstockContactTag**](LegacyLowstockContactApi.md#deletelegacylowstockcontacttag) | **DELETE** /beta/legacyLowstockContact/{legacyLowstockContactId}/tag/{legacyLowstockContactTag} | Delete a tag for a legacyLowstockContact.
[**GetDuplicateLegacyLowstockContactById**](LegacyLowstockContactApi.md#getduplicatelegacylowstockcontactbyid) | **GET** /beta/legacyLowstockContact/duplicate/{legacyLowstockContactId} | Get a duplicated a legacyLowstockContact by id
[**GetLegacyLowstockContactByFilter**](LegacyLowstockContactApi.md#getlegacylowstockcontactbyfilter) | **GET** /beta/legacyLowstockContact/search | Search legacyLowstockContacts by filter
[**GetLegacyLowstockContactById**](LegacyLowstockContactApi.md#getlegacylowstockcontactbyid) | **GET** /beta/legacyLowstockContact/{legacyLowstockContactId} | Get a legacyLowstockContact by id
[**GetLegacyLowstockContactTags**](LegacyLowstockContactApi.md#getlegacylowstockcontacttags) | **GET** /beta/legacyLowstockContact/{legacyLowstockContactId}/tag | Get the tags for a legacyLowstockContact.
[**UpdateLegacyLowstockContact**](LegacyLowstockContactApi.md#updatelegacylowstockcontact) | **PUT** /beta/legacyLowstockContact | Update a legacyLowstockContact


<a name="addlegacylowstockcontact"></a>
# **AddLegacyLowstockContact**
> LegacyLowstockContact AddLegacyLowstockContact (LegacyLowstockContact body)

Create a legacyLowstockContact

Inserts a new legacyLowstockContact using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLegacyLowstockContactExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var body = new LegacyLowstockContact(); // LegacyLowstockContact | LegacyLowstockContact to be inserted.

            try
            {
                // Create a legacyLowstockContact
                LegacyLowstockContact result = apiInstance.AddLegacyLowstockContact(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.AddLegacyLowstockContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LegacyLowstockContact**](LegacyLowstockContact.md)| LegacyLowstockContact to be inserted. | 

### Return type

[**LegacyLowstockContact**](LegacyLowstockContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlegacylowstockcontactaudit"></a>
# **AddLegacyLowstockContactAudit**
> void AddLegacyLowstockContactAudit (int? legacyLowstockContactId, string legacyLowstockContactAudit)

Add new audit for a legacyLowstockContact

Adds an audit to an existing legacyLowstockContact.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLegacyLowstockContactAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to add an audit to
            var legacyLowstockContactAudit = legacyLowstockContactAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a legacyLowstockContact
                apiInstance.AddLegacyLowstockContactAudit(legacyLowstockContactId, legacyLowstockContactAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.AddLegacyLowstockContactAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to add an audit to | 
 **legacyLowstockContactAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlegacylowstockcontactfile"></a>
# **AddLegacyLowstockContactFile**
> void AddLegacyLowstockContactFile (int? legacyLowstockContactId, string fileName)

Attach a file to a legacyLowstockContact

Adds a file to an existing legacyLowstockContact.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLegacyLowstockContactFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a legacyLowstockContact
                apiInstance.AddLegacyLowstockContactFile(legacyLowstockContactId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.AddLegacyLowstockContactFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlegacylowstockcontacttag"></a>
# **AddLegacyLowstockContactTag**
> void AddLegacyLowstockContactTag (int? legacyLowstockContactId, string legacyLowstockContactTag)

Add new tags for a legacyLowstockContact.

Adds a tag to an existing legacyLowstockContact.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddLegacyLowstockContactTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to add a tag to
            var legacyLowstockContactTag = legacyLowstockContactTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a legacyLowstockContact.
                apiInstance.AddLegacyLowstockContactTag(legacyLowstockContactId, legacyLowstockContactTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.AddLegacyLowstockContactTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to add a tag to | 
 **legacyLowstockContactTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelegacylowstockcontact"></a>
# **DeleteLegacyLowstockContact**
> void DeleteLegacyLowstockContact (int? legacyLowstockContactId)

Delete a legacyLowstockContact

Deletes the legacyLowstockContact identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLegacyLowstockContactExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to be deleted.

            try
            {
                // Delete a legacyLowstockContact
                apiInstance.DeleteLegacyLowstockContact(legacyLowstockContactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.DeleteLegacyLowstockContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelegacylowstockcontacttag"></a>
# **DeleteLegacyLowstockContactTag**
> void DeleteLegacyLowstockContactTag (int? legacyLowstockContactId, string legacyLowstockContactTag)

Delete a tag for a legacyLowstockContact.

Deletes an existing legacyLowstockContact tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteLegacyLowstockContactTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to remove tag from
            var legacyLowstockContactTag = legacyLowstockContactTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a legacyLowstockContact.
                apiInstance.DeleteLegacyLowstockContactTag(legacyLowstockContactId, legacyLowstockContactTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.DeleteLegacyLowstockContactTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to remove tag from | 
 **legacyLowstockContactTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatelegacylowstockcontactbyid"></a>
# **GetDuplicateLegacyLowstockContactById**
> LegacyLowstockContact GetDuplicateLegacyLowstockContactById (int? legacyLowstockContactId)

Get a duplicated a legacyLowstockContact by id

Returns a duplicated legacyLowstockContact identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateLegacyLowstockContactByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to be duplicated.

            try
            {
                // Get a duplicated a legacyLowstockContact by id
                LegacyLowstockContact result = apiInstance.GetDuplicateLegacyLowstockContactById(legacyLowstockContactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.GetDuplicateLegacyLowstockContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to be duplicated. | 

### Return type

[**LegacyLowstockContact**](LegacyLowstockContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegacylowstockcontactbyfilter"></a>
# **GetLegacyLowstockContactByFilter**
> List<LegacyLowstockContact> GetLegacyLowstockContactByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search legacyLowstockContacts by filter

Returns the list of legacyLowstockContacts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLegacyLowstockContactByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search legacyLowstockContacts by filter
                List&lt;LegacyLowstockContact&gt; result = apiInstance.GetLegacyLowstockContactByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.GetLegacyLowstockContactByFilter: " + e.Message );
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

[**List<LegacyLowstockContact>**](LegacyLowstockContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegacylowstockcontactbyid"></a>
# **GetLegacyLowstockContactById**
> LegacyLowstockContact GetLegacyLowstockContactById (int? legacyLowstockContactId)

Get a legacyLowstockContact by id

Returns the legacyLowstockContact identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLegacyLowstockContactByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to be returned.

            try
            {
                // Get a legacyLowstockContact by id
                LegacyLowstockContact result = apiInstance.GetLegacyLowstockContactById(legacyLowstockContactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.GetLegacyLowstockContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to be returned. | 

### Return type

[**LegacyLowstockContact**](LegacyLowstockContact.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegacylowstockcontacttags"></a>
# **GetLegacyLowstockContactTags**
> void GetLegacyLowstockContactTags (int? legacyLowstockContactId)

Get the tags for a legacyLowstockContact.

Get all existing legacyLowstockContact tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetLegacyLowstockContactTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var legacyLowstockContactId = 56;  // int? | Id of the legacyLowstockContact to get tags for

            try
            {
                // Get the tags for a legacyLowstockContact.
                apiInstance.GetLegacyLowstockContactTags(legacyLowstockContactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.GetLegacyLowstockContactTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legacyLowstockContactId** | **int?**| Id of the legacyLowstockContact to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelegacylowstockcontact"></a>
# **UpdateLegacyLowstockContact**
> void UpdateLegacyLowstockContact (LegacyLowstockContact body)

Update a legacyLowstockContact

Updates an existing legacyLowstockContact using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateLegacyLowstockContactExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new LegacyLowstockContactApi();
            var body = new LegacyLowstockContact(); // LegacyLowstockContact | LegacyLowstockContact to be updated.

            try
            {
                // Update a legacyLowstockContact
                apiInstance.UpdateLegacyLowstockContact(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegacyLowstockContactApi.UpdateLegacyLowstockContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LegacyLowstockContact**](LegacyLowstockContact.md)| LegacyLowstockContact to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

