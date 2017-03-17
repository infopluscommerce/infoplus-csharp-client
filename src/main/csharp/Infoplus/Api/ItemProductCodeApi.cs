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
    public interface IItemProductCodeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an itemProductCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param>
        /// <returns>ItemProductCode</returns>
        ItemProductCode AddItemProductCode (ItemProductCode body);
  
        /// <summary>
        /// Create an itemProductCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param>
        /// <returns>ApiResponse of ItemProductCode</returns>
        ApiResponse<ItemProductCode> AddItemProductCodeWithHttpInfo (ItemProductCode body);
        
        /// <summary>
        /// Add new audit for an itemProductCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param>
        /// <param name="itemProductCodeAudit">The audit to add</param>
        /// <returns></returns>
        void AddItemProductCodeAudit (int? itemProductCodeId, string itemProductCodeAudit);
  
        /// <summary>
        /// Add new audit for an itemProductCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param>
        /// <param name="itemProductCodeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemProductCodeAuditWithHttpInfo (int? itemProductCodeId, string itemProductCodeAudit);
        
        /// <summary>
        /// Add new tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param>
        /// <param name="itemProductCodeTag">The tag to add</param>
        /// <returns></returns>
        void AddItemProductCodeTag (int? itemProductCodeId, string itemProductCodeTag);
  
        /// <summary>
        /// Add new tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param>
        /// <param name="itemProductCodeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemProductCodeTagWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag);
        
        /// <summary>
        /// Delete an itemProductCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param>
        /// <returns></returns>
        void DeleteItemProductCode (int? itemProductCodeId);
  
        /// <summary>
        /// Delete an itemProductCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemProductCodeWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Delete a tag for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemProductCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param>
        /// <param name="itemProductCodeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteItemProductCodeTag (int? itemProductCodeId, string itemProductCodeTag);
  
        /// <summary>
        /// Delete a tag for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemProductCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param>
        /// <param name="itemProductCodeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemProductCodeTagWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag);
        
        /// <summary>
        /// Get a duplicated an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param>
        /// <returns>ItemProductCode</returns>
        ItemProductCode GetDuplicateItemProductCodeById (int? itemProductCodeId);
  
        /// <summary>
        /// Get a duplicated an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param>
        /// <returns>ApiResponse of ItemProductCode</returns>
        ApiResponse<ItemProductCode> GetDuplicateItemProductCodeByIdWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Search itemProductCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemProductCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ItemProductCode&gt;</returns>
        List<ItemProductCode> GetItemProductCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search itemProductCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemProductCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemProductCode&gt;</returns>
        ApiResponse<List<ItemProductCode>> GetItemProductCodeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param>
        /// <returns>ItemProductCode</returns>
        ItemProductCode GetItemProductCodeById (int? itemProductCodeId);
  
        /// <summary>
        /// Get an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param>
        /// <returns>ApiResponse of ItemProductCode</returns>
        ApiResponse<ItemProductCode> GetItemProductCodeByIdWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Get the tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemProductCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param>
        /// <returns></returns>
        void GetItemProductCodeTags (int? itemProductCodeId);
  
        /// <summary>
        /// Get the tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemProductCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetItemProductCodeTagsWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Update an itemProductCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param>
        /// <returns></returns>
        void UpdateItemProductCode (ItemProductCode body);
  
        /// <summary>
        /// Update an itemProductCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemProductCodeWithHttpInfo (ItemProductCode body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an itemProductCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param>
        /// <returns>Task of ItemProductCode</returns>
        System.Threading.Tasks.Task<ItemProductCode> AddItemProductCodeAsync (ItemProductCode body);

        /// <summary>
        /// Create an itemProductCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemProductCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemProductCode>> AddItemProductCodeAsyncWithHttpInfo (ItemProductCode body);
        
        /// <summary>
        /// Add new audit for an itemProductCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param>
        /// <param name="itemProductCodeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemProductCodeAuditAsync (int? itemProductCodeId, string itemProductCodeAudit);

        /// <summary>
        /// Add new audit for an itemProductCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param>
        /// <param name="itemProductCodeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemProductCodeAuditAsyncWithHttpInfo (int? itemProductCodeId, string itemProductCodeAudit);
        
        /// <summary>
        /// Add new tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param>
        /// <param name="itemProductCodeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemProductCodeTagAsync (int? itemProductCodeId, string itemProductCodeTag);

        /// <summary>
        /// Add new tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemProductCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param>
        /// <param name="itemProductCodeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemProductCodeTagAsyncWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag);
        
        /// <summary>
        /// Delete an itemProductCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemProductCodeAsync (int? itemProductCodeId);

        /// <summary>
        /// Delete an itemProductCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemProductCodeAsyncWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Delete a tag for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemProductCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param>
        /// <param name="itemProductCodeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemProductCodeTagAsync (int? itemProductCodeId, string itemProductCodeTag);

        /// <summary>
        /// Delete a tag for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemProductCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param>
        /// <param name="itemProductCodeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemProductCodeTagAsyncWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag);
        
        /// <summary>
        /// Get a duplicated an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param>
        /// <returns>Task of ItemProductCode</returns>
        System.Threading.Tasks.Task<ItemProductCode> GetDuplicateItemProductCodeByIdAsync (int? itemProductCodeId);

        /// <summary>
        /// Get a duplicated an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemProductCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemProductCode>> GetDuplicateItemProductCodeByIdAsyncWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Search itemProductCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemProductCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemProductCode&gt;</returns>
        System.Threading.Tasks.Task<List<ItemProductCode>> GetItemProductCodeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search itemProductCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemProductCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemProductCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemProductCode>>> GetItemProductCodeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param>
        /// <returns>Task of ItemProductCode</returns>
        System.Threading.Tasks.Task<ItemProductCode> GetItemProductCodeByIdAsync (int? itemProductCodeId);

        /// <summary>
        /// Get an itemProductCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemProductCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemProductCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemProductCode>> GetItemProductCodeByIdAsyncWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Get the tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemProductCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetItemProductCodeTagsAsync (int? itemProductCodeId);

        /// <summary>
        /// Get the tags for an itemProductCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemProductCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetItemProductCodeTagsAsyncWithHttpInfo (int? itemProductCodeId);
        
        /// <summary>
        /// Update an itemProductCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemProductCodeAsync (ItemProductCode body);

        /// <summary>
        /// Update an itemProductCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemProductCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemProductCodeAsyncWithHttpInfo (ItemProductCode body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemProductCodeApi : IItemProductCodeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemProductCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemProductCodeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemProductCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemProductCodeApi(Configuration configuration = null)
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
        /// Create an itemProductCode Inserts a new itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param> 
        /// <returns>ItemProductCode</returns>
        public ItemProductCode AddItemProductCode (ItemProductCode body)
        {
             ApiResponse<ItemProductCode> localVarResponse = AddItemProductCodeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an itemProductCode Inserts a new itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param> 
        /// <returns>ApiResponse of ItemProductCode</returns>
        public ApiResponse< ItemProductCode > AddItemProductCodeWithHttpInfo (ItemProductCode body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemProductCodeApi->AddItemProductCode");
            
    
            var localVarPath = "/beta/itemProductCode";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemProductCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemProductCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemProductCode)));
            
        }

        
        /// <summary>
        /// Create an itemProductCode Inserts a new itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param>
        /// <returns>Task of ItemProductCode</returns>
        public async System.Threading.Tasks.Task<ItemProductCode> AddItemProductCodeAsync (ItemProductCode body)
        {
             ApiResponse<ItemProductCode> localVarResponse = await AddItemProductCodeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an itemProductCode Inserts a new itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemProductCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemProductCode>> AddItemProductCodeAsyncWithHttpInfo (ItemProductCode body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddItemProductCode");
            
    
            var localVarPath = "/beta/itemProductCode";
    
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemProductCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemProductCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemProductCode)));
            
        }
        
        /// <summary>
        /// Add new audit for an itemProductCode Adds an audit to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param> 
        /// <param name="itemProductCodeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddItemProductCodeAudit (int? itemProductCodeId, string itemProductCodeAudit)
        {
             AddItemProductCodeAuditWithHttpInfo(itemProductCodeId, itemProductCodeAudit);
        }

        /// <summary>
        /// Add new audit for an itemProductCode Adds an audit to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param> 
        /// <param name="itemProductCodeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemProductCodeAuditWithHttpInfo (int? itemProductCodeId, string itemProductCodeAudit)
        {
            
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling ItemProductCodeApi->AddItemProductCodeAudit");
            
            // verify the required parameter 'itemProductCodeAudit' is set
            if (itemProductCodeAudit == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeAudit' when calling ItemProductCodeApi->AddItemProductCodeAudit");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/audit/{itemProductCodeAudit}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            if (itemProductCodeAudit != null) localVarPathParams.Add("itemProductCodeAudit", Configuration.ApiClient.ParameterToString(itemProductCodeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an itemProductCode Adds an audit to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param>
        /// <param name="itemProductCodeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemProductCodeAuditAsync (int? itemProductCodeId, string itemProductCodeAudit)
        {
             await AddItemProductCodeAuditAsyncWithHttpInfo(itemProductCodeId, itemProductCodeAudit);

        }

        /// <summary>
        /// Add new audit for an itemProductCode Adds an audit to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add an audit to</param>
        /// <param name="itemProductCodeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemProductCodeAuditAsyncWithHttpInfo (int? itemProductCodeId, string itemProductCodeAudit)
        {
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling AddItemProductCodeAudit");
            // verify the required parameter 'itemProductCodeAudit' is set
            if (itemProductCodeAudit == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeAudit' when calling AddItemProductCodeAudit");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/audit/{itemProductCodeAudit}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            if (itemProductCodeAudit != null) localVarPathParams.Add("itemProductCodeAudit", Configuration.ApiClient.ParameterToString(itemProductCodeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an itemProductCode. Adds a tag to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param> 
        /// <param name="itemProductCodeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddItemProductCodeTag (int? itemProductCodeId, string itemProductCodeTag)
        {
             AddItemProductCodeTagWithHttpInfo(itemProductCodeId, itemProductCodeTag);
        }

        /// <summary>
        /// Add new tags for an itemProductCode. Adds a tag to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param> 
        /// <param name="itemProductCodeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemProductCodeTagWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag)
        {
            
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling ItemProductCodeApi->AddItemProductCodeTag");
            
            // verify the required parameter 'itemProductCodeTag' is set
            if (itemProductCodeTag == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeTag' when calling ItemProductCodeApi->AddItemProductCodeTag");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/tag/{itemProductCodeTag}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            if (itemProductCodeTag != null) localVarPathParams.Add("itemProductCodeTag", Configuration.ApiClient.ParameterToString(itemProductCodeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an itemProductCode. Adds a tag to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param>
        /// <param name="itemProductCodeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemProductCodeTagAsync (int? itemProductCodeId, string itemProductCodeTag)
        {
             await AddItemProductCodeTagAsyncWithHttpInfo(itemProductCodeId, itemProductCodeTag);

        }

        /// <summary>
        /// Add new tags for an itemProductCode. Adds a tag to an existing itemProductCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to add a tag to</param>
        /// <param name="itemProductCodeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemProductCodeTagAsyncWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag)
        {
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling AddItemProductCodeTag");
            // verify the required parameter 'itemProductCodeTag' is set
            if (itemProductCodeTag == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeTag' when calling AddItemProductCodeTag");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/tag/{itemProductCodeTag}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            if (itemProductCodeTag != null) localVarPathParams.Add("itemProductCodeTag", Configuration.ApiClient.ParameterToString(itemProductCodeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemProductCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an itemProductCode Deletes the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param> 
        /// <returns></returns>
        public void DeleteItemProductCode (int? itemProductCodeId)
        {
             DeleteItemProductCodeWithHttpInfo(itemProductCodeId);
        }

        /// <summary>
        /// Delete an itemProductCode Deletes the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemProductCodeWithHttpInfo (int? itemProductCodeId)
        {
            
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling ItemProductCodeApi->DeleteItemProductCode");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an itemProductCode Deletes the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemProductCodeAsync (int? itemProductCodeId)
        {
             await DeleteItemProductCodeAsyncWithHttpInfo(itemProductCodeId);

        }

        /// <summary>
        /// Delete an itemProductCode Deletes the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemProductCodeAsyncWithHttpInfo (int? itemProductCodeId)
        {
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling DeleteItemProductCode");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an itemProductCode. Deletes an existing itemProductCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param> 
        /// <param name="itemProductCodeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteItemProductCodeTag (int? itemProductCodeId, string itemProductCodeTag)
        {
             DeleteItemProductCodeTagWithHttpInfo(itemProductCodeId, itemProductCodeTag);
        }

        /// <summary>
        /// Delete a tag for an itemProductCode. Deletes an existing itemProductCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param> 
        /// <param name="itemProductCodeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemProductCodeTagWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag)
        {
            
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling ItemProductCodeApi->DeleteItemProductCodeTag");
            
            // verify the required parameter 'itemProductCodeTag' is set
            if (itemProductCodeTag == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeTag' when calling ItemProductCodeApi->DeleteItemProductCodeTag");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/tag/{itemProductCodeTag}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            if (itemProductCodeTag != null) localVarPathParams.Add("itemProductCodeTag", Configuration.ApiClient.ParameterToString(itemProductCodeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an itemProductCode. Deletes an existing itemProductCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param>
        /// <param name="itemProductCodeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemProductCodeTagAsync (int? itemProductCodeId, string itemProductCodeTag)
        {
             await DeleteItemProductCodeTagAsyncWithHttpInfo(itemProductCodeId, itemProductCodeTag);

        }

        /// <summary>
        /// Delete a tag for an itemProductCode. Deletes an existing itemProductCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to remove tag from</param>
        /// <param name="itemProductCodeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemProductCodeTagAsyncWithHttpInfo (int? itemProductCodeId, string itemProductCodeTag)
        {
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling DeleteItemProductCodeTag");
            // verify the required parameter 'itemProductCodeTag' is set
            if (itemProductCodeTag == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeTag' when calling DeleteItemProductCodeTag");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/tag/{itemProductCodeTag}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            if (itemProductCodeTag != null) localVarPathParams.Add("itemProductCodeTag", Configuration.ApiClient.ParameterToString(itemProductCodeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemProductCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an itemProductCode by id Returns a duplicated itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param> 
        /// <returns>ItemProductCode</returns>
        public ItemProductCode GetDuplicateItemProductCodeById (int? itemProductCodeId)
        {
             ApiResponse<ItemProductCode> localVarResponse = GetDuplicateItemProductCodeByIdWithHttpInfo(itemProductCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an itemProductCode by id Returns a duplicated itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param> 
        /// <returns>ApiResponse of ItemProductCode</returns>
        public ApiResponse< ItemProductCode > GetDuplicateItemProductCodeByIdWithHttpInfo (int? itemProductCodeId)
        {
            
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling ItemProductCodeApi->GetDuplicateItemProductCodeById");
            
    
            var localVarPath = "/beta/itemProductCode/duplicate/{itemProductCodeId}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemProductCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemProductCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemProductCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemProductCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemProductCode)));
            
        }

        
        /// <summary>
        /// Get a duplicated an itemProductCode by id Returns a duplicated itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param>
        /// <returns>Task of ItemProductCode</returns>
        public async System.Threading.Tasks.Task<ItemProductCode> GetDuplicateItemProductCodeByIdAsync (int? itemProductCodeId)
        {
             ApiResponse<ItemProductCode> localVarResponse = await GetDuplicateItemProductCodeByIdAsyncWithHttpInfo(itemProductCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an itemProductCode by id Returns a duplicated itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemProductCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemProductCode>> GetDuplicateItemProductCodeByIdAsyncWithHttpInfo (int? itemProductCodeId)
        {
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling GetDuplicateItemProductCodeById");
            
    
            var localVarPath = "/beta/itemProductCode/duplicate/{itemProductCodeId}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemProductCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemProductCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemProductCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemProductCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemProductCode)));
            
        }
        
        /// <summary>
        /// Search itemProductCodes by filter Returns the list of itemProductCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ItemProductCode&gt;</returns>
        public List<ItemProductCode> GetItemProductCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemProductCode>> localVarResponse = GetItemProductCodeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemProductCodes by filter Returns the list of itemProductCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemProductCode&gt;</returns>
        public ApiResponse< List<ItemProductCode> > GetItemProductCodeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemProductCode/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemProductCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemProductCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemProductCode>)));
            
        }

        
        /// <summary>
        /// Search itemProductCodes by filter Returns the list of itemProductCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemProductCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemProductCode>> GetItemProductCodeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemProductCode>> localVarResponse = await GetItemProductCodeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemProductCodes by filter Returns the list of itemProductCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemProductCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemProductCode>>> GetItemProductCodeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemProductCode/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemProductCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemProductCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemProductCode>)));
            
        }
        
        /// <summary>
        /// Get an itemProductCode by id Returns the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param> 
        /// <returns>ItemProductCode</returns>
        public ItemProductCode GetItemProductCodeById (int? itemProductCodeId)
        {
             ApiResponse<ItemProductCode> localVarResponse = GetItemProductCodeByIdWithHttpInfo(itemProductCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemProductCode by id Returns the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param> 
        /// <returns>ApiResponse of ItemProductCode</returns>
        public ApiResponse< ItemProductCode > GetItemProductCodeByIdWithHttpInfo (int? itemProductCodeId)
        {
            
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling ItemProductCodeApi->GetItemProductCodeById");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemProductCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemProductCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemProductCode)));
            
        }

        
        /// <summary>
        /// Get an itemProductCode by id Returns the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param>
        /// <returns>Task of ItemProductCode</returns>
        public async System.Threading.Tasks.Task<ItemProductCode> GetItemProductCodeByIdAsync (int? itemProductCodeId)
        {
             ApiResponse<ItemProductCode> localVarResponse = await GetItemProductCodeByIdAsyncWithHttpInfo(itemProductCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemProductCode by id Returns the itemProductCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemProductCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemProductCode>> GetItemProductCodeByIdAsyncWithHttpInfo (int? itemProductCodeId)
        {
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling GetItemProductCodeById");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemProductCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemProductCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemProductCode)));
            
        }
        
        /// <summary>
        /// Get the tags for an itemProductCode. Get all existing itemProductCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param> 
        /// <returns></returns>
        public void GetItemProductCodeTags (int? itemProductCodeId)
        {
             GetItemProductCodeTagsWithHttpInfo(itemProductCodeId);
        }

        /// <summary>
        /// Get the tags for an itemProductCode. Get all existing itemProductCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetItemProductCodeTagsWithHttpInfo (int? itemProductCodeId)
        {
            
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling ItemProductCodeApi->GetItemProductCodeTags");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/tag";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an itemProductCode. Get all existing itemProductCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetItemProductCodeTagsAsync (int? itemProductCodeId)
        {
             await GetItemProductCodeTagsAsyncWithHttpInfo(itemProductCodeId);

        }

        /// <summary>
        /// Get the tags for an itemProductCode. Get all existing itemProductCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemProductCodeId">Id of the itemProductCode to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetItemProductCodeTagsAsyncWithHttpInfo (int? itemProductCodeId)
        {
            // verify the required parameter 'itemProductCodeId' is set
            if (itemProductCodeId == null) throw new ApiException(400, "Missing required parameter 'itemProductCodeId' when calling GetItemProductCodeTags");
            
    
            var localVarPath = "/beta/itemProductCode/{itemProductCodeId}/tag";
    
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
            if (itemProductCodeId != null) localVarPathParams.Add("itemProductCodeId", Configuration.ApiClient.ParameterToString(itemProductCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemProductCodeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemProductCode Updates an existing itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemProductCode (ItemProductCode body)
        {
             UpdateItemProductCodeWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemProductCode Updates an existing itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemProductCodeWithHttpInfo (ItemProductCode body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemProductCodeApi->UpdateItemProductCode");
            
    
            var localVarPath = "/beta/itemProductCode";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemProductCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemProductCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemProductCode Updates an existing itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemProductCodeAsync (ItemProductCode body)
        {
             await UpdateItemProductCodeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemProductCode Updates an existing itemProductCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemProductCode to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemProductCodeAsyncWithHttpInfo (ItemProductCode body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemProductCode");
            
    
            var localVarPath = "/beta/itemProductCode";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemProductCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemProductCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
