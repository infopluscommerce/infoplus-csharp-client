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
    public interface IItemReceiptActivityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param>
        /// <returns>ItemReceiptActivity</returns>
        ItemReceiptActivity AddItemReceiptActivity (ItemReceiptActivity body);
  
        /// <summary>
        /// Create an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param>
        /// <returns>ApiResponse of ItemReceiptActivity</returns>
        ApiResponse<ItemReceiptActivity> AddItemReceiptActivityWithHttpInfo (ItemReceiptActivity body);
        
        /// <summary>
        /// Add new audit for an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param>
        /// <param name="itemReceiptActivityAudit">The audit to add</param>
        /// <returns></returns>
        void AddItemReceiptActivityAudit (int? itemReceiptActivityId, string itemReceiptActivityAudit);
  
        /// <summary>
        /// Add new audit for an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param>
        /// <param name="itemReceiptActivityAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemReceiptActivityAuditWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityAudit);
        
        /// <summary>
        /// Add new tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param>
        /// <param name="itemReceiptActivityTag">The tag to add</param>
        /// <returns></returns>
        void AddItemReceiptActivityTag (int? itemReceiptActivityId, string itemReceiptActivityTag);
  
        /// <summary>
        /// Add new tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param>
        /// <param name="itemReceiptActivityTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemReceiptActivityTagWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag);
        
        /// <summary>
        /// Delete an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Deletes the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param>
        /// <returns></returns>
        void DeleteItemReceiptActivity (int? itemReceiptActivityId);
  
        /// <summary>
        /// Delete an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Deletes the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemReceiptActivityWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Delete a tag for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceiptActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param>
        /// <param name="itemReceiptActivityTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteItemReceiptActivityTag (int? itemReceiptActivityId, string itemReceiptActivityTag);
  
        /// <summary>
        /// Delete a tag for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceiptActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param>
        /// <param name="itemReceiptActivityTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemReceiptActivityTagWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag);
        
        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param>
        /// <returns>ItemReceiptActivity</returns>
        ItemReceiptActivity GetDuplicateItemReceiptActivityById (int? itemReceiptActivityId);
  
        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param>
        /// <returns>ApiResponse of ItemReceiptActivity</returns>
        ApiResponse<ItemReceiptActivity> GetDuplicateItemReceiptActivityByIdWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Search itemReceiptActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceiptActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ItemReceiptActivity&gt;</returns>
        List<ItemReceiptActivity> GetItemReceiptActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search itemReceiptActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceiptActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemReceiptActivity&gt;</returns>
        ApiResponse<List<ItemReceiptActivity>> GetItemReceiptActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param>
        /// <returns>ItemReceiptActivity</returns>
        ItemReceiptActivity GetItemReceiptActivityById (int? itemReceiptActivityId);
  
        /// <summary>
        /// Get an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param>
        /// <returns>ApiResponse of ItemReceiptActivity</returns>
        ApiResponse<ItemReceiptActivity> GetItemReceiptActivityByIdWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Get the tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceiptActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param>
        /// <returns></returns>
        void GetItemReceiptActivityTags (int? itemReceiptActivityId);
  
        /// <summary>
        /// Get the tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceiptActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetItemReceiptActivityTagsWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Update an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param>
        /// <returns></returns>
        void UpdateItemReceiptActivity (ItemReceiptActivity body);
  
        /// <summary>
        /// Update an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemReceiptActivityWithHttpInfo (ItemReceiptActivity body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param>
        /// <returns>Task of ItemReceiptActivity</returns>
        System.Threading.Tasks.Task<ItemReceiptActivity> AddItemReceiptActivityAsync (ItemReceiptActivity body);

        /// <summary>
        /// Create an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemReceiptActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemReceiptActivity>> AddItemReceiptActivityAsyncWithHttpInfo (ItemReceiptActivity body);
        
        /// <summary>
        /// Add new audit for an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param>
        /// <param name="itemReceiptActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemReceiptActivityAuditAsync (int? itemReceiptActivityId, string itemReceiptActivityAudit);

        /// <summary>
        /// Add new audit for an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param>
        /// <param name="itemReceiptActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptActivityAuditAsyncWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityAudit);
        
        /// <summary>
        /// Add new tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param>
        /// <param name="itemReceiptActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemReceiptActivityTagAsync (int? itemReceiptActivityId, string itemReceiptActivityTag);

        /// <summary>
        /// Add new tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceiptActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param>
        /// <param name="itemReceiptActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptActivityTagAsyncWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag);
        
        /// <summary>
        /// Delete an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Deletes the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemReceiptActivityAsync (int? itemReceiptActivityId);

        /// <summary>
        /// Delete an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Deletes the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemReceiptActivityAsyncWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Delete a tag for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceiptActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param>
        /// <param name="itemReceiptActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemReceiptActivityTagAsync (int? itemReceiptActivityId, string itemReceiptActivityTag);

        /// <summary>
        /// Delete a tag for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceiptActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param>
        /// <param name="itemReceiptActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemReceiptActivityTagAsyncWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag);
        
        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param>
        /// <returns>Task of ItemReceiptActivity</returns>
        System.Threading.Tasks.Task<ItemReceiptActivity> GetDuplicateItemReceiptActivityByIdAsync (int? itemReceiptActivityId);

        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemReceiptActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemReceiptActivity>> GetDuplicateItemReceiptActivityByIdAsyncWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Search itemReceiptActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceiptActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemReceiptActivity&gt;</returns>
        System.Threading.Tasks.Task<List<ItemReceiptActivity>> GetItemReceiptActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search itemReceiptActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceiptActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemReceiptActivity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemReceiptActivity>>> GetItemReceiptActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param>
        /// <returns>Task of ItemReceiptActivity</returns>
        System.Threading.Tasks.Task<ItemReceiptActivity> GetItemReceiptActivityByIdAsync (int? itemReceiptActivityId);

        /// <summary>
        /// Get an itemReceiptActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceiptActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param>
        /// <returns>Task of ApiResponse (ItemReceiptActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemReceiptActivity>> GetItemReceiptActivityByIdAsyncWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Get the tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceiptActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetItemReceiptActivityTagsAsync (int? itemReceiptActivityId);

        /// <summary>
        /// Get the tags for an itemReceiptActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceiptActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetItemReceiptActivityTagsAsyncWithHttpInfo (int? itemReceiptActivityId);
        
        /// <summary>
        /// Update an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemReceiptActivityAsync (ItemReceiptActivity body);

        /// <summary>
        /// Update an itemReceiptActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceiptActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemReceiptActivityAsyncWithHttpInfo (ItemReceiptActivity body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemReceiptActivityApi : IItemReceiptActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReceiptActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemReceiptActivityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReceiptActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemReceiptActivityApi(Configuration configuration = null)
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
        /// Create an itemReceiptActivity Inserts a new itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param> 
        /// <returns>ItemReceiptActivity</returns>
        public ItemReceiptActivity AddItemReceiptActivity (ItemReceiptActivity body)
        {
             ApiResponse<ItemReceiptActivity> localVarResponse = AddItemReceiptActivityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an itemReceiptActivity Inserts a new itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param> 
        /// <returns>ApiResponse of ItemReceiptActivity</returns>
        public ApiResponse< ItemReceiptActivity > AddItemReceiptActivityWithHttpInfo (ItemReceiptActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemReceiptActivityApi->AddItemReceiptActivity");
            
    
            var localVarPath = "/beta/itemReceiptActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemReceiptActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceiptActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceiptActivity)));
            
        }

        
        /// <summary>
        /// Create an itemReceiptActivity Inserts a new itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param>
        /// <returns>Task of ItemReceiptActivity</returns>
        public async System.Threading.Tasks.Task<ItemReceiptActivity> AddItemReceiptActivityAsync (ItemReceiptActivity body)
        {
             ApiResponse<ItemReceiptActivity> localVarResponse = await AddItemReceiptActivityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an itemReceiptActivity Inserts a new itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemReceiptActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemReceiptActivity>> AddItemReceiptActivityAsyncWithHttpInfo (ItemReceiptActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddItemReceiptActivity");
            
    
            var localVarPath = "/beta/itemReceiptActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemReceiptActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceiptActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceiptActivity)));
            
        }
        
        /// <summary>
        /// Add new audit for an itemReceiptActivity Adds an audit to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param> 
        /// <param name="itemReceiptActivityAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddItemReceiptActivityAudit (int? itemReceiptActivityId, string itemReceiptActivityAudit)
        {
             AddItemReceiptActivityAuditWithHttpInfo(itemReceiptActivityId, itemReceiptActivityAudit);
        }

        /// <summary>
        /// Add new audit for an itemReceiptActivity Adds an audit to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param> 
        /// <param name="itemReceiptActivityAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemReceiptActivityAuditWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityAudit)
        {
            
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling ItemReceiptActivityApi->AddItemReceiptActivityAudit");
            
            // verify the required parameter 'itemReceiptActivityAudit' is set
            if (itemReceiptActivityAudit == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityAudit' when calling ItemReceiptActivityApi->AddItemReceiptActivityAudit");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/audit/{itemReceiptActivityAudit}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            if (itemReceiptActivityAudit != null) localVarPathParams.Add("itemReceiptActivityAudit", Configuration.ApiClient.ParameterToString(itemReceiptActivityAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an itemReceiptActivity Adds an audit to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param>
        /// <param name="itemReceiptActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemReceiptActivityAuditAsync (int? itemReceiptActivityId, string itemReceiptActivityAudit)
        {
             await AddItemReceiptActivityAuditAsyncWithHttpInfo(itemReceiptActivityId, itemReceiptActivityAudit);

        }

        /// <summary>
        /// Add new audit for an itemReceiptActivity Adds an audit to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add an audit to</param>
        /// <param name="itemReceiptActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptActivityAuditAsyncWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityAudit)
        {
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling AddItemReceiptActivityAudit");
            // verify the required parameter 'itemReceiptActivityAudit' is set
            if (itemReceiptActivityAudit == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityAudit' when calling AddItemReceiptActivityAudit");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/audit/{itemReceiptActivityAudit}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            if (itemReceiptActivityAudit != null) localVarPathParams.Add("itemReceiptActivityAudit", Configuration.ApiClient.ParameterToString(itemReceiptActivityAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an itemReceiptActivity. Adds a tag to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param> 
        /// <param name="itemReceiptActivityTag">The tag to add</param> 
        /// <returns></returns>
        public void AddItemReceiptActivityTag (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
             AddItemReceiptActivityTagWithHttpInfo(itemReceiptActivityId, itemReceiptActivityTag);
        }

        /// <summary>
        /// Add new tags for an itemReceiptActivity. Adds a tag to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param> 
        /// <param name="itemReceiptActivityTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemReceiptActivityTagWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
            
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling ItemReceiptActivityApi->AddItemReceiptActivityTag");
            
            // verify the required parameter 'itemReceiptActivityTag' is set
            if (itemReceiptActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityTag' when calling ItemReceiptActivityApi->AddItemReceiptActivityTag");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/tag/{itemReceiptActivityTag}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            if (itemReceiptActivityTag != null) localVarPathParams.Add("itemReceiptActivityTag", Configuration.ApiClient.ParameterToString(itemReceiptActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an itemReceiptActivity. Adds a tag to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param>
        /// <param name="itemReceiptActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemReceiptActivityTagAsync (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
             await AddItemReceiptActivityTagAsyncWithHttpInfo(itemReceiptActivityId, itemReceiptActivityTag);

        }

        /// <summary>
        /// Add new tags for an itemReceiptActivity. Adds a tag to an existing itemReceiptActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to add a tag to</param>
        /// <param name="itemReceiptActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptActivityTagAsyncWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling AddItemReceiptActivityTag");
            // verify the required parameter 'itemReceiptActivityTag' is set
            if (itemReceiptActivityTag == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityTag' when calling AddItemReceiptActivityTag");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/tag/{itemReceiptActivityTag}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            if (itemReceiptActivityTag != null) localVarPathParams.Add("itemReceiptActivityTag", Configuration.ApiClient.ParameterToString(itemReceiptActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an itemReceiptActivity Deletes the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param> 
        /// <returns></returns>
        public void DeleteItemReceiptActivity (int? itemReceiptActivityId)
        {
             DeleteItemReceiptActivityWithHttpInfo(itemReceiptActivityId);
        }

        /// <summary>
        /// Delete an itemReceiptActivity Deletes the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemReceiptActivityWithHttpInfo (int? itemReceiptActivityId)
        {
            
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling ItemReceiptActivityApi->DeleteItemReceiptActivity");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an itemReceiptActivity Deletes the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemReceiptActivityAsync (int? itemReceiptActivityId)
        {
             await DeleteItemReceiptActivityAsyncWithHttpInfo(itemReceiptActivityId);

        }

        /// <summary>
        /// Delete an itemReceiptActivity Deletes the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemReceiptActivityAsyncWithHttpInfo (int? itemReceiptActivityId)
        {
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling DeleteItemReceiptActivity");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an itemReceiptActivity. Deletes an existing itemReceiptActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param> 
        /// <param name="itemReceiptActivityTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteItemReceiptActivityTag (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
             DeleteItemReceiptActivityTagWithHttpInfo(itemReceiptActivityId, itemReceiptActivityTag);
        }

        /// <summary>
        /// Delete a tag for an itemReceiptActivity. Deletes an existing itemReceiptActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param> 
        /// <param name="itemReceiptActivityTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemReceiptActivityTagWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
            
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling ItemReceiptActivityApi->DeleteItemReceiptActivityTag");
            
            // verify the required parameter 'itemReceiptActivityTag' is set
            if (itemReceiptActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityTag' when calling ItemReceiptActivityApi->DeleteItemReceiptActivityTag");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/tag/{itemReceiptActivityTag}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            if (itemReceiptActivityTag != null) localVarPathParams.Add("itemReceiptActivityTag", Configuration.ApiClient.ParameterToString(itemReceiptActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an itemReceiptActivity. Deletes an existing itemReceiptActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param>
        /// <param name="itemReceiptActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemReceiptActivityTagAsync (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
             await DeleteItemReceiptActivityTagAsyncWithHttpInfo(itemReceiptActivityId, itemReceiptActivityTag);

        }

        /// <summary>
        /// Delete a tag for an itemReceiptActivity. Deletes an existing itemReceiptActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to remove tag from</param>
        /// <param name="itemReceiptActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemReceiptActivityTagAsyncWithHttpInfo (int? itemReceiptActivityId, string itemReceiptActivityTag)
        {
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling DeleteItemReceiptActivityTag");
            // verify the required parameter 'itemReceiptActivityTag' is set
            if (itemReceiptActivityTag == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityTag' when calling DeleteItemReceiptActivityTag");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/tag/{itemReceiptActivityTag}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            if (itemReceiptActivityTag != null) localVarPathParams.Add("itemReceiptActivityTag", Configuration.ApiClient.ParameterToString(itemReceiptActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param> 
        /// <returns>ItemReceiptActivity</returns>
        public ItemReceiptActivity GetDuplicateItemReceiptActivityById (int? itemReceiptActivityId)
        {
             ApiResponse<ItemReceiptActivity> localVarResponse = GetDuplicateItemReceiptActivityByIdWithHttpInfo(itemReceiptActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param> 
        /// <returns>ApiResponse of ItemReceiptActivity</returns>
        public ApiResponse< ItemReceiptActivity > GetDuplicateItemReceiptActivityByIdWithHttpInfo (int? itemReceiptActivityId)
        {
            
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling ItemReceiptActivityApi->GetDuplicateItemReceiptActivityById");
            
    
            var localVarPath = "/beta/itemReceiptActivity/duplicate/{itemReceiptActivityId}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemReceiptActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceiptActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceiptActivity)));
            
        }

        
        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param>
        /// <returns>Task of ItemReceiptActivity</returns>
        public async System.Threading.Tasks.Task<ItemReceiptActivity> GetDuplicateItemReceiptActivityByIdAsync (int? itemReceiptActivityId)
        {
             ApiResponse<ItemReceiptActivity> localVarResponse = await GetDuplicateItemReceiptActivityByIdAsyncWithHttpInfo(itemReceiptActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an itemReceiptActivity by id Returns a duplicated itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemReceiptActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemReceiptActivity>> GetDuplicateItemReceiptActivityByIdAsyncWithHttpInfo (int? itemReceiptActivityId)
        {
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling GetDuplicateItemReceiptActivityById");
            
    
            var localVarPath = "/beta/itemReceiptActivity/duplicate/{itemReceiptActivityId}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemReceiptActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceiptActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceiptActivity)));
            
        }
        
        /// <summary>
        /// Search itemReceiptActivitys by filter Returns the list of itemReceiptActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ItemReceiptActivity&gt;</returns>
        public List<ItemReceiptActivity> GetItemReceiptActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemReceiptActivity>> localVarResponse = GetItemReceiptActivityByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemReceiptActivitys by filter Returns the list of itemReceiptActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemReceiptActivity&gt;</returns>
        public ApiResponse< List<ItemReceiptActivity> > GetItemReceiptActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemReceiptActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemReceiptActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemReceiptActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemReceiptActivity>)));
            
        }

        
        /// <summary>
        /// Search itemReceiptActivitys by filter Returns the list of itemReceiptActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemReceiptActivity&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemReceiptActivity>> GetItemReceiptActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemReceiptActivity>> localVarResponse = await GetItemReceiptActivityByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemReceiptActivitys by filter Returns the list of itemReceiptActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemReceiptActivity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemReceiptActivity>>> GetItemReceiptActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemReceiptActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemReceiptActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemReceiptActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemReceiptActivity>)));
            
        }
        
        /// <summary>
        /// Get an itemReceiptActivity by id Returns the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param> 
        /// <returns>ItemReceiptActivity</returns>
        public ItemReceiptActivity GetItemReceiptActivityById (int? itemReceiptActivityId)
        {
             ApiResponse<ItemReceiptActivity> localVarResponse = GetItemReceiptActivityByIdWithHttpInfo(itemReceiptActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemReceiptActivity by id Returns the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param> 
        /// <returns>ApiResponse of ItemReceiptActivity</returns>
        public ApiResponse< ItemReceiptActivity > GetItemReceiptActivityByIdWithHttpInfo (int? itemReceiptActivityId)
        {
            
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling ItemReceiptActivityApi->GetItemReceiptActivityById");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemReceiptActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceiptActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceiptActivity)));
            
        }

        
        /// <summary>
        /// Get an itemReceiptActivity by id Returns the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param>
        /// <returns>Task of ItemReceiptActivity</returns>
        public async System.Threading.Tasks.Task<ItemReceiptActivity> GetItemReceiptActivityByIdAsync (int? itemReceiptActivityId)
        {
             ApiResponse<ItemReceiptActivity> localVarResponse = await GetItemReceiptActivityByIdAsyncWithHttpInfo(itemReceiptActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemReceiptActivity by id Returns the itemReceiptActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to be returned.</param>
        /// <returns>Task of ApiResponse (ItemReceiptActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemReceiptActivity>> GetItemReceiptActivityByIdAsyncWithHttpInfo (int? itemReceiptActivityId)
        {
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling GetItemReceiptActivityById");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemReceiptActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceiptActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceiptActivity)));
            
        }
        
        /// <summary>
        /// Get the tags for an itemReceiptActivity. Get all existing itemReceiptActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param> 
        /// <returns></returns>
        public void GetItemReceiptActivityTags (int? itemReceiptActivityId)
        {
             GetItemReceiptActivityTagsWithHttpInfo(itemReceiptActivityId);
        }

        /// <summary>
        /// Get the tags for an itemReceiptActivity. Get all existing itemReceiptActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetItemReceiptActivityTagsWithHttpInfo (int? itemReceiptActivityId)
        {
            
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling ItemReceiptActivityApi->GetItemReceiptActivityTags");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/tag";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an itemReceiptActivity. Get all existing itemReceiptActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetItemReceiptActivityTagsAsync (int? itemReceiptActivityId)
        {
             await GetItemReceiptActivityTagsAsyncWithHttpInfo(itemReceiptActivityId);

        }

        /// <summary>
        /// Get the tags for an itemReceiptActivity. Get all existing itemReceiptActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptActivityId">Id of the itemReceiptActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetItemReceiptActivityTagsAsyncWithHttpInfo (int? itemReceiptActivityId)
        {
            // verify the required parameter 'itemReceiptActivityId' is set
            if (itemReceiptActivityId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptActivityId' when calling GetItemReceiptActivityTags");
            
    
            var localVarPath = "/beta/itemReceiptActivity/{itemReceiptActivityId}/tag";
    
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
            if (itemReceiptActivityId != null) localVarPathParams.Add("itemReceiptActivityId", Configuration.ApiClient.ParameterToString(itemReceiptActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemReceiptActivity Updates an existing itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemReceiptActivity (ItemReceiptActivity body)
        {
             UpdateItemReceiptActivityWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemReceiptActivity Updates an existing itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemReceiptActivityWithHttpInfo (ItemReceiptActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemReceiptActivityApi->UpdateItemReceiptActivity");
            
    
            var localVarPath = "/beta/itemReceiptActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemReceiptActivity Updates an existing itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemReceiptActivityAsync (ItemReceiptActivity body)
        {
             await UpdateItemReceiptActivityAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemReceiptActivity Updates an existing itemReceiptActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceiptActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemReceiptActivityAsyncWithHttpInfo (ItemReceiptActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemReceiptActivity");
            
    
            var localVarPath = "/beta/itemReceiptActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
