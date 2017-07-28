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
    public interface IItemSummaryCodeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param>
        /// <returns>ItemSummaryCode</returns>
        ItemSummaryCode AddItemSummaryCode (ItemSummaryCode body);
  
        /// <summary>
        /// Create an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param>
        /// <returns>ApiResponse of ItemSummaryCode</returns>
        ApiResponse<ItemSummaryCode> AddItemSummaryCodeWithHttpInfo (ItemSummaryCode body);
        
        /// <summary>
        /// Add new audit for an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param>
        /// <param name="itemSummaryCodeAudit">The audit to add</param>
        /// <returns></returns>
        void AddItemSummaryCodeAudit (int? itemSummaryCodeId, string itemSummaryCodeAudit);
  
        /// <summary>
        /// Add new audit for an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param>
        /// <param name="itemSummaryCodeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemSummaryCodeAuditWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeAudit);
        
        /// <summary>
        /// Add new tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param>
        /// <param name="itemSummaryCodeTag">The tag to add</param>
        /// <returns></returns>
        void AddItemSummaryCodeTag (int? itemSummaryCodeId, string itemSummaryCodeTag);
  
        /// <summary>
        /// Add new tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param>
        /// <param name="itemSummaryCodeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemSummaryCodeTagWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag);
        
        /// <summary>
        /// Delete an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param>
        /// <returns></returns>
        void DeleteItemSummaryCode (int? itemSummaryCodeId);
  
        /// <summary>
        /// Delete an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemSummaryCodeWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Delete a tag for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSummaryCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param>
        /// <param name="itemSummaryCodeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteItemSummaryCodeTag (int? itemSummaryCodeId, string itemSummaryCodeTag);
  
        /// <summary>
        /// Delete a tag for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSummaryCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param>
        /// <param name="itemSummaryCodeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemSummaryCodeTagWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag);
        
        /// <summary>
        /// Get a duplicated an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param>
        /// <returns>ItemSummaryCode</returns>
        ItemSummaryCode GetDuplicateItemSummaryCodeById (int? itemSummaryCodeId);
  
        /// <summary>
        /// Get a duplicated an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param>
        /// <returns>ApiResponse of ItemSummaryCode</returns>
        ApiResponse<ItemSummaryCode> GetDuplicateItemSummaryCodeByIdWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Search itemSummaryCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSummaryCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ItemSummaryCode&gt;</returns>
        List<ItemSummaryCode> GetItemSummaryCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search itemSummaryCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSummaryCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemSummaryCode&gt;</returns>
        ApiResponse<List<ItemSummaryCode>> GetItemSummaryCodeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param>
        /// <returns>ItemSummaryCode</returns>
        ItemSummaryCode GetItemSummaryCodeById (int? itemSummaryCodeId);
  
        /// <summary>
        /// Get an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param>
        /// <returns>ApiResponse of ItemSummaryCode</returns>
        ApiResponse<ItemSummaryCode> GetItemSummaryCodeByIdWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Get the tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSummaryCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param>
        /// <returns></returns>
        void GetItemSummaryCodeTags (int? itemSummaryCodeId);
  
        /// <summary>
        /// Get the tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSummaryCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetItemSummaryCodeTagsWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Update an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param>
        /// <returns></returns>
        void UpdateItemSummaryCode (ItemSummaryCode body);
  
        /// <summary>
        /// Update an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemSummaryCodeWithHttpInfo (ItemSummaryCode body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param>
        /// <returns>Task of ItemSummaryCode</returns>
        System.Threading.Tasks.Task<ItemSummaryCode> AddItemSummaryCodeAsync (ItemSummaryCode body);

        /// <summary>
        /// Create an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemSummaryCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSummaryCode>> AddItemSummaryCodeAsyncWithHttpInfo (ItemSummaryCode body);
        
        /// <summary>
        /// Add new audit for an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param>
        /// <param name="itemSummaryCodeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemSummaryCodeAuditAsync (int? itemSummaryCodeId, string itemSummaryCodeAudit);

        /// <summary>
        /// Add new audit for an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param>
        /// <param name="itemSummaryCodeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSummaryCodeAuditAsyncWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeAudit);
        
        /// <summary>
        /// Add new tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param>
        /// <param name="itemSummaryCodeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemSummaryCodeTagAsync (int? itemSummaryCodeId, string itemSummaryCodeTag);

        /// <summary>
        /// Add new tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSummaryCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param>
        /// <param name="itemSummaryCodeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSummaryCodeTagAsyncWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag);
        
        /// <summary>
        /// Delete an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemSummaryCodeAsync (int? itemSummaryCodeId);

        /// <summary>
        /// Delete an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSummaryCodeAsyncWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Delete a tag for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSummaryCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param>
        /// <param name="itemSummaryCodeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemSummaryCodeTagAsync (int? itemSummaryCodeId, string itemSummaryCodeTag);

        /// <summary>
        /// Delete a tag for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSummaryCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param>
        /// <param name="itemSummaryCodeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSummaryCodeTagAsyncWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag);
        
        /// <summary>
        /// Get a duplicated an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param>
        /// <returns>Task of ItemSummaryCode</returns>
        System.Threading.Tasks.Task<ItemSummaryCode> GetDuplicateItemSummaryCodeByIdAsync (int? itemSummaryCodeId);

        /// <summary>
        /// Get a duplicated an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemSummaryCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSummaryCode>> GetDuplicateItemSummaryCodeByIdAsyncWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Search itemSummaryCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSummaryCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemSummaryCode&gt;</returns>
        System.Threading.Tasks.Task<List<ItemSummaryCode>> GetItemSummaryCodeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search itemSummaryCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSummaryCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemSummaryCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemSummaryCode>>> GetItemSummaryCodeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param>
        /// <returns>Task of ItemSummaryCode</returns>
        System.Threading.Tasks.Task<ItemSummaryCode> GetItemSummaryCodeByIdAsync (int? itemSummaryCodeId);

        /// <summary>
        /// Get an itemSummaryCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSummaryCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemSummaryCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSummaryCode>> GetItemSummaryCodeByIdAsyncWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Get the tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSummaryCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetItemSummaryCodeTagsAsync (int? itemSummaryCodeId);

        /// <summary>
        /// Get the tags for an itemSummaryCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSummaryCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetItemSummaryCodeTagsAsyncWithHttpInfo (int? itemSummaryCodeId);
        
        /// <summary>
        /// Update an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemSummaryCodeAsync (ItemSummaryCode body);

        /// <summary>
        /// Update an itemSummaryCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSummaryCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemSummaryCodeAsyncWithHttpInfo (ItemSummaryCode body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemSummaryCodeApi : IItemSummaryCodeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSummaryCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemSummaryCodeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSummaryCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemSummaryCodeApi(Configuration configuration = null)
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
        /// Create an itemSummaryCode Inserts a new itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param> 
        /// <returns>ItemSummaryCode</returns>
        public ItemSummaryCode AddItemSummaryCode (ItemSummaryCode body)
        {
             ApiResponse<ItemSummaryCode> localVarResponse = AddItemSummaryCodeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an itemSummaryCode Inserts a new itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param> 
        /// <returns>ApiResponse of ItemSummaryCode</returns>
        public ApiResponse< ItemSummaryCode > AddItemSummaryCodeWithHttpInfo (ItemSummaryCode body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemSummaryCodeApi->AddItemSummaryCode");
            
    
            var localVarPath = "/beta/itemSummaryCode";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSummaryCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSummaryCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSummaryCode)));
            
        }

        
        /// <summary>
        /// Create an itemSummaryCode Inserts a new itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param>
        /// <returns>Task of ItemSummaryCode</returns>
        public async System.Threading.Tasks.Task<ItemSummaryCode> AddItemSummaryCodeAsync (ItemSummaryCode body)
        {
             ApiResponse<ItemSummaryCode> localVarResponse = await AddItemSummaryCodeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an itemSummaryCode Inserts a new itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemSummaryCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSummaryCode>> AddItemSummaryCodeAsyncWithHttpInfo (ItemSummaryCode body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddItemSummaryCode");
            
    
            var localVarPath = "/beta/itemSummaryCode";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSummaryCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSummaryCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSummaryCode)));
            
        }
        
        /// <summary>
        /// Add new audit for an itemSummaryCode Adds an audit to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param> 
        /// <param name="itemSummaryCodeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddItemSummaryCodeAudit (int? itemSummaryCodeId, string itemSummaryCodeAudit)
        {
             AddItemSummaryCodeAuditWithHttpInfo(itemSummaryCodeId, itemSummaryCodeAudit);
        }

        /// <summary>
        /// Add new audit for an itemSummaryCode Adds an audit to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param> 
        /// <param name="itemSummaryCodeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemSummaryCodeAuditWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeAudit)
        {
            
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling ItemSummaryCodeApi->AddItemSummaryCodeAudit");
            
            // verify the required parameter 'itemSummaryCodeAudit' is set
            if (itemSummaryCodeAudit == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeAudit' when calling ItemSummaryCodeApi->AddItemSummaryCodeAudit");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/audit/{itemSummaryCodeAudit}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            if (itemSummaryCodeAudit != null) localVarPathParams.Add("itemSummaryCodeAudit", Configuration.ApiClient.ParameterToString(itemSummaryCodeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an itemSummaryCode Adds an audit to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param>
        /// <param name="itemSummaryCodeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemSummaryCodeAuditAsync (int? itemSummaryCodeId, string itemSummaryCodeAudit)
        {
             await AddItemSummaryCodeAuditAsyncWithHttpInfo(itemSummaryCodeId, itemSummaryCodeAudit);

        }

        /// <summary>
        /// Add new audit for an itemSummaryCode Adds an audit to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add an audit to</param>
        /// <param name="itemSummaryCodeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSummaryCodeAuditAsyncWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeAudit)
        {
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling AddItemSummaryCodeAudit");
            // verify the required parameter 'itemSummaryCodeAudit' is set
            if (itemSummaryCodeAudit == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeAudit' when calling AddItemSummaryCodeAudit");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/audit/{itemSummaryCodeAudit}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            if (itemSummaryCodeAudit != null) localVarPathParams.Add("itemSummaryCodeAudit", Configuration.ApiClient.ParameterToString(itemSummaryCodeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an itemSummaryCode. Adds a tag to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param> 
        /// <param name="itemSummaryCodeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddItemSummaryCodeTag (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
             AddItemSummaryCodeTagWithHttpInfo(itemSummaryCodeId, itemSummaryCodeTag);
        }

        /// <summary>
        /// Add new tags for an itemSummaryCode. Adds a tag to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param> 
        /// <param name="itemSummaryCodeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemSummaryCodeTagWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
            
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling ItemSummaryCodeApi->AddItemSummaryCodeTag");
            
            // verify the required parameter 'itemSummaryCodeTag' is set
            if (itemSummaryCodeTag == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeTag' when calling ItemSummaryCodeApi->AddItemSummaryCodeTag");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/tag/{itemSummaryCodeTag}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            if (itemSummaryCodeTag != null) localVarPathParams.Add("itemSummaryCodeTag", Configuration.ApiClient.ParameterToString(itemSummaryCodeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an itemSummaryCode. Adds a tag to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param>
        /// <param name="itemSummaryCodeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemSummaryCodeTagAsync (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
             await AddItemSummaryCodeTagAsyncWithHttpInfo(itemSummaryCodeId, itemSummaryCodeTag);

        }

        /// <summary>
        /// Add new tags for an itemSummaryCode. Adds a tag to an existing itemSummaryCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to add a tag to</param>
        /// <param name="itemSummaryCodeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSummaryCodeTagAsyncWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling AddItemSummaryCodeTag");
            // verify the required parameter 'itemSummaryCodeTag' is set
            if (itemSummaryCodeTag == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeTag' when calling AddItemSummaryCodeTag");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/tag/{itemSummaryCodeTag}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            if (itemSummaryCodeTag != null) localVarPathParams.Add("itemSummaryCodeTag", Configuration.ApiClient.ParameterToString(itemSummaryCodeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSummaryCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an itemSummaryCode Deletes the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param> 
        /// <returns></returns>
        public void DeleteItemSummaryCode (int? itemSummaryCodeId)
        {
             DeleteItemSummaryCodeWithHttpInfo(itemSummaryCodeId);
        }

        /// <summary>
        /// Delete an itemSummaryCode Deletes the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemSummaryCodeWithHttpInfo (int? itemSummaryCodeId)
        {
            
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling ItemSummaryCodeApi->DeleteItemSummaryCode");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an itemSummaryCode Deletes the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemSummaryCodeAsync (int? itemSummaryCodeId)
        {
             await DeleteItemSummaryCodeAsyncWithHttpInfo(itemSummaryCodeId);

        }

        /// <summary>
        /// Delete an itemSummaryCode Deletes the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSummaryCodeAsyncWithHttpInfo (int? itemSummaryCodeId)
        {
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling DeleteItemSummaryCode");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an itemSummaryCode. Deletes an existing itemSummaryCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param> 
        /// <param name="itemSummaryCodeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteItemSummaryCodeTag (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
             DeleteItemSummaryCodeTagWithHttpInfo(itemSummaryCodeId, itemSummaryCodeTag);
        }

        /// <summary>
        /// Delete a tag for an itemSummaryCode. Deletes an existing itemSummaryCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param> 
        /// <param name="itemSummaryCodeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemSummaryCodeTagWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
            
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling ItemSummaryCodeApi->DeleteItemSummaryCodeTag");
            
            // verify the required parameter 'itemSummaryCodeTag' is set
            if (itemSummaryCodeTag == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeTag' when calling ItemSummaryCodeApi->DeleteItemSummaryCodeTag");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/tag/{itemSummaryCodeTag}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            if (itemSummaryCodeTag != null) localVarPathParams.Add("itemSummaryCodeTag", Configuration.ApiClient.ParameterToString(itemSummaryCodeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an itemSummaryCode. Deletes an existing itemSummaryCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param>
        /// <param name="itemSummaryCodeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemSummaryCodeTagAsync (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
             await DeleteItemSummaryCodeTagAsyncWithHttpInfo(itemSummaryCodeId, itemSummaryCodeTag);

        }

        /// <summary>
        /// Delete a tag for an itemSummaryCode. Deletes an existing itemSummaryCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to remove tag from</param>
        /// <param name="itemSummaryCodeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSummaryCodeTagAsyncWithHttpInfo (int? itemSummaryCodeId, string itemSummaryCodeTag)
        {
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling DeleteItemSummaryCodeTag");
            // verify the required parameter 'itemSummaryCodeTag' is set
            if (itemSummaryCodeTag == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeTag' when calling DeleteItemSummaryCodeTag");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/tag/{itemSummaryCodeTag}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            if (itemSummaryCodeTag != null) localVarPathParams.Add("itemSummaryCodeTag", Configuration.ApiClient.ParameterToString(itemSummaryCodeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSummaryCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an itemSummaryCode by id Returns a duplicated itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param> 
        /// <returns>ItemSummaryCode</returns>
        public ItemSummaryCode GetDuplicateItemSummaryCodeById (int? itemSummaryCodeId)
        {
             ApiResponse<ItemSummaryCode> localVarResponse = GetDuplicateItemSummaryCodeByIdWithHttpInfo(itemSummaryCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an itemSummaryCode by id Returns a duplicated itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param> 
        /// <returns>ApiResponse of ItemSummaryCode</returns>
        public ApiResponse< ItemSummaryCode > GetDuplicateItemSummaryCodeByIdWithHttpInfo (int? itemSummaryCodeId)
        {
            
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling ItemSummaryCodeApi->GetDuplicateItemSummaryCodeById");
            
    
            var localVarPath = "/beta/itemSummaryCode/duplicate/{itemSummaryCodeId}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSummaryCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSummaryCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSummaryCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSummaryCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSummaryCode)));
            
        }

        
        /// <summary>
        /// Get a duplicated an itemSummaryCode by id Returns a duplicated itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param>
        /// <returns>Task of ItemSummaryCode</returns>
        public async System.Threading.Tasks.Task<ItemSummaryCode> GetDuplicateItemSummaryCodeByIdAsync (int? itemSummaryCodeId)
        {
             ApiResponse<ItemSummaryCode> localVarResponse = await GetDuplicateItemSummaryCodeByIdAsyncWithHttpInfo(itemSummaryCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an itemSummaryCode by id Returns a duplicated itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemSummaryCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSummaryCode>> GetDuplicateItemSummaryCodeByIdAsyncWithHttpInfo (int? itemSummaryCodeId)
        {
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling GetDuplicateItemSummaryCodeById");
            
    
            var localVarPath = "/beta/itemSummaryCode/duplicate/{itemSummaryCodeId}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSummaryCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSummaryCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSummaryCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSummaryCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSummaryCode)));
            
        }
        
        /// <summary>
        /// Search itemSummaryCodes by filter Returns the list of itemSummaryCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ItemSummaryCode&gt;</returns>
        public List<ItemSummaryCode> GetItemSummaryCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemSummaryCode>> localVarResponse = GetItemSummaryCodeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemSummaryCodes by filter Returns the list of itemSummaryCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemSummaryCode&gt;</returns>
        public ApiResponse< List<ItemSummaryCode> > GetItemSummaryCodeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemSummaryCode/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemSummaryCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemSummaryCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemSummaryCode>)));
            
        }

        
        /// <summary>
        /// Search itemSummaryCodes by filter Returns the list of itemSummaryCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemSummaryCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemSummaryCode>> GetItemSummaryCodeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemSummaryCode>> localVarResponse = await GetItemSummaryCodeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemSummaryCodes by filter Returns the list of itemSummaryCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemSummaryCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemSummaryCode>>> GetItemSummaryCodeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemSummaryCode/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemSummaryCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemSummaryCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemSummaryCode>)));
            
        }
        
        /// <summary>
        /// Get an itemSummaryCode by id Returns the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param> 
        /// <returns>ItemSummaryCode</returns>
        public ItemSummaryCode GetItemSummaryCodeById (int? itemSummaryCodeId)
        {
             ApiResponse<ItemSummaryCode> localVarResponse = GetItemSummaryCodeByIdWithHttpInfo(itemSummaryCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemSummaryCode by id Returns the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param> 
        /// <returns>ApiResponse of ItemSummaryCode</returns>
        public ApiResponse< ItemSummaryCode > GetItemSummaryCodeByIdWithHttpInfo (int? itemSummaryCodeId)
        {
            
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling ItemSummaryCodeApi->GetItemSummaryCodeById");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSummaryCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSummaryCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSummaryCode)));
            
        }

        
        /// <summary>
        /// Get an itemSummaryCode by id Returns the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param>
        /// <returns>Task of ItemSummaryCode</returns>
        public async System.Threading.Tasks.Task<ItemSummaryCode> GetItemSummaryCodeByIdAsync (int? itemSummaryCodeId)
        {
             ApiResponse<ItemSummaryCode> localVarResponse = await GetItemSummaryCodeByIdAsyncWithHttpInfo(itemSummaryCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemSummaryCode by id Returns the itemSummaryCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemSummaryCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSummaryCode>> GetItemSummaryCodeByIdAsyncWithHttpInfo (int? itemSummaryCodeId)
        {
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling GetItemSummaryCodeById");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSummaryCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSummaryCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSummaryCode)));
            
        }
        
        /// <summary>
        /// Get the tags for an itemSummaryCode. Get all existing itemSummaryCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param> 
        /// <returns></returns>
        public void GetItemSummaryCodeTags (int? itemSummaryCodeId)
        {
             GetItemSummaryCodeTagsWithHttpInfo(itemSummaryCodeId);
        }

        /// <summary>
        /// Get the tags for an itemSummaryCode. Get all existing itemSummaryCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetItemSummaryCodeTagsWithHttpInfo (int? itemSummaryCodeId)
        {
            
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling ItemSummaryCodeApi->GetItemSummaryCodeTags");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/tag";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an itemSummaryCode. Get all existing itemSummaryCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetItemSummaryCodeTagsAsync (int? itemSummaryCodeId)
        {
             await GetItemSummaryCodeTagsAsyncWithHttpInfo(itemSummaryCodeId);

        }

        /// <summary>
        /// Get the tags for an itemSummaryCode. Get all existing itemSummaryCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSummaryCodeId">Id of the itemSummaryCode to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetItemSummaryCodeTagsAsyncWithHttpInfo (int? itemSummaryCodeId)
        {
            // verify the required parameter 'itemSummaryCodeId' is set
            if (itemSummaryCodeId == null) throw new ApiException(400, "Missing required parameter 'itemSummaryCodeId' when calling GetItemSummaryCodeTags");
            
    
            var localVarPath = "/beta/itemSummaryCode/{itemSummaryCodeId}/tag";
    
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
            if (itemSummaryCodeId != null) localVarPathParams.Add("itemSummaryCodeId", Configuration.ApiClient.ParameterToString(itemSummaryCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSummaryCodeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemSummaryCode Updates an existing itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemSummaryCode (ItemSummaryCode body)
        {
             UpdateItemSummaryCodeWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemSummaryCode Updates an existing itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemSummaryCodeWithHttpInfo (ItemSummaryCode body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemSummaryCodeApi->UpdateItemSummaryCode");
            
    
            var localVarPath = "/beta/itemSummaryCode";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSummaryCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSummaryCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemSummaryCode Updates an existing itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemSummaryCodeAsync (ItemSummaryCode body)
        {
             await UpdateItemSummaryCodeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemSummaryCode Updates an existing itemSummaryCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSummaryCode to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemSummaryCodeAsyncWithHttpInfo (ItemSummaryCode body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemSummaryCode");
            
    
            var localVarPath = "/beta/itemSummaryCode";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSummaryCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSummaryCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
