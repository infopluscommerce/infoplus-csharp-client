# Infoplus.Api.BusinessTransactionApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBusinessTransactionByFilter**](BusinessTransactionApi.md#getbusinesstransactionbyfilter) | **GET** /beta/businessTransaction/search | Search businessTransactions by filter
[**GetBusinessTransactionById**](BusinessTransactionApi.md#getbusinesstransactionbyid) | **GET** /beta/businessTransaction/{businessTransactionId} | Get a businessTransaction by id
[**UpdateBusinessTransactionCustomFields**](BusinessTransactionApi.md#updatebusinesstransactioncustomfields) | **PUT** /beta/businessTransaction/customFields | Update a businessTransaction custom fields


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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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
            Configuration.Default.ApiKey.Add("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("API-Key", "Bearer");

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

