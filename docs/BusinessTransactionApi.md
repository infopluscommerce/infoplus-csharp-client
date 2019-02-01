# Infoplus.Api.BusinessTransactionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBusinessTransaction**](BusinessTransactionApi.md#addbusinesstransaction) | **POST** /beta/businessTransaction | Create a businessTransaction
[**AddBusinessTransactionAudit**](BusinessTransactionApi.md#addbusinesstransactionaudit) | **PUT** /beta/businessTransaction/{businessTransactionId}/audit/{businessTransactionAudit} | Add new audit for a businessTransaction
[**AddBusinessTransactionTag**](BusinessTransactionApi.md#addbusinesstransactiontag) | **PUT** /beta/businessTransaction/{businessTransactionId}/tag/{businessTransactionTag} | Add new tags for a businessTransaction.
[**DeleteBusinessTransactionTag**](BusinessTransactionApi.md#deletebusinesstransactiontag) | **DELETE** /beta/businessTransaction/{businessTransactionId}/tag/{businessTransactionTag} | Delete a tag for a businessTransaction.
[**GetBusinessTransactionByFilter**](BusinessTransactionApi.md#getbusinesstransactionbyfilter) | **GET** /beta/businessTransaction/search | Search businessTransactions by filter
[**GetBusinessTransactionById**](BusinessTransactionApi.md#getbusinesstransactionbyid) | **GET** /beta/businessTransaction/{businessTransactionId} | Get a businessTransaction by id
[**GetBusinessTransactionTags**](BusinessTransactionApi.md#getbusinesstransactiontags) | **GET** /beta/businessTransaction/{businessTransactionId}/tag | Get the tags for a businessTransaction.
[**GetDuplicateBusinessTransactionById**](BusinessTransactionApi.md#getduplicatebusinesstransactionbyid) | **GET** /beta/businessTransaction/duplicate/{businessTransactionId} | Get a duplicated a businessTransaction by id
[**UpdateBusinessTransaction**](BusinessTransactionApi.md#updatebusinesstransaction) | **PUT** /beta/businessTransaction | Update a businessTransaction
[**UpdateBusinessTransactionCustomFields**](BusinessTransactionApi.md#updatebusinesstransactioncustomfields) | **PUT** /beta/businessTransaction/customFields | Update a businessTransaction custom fields


<a name="addbusinesstransaction"></a>
# **AddBusinessTransaction**
> BusinessTransaction AddBusinessTransaction (BusinessTransaction body)

Create a businessTransaction

Inserts a new businessTransaction using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBusinessTransactionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var body = new BusinessTransaction(); // BusinessTransaction | BusinessTransaction to be inserted.

            try
            {
                // Create a businessTransaction
                BusinessTransaction result = apiInstance.AddBusinessTransaction(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.AddBusinessTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusinessTransaction**](BusinessTransaction.md)| BusinessTransaction to be inserted. | 

### Return type

[**BusinessTransaction**](BusinessTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbusinesstransactionaudit"></a>
# **AddBusinessTransactionAudit**
> void AddBusinessTransactionAudit (int? businessTransactionId, string businessTransactionAudit)

Add new audit for a businessTransaction

Adds an audit to an existing businessTransaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBusinessTransactionAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var businessTransactionId = 56;  // int? | Id of the businessTransaction to add an audit to
            var businessTransactionAudit = businessTransactionAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a businessTransaction
                apiInstance.AddBusinessTransactionAudit(businessTransactionId, businessTransactionAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.AddBusinessTransactionAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessTransactionId** | **int?**| Id of the businessTransaction to add an audit to | 
 **businessTransactionAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbusinesstransactiontag"></a>
# **AddBusinessTransactionTag**
> void AddBusinessTransactionTag (int? businessTransactionId, string businessTransactionTag)

Add new tags for a businessTransaction.

Adds a tag to an existing businessTransaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddBusinessTransactionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var businessTransactionId = 56;  // int? | Id of the businessTransaction to add a tag to
            var businessTransactionTag = businessTransactionTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a businessTransaction.
                apiInstance.AddBusinessTransactionTag(businessTransactionId, businessTransactionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.AddBusinessTransactionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessTransactionId** | **int?**| Id of the businessTransaction to add a tag to | 
 **businessTransactionTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebusinesstransactiontag"></a>
# **DeleteBusinessTransactionTag**
> void DeleteBusinessTransactionTag (int? businessTransactionId, string businessTransactionTag)

Delete a tag for a businessTransaction.

Deletes an existing businessTransaction tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteBusinessTransactionTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var businessTransactionId = 56;  // int? | Id of the businessTransaction to remove tag from
            var businessTransactionTag = businessTransactionTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a businessTransaction.
                apiInstance.DeleteBusinessTransactionTag(businessTransactionId, businessTransactionTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.DeleteBusinessTransactionTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessTransactionId** | **int?**| Id of the businessTransaction to remove tag from | 
 **businessTransactionTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbusinesstransactionbyfilter"></a>
# **GetBusinessTransactionByFilter**
> List<BusinessTransaction> GetBusinessTransactionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search businessTransactions by filter

Returns the list of businessTransactions that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBusinessTransactionByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search businessTransactions by filter
                List&lt;BusinessTransaction&gt; result = apiInstance.GetBusinessTransactionByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.GetBusinessTransactionByFilter: " + e.Message );
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

[**List<BusinessTransaction>**](BusinessTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbusinesstransactionbyid"></a>
# **GetBusinessTransactionById**
> BusinessTransaction GetBusinessTransactionById (int? businessTransactionId)

Get a businessTransaction by id

Returns the businessTransaction identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBusinessTransactionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var businessTransactionId = 56;  // int? | Id of the businessTransaction to be returned.

            try
            {
                // Get a businessTransaction by id
                BusinessTransaction result = apiInstance.GetBusinessTransactionById(businessTransactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.GetBusinessTransactionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessTransactionId** | **int?**| Id of the businessTransaction to be returned. | 

### Return type

[**BusinessTransaction**](BusinessTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbusinesstransactiontags"></a>
# **GetBusinessTransactionTags**
> void GetBusinessTransactionTags (int? businessTransactionId)

Get the tags for a businessTransaction.

Get all existing businessTransaction tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetBusinessTransactionTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var businessTransactionId = 56;  // int? | Id of the businessTransaction to get tags for

            try
            {
                // Get the tags for a businessTransaction.
                apiInstance.GetBusinessTransactionTags(businessTransactionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.GetBusinessTransactionTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessTransactionId** | **int?**| Id of the businessTransaction to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatebusinesstransactionbyid"></a>
# **GetDuplicateBusinessTransactionById**
> BusinessTransaction GetDuplicateBusinessTransactionById (int? businessTransactionId)

Get a duplicated a businessTransaction by id

Returns a duplicated businessTransaction identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateBusinessTransactionByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var businessTransactionId = 56;  // int? | Id of the businessTransaction to be duplicated.

            try
            {
                // Get a duplicated a businessTransaction by id
                BusinessTransaction result = apiInstance.GetDuplicateBusinessTransactionById(businessTransactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.GetDuplicateBusinessTransactionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **businessTransactionId** | **int?**| Id of the businessTransaction to be duplicated. | 

### Return type

[**BusinessTransaction**](BusinessTransaction.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebusinesstransaction"></a>
# **UpdateBusinessTransaction**
> void UpdateBusinessTransaction (BusinessTransaction body)

Update a businessTransaction

Updates an existing businessTransaction using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBusinessTransactionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var body = new BusinessTransaction(); // BusinessTransaction | BusinessTransaction to be updated.

            try
            {
                // Update a businessTransaction
                apiInstance.UpdateBusinessTransaction(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.UpdateBusinessTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusinessTransaction**](BusinessTransaction.md)| BusinessTransaction to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebusinesstransactioncustomfields"></a>
# **UpdateBusinessTransactionCustomFields**
> void UpdateBusinessTransactionCustomFields (BusinessTransaction body)

Update a businessTransaction custom fields

Updates an existing businessTransaction custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateBusinessTransactionCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new BusinessTransactionApi();
            var body = new BusinessTransaction(); // BusinessTransaction | BusinessTransaction to be updated.

            try
            {
                // Update a businessTransaction custom fields
                apiInstance.UpdateBusinessTransactionCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessTransactionApi.UpdateBusinessTransactionCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusinessTransaction**](BusinessTransaction.md)| BusinessTransaction to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

