# Infoplus.Api.CustomerApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomer**](CustomerApi.md#addcustomer) | **POST** /beta/customer | Create a customer
[**AddCustomerAudit**](CustomerApi.md#addcustomeraudit) | **PUT** /beta/customer/{customerId}/audit/{customerAudit} | Add new audit for a customer
[**AddCustomerTag**](CustomerApi.md#addcustomertag) | **PUT** /beta/customer/{customerId}/tag/{customerTag} | Add new tags for a customer.
[**DeleteCustomer**](CustomerApi.md#deletecustomer) | **DELETE** /beta/customer/{customerId} | Delete a customer
[**DeleteCustomerTag**](CustomerApi.md#deletecustomertag) | **DELETE** /beta/customer/{customerId}/tag/{customerTag} | Delete a tag for a customer.
[**GetByCustomerNo**](CustomerApi.md#getbycustomerno) | **GET** /beta/customer/getByCustomerNo | Get a customer by Customer No
[**GetCustomerByFilter**](CustomerApi.md#getcustomerbyfilter) | **GET** /beta/customer/search | Search customers by filter
[**GetCustomerById**](CustomerApi.md#getcustomerbyid) | **GET** /beta/customer/{customerId} | Get a customer by id
[**GetCustomerTags**](CustomerApi.md#getcustomertags) | **GET** /beta/customer/{customerId}/tag | Get the tags for a customer.
[**GetDuplicateCustomerById**](CustomerApi.md#getduplicatecustomerbyid) | **GET** /beta/customer/duplicate/{customerId} | Get a duplicated a customer by id
[**UpdateCustomer**](CustomerApi.md#updatecustomer) | **PUT** /beta/customer | Update a customer
[**UpdateCustomerCustomFields**](CustomerApi.md#updatecustomercustomfields) | **PUT** /beta/customer/customFields | Update a customer custom fields


<a name="addcustomer"></a>
# **AddCustomer**
> Customer AddCustomer (Customer body)

Create a customer

Inserts a new customer using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var body = new Customer(); // Customer | Customer to be inserted.

            try
            {
                // Create a customer
                Customer result = apiInstance.AddCustomer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.AddCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Customer**](Customer.md)| Customer to be inserted. | 

### Return type

[**Customer**](Customer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomeraudit"></a>
# **AddCustomerAudit**
> void AddCustomerAudit (int? customerId, string customerAudit)

Add new audit for a customer

Adds an audit to an existing customer.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var customerId = 56;  // int? | Id of the customer to add an audit to
            var customerAudit = customerAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a customer
                apiInstance.AddCustomerAudit(customerId, customerAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.AddCustomerAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **int?**| Id of the customer to add an audit to | 
 **customerAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomertag"></a>
# **AddCustomerTag**
> void AddCustomerTag (int? customerId, string customerTag)

Add new tags for a customer.

Adds a tag to an existing customer.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomerTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var customerId = 56;  // int? | Id of the customer to add a tag to
            var customerTag = customerTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a customer.
                apiInstance.AddCustomerTag(customerId, customerTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.AddCustomerTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **int?**| Id of the customer to add a tag to | 
 **customerTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomer"></a>
# **DeleteCustomer**
> void DeleteCustomer (int? customerId)

Delete a customer

Deletes the customer identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var customerId = 56;  // int? | Id of the customer to be deleted.

            try
            {
                // Delete a customer
                apiInstance.DeleteCustomer(customerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.DeleteCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **int?**| Id of the customer to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomertag"></a>
# **DeleteCustomerTag**
> void DeleteCustomerTag (int? customerId, string customerTag)

Delete a tag for a customer.

Deletes an existing customer tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomerTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var customerId = 56;  // int? | Id of the customer to remove tag from
            var customerTag = customerTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a customer.
                apiInstance.DeleteCustomerTag(customerId, customerTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.DeleteCustomerTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **int?**| Id of the customer to remove tag from | 
 **customerTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbycustomerno"></a>
# **GetByCustomerNo**
> Customer GetByCustomerNo (int? lobId, string customerNo)

Get a customer by Customer No

Returns the customer identified by the specified parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetByCustomerNoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var lobId = 56;  // int? | lobId of the customer to be returned.
            var customerNo = customerNo_example;  // string | customerNo of the customer to be returned.

            try
            {
                // Get a customer by Customer No
                Customer result = apiInstance.GetByCustomerNo(lobId, customerNo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetByCustomerNo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lobId** | **int?**| lobId of the customer to be returned. | 
 **customerNo** | **string**| customerNo of the customer to be returned. | 

### Return type

[**Customer**](Customer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerbyfilter"></a>
# **GetCustomerByFilter**
> List<Customer> GetCustomerByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search customers by filter

Returns the list of customers that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search customers by filter
                List&lt;Customer&gt; result = apiInstance.GetCustomerByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerByFilter: " + e.Message );
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

[**List<Customer>**](Customer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomerbyid"></a>
# **GetCustomerById**
> Customer GetCustomerById (int? customerId)

Get a customer by id

Returns the customer identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var customerId = 56;  // int? | Id of the customer to be returned.

            try
            {
                // Get a customer by id
                Customer result = apiInstance.GetCustomerById(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **int?**| Id of the customer to be returned. | 

### Return type

[**Customer**](Customer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomertags"></a>
# **GetCustomerTags**
> void GetCustomerTags (int? customerId)

Get the tags for a customer.

Get all existing customer tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomerTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var customerId = 56;  // int? | Id of the customer to get tags for

            try
            {
                // Get the tags for a customer.
                apiInstance.GetCustomerTags(customerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetCustomerTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **int?**| Id of the customer to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecustomerbyid"></a>
# **GetDuplicateCustomerById**
> Customer GetDuplicateCustomerById (int? customerId)

Get a duplicated a customer by id

Returns a duplicated customer identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCustomerByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var customerId = 56;  // int? | Id of the customer to be duplicated.

            try
            {
                // Get a duplicated a customer by id
                Customer result = apiInstance.GetDuplicateCustomerById(customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.GetDuplicateCustomerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerId** | **int?**| Id of the customer to be duplicated. | 

### Return type

[**Customer**](Customer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomer"></a>
# **UpdateCustomer**
> void UpdateCustomer (Customer body)

Update a customer

Updates an existing customer using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCustomerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var body = new Customer(); // Customer | Customer to be updated.

            try
            {
                // Update a customer
                apiInstance.UpdateCustomer(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.UpdateCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Customer**](Customer.md)| Customer to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomercustomfields"></a>
# **UpdateCustomerCustomFields**
> void UpdateCustomerCustomFields (Customer body)

Update a customer custom fields

Updates an existing customer custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCustomerCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomerApi();
            var body = new Customer(); // Customer | Customer to be updated.

            try
            {
                // Update a customer custom fields
                apiInstance.UpdateCustomerCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.UpdateCustomerCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Customer**](Customer.md)| Customer to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

