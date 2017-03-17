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
    public interface IItemSectorApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an itemSector
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param>
        /// <returns>ItemSector</returns>
        ItemSector AddItemSector (ItemSector body);
  
        /// <summary>
        /// Create an itemSector
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param>
        /// <returns>ApiResponse of ItemSector</returns>
        ApiResponse<ItemSector> AddItemSectorWithHttpInfo (ItemSector body);
        
        /// <summary>
        /// Add new audit for an itemSector
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param>
        /// <param name="itemSectorAudit">The audit to add</param>
        /// <returns></returns>
        void AddItemSectorAudit (int? itemSectorId, string itemSectorAudit);
  
        /// <summary>
        /// Add new audit for an itemSector
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param>
        /// <param name="itemSectorAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemSectorAuditWithHttpInfo (int? itemSectorId, string itemSectorAudit);
        
        /// <summary>
        /// Add new tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param>
        /// <param name="itemSectorTag">The tag to add</param>
        /// <returns></returns>
        void AddItemSectorTag (int? itemSectorId, string itemSectorTag);
  
        /// <summary>
        /// Add new tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param>
        /// <param name="itemSectorTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemSectorTagWithHttpInfo (int? itemSectorId, string itemSectorTag);
        
        /// <summary>
        /// Delete an itemSector
        /// </summary>
        /// <remarks>
        /// Deletes the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param>
        /// <returns></returns>
        void DeleteItemSector (int? itemSectorId);
  
        /// <summary>
        /// Delete an itemSector
        /// </summary>
        /// <remarks>
        /// Deletes the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemSectorWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Delete a tag for an itemSector.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSector tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param>
        /// <param name="itemSectorTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteItemSectorTag (int? itemSectorId, string itemSectorTag);
  
        /// <summary>
        /// Delete a tag for an itemSector.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSector tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param>
        /// <param name="itemSectorTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemSectorTagWithHttpInfo (int? itemSectorId, string itemSectorTag);
        
        /// <summary>
        /// Get a duplicated an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param>
        /// <returns>ItemSector</returns>
        ItemSector GetDuplicateItemSectorById (int? itemSectorId);
  
        /// <summary>
        /// Get a duplicated an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param>
        /// <returns>ApiResponse of ItemSector</returns>
        ApiResponse<ItemSector> GetDuplicateItemSectorByIdWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Search itemSectors by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSectors that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ItemSector&gt;</returns>
        List<ItemSector> GetItemSectorByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search itemSectors by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSectors that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemSector&gt;</returns>
        ApiResponse<List<ItemSector>> GetItemSectorByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param>
        /// <returns>ItemSector</returns>
        ItemSector GetItemSectorById (int? itemSectorId);
  
        /// <summary>
        /// Get an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param>
        /// <returns>ApiResponse of ItemSector</returns>
        ApiResponse<ItemSector> GetItemSectorByIdWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Get the tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSector tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param>
        /// <returns></returns>
        void GetItemSectorTags (int? itemSectorId);
  
        /// <summary>
        /// Get the tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSector tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetItemSectorTagsWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Update an itemSector
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param>
        /// <returns></returns>
        void UpdateItemSector (ItemSector body);
  
        /// <summary>
        /// Update an itemSector
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemSectorWithHttpInfo (ItemSector body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an itemSector
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param>
        /// <returns>Task of ItemSector</returns>
        System.Threading.Tasks.Task<ItemSector> AddItemSectorAsync (ItemSector body);

        /// <summary>
        /// Create an itemSector
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemSector)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSector>> AddItemSectorAsyncWithHttpInfo (ItemSector body);
        
        /// <summary>
        /// Add new audit for an itemSector
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param>
        /// <param name="itemSectorAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemSectorAuditAsync (int? itemSectorId, string itemSectorAudit);

        /// <summary>
        /// Add new audit for an itemSector
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param>
        /// <param name="itemSectorAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSectorAuditAsyncWithHttpInfo (int? itemSectorId, string itemSectorAudit);
        
        /// <summary>
        /// Add new tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param>
        /// <param name="itemSectorTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemSectorTagAsync (int? itemSectorId, string itemSectorTag);

        /// <summary>
        /// Add new tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSector.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param>
        /// <param name="itemSectorTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSectorTagAsyncWithHttpInfo (int? itemSectorId, string itemSectorTag);
        
        /// <summary>
        /// Delete an itemSector
        /// </summary>
        /// <remarks>
        /// Deletes the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemSectorAsync (int? itemSectorId);

        /// <summary>
        /// Delete an itemSector
        /// </summary>
        /// <remarks>
        /// Deletes the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSectorAsyncWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Delete a tag for an itemSector.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSector tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param>
        /// <param name="itemSectorTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemSectorTagAsync (int? itemSectorId, string itemSectorTag);

        /// <summary>
        /// Delete a tag for an itemSector.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSector tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param>
        /// <param name="itemSectorTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSectorTagAsyncWithHttpInfo (int? itemSectorId, string itemSectorTag);
        
        /// <summary>
        /// Get a duplicated an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param>
        /// <returns>Task of ItemSector</returns>
        System.Threading.Tasks.Task<ItemSector> GetDuplicateItemSectorByIdAsync (int? itemSectorId);

        /// <summary>
        /// Get a duplicated an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemSector)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSector>> GetDuplicateItemSectorByIdAsyncWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Search itemSectors by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSectors that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemSector&gt;</returns>
        System.Threading.Tasks.Task<List<ItemSector>> GetItemSectorByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search itemSectors by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSectors that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemSector&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemSector>>> GetItemSectorByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param>
        /// <returns>Task of ItemSector</returns>
        System.Threading.Tasks.Task<ItemSector> GetItemSectorByIdAsync (int? itemSectorId);

        /// <summary>
        /// Get an itemSector by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSector identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param>
        /// <returns>Task of ApiResponse (ItemSector)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSector>> GetItemSectorByIdAsyncWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Get the tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSector tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetItemSectorTagsAsync (int? itemSectorId);

        /// <summary>
        /// Get the tags for an itemSector.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSector tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetItemSectorTagsAsyncWithHttpInfo (int? itemSectorId);
        
        /// <summary>
        /// Update an itemSector
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemSectorAsync (ItemSector body);

        /// <summary>
        /// Update an itemSector
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSector using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemSectorAsyncWithHttpInfo (ItemSector body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemSectorApi : IItemSectorApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemSectorApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSectorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemSectorApi(Configuration configuration = null)
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
        /// Create an itemSector Inserts a new itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param> 
        /// <returns>ItemSector</returns>
        public ItemSector AddItemSector (ItemSector body)
        {
             ApiResponse<ItemSector> localVarResponse = AddItemSectorWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an itemSector Inserts a new itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param> 
        /// <returns>ApiResponse of ItemSector</returns>
        public ApiResponse< ItemSector > AddItemSectorWithHttpInfo (ItemSector body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemSectorApi->AddItemSector");
            
    
            var localVarPath = "/beta/itemSector";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSector: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSector: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSector>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSector) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSector)));
            
        }

        
        /// <summary>
        /// Create an itemSector Inserts a new itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param>
        /// <returns>Task of ItemSector</returns>
        public async System.Threading.Tasks.Task<ItemSector> AddItemSectorAsync (ItemSector body)
        {
             ApiResponse<ItemSector> localVarResponse = await AddItemSectorAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an itemSector Inserts a new itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemSector)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSector>> AddItemSectorAsyncWithHttpInfo (ItemSector body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddItemSector");
            
    
            var localVarPath = "/beta/itemSector";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSector: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSector: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSector>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSector) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSector)));
            
        }
        
        /// <summary>
        /// Add new audit for an itemSector Adds an audit to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param> 
        /// <param name="itemSectorAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddItemSectorAudit (int? itemSectorId, string itemSectorAudit)
        {
             AddItemSectorAuditWithHttpInfo(itemSectorId, itemSectorAudit);
        }

        /// <summary>
        /// Add new audit for an itemSector Adds an audit to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param> 
        /// <param name="itemSectorAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemSectorAuditWithHttpInfo (int? itemSectorId, string itemSectorAudit)
        {
            
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling ItemSectorApi->AddItemSectorAudit");
            
            // verify the required parameter 'itemSectorAudit' is set
            if (itemSectorAudit == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorAudit' when calling ItemSectorApi->AddItemSectorAudit");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/audit/{itemSectorAudit}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            if (itemSectorAudit != null) localVarPathParams.Add("itemSectorAudit", Configuration.ApiClient.ParameterToString(itemSectorAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an itemSector Adds an audit to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param>
        /// <param name="itemSectorAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemSectorAuditAsync (int? itemSectorId, string itemSectorAudit)
        {
             await AddItemSectorAuditAsyncWithHttpInfo(itemSectorId, itemSectorAudit);

        }

        /// <summary>
        /// Add new audit for an itemSector Adds an audit to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add an audit to</param>
        /// <param name="itemSectorAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSectorAuditAsyncWithHttpInfo (int? itemSectorId, string itemSectorAudit)
        {
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null) throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling AddItemSectorAudit");
            // verify the required parameter 'itemSectorAudit' is set
            if (itemSectorAudit == null) throw new ApiException(400, "Missing required parameter 'itemSectorAudit' when calling AddItemSectorAudit");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/audit/{itemSectorAudit}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            if (itemSectorAudit != null) localVarPathParams.Add("itemSectorAudit", Configuration.ApiClient.ParameterToString(itemSectorAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an itemSector. Adds a tag to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param> 
        /// <param name="itemSectorTag">The tag to add</param> 
        /// <returns></returns>
        public void AddItemSectorTag (int? itemSectorId, string itemSectorTag)
        {
             AddItemSectorTagWithHttpInfo(itemSectorId, itemSectorTag);
        }

        /// <summary>
        /// Add new tags for an itemSector. Adds a tag to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param> 
        /// <param name="itemSectorTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemSectorTagWithHttpInfo (int? itemSectorId, string itemSectorTag)
        {
            
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling ItemSectorApi->AddItemSectorTag");
            
            // verify the required parameter 'itemSectorTag' is set
            if (itemSectorTag == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorTag' when calling ItemSectorApi->AddItemSectorTag");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/tag/{itemSectorTag}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            if (itemSectorTag != null) localVarPathParams.Add("itemSectorTag", Configuration.ApiClient.ParameterToString(itemSectorTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an itemSector. Adds a tag to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param>
        /// <param name="itemSectorTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemSectorTagAsync (int? itemSectorId, string itemSectorTag)
        {
             await AddItemSectorTagAsyncWithHttpInfo(itemSectorId, itemSectorTag);

        }

        /// <summary>
        /// Add new tags for an itemSector. Adds a tag to an existing itemSector.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to add a tag to</param>
        /// <param name="itemSectorTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSectorTagAsyncWithHttpInfo (int? itemSectorId, string itemSectorTag)
        {
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null) throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling AddItemSectorTag");
            // verify the required parameter 'itemSectorTag' is set
            if (itemSectorTag == null) throw new ApiException(400, "Missing required parameter 'itemSectorTag' when calling AddItemSectorTag");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/tag/{itemSectorTag}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            if (itemSectorTag != null) localVarPathParams.Add("itemSectorTag", Configuration.ApiClient.ParameterToString(itemSectorTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSectorTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an itemSector Deletes the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param> 
        /// <returns></returns>
        public void DeleteItemSector (int? itemSectorId)
        {
             DeleteItemSectorWithHttpInfo(itemSectorId);
        }

        /// <summary>
        /// Delete an itemSector Deletes the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemSectorWithHttpInfo (int? itemSectorId)
        {
            
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling ItemSectorApi->DeleteItemSector");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSector: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSector: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an itemSector Deletes the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemSectorAsync (int? itemSectorId)
        {
             await DeleteItemSectorAsyncWithHttpInfo(itemSectorId);

        }

        /// <summary>
        /// Delete an itemSector Deletes the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSectorAsyncWithHttpInfo (int? itemSectorId)
        {
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null) throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling DeleteItemSector");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSector: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSector: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an itemSector. Deletes an existing itemSector tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param> 
        /// <param name="itemSectorTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteItemSectorTag (int? itemSectorId, string itemSectorTag)
        {
             DeleteItemSectorTagWithHttpInfo(itemSectorId, itemSectorTag);
        }

        /// <summary>
        /// Delete a tag for an itemSector. Deletes an existing itemSector tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param> 
        /// <param name="itemSectorTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemSectorTagWithHttpInfo (int? itemSectorId, string itemSectorTag)
        {
            
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling ItemSectorApi->DeleteItemSectorTag");
            
            // verify the required parameter 'itemSectorTag' is set
            if (itemSectorTag == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorTag' when calling ItemSectorApi->DeleteItemSectorTag");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/tag/{itemSectorTag}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            if (itemSectorTag != null) localVarPathParams.Add("itemSectorTag", Configuration.ApiClient.ParameterToString(itemSectorTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSectorTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSectorTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an itemSector. Deletes an existing itemSector tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param>
        /// <param name="itemSectorTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemSectorTagAsync (int? itemSectorId, string itemSectorTag)
        {
             await DeleteItemSectorTagAsyncWithHttpInfo(itemSectorId, itemSectorTag);

        }

        /// <summary>
        /// Delete a tag for an itemSector. Deletes an existing itemSector tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to remove tag from</param>
        /// <param name="itemSectorTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSectorTagAsyncWithHttpInfo (int? itemSectorId, string itemSectorTag)
        {
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null) throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling DeleteItemSectorTag");
            // verify the required parameter 'itemSectorTag' is set
            if (itemSectorTag == null) throw new ApiException(400, "Missing required parameter 'itemSectorTag' when calling DeleteItemSectorTag");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/tag/{itemSectorTag}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            if (itemSectorTag != null) localVarPathParams.Add("itemSectorTag", Configuration.ApiClient.ParameterToString(itemSectorTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSectorTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSectorTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an itemSector by id Returns a duplicated itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param> 
        /// <returns>ItemSector</returns>
        public ItemSector GetDuplicateItemSectorById (int? itemSectorId)
        {
             ApiResponse<ItemSector> localVarResponse = GetDuplicateItemSectorByIdWithHttpInfo(itemSectorId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an itemSector by id Returns a duplicated itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param> 
        /// <returns>ApiResponse of ItemSector</returns>
        public ApiResponse< ItemSector > GetDuplicateItemSectorByIdWithHttpInfo (int? itemSectorId)
        {
            
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling ItemSectorApi->GetDuplicateItemSectorById");
            
    
            var localVarPath = "/beta/itemSector/duplicate/{itemSectorId}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSectorById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSectorById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSector>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSector) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSector)));
            
        }

        
        /// <summary>
        /// Get a duplicated an itemSector by id Returns a duplicated itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param>
        /// <returns>Task of ItemSector</returns>
        public async System.Threading.Tasks.Task<ItemSector> GetDuplicateItemSectorByIdAsync (int? itemSectorId)
        {
             ApiResponse<ItemSector> localVarResponse = await GetDuplicateItemSectorByIdAsyncWithHttpInfo(itemSectorId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an itemSector by id Returns a duplicated itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemSector)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSector>> GetDuplicateItemSectorByIdAsyncWithHttpInfo (int? itemSectorId)
        {
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null) throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling GetDuplicateItemSectorById");
            
    
            var localVarPath = "/beta/itemSector/duplicate/{itemSectorId}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSectorById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSectorById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSector>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSector) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSector)));
            
        }
        
        /// <summary>
        /// Search itemSectors by filter Returns the list of itemSectors that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ItemSector&gt;</returns>
        public List<ItemSector> GetItemSectorByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemSector>> localVarResponse = GetItemSectorByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemSectors by filter Returns the list of itemSectors that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemSector&gt;</returns>
        public ApiResponse< List<ItemSector> > GetItemSectorByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemSector/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemSector>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemSector>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemSector>)));
            
        }

        
        /// <summary>
        /// Search itemSectors by filter Returns the list of itemSectors that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemSector&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemSector>> GetItemSectorByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemSector>> localVarResponse = await GetItemSectorByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemSectors by filter Returns the list of itemSectors that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemSector&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemSector>>> GetItemSectorByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemSector/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemSector>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemSector>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemSector>)));
            
        }
        
        /// <summary>
        /// Get an itemSector by id Returns the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param> 
        /// <returns>ItemSector</returns>
        public ItemSector GetItemSectorById (int? itemSectorId)
        {
             ApiResponse<ItemSector> localVarResponse = GetItemSectorByIdWithHttpInfo(itemSectorId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemSector by id Returns the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param> 
        /// <returns>ApiResponse of ItemSector</returns>
        public ApiResponse< ItemSector > GetItemSectorByIdWithHttpInfo (int? itemSectorId)
        {
            
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling ItemSectorApi->GetItemSectorById");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSector>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSector) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSector)));
            
        }

        
        /// <summary>
        /// Get an itemSector by id Returns the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param>
        /// <returns>Task of ItemSector</returns>
        public async System.Threading.Tasks.Task<ItemSector> GetItemSectorByIdAsync (int? itemSectorId)
        {
             ApiResponse<ItemSector> localVarResponse = await GetItemSectorByIdAsyncWithHttpInfo(itemSectorId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemSector by id Returns the itemSector identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to be returned.</param>
        /// <returns>Task of ApiResponse (ItemSector)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSector>> GetItemSectorByIdAsyncWithHttpInfo (int? itemSectorId)
        {
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null) throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling GetItemSectorById");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSector>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSector) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSector)));
            
        }
        
        /// <summary>
        /// Get the tags for an itemSector. Get all existing itemSector tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param> 
        /// <returns></returns>
        public void GetItemSectorTags (int? itemSectorId)
        {
             GetItemSectorTagsWithHttpInfo(itemSectorId);
        }

        /// <summary>
        /// Get the tags for an itemSector. Get all existing itemSector tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetItemSectorTagsWithHttpInfo (int? itemSectorId)
        {
            
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null)
                throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling ItemSectorApi->GetItemSectorTags");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/tag";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an itemSector. Get all existing itemSector tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetItemSectorTagsAsync (int? itemSectorId)
        {
             await GetItemSectorTagsAsyncWithHttpInfo(itemSectorId);

        }

        /// <summary>
        /// Get the tags for an itemSector. Get all existing itemSector tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSectorId">Id of the itemSector to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetItemSectorTagsAsyncWithHttpInfo (int? itemSectorId)
        {
            // verify the required parameter 'itemSectorId' is set
            if (itemSectorId == null) throw new ApiException(400, "Missing required parameter 'itemSectorId' when calling GetItemSectorTags");
            
    
            var localVarPath = "/beta/itemSector/{itemSectorId}/tag";
    
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
            if (itemSectorId != null) localVarPathParams.Add("itemSectorId", Configuration.ApiClient.ParameterToString(itemSectorId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSectorTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemSector Updates an existing itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemSector (ItemSector body)
        {
             UpdateItemSectorWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemSector Updates an existing itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemSectorWithHttpInfo (ItemSector body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemSectorApi->UpdateItemSector");
            
    
            var localVarPath = "/beta/itemSector";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSector: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSector: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemSector Updates an existing itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemSectorAsync (ItemSector body)
        {
             await UpdateItemSectorAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemSector Updates an existing itemSector using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSector to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemSectorAsyncWithHttpInfo (ItemSector body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemSector");
            
    
            var localVarPath = "/beta/itemSector";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSector: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSector: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
