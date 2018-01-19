# Infoplus.Api.EmailTemplateApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEmailTemplate**](EmailTemplateApi.md#addemailtemplate) | **POST** /beta/emailTemplate | Create an emailTemplate
[**AddEmailTemplateAudit**](EmailTemplateApi.md#addemailtemplateaudit) | **PUT** /beta/emailTemplate/{emailTemplateId}/audit/{emailTemplateAudit} | Add new audit for an emailTemplate
[**AddEmailTemplateTag**](EmailTemplateApi.md#addemailtemplatetag) | **PUT** /beta/emailTemplate/{emailTemplateId}/tag/{emailTemplateTag} | Add new tags for an emailTemplate.
[**DeleteEmailTemplate**](EmailTemplateApi.md#deleteemailtemplate) | **DELETE** /beta/emailTemplate/{emailTemplateId} | Delete an emailTemplate
[**DeleteEmailTemplateTag**](EmailTemplateApi.md#deleteemailtemplatetag) | **DELETE** /beta/emailTemplate/{emailTemplateId}/tag/{emailTemplateTag} | Delete a tag for an emailTemplate.
[**GetDuplicateEmailTemplateById**](EmailTemplateApi.md#getduplicateemailtemplatebyid) | **GET** /beta/emailTemplate/duplicate/{emailTemplateId} | Get a duplicated an emailTemplate by id
[**GetEmailTemplateByFilter**](EmailTemplateApi.md#getemailtemplatebyfilter) | **GET** /beta/emailTemplate/search | Search emailTemplates by filter
[**GetEmailTemplateById**](EmailTemplateApi.md#getemailtemplatebyid) | **GET** /beta/emailTemplate/{emailTemplateId} | Get an emailTemplate by id
[**GetEmailTemplateTags**](EmailTemplateApi.md#getemailtemplatetags) | **GET** /beta/emailTemplate/{emailTemplateId}/tag | Get the tags for an emailTemplate.
[**UpdateEmailTemplate**](EmailTemplateApi.md#updateemailtemplate) | **PUT** /beta/emailTemplate | Update an emailTemplate
[**UpdateEmailTemplateCustomFields**](EmailTemplateApi.md#updateemailtemplatecustomfields) | **PUT** /beta/emailTemplate/customFields | Update an emailTemplate custom fields


<a name="addemailtemplate"></a>
# **AddEmailTemplate**
> EmailTemplate AddEmailTemplate (EmailTemplate body)

Create an emailTemplate

Inserts a new emailTemplate using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddEmailTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var body = new EmailTemplate(); // EmailTemplate | EmailTemplate to be inserted.

            try
            {
                // Create an emailTemplate
                EmailTemplate result = apiInstance.AddEmailTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.AddEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailTemplate**](EmailTemplate.md)| EmailTemplate to be inserted. | 

### Return type

[**EmailTemplate**](EmailTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addemailtemplateaudit"></a>
# **AddEmailTemplateAudit**
> void AddEmailTemplateAudit (int? emailTemplateId, string emailTemplateAudit)

Add new audit for an emailTemplate

Adds an audit to an existing emailTemplate.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddEmailTemplateAuditExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to add an audit to
            var emailTemplateAudit = emailTemplateAudit_example;  // string | The audit to add

            try
            {
                // Add new audit for an emailTemplate
                apiInstance.AddEmailTemplateAudit(emailTemplateId, emailTemplateAudit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.AddEmailTemplateAudit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to add an audit to | 
 **emailTemplateAudit** | **string**| The audit to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addemailtemplatetag"></a>
# **AddEmailTemplateTag**
> void AddEmailTemplateTag (int? emailTemplateId, string emailTemplateTag)

Add new tags for an emailTemplate.

Adds a tag to an existing emailTemplate.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class AddEmailTemplateTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to add a tag to
            var emailTemplateTag = emailTemplateTag_example;  // string | The tag to add

            try
            {
                // Add new tags for an emailTemplate.
                apiInstance.AddEmailTemplateTag(emailTemplateId, emailTemplateTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.AddEmailTemplateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to add a tag to | 
 **emailTemplateTag** | **string**| The tag to add | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailtemplate"></a>
# **DeleteEmailTemplate**
> void DeleteEmailTemplate (int? emailTemplateId)

Delete an emailTemplate

Deletes the emailTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteEmailTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to be deleted.

            try
            {
                // Delete an emailTemplate
                apiInstance.DeleteEmailTemplate(emailTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.DeleteEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to be deleted. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailtemplatetag"></a>
# **DeleteEmailTemplateTag**
> void DeleteEmailTemplateTag (int? emailTemplateId, string emailTemplateTag)

Delete a tag for an emailTemplate.

Deletes an existing emailTemplate tag using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class DeleteEmailTemplateTagExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to remove tag from
            var emailTemplateTag = emailTemplateTag_example;  // string | The tag to delete

            try
            {
                // Delete a tag for an emailTemplate.
                apiInstance.DeleteEmailTemplateTag(emailTemplateId, emailTemplateTag);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.DeleteEmailTemplateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to remove tag from | 
 **emailTemplateTag** | **string**| The tag to delete | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getduplicateemailtemplatebyid"></a>
# **GetDuplicateEmailTemplateById**
> EmailTemplate GetDuplicateEmailTemplateById (int? emailTemplateId)

Get a duplicated an emailTemplate by id

Returns a duplicated emailTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetDuplicateEmailTemplateByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to be duplicated.

            try
            {
                // Get a duplicated an emailTemplate by id
                EmailTemplate result = apiInstance.GetDuplicateEmailTemplateById(emailTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.GetDuplicateEmailTemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to be duplicated. | 

### Return type

[**EmailTemplate**](EmailTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtemplatebyfilter"></a>
# **GetEmailTemplateByFilter**
> List<EmailTemplate> GetEmailTemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)

Search emailTemplates by filter

Returns the list of emailTemplates that match the given filter.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetEmailTemplateByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var filter = filter_example;  // string | Query string, used to filter results. (optional) 
            var page = 56;  // int? | Result page number.  Defaults to 1. (optional) 
            var limit = 56;  // int? | Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional) 
            var sort = sort_example;  // string | Sort results by specified field. (optional) 

            try
            {
                // Search emailTemplates by filter
                List&lt;EmailTemplate&gt; result = apiInstance.GetEmailTemplateByFilter(filter, page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.GetEmailTemplateByFilter: " + e.Message );
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

[**List<EmailTemplate>**](EmailTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtemplatebyid"></a>
# **GetEmailTemplateById**
> EmailTemplate GetEmailTemplateById (int? emailTemplateId)

Get an emailTemplate by id

Returns the emailTemplate identified by the specified id.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetEmailTemplateByIdExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to be returned.

            try
            {
                // Get an emailTemplate by id
                EmailTemplate result = apiInstance.GetEmailTemplateById(emailTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.GetEmailTemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to be returned. | 

### Return type

[**EmailTemplate**](EmailTemplate.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailtemplatetags"></a>
# **GetEmailTemplateTags**
> void GetEmailTemplateTags (int? emailTemplateId)

Get the tags for an emailTemplate.

Get all existing emailTemplate tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class GetEmailTemplateTagsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var emailTemplateId = 56;  // int? | Id of the emailTemplate to get tags for

            try
            {
                // Get the tags for an emailTemplate.
                apiInstance.GetEmailTemplateTags(emailTemplateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.GetEmailTemplateTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailTemplateId** | **int?**| Id of the emailTemplate to get tags for | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailtemplate"></a>
# **UpdateEmailTemplate**
> void UpdateEmailTemplate (EmailTemplate body)

Update an emailTemplate

Updates an existing emailTemplate using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateEmailTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var body = new EmailTemplate(); // EmailTemplate | EmailTemplate to be updated.

            try
            {
                // Update an emailTemplate
                apiInstance.UpdateEmailTemplate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.UpdateEmailTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailTemplate**](EmailTemplate.md)| EmailTemplate to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailtemplatecustomfields"></a>
# **UpdateEmailTemplateCustomFields**
> void UpdateEmailTemplateCustomFields (EmailTemplate body)

Update an emailTemplate custom fields

Updates an existing emailTemplate custom fields using the specified data.

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class UpdateEmailTemplateCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new EmailTemplateApi();
            var body = new EmailTemplate(); // EmailTemplate | EmailTemplate to be updated.

            try
            {
                // Update an emailTemplate custom fields
                apiInstance.UpdateEmailTemplateCustomFields(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailTemplateApi.UpdateEmailTemplateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailTemplate**](EmailTemplate.md)| EmailTemplate to be updated. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

