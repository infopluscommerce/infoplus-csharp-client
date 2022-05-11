# Infoplus.Api.CustomFieldApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomField**](CustomFieldApi.md#addcustomfield) | **POST** /v3.0/customField | Create a customField
[**AddCustomFieldAudit**](CustomFieldApi.md#addcustomfieldaudit) | **PUT** /v3.0/customField/{customFieldId}/audit/{customFieldAudit} | Add new audit for a customField
[**AddCustomFieldFile**](CustomFieldApi.md#addcustomfieldfile) | **POST** /v3.0/customField/{customFieldId}/file/{fileName} | Attach a file to a customField
[**AddCustomFieldFileByURL**](CustomFieldApi.md#addcustomfieldfilebyurl) | **POST** /v3.0/customField/{customFieldId}/file | Attach a file to a customField by URL.
[**AddCustomFieldTag**](CustomFieldApi.md#addcustomfieldtag) | **PUT** /v3.0/customField/{customFieldId}/tag/{customFieldTag} | Add new tags for a customField.
[**DeleteCustomFieldFile**](CustomFieldApi.md#deletecustomfieldfile) | **DELETE** /v3.0/customField/{customFieldId}/file/{fileId} | Delete a file for a customField.
[**DeleteCustomFieldTag**](CustomFieldApi.md#deletecustomfieldtag) | **DELETE** /v3.0/customField/{customFieldId}/tag/{customFieldTag} | Delete a tag for a customField.
[**GetCustomFieldByFilter**](CustomFieldApi.md#getcustomfieldbyfilter) | **GET** /v3.0/customField/search | Search customFields by filter
[**GetCustomFieldById**](CustomFieldApi.md#getcustomfieldbyid) | **GET** /v3.0/customField/{customFieldId} | Get a customField by id
[**GetCustomFieldFiles**](CustomFieldApi.md#getcustomfieldfiles) | **GET** /v3.0/customField/{customFieldId}/file | Get the files for a customField.
[**GetCustomFieldTags**](CustomFieldApi.md#getcustomfieldtags) | **GET** /v3.0/customField/{customFieldId}/tag | Get the tags for a customField.
[**GetDuplicateCustomFieldById**](CustomFieldApi.md#getduplicatecustomfieldbyid) | **GET** /v3.0/customField/duplicate/{customFieldId} | Get a duplicated a customField by id
[**UpdateCustomField**](CustomFieldApi.md#updatecustomfield) | **PUT** /v3.0/customField | Update a customField


<a name="addcustomfield"></a>
# **AddCustomField**
> CustomField AddCustomField (CustomField body)

Create a customField

Inserts a new customField using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var body = new CustomField(); // CustomField | CustomField to be inserted.

            try
            {
                // Create a customField
                CustomField result = apiInstance.AddCustomField(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.AddCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomField**](CustomField.md)| CustomField to be inserted. | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomfieldaudit"></a>
# **AddCustomFieldAudit**
> void AddCustomFieldAudit (int? customFieldId, string customFieldAudit)

Add new audit for a customField

Adds an audit to an existing customField.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomFieldAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to add an audit to
            var customFieldAudit = customFieldAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for a customField
                apiInstance.AddCustomFieldAudit(customFieldId, customFieldAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.AddCustomFieldAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to add an audit to | 
 **customFieldAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomfieldfile"></a>
# **AddCustomFieldFile**
> void AddCustomFieldFile (int? customFieldId, string fileName)

Attach a file to a customField

Adds a file to an existing customField.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomFieldFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to add a file to
            var fileName = fileName_example;  // string | Name of file

            try
            {
                // Attach a file to a customField
                apiInstance.AddCustomFieldFile(customFieldId, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.AddCustomFieldFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to add a file to | 
 **fileName** | **string**| Name of file | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomfieldfilebyurl"></a>
# **AddCustomFieldFileByURL**
> void AddCustomFieldFileByURL (RecordFile body, int? customFieldId)

Attach a file to a customField by URL.

Adds a file to an existing customField by URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomFieldFileByURLExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var body = new RecordFile(); // RecordFile | The url and optionly fileName to be used.
            var customFieldId = 56;  // int? | Id of the customField to add an file to

            try
            {
                // Attach a file to a customField by URL.
                apiInstance.AddCustomFieldFileByURL(body, customFieldId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.AddCustomFieldFileByURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecordFile**](RecordFile.md)| The url and optionly fileName to be used. | 
 **customFieldId** | **int?**| Id of the customField to add an file to | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addcustomfieldtag"></a>
# **AddCustomFieldTag**
> void AddCustomFieldTag (int? customFieldId, string customFieldTag)

Add new tags for a customField.

Adds a tag to an existing customField.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddCustomFieldTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to add a tag to
            var customFieldTag = customFieldTag_example;  // string | The tag to add

            try
            {
                // Add new tags for a customField.
                apiInstance.AddCustomFieldTag(customFieldId, customFieldTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.AddCustomFieldTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to add a tag to | 
 **customFieldTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomfieldfile"></a>
# **DeleteCustomFieldFile**
> void DeleteCustomFieldFile (int? customFieldId, int? fileId)

Delete a file for a customField.

Deletes an existing customField file using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomFieldFileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to remove file from
            var fileId = 56;  // int? | Id of the file to delete

            try
            {
                // Delete a file for a customField.
                apiInstance.DeleteCustomFieldFile(customFieldId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.DeleteCustomFieldFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to remove file from | 
 **fileId** | **int?**| Id of the file to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomfieldtag"></a>
# **DeleteCustomFieldTag**
> void DeleteCustomFieldTag (int? customFieldId, string customFieldTag)

Delete a tag for a customField.

Deletes an existing customField tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteCustomFieldTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to remove tag from
            var customFieldTag = customFieldTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for a customField.
                apiInstance.DeleteCustomFieldTag(customFieldId, customFieldTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.DeleteCustomFieldTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to remove tag from | 
 **customFieldTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomfieldbyfilter"></a>
# **GetCustomFieldByFilter**
> List<CustomField> GetCustomFieldByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search customFields by filter

Returns the list of customFields that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomFieldByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search customFields by filter
                List&lt;CustomField&gt; result = apiInstance.GetCustomFieldByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.GetCustomFieldByFilter: " + e.Message );
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

[**List<CustomField>**](CustomField.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomfieldbyid"></a>
# **GetCustomFieldById**
> CustomField GetCustomFieldById (int? customFieldId)

Get a customField by id

Returns the customField identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomFieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to be returned.

            try
            {
                // Get a customField by id
                CustomField result = apiInstance.GetCustomFieldById(customFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.GetCustomFieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to be returned. | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomfieldfiles"></a>
# **GetCustomFieldFiles**
> void GetCustomFieldFiles (int? customFieldId)

Get the files for a customField.

Get all existing customField files.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomFieldFilesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to get files for

            try
            {
                // Get the files for a customField.
                apiInstance.GetCustomFieldFiles(customFieldId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.GetCustomFieldFiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to get files for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomfieldtags"></a>
# **GetCustomFieldTags**
> void GetCustomFieldTags (int? customFieldId)

Get the tags for a customField.

Get all existing customField tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetCustomFieldTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to get tags for

            try
            {
                // Get the tags for a customField.
                apiInstance.GetCustomFieldTags(customFieldId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.GetCustomFieldTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicatecustomfieldbyid"></a>
# **GetDuplicateCustomFieldById**
> CustomField GetDuplicateCustomFieldById (int? customFieldId)

Get a duplicated a customField by id

Returns a duplicated customField identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateCustomFieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var customFieldId = 56;  // int? | Id of the customField to be duplicated.

            try
            {
                // Get a duplicated a customField by id
                CustomField result = apiInstance.GetDuplicateCustomFieldById(customFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.GetDuplicateCustomFieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **int?**| Id of the customField to be duplicated. | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomfield"></a>
# **UpdateCustomField**
> void UpdateCustomField (CustomField body)

Update a customField

Updates an existing customField using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateCustomFieldExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new CustomFieldApi();
            var body = new CustomField(); // CustomField | CustomField to be updated.

            try
            {
                // Update a customField
                apiInstance.UpdateCustomField(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldApi.UpdateCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomField**](CustomField.md)| CustomField to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

