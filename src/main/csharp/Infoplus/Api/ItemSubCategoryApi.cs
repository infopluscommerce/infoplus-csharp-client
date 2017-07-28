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
    public interface IItemSubCategoryApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param>
        /// <returns>ItemSubCategory</returns>
        ItemSubCategory AddItemSubCategory (ItemSubCategory body);
  
        /// <summary>
        /// Create an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param>
        /// <returns>ApiResponse of ItemSubCategory</returns>
        ApiResponse<ItemSubCategory> AddItemSubCategoryWithHttpInfo (ItemSubCategory body);
        
        /// <summary>
        /// Add new audit for an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param>
        /// <param name="itemSubCategoryAudit">The audit to add</param>
        /// <returns></returns>
        void AddItemSubCategoryAudit (int? itemSubCategoryId, string itemSubCategoryAudit);
  
        /// <summary>
        /// Add new audit for an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param>
        /// <param name="itemSubCategoryAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemSubCategoryAuditWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryAudit);
        
        /// <summary>
        /// Add new tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param>
        /// <param name="itemSubCategoryTag">The tag to add</param>
        /// <returns></returns>
        void AddItemSubCategoryTag (int? itemSubCategoryId, string itemSubCategoryTag);
  
        /// <summary>
        /// Add new tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param>
        /// <param name="itemSubCategoryTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemSubCategoryTagWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag);
        
        /// <summary>
        /// Delete an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Deletes the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param>
        /// <returns></returns>
        void DeleteItemSubCategory (int? itemSubCategoryId);
  
        /// <summary>
        /// Delete an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Deletes the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemSubCategoryWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Delete a tag for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSubCategory tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param>
        /// <param name="itemSubCategoryTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteItemSubCategoryTag (int? itemSubCategoryId, string itemSubCategoryTag);
  
        /// <summary>
        /// Delete a tag for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSubCategory tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param>
        /// <param name="itemSubCategoryTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemSubCategoryTagWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag);
        
        /// <summary>
        /// Get a duplicated an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param>
        /// <returns>ItemSubCategory</returns>
        ItemSubCategory GetDuplicateItemSubCategoryById (int? itemSubCategoryId);
  
        /// <summary>
        /// Get a duplicated an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param>
        /// <returns>ApiResponse of ItemSubCategory</returns>
        ApiResponse<ItemSubCategory> GetDuplicateItemSubCategoryByIdWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Search itemSubCategorys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSubCategorys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ItemSubCategory&gt;</returns>
        List<ItemSubCategory> GetItemSubCategoryByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search itemSubCategorys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSubCategorys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemSubCategory&gt;</returns>
        ApiResponse<List<ItemSubCategory>> GetItemSubCategoryByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param>
        /// <returns>ItemSubCategory</returns>
        ItemSubCategory GetItemSubCategoryById (int? itemSubCategoryId);
  
        /// <summary>
        /// Get an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param>
        /// <returns>ApiResponse of ItemSubCategory</returns>
        ApiResponse<ItemSubCategory> GetItemSubCategoryByIdWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Get the tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSubCategory tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param>
        /// <returns></returns>
        void GetItemSubCategoryTags (int? itemSubCategoryId);
  
        /// <summary>
        /// Get the tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSubCategory tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetItemSubCategoryTagsWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Update an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param>
        /// <returns></returns>
        void UpdateItemSubCategory (ItemSubCategory body);
  
        /// <summary>
        /// Update an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemSubCategoryWithHttpInfo (ItemSubCategory body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param>
        /// <returns>Task of ItemSubCategory</returns>
        System.Threading.Tasks.Task<ItemSubCategory> AddItemSubCategoryAsync (ItemSubCategory body);

        /// <summary>
        /// Create an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Inserts a new itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemSubCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSubCategory>> AddItemSubCategoryAsyncWithHttpInfo (ItemSubCategory body);
        
        /// <summary>
        /// Add new audit for an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param>
        /// <param name="itemSubCategoryAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemSubCategoryAuditAsync (int? itemSubCategoryId, string itemSubCategoryAudit);

        /// <summary>
        /// Add new audit for an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param>
        /// <param name="itemSubCategoryAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSubCategoryAuditAsyncWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryAudit);
        
        /// <summary>
        /// Add new tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param>
        /// <param name="itemSubCategoryTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemSubCategoryTagAsync (int? itemSubCategoryId, string itemSubCategoryTag);

        /// <summary>
        /// Add new tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemSubCategory.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param>
        /// <param name="itemSubCategoryTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSubCategoryTagAsyncWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag);
        
        /// <summary>
        /// Delete an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Deletes the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemSubCategoryAsync (int? itemSubCategoryId);

        /// <summary>
        /// Delete an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Deletes the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSubCategoryAsyncWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Delete a tag for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSubCategory tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param>
        /// <param name="itemSubCategoryTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemSubCategoryTagAsync (int? itemSubCategoryId, string itemSubCategoryTag);

        /// <summary>
        /// Delete a tag for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemSubCategory tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param>
        /// <param name="itemSubCategoryTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSubCategoryTagAsyncWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag);
        
        /// <summary>
        /// Get a duplicated an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param>
        /// <returns>Task of ItemSubCategory</returns>
        System.Threading.Tasks.Task<ItemSubCategory> GetDuplicateItemSubCategoryByIdAsync (int? itemSubCategoryId);

        /// <summary>
        /// Get a duplicated an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemSubCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSubCategory>> GetDuplicateItemSubCategoryByIdAsyncWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Search itemSubCategorys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSubCategorys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemSubCategory&gt;</returns>
        System.Threading.Tasks.Task<List<ItemSubCategory>> GetItemSubCategoryByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search itemSubCategorys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemSubCategorys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemSubCategory&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemSubCategory>>> GetItemSubCategoryByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param>
        /// <returns>Task of ItemSubCategory</returns>
        System.Threading.Tasks.Task<ItemSubCategory> GetItemSubCategoryByIdAsync (int? itemSubCategoryId);

        /// <summary>
        /// Get an itemSubCategory by id
        /// </summary>
        /// <remarks>
        /// Returns the itemSubCategory identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param>
        /// <returns>Task of ApiResponse (ItemSubCategory)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemSubCategory>> GetItemSubCategoryByIdAsyncWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Get the tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSubCategory tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetItemSubCategoryTagsAsync (int? itemSubCategoryId);

        /// <summary>
        /// Get the tags for an itemSubCategory.
        /// </summary>
        /// <remarks>
        /// Get all existing itemSubCategory tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetItemSubCategoryTagsAsyncWithHttpInfo (int? itemSubCategoryId);
        
        /// <summary>
        /// Update an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemSubCategoryAsync (ItemSubCategory body);

        /// <summary>
        /// Update an itemSubCategory
        /// </summary>
        /// <remarks>
        /// Updates an existing itemSubCategory using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemSubCategoryAsyncWithHttpInfo (ItemSubCategory body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemSubCategoryApi : IItemSubCategoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSubCategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemSubCategoryApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSubCategoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemSubCategoryApi(Configuration configuration = null)
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
        /// Create an itemSubCategory Inserts a new itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param> 
        /// <returns>ItemSubCategory</returns>
        public ItemSubCategory AddItemSubCategory (ItemSubCategory body)
        {
             ApiResponse<ItemSubCategory> localVarResponse = AddItemSubCategoryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an itemSubCategory Inserts a new itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param> 
        /// <returns>ApiResponse of ItemSubCategory</returns>
        public ApiResponse< ItemSubCategory > AddItemSubCategoryWithHttpInfo (ItemSubCategory body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemSubCategoryApi->AddItemSubCategory");
            
    
            var localVarPath = "/beta/itemSubCategory";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSubCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSubCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSubCategory)));
            
        }

        
        /// <summary>
        /// Create an itemSubCategory Inserts a new itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param>
        /// <returns>Task of ItemSubCategory</returns>
        public async System.Threading.Tasks.Task<ItemSubCategory> AddItemSubCategoryAsync (ItemSubCategory body)
        {
             ApiResponse<ItemSubCategory> localVarResponse = await AddItemSubCategoryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an itemSubCategory Inserts a new itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemSubCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSubCategory>> AddItemSubCategoryAsyncWithHttpInfo (ItemSubCategory body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddItemSubCategory");
            
    
            var localVarPath = "/beta/itemSubCategory";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSubCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSubCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSubCategory)));
            
        }
        
        /// <summary>
        /// Add new audit for an itemSubCategory Adds an audit to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param> 
        /// <param name="itemSubCategoryAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddItemSubCategoryAudit (int? itemSubCategoryId, string itemSubCategoryAudit)
        {
             AddItemSubCategoryAuditWithHttpInfo(itemSubCategoryId, itemSubCategoryAudit);
        }

        /// <summary>
        /// Add new audit for an itemSubCategory Adds an audit to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param> 
        /// <param name="itemSubCategoryAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemSubCategoryAuditWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryAudit)
        {
            
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling ItemSubCategoryApi->AddItemSubCategoryAudit");
            
            // verify the required parameter 'itemSubCategoryAudit' is set
            if (itemSubCategoryAudit == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryAudit' when calling ItemSubCategoryApi->AddItemSubCategoryAudit");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/audit/{itemSubCategoryAudit}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            if (itemSubCategoryAudit != null) localVarPathParams.Add("itemSubCategoryAudit", Configuration.ApiClient.ParameterToString(itemSubCategoryAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an itemSubCategory Adds an audit to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param>
        /// <param name="itemSubCategoryAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemSubCategoryAuditAsync (int? itemSubCategoryId, string itemSubCategoryAudit)
        {
             await AddItemSubCategoryAuditAsyncWithHttpInfo(itemSubCategoryId, itemSubCategoryAudit);

        }

        /// <summary>
        /// Add new audit for an itemSubCategory Adds an audit to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add an audit to</param>
        /// <param name="itemSubCategoryAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSubCategoryAuditAsyncWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryAudit)
        {
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling AddItemSubCategoryAudit");
            // verify the required parameter 'itemSubCategoryAudit' is set
            if (itemSubCategoryAudit == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryAudit' when calling AddItemSubCategoryAudit");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/audit/{itemSubCategoryAudit}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            if (itemSubCategoryAudit != null) localVarPathParams.Add("itemSubCategoryAudit", Configuration.ApiClient.ParameterToString(itemSubCategoryAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an itemSubCategory. Adds a tag to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param> 
        /// <param name="itemSubCategoryTag">The tag to add</param> 
        /// <returns></returns>
        public void AddItemSubCategoryTag (int? itemSubCategoryId, string itemSubCategoryTag)
        {
             AddItemSubCategoryTagWithHttpInfo(itemSubCategoryId, itemSubCategoryTag);
        }

        /// <summary>
        /// Add new tags for an itemSubCategory. Adds a tag to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param> 
        /// <param name="itemSubCategoryTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemSubCategoryTagWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag)
        {
            
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling ItemSubCategoryApi->AddItemSubCategoryTag");
            
            // verify the required parameter 'itemSubCategoryTag' is set
            if (itemSubCategoryTag == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryTag' when calling ItemSubCategoryApi->AddItemSubCategoryTag");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/tag/{itemSubCategoryTag}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            if (itemSubCategoryTag != null) localVarPathParams.Add("itemSubCategoryTag", Configuration.ApiClient.ParameterToString(itemSubCategoryTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an itemSubCategory. Adds a tag to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param>
        /// <param name="itemSubCategoryTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemSubCategoryTagAsync (int? itemSubCategoryId, string itemSubCategoryTag)
        {
             await AddItemSubCategoryTagAsyncWithHttpInfo(itemSubCategoryId, itemSubCategoryTag);

        }

        /// <summary>
        /// Add new tags for an itemSubCategory. Adds a tag to an existing itemSubCategory.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to add a tag to</param>
        /// <param name="itemSubCategoryTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemSubCategoryTagAsyncWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag)
        {
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling AddItemSubCategoryTag");
            // verify the required parameter 'itemSubCategoryTag' is set
            if (itemSubCategoryTag == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryTag' when calling AddItemSubCategoryTag");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/tag/{itemSubCategoryTag}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            if (itemSubCategoryTag != null) localVarPathParams.Add("itemSubCategoryTag", Configuration.ApiClient.ParameterToString(itemSubCategoryTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemSubCategoryTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an itemSubCategory Deletes the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param> 
        /// <returns></returns>
        public void DeleteItemSubCategory (int? itemSubCategoryId)
        {
             DeleteItemSubCategoryWithHttpInfo(itemSubCategoryId);
        }

        /// <summary>
        /// Delete an itemSubCategory Deletes the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemSubCategoryWithHttpInfo (int? itemSubCategoryId)
        {
            
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling ItemSubCategoryApi->DeleteItemSubCategory");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an itemSubCategory Deletes the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemSubCategoryAsync (int? itemSubCategoryId)
        {
             await DeleteItemSubCategoryAsyncWithHttpInfo(itemSubCategoryId);

        }

        /// <summary>
        /// Delete an itemSubCategory Deletes the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSubCategoryAsyncWithHttpInfo (int? itemSubCategoryId)
        {
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling DeleteItemSubCategory");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an itemSubCategory. Deletes an existing itemSubCategory tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param> 
        /// <param name="itemSubCategoryTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteItemSubCategoryTag (int? itemSubCategoryId, string itemSubCategoryTag)
        {
             DeleteItemSubCategoryTagWithHttpInfo(itemSubCategoryId, itemSubCategoryTag);
        }

        /// <summary>
        /// Delete a tag for an itemSubCategory. Deletes an existing itemSubCategory tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param> 
        /// <param name="itemSubCategoryTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemSubCategoryTagWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag)
        {
            
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling ItemSubCategoryApi->DeleteItemSubCategoryTag");
            
            // verify the required parameter 'itemSubCategoryTag' is set
            if (itemSubCategoryTag == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryTag' when calling ItemSubCategoryApi->DeleteItemSubCategoryTag");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/tag/{itemSubCategoryTag}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            if (itemSubCategoryTag != null) localVarPathParams.Add("itemSubCategoryTag", Configuration.ApiClient.ParameterToString(itemSubCategoryTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategoryTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategoryTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an itemSubCategory. Deletes an existing itemSubCategory tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param>
        /// <param name="itemSubCategoryTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemSubCategoryTagAsync (int? itemSubCategoryId, string itemSubCategoryTag)
        {
             await DeleteItemSubCategoryTagAsyncWithHttpInfo(itemSubCategoryId, itemSubCategoryTag);

        }

        /// <summary>
        /// Delete a tag for an itemSubCategory. Deletes an existing itemSubCategory tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to remove tag from</param>
        /// <param name="itemSubCategoryTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemSubCategoryTagAsyncWithHttpInfo (int? itemSubCategoryId, string itemSubCategoryTag)
        {
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling DeleteItemSubCategoryTag");
            // verify the required parameter 'itemSubCategoryTag' is set
            if (itemSubCategoryTag == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryTag' when calling DeleteItemSubCategoryTag");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/tag/{itemSubCategoryTag}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            if (itemSubCategoryTag != null) localVarPathParams.Add("itemSubCategoryTag", Configuration.ApiClient.ParameterToString(itemSubCategoryTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategoryTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemSubCategoryTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an itemSubCategory by id Returns a duplicated itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param> 
        /// <returns>ItemSubCategory</returns>
        public ItemSubCategory GetDuplicateItemSubCategoryById (int? itemSubCategoryId)
        {
             ApiResponse<ItemSubCategory> localVarResponse = GetDuplicateItemSubCategoryByIdWithHttpInfo(itemSubCategoryId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an itemSubCategory by id Returns a duplicated itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param> 
        /// <returns>ApiResponse of ItemSubCategory</returns>
        public ApiResponse< ItemSubCategory > GetDuplicateItemSubCategoryByIdWithHttpInfo (int? itemSubCategoryId)
        {
            
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling ItemSubCategoryApi->GetDuplicateItemSubCategoryById");
            
    
            var localVarPath = "/beta/itemSubCategory/duplicate/{itemSubCategoryId}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSubCategoryById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSubCategoryById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSubCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSubCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSubCategory)));
            
        }

        
        /// <summary>
        /// Get a duplicated an itemSubCategory by id Returns a duplicated itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param>
        /// <returns>Task of ItemSubCategory</returns>
        public async System.Threading.Tasks.Task<ItemSubCategory> GetDuplicateItemSubCategoryByIdAsync (int? itemSubCategoryId)
        {
             ApiResponse<ItemSubCategory> localVarResponse = await GetDuplicateItemSubCategoryByIdAsyncWithHttpInfo(itemSubCategoryId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an itemSubCategory by id Returns a duplicated itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemSubCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSubCategory>> GetDuplicateItemSubCategoryByIdAsyncWithHttpInfo (int? itemSubCategoryId)
        {
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling GetDuplicateItemSubCategoryById");
            
    
            var localVarPath = "/beta/itemSubCategory/duplicate/{itemSubCategoryId}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSubCategoryById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemSubCategoryById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSubCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSubCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSubCategory)));
            
        }
        
        /// <summary>
        /// Search itemSubCategorys by filter Returns the list of itemSubCategorys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ItemSubCategory&gt;</returns>
        public List<ItemSubCategory> GetItemSubCategoryByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemSubCategory>> localVarResponse = GetItemSubCategoryByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemSubCategorys by filter Returns the list of itemSubCategorys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemSubCategory&gt;</returns>
        public ApiResponse< List<ItemSubCategory> > GetItemSubCategoryByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemSubCategory/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemSubCategory>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemSubCategory>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemSubCategory>)));
            
        }

        
        /// <summary>
        /// Search itemSubCategorys by filter Returns the list of itemSubCategorys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemSubCategory&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemSubCategory>> GetItemSubCategoryByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemSubCategory>> localVarResponse = await GetItemSubCategoryByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemSubCategorys by filter Returns the list of itemSubCategorys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemSubCategory&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemSubCategory>>> GetItemSubCategoryByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemSubCategory/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemSubCategory>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemSubCategory>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemSubCategory>)));
            
        }
        
        /// <summary>
        /// Get an itemSubCategory by id Returns the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param> 
        /// <returns>ItemSubCategory</returns>
        public ItemSubCategory GetItemSubCategoryById (int? itemSubCategoryId)
        {
             ApiResponse<ItemSubCategory> localVarResponse = GetItemSubCategoryByIdWithHttpInfo(itemSubCategoryId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemSubCategory by id Returns the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param> 
        /// <returns>ApiResponse of ItemSubCategory</returns>
        public ApiResponse< ItemSubCategory > GetItemSubCategoryByIdWithHttpInfo (int? itemSubCategoryId)
        {
            
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling ItemSubCategoryApi->GetItemSubCategoryById");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemSubCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSubCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSubCategory)));
            
        }

        
        /// <summary>
        /// Get an itemSubCategory by id Returns the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param>
        /// <returns>Task of ItemSubCategory</returns>
        public async System.Threading.Tasks.Task<ItemSubCategory> GetItemSubCategoryByIdAsync (int? itemSubCategoryId)
        {
             ApiResponse<ItemSubCategory> localVarResponse = await GetItemSubCategoryByIdAsyncWithHttpInfo(itemSubCategoryId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemSubCategory by id Returns the itemSubCategory identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to be returned.</param>
        /// <returns>Task of ApiResponse (ItemSubCategory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemSubCategory>> GetItemSubCategoryByIdAsyncWithHttpInfo (int? itemSubCategoryId)
        {
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling GetItemSubCategoryById");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemSubCategory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemSubCategory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemSubCategory)));
            
        }
        
        /// <summary>
        /// Get the tags for an itemSubCategory. Get all existing itemSubCategory tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param> 
        /// <returns></returns>
        public void GetItemSubCategoryTags (int? itemSubCategoryId)
        {
             GetItemSubCategoryTagsWithHttpInfo(itemSubCategoryId);
        }

        /// <summary>
        /// Get the tags for an itemSubCategory. Get all existing itemSubCategory tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetItemSubCategoryTagsWithHttpInfo (int? itemSubCategoryId)
        {
            
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null)
                throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling ItemSubCategoryApi->GetItemSubCategoryTags");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/tag";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an itemSubCategory. Get all existing itemSubCategory tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetItemSubCategoryTagsAsync (int? itemSubCategoryId)
        {
             await GetItemSubCategoryTagsAsyncWithHttpInfo(itemSubCategoryId);

        }

        /// <summary>
        /// Get the tags for an itemSubCategory. Get all existing itemSubCategory tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemSubCategoryId">Id of the itemSubCategory to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetItemSubCategoryTagsAsyncWithHttpInfo (int? itemSubCategoryId)
        {
            // verify the required parameter 'itemSubCategoryId' is set
            if (itemSubCategoryId == null) throw new ApiException(400, "Missing required parameter 'itemSubCategoryId' when calling GetItemSubCategoryTags");
            
    
            var localVarPath = "/beta/itemSubCategory/{itemSubCategoryId}/tag";
    
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
            if (itemSubCategoryId != null) localVarPathParams.Add("itemSubCategoryId", Configuration.ApiClient.ParameterToString(itemSubCategoryId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemSubCategoryTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemSubCategory Updates an existing itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemSubCategory (ItemSubCategory body)
        {
             UpdateItemSubCategoryWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemSubCategory Updates an existing itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemSubCategoryWithHttpInfo (ItemSubCategory body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemSubCategoryApi->UpdateItemSubCategory");
            
    
            var localVarPath = "/beta/itemSubCategory";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSubCategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSubCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemSubCategory Updates an existing itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemSubCategoryAsync (ItemSubCategory body)
        {
             await UpdateItemSubCategoryAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemSubCategory Updates an existing itemSubCategory using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemSubCategory to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemSubCategoryAsyncWithHttpInfo (ItemSubCategory body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemSubCategory");
            
    
            var localVarPath = "/beta/itemSubCategory";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSubCategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemSubCategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
