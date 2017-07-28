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
    public interface IItemReceiptApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for an itemReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param>
        /// <param name="itemReceiptAudit">The audit to add</param>
        /// <returns></returns>
        void AddItemReceiptAudit (int? itemReceiptId, string itemReceiptAudit);
  
        /// <summary>
        /// Add new audit for an itemReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param>
        /// <param name="itemReceiptAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemReceiptAuditWithHttpInfo (int? itemReceiptId, string itemReceiptAudit);
        
        /// <summary>
        /// Add new tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param>
        /// <param name="itemReceiptTag">The tag to add</param>
        /// <returns></returns>
        void AddItemReceiptTag (int? itemReceiptId, string itemReceiptTag);
  
        /// <summary>
        /// Add new tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param>
        /// <param name="itemReceiptTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemReceiptTagWithHttpInfo (int? itemReceiptId, string itemReceiptTag);
        
        /// <summary>
        /// Delete a tag for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param>
        /// <param name="itemReceiptTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteItemReceiptTag (int? itemReceiptId, string itemReceiptTag);
  
        /// <summary>
        /// Delete a tag for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param>
        /// <param name="itemReceiptTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemReceiptTagWithHttpInfo (int? itemReceiptId, string itemReceiptTag);
        
        /// <summary>
        /// Get a duplicated an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param>
        /// <returns>ItemReceipt</returns>
        ItemReceipt GetDuplicateItemReceiptById (int? itemReceiptId);
  
        /// <summary>
        /// Get a duplicated an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param>
        /// <returns>ApiResponse of ItemReceipt</returns>
        ApiResponse<ItemReceipt> GetDuplicateItemReceiptByIdWithHttpInfo (int? itemReceiptId);
        
        /// <summary>
        /// Search itemReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ItemReceipt&gt;</returns>
        List<ItemReceipt> GetItemReceiptByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search itemReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemReceipt&gt;</returns>
        ApiResponse<List<ItemReceipt>> GetItemReceiptByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param>
        /// <returns>ItemReceipt</returns>
        ItemReceipt GetItemReceiptById (int? itemReceiptId);
  
        /// <summary>
        /// Get an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param>
        /// <returns>ApiResponse of ItemReceipt</returns>
        ApiResponse<ItemReceipt> GetItemReceiptByIdWithHttpInfo (int? itemReceiptId);
        
        /// <summary>
        /// Get the tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param>
        /// <returns></returns>
        void GetItemReceiptTags (int? itemReceiptId);
  
        /// <summary>
        /// Get the tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetItemReceiptTagsWithHttpInfo (int? itemReceiptId);
        
        /// <summary>
        /// Update an itemReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns></returns>
        void UpdateItemReceipt (ItemReceipt body);
  
        /// <summary>
        /// Update an itemReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemReceiptWithHttpInfo (ItemReceipt body);
        
        /// <summary>
        /// Update an itemReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns></returns>
        void UpdateItemReceiptCustomFields (ItemReceipt body);
  
        /// <summary>
        /// Update an itemReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemReceiptCustomFieldsWithHttpInfo (ItemReceipt body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for an itemReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param>
        /// <param name="itemReceiptAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemReceiptAuditAsync (int? itemReceiptId, string itemReceiptAudit);

        /// <summary>
        /// Add new audit for an itemReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param>
        /// <param name="itemReceiptAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptAuditAsyncWithHttpInfo (int? itemReceiptId, string itemReceiptAudit);
        
        /// <summary>
        /// Add new tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param>
        /// <param name="itemReceiptTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemReceiptTagAsync (int? itemReceiptId, string itemReceiptTag);

        /// <summary>
        /// Add new tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param>
        /// <param name="itemReceiptTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptTagAsyncWithHttpInfo (int? itemReceiptId, string itemReceiptTag);
        
        /// <summary>
        /// Delete a tag for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param>
        /// <param name="itemReceiptTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemReceiptTagAsync (int? itemReceiptId, string itemReceiptTag);

        /// <summary>
        /// Delete a tag for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param>
        /// <param name="itemReceiptTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemReceiptTagAsyncWithHttpInfo (int? itemReceiptId, string itemReceiptTag);
        
        /// <summary>
        /// Get a duplicated an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param>
        /// <returns>Task of ItemReceipt</returns>
        System.Threading.Tasks.Task<ItemReceipt> GetDuplicateItemReceiptByIdAsync (int? itemReceiptId);

        /// <summary>
        /// Get a duplicated an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemReceipt)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemReceipt>> GetDuplicateItemReceiptByIdAsyncWithHttpInfo (int? itemReceiptId);
        
        /// <summary>
        /// Search itemReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemReceipt&gt;</returns>
        System.Threading.Tasks.Task<List<ItemReceipt>> GetItemReceiptByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search itemReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemReceipt&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemReceipt>>> GetItemReceiptByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param>
        /// <returns>Task of ItemReceipt</returns>
        System.Threading.Tasks.Task<ItemReceipt> GetItemReceiptByIdAsync (int? itemReceiptId);

        /// <summary>
        /// Get an itemReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the itemReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param>
        /// <returns>Task of ApiResponse (ItemReceipt)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemReceipt>> GetItemReceiptByIdAsyncWithHttpInfo (int? itemReceiptId);
        
        /// <summary>
        /// Get the tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetItemReceiptTagsAsync (int? itemReceiptId);

        /// <summary>
        /// Get the tags for an itemReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing itemReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetItemReceiptTagsAsyncWithHttpInfo (int? itemReceiptId);
        
        /// <summary>
        /// Update an itemReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemReceiptAsync (ItemReceipt body);

        /// <summary>
        /// Update an itemReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemReceiptAsyncWithHttpInfo (ItemReceipt body);
        
        /// <summary>
        /// Update an itemReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemReceiptCustomFieldsAsync (ItemReceipt body);

        /// <summary>
        /// Update an itemReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing itemReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemReceiptCustomFieldsAsyncWithHttpInfo (ItemReceipt body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemReceiptApi : IItemReceiptApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReceiptApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemReceiptApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReceiptApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemReceiptApi(Configuration configuration = null)
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
        /// Add new audit for an itemReceipt Adds an audit to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param> 
        /// <param name="itemReceiptAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddItemReceiptAudit (int? itemReceiptId, string itemReceiptAudit)
        {
             AddItemReceiptAuditWithHttpInfo(itemReceiptId, itemReceiptAudit);
        }

        /// <summary>
        /// Add new audit for an itemReceipt Adds an audit to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param> 
        /// <param name="itemReceiptAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemReceiptAuditWithHttpInfo (int? itemReceiptId, string itemReceiptAudit)
        {
            
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling ItemReceiptApi->AddItemReceiptAudit");
            
            // verify the required parameter 'itemReceiptAudit' is set
            if (itemReceiptAudit == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptAudit' when calling ItemReceiptApi->AddItemReceiptAudit");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/audit/{itemReceiptAudit}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            if (itemReceiptAudit != null) localVarPathParams.Add("itemReceiptAudit", Configuration.ApiClient.ParameterToString(itemReceiptAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an itemReceipt Adds an audit to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param>
        /// <param name="itemReceiptAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemReceiptAuditAsync (int? itemReceiptId, string itemReceiptAudit)
        {
             await AddItemReceiptAuditAsyncWithHttpInfo(itemReceiptId, itemReceiptAudit);

        }

        /// <summary>
        /// Add new audit for an itemReceipt Adds an audit to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add an audit to</param>
        /// <param name="itemReceiptAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptAuditAsyncWithHttpInfo (int? itemReceiptId, string itemReceiptAudit)
        {
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling AddItemReceiptAudit");
            // verify the required parameter 'itemReceiptAudit' is set
            if (itemReceiptAudit == null) throw new ApiException(400, "Missing required parameter 'itemReceiptAudit' when calling AddItemReceiptAudit");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/audit/{itemReceiptAudit}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            if (itemReceiptAudit != null) localVarPathParams.Add("itemReceiptAudit", Configuration.ApiClient.ParameterToString(itemReceiptAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an itemReceipt. Adds a tag to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param> 
        /// <param name="itemReceiptTag">The tag to add</param> 
        /// <returns></returns>
        public void AddItemReceiptTag (int? itemReceiptId, string itemReceiptTag)
        {
             AddItemReceiptTagWithHttpInfo(itemReceiptId, itemReceiptTag);
        }

        /// <summary>
        /// Add new tags for an itemReceipt. Adds a tag to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param> 
        /// <param name="itemReceiptTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemReceiptTagWithHttpInfo (int? itemReceiptId, string itemReceiptTag)
        {
            
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling ItemReceiptApi->AddItemReceiptTag");
            
            // verify the required parameter 'itemReceiptTag' is set
            if (itemReceiptTag == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptTag' when calling ItemReceiptApi->AddItemReceiptTag");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/tag/{itemReceiptTag}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            if (itemReceiptTag != null) localVarPathParams.Add("itemReceiptTag", Configuration.ApiClient.ParameterToString(itemReceiptTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an itemReceipt. Adds a tag to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param>
        /// <param name="itemReceiptTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemReceiptTagAsync (int? itemReceiptId, string itemReceiptTag)
        {
             await AddItemReceiptTagAsyncWithHttpInfo(itemReceiptId, itemReceiptTag);

        }

        /// <summary>
        /// Add new tags for an itemReceipt. Adds a tag to an existing itemReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to add a tag to</param>
        /// <param name="itemReceiptTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemReceiptTagAsyncWithHttpInfo (int? itemReceiptId, string itemReceiptTag)
        {
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling AddItemReceiptTag");
            // verify the required parameter 'itemReceiptTag' is set
            if (itemReceiptTag == null) throw new ApiException(400, "Missing required parameter 'itemReceiptTag' when calling AddItemReceiptTag");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/tag/{itemReceiptTag}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            if (itemReceiptTag != null) localVarPathParams.Add("itemReceiptTag", Configuration.ApiClient.ParameterToString(itemReceiptTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an itemReceipt. Deletes an existing itemReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param> 
        /// <param name="itemReceiptTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteItemReceiptTag (int? itemReceiptId, string itemReceiptTag)
        {
             DeleteItemReceiptTagWithHttpInfo(itemReceiptId, itemReceiptTag);
        }

        /// <summary>
        /// Delete a tag for an itemReceipt. Deletes an existing itemReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param> 
        /// <param name="itemReceiptTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemReceiptTagWithHttpInfo (int? itemReceiptId, string itemReceiptTag)
        {
            
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling ItemReceiptApi->DeleteItemReceiptTag");
            
            // verify the required parameter 'itemReceiptTag' is set
            if (itemReceiptTag == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptTag' when calling ItemReceiptApi->DeleteItemReceiptTag");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/tag/{itemReceiptTag}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            if (itemReceiptTag != null) localVarPathParams.Add("itemReceiptTag", Configuration.ApiClient.ParameterToString(itemReceiptTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an itemReceipt. Deletes an existing itemReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param>
        /// <param name="itemReceiptTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemReceiptTagAsync (int? itemReceiptId, string itemReceiptTag)
        {
             await DeleteItemReceiptTagAsyncWithHttpInfo(itemReceiptId, itemReceiptTag);

        }

        /// <summary>
        /// Delete a tag for an itemReceipt. Deletes an existing itemReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to remove tag from</param>
        /// <param name="itemReceiptTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemReceiptTagAsyncWithHttpInfo (int? itemReceiptId, string itemReceiptTag)
        {
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling DeleteItemReceiptTag");
            // verify the required parameter 'itemReceiptTag' is set
            if (itemReceiptTag == null) throw new ApiException(400, "Missing required parameter 'itemReceiptTag' when calling DeleteItemReceiptTag");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/tag/{itemReceiptTag}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            if (itemReceiptTag != null) localVarPathParams.Add("itemReceiptTag", Configuration.ApiClient.ParameterToString(itemReceiptTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an itemReceipt by id Returns a duplicated itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param> 
        /// <returns>ItemReceipt</returns>
        public ItemReceipt GetDuplicateItemReceiptById (int? itemReceiptId)
        {
             ApiResponse<ItemReceipt> localVarResponse = GetDuplicateItemReceiptByIdWithHttpInfo(itemReceiptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an itemReceipt by id Returns a duplicated itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param> 
        /// <returns>ApiResponse of ItemReceipt</returns>
        public ApiResponse< ItemReceipt > GetDuplicateItemReceiptByIdWithHttpInfo (int? itemReceiptId)
        {
            
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling ItemReceiptApi->GetDuplicateItemReceiptById");
            
    
            var localVarPath = "/beta/itemReceipt/duplicate/{itemReceiptId}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceipt)));
            
        }

        
        /// <summary>
        /// Get a duplicated an itemReceipt by id Returns a duplicated itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param>
        /// <returns>Task of ItemReceipt</returns>
        public async System.Threading.Tasks.Task<ItemReceipt> GetDuplicateItemReceiptByIdAsync (int? itemReceiptId)
        {
             ApiResponse<ItemReceipt> localVarResponse = await GetDuplicateItemReceiptByIdAsyncWithHttpInfo(itemReceiptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an itemReceipt by id Returns a duplicated itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemReceipt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemReceipt>> GetDuplicateItemReceiptByIdAsyncWithHttpInfo (int? itemReceiptId)
        {
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling GetDuplicateItemReceiptById");
            
    
            var localVarPath = "/beta/itemReceipt/duplicate/{itemReceiptId}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceipt)));
            
        }
        
        /// <summary>
        /// Search itemReceipts by filter Returns the list of itemReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ItemReceipt&gt;</returns>
        public List<ItemReceipt> GetItemReceiptByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemReceipt>> localVarResponse = GetItemReceiptByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemReceipts by filter Returns the list of itemReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemReceipt&gt;</returns>
        public ApiResponse< List<ItemReceipt> > GetItemReceiptByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemReceipt/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemReceipt>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemReceipt>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemReceipt>)));
            
        }

        
        /// <summary>
        /// Search itemReceipts by filter Returns the list of itemReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemReceipt&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemReceipt>> GetItemReceiptByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemReceipt>> localVarResponse = await GetItemReceiptByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemReceipts by filter Returns the list of itemReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemReceipt&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemReceipt>>> GetItemReceiptByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemReceipt/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemReceipt>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemReceipt>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemReceipt>)));
            
        }
        
        /// <summary>
        /// Get an itemReceipt by id Returns the itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param> 
        /// <returns>ItemReceipt</returns>
        public ItemReceipt GetItemReceiptById (int? itemReceiptId)
        {
             ApiResponse<ItemReceipt> localVarResponse = GetItemReceiptByIdWithHttpInfo(itemReceiptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemReceipt by id Returns the itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param> 
        /// <returns>ApiResponse of ItemReceipt</returns>
        public ApiResponse< ItemReceipt > GetItemReceiptByIdWithHttpInfo (int? itemReceiptId)
        {
            
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling ItemReceiptApi->GetItemReceiptById");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceipt)));
            
        }

        
        /// <summary>
        /// Get an itemReceipt by id Returns the itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param>
        /// <returns>Task of ItemReceipt</returns>
        public async System.Threading.Tasks.Task<ItemReceipt> GetItemReceiptByIdAsync (int? itemReceiptId)
        {
             ApiResponse<ItemReceipt> localVarResponse = await GetItemReceiptByIdAsyncWithHttpInfo(itemReceiptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemReceipt by id Returns the itemReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to be returned.</param>
        /// <returns>Task of ApiResponse (ItemReceipt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemReceipt>> GetItemReceiptByIdAsyncWithHttpInfo (int? itemReceiptId)
        {
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling GetItemReceiptById");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemReceipt)));
            
        }
        
        /// <summary>
        /// Get the tags for an itemReceipt. Get all existing itemReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param> 
        /// <returns></returns>
        public void GetItemReceiptTags (int? itemReceiptId)
        {
             GetItemReceiptTagsWithHttpInfo(itemReceiptId);
        }

        /// <summary>
        /// Get the tags for an itemReceipt. Get all existing itemReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetItemReceiptTagsWithHttpInfo (int? itemReceiptId)
        {
            
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling ItemReceiptApi->GetItemReceiptTags");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/tag";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an itemReceipt. Get all existing itemReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetItemReceiptTagsAsync (int? itemReceiptId)
        {
             await GetItemReceiptTagsAsyncWithHttpInfo(itemReceiptId);

        }

        /// <summary>
        /// Get the tags for an itemReceipt. Get all existing itemReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemReceiptId">Id of the itemReceipt to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetItemReceiptTagsAsyncWithHttpInfo (int? itemReceiptId)
        {
            // verify the required parameter 'itemReceiptId' is set
            if (itemReceiptId == null) throw new ApiException(400, "Missing required parameter 'itemReceiptId' when calling GetItemReceiptTags");
            
    
            var localVarPath = "/beta/itemReceipt/{itemReceiptId}/tag";
    
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
            if (itemReceiptId != null) localVarPathParams.Add("itemReceiptId", Configuration.ApiClient.ParameterToString(itemReceiptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemReceiptTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemReceipt Updates an existing itemReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemReceipt (ItemReceipt body)
        {
             UpdateItemReceiptWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemReceipt Updates an existing itemReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemReceiptWithHttpInfo (ItemReceipt body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemReceiptApi->UpdateItemReceipt");
            
    
            var localVarPath = "/beta/itemReceipt";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemReceipt Updates an existing itemReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemReceiptAsync (ItemReceipt body)
        {
             await UpdateItemReceiptAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemReceipt Updates an existing itemReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemReceiptAsyncWithHttpInfo (ItemReceipt body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemReceipt");
            
    
            var localVarPath = "/beta/itemReceipt";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemReceipt custom fields Updates an existing itemReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemReceiptCustomFields (ItemReceipt body)
        {
             UpdateItemReceiptCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemReceipt custom fields Updates an existing itemReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemReceiptCustomFieldsWithHttpInfo (ItemReceipt body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemReceiptApi->UpdateItemReceiptCustomFields");
            
    
            var localVarPath = "/beta/itemReceipt/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemReceipt custom fields Updates an existing itemReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemReceiptCustomFieldsAsync (ItemReceipt body)
        {
             await UpdateItemReceiptCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemReceipt custom fields Updates an existing itemReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemReceiptCustomFieldsAsyncWithHttpInfo (ItemReceipt body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemReceiptCustomFields");
            
    
            var localVarPath = "/beta/itemReceipt/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemReceiptCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
