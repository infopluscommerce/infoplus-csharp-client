# Infoplus.Api.ShipmentApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddShipmentAudit**](ShipmentApi.md#addshipmentaudit) | **PUT** /beta/shipment/{shipmentId}/audit/{shipmentAudit} | Add new audit for a shipment
[**AddShipmentFile**](ShipmentApi.md#addshipmentfile) | **POST** /beta/shipment/{shipmentId}/file/{fileName} | Attach a file to a shipment
[**AddShipmentTag**](ShipmentApi.md#addshipmenttag) | **PUT** /beta/shipment/{shipmentId}/tag/{shipmentTag} | Add new tags for a shipment.
[**DeleteShipmentTag**](ShipmentApi.md#deleteshipmenttag) | **DELETE** /beta/shipment/{shipmentId}/tag/{shipmentTag} | Delete a tag for a shipment.
[**GetDuplicateShipmentById**](ShipmentApi.md#getduplicateshipmentbyid) | **GET** /beta/shipment/duplicate/{shipmentId} | Get a duplicated a shipment by id
[**GetShipmentByFilter**](ShipmentApi.md#getshipmentbyfilter) | **GET** /beta/shipment/search | Search shipments by filter
[**GetShipmentById**](ShipmentApi.md#getshipmentbyid) | **GET** /beta/shipment/{shipmentId} | Get a shipment by id
[**GetShipmentTags**](ShipmentApi.md#getshipmenttags) | **GET** /beta/shipment/{shipmentId}/tag | Get the tags for a shipment.
[**UpdateShipmentCustomFields**](ShipmentApi.md#updateshipmentcustomfields) | **PUT** /beta/shipment/customFields | Update a shipment custom fields


<a name="addshipmentaudit"></a>
# **AddShipmentAudit**
> void AddShipmentAudit (int? shipmentId, string shipmentAudit)

Add new audit for a shipment

Adds an audit to an existing shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShipmentAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var shipmentId = 56;  // int? | Id of the shipment to add an audit to
            var shipmentAudit = shipmentAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a shipment
                apiInstance.AddShipmentAudit(shipmentId, shipmentAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.AddShipmentAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **int?**| Id of the shipment to add an audit to | 
 **shipmentAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addshipmentfile"></a>
# **AddShipmentFile**
> void AddShipmentFile (int? shipmentId, string fileName)

Attach a file to a shipment

Adds a file to an existing shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShipmentFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var shipmentId = 56;  // int? | Id of the shipment to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a shipment
                apiInstance.AddShipmentFile(shipmentId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.AddShipmentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **int?**| Id of the shipment to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addshipmenttag"></a>
# **AddShipmentTag**
> void AddShipmentTag (int? shipmentId, string shipmentTag)

Add new tags for a shipment.

Adds a tag to an existing shipment.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddShipmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var shipmentId = 56;  // int? | Id of the shipment to add a tag to
            var shipmentTag = shipmentTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a shipment.
                apiInstance.AddShipmentTag(shipmentId, shipmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.AddShipmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **int?**| Id of the shipment to add a tag to | 
 **shipmentTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshipmenttag"></a>
# **DeleteShipmentTag**
> void DeleteShipmentTag (int? shipmentId, string shipmentTag)

Delete a tag for a shipment.

Deletes an existing shipment tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteShipmentTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var shipmentId = 56;  // int? | Id of the shipment to remove tag from
            var shipmentTag = shipmentTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a shipment.
                apiInstance.DeleteShipmentTag(shipmentId, shipmentTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.DeleteShipmentTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **int?**| Id of the shipment to remove tag from | 
 **shipmentTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateshipmentbyid"></a>
# **GetDuplicateShipmentById**
> Shipment GetDuplicateShipmentById (int? shipmentId)

Get a duplicated a shipment by id

Returns a duplicated shipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateShipmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var shipmentId = 56;  // int? | Id of the shipment to be duplicated.

            try
            {
                // Get a duplicated a shipment by id
                Shipment result = apiInstance.GetDuplicateShipmentById(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetDuplicateShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **int?**| Id of the shipment to be duplicated. | 

### Return type

[**Shipment**](Shipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentbyfilter"></a>
# **GetShipmentByFilter**
> List<Shipment> GetShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search shipments by filter

Returns the list of shipments that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetShipmentByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search shipments by filter
                List&lt;Shipment&gt; result = apiInstance.GetShipmentByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetShipmentByFilter: " + e.Message );
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

[**List<Shipment>**](Shipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmentbyid"></a>
# **GetShipmentById**
> Shipment GetShipmentById (int? shipmentId)

Get a shipment by id

Returns the shipment identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetShipmentByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var shipmentId = 56;  // int? | Id of the shipment to be returned.

            try
            {
                // Get a shipment by id
                Shipment result = apiInstance.GetShipmentById(shipmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetShipmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **int?**| Id of the shipment to be returned. | 

### Return type

[**Shipment**](Shipment.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshipmenttags"></a>
# **GetShipmentTags**
> void GetShipmentTags (int? shipmentId)

Get the tags for a shipment.

Get all existing shipment tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetShipmentTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var shipmentId = 56;  // int? | Id of the shipment to get tags for

            try
            {
                // Get the tags for a shipment.
                apiInstance.GetShipmentTags(shipmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetShipmentTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **int?**| Id of the shipment to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshipmentcustomfields"></a>
# **UpdateShipmentCustomFields**
> void UpdateShipmentCustomFields (Shipment body)

Update a shipment custom fields

Updates an existing shipment custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateShipmentCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ShipmentApi();
            var body = new Shipment(); // Shipment | Shipment to be updated.

            try
            {
                // Update a shipment custom fields
                apiInstance.UpdateShipmentCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.UpdateShipmentCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Shipment**](Shipment.md)| Shipment to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

