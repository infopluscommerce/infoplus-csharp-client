using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Infoplus.Client;
using Infoplus.Model;

namespace Infoplus.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScheduledPlanLogApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search scheduledPlanLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of scheduledPlanLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ScheduledPlanLog&gt;</returns>
        List<ScheduledPlanLog> GetScheduledPlanLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search scheduledPlanLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of scheduledPlanLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ScheduledPlanLog&gt;</returns>
        ApiResponse<List<ScheduledPlanLog>> GetScheduledPlanLogByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns the scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param>
        /// <returns>ScheduledPlanLog</returns>
        ScheduledPlanLog GetScheduledPlanLogById (int? scheduledPlanLogId);
  
        /// <summary>
        /// Get a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns the scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param>
        /// <returns>ApiResponse of ScheduledPlanLog</returns>
        ApiResponse<ScheduledPlanLog> GetScheduledPlanLogByIdWithHttpInfo (int? scheduledPlanLogId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search scheduledPlanLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of scheduledPlanLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ScheduledPlanLog&gt;</returns>
        System.Threading.Tasks.Task<List<ScheduledPlanLog>> GetScheduledPlanLogByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search scheduledPlanLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of scheduledPlanLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ScheduledPlanLog&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ScheduledPlanLog>>> GetScheduledPlanLogByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns the scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param>
        /// <returns>Task of ScheduledPlanLog</returns>
        System.Threading.Tasks.Task<ScheduledPlanLog> GetScheduledPlanLogByIdAsync (int? scheduledPlanLogId);

        /// <summary>
        /// Get a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns the scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param>
        /// <returns>Task of ApiResponse (ScheduledPlanLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduledPlanLog>> GetScheduledPlanLogByIdAsyncWithHttpInfo (int? scheduledPlanLogId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScheduledPlanLogApi : IScheduledPlanLogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledPlanLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScheduledPlanLogApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledPlanLogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScheduledPlanLogApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Search scheduledPlanLogs by filter Returns the list of scheduledPlanLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ScheduledPlanLog&gt;</returns>
        public List<ScheduledPlanLog> GetScheduledPlanLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ScheduledPlanLog>> localVarResponse = GetScheduledPlanLogByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search scheduledPlanLogs by filter Returns the list of scheduledPlanLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ScheduledPlanLog&gt;</returns>
        public ApiResponse< List<ScheduledPlanLog> > GetScheduledPlanLogByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/scheduledPlanLog/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ScheduledPlanLog>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ScheduledPlanLog>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ScheduledPlanLog>)));
            
        }

        
        /// <summary>
        /// Search scheduledPlanLogs by filter Returns the list of scheduledPlanLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ScheduledPlanLog&gt;</returns>
        public async System.Threading.Tasks.Task<List<ScheduledPlanLog>> GetScheduledPlanLogByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ScheduledPlanLog>> localVarResponse = await GetScheduledPlanLogByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search scheduledPlanLogs by filter Returns the list of scheduledPlanLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ScheduledPlanLog&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ScheduledPlanLog>>> GetScheduledPlanLogByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/scheduledPlanLog/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ScheduledPlanLog>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ScheduledPlanLog>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ScheduledPlanLog>)));
            
        }
        
        /// <summary>
        /// Get a scheduledPlanLog by id Returns the scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param> 
        /// <returns>ScheduledPlanLog</returns>
        public ScheduledPlanLog GetScheduledPlanLogById (int? scheduledPlanLogId)
        {
             ApiResponse<ScheduledPlanLog> localVarResponse = GetScheduledPlanLogByIdWithHttpInfo(scheduledPlanLogId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a scheduledPlanLog by id Returns the scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param> 
        /// <returns>ApiResponse of ScheduledPlanLog</returns>
        public ApiResponse< ScheduledPlanLog > GetScheduledPlanLogByIdWithHttpInfo (int? scheduledPlanLogId)
        {
            
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling ScheduledPlanLogApi->GetScheduledPlanLogById");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduledPlanLogId != null) localVarPathParams.Add("scheduledPlanLogId", Configuration.ApiClient.ParameterToString(scheduledPlanLogId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ScheduledPlanLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduledPlanLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduledPlanLog)));
            
        }

        
        /// <summary>
        /// Get a scheduledPlanLog by id Returns the scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param>
        /// <returns>Task of ScheduledPlanLog</returns>
        public async System.Threading.Tasks.Task<ScheduledPlanLog> GetScheduledPlanLogByIdAsync (int? scheduledPlanLogId)
        {
             ApiResponse<ScheduledPlanLog> localVarResponse = await GetScheduledPlanLogByIdAsyncWithHttpInfo(scheduledPlanLogId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a scheduledPlanLog by id Returns the scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be returned.</param>
        /// <returns>Task of ApiResponse (ScheduledPlanLog)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduledPlanLog>> GetScheduledPlanLogByIdAsyncWithHttpInfo (int? scheduledPlanLogId)
        {
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling GetScheduledPlanLogById");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scheduledPlanLogId != null) localVarPathParams.Add("scheduledPlanLogId", Configuration.ApiClient.ParameterToString(scheduledPlanLogId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduledPlanLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduledPlanLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduledPlanLog)));
            
        }
        
    }
    
}
