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
    public interface IWorkBatchApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a workBatch
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param>
        /// <param name="workBatchAudit">The audit to add</param>
        /// <returns></returns>
        void AddWorkBatchAudit (int? workBatchId, string workBatchAudit);
  
        /// <summary>
        /// Add new audit for a workBatch
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param>
        /// <param name="workBatchAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddWorkBatchAuditWithHttpInfo (int? workBatchId, string workBatchAudit);
        
        /// <summary>
        /// Add new tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param>
        /// <param name="workBatchTag">The tag to add</param>
        /// <returns></returns>
        void AddWorkBatchTag (int? workBatchId, string workBatchTag);
  
        /// <summary>
        /// Add new tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param>
        /// <param name="workBatchTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddWorkBatchTagWithHttpInfo (int? workBatchId, string workBatchTag);
        
        /// <summary>
        /// Delete a tag for a workBatch.
        /// </summary>
        /// <remarks>
        /// Deletes an existing workBatch tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param>
        /// <param name="workBatchTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteWorkBatchTag (int? workBatchId, string workBatchTag);
  
        /// <summary>
        /// Delete a tag for a workBatch.
        /// </summary>
        /// <remarks>
        /// Deletes an existing workBatch tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param>
        /// <param name="workBatchTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWorkBatchTagWithHttpInfo (int? workBatchId, string workBatchTag);
        
        /// <summary>
        /// Get a duplicated a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param>
        /// <returns>WorkBatch</returns>
        WorkBatch GetDuplicateWorkBatchById (int? workBatchId);
  
        /// <summary>
        /// Get a duplicated a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param>
        /// <returns>ApiResponse of WorkBatch</returns>
        ApiResponse<WorkBatch> GetDuplicateWorkBatchByIdWithHttpInfo (int? workBatchId);
        
        /// <summary>
        /// Search workBatchs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of workBatchs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;WorkBatch&gt;</returns>
        List<WorkBatch> GetWorkBatchByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search workBatchs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of workBatchs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;WorkBatch&gt;</returns>
        ApiResponse<List<WorkBatch>> GetWorkBatchByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns the workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param>
        /// <returns>WorkBatch</returns>
        WorkBatch GetWorkBatchById (int? workBatchId);
  
        /// <summary>
        /// Get a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns the workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param>
        /// <returns>ApiResponse of WorkBatch</returns>
        ApiResponse<WorkBatch> GetWorkBatchByIdWithHttpInfo (int? workBatchId);
        
        /// <summary>
        /// Get the tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Get all existing workBatch tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param>
        /// <returns></returns>
        void GetWorkBatchTags (int? workBatchId);
  
        /// <summary>
        /// Get the tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Get all existing workBatch tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetWorkBatchTagsWithHttpInfo (int? workBatchId);
        
        /// <summary>
        /// Update a workBatch custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing workBatch custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param>
        /// <returns></returns>
        void UpdateWorkBatchCustomFields (WorkBatch body);
  
        /// <summary>
        /// Update a workBatch custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing workBatch custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateWorkBatchCustomFieldsWithHttpInfo (WorkBatch body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a workBatch
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param>
        /// <param name="workBatchAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddWorkBatchAuditAsync (int? workBatchId, string workBatchAudit);

        /// <summary>
        /// Add new audit for a workBatch
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param>
        /// <param name="workBatchAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddWorkBatchAuditAsyncWithHttpInfo (int? workBatchId, string workBatchAudit);
        
        /// <summary>
        /// Add new tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param>
        /// <param name="workBatchTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddWorkBatchTagAsync (int? workBatchId, string workBatchTag);

        /// <summary>
        /// Add new tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing workBatch.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param>
        /// <param name="workBatchTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddWorkBatchTagAsyncWithHttpInfo (int? workBatchId, string workBatchTag);
        
        /// <summary>
        /// Delete a tag for a workBatch.
        /// </summary>
        /// <remarks>
        /// Deletes an existing workBatch tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param>
        /// <param name="workBatchTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWorkBatchTagAsync (int? workBatchId, string workBatchTag);

        /// <summary>
        /// Delete a tag for a workBatch.
        /// </summary>
        /// <remarks>
        /// Deletes an existing workBatch tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param>
        /// <param name="workBatchTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkBatchTagAsyncWithHttpInfo (int? workBatchId, string workBatchTag);
        
        /// <summary>
        /// Get a duplicated a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param>
        /// <returns>Task of WorkBatch</returns>
        System.Threading.Tasks.Task<WorkBatch> GetDuplicateWorkBatchByIdAsync (int? workBatchId);

        /// <summary>
        /// Get a duplicated a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param>
        /// <returns>Task of ApiResponse (WorkBatch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkBatch>> GetDuplicateWorkBatchByIdAsyncWithHttpInfo (int? workBatchId);
        
        /// <summary>
        /// Search workBatchs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of workBatchs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WorkBatch&gt;</returns>
        System.Threading.Tasks.Task<List<WorkBatch>> GetWorkBatchByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search workBatchs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of workBatchs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WorkBatch&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WorkBatch>>> GetWorkBatchByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns the workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param>
        /// <returns>Task of WorkBatch</returns>
        System.Threading.Tasks.Task<WorkBatch> GetWorkBatchByIdAsync (int? workBatchId);

        /// <summary>
        /// Get a workBatch by id
        /// </summary>
        /// <remarks>
        /// Returns the workBatch identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param>
        /// <returns>Task of ApiResponse (WorkBatch)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkBatch>> GetWorkBatchByIdAsyncWithHttpInfo (int? workBatchId);
        
        /// <summary>
        /// Get the tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Get all existing workBatch tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetWorkBatchTagsAsync (int? workBatchId);

        /// <summary>
        /// Get the tags for a workBatch.
        /// </summary>
        /// <remarks>
        /// Get all existing workBatch tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetWorkBatchTagsAsyncWithHttpInfo (int? workBatchId);
        
        /// <summary>
        /// Update a workBatch custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing workBatch custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateWorkBatchCustomFieldsAsync (WorkBatch body);

        /// <summary>
        /// Update a workBatch custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing workBatch custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateWorkBatchCustomFieldsAsyncWithHttpInfo (WorkBatch body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WorkBatchApi : IWorkBatchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkBatchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkBatchApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkBatchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkBatchApi(Configuration configuration = null)
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
        /// Add new audit for a workBatch Adds an audit to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param> 
        /// <param name="workBatchAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddWorkBatchAudit (int? workBatchId, string workBatchAudit)
        {
             AddWorkBatchAuditWithHttpInfo(workBatchId, workBatchAudit);
        }

        /// <summary>
        /// Add new audit for a workBatch Adds an audit to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param> 
        /// <param name="workBatchAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddWorkBatchAuditWithHttpInfo (int? workBatchId, string workBatchAudit)
        {
            
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null)
                throw new ApiException(400, "Missing required parameter 'workBatchId' when calling WorkBatchApi->AddWorkBatchAudit");
            
            // verify the required parameter 'workBatchAudit' is set
            if (workBatchAudit == null)
                throw new ApiException(400, "Missing required parameter 'workBatchAudit' when calling WorkBatchApi->AddWorkBatchAudit");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/audit/{workBatchAudit}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            if (workBatchAudit != null) localVarPathParams.Add("workBatchAudit", Configuration.ApiClient.ParameterToString(workBatchAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a workBatch Adds an audit to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param>
        /// <param name="workBatchAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddWorkBatchAuditAsync (int? workBatchId, string workBatchAudit)
        {
             await AddWorkBatchAuditAsyncWithHttpInfo(workBatchId, workBatchAudit);

        }

        /// <summary>
        /// Add new audit for a workBatch Adds an audit to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add an audit to</param>
        /// <param name="workBatchAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddWorkBatchAuditAsyncWithHttpInfo (int? workBatchId, string workBatchAudit)
        {
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null) throw new ApiException(400, "Missing required parameter 'workBatchId' when calling AddWorkBatchAudit");
            // verify the required parameter 'workBatchAudit' is set
            if (workBatchAudit == null) throw new ApiException(400, "Missing required parameter 'workBatchAudit' when calling AddWorkBatchAudit");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/audit/{workBatchAudit}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            if (workBatchAudit != null) localVarPathParams.Add("workBatchAudit", Configuration.ApiClient.ParameterToString(workBatchAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a workBatch. Adds a tag to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param> 
        /// <param name="workBatchTag">The tag to add</param> 
        /// <returns></returns>
        public void AddWorkBatchTag (int? workBatchId, string workBatchTag)
        {
             AddWorkBatchTagWithHttpInfo(workBatchId, workBatchTag);
        }

        /// <summary>
        /// Add new tags for a workBatch. Adds a tag to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param> 
        /// <param name="workBatchTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddWorkBatchTagWithHttpInfo (int? workBatchId, string workBatchTag)
        {
            
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null)
                throw new ApiException(400, "Missing required parameter 'workBatchId' when calling WorkBatchApi->AddWorkBatchTag");
            
            // verify the required parameter 'workBatchTag' is set
            if (workBatchTag == null)
                throw new ApiException(400, "Missing required parameter 'workBatchTag' when calling WorkBatchApi->AddWorkBatchTag");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/tag/{workBatchTag}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            if (workBatchTag != null) localVarPathParams.Add("workBatchTag", Configuration.ApiClient.ParameterToString(workBatchTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a workBatch. Adds a tag to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param>
        /// <param name="workBatchTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddWorkBatchTagAsync (int? workBatchId, string workBatchTag)
        {
             await AddWorkBatchTagAsyncWithHttpInfo(workBatchId, workBatchTag);

        }

        /// <summary>
        /// Add new tags for a workBatch. Adds a tag to an existing workBatch.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to add a tag to</param>
        /// <param name="workBatchTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddWorkBatchTagAsyncWithHttpInfo (int? workBatchId, string workBatchTag)
        {
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null) throw new ApiException(400, "Missing required parameter 'workBatchId' when calling AddWorkBatchTag");
            // verify the required parameter 'workBatchTag' is set
            if (workBatchTag == null) throw new ApiException(400, "Missing required parameter 'workBatchTag' when calling AddWorkBatchTag");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/tag/{workBatchTag}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            if (workBatchTag != null) localVarPathParams.Add("workBatchTag", Configuration.ApiClient.ParameterToString(workBatchTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWorkBatchTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a workBatch. Deletes an existing workBatch tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param> 
        /// <param name="workBatchTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteWorkBatchTag (int? workBatchId, string workBatchTag)
        {
             DeleteWorkBatchTagWithHttpInfo(workBatchId, workBatchTag);
        }

        /// <summary>
        /// Delete a tag for a workBatch. Deletes an existing workBatch tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param> 
        /// <param name="workBatchTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWorkBatchTagWithHttpInfo (int? workBatchId, string workBatchTag)
        {
            
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null)
                throw new ApiException(400, "Missing required parameter 'workBatchId' when calling WorkBatchApi->DeleteWorkBatchTag");
            
            // verify the required parameter 'workBatchTag' is set
            if (workBatchTag == null)
                throw new ApiException(400, "Missing required parameter 'workBatchTag' when calling WorkBatchApi->DeleteWorkBatchTag");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/tag/{workBatchTag}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            if (workBatchTag != null) localVarPathParams.Add("workBatchTag", Configuration.ApiClient.ParameterToString(workBatchTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkBatchTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkBatchTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a workBatch. Deletes an existing workBatch tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param>
        /// <param name="workBatchTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWorkBatchTagAsync (int? workBatchId, string workBatchTag)
        {
             await DeleteWorkBatchTagAsyncWithHttpInfo(workBatchId, workBatchTag);

        }

        /// <summary>
        /// Delete a tag for a workBatch. Deletes an existing workBatch tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to remove tag from</param>
        /// <param name="workBatchTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWorkBatchTagAsyncWithHttpInfo (int? workBatchId, string workBatchTag)
        {
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null) throw new ApiException(400, "Missing required parameter 'workBatchId' when calling DeleteWorkBatchTag");
            // verify the required parameter 'workBatchTag' is set
            if (workBatchTag == null) throw new ApiException(400, "Missing required parameter 'workBatchTag' when calling DeleteWorkBatchTag");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/tag/{workBatchTag}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            if (workBatchTag != null) localVarPathParams.Add("workBatchTag", Configuration.ApiClient.ParameterToString(workBatchTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkBatchTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWorkBatchTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a workBatch by id Returns a duplicated workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param> 
        /// <returns>WorkBatch</returns>
        public WorkBatch GetDuplicateWorkBatchById (int? workBatchId)
        {
             ApiResponse<WorkBatch> localVarResponse = GetDuplicateWorkBatchByIdWithHttpInfo(workBatchId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a workBatch by id Returns a duplicated workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param> 
        /// <returns>ApiResponse of WorkBatch</returns>
        public ApiResponse< WorkBatch > GetDuplicateWorkBatchByIdWithHttpInfo (int? workBatchId)
        {
            
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null)
                throw new ApiException(400, "Missing required parameter 'workBatchId' when calling WorkBatchApi->GetDuplicateWorkBatchById");
            
    
            var localVarPath = "/beta/workBatch/duplicate/{workBatchId}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWorkBatchById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWorkBatchById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WorkBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkBatch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkBatch)));
            
        }

        
        /// <summary>
        /// Get a duplicated a workBatch by id Returns a duplicated workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param>
        /// <returns>Task of WorkBatch</returns>
        public async System.Threading.Tasks.Task<WorkBatch> GetDuplicateWorkBatchByIdAsync (int? workBatchId)
        {
             ApiResponse<WorkBatch> localVarResponse = await GetDuplicateWorkBatchByIdAsyncWithHttpInfo(workBatchId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a workBatch by id Returns a duplicated workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be duplicated.</param>
        /// <returns>Task of ApiResponse (WorkBatch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkBatch>> GetDuplicateWorkBatchByIdAsyncWithHttpInfo (int? workBatchId)
        {
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null) throw new ApiException(400, "Missing required parameter 'workBatchId' when calling GetDuplicateWorkBatchById");
            
    
            var localVarPath = "/beta/workBatch/duplicate/{workBatchId}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWorkBatchById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWorkBatchById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkBatch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkBatch)));
            
        }
        
        /// <summary>
        /// Search workBatchs by filter Returns the list of workBatchs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;WorkBatch&gt;</returns>
        public List<WorkBatch> GetWorkBatchByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WorkBatch>> localVarResponse = GetWorkBatchByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search workBatchs by filter Returns the list of workBatchs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;WorkBatch&gt;</returns>
        public ApiResponse< List<WorkBatch> > GetWorkBatchByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/workBatch/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WorkBatch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WorkBatch>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WorkBatch>)));
            
        }

        
        /// <summary>
        /// Search workBatchs by filter Returns the list of workBatchs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WorkBatch&gt;</returns>
        public async System.Threading.Tasks.Task<List<WorkBatch>> GetWorkBatchByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WorkBatch>> localVarResponse = await GetWorkBatchByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search workBatchs by filter Returns the list of workBatchs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WorkBatch&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WorkBatch>>> GetWorkBatchByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/workBatch/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WorkBatch>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WorkBatch>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WorkBatch>)));
            
        }
        
        /// <summary>
        /// Get a workBatch by id Returns the workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param> 
        /// <returns>WorkBatch</returns>
        public WorkBatch GetWorkBatchById (int? workBatchId)
        {
             ApiResponse<WorkBatch> localVarResponse = GetWorkBatchByIdWithHttpInfo(workBatchId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a workBatch by id Returns the workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param> 
        /// <returns>ApiResponse of WorkBatch</returns>
        public ApiResponse< WorkBatch > GetWorkBatchByIdWithHttpInfo (int? workBatchId)
        {
            
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null)
                throw new ApiException(400, "Missing required parameter 'workBatchId' when calling WorkBatchApi->GetWorkBatchById");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WorkBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkBatch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkBatch)));
            
        }

        
        /// <summary>
        /// Get a workBatch by id Returns the workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param>
        /// <returns>Task of WorkBatch</returns>
        public async System.Threading.Tasks.Task<WorkBatch> GetWorkBatchByIdAsync (int? workBatchId)
        {
             ApiResponse<WorkBatch> localVarResponse = await GetWorkBatchByIdAsyncWithHttpInfo(workBatchId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a workBatch by id Returns the workBatch identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to be returned.</param>
        /// <returns>Task of ApiResponse (WorkBatch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkBatch>> GetWorkBatchByIdAsyncWithHttpInfo (int? workBatchId)
        {
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null) throw new ApiException(400, "Missing required parameter 'workBatchId' when calling GetWorkBatchById");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkBatch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkBatch)));
            
        }
        
        /// <summary>
        /// Get the tags for a workBatch. Get all existing workBatch tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param> 
        /// <returns></returns>
        public void GetWorkBatchTags (int? workBatchId)
        {
             GetWorkBatchTagsWithHttpInfo(workBatchId);
        }

        /// <summary>
        /// Get the tags for a workBatch. Get all existing workBatch tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetWorkBatchTagsWithHttpInfo (int? workBatchId)
        {
            
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null)
                throw new ApiException(400, "Missing required parameter 'workBatchId' when calling WorkBatchApi->GetWorkBatchTags");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/tag";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a workBatch. Get all existing workBatch tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetWorkBatchTagsAsync (int? workBatchId)
        {
             await GetWorkBatchTagsAsyncWithHttpInfo(workBatchId);

        }

        /// <summary>
        /// Get the tags for a workBatch. Get all existing workBatch tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workBatchId">Id of the workBatch to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetWorkBatchTagsAsyncWithHttpInfo (int? workBatchId)
        {
            // verify the required parameter 'workBatchId' is set
            if (workBatchId == null) throw new ApiException(400, "Missing required parameter 'workBatchId' when calling GetWorkBatchTags");
            
    
            var localVarPath = "/beta/workBatch/{workBatchId}/tag";
    
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
            if (workBatchId != null) localVarPathParams.Add("workBatchId", Configuration.ApiClient.ParameterToString(workBatchId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWorkBatchTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a workBatch custom fields Updates an existing workBatch custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param> 
        /// <returns></returns>
        public void UpdateWorkBatchCustomFields (WorkBatch body)
        {
             UpdateWorkBatchCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a workBatch custom fields Updates an existing workBatch custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateWorkBatchCustomFieldsWithHttpInfo (WorkBatch body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WorkBatchApi->UpdateWorkBatchCustomFields");
            
    
            var localVarPath = "/beta/workBatch/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWorkBatchCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWorkBatchCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a workBatch custom fields Updates an existing workBatch custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateWorkBatchCustomFieldsAsync (WorkBatch body)
        {
             await UpdateWorkBatchCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a workBatch custom fields Updates an existing workBatch custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WorkBatch to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateWorkBatchCustomFieldsAsyncWithHttpInfo (WorkBatch body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateWorkBatchCustomFields");
            
    
            var localVarPath = "/beta/workBatch/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWorkBatchCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWorkBatchCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
