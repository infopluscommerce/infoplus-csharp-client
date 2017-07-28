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
    public interface IInventoryStorageActivityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param>
        /// <returns>InventoryStorageActivity</returns>
        InventoryStorageActivity AddInventoryStorageActivity (InventoryStorageActivity body);
  
        /// <summary>
        /// Create an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param>
        /// <returns>ApiResponse of InventoryStorageActivity</returns>
        ApiResponse<InventoryStorageActivity> AddInventoryStorageActivityWithHttpInfo (InventoryStorageActivity body);
        
        /// <summary>
        /// Add new audit for an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param>
        /// <param name="inventoryStorageActivityAudit">The audit to add</param>
        /// <returns></returns>
        void AddInventoryStorageActivityAudit (int? inventoryStorageActivityId, string inventoryStorageActivityAudit);
  
        /// <summary>
        /// Add new audit for an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param>
        /// <param name="inventoryStorageActivityAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventoryStorageActivityAuditWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityAudit);
        
        /// <summary>
        /// Add new tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param>
        /// <param name="inventoryStorageActivityTag">The tag to add</param>
        /// <returns></returns>
        void AddInventoryStorageActivityTag (int? inventoryStorageActivityId, string inventoryStorageActivityTag);
  
        /// <summary>
        /// Add new tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param>
        /// <param name="inventoryStorageActivityTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventoryStorageActivityTagWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag);
        
        /// <summary>
        /// Delete an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Deletes the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param>
        /// <returns></returns>
        void DeleteInventoryStorageActivity (int? inventoryStorageActivityId);
  
        /// <summary>
        /// Delete an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Deletes the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInventoryStorageActivityWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Delete a tag for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param>
        /// <param name="inventoryStorageActivityTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteInventoryStorageActivityTag (int? inventoryStorageActivityId, string inventoryStorageActivityTag);
  
        /// <summary>
        /// Delete a tag for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param>
        /// <param name="inventoryStorageActivityTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInventoryStorageActivityTagWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag);
        
        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param>
        /// <returns>InventoryStorageActivity</returns>
        InventoryStorageActivity GetDuplicateInventoryStorageActivityById (int? inventoryStorageActivityId);
  
        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param>
        /// <returns>ApiResponse of InventoryStorageActivity</returns>
        ApiResponse<InventoryStorageActivity> GetDuplicateInventoryStorageActivityByIdWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Search inventoryStorageActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryStorageActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;InventoryStorageActivity&gt;</returns>
        List<InventoryStorageActivity> GetInventoryStorageActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search inventoryStorageActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryStorageActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;InventoryStorageActivity&gt;</returns>
        ApiResponse<List<InventoryStorageActivity>> GetInventoryStorageActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param>
        /// <returns>InventoryStorageActivity</returns>
        InventoryStorageActivity GetInventoryStorageActivityById (int? inventoryStorageActivityId);
  
        /// <summary>
        /// Get an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param>
        /// <returns>ApiResponse of InventoryStorageActivity</returns>
        ApiResponse<InventoryStorageActivity> GetInventoryStorageActivityByIdWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Get the tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryStorageActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param>
        /// <returns></returns>
        void GetInventoryStorageActivityTags (int? inventoryStorageActivityId);
  
        /// <summary>
        /// Get the tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryStorageActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetInventoryStorageActivityTagsWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Update an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param>
        /// <returns></returns>
        void UpdateInventoryStorageActivity (InventoryStorageActivity body);
  
        /// <summary>
        /// Update an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateInventoryStorageActivityWithHttpInfo (InventoryStorageActivity body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param>
        /// <returns>Task of InventoryStorageActivity</returns>
        System.Threading.Tasks.Task<InventoryStorageActivity> AddInventoryStorageActivityAsync (InventoryStorageActivity body);

        /// <summary>
        /// Create an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (InventoryStorageActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryStorageActivity>> AddInventoryStorageActivityAsyncWithHttpInfo (InventoryStorageActivity body);
        
        /// <summary>
        /// Add new audit for an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param>
        /// <param name="inventoryStorageActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventoryStorageActivityAuditAsync (int? inventoryStorageActivityId, string inventoryStorageActivityAudit);

        /// <summary>
        /// Add new audit for an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param>
        /// <param name="inventoryStorageActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryStorageActivityAuditAsyncWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityAudit);
        
        /// <summary>
        /// Add new tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param>
        /// <param name="inventoryStorageActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventoryStorageActivityTagAsync (int? inventoryStorageActivityId, string inventoryStorageActivityTag);

        /// <summary>
        /// Add new tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventoryStorageActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param>
        /// <param name="inventoryStorageActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryStorageActivityTagAsyncWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag);
        
        /// <summary>
        /// Delete an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Deletes the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInventoryStorageActivityAsync (int? inventoryStorageActivityId);

        /// <summary>
        /// Delete an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Deletes the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryStorageActivityAsyncWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Delete a tag for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param>
        /// <param name="inventoryStorageActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInventoryStorageActivityTagAsync (int? inventoryStorageActivityId, string inventoryStorageActivityTag);

        /// <summary>
        /// Delete a tag for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param>
        /// <param name="inventoryStorageActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryStorageActivityTagAsyncWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag);
        
        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param>
        /// <returns>Task of InventoryStorageActivity</returns>
        System.Threading.Tasks.Task<InventoryStorageActivity> GetDuplicateInventoryStorageActivityByIdAsync (int? inventoryStorageActivityId);

        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventoryStorageActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryStorageActivity>> GetDuplicateInventoryStorageActivityByIdAsyncWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Search inventoryStorageActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryStorageActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventoryStorageActivity&gt;</returns>
        System.Threading.Tasks.Task<List<InventoryStorageActivity>> GetInventoryStorageActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search inventoryStorageActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventoryStorageActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryStorageActivity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InventoryStorageActivity>>> GetInventoryStorageActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param>
        /// <returns>Task of InventoryStorageActivity</returns>
        System.Threading.Tasks.Task<InventoryStorageActivity> GetInventoryStorageActivityByIdAsync (int? inventoryStorageActivityId);

        /// <summary>
        /// Get an inventoryStorageActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the inventoryStorageActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param>
        /// <returns>Task of ApiResponse (InventoryStorageActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryStorageActivity>> GetInventoryStorageActivityByIdAsyncWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Get the tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryStorageActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetInventoryStorageActivityTagsAsync (int? inventoryStorageActivityId);

        /// <summary>
        /// Get the tags for an inventoryStorageActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing inventoryStorageActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetInventoryStorageActivityTagsAsyncWithHttpInfo (int? inventoryStorageActivityId);
        
        /// <summary>
        /// Update an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateInventoryStorageActivityAsync (InventoryStorageActivity body);

        /// <summary>
        /// Update an inventoryStorageActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing inventoryStorageActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInventoryStorageActivityAsyncWithHttpInfo (InventoryStorageActivity body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InventoryStorageActivityApi : IInventoryStorageActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryStorageActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InventoryStorageActivityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryStorageActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InventoryStorageActivityApi(Configuration configuration = null)
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
        /// Create an inventoryStorageActivity Inserts a new inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param> 
        /// <returns>InventoryStorageActivity</returns>
        public InventoryStorageActivity AddInventoryStorageActivity (InventoryStorageActivity body)
        {
             ApiResponse<InventoryStorageActivity> localVarResponse = AddInventoryStorageActivityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an inventoryStorageActivity Inserts a new inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param> 
        /// <returns>ApiResponse of InventoryStorageActivity</returns>
        public ApiResponse< InventoryStorageActivity > AddInventoryStorageActivityWithHttpInfo (InventoryStorageActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InventoryStorageActivityApi->AddInventoryStorageActivity");
            
    
            var localVarPath = "/beta/inventoryStorageActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventoryStorageActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryStorageActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryStorageActivity)));
            
        }

        
        /// <summary>
        /// Create an inventoryStorageActivity Inserts a new inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param>
        /// <returns>Task of InventoryStorageActivity</returns>
        public async System.Threading.Tasks.Task<InventoryStorageActivity> AddInventoryStorageActivityAsync (InventoryStorageActivity body)
        {
             ApiResponse<InventoryStorageActivity> localVarResponse = await AddInventoryStorageActivityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an inventoryStorageActivity Inserts a new inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (InventoryStorageActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryStorageActivity>> AddInventoryStorageActivityAsyncWithHttpInfo (InventoryStorageActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddInventoryStorageActivity");
            
    
            var localVarPath = "/beta/inventoryStorageActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryStorageActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryStorageActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryStorageActivity)));
            
        }
        
        /// <summary>
        /// Add new audit for an inventoryStorageActivity Adds an audit to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param> 
        /// <param name="inventoryStorageActivityAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddInventoryStorageActivityAudit (int? inventoryStorageActivityId, string inventoryStorageActivityAudit)
        {
             AddInventoryStorageActivityAuditWithHttpInfo(inventoryStorageActivityId, inventoryStorageActivityAudit);
        }

        /// <summary>
        /// Add new audit for an inventoryStorageActivity Adds an audit to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param> 
        /// <param name="inventoryStorageActivityAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventoryStorageActivityAuditWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityAudit)
        {
            
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling InventoryStorageActivityApi->AddInventoryStorageActivityAudit");
            
            // verify the required parameter 'inventoryStorageActivityAudit' is set
            if (inventoryStorageActivityAudit == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityAudit' when calling InventoryStorageActivityApi->AddInventoryStorageActivityAudit");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/audit/{inventoryStorageActivityAudit}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            if (inventoryStorageActivityAudit != null) localVarPathParams.Add("inventoryStorageActivityAudit", Configuration.ApiClient.ParameterToString(inventoryStorageActivityAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an inventoryStorageActivity Adds an audit to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param>
        /// <param name="inventoryStorageActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventoryStorageActivityAuditAsync (int? inventoryStorageActivityId, string inventoryStorageActivityAudit)
        {
             await AddInventoryStorageActivityAuditAsyncWithHttpInfo(inventoryStorageActivityId, inventoryStorageActivityAudit);

        }

        /// <summary>
        /// Add new audit for an inventoryStorageActivity Adds an audit to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add an audit to</param>
        /// <param name="inventoryStorageActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryStorageActivityAuditAsyncWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityAudit)
        {
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling AddInventoryStorageActivityAudit");
            // verify the required parameter 'inventoryStorageActivityAudit' is set
            if (inventoryStorageActivityAudit == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityAudit' when calling AddInventoryStorageActivityAudit");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/audit/{inventoryStorageActivityAudit}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            if (inventoryStorageActivityAudit != null) localVarPathParams.Add("inventoryStorageActivityAudit", Configuration.ApiClient.ParameterToString(inventoryStorageActivityAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an inventoryStorageActivity. Adds a tag to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param> 
        /// <param name="inventoryStorageActivityTag">The tag to add</param> 
        /// <returns></returns>
        public void AddInventoryStorageActivityTag (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
             AddInventoryStorageActivityTagWithHttpInfo(inventoryStorageActivityId, inventoryStorageActivityTag);
        }

        /// <summary>
        /// Add new tags for an inventoryStorageActivity. Adds a tag to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param> 
        /// <param name="inventoryStorageActivityTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventoryStorageActivityTagWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
            
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling InventoryStorageActivityApi->AddInventoryStorageActivityTag");
            
            // verify the required parameter 'inventoryStorageActivityTag' is set
            if (inventoryStorageActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityTag' when calling InventoryStorageActivityApi->AddInventoryStorageActivityTag");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/tag/{inventoryStorageActivityTag}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            if (inventoryStorageActivityTag != null) localVarPathParams.Add("inventoryStorageActivityTag", Configuration.ApiClient.ParameterToString(inventoryStorageActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an inventoryStorageActivity. Adds a tag to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param>
        /// <param name="inventoryStorageActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventoryStorageActivityTagAsync (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
             await AddInventoryStorageActivityTagAsyncWithHttpInfo(inventoryStorageActivityId, inventoryStorageActivityTag);

        }

        /// <summary>
        /// Add new tags for an inventoryStorageActivity. Adds a tag to an existing inventoryStorageActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to add a tag to</param>
        /// <param name="inventoryStorageActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventoryStorageActivityTagAsyncWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling AddInventoryStorageActivityTag");
            // verify the required parameter 'inventoryStorageActivityTag' is set
            if (inventoryStorageActivityTag == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityTag' when calling AddInventoryStorageActivityTag");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/tag/{inventoryStorageActivityTag}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            if (inventoryStorageActivityTag != null) localVarPathParams.Add("inventoryStorageActivityTag", Configuration.ApiClient.ParameterToString(inventoryStorageActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventoryStorageActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an inventoryStorageActivity Deletes the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param> 
        /// <returns></returns>
        public void DeleteInventoryStorageActivity (int? inventoryStorageActivityId)
        {
             DeleteInventoryStorageActivityWithHttpInfo(inventoryStorageActivityId);
        }

        /// <summary>
        /// Delete an inventoryStorageActivity Deletes the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInventoryStorageActivityWithHttpInfo (int? inventoryStorageActivityId)
        {
            
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling InventoryStorageActivityApi->DeleteInventoryStorageActivity");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an inventoryStorageActivity Deletes the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInventoryStorageActivityAsync (int? inventoryStorageActivityId)
        {
             await DeleteInventoryStorageActivityAsyncWithHttpInfo(inventoryStorageActivityId);

        }

        /// <summary>
        /// Delete an inventoryStorageActivity Deletes the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryStorageActivityAsyncWithHttpInfo (int? inventoryStorageActivityId)
        {
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling DeleteInventoryStorageActivity");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an inventoryStorageActivity. Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param> 
        /// <param name="inventoryStorageActivityTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteInventoryStorageActivityTag (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
             DeleteInventoryStorageActivityTagWithHttpInfo(inventoryStorageActivityId, inventoryStorageActivityTag);
        }

        /// <summary>
        /// Delete a tag for an inventoryStorageActivity. Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param> 
        /// <param name="inventoryStorageActivityTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInventoryStorageActivityTagWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
            
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling InventoryStorageActivityApi->DeleteInventoryStorageActivityTag");
            
            // verify the required parameter 'inventoryStorageActivityTag' is set
            if (inventoryStorageActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityTag' when calling InventoryStorageActivityApi->DeleteInventoryStorageActivityTag");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/tag/{inventoryStorageActivityTag}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            if (inventoryStorageActivityTag != null) localVarPathParams.Add("inventoryStorageActivityTag", Configuration.ApiClient.ParameterToString(inventoryStorageActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an inventoryStorageActivity. Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param>
        /// <param name="inventoryStorageActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInventoryStorageActivityTagAsync (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
             await DeleteInventoryStorageActivityTagAsyncWithHttpInfo(inventoryStorageActivityId, inventoryStorageActivityTag);

        }

        /// <summary>
        /// Delete a tag for an inventoryStorageActivity. Deletes an existing inventoryStorageActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to remove tag from</param>
        /// <param name="inventoryStorageActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventoryStorageActivityTagAsyncWithHttpInfo (int? inventoryStorageActivityId, string inventoryStorageActivityTag)
        {
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling DeleteInventoryStorageActivityTag");
            // verify the required parameter 'inventoryStorageActivityTag' is set
            if (inventoryStorageActivityTag == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityTag' when calling DeleteInventoryStorageActivityTag");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/tag/{inventoryStorageActivityTag}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            if (inventoryStorageActivityTag != null) localVarPathParams.Add("inventoryStorageActivityTag", Configuration.ApiClient.ParameterToString(inventoryStorageActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventoryStorageActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param> 
        /// <returns>InventoryStorageActivity</returns>
        public InventoryStorageActivity GetDuplicateInventoryStorageActivityById (int? inventoryStorageActivityId)
        {
             ApiResponse<InventoryStorageActivity> localVarResponse = GetDuplicateInventoryStorageActivityByIdWithHttpInfo(inventoryStorageActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param> 
        /// <returns>ApiResponse of InventoryStorageActivity</returns>
        public ApiResponse< InventoryStorageActivity > GetDuplicateInventoryStorageActivityByIdWithHttpInfo (int? inventoryStorageActivityId)
        {
            
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling InventoryStorageActivityApi->GetDuplicateInventoryStorageActivityById");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/duplicate/{inventoryStorageActivityId}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryStorageActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryStorageActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventoryStorageActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryStorageActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryStorageActivity)));
            
        }

        
        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param>
        /// <returns>Task of InventoryStorageActivity</returns>
        public async System.Threading.Tasks.Task<InventoryStorageActivity> GetDuplicateInventoryStorageActivityByIdAsync (int? inventoryStorageActivityId)
        {
             ApiResponse<InventoryStorageActivity> localVarResponse = await GetDuplicateInventoryStorageActivityByIdAsyncWithHttpInfo(inventoryStorageActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an inventoryStorageActivity by id Returns a duplicated inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventoryStorageActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryStorageActivity>> GetDuplicateInventoryStorageActivityByIdAsyncWithHttpInfo (int? inventoryStorageActivityId)
        {
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling GetDuplicateInventoryStorageActivityById");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/duplicate/{inventoryStorageActivityId}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryStorageActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventoryStorageActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryStorageActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryStorageActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryStorageActivity)));
            
        }
        
        /// <summary>
        /// Search inventoryStorageActivitys by filter Returns the list of inventoryStorageActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;InventoryStorageActivity&gt;</returns>
        public List<InventoryStorageActivity> GetInventoryStorageActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventoryStorageActivity>> localVarResponse = GetInventoryStorageActivityByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search inventoryStorageActivitys by filter Returns the list of inventoryStorageActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;InventoryStorageActivity&gt;</returns>
        public ApiResponse< List<InventoryStorageActivity> > GetInventoryStorageActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventoryStorageActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InventoryStorageActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryStorageActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventoryStorageActivity>)));
            
        }

        
        /// <summary>
        /// Search inventoryStorageActivitys by filter Returns the list of inventoryStorageActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventoryStorageActivity&gt;</returns>
        public async System.Threading.Tasks.Task<List<InventoryStorageActivity>> GetInventoryStorageActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventoryStorageActivity>> localVarResponse = await GetInventoryStorageActivityByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search inventoryStorageActivitys by filter Returns the list of inventoryStorageActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryStorageActivity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InventoryStorageActivity>>> GetInventoryStorageActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventoryStorageActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventoryStorageActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryStorageActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventoryStorageActivity>)));
            
        }
        
        /// <summary>
        /// Get an inventoryStorageActivity by id Returns the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param> 
        /// <returns>InventoryStorageActivity</returns>
        public InventoryStorageActivity GetInventoryStorageActivityById (int? inventoryStorageActivityId)
        {
             ApiResponse<InventoryStorageActivity> localVarResponse = GetInventoryStorageActivityByIdWithHttpInfo(inventoryStorageActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an inventoryStorageActivity by id Returns the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param> 
        /// <returns>ApiResponse of InventoryStorageActivity</returns>
        public ApiResponse< InventoryStorageActivity > GetInventoryStorageActivityByIdWithHttpInfo (int? inventoryStorageActivityId)
        {
            
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling InventoryStorageActivityApi->GetInventoryStorageActivityById");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventoryStorageActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryStorageActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryStorageActivity)));
            
        }

        
        /// <summary>
        /// Get an inventoryStorageActivity by id Returns the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param>
        /// <returns>Task of InventoryStorageActivity</returns>
        public async System.Threading.Tasks.Task<InventoryStorageActivity> GetInventoryStorageActivityByIdAsync (int? inventoryStorageActivityId)
        {
             ApiResponse<InventoryStorageActivity> localVarResponse = await GetInventoryStorageActivityByIdAsyncWithHttpInfo(inventoryStorageActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an inventoryStorageActivity by id Returns the inventoryStorageActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to be returned.</param>
        /// <returns>Task of ApiResponse (InventoryStorageActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryStorageActivity>> GetInventoryStorageActivityByIdAsyncWithHttpInfo (int? inventoryStorageActivityId)
        {
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling GetInventoryStorageActivityById");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryStorageActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryStorageActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventoryStorageActivity)));
            
        }
        
        /// <summary>
        /// Get the tags for an inventoryStorageActivity. Get all existing inventoryStorageActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param> 
        /// <returns></returns>
        public void GetInventoryStorageActivityTags (int? inventoryStorageActivityId)
        {
             GetInventoryStorageActivityTagsWithHttpInfo(inventoryStorageActivityId);
        }

        /// <summary>
        /// Get the tags for an inventoryStorageActivity. Get all existing inventoryStorageActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetInventoryStorageActivityTagsWithHttpInfo (int? inventoryStorageActivityId)
        {
            
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null)
                throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling InventoryStorageActivityApi->GetInventoryStorageActivityTags");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/tag";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an inventoryStorageActivity. Get all existing inventoryStorageActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetInventoryStorageActivityTagsAsync (int? inventoryStorageActivityId)
        {
             await GetInventoryStorageActivityTagsAsyncWithHttpInfo(inventoryStorageActivityId);

        }

        /// <summary>
        /// Get the tags for an inventoryStorageActivity. Get all existing inventoryStorageActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventoryStorageActivityId">Id of the inventoryStorageActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetInventoryStorageActivityTagsAsyncWithHttpInfo (int? inventoryStorageActivityId)
        {
            // verify the required parameter 'inventoryStorageActivityId' is set
            if (inventoryStorageActivityId == null) throw new ApiException(400, "Missing required parameter 'inventoryStorageActivityId' when calling GetInventoryStorageActivityTags");
            
    
            var localVarPath = "/beta/inventoryStorageActivity/{inventoryStorageActivityId}/tag";
    
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
            if (inventoryStorageActivityId != null) localVarPathParams.Add("inventoryStorageActivityId", Configuration.ApiClient.ParameterToString(inventoryStorageActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventoryStorageActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an inventoryStorageActivity Updates an existing inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param> 
        /// <returns></returns>
        public void UpdateInventoryStorageActivity (InventoryStorageActivity body)
        {
             UpdateInventoryStorageActivityWithHttpInfo(body);
        }

        /// <summary>
        /// Update an inventoryStorageActivity Updates an existing inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateInventoryStorageActivityWithHttpInfo (InventoryStorageActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InventoryStorageActivityApi->UpdateInventoryStorageActivity");
            
    
            var localVarPath = "/beta/inventoryStorageActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryStorageActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryStorageActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an inventoryStorageActivity Updates an existing inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateInventoryStorageActivityAsync (InventoryStorageActivity body)
        {
             await UpdateInventoryStorageActivityAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an inventoryStorageActivity Updates an existing inventoryStorageActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InventoryStorageActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInventoryStorageActivityAsyncWithHttpInfo (InventoryStorageActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateInventoryStorageActivity");
            
    
            var localVarPath = "/beta/inventoryStorageActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryStorageActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInventoryStorageActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
