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
        /// Add new audit for a scheduledPlanLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param>
        /// <param name="scheduledPlanLogAudit">The audit to add</param>
        /// <returns></returns>
        void AddScheduledPlanLogAudit (int? scheduledPlanLogId, string scheduledPlanLogAudit);
  
        /// <summary>
        /// Add new audit for a scheduledPlanLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param>
        /// <param name="scheduledPlanLogAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddScheduledPlanLogAuditWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogAudit);
        
        /// <summary>
        /// Add new tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param>
        /// <param name="scheduledPlanLogTag">The tag to add</param>
        /// <returns></returns>
        void AddScheduledPlanLogTag (int? scheduledPlanLogId, string scheduledPlanLogTag);
  
        /// <summary>
        /// Add new tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param>
        /// <param name="scheduledPlanLogTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddScheduledPlanLogTagWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag);
        
        /// <summary>
        /// Delete a tag for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing scheduledPlanLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param>
        /// <param name="scheduledPlanLogTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteScheduledPlanLogTag (int? scheduledPlanLogId, string scheduledPlanLogTag);
  
        /// <summary>
        /// Delete a tag for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing scheduledPlanLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param>
        /// <param name="scheduledPlanLogTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteScheduledPlanLogTagWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag);
        
        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param>
        /// <returns>ScheduledPlanLog</returns>
        ScheduledPlanLog GetDuplicateScheduledPlanLogById (int? scheduledPlanLogId);
  
        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param>
        /// <returns>ApiResponse of ScheduledPlanLog</returns>
        ApiResponse<ScheduledPlanLog> GetDuplicateScheduledPlanLogByIdWithHttpInfo (int? scheduledPlanLogId);
        
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
        
        /// <summary>
        /// Get the tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Get all existing scheduledPlanLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param>
        /// <returns></returns>
        void GetScheduledPlanLogTags (int? scheduledPlanLogId);
  
        /// <summary>
        /// Get the tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Get all existing scheduledPlanLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetScheduledPlanLogTagsWithHttpInfo (int? scheduledPlanLogId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a scheduledPlanLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param>
        /// <param name="scheduledPlanLogAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddScheduledPlanLogAuditAsync (int? scheduledPlanLogId, string scheduledPlanLogAudit);

        /// <summary>
        /// Add new audit for a scheduledPlanLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param>
        /// <param name="scheduledPlanLogAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddScheduledPlanLogAuditAsyncWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogAudit);
        
        /// <summary>
        /// Add new tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param>
        /// <param name="scheduledPlanLogTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddScheduledPlanLogTagAsync (int? scheduledPlanLogId, string scheduledPlanLogTag);

        /// <summary>
        /// Add new tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing scheduledPlanLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param>
        /// <param name="scheduledPlanLogTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddScheduledPlanLogTagAsyncWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag);
        
        /// <summary>
        /// Delete a tag for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing scheduledPlanLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param>
        /// <param name="scheduledPlanLogTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteScheduledPlanLogTagAsync (int? scheduledPlanLogId, string scheduledPlanLogTag);

        /// <summary>
        /// Delete a tag for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing scheduledPlanLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param>
        /// <param name="scheduledPlanLogTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteScheduledPlanLogTagAsyncWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag);
        
        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param>
        /// <returns>Task of ScheduledPlanLog</returns>
        System.Threading.Tasks.Task<ScheduledPlanLog> GetDuplicateScheduledPlanLogByIdAsync (int? scheduledPlanLogId);

        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param>
        /// <returns>Task of ApiResponse (ScheduledPlanLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduledPlanLog>> GetDuplicateScheduledPlanLogByIdAsyncWithHttpInfo (int? scheduledPlanLogId);
        
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
        
        /// <summary>
        /// Get the tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Get all existing scheduledPlanLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetScheduledPlanLogTagsAsync (int? scheduledPlanLogId);

        /// <summary>
        /// Get the tags for a scheduledPlanLog.
        /// </summary>
        /// <remarks>
        /// Get all existing scheduledPlanLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetScheduledPlanLogTagsAsyncWithHttpInfo (int? scheduledPlanLogId);
        
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
        /// Add new audit for a scheduledPlanLog Adds an audit to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param> 
        /// <param name="scheduledPlanLogAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddScheduledPlanLogAudit (int? scheduledPlanLogId, string scheduledPlanLogAudit)
        {
             AddScheduledPlanLogAuditWithHttpInfo(scheduledPlanLogId, scheduledPlanLogAudit);
        }

        /// <summary>
        /// Add new audit for a scheduledPlanLog Adds an audit to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param> 
        /// <param name="scheduledPlanLogAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddScheduledPlanLogAuditWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogAudit)
        {
            
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling ScheduledPlanLogApi->AddScheduledPlanLogAudit");
            
            // verify the required parameter 'scheduledPlanLogAudit' is set
            if (scheduledPlanLogAudit == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogAudit' when calling ScheduledPlanLogApi->AddScheduledPlanLogAudit");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/audit/{scheduledPlanLogAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (scheduledPlanLogAudit != null) localVarPathParams.Add("scheduledPlanLogAudit", Configuration.ApiClient.ParameterToString(scheduledPlanLogAudit)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a scheduledPlanLog Adds an audit to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param>
        /// <param name="scheduledPlanLogAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddScheduledPlanLogAuditAsync (int? scheduledPlanLogId, string scheduledPlanLogAudit)
        {
             await AddScheduledPlanLogAuditAsyncWithHttpInfo(scheduledPlanLogId, scheduledPlanLogAudit);

        }

        /// <summary>
        /// Add new audit for a scheduledPlanLog Adds an audit to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add an audit to</param>
        /// <param name="scheduledPlanLogAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddScheduledPlanLogAuditAsyncWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogAudit)
        {
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling AddScheduledPlanLogAudit");
            // verify the required parameter 'scheduledPlanLogAudit' is set
            if (scheduledPlanLogAudit == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogAudit' when calling AddScheduledPlanLogAudit");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/audit/{scheduledPlanLogAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (scheduledPlanLogAudit != null) localVarPathParams.Add("scheduledPlanLogAudit", Configuration.ApiClient.ParameterToString(scheduledPlanLogAudit)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a scheduledPlanLog. Adds a tag to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param> 
        /// <param name="scheduledPlanLogTag">The tag to add</param> 
        /// <returns></returns>
        public void AddScheduledPlanLogTag (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
             AddScheduledPlanLogTagWithHttpInfo(scheduledPlanLogId, scheduledPlanLogTag);
        }

        /// <summary>
        /// Add new tags for a scheduledPlanLog. Adds a tag to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param> 
        /// <param name="scheduledPlanLogTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddScheduledPlanLogTagWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
            
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling ScheduledPlanLogApi->AddScheduledPlanLogTag");
            
            // verify the required parameter 'scheduledPlanLogTag' is set
            if (scheduledPlanLogTag == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogTag' when calling ScheduledPlanLogApi->AddScheduledPlanLogTag");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/tag/{scheduledPlanLogTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (scheduledPlanLogTag != null) localVarPathParams.Add("scheduledPlanLogTag", Configuration.ApiClient.ParameterToString(scheduledPlanLogTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a scheduledPlanLog. Adds a tag to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param>
        /// <param name="scheduledPlanLogTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddScheduledPlanLogTagAsync (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
             await AddScheduledPlanLogTagAsyncWithHttpInfo(scheduledPlanLogId, scheduledPlanLogTag);

        }

        /// <summary>
        /// Add new tags for a scheduledPlanLog. Adds a tag to an existing scheduledPlanLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to add a tag to</param>
        /// <param name="scheduledPlanLogTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddScheduledPlanLogTagAsyncWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling AddScheduledPlanLogTag");
            // verify the required parameter 'scheduledPlanLogTag' is set
            if (scheduledPlanLogTag == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogTag' when calling AddScheduledPlanLogTag");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/tag/{scheduledPlanLogTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (scheduledPlanLogTag != null) localVarPathParams.Add("scheduledPlanLogTag", Configuration.ApiClient.ParameterToString(scheduledPlanLogTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddScheduledPlanLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a scheduledPlanLog. Deletes an existing scheduledPlanLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param> 
        /// <param name="scheduledPlanLogTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteScheduledPlanLogTag (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
             DeleteScheduledPlanLogTagWithHttpInfo(scheduledPlanLogId, scheduledPlanLogTag);
        }

        /// <summary>
        /// Delete a tag for a scheduledPlanLog. Deletes an existing scheduledPlanLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param> 
        /// <param name="scheduledPlanLogTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteScheduledPlanLogTagWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
            
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling ScheduledPlanLogApi->DeleteScheduledPlanLogTag");
            
            // verify the required parameter 'scheduledPlanLogTag' is set
            if (scheduledPlanLogTag == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogTag' when calling ScheduledPlanLogApi->DeleteScheduledPlanLogTag");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/tag/{scheduledPlanLogTag}";
    
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
            if (scheduledPlanLogTag != null) localVarPathParams.Add("scheduledPlanLogTag", Configuration.ApiClient.ParameterToString(scheduledPlanLogTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScheduledPlanLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScheduledPlanLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a scheduledPlanLog. Deletes an existing scheduledPlanLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param>
        /// <param name="scheduledPlanLogTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteScheduledPlanLogTagAsync (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
             await DeleteScheduledPlanLogTagAsyncWithHttpInfo(scheduledPlanLogId, scheduledPlanLogTag);

        }

        /// <summary>
        /// Delete a tag for a scheduledPlanLog. Deletes an existing scheduledPlanLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to remove tag from</param>
        /// <param name="scheduledPlanLogTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteScheduledPlanLogTagAsyncWithHttpInfo (int? scheduledPlanLogId, string scheduledPlanLogTag)
        {
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling DeleteScheduledPlanLogTag");
            // verify the required parameter 'scheduledPlanLogTag' is set
            if (scheduledPlanLogTag == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogTag' when calling DeleteScheduledPlanLogTag");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/tag/{scheduledPlanLogTag}";
    
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
            if (scheduledPlanLogTag != null) localVarPathParams.Add("scheduledPlanLogTag", Configuration.ApiClient.ParameterToString(scheduledPlanLogTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScheduledPlanLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScheduledPlanLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param> 
        /// <returns>ScheduledPlanLog</returns>
        public ScheduledPlanLog GetDuplicateScheduledPlanLogById (int? scheduledPlanLogId)
        {
             ApiResponse<ScheduledPlanLog> localVarResponse = GetDuplicateScheduledPlanLogByIdWithHttpInfo(scheduledPlanLogId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param> 
        /// <returns>ApiResponse of ScheduledPlanLog</returns>
        public ApiResponse< ScheduledPlanLog > GetDuplicateScheduledPlanLogByIdWithHttpInfo (int? scheduledPlanLogId)
        {
            
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling ScheduledPlanLogApi->GetDuplicateScheduledPlanLogById");
            
    
            var localVarPath = "/beta/scheduledPlanLog/duplicate/{scheduledPlanLogId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateScheduledPlanLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateScheduledPlanLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ScheduledPlanLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduledPlanLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduledPlanLog)));
            
        }

        
        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param>
        /// <returns>Task of ScheduledPlanLog</returns>
        public async System.Threading.Tasks.Task<ScheduledPlanLog> GetDuplicateScheduledPlanLogByIdAsync (int? scheduledPlanLogId)
        {
             ApiResponse<ScheduledPlanLog> localVarResponse = await GetDuplicateScheduledPlanLogByIdAsyncWithHttpInfo(scheduledPlanLogId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a scheduledPlanLog by id Returns a duplicated scheduledPlanLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to be duplicated.</param>
        /// <returns>Task of ApiResponse (ScheduledPlanLog)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduledPlanLog>> GetDuplicateScheduledPlanLogByIdAsyncWithHttpInfo (int? scheduledPlanLogId)
        {
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling GetDuplicateScheduledPlanLogById");
            
    
            var localVarPath = "/beta/scheduledPlanLog/duplicate/{scheduledPlanLogId}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateScheduledPlanLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateScheduledPlanLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduledPlanLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduledPlanLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduledPlanLog)));
            
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
        
        /// <summary>
        /// Get the tags for a scheduledPlanLog. Get all existing scheduledPlanLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param> 
        /// <returns></returns>
        public void GetScheduledPlanLogTags (int? scheduledPlanLogId)
        {
             GetScheduledPlanLogTagsWithHttpInfo(scheduledPlanLogId);
        }

        /// <summary>
        /// Get the tags for a scheduledPlanLog. Get all existing scheduledPlanLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetScheduledPlanLogTagsWithHttpInfo (int? scheduledPlanLogId)
        {
            
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null)
                throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling ScheduledPlanLogApi->GetScheduledPlanLogTags");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/tag";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a scheduledPlanLog. Get all existing scheduledPlanLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetScheduledPlanLogTagsAsync (int? scheduledPlanLogId)
        {
             await GetScheduledPlanLogTagsAsyncWithHttpInfo(scheduledPlanLogId);

        }

        /// <summary>
        /// Get the tags for a scheduledPlanLog. Get all existing scheduledPlanLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduledPlanLogId">Id of the scheduledPlanLog to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetScheduledPlanLogTagsAsyncWithHttpInfo (int? scheduledPlanLogId)
        {
            // verify the required parameter 'scheduledPlanLogId' is set
            if (scheduledPlanLogId == null) throw new ApiException(400, "Missing required parameter 'scheduledPlanLogId' when calling GetScheduledPlanLogTags");
            
    
            var localVarPath = "/beta/scheduledPlanLog/{scheduledPlanLogId}/tag";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScheduledPlanLogTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
