# Infoplus.Api.ReportApi

All URIs are relative to *https://kingsrook.localhost-testsubdomain1.infopluswms.com:8443/infoplus-wms/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RunReport**](ReportApi.md#runreport) | **GET** /v3.0/report/{reportId}/runReport | Run a specified report


<a name="runreport"></a>
# **RunReport**
> void RunReport (int? reportId, string format)

Run a specified report

Run a specified report

### Example
```csharp
using System;
using System.Diagnostics;
using Infoplus.Api;
using Infoplus.Client;
using Infoplus.Model;

namespace Example
{
    public class RunReportExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("API-Key", "Bearer");

            var apiInstance = new ReportApi();
            var reportId = 56;  // int? | Id of the report to run.
            var format = format_example;  // string | Format of the report.

            try
            {
                // Run a specified report
                apiInstance.RunReport(reportId, format);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.RunReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportId** | **int?**| Id of the report to run. | 
 **format** | **string**| Format of the report. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

