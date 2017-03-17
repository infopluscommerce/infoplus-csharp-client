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
    public interface ILoggedTimeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a loggedTime
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param>
        /// <param name="loggedTimeAudit">The audit to add</param>
        /// <returns></returns>
        void AddLoggedTimeAudit (int? loggedTimeId, string loggedTimeAudit);
  
        /// <summary>
        /// Add new audit for a loggedTime
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param>
        /// <param name="loggedTimeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLoggedTimeAuditWithHttpInfo (int? loggedTimeId, string loggedTimeAudit);
        
        /// <summary>
        /// Add new tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param>
        /// <param name="loggedTimeTag">The tag to add</param>
        /// <returns></returns>
        void AddLoggedTimeTag (int? loggedTimeId, string loggedTimeTag);
  
        /// <summary>
        /// Add new tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param>
        /// <param name="loggedTimeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLoggedTimeTagWithHttpInfo (int? loggedTimeId, string loggedTimeTag);
        
        /// <summary>
        /// Delete a tag for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Deletes an existing loggedTime tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param>
        /// <param name="loggedTimeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteLoggedTimeTag (int? loggedTimeId, string loggedTimeTag);
  
        /// <summary>
        /// Delete a tag for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Deletes an existing loggedTime tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param>
        /// <param name="loggedTimeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLoggedTimeTagWithHttpInfo (int? loggedTimeId, string loggedTimeTag);
        
        /// <summary>
        /// Get a duplicated a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param>
        /// <returns>LoggedTime</returns>
        LoggedTime GetDuplicateLoggedTimeById (int? loggedTimeId);
  
        /// <summary>
        /// Get a duplicated a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param>
        /// <returns>ApiResponse of LoggedTime</returns>
        ApiResponse<LoggedTime> GetDuplicateLoggedTimeByIdWithHttpInfo (int? loggedTimeId);
        
        /// <summary>
        /// Search loggedTimes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of loggedTimes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;LoggedTime&gt;</returns>
        List<LoggedTime> GetLoggedTimeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search loggedTimes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of loggedTimes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;LoggedTime&gt;</returns>
        ApiResponse<List<LoggedTime>> GetLoggedTimeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns the loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param>
        /// <returns>LoggedTime</returns>
        LoggedTime GetLoggedTimeById (int? loggedTimeId);
  
        /// <summary>
        /// Get a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns the loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param>
        /// <returns>ApiResponse of LoggedTime</returns>
        ApiResponse<LoggedTime> GetLoggedTimeByIdWithHttpInfo (int? loggedTimeId);
        
        /// <summary>
        /// Get the tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Get all existing loggedTime tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param>
        /// <returns></returns>
        void GetLoggedTimeTags (int? loggedTimeId);
  
        /// <summary>
        /// Get the tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Get all existing loggedTime tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetLoggedTimeTagsWithHttpInfo (int? loggedTimeId);
        
        /// <summary>
        /// Update a loggedTime custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing loggedTime custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param>
        /// <returns></returns>
        void UpdateLoggedTimeCustomFields (LoggedTime body);
  
        /// <summary>
        /// Update a loggedTime custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing loggedTime custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLoggedTimeCustomFieldsWithHttpInfo (LoggedTime body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a loggedTime
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param>
        /// <param name="loggedTimeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLoggedTimeAuditAsync (int? loggedTimeId, string loggedTimeAudit);

        /// <summary>
        /// Add new audit for a loggedTime
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param>
        /// <param name="loggedTimeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLoggedTimeAuditAsyncWithHttpInfo (int? loggedTimeId, string loggedTimeAudit);
        
        /// <summary>
        /// Add new tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param>
        /// <param name="loggedTimeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLoggedTimeTagAsync (int? loggedTimeId, string loggedTimeTag);

        /// <summary>
        /// Add new tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing loggedTime.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param>
        /// <param name="loggedTimeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLoggedTimeTagAsyncWithHttpInfo (int? loggedTimeId, string loggedTimeTag);
        
        /// <summary>
        /// Delete a tag for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Deletes an existing loggedTime tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param>
        /// <param name="loggedTimeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLoggedTimeTagAsync (int? loggedTimeId, string loggedTimeTag);

        /// <summary>
        /// Delete a tag for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Deletes an existing loggedTime tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param>
        /// <param name="loggedTimeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLoggedTimeTagAsyncWithHttpInfo (int? loggedTimeId, string loggedTimeTag);
        
        /// <summary>
        /// Get a duplicated a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param>
        /// <returns>Task of LoggedTime</returns>
        System.Threading.Tasks.Task<LoggedTime> GetDuplicateLoggedTimeByIdAsync (int? loggedTimeId);

        /// <summary>
        /// Get a duplicated a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param>
        /// <returns>Task of ApiResponse (LoggedTime)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoggedTime>> GetDuplicateLoggedTimeByIdAsyncWithHttpInfo (int? loggedTimeId);
        
        /// <summary>
        /// Search loggedTimes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of loggedTimes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LoggedTime&gt;</returns>
        System.Threading.Tasks.Task<List<LoggedTime>> GetLoggedTimeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search loggedTimes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of loggedTimes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LoggedTime&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LoggedTime>>> GetLoggedTimeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns the loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param>
        /// <returns>Task of LoggedTime</returns>
        System.Threading.Tasks.Task<LoggedTime> GetLoggedTimeByIdAsync (int? loggedTimeId);

        /// <summary>
        /// Get a loggedTime by id
        /// </summary>
        /// <remarks>
        /// Returns the loggedTime identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param>
        /// <returns>Task of ApiResponse (LoggedTime)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoggedTime>> GetLoggedTimeByIdAsyncWithHttpInfo (int? loggedTimeId);
        
        /// <summary>
        /// Get the tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Get all existing loggedTime tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetLoggedTimeTagsAsync (int? loggedTimeId);

        /// <summary>
        /// Get the tags for a loggedTime.
        /// </summary>
        /// <remarks>
        /// Get all existing loggedTime tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetLoggedTimeTagsAsyncWithHttpInfo (int? loggedTimeId);
        
        /// <summary>
        /// Update a loggedTime custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing loggedTime custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLoggedTimeCustomFieldsAsync (LoggedTime body);

        /// <summary>
        /// Update a loggedTime custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing loggedTime custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLoggedTimeCustomFieldsAsyncWithHttpInfo (LoggedTime body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LoggedTimeApi : ILoggedTimeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedTimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoggedTimeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedTimeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoggedTimeApi(Configuration configuration = null)
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
        /// Add new audit for a loggedTime Adds an audit to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param> 
        /// <param name="loggedTimeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddLoggedTimeAudit (int? loggedTimeId, string loggedTimeAudit)
        {
             AddLoggedTimeAuditWithHttpInfo(loggedTimeId, loggedTimeAudit);
        }

        /// <summary>
        /// Add new audit for a loggedTime Adds an audit to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param> 
        /// <param name="loggedTimeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLoggedTimeAuditWithHttpInfo (int? loggedTimeId, string loggedTimeAudit)
        {
            
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling LoggedTimeApi->AddLoggedTimeAudit");
            
            // verify the required parameter 'loggedTimeAudit' is set
            if (loggedTimeAudit == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeAudit' when calling LoggedTimeApi->AddLoggedTimeAudit");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/audit/{loggedTimeAudit}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            if (loggedTimeAudit != null) localVarPathParams.Add("loggedTimeAudit", Configuration.ApiClient.ParameterToString(loggedTimeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a loggedTime Adds an audit to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param>
        /// <param name="loggedTimeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLoggedTimeAuditAsync (int? loggedTimeId, string loggedTimeAudit)
        {
             await AddLoggedTimeAuditAsyncWithHttpInfo(loggedTimeId, loggedTimeAudit);

        }

        /// <summary>
        /// Add new audit for a loggedTime Adds an audit to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add an audit to</param>
        /// <param name="loggedTimeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLoggedTimeAuditAsyncWithHttpInfo (int? loggedTimeId, string loggedTimeAudit)
        {
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null) throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling AddLoggedTimeAudit");
            // verify the required parameter 'loggedTimeAudit' is set
            if (loggedTimeAudit == null) throw new ApiException(400, "Missing required parameter 'loggedTimeAudit' when calling AddLoggedTimeAudit");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/audit/{loggedTimeAudit}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            if (loggedTimeAudit != null) localVarPathParams.Add("loggedTimeAudit", Configuration.ApiClient.ParameterToString(loggedTimeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a loggedTime. Adds a tag to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param> 
        /// <param name="loggedTimeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddLoggedTimeTag (int? loggedTimeId, string loggedTimeTag)
        {
             AddLoggedTimeTagWithHttpInfo(loggedTimeId, loggedTimeTag);
        }

        /// <summary>
        /// Add new tags for a loggedTime. Adds a tag to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param> 
        /// <param name="loggedTimeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLoggedTimeTagWithHttpInfo (int? loggedTimeId, string loggedTimeTag)
        {
            
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling LoggedTimeApi->AddLoggedTimeTag");
            
            // verify the required parameter 'loggedTimeTag' is set
            if (loggedTimeTag == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeTag' when calling LoggedTimeApi->AddLoggedTimeTag");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/tag/{loggedTimeTag}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            if (loggedTimeTag != null) localVarPathParams.Add("loggedTimeTag", Configuration.ApiClient.ParameterToString(loggedTimeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a loggedTime. Adds a tag to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param>
        /// <param name="loggedTimeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLoggedTimeTagAsync (int? loggedTimeId, string loggedTimeTag)
        {
             await AddLoggedTimeTagAsyncWithHttpInfo(loggedTimeId, loggedTimeTag);

        }

        /// <summary>
        /// Add new tags for a loggedTime. Adds a tag to an existing loggedTime.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to add a tag to</param>
        /// <param name="loggedTimeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLoggedTimeTagAsyncWithHttpInfo (int? loggedTimeId, string loggedTimeTag)
        {
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null) throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling AddLoggedTimeTag");
            // verify the required parameter 'loggedTimeTag' is set
            if (loggedTimeTag == null) throw new ApiException(400, "Missing required parameter 'loggedTimeTag' when calling AddLoggedTimeTag");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/tag/{loggedTimeTag}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            if (loggedTimeTag != null) localVarPathParams.Add("loggedTimeTag", Configuration.ApiClient.ParameterToString(loggedTimeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLoggedTimeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a loggedTime. Deletes an existing loggedTime tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param> 
        /// <param name="loggedTimeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteLoggedTimeTag (int? loggedTimeId, string loggedTimeTag)
        {
             DeleteLoggedTimeTagWithHttpInfo(loggedTimeId, loggedTimeTag);
        }

        /// <summary>
        /// Delete a tag for a loggedTime. Deletes an existing loggedTime tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param> 
        /// <param name="loggedTimeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLoggedTimeTagWithHttpInfo (int? loggedTimeId, string loggedTimeTag)
        {
            
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling LoggedTimeApi->DeleteLoggedTimeTag");
            
            // verify the required parameter 'loggedTimeTag' is set
            if (loggedTimeTag == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeTag' when calling LoggedTimeApi->DeleteLoggedTimeTag");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/tag/{loggedTimeTag}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            if (loggedTimeTag != null) localVarPathParams.Add("loggedTimeTag", Configuration.ApiClient.ParameterToString(loggedTimeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLoggedTimeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLoggedTimeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a loggedTime. Deletes an existing loggedTime tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param>
        /// <param name="loggedTimeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLoggedTimeTagAsync (int? loggedTimeId, string loggedTimeTag)
        {
             await DeleteLoggedTimeTagAsyncWithHttpInfo(loggedTimeId, loggedTimeTag);

        }

        /// <summary>
        /// Delete a tag for a loggedTime. Deletes an existing loggedTime tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to remove tag from</param>
        /// <param name="loggedTimeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLoggedTimeTagAsyncWithHttpInfo (int? loggedTimeId, string loggedTimeTag)
        {
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null) throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling DeleteLoggedTimeTag");
            // verify the required parameter 'loggedTimeTag' is set
            if (loggedTimeTag == null) throw new ApiException(400, "Missing required parameter 'loggedTimeTag' when calling DeleteLoggedTimeTag");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/tag/{loggedTimeTag}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            if (loggedTimeTag != null) localVarPathParams.Add("loggedTimeTag", Configuration.ApiClient.ParameterToString(loggedTimeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLoggedTimeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLoggedTimeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a loggedTime by id Returns a duplicated loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param> 
        /// <returns>LoggedTime</returns>
        public LoggedTime GetDuplicateLoggedTimeById (int? loggedTimeId)
        {
             ApiResponse<LoggedTime> localVarResponse = GetDuplicateLoggedTimeByIdWithHttpInfo(loggedTimeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a loggedTime by id Returns a duplicated loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param> 
        /// <returns>ApiResponse of LoggedTime</returns>
        public ApiResponse< LoggedTime > GetDuplicateLoggedTimeByIdWithHttpInfo (int? loggedTimeId)
        {
            
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling LoggedTimeApi->GetDuplicateLoggedTimeById");
            
    
            var localVarPath = "/beta/loggedTime/duplicate/{loggedTimeId}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLoggedTimeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLoggedTimeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoggedTime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoggedTime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoggedTime)));
            
        }

        
        /// <summary>
        /// Get a duplicated a loggedTime by id Returns a duplicated loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param>
        /// <returns>Task of LoggedTime</returns>
        public async System.Threading.Tasks.Task<LoggedTime> GetDuplicateLoggedTimeByIdAsync (int? loggedTimeId)
        {
             ApiResponse<LoggedTime> localVarResponse = await GetDuplicateLoggedTimeByIdAsyncWithHttpInfo(loggedTimeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a loggedTime by id Returns a duplicated loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be duplicated.</param>
        /// <returns>Task of ApiResponse (LoggedTime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoggedTime>> GetDuplicateLoggedTimeByIdAsyncWithHttpInfo (int? loggedTimeId)
        {
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null) throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling GetDuplicateLoggedTimeById");
            
    
            var localVarPath = "/beta/loggedTime/duplicate/{loggedTimeId}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLoggedTimeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLoggedTimeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoggedTime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoggedTime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoggedTime)));
            
        }
        
        /// <summary>
        /// Search loggedTimes by filter Returns the list of loggedTimes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;LoggedTime&gt;</returns>
        public List<LoggedTime> GetLoggedTimeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LoggedTime>> localVarResponse = GetLoggedTimeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search loggedTimes by filter Returns the list of loggedTimes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;LoggedTime&gt;</returns>
        public ApiResponse< List<LoggedTime> > GetLoggedTimeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/loggedTime/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<LoggedTime>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LoggedTime>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LoggedTime>)));
            
        }

        
        /// <summary>
        /// Search loggedTimes by filter Returns the list of loggedTimes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LoggedTime&gt;</returns>
        public async System.Threading.Tasks.Task<List<LoggedTime>> GetLoggedTimeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LoggedTime>> localVarResponse = await GetLoggedTimeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search loggedTimes by filter Returns the list of loggedTimes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LoggedTime&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LoggedTime>>> GetLoggedTimeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/loggedTime/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LoggedTime>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LoggedTime>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LoggedTime>)));
            
        }
        
        /// <summary>
        /// Get a loggedTime by id Returns the loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param> 
        /// <returns>LoggedTime</returns>
        public LoggedTime GetLoggedTimeById (int? loggedTimeId)
        {
             ApiResponse<LoggedTime> localVarResponse = GetLoggedTimeByIdWithHttpInfo(loggedTimeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a loggedTime by id Returns the loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param> 
        /// <returns>ApiResponse of LoggedTime</returns>
        public ApiResponse< LoggedTime > GetLoggedTimeByIdWithHttpInfo (int? loggedTimeId)
        {
            
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling LoggedTimeApi->GetLoggedTimeById");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LoggedTime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoggedTime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoggedTime)));
            
        }

        
        /// <summary>
        /// Get a loggedTime by id Returns the loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param>
        /// <returns>Task of LoggedTime</returns>
        public async System.Threading.Tasks.Task<LoggedTime> GetLoggedTimeByIdAsync (int? loggedTimeId)
        {
             ApiResponse<LoggedTime> localVarResponse = await GetLoggedTimeByIdAsyncWithHttpInfo(loggedTimeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a loggedTime by id Returns the loggedTime identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to be returned.</param>
        /// <returns>Task of ApiResponse (LoggedTime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoggedTime>> GetLoggedTimeByIdAsyncWithHttpInfo (int? loggedTimeId)
        {
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null) throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling GetLoggedTimeById");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LoggedTime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoggedTime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoggedTime)));
            
        }
        
        /// <summary>
        /// Get the tags for a loggedTime. Get all existing loggedTime tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param> 
        /// <returns></returns>
        public void GetLoggedTimeTags (int? loggedTimeId)
        {
             GetLoggedTimeTagsWithHttpInfo(loggedTimeId);
        }

        /// <summary>
        /// Get the tags for a loggedTime. Get all existing loggedTime tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetLoggedTimeTagsWithHttpInfo (int? loggedTimeId)
        {
            
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null)
                throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling LoggedTimeApi->GetLoggedTimeTags");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/tag";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a loggedTime. Get all existing loggedTime tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetLoggedTimeTagsAsync (int? loggedTimeId)
        {
             await GetLoggedTimeTagsAsyncWithHttpInfo(loggedTimeId);

        }

        /// <summary>
        /// Get the tags for a loggedTime. Get all existing loggedTime tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loggedTimeId">Id of the loggedTime to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetLoggedTimeTagsAsyncWithHttpInfo (int? loggedTimeId)
        {
            // verify the required parameter 'loggedTimeId' is set
            if (loggedTimeId == null) throw new ApiException(400, "Missing required parameter 'loggedTimeId' when calling GetLoggedTimeTags");
            
    
            var localVarPath = "/beta/loggedTime/{loggedTimeId}/tag";
    
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
            if (loggedTimeId != null) localVarPathParams.Add("loggedTimeId", Configuration.ApiClient.ParameterToString(loggedTimeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLoggedTimeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a loggedTime custom fields Updates an existing loggedTime custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param> 
        /// <returns></returns>
        public void UpdateLoggedTimeCustomFields (LoggedTime body)
        {
             UpdateLoggedTimeCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a loggedTime custom fields Updates an existing loggedTime custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLoggedTimeCustomFieldsWithHttpInfo (LoggedTime body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LoggedTimeApi->UpdateLoggedTimeCustomFields");
            
    
            var localVarPath = "/beta/loggedTime/customFields";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLoggedTimeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLoggedTimeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a loggedTime custom fields Updates an existing loggedTime custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLoggedTimeCustomFieldsAsync (LoggedTime body)
        {
             await UpdateLoggedTimeCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a loggedTime custom fields Updates an existing loggedTime custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LoggedTime to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLoggedTimeCustomFieldsAsyncWithHttpInfo (LoggedTime body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLoggedTimeCustomFields");
            
    
            var localVarPath = "/beta/loggedTime/customFields";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLoggedTimeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLoggedTimeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
