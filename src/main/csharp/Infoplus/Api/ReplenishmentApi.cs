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
    public interface IReplenishmentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a replenishment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param>
        /// <param name="replenishmentAudit">The audit to add</param>
        /// <returns></returns>
        void AddReplenishmentAudit (int? replenishmentId, string replenishmentAudit);
  
        /// <summary>
        /// Add new audit for a replenishment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param>
        /// <param name="replenishmentAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReplenishmentAuditWithHttpInfo (int? replenishmentId, string replenishmentAudit);
        
        /// <summary>
        /// Add new tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param>
        /// <param name="replenishmentTag">The tag to add</param>
        /// <returns></returns>
        void AddReplenishmentTag (int? replenishmentId, string replenishmentTag);
  
        /// <summary>
        /// Add new tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param>
        /// <param name="replenishmentTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReplenishmentTagWithHttpInfo (int? replenishmentId, string replenishmentTag);
        
        /// <summary>
        /// Delete a tag for a replenishment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param>
        /// <param name="replenishmentTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteReplenishmentTag (int? replenishmentId, string replenishmentTag);
  
        /// <summary>
        /// Delete a tag for a replenishment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param>
        /// <param name="replenishmentTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteReplenishmentTagWithHttpInfo (int? replenishmentId, string replenishmentTag);
        
        /// <summary>
        /// Get a duplicated a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param>
        /// <returns>Replenishment</returns>
        Replenishment GetDuplicateReplenishmentById (int? replenishmentId);
  
        /// <summary>
        /// Get a duplicated a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param>
        /// <returns>ApiResponse of Replenishment</returns>
        ApiResponse<Replenishment> GetDuplicateReplenishmentByIdWithHttpInfo (int? replenishmentId);
        
        /// <summary>
        /// Search replenishments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;Replenishment&gt;</returns>
        List<Replenishment> GetReplenishmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search replenishments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;Replenishment&gt;</returns>
        ApiResponse<List<Replenishment>> GetReplenishmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param>
        /// <returns>Replenishment</returns>
        Replenishment GetReplenishmentById (int? replenishmentId);
  
        /// <summary>
        /// Get a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param>
        /// <returns>ApiResponse of Replenishment</returns>
        ApiResponse<Replenishment> GetReplenishmentByIdWithHttpInfo (int? replenishmentId);
        
        /// <summary>
        /// Get the tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param>
        /// <returns></returns>
        void GetReplenishmentTags (int? replenishmentId);
  
        /// <summary>
        /// Get the tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetReplenishmentTagsWithHttpInfo (int? replenishmentId);
        
        /// <summary>
        /// Update a replenishment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param>
        /// <returns></returns>
        void UpdateReplenishmentCustomFields (Replenishment body);
  
        /// <summary>
        /// Update a replenishment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateReplenishmentCustomFieldsWithHttpInfo (Replenishment body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a replenishment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param>
        /// <param name="replenishmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReplenishmentAuditAsync (int? replenishmentId, string replenishmentAudit);

        /// <summary>
        /// Add new audit for a replenishment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param>
        /// <param name="replenishmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentAuditAsyncWithHttpInfo (int? replenishmentId, string replenishmentAudit);
        
        /// <summary>
        /// Add new tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param>
        /// <param name="replenishmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReplenishmentTagAsync (int? replenishmentId, string replenishmentTag);

        /// <summary>
        /// Add new tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param>
        /// <param name="replenishmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentTagAsyncWithHttpInfo (int? replenishmentId, string replenishmentTag);
        
        /// <summary>
        /// Delete a tag for a replenishment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param>
        /// <param name="replenishmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteReplenishmentTagAsync (int? replenishmentId, string replenishmentTag);

        /// <summary>
        /// Delete a tag for a replenishment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param>
        /// <param name="replenishmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReplenishmentTagAsyncWithHttpInfo (int? replenishmentId, string replenishmentTag);
        
        /// <summary>
        /// Get a duplicated a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param>
        /// <returns>Task of Replenishment</returns>
        System.Threading.Tasks.Task<Replenishment> GetDuplicateReplenishmentByIdAsync (int? replenishmentId);

        /// <summary>
        /// Get a duplicated a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param>
        /// <returns>Task of ApiResponse (Replenishment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Replenishment>> GetDuplicateReplenishmentByIdAsyncWithHttpInfo (int? replenishmentId);
        
        /// <summary>
        /// Search replenishments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;Replenishment&gt;</returns>
        System.Threading.Tasks.Task<List<Replenishment>> GetReplenishmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search replenishments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Replenishment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Replenishment>>> GetReplenishmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param>
        /// <returns>Task of Replenishment</returns>
        System.Threading.Tasks.Task<Replenishment> GetReplenishmentByIdAsync (int? replenishmentId);

        /// <summary>
        /// Get a replenishment by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param>
        /// <returns>Task of ApiResponse (Replenishment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Replenishment>> GetReplenishmentByIdAsyncWithHttpInfo (int? replenishmentId);
        
        /// <summary>
        /// Get the tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetReplenishmentTagsAsync (int? replenishmentId);

        /// <summary>
        /// Get the tags for a replenishment.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetReplenishmentTagsAsyncWithHttpInfo (int? replenishmentId);
        
        /// <summary>
        /// Update a replenishment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateReplenishmentCustomFieldsAsync (Replenishment body);

        /// <summary>
        /// Update a replenishment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReplenishmentCustomFieldsAsyncWithHttpInfo (Replenishment body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReplenishmentApi : IReplenishmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplenishmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReplenishmentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplenishmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReplenishmentApi(Configuration configuration = null)
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
        /// Add new audit for a replenishment Adds an audit to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param> 
        /// <param name="replenishmentAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddReplenishmentAudit (int? replenishmentId, string replenishmentAudit)
        {
             AddReplenishmentAuditWithHttpInfo(replenishmentId, replenishmentAudit);
        }

        /// <summary>
        /// Add new audit for a replenishment Adds an audit to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param> 
        /// <param name="replenishmentAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReplenishmentAuditWithHttpInfo (int? replenishmentId, string replenishmentAudit)
        {
            
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling ReplenishmentApi->AddReplenishmentAudit");
            
            // verify the required parameter 'replenishmentAudit' is set
            if (replenishmentAudit == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentAudit' when calling ReplenishmentApi->AddReplenishmentAudit");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/audit/{replenishmentAudit}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            if (replenishmentAudit != null) localVarPathParams.Add("replenishmentAudit", Configuration.ApiClient.ParameterToString(replenishmentAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a replenishment Adds an audit to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param>
        /// <param name="replenishmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReplenishmentAuditAsync (int? replenishmentId, string replenishmentAudit)
        {
             await AddReplenishmentAuditAsyncWithHttpInfo(replenishmentId, replenishmentAudit);

        }

        /// <summary>
        /// Add new audit for a replenishment Adds an audit to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add an audit to</param>
        /// <param name="replenishmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentAuditAsyncWithHttpInfo (int? replenishmentId, string replenishmentAudit)
        {
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null) throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling AddReplenishmentAudit");
            // verify the required parameter 'replenishmentAudit' is set
            if (replenishmentAudit == null) throw new ApiException(400, "Missing required parameter 'replenishmentAudit' when calling AddReplenishmentAudit");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/audit/{replenishmentAudit}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            if (replenishmentAudit != null) localVarPathParams.Add("replenishmentAudit", Configuration.ApiClient.ParameterToString(replenishmentAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a replenishment. Adds a tag to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param> 
        /// <param name="replenishmentTag">The tag to add</param> 
        /// <returns></returns>
        public void AddReplenishmentTag (int? replenishmentId, string replenishmentTag)
        {
             AddReplenishmentTagWithHttpInfo(replenishmentId, replenishmentTag);
        }

        /// <summary>
        /// Add new tags for a replenishment. Adds a tag to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param> 
        /// <param name="replenishmentTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReplenishmentTagWithHttpInfo (int? replenishmentId, string replenishmentTag)
        {
            
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling ReplenishmentApi->AddReplenishmentTag");
            
            // verify the required parameter 'replenishmentTag' is set
            if (replenishmentTag == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentTag' when calling ReplenishmentApi->AddReplenishmentTag");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/tag/{replenishmentTag}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            if (replenishmentTag != null) localVarPathParams.Add("replenishmentTag", Configuration.ApiClient.ParameterToString(replenishmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a replenishment. Adds a tag to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param>
        /// <param name="replenishmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReplenishmentTagAsync (int? replenishmentId, string replenishmentTag)
        {
             await AddReplenishmentTagAsyncWithHttpInfo(replenishmentId, replenishmentTag);

        }

        /// <summary>
        /// Add new tags for a replenishment. Adds a tag to an existing replenishment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to add a tag to</param>
        /// <param name="replenishmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentTagAsyncWithHttpInfo (int? replenishmentId, string replenishmentTag)
        {
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null) throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling AddReplenishmentTag");
            // verify the required parameter 'replenishmentTag' is set
            if (replenishmentTag == null) throw new ApiException(400, "Missing required parameter 'replenishmentTag' when calling AddReplenishmentTag");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/tag/{replenishmentTag}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            if (replenishmentTag != null) localVarPathParams.Add("replenishmentTag", Configuration.ApiClient.ParameterToString(replenishmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a replenishment. Deletes an existing replenishment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param> 
        /// <param name="replenishmentTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteReplenishmentTag (int? replenishmentId, string replenishmentTag)
        {
             DeleteReplenishmentTagWithHttpInfo(replenishmentId, replenishmentTag);
        }

        /// <summary>
        /// Delete a tag for a replenishment. Deletes an existing replenishment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param> 
        /// <param name="replenishmentTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteReplenishmentTagWithHttpInfo (int? replenishmentId, string replenishmentTag)
        {
            
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling ReplenishmentApi->DeleteReplenishmentTag");
            
            // verify the required parameter 'replenishmentTag' is set
            if (replenishmentTag == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentTag' when calling ReplenishmentApi->DeleteReplenishmentTag");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/tag/{replenishmentTag}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            if (replenishmentTag != null) localVarPathParams.Add("replenishmentTag", Configuration.ApiClient.ParameterToString(replenishmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a replenishment. Deletes an existing replenishment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param>
        /// <param name="replenishmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteReplenishmentTagAsync (int? replenishmentId, string replenishmentTag)
        {
             await DeleteReplenishmentTagAsyncWithHttpInfo(replenishmentId, replenishmentTag);

        }

        /// <summary>
        /// Delete a tag for a replenishment. Deletes an existing replenishment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to remove tag from</param>
        /// <param name="replenishmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReplenishmentTagAsyncWithHttpInfo (int? replenishmentId, string replenishmentTag)
        {
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null) throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling DeleteReplenishmentTag");
            // verify the required parameter 'replenishmentTag' is set
            if (replenishmentTag == null) throw new ApiException(400, "Missing required parameter 'replenishmentTag' when calling DeleteReplenishmentTag");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/tag/{replenishmentTag}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            if (replenishmentTag != null) localVarPathParams.Add("replenishmentTag", Configuration.ApiClient.ParameterToString(replenishmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a replenishment by id Returns a duplicated replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param> 
        /// <returns>Replenishment</returns>
        public Replenishment GetDuplicateReplenishmentById (int? replenishmentId)
        {
             ApiResponse<Replenishment> localVarResponse = GetDuplicateReplenishmentByIdWithHttpInfo(replenishmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a replenishment by id Returns a duplicated replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param> 
        /// <returns>ApiResponse of Replenishment</returns>
        public ApiResponse< Replenishment > GetDuplicateReplenishmentByIdWithHttpInfo (int? replenishmentId)
        {
            
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling ReplenishmentApi->GetDuplicateReplenishmentById");
            
    
            var localVarPath = "/beta/replenishment/duplicate/{replenishmentId}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Replenishment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Replenishment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Replenishment)));
            
        }

        
        /// <summary>
        /// Get a duplicated a replenishment by id Returns a duplicated replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param>
        /// <returns>Task of Replenishment</returns>
        public async System.Threading.Tasks.Task<Replenishment> GetDuplicateReplenishmentByIdAsync (int? replenishmentId)
        {
             ApiResponse<Replenishment> localVarResponse = await GetDuplicateReplenishmentByIdAsyncWithHttpInfo(replenishmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a replenishment by id Returns a duplicated replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be duplicated.</param>
        /// <returns>Task of ApiResponse (Replenishment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Replenishment>> GetDuplicateReplenishmentByIdAsyncWithHttpInfo (int? replenishmentId)
        {
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null) throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling GetDuplicateReplenishmentById");
            
    
            var localVarPath = "/beta/replenishment/duplicate/{replenishmentId}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Replenishment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Replenishment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Replenishment)));
            
        }
        
        /// <summary>
        /// Search replenishments by filter Returns the list of replenishments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;Replenishment&gt;</returns>
        public List<Replenishment> GetReplenishmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<Replenishment>> localVarResponse = GetReplenishmentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search replenishments by filter Returns the list of replenishments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;Replenishment&gt;</returns>
        public ApiResponse< List<Replenishment> > GetReplenishmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/replenishment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Replenishment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Replenishment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Replenishment>)));
            
        }

        
        /// <summary>
        /// Search replenishments by filter Returns the list of replenishments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;Replenishment&gt;</returns>
        public async System.Threading.Tasks.Task<List<Replenishment>> GetReplenishmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<Replenishment>> localVarResponse = await GetReplenishmentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search replenishments by filter Returns the list of replenishments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Replenishment&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Replenishment>>> GetReplenishmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/replenishment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Replenishment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Replenishment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Replenishment>)));
            
        }
        
        /// <summary>
        /// Get a replenishment by id Returns the replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param> 
        /// <returns>Replenishment</returns>
        public Replenishment GetReplenishmentById (int? replenishmentId)
        {
             ApiResponse<Replenishment> localVarResponse = GetReplenishmentByIdWithHttpInfo(replenishmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a replenishment by id Returns the replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param> 
        /// <returns>ApiResponse of Replenishment</returns>
        public ApiResponse< Replenishment > GetReplenishmentByIdWithHttpInfo (int? replenishmentId)
        {
            
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling ReplenishmentApi->GetReplenishmentById");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Replenishment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Replenishment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Replenishment)));
            
        }

        
        /// <summary>
        /// Get a replenishment by id Returns the replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param>
        /// <returns>Task of Replenishment</returns>
        public async System.Threading.Tasks.Task<Replenishment> GetReplenishmentByIdAsync (int? replenishmentId)
        {
             ApiResponse<Replenishment> localVarResponse = await GetReplenishmentByIdAsyncWithHttpInfo(replenishmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a replenishment by id Returns the replenishment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to be returned.</param>
        /// <returns>Task of ApiResponse (Replenishment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Replenishment>> GetReplenishmentByIdAsyncWithHttpInfo (int? replenishmentId)
        {
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null) throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling GetReplenishmentById");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Replenishment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Replenishment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Replenishment)));
            
        }
        
        /// <summary>
        /// Get the tags for a replenishment. Get all existing replenishment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param> 
        /// <returns></returns>
        public void GetReplenishmentTags (int? replenishmentId)
        {
             GetReplenishmentTagsWithHttpInfo(replenishmentId);
        }

        /// <summary>
        /// Get the tags for a replenishment. Get all existing replenishment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetReplenishmentTagsWithHttpInfo (int? replenishmentId)
        {
            
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling ReplenishmentApi->GetReplenishmentTags");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/tag";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a replenishment. Get all existing replenishment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetReplenishmentTagsAsync (int? replenishmentId)
        {
             await GetReplenishmentTagsAsyncWithHttpInfo(replenishmentId);

        }

        /// <summary>
        /// Get the tags for a replenishment. Get all existing replenishment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentId">Id of the replenishment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetReplenishmentTagsAsyncWithHttpInfo (int? replenishmentId)
        {
            // verify the required parameter 'replenishmentId' is set
            if (replenishmentId == null) throw new ApiException(400, "Missing required parameter 'replenishmentId' when calling GetReplenishmentTags");
            
    
            var localVarPath = "/beta/replenishment/{replenishmentId}/tag";
    
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
            if (replenishmentId != null) localVarPathParams.Add("replenishmentId", Configuration.ApiClient.ParameterToString(replenishmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a replenishment custom fields Updates an existing replenishment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param> 
        /// <returns></returns>
        public void UpdateReplenishmentCustomFields (Replenishment body)
        {
             UpdateReplenishmentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a replenishment custom fields Updates an existing replenishment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateReplenishmentCustomFieldsWithHttpInfo (Replenishment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReplenishmentApi->UpdateReplenishmentCustomFields");
            
    
            var localVarPath = "/beta/replenishment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a replenishment custom fields Updates an existing replenishment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateReplenishmentCustomFieldsAsync (Replenishment body)
        {
             await UpdateReplenishmentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a replenishment custom fields Updates an existing replenishment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Replenishment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReplenishmentCustomFieldsAsyncWithHttpInfo (Replenishment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateReplenishmentCustomFields");
            
    
            var localVarPath = "/beta/replenishment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
