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
    public interface IBusinessTransactionApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a businessTransaction
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param>
        /// <param name="businessTransactionAudit">The audit to add</param>
        /// <returns></returns>
        void AddBusinessTransactionAudit (int? businessTransactionId, string businessTransactionAudit);
  
        /// <summary>
        /// Add new audit for a businessTransaction
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param>
        /// <param name="businessTransactionAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBusinessTransactionAuditWithHttpInfo (int? businessTransactionId, string businessTransactionAudit);
        
        /// <summary>
        /// Add new tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param>
        /// <param name="businessTransactionTag">The tag to add</param>
        /// <returns></returns>
        void AddBusinessTransactionTag (int? businessTransactionId, string businessTransactionTag);
  
        /// <summary>
        /// Add new tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param>
        /// <param name="businessTransactionTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBusinessTransactionTagWithHttpInfo (int? businessTransactionId, string businessTransactionTag);
        
        /// <summary>
        /// Delete a tag for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Deletes an existing businessTransaction tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param>
        /// <param name="businessTransactionTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteBusinessTransactionTag (int? businessTransactionId, string businessTransactionTag);
  
        /// <summary>
        /// Delete a tag for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Deletes an existing businessTransaction tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param>
        /// <param name="businessTransactionTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBusinessTransactionTagWithHttpInfo (int? businessTransactionId, string businessTransactionTag);
        
        /// <summary>
        /// Search businessTransactions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of businessTransactions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;BusinessTransaction&gt;</returns>
        List<BusinessTransaction> GetBusinessTransactionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search businessTransactions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of businessTransactions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;BusinessTransaction&gt;</returns>
        ApiResponse<List<BusinessTransaction>> GetBusinessTransactionByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns the businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param>
        /// <returns>BusinessTransaction</returns>
        BusinessTransaction GetBusinessTransactionById (int? businessTransactionId);
  
        /// <summary>
        /// Get a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns the businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param>
        /// <returns>ApiResponse of BusinessTransaction</returns>
        ApiResponse<BusinessTransaction> GetBusinessTransactionByIdWithHttpInfo (int? businessTransactionId);
        
        /// <summary>
        /// Get the tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Get all existing businessTransaction tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param>
        /// <returns></returns>
        void GetBusinessTransactionTags (int? businessTransactionId);
  
        /// <summary>
        /// Get the tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Get all existing businessTransaction tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBusinessTransactionTagsWithHttpInfo (int? businessTransactionId);
        
        /// <summary>
        /// Get a duplicated a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param>
        /// <returns>BusinessTransaction</returns>
        BusinessTransaction GetDuplicateBusinessTransactionById (int? businessTransactionId);
  
        /// <summary>
        /// Get a duplicated a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param>
        /// <returns>ApiResponse of BusinessTransaction</returns>
        ApiResponse<BusinessTransaction> GetDuplicateBusinessTransactionByIdWithHttpInfo (int? businessTransactionId);
        
        /// <summary>
        /// Update a businessTransaction custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing businessTransaction custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param>
        /// <returns></returns>
        void UpdateBusinessTransactionCustomFields (BusinessTransaction body);
  
        /// <summary>
        /// Update a businessTransaction custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing businessTransaction custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateBusinessTransactionCustomFieldsWithHttpInfo (BusinessTransaction body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a businessTransaction
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param>
        /// <param name="businessTransactionAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBusinessTransactionAuditAsync (int? businessTransactionId, string businessTransactionAudit);

        /// <summary>
        /// Add new audit for a businessTransaction
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param>
        /// <param name="businessTransactionAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBusinessTransactionAuditAsyncWithHttpInfo (int? businessTransactionId, string businessTransactionAudit);
        
        /// <summary>
        /// Add new tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param>
        /// <param name="businessTransactionTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBusinessTransactionTagAsync (int? businessTransactionId, string businessTransactionTag);

        /// <summary>
        /// Add new tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing businessTransaction.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param>
        /// <param name="businessTransactionTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBusinessTransactionTagAsyncWithHttpInfo (int? businessTransactionId, string businessTransactionTag);
        
        /// <summary>
        /// Delete a tag for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Deletes an existing businessTransaction tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param>
        /// <param name="businessTransactionTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBusinessTransactionTagAsync (int? businessTransactionId, string businessTransactionTag);

        /// <summary>
        /// Delete a tag for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Deletes an existing businessTransaction tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param>
        /// <param name="businessTransactionTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessTransactionTagAsyncWithHttpInfo (int? businessTransactionId, string businessTransactionTag);
        
        /// <summary>
        /// Search businessTransactions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of businessTransactions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BusinessTransaction&gt;</returns>
        System.Threading.Tasks.Task<List<BusinessTransaction>> GetBusinessTransactionByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search businessTransactions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of businessTransactions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BusinessTransaction&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BusinessTransaction>>> GetBusinessTransactionByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns the businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param>
        /// <returns>Task of BusinessTransaction</returns>
        System.Threading.Tasks.Task<BusinessTransaction> GetBusinessTransactionByIdAsync (int? businessTransactionId);

        /// <summary>
        /// Get a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns the businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param>
        /// <returns>Task of ApiResponse (BusinessTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<BusinessTransaction>> GetBusinessTransactionByIdAsyncWithHttpInfo (int? businessTransactionId);
        
        /// <summary>
        /// Get the tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Get all existing businessTransaction tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBusinessTransactionTagsAsync (int? businessTransactionId);

        /// <summary>
        /// Get the tags for a businessTransaction.
        /// </summary>
        /// <remarks>
        /// Get all existing businessTransaction tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBusinessTransactionTagsAsyncWithHttpInfo (int? businessTransactionId);
        
        /// <summary>
        /// Get a duplicated a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param>
        /// <returns>Task of BusinessTransaction</returns>
        System.Threading.Tasks.Task<BusinessTransaction> GetDuplicateBusinessTransactionByIdAsync (int? businessTransactionId);

        /// <summary>
        /// Get a duplicated a businessTransaction by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated businessTransaction identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param>
        /// <returns>Task of ApiResponse (BusinessTransaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<BusinessTransaction>> GetDuplicateBusinessTransactionByIdAsyncWithHttpInfo (int? businessTransactionId);
        
        /// <summary>
        /// Update a businessTransaction custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing businessTransaction custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateBusinessTransactionCustomFieldsAsync (BusinessTransaction body);

        /// <summary>
        /// Update a businessTransaction custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing businessTransaction custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBusinessTransactionCustomFieldsAsyncWithHttpInfo (BusinessTransaction body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BusinessTransactionApi : IBusinessTransactionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessTransactionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BusinessTransactionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessTransactionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BusinessTransactionApi(Configuration configuration = null)
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
        /// Add new audit for a businessTransaction Adds an audit to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param> 
        /// <param name="businessTransactionAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddBusinessTransactionAudit (int? businessTransactionId, string businessTransactionAudit)
        {
             AddBusinessTransactionAuditWithHttpInfo(businessTransactionId, businessTransactionAudit);
        }

        /// <summary>
        /// Add new audit for a businessTransaction Adds an audit to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param> 
        /// <param name="businessTransactionAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBusinessTransactionAuditWithHttpInfo (int? businessTransactionId, string businessTransactionAudit)
        {
            
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling BusinessTransactionApi->AddBusinessTransactionAudit");
            
            // verify the required parameter 'businessTransactionAudit' is set
            if (businessTransactionAudit == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionAudit' when calling BusinessTransactionApi->AddBusinessTransactionAudit");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/audit/{businessTransactionAudit}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            if (businessTransactionAudit != null) localVarPathParams.Add("businessTransactionAudit", Configuration.ApiClient.ParameterToString(businessTransactionAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a businessTransaction Adds an audit to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param>
        /// <param name="businessTransactionAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBusinessTransactionAuditAsync (int? businessTransactionId, string businessTransactionAudit)
        {
             await AddBusinessTransactionAuditAsyncWithHttpInfo(businessTransactionId, businessTransactionAudit);

        }

        /// <summary>
        /// Add new audit for a businessTransaction Adds an audit to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add an audit to</param>
        /// <param name="businessTransactionAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBusinessTransactionAuditAsyncWithHttpInfo (int? businessTransactionId, string businessTransactionAudit)
        {
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null) throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling AddBusinessTransactionAudit");
            // verify the required parameter 'businessTransactionAudit' is set
            if (businessTransactionAudit == null) throw new ApiException(400, "Missing required parameter 'businessTransactionAudit' when calling AddBusinessTransactionAudit");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/audit/{businessTransactionAudit}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            if (businessTransactionAudit != null) localVarPathParams.Add("businessTransactionAudit", Configuration.ApiClient.ParameterToString(businessTransactionAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a businessTransaction. Adds a tag to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param> 
        /// <param name="businessTransactionTag">The tag to add</param> 
        /// <returns></returns>
        public void AddBusinessTransactionTag (int? businessTransactionId, string businessTransactionTag)
        {
             AddBusinessTransactionTagWithHttpInfo(businessTransactionId, businessTransactionTag);
        }

        /// <summary>
        /// Add new tags for a businessTransaction. Adds a tag to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param> 
        /// <param name="businessTransactionTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBusinessTransactionTagWithHttpInfo (int? businessTransactionId, string businessTransactionTag)
        {
            
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling BusinessTransactionApi->AddBusinessTransactionTag");
            
            // verify the required parameter 'businessTransactionTag' is set
            if (businessTransactionTag == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionTag' when calling BusinessTransactionApi->AddBusinessTransactionTag");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/tag/{businessTransactionTag}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            if (businessTransactionTag != null) localVarPathParams.Add("businessTransactionTag", Configuration.ApiClient.ParameterToString(businessTransactionTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a businessTransaction. Adds a tag to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param>
        /// <param name="businessTransactionTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBusinessTransactionTagAsync (int? businessTransactionId, string businessTransactionTag)
        {
             await AddBusinessTransactionTagAsyncWithHttpInfo(businessTransactionId, businessTransactionTag);

        }

        /// <summary>
        /// Add new tags for a businessTransaction. Adds a tag to an existing businessTransaction.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to add a tag to</param>
        /// <param name="businessTransactionTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBusinessTransactionTagAsyncWithHttpInfo (int? businessTransactionId, string businessTransactionTag)
        {
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null) throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling AddBusinessTransactionTag");
            // verify the required parameter 'businessTransactionTag' is set
            if (businessTransactionTag == null) throw new ApiException(400, "Missing required parameter 'businessTransactionTag' when calling AddBusinessTransactionTag");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/tag/{businessTransactionTag}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            if (businessTransactionTag != null) localVarPathParams.Add("businessTransactionTag", Configuration.ApiClient.ParameterToString(businessTransactionTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBusinessTransactionTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a businessTransaction. Deletes an existing businessTransaction tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param> 
        /// <param name="businessTransactionTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteBusinessTransactionTag (int? businessTransactionId, string businessTransactionTag)
        {
             DeleteBusinessTransactionTagWithHttpInfo(businessTransactionId, businessTransactionTag);
        }

        /// <summary>
        /// Delete a tag for a businessTransaction. Deletes an existing businessTransaction tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param> 
        /// <param name="businessTransactionTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBusinessTransactionTagWithHttpInfo (int? businessTransactionId, string businessTransactionTag)
        {
            
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling BusinessTransactionApi->DeleteBusinessTransactionTag");
            
            // verify the required parameter 'businessTransactionTag' is set
            if (businessTransactionTag == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionTag' when calling BusinessTransactionApi->DeleteBusinessTransactionTag");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/tag/{businessTransactionTag}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            if (businessTransactionTag != null) localVarPathParams.Add("businessTransactionTag", Configuration.ApiClient.ParameterToString(businessTransactionTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBusinessTransactionTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBusinessTransactionTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a businessTransaction. Deletes an existing businessTransaction tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param>
        /// <param name="businessTransactionTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBusinessTransactionTagAsync (int? businessTransactionId, string businessTransactionTag)
        {
             await DeleteBusinessTransactionTagAsyncWithHttpInfo(businessTransactionId, businessTransactionTag);

        }

        /// <summary>
        /// Delete a tag for a businessTransaction. Deletes an existing businessTransaction tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to remove tag from</param>
        /// <param name="businessTransactionTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBusinessTransactionTagAsyncWithHttpInfo (int? businessTransactionId, string businessTransactionTag)
        {
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null) throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling DeleteBusinessTransactionTag");
            // verify the required parameter 'businessTransactionTag' is set
            if (businessTransactionTag == null) throw new ApiException(400, "Missing required parameter 'businessTransactionTag' when calling DeleteBusinessTransactionTag");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/tag/{businessTransactionTag}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            if (businessTransactionTag != null) localVarPathParams.Add("businessTransactionTag", Configuration.ApiClient.ParameterToString(businessTransactionTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBusinessTransactionTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBusinessTransactionTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search businessTransactions by filter Returns the list of businessTransactions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;BusinessTransaction&gt;</returns>
        public List<BusinessTransaction> GetBusinessTransactionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BusinessTransaction>> localVarResponse = GetBusinessTransactionByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search businessTransactions by filter Returns the list of businessTransactions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;BusinessTransaction&gt;</returns>
        public ApiResponse< List<BusinessTransaction> > GetBusinessTransactionByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/businessTransaction/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<BusinessTransaction>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessTransaction>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessTransaction>)));
            
        }

        
        /// <summary>
        /// Search businessTransactions by filter Returns the list of businessTransactions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BusinessTransaction&gt;</returns>
        public async System.Threading.Tasks.Task<List<BusinessTransaction>> GetBusinessTransactionByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BusinessTransaction>> localVarResponse = await GetBusinessTransactionByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search businessTransactions by filter Returns the list of businessTransactions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BusinessTransaction&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BusinessTransaction>>> GetBusinessTransactionByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/businessTransaction/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<BusinessTransaction>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BusinessTransaction>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BusinessTransaction>)));
            
        }
        
        /// <summary>
        /// Get a businessTransaction by id Returns the businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param> 
        /// <returns>BusinessTransaction</returns>
        public BusinessTransaction GetBusinessTransactionById (int? businessTransactionId)
        {
             ApiResponse<BusinessTransaction> localVarResponse = GetBusinessTransactionByIdWithHttpInfo(businessTransactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a businessTransaction by id Returns the businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param> 
        /// <returns>ApiResponse of BusinessTransaction</returns>
        public ApiResponse< BusinessTransaction > GetBusinessTransactionByIdWithHttpInfo (int? businessTransactionId)
        {
            
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling BusinessTransactionApi->GetBusinessTransactionById");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BusinessTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BusinessTransaction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessTransaction)));
            
        }

        
        /// <summary>
        /// Get a businessTransaction by id Returns the businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param>
        /// <returns>Task of BusinessTransaction</returns>
        public async System.Threading.Tasks.Task<BusinessTransaction> GetBusinessTransactionByIdAsync (int? businessTransactionId)
        {
             ApiResponse<BusinessTransaction> localVarResponse = await GetBusinessTransactionByIdAsyncWithHttpInfo(businessTransactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a businessTransaction by id Returns the businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be returned.</param>
        /// <returns>Task of ApiResponse (BusinessTransaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BusinessTransaction>> GetBusinessTransactionByIdAsyncWithHttpInfo (int? businessTransactionId)
        {
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null) throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling GetBusinessTransactionById");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BusinessTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BusinessTransaction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessTransaction)));
            
        }
        
        /// <summary>
        /// Get the tags for a businessTransaction. Get all existing businessTransaction tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param> 
        /// <returns></returns>
        public void GetBusinessTransactionTags (int? businessTransactionId)
        {
             GetBusinessTransactionTagsWithHttpInfo(businessTransactionId);
        }

        /// <summary>
        /// Get the tags for a businessTransaction. Get all existing businessTransaction tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetBusinessTransactionTagsWithHttpInfo (int? businessTransactionId)
        {
            
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling BusinessTransactionApi->GetBusinessTransactionTags");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/tag";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a businessTransaction. Get all existing businessTransaction tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetBusinessTransactionTagsAsync (int? businessTransactionId)
        {
             await GetBusinessTransactionTagsAsyncWithHttpInfo(businessTransactionId);

        }

        /// <summary>
        /// Get the tags for a businessTransaction. Get all existing businessTransaction tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetBusinessTransactionTagsAsyncWithHttpInfo (int? businessTransactionId)
        {
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null) throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling GetBusinessTransactionTags");
            
    
            var localVarPath = "/beta/businessTransaction/{businessTransactionId}/tag";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBusinessTransactionTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a businessTransaction by id Returns a duplicated businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param> 
        /// <returns>BusinessTransaction</returns>
        public BusinessTransaction GetDuplicateBusinessTransactionById (int? businessTransactionId)
        {
             ApiResponse<BusinessTransaction> localVarResponse = GetDuplicateBusinessTransactionByIdWithHttpInfo(businessTransactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a businessTransaction by id Returns a duplicated businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param> 
        /// <returns>ApiResponse of BusinessTransaction</returns>
        public ApiResponse< BusinessTransaction > GetDuplicateBusinessTransactionByIdWithHttpInfo (int? businessTransactionId)
        {
            
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null)
                throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling BusinessTransactionApi->GetDuplicateBusinessTransactionById");
            
    
            var localVarPath = "/beta/businessTransaction/duplicate/{businessTransactionId}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBusinessTransactionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBusinessTransactionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BusinessTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BusinessTransaction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessTransaction)));
            
        }

        
        /// <summary>
        /// Get a duplicated a businessTransaction by id Returns a duplicated businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param>
        /// <returns>Task of BusinessTransaction</returns>
        public async System.Threading.Tasks.Task<BusinessTransaction> GetDuplicateBusinessTransactionByIdAsync (int? businessTransactionId)
        {
             ApiResponse<BusinessTransaction> localVarResponse = await GetDuplicateBusinessTransactionByIdAsyncWithHttpInfo(businessTransactionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a businessTransaction by id Returns a duplicated businessTransaction identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessTransactionId">Id of the businessTransaction to be duplicated.</param>
        /// <returns>Task of ApiResponse (BusinessTransaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BusinessTransaction>> GetDuplicateBusinessTransactionByIdAsyncWithHttpInfo (int? businessTransactionId)
        {
            // verify the required parameter 'businessTransactionId' is set
            if (businessTransactionId == null) throw new ApiException(400, "Missing required parameter 'businessTransactionId' when calling GetDuplicateBusinessTransactionById");
            
    
            var localVarPath = "/beta/businessTransaction/duplicate/{businessTransactionId}";
    
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
            if (businessTransactionId != null) localVarPathParams.Add("businessTransactionId", Configuration.ApiClient.ParameterToString(businessTransactionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBusinessTransactionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBusinessTransactionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BusinessTransaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BusinessTransaction) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BusinessTransaction)));
            
        }
        
        /// <summary>
        /// Update a businessTransaction custom fields Updates an existing businessTransaction custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param> 
        /// <returns></returns>
        public void UpdateBusinessTransactionCustomFields (BusinessTransaction body)
        {
             UpdateBusinessTransactionCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a businessTransaction custom fields Updates an existing businessTransaction custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateBusinessTransactionCustomFieldsWithHttpInfo (BusinessTransaction body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BusinessTransactionApi->UpdateBusinessTransactionCustomFields");
            
    
            var localVarPath = "/beta/businessTransaction/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBusinessTransactionCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBusinessTransactionCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a businessTransaction custom fields Updates an existing businessTransaction custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateBusinessTransactionCustomFieldsAsync (BusinessTransaction body)
        {
             await UpdateBusinessTransactionCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a businessTransaction custom fields Updates an existing businessTransaction custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BusinessTransaction to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBusinessTransactionCustomFieldsAsyncWithHttpInfo (BusinessTransaction body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBusinessTransactionCustomFields");
            
    
            var localVarPath = "/beta/businessTransaction/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBusinessTransactionCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBusinessTransactionCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
