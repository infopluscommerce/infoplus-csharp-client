# Infoplus.Api.ParcelAccountApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddParcelAccount**](ParcelAccountApi.md#addparcelaccount) | **POST** /beta/parcelAccount | Create a parcelAccount
[**AddParcelAccountAudit**](ParcelAccountApi.md#addparcelaccountaudit) | **PUT** /beta/parcelAccount/{parcelAccountId}/audit/{parcelAccountAudit} | Add new audit for a parcelAccount
[**AddParcelAccountFile**](ParcelAccountApi.md#addparcelaccountfile) | **POST** /beta/parcelAccount/{parcelAccountId}/file/{fileName} | Attach a file to a parcelAccount
[**AddParcelAccountFileByURL**](ParcelAccountApi.md#addparcelaccountfilebyurl) | **POST** /beta/parcelAccount/{parcelAccountId}/file | Attach a file to a parcelAccount by URL.
[**AddParcelAccountTag**](ParcelAccountApi.md#addparcelaccounttag) | **PUT** /beta/parcelAccount/{parcelAccountId}/tag/{parcelAccountTag} | Add new tags for a parcelAccount.
[**DeleteParcelAccountFile**](ParcelAccountApi.md#deleteparcelaccountfile) | **DELETE** /beta/parcelAccount/{parcelAccountId}/file/{fileId} | Delete a file for a parcelAccount.
[**DeleteParcelAccountTag**](ParcelAccountApi.md#deleteparcelaccounttag) | **DELETE** /beta/parcelAccount/{parcelAccountId}/tag/{parcelAccountTag} | Delete a tag for a parcelAccount.
[**GetDuplicateParcelAccountById**](ParcelAccountApi.md#getduplicateparcelaccountbyid) | **GET** /beta/parcelAccount/duplicate/{parcelAccountId} | Get a duplicated a parcelAccount by id
[**GetParcelAccountByFilter**](ParcelAccountApi.md#getparcelaccountbyfilter) | **GET** /beta/parcelAccount/search | Search parcelAccounts by filter
[**GetParcelAccountById**](ParcelAccountApi.md#getparcelaccountbyid) | **GET** /beta/parcelAccount/{parcelAccountId} | Get a parcelAccount by id
[**GetParcelAccountFiles**](ParcelAccountApi.md#getparcelaccountfiles) | **GET** /beta/parcelAccount/{parcelAccountId}/file | Get the files for a parcelAccount.
[**GetParcelAccountTags**](ParcelAccountApi.md#getparcelaccounttags) | **GET** /beta/parcelAccount/{parcelAccountId}/tag | Get the tags for a parcelAccount.
[**UpdateParcelAccount**](ParcelAccountApi.md#updateparcelaccount) | **PUT** /beta/parcelAccount | Update a parcelAccount
[**UpdateParcelAccountCustomFields**](ParcelAccountApi.md#updateparcelaccountcustomfields) | **PUT** /beta/parcelAccount/customFields | Update a parcelAccount custom fields


<a name="addparcelaccount"></a>
# **AddParcelAccount**
> ParcelAccount AddParcelAccount (ParcelAccount body)

Create a parcelAccount

Inserts a new parcelAccount using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var body = new ParcelAccount(); // ParcelAccount | ParcelAccount to be inserted.

            try
            {
                // Create a parcelAccount
                ParcelAccount result = apiInstance.AddParcelAccount(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.AddParcelAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ParcelAccount**](ParcelAccount.md)| ParcelAccount to be inserted. | 

### Return type

[**ParcelAccount**](ParcelAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelaccountaudit"></a>
# **AddParcelAccountAudit**
> void AddParcelAccountAudit (int? parcelAccountId, string parcelAccountAudit)

Add new audit for a parcelAccount

Adds an audit to an existing parcelAccount.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelAccountAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to add an audit to
            var parcelAccountAudit = parcelAccountAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a parcelAccount
                apiInstance.AddParcelAccountAudit(parcelAccountId, parcelAccountAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.AddParcelAccountAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to add an audit to | 
 **parcelAccountAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelaccountfile"></a>
# **AddParcelAccountFile**
> void AddParcelAccountFile (int? parcelAccountId, string fileName)

Attach a file to a parcelAccount

Adds a file to an existing parcelAccount.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelAccountFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a parcelAccount
                apiInstance.AddParcelAccountFile(parcelAccountId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.AddParcelAccountFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelaccountfilebyurl"></a>
# **AddParcelAccountFileByURL**
> void AddParcelAccountFileByURL (RecordFile body, int? parcelAccountId)

Attach a file to a parcelAccount by URL.

Adds a file to an existing parcelAccount by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelAccountFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to add an file to

            try
            {
                // Attach a file to a parcelAccount by URL.
                apiInstance.AddParcelAccountFileByURL(body, parcelAccountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.AddParcelAccountFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **parcelAccountId** | **int?**| Id of the parcelAccount to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addparcelaccounttag"></a>
# **AddParcelAccountTag**
> void AddParcelAccountTag (int? parcelAccountId, string parcelAccountTag)

Add new tags for a parcelAccount.

Adds a tag to an existing parcelAccount.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddParcelAccountTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to add a tag to
            var parcelAccountTag = parcelAccountTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a parcelAccount.
                apiInstance.AddParcelAccountTag(parcelAccountId, parcelAccountTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.AddParcelAccountTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to add a tag to | 
 **parcelAccountTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparcelaccountfile"></a>
# **DeleteParcelAccountFile**
> void DeleteParcelAccountFile (int? parcelAccountId, int? fileId)

Delete a file for a parcelAccount.

Deletes an existing parcelAccount file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteParcelAccountFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a parcelAccount.
                apiInstance.DeleteParcelAccountFile(parcelAccountId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.DeleteParcelAccountFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparcelaccounttag"></a>
# **DeleteParcelAccountTag**
> void DeleteParcelAccountTag (int? parcelAccountId, string parcelAccountTag)

Delete a tag for a parcelAccount.

Deletes an existing parcelAccount tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteParcelAccountTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to remove tag from
            var parcelAccountTag = parcelAccountTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a parcelAccount.
                apiInstance.DeleteParcelAccountTag(parcelAccountId, parcelAccountTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.DeleteParcelAccountTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to remove tag from | 
 **parcelAccountTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateparcelaccountbyid"></a>
# **GetDuplicateParcelAccountById**
> ParcelAccount GetDuplicateParcelAccountById (int? parcelAccountId)

Get a duplicated a parcelAccount by id

Returns a duplicated parcelAccount identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateParcelAccountByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to be duplicated.

            try
            {
                // Get a duplicated a parcelAccount by id
                ParcelAccount result = apiInstance.GetDuplicateParcelAccountById(parcelAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.GetDuplicateParcelAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to be duplicated. | 

### Return type

[**ParcelAccount**](ParcelAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelaccountbyfilter"></a>
# **GetParcelAccountByFilter**
> List<ParcelAccount> GetParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search parcelAccounts by filter

Returns the list of parcelAccounts that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelAccountByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search parcelAccounts by filter
                List&lt;ParcelAccount&gt; result = apiInstance.GetParcelAccountByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.GetParcelAccountByFilter: " + e.Message );
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

[**List<ParcelAccount>**](ParcelAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelaccountbyid"></a>
# **GetParcelAccountById**
> ParcelAccount GetParcelAccountById (int? parcelAccountId)

Get a parcelAccount by id

Returns the parcelAccount identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelAccountByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to be returned.

            try
            {
                // Get a parcelAccount by id
                ParcelAccount result = apiInstance.GetParcelAccountById(parcelAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.GetParcelAccountById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to be returned. | 

### Return type

[**ParcelAccount**](ParcelAccount.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelaccountfiles"></a>
# **GetParcelAccountFiles**
> void GetParcelAccountFiles (int? parcelAccountId)

Get the files for a parcelAccount.

Get all existing parcelAccount files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelAccountFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to get files for

            try
            {
                // Get the files for a parcelAccount.
                apiInstance.GetParcelAccountFiles(parcelAccountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.GetParcelAccountFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparcelaccounttags"></a>
# **GetParcelAccountTags**
> void GetParcelAccountTags (int? parcelAccountId)

Get the tags for a parcelAccount.

Get all existing parcelAccount tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetParcelAccountTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var parcelAccountId = 56;  // int? | Id of the parcelAccount to get tags for

            try
            {
                // Get the tags for a parcelAccount.
                apiInstance.GetParcelAccountTags(parcelAccountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.GetParcelAccountTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parcelAccountId** | **int?**| Id of the parcelAccount to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateparcelaccount"></a>
# **UpdateParcelAccount**
> void UpdateParcelAccount (ParcelAccount body)

Update a parcelAccount

Updates an existing parcelAccount using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateParcelAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var body = new ParcelAccount(); // ParcelAccount | ParcelAccount to be updated.

            try
            {
                // Update a parcelAccount
                apiInstance.UpdateParcelAccount(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.UpdateParcelAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ParcelAccount**](ParcelAccount.md)| ParcelAccount to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateparcelaccountcustomfields"></a>
# **UpdateParcelAccountCustomFields**
> void UpdateParcelAccountCustomFields (ParcelAccount body)

Update a parcelAccount custom fields

Updates an existing parcelAccount custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateParcelAccountCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ParcelAccountApi();
            var body = new ParcelAccount(); // ParcelAccount | ParcelAccount to be updated.

            try
            {
                // Update a parcelAccount custom fields
                apiInstance.UpdateParcelAccountCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParcelAccountApi.UpdateParcelAccountCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ParcelAccount**](ParcelAccount.md)| ParcelAccount to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

