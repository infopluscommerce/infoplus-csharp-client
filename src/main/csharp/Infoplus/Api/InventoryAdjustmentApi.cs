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
    public interface IInventoryAdjustmentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for an inventoryAdjustment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param>
        /// <param name="inventoryAdjustmentAudit">The audit to add</param>
        /// <returns></returns>
        void AddInventoryAdjustmentAudit (int? inventoryAdjustmentId, string inventoryAdjustmentAudit);
  
        /// <summary>
        /// Add new audit for an inventoryAdjustment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param>
        /// <param name="inventoryAdjustmentAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventoryAdjustmentAuditWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentAudit);
        
        /// <summary>
        /// Add new tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param>
        /// <param name="inventoryAdjustmentTag">The tag to add</param>
        /// <returns></returns>
        void AddInventoryAdjustmentTag (int? inventoryAdjustmentId, string inventoryAdjustmentTag);
  
        /// <summary>
        /// Add new tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param>
        /// <param name="inventoryAdjustmentTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventoryAdjustmentTagWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag);
        
        /// <summary>
        /// Delete a tag for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryAdjustment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param>
        /// <param name="inventoryAdjustmentTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteInventoryAdjustmentTag (int? inventoryAdjustmentId, string inventoryAdjustmentTag);
  
        /// <summary>
        /// Delete a tag for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryAdjustment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param>
        /// <param name="inventoryAdjustmentTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInventoryAdjustmentTagWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag);
        
        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param>
        /// <returns>InventoryAdjustment</returns>
        InventoryAdjustment GetDuplicateInventoryAdjustmentById (int? inventoryAdjustmentId);
  
        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param>
        /// <returns>ApiResponse of InventoryAdjustment</returns>
        ApiResponse<InventoryAdjustment> GetDuplicateInventoryAdjustmentByIdWithHttpInfo (int? inventoryAdjustmentId);
        
        /// <summary>
        /// Search inventoryAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;InventoryAdjustment&gt;</returns>
        List<InventoryAdjustment> GetInventoryAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search inventoryAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;InventoryAdjustment&gt;</returns>
        ApiResponse<List<InventoryAdjustment>> GetInventoryAdjustmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param>
        /// <returns>InventoryAdjustment</returns>
        InventoryAdjustment GetInventoryAdjustmentById (int? inventoryAdjustmentId);
  
        /// <summary>
        /// Get an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param>
        /// <returns>ApiResponse of InventoryAdjustment</returns>
        ApiResponse<InventoryAdjustment> GetInventoryAdjustmentByIdWithHttpInfo (int? inventoryAdjustmentId);
        
        /// <summary>
        /// Get the tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryAdjustment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param>
        /// <returns></returns>
        void GetInventoryAdjustmentTags (int? inventoryAdjustmentId);
  
        /// <summary>
        /// Get the tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryAdjustment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetInventoryAdjustmentTagsWithHttpInfo (int? inventoryAdjustmentId);
        
        /// <summary>
        /// Update an inventoryAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param>
        /// <returns></returns>
        void UpdateInventoryAdjustmentCustomFields (InventoryAdjustment body);
  
        /// <summary>
        /// Update an inventoryAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateInventoryAdjustmentCustomFieldsWithHttpInfo (InventoryAdjustment body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for an inventoryAdjustment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param>
        /// <param name="inventoryAdjustmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventoryAdjustmentAuditAsync (int? inventoryAdjustmentId, string inventoryAdjustmentAudit);

        /// <summary>
        /// Add new audit for an inventoryAdjustment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param>
        /// <param name="inventoryAdjustmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryAdjustmentAuditAsyncWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentAudit);
        
        /// <summary>
        /// Add new tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param>
        /// <param name="inventoryAdjustmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventoryAdjustmentTagAsync (int? inventoryAdjustmentId, string inventoryAdjustmentTag);

        /// <summary>
        /// Add new tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryAdjustment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param>
        /// <param name="inventoryAdjustmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryAdjustmentTagAsyncWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag);
        
        /// <summary>
        /// Delete a tag for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryAdjustment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param>
        /// <param name="inventoryAdjustmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInventoryAdjustmentTagAsync (int? inventoryAdjustmentId, string inventoryAdjustmentTag);

        /// <summary>
        /// Delete a tag for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryAdjustment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param>
        /// <param name="inventoryAdjustmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryAdjustmentTagAsyncWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag);
        
        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param>
        /// <returns>Task of InventoryAdjustment</returns>
        System.Threading.Tasks.Task<InventoryAdjustment> GetDuplicateInventoryAdjustmentByIdAsync (int? inventoryAdjustmentId);

        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventoryAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryAdjustment>> GetDuplicateInventoryAdjustmentByIdAsyncWithHttpInfo (int? inventoryAdjustmentId);
        
        /// <summary>
        /// Search inventoryAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventoryAdjustment&gt;</returns>
        System.Threading.Tasks.Task<List<InventoryAdjustment>> GetInventoryAdjustmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search inventoryAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryAdjustment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InventoryAdjustment>>> GetInventoryAdjustmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param>
        /// <returns>Task of InventoryAdjustment</returns>
        System.Threading.Tasks.Task<InventoryAdjustment> GetInventoryAdjustmentByIdAsync (int? inventoryAdjustmentId);

        /// <summary>
        /// Get an inventoryAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param>
        /// <returns>Task of ApiResponse (InventoryAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryAdjustment>> GetInventoryAdjustmentByIdAsyncWithHttpInfo (int? inventoryAdjustmentId);
        
        /// <summary>
        /// Get the tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryAdjustment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetInventoryAdjustmentTagsAsync (int? inventoryAdjustmentId);

        /// <summary>
        /// Get the tags for an inventoryAdjustment.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryAdjustment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetInventoryAdjustmentTagsAsyncWithHttpInfo (int? inventoryAdjustmentId);
        
        /// <summary>
        /// Update an inventoryAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateInventoryAdjustmentCustomFieldsAsync (InventoryAdjustment body);

        /// <summary>
        /// Update an inventoryAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInventoryAdjustmentCustomFieldsAsyncWithHttpInfo (InventoryAdjustment body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InventoryAdjustmentApi : IInventoryAdjustmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAdjustmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InventoryAdjustmentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryAdjustmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InventoryAdjustmentApi(Configuration configuration = null)
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
        /// Add new audit for an inventoryAdjustment Adds an audit to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param> 
        /// <param name="inventoryAdjustmentAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddInventoryAdjustmentAudit (int? inventoryAdjustmentId, string inventoryAdjustmentAudit)
        {
             AddInventoryAdjustmentAuditWithHttpInfo(inventoryAdjustmentId, inventoryAdjustmentAudit);
        }

        /// <summary>
        /// Add new audit for an inventoryAdjustment Adds an audit to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param> 
        /// <param name="inventoryAdjustmentAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventoryAdjustmentAuditWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentAudit)
        {
            
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling InventoryAdjustmentApi->AddInventoryAdjustmentAudit");
            
            // verify the required parameter 'inventoryAdjustmentAudit' is set
            if (inventoryAdjustmentAudit == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentAudit' when calling InventoryAdjustmentApi->AddInventoryAdjustmentAudit");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/audit/{inventoryAdjustmentAudit}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            if (inventoryAdjustmentAudit != null) localVarPathParams.Add("inventoryAdjustmentAudit", Configuration.ApiClient.ParameterToString(inventoryAdjustmentAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an inventoryAdjustment Adds an audit to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param>
        /// <param name="inventoryAdjustmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventoryAdjustmentAuditAsync (int? inventoryAdjustmentId, string inventoryAdjustmentAudit)
        {
             await AddInventoryAdjustmentAuditAsyncWithHttpInfo(inventoryAdjustmentId, inventoryAdjustmentAudit);

        }

        /// <summary>
        /// Add new audit for an inventoryAdjustment Adds an audit to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add an audit to</param>
        /// <param name="inventoryAdjustmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryAdjustmentAuditAsyncWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentAudit)
        {
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling AddInventoryAdjustmentAudit");
            // verify the required parameter 'inventoryAdjustmentAudit' is set
            if (inventoryAdjustmentAudit == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentAudit' when calling AddInventoryAdjustmentAudit");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/audit/{inventoryAdjustmentAudit}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            if (inventoryAdjustmentAudit != null) localVarPathParams.Add("inventoryAdjustmentAudit", Configuration.ApiClient.ParameterToString(inventoryAdjustmentAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an inventoryAdjustment. Adds a tag to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param> 
        /// <param name="inventoryAdjustmentTag">The tag to add</param> 
        /// <returns></returns>
        public void AddInventoryAdjustmentTag (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
             AddInventoryAdjustmentTagWithHttpInfo(inventoryAdjustmentId, inventoryAdjustmentTag);
        }

        /// <summary>
        /// Add new tags for an inventoryAdjustment. Adds a tag to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param> 
        /// <param name="inventoryAdjustmentTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventoryAdjustmentTagWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
            
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling InventoryAdjustmentApi->AddInventoryAdjustmentTag");
            
            // verify the required parameter 'inventoryAdjustmentTag' is set
            if (inventoryAdjustmentTag == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentTag' when calling InventoryAdjustmentApi->AddInventoryAdjustmentTag");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/tag/{inventoryAdjustmentTag}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            if (inventoryAdjustmentTag != null) localVarPathParams.Add("inventoryAdjustmentTag", Configuration.ApiClient.ParameterToString(inventoryAdjustmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an inventoryAdjustment. Adds a tag to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param>
        /// <param name="inventoryAdjustmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventoryAdjustmentTagAsync (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
             await AddInventoryAdjustmentTagAsyncWithHttpInfo(inventoryAdjustmentId, inventoryAdjustmentTag);

        }

        /// <summary>
        /// Add new tags for an inventoryAdjustment. Adds a tag to an existing inventoryAdjustment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to add a tag to</param>
        /// <param name="inventoryAdjustmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryAdjustmentTagAsyncWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling AddInventoryAdjustmentTag");
            // verify the required parameter 'inventoryAdjustmentTag' is set
            if (inventoryAdjustmentTag == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentTag' when calling AddInventoryAdjustmentTag");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/tag/{inventoryAdjustmentTag}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            if (inventoryAdjustmentTag != null) localVarPathParams.Add("inventoryAdjustmentTag", Configuration.ApiClient.ParameterToString(inventoryAdjustmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryAdjustmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an inventoryAdjustment. Deletes an existing inventoryAdjustment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param> 
        /// <param name="inventoryAdjustmentTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteInventoryAdjustmentTag (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
             DeleteInventoryAdjustmentTagWithHttpInfo(inventoryAdjustmentId, inventoryAdjustmentTag);
        }

        /// <summary>
        /// Delete a tag for an inventoryAdjustment. Deletes an existing inventoryAdjustment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param> 
        /// <param name="inventoryAdjustmentTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInventoryAdjustmentTagWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
            
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling InventoryAdjustmentApi->DeleteInventoryAdjustmentTag");
            
            // verify the required parameter 'inventoryAdjustmentTag' is set
            if (inventoryAdjustmentTag == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentTag' when calling InventoryAdjustmentApi->DeleteInventoryAdjustmentTag");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/tag/{inventoryAdjustmentTag}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            if (inventoryAdjustmentTag != null) localVarPathParams.Add("inventoryAdjustmentTag", Configuration.ApiClient.ParameterToString(inventoryAdjustmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryAdjustmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryAdjustmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an inventoryAdjustment. Deletes an existing inventoryAdjustment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param>
        /// <param name="inventoryAdjustmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInventoryAdjustmentTagAsync (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
             await DeleteInventoryAdjustmentTagAsyncWithHttpInfo(inventoryAdjustmentId, inventoryAdjustmentTag);

        }

        /// <summary>
        /// Delete a tag for an inventoryAdjustment. Deletes an existing inventoryAdjustment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to remove tag from</param>
        /// <param name="inventoryAdjustmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryAdjustmentTagAsyncWithHttpInfo (int? inventoryAdjustmentId, string inventoryAdjustmentTag)
        {
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling DeleteInventoryAdjustmentTag");
            // verify the required parameter 'inventoryAdjustmentTag' is set
            if (inventoryAdjustmentTag == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentTag' when calling DeleteInventoryAdjustmentTag");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/tag/{inventoryAdjustmentTag}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            if (inventoryAdjustmentTag != null) localVarPathParams.Add("inventoryAdjustmentTag", Configuration.ApiClient.ParameterToString(inventoryAdjustmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryAdjustmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryAdjustmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param> 
        /// <returns>InventoryAdjustment</returns>
        public InventoryAdjustment GetDuplicateInventoryAdjustmentById (int? inventoryAdjustmentId)
        {
             ApiResponse<InventoryAdjustment> localVarResponse = GetDuplicateInventoryAdjustmentByIdWithHttpInfo(inventoryAdjustmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param> 
        /// <returns>ApiResponse of InventoryAdjustment</returns>
        public ApiResponse< InventoryAdjustment > GetDuplicateInventoryAdjustmentByIdWithHttpInfo (int? inventoryAdjustmentId)
        {
            
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling InventoryAdjustmentApi->GetDuplicateInventoryAdjustmentById");
            
    
            var localVarPath = "/beta/inventoryAdjustment/duplicate/{inventoryAdjustmentId}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventoryAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryAdjustment)));
            
        }

        
        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param>
        /// <returns>Task of InventoryAdjustment</returns>
        public async System.Threading.Tasks.Task<InventoryAdjustment> GetDuplicateInventoryAdjustmentByIdAsync (int? inventoryAdjustmentId)
        {
             ApiResponse<InventoryAdjustment> localVarResponse = await GetDuplicateInventoryAdjustmentByIdAsyncWithHttpInfo(inventoryAdjustmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an inventoryAdjustment by id Returns a duplicated inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventoryAdjustment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryAdjustment>> GetDuplicateInventoryAdjustmentByIdAsyncWithHttpInfo (int? inventoryAdjustmentId)
        {
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling GetDuplicateInventoryAdjustmentById");
            
    
            var localVarPath = "/beta/inventoryAdjustment/duplicate/{inventoryAdjustmentId}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryAdjustment)));
            
        }
        
        /// <summary>
        /// Search inventoryAdjustments by filter Returns the list of inventoryAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;InventoryAdjustment&gt;</returns>
        public List<InventoryAdjustment> GetInventoryAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventoryAdjustment>> localVarResponse = GetInventoryAdjustmentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search inventoryAdjustments by filter Returns the list of inventoryAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;InventoryAdjustment&gt;</returns>
        public ApiResponse< List<InventoryAdjustment> > GetInventoryAdjustmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventoryAdjustment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InventoryAdjustment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryAdjustment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventoryAdjustment>)));
            
        }

        
        /// <summary>
        /// Search inventoryAdjustments by filter Returns the list of inventoryAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventoryAdjustment&gt;</returns>
        public async System.Threading.Tasks.Task<List<InventoryAdjustment>> GetInventoryAdjustmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventoryAdjustment>> localVarResponse = await GetInventoryAdjustmentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search inventoryAdjustments by filter Returns the list of inventoryAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryAdjustment&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InventoryAdjustment>>> GetInventoryAdjustmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventoryAdjustment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventoryAdjustment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryAdjustment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventoryAdjustment>)));
            
        }
        
        /// <summary>
        /// Get an inventoryAdjustment by id Returns the inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param> 
        /// <returns>InventoryAdjustment</returns>
        public InventoryAdjustment GetInventoryAdjustmentById (int? inventoryAdjustmentId)
        {
             ApiResponse<InventoryAdjustment> localVarResponse = GetInventoryAdjustmentByIdWithHttpInfo(inventoryAdjustmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an inventoryAdjustment by id Returns the inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param> 
        /// <returns>ApiResponse of InventoryAdjustment</returns>
        public ApiResponse< InventoryAdjustment > GetInventoryAdjustmentByIdWithHttpInfo (int? inventoryAdjustmentId)
        {
            
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling InventoryAdjustmentApi->GetInventoryAdjustmentById");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventoryAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryAdjustment)));
            
        }

        
        /// <summary>
        /// Get an inventoryAdjustment by id Returns the inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param>
        /// <returns>Task of InventoryAdjustment</returns>
        public async System.Threading.Tasks.Task<InventoryAdjustment> GetInventoryAdjustmentByIdAsync (int? inventoryAdjustmentId)
        {
             ApiResponse<InventoryAdjustment> localVarResponse = await GetInventoryAdjustmentByIdAsyncWithHttpInfo(inventoryAdjustmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an inventoryAdjustment by id Returns the inventoryAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to be returned.</param>
        /// <returns>Task of ApiResponse (InventoryAdjustment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryAdjustment>> GetInventoryAdjustmentByIdAsyncWithHttpInfo (int? inventoryAdjustmentId)
        {
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling GetInventoryAdjustmentById");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryAdjustment)));
            
        }
        
        /// <summary>
        /// Get the tags for an inventoryAdjustment. Get all existing inventoryAdjustment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param> 
        /// <returns></returns>
        public void GetInventoryAdjustmentTags (int? inventoryAdjustmentId)
        {
             GetInventoryAdjustmentTagsWithHttpInfo(inventoryAdjustmentId);
        }

        /// <summary>
        /// Get the tags for an inventoryAdjustment. Get all existing inventoryAdjustment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetInventoryAdjustmentTagsWithHttpInfo (int? inventoryAdjustmentId)
        {
            
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling InventoryAdjustmentApi->GetInventoryAdjustmentTags");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/tag";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an inventoryAdjustment. Get all existing inventoryAdjustment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetInventoryAdjustmentTagsAsync (int? inventoryAdjustmentId)
        {
             await GetInventoryAdjustmentTagsAsyncWithHttpInfo(inventoryAdjustmentId);

        }

        /// <summary>
        /// Get the tags for an inventoryAdjustment. Get all existing inventoryAdjustment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryAdjustmentId">Id of the inventoryAdjustment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetInventoryAdjustmentTagsAsyncWithHttpInfo (int? inventoryAdjustmentId)
        {
            // verify the required parameter 'inventoryAdjustmentId' is set
            if (inventoryAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'inventoryAdjustmentId' when calling GetInventoryAdjustmentTags");
            
    
            var localVarPath = "/beta/inventoryAdjustment/{inventoryAdjustmentId}/tag";
    
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
            if (inventoryAdjustmentId != null) localVarPathParams.Add("inventoryAdjustmentId", Configuration.ApiClient.ParameterToString(inventoryAdjustmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryAdjustmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an inventoryAdjustment custom fields Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param> 
        /// <returns></returns>
        public void UpdateInventoryAdjustmentCustomFields (InventoryAdjustment body)
        {
             UpdateInventoryAdjustmentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an inventoryAdjustment custom fields Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateInventoryAdjustmentCustomFieldsWithHttpInfo (InventoryAdjustment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InventoryAdjustmentApi->UpdateInventoryAdjustmentCustomFields");
            
    
            var localVarPath = "/beta/inventoryAdjustment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryAdjustmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryAdjustmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an inventoryAdjustment custom fields Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateInventoryAdjustmentCustomFieldsAsync (InventoryAdjustment body)
        {
             await UpdateInventoryAdjustmentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an inventoryAdjustment custom fields Updates an existing inventoryAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryAdjustment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInventoryAdjustmentCustomFieldsAsyncWithHttpInfo (InventoryAdjustment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateInventoryAdjustmentCustomFields");
            
    
            var localVarPath = "/beta/inventoryAdjustment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryAdjustmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryAdjustmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
