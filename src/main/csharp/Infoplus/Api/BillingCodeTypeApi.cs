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
    public interface IBillingCodeTypeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a billingCodeType
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param>
        /// <returns>BillingCodeType</returns>
        BillingCodeType AddBillingCodeType (BillingCodeType body);
  
        /// <summary>
        /// Create a billingCodeType
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param>
        /// <returns>ApiResponse of BillingCodeType</returns>
        ApiResponse<BillingCodeType> AddBillingCodeTypeWithHttpInfo (BillingCodeType body);
        
        /// <summary>
        /// Add new audit for a billingCodeType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param>
        /// <param name="billingCodeTypeAudit">The audit to add</param>
        /// <returns></returns>
        void AddBillingCodeTypeAudit (int? billingCodeTypeId, string billingCodeTypeAudit);
  
        /// <summary>
        /// Add new audit for a billingCodeType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param>
        /// <param name="billingCodeTypeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBillingCodeTypeAuditWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeAudit);
        
        /// <summary>
        /// Add new tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param>
        /// <param name="billingCodeTypeTag">The tag to add</param>
        /// <returns></returns>
        void AddBillingCodeTypeTag (int? billingCodeTypeId, string billingCodeTypeTag);
  
        /// <summary>
        /// Add new tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param>
        /// <param name="billingCodeTypeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBillingCodeTypeTagWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag);
        
        /// <summary>
        /// Delete a billingCodeType
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param>
        /// <returns></returns>
        void DeleteBillingCodeType (int? billingCodeTypeId);
  
        /// <summary>
        /// Delete a billingCodeType
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBillingCodeTypeWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Delete a tag for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param>
        /// <param name="billingCodeTypeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteBillingCodeTypeTag (int? billingCodeTypeId, string billingCodeTypeTag);
  
        /// <summary>
        /// Delete a tag for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param>
        /// <param name="billingCodeTypeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBillingCodeTypeTagWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag);
        
        /// <summary>
        /// Search billingCodeTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;BillingCodeType&gt;</returns>
        List<BillingCodeType> GetBillingCodeTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search billingCodeTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;BillingCodeType&gt;</returns>
        ApiResponse<List<BillingCodeType>> GetBillingCodeTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param>
        /// <returns>BillingCodeType</returns>
        BillingCodeType GetBillingCodeTypeById (int? billingCodeTypeId);
  
        /// <summary>
        /// Get a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param>
        /// <returns>ApiResponse of BillingCodeType</returns>
        ApiResponse<BillingCodeType> GetBillingCodeTypeByIdWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Get the tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param>
        /// <returns></returns>
        void GetBillingCodeTypeTags (int? billingCodeTypeId);
  
        /// <summary>
        /// Get the tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBillingCodeTypeTagsWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Get a duplicated a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param>
        /// <returns>BillingCodeType</returns>
        BillingCodeType GetDuplicateBillingCodeTypeById (int? billingCodeTypeId);
  
        /// <summary>
        /// Get a duplicated a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param>
        /// <returns>ApiResponse of BillingCodeType</returns>
        ApiResponse<BillingCodeType> GetDuplicateBillingCodeTypeByIdWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Update a billingCodeType
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns></returns>
        void UpdateBillingCodeType (BillingCodeType body);
  
        /// <summary>
        /// Update a billingCodeType
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateBillingCodeTypeWithHttpInfo (BillingCodeType body);
        
        /// <summary>
        /// Update a billingCodeType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns></returns>
        void UpdateBillingCodeTypeCustomFields (BillingCodeType body);
  
        /// <summary>
        /// Update a billingCodeType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateBillingCodeTypeCustomFieldsWithHttpInfo (BillingCodeType body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a billingCodeType
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param>
        /// <returns>Task of BillingCodeType</returns>
        System.Threading.Tasks.Task<BillingCodeType> AddBillingCodeTypeAsync (BillingCodeType body);

        /// <summary>
        /// Create a billingCodeType
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param>
        /// <returns>Task of ApiResponse (BillingCodeType)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillingCodeType>> AddBillingCodeTypeAsyncWithHttpInfo (BillingCodeType body);
        
        /// <summary>
        /// Add new audit for a billingCodeType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param>
        /// <param name="billingCodeTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBillingCodeTypeAuditAsync (int? billingCodeTypeId, string billingCodeTypeAudit);

        /// <summary>
        /// Add new audit for a billingCodeType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param>
        /// <param name="billingCodeTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeTypeAuditAsyncWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeAudit);
        
        /// <summary>
        /// Add new tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param>
        /// <param name="billingCodeTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBillingCodeTypeTagAsync (int? billingCodeTypeId, string billingCodeTypeTag);

        /// <summary>
        /// Add new tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param>
        /// <param name="billingCodeTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeTypeTagAsyncWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag);
        
        /// <summary>
        /// Delete a billingCodeType
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBillingCodeTypeAsync (int? billingCodeTypeId);

        /// <summary>
        /// Delete a billingCodeType
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeTypeAsyncWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Delete a tag for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param>
        /// <param name="billingCodeTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBillingCodeTypeTagAsync (int? billingCodeTypeId, string billingCodeTypeTag);

        /// <summary>
        /// Delete a tag for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param>
        /// <param name="billingCodeTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeTypeTagAsyncWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag);
        
        /// <summary>
        /// Search billingCodeTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BillingCodeType&gt;</returns>
        System.Threading.Tasks.Task<List<BillingCodeType>> GetBillingCodeTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search billingCodeTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BillingCodeType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BillingCodeType>>> GetBillingCodeTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param>
        /// <returns>Task of BillingCodeType</returns>
        System.Threading.Tasks.Task<BillingCodeType> GetBillingCodeTypeByIdAsync (int? billingCodeTypeId);

        /// <summary>
        /// Get a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param>
        /// <returns>Task of ApiResponse (BillingCodeType)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillingCodeType>> GetBillingCodeTypeByIdAsyncWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Get the tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBillingCodeTypeTagsAsync (int? billingCodeTypeId);

        /// <summary>
        /// Get the tags for a billingCodeType.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBillingCodeTypeTagsAsyncWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Get a duplicated a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param>
        /// <returns>Task of BillingCodeType</returns>
        System.Threading.Tasks.Task<BillingCodeType> GetDuplicateBillingCodeTypeByIdAsync (int? billingCodeTypeId);

        /// <summary>
        /// Get a duplicated a billingCodeType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param>
        /// <returns>Task of ApiResponse (BillingCodeType)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillingCodeType>> GetDuplicateBillingCodeTypeByIdAsyncWithHttpInfo (int? billingCodeTypeId);
        
        /// <summary>
        /// Update a billingCodeType
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateBillingCodeTypeAsync (BillingCodeType body);

        /// <summary>
        /// Update a billingCodeType
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillingCodeTypeAsyncWithHttpInfo (BillingCodeType body);
        
        /// <summary>
        /// Update a billingCodeType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateBillingCodeTypeCustomFieldsAsync (BillingCodeType body);

        /// <summary>
        /// Update a billingCodeType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillingCodeTypeCustomFieldsAsyncWithHttpInfo (BillingCodeType body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillingCodeTypeApi : IBillingCodeTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingCodeTypeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillingCodeTypeApi(Configuration configuration = null)
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
        /// Create a billingCodeType Inserts a new billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param> 
        /// <returns>BillingCodeType</returns>
        public BillingCodeType AddBillingCodeType (BillingCodeType body)
        {
             ApiResponse<BillingCodeType> localVarResponse = AddBillingCodeTypeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a billingCodeType Inserts a new billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param> 
        /// <returns>ApiResponse of BillingCodeType</returns>
        public ApiResponse< BillingCodeType > AddBillingCodeTypeWithHttpInfo (BillingCodeType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillingCodeTypeApi->AddBillingCodeType");
            
    
            var localVarPath = "/beta/billingCodeType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillingCodeType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeType)));
            
        }

        
        /// <summary>
        /// Create a billingCodeType Inserts a new billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param>
        /// <returns>Task of BillingCodeType</returns>
        public async System.Threading.Tasks.Task<BillingCodeType> AddBillingCodeTypeAsync (BillingCodeType body)
        {
             ApiResponse<BillingCodeType> localVarResponse = await AddBillingCodeTypeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a billingCodeType Inserts a new billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be inserted.</param>
        /// <returns>Task of ApiResponse (BillingCodeType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillingCodeType>> AddBillingCodeTypeAsyncWithHttpInfo (BillingCodeType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBillingCodeType");
            
    
            var localVarPath = "/beta/billingCodeType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingCodeType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeType)));
            
        }
        
        /// <summary>
        /// Add new audit for a billingCodeType Adds an audit to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param> 
        /// <param name="billingCodeTypeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddBillingCodeTypeAudit (int? billingCodeTypeId, string billingCodeTypeAudit)
        {
             AddBillingCodeTypeAuditWithHttpInfo(billingCodeTypeId, billingCodeTypeAudit);
        }

        /// <summary>
        /// Add new audit for a billingCodeType Adds an audit to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param> 
        /// <param name="billingCodeTypeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBillingCodeTypeAuditWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeAudit)
        {
            
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling BillingCodeTypeApi->AddBillingCodeTypeAudit");
            
            // verify the required parameter 'billingCodeTypeAudit' is set
            if (billingCodeTypeAudit == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeAudit' when calling BillingCodeTypeApi->AddBillingCodeTypeAudit");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/audit/{billingCodeTypeAudit}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            if (billingCodeTypeAudit != null) localVarPathParams.Add("billingCodeTypeAudit", Configuration.ApiClient.ParameterToString(billingCodeTypeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a billingCodeType Adds an audit to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param>
        /// <param name="billingCodeTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBillingCodeTypeAuditAsync (int? billingCodeTypeId, string billingCodeTypeAudit)
        {
             await AddBillingCodeTypeAuditAsyncWithHttpInfo(billingCodeTypeId, billingCodeTypeAudit);

        }

        /// <summary>
        /// Add new audit for a billingCodeType Adds an audit to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add an audit to</param>
        /// <param name="billingCodeTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeTypeAuditAsyncWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeAudit)
        {
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling AddBillingCodeTypeAudit");
            // verify the required parameter 'billingCodeTypeAudit' is set
            if (billingCodeTypeAudit == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeAudit' when calling AddBillingCodeTypeAudit");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/audit/{billingCodeTypeAudit}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            if (billingCodeTypeAudit != null) localVarPathParams.Add("billingCodeTypeAudit", Configuration.ApiClient.ParameterToString(billingCodeTypeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a billingCodeType. Adds a tag to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param> 
        /// <param name="billingCodeTypeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddBillingCodeTypeTag (int? billingCodeTypeId, string billingCodeTypeTag)
        {
             AddBillingCodeTypeTagWithHttpInfo(billingCodeTypeId, billingCodeTypeTag);
        }

        /// <summary>
        /// Add new tags for a billingCodeType. Adds a tag to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param> 
        /// <param name="billingCodeTypeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBillingCodeTypeTagWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag)
        {
            
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling BillingCodeTypeApi->AddBillingCodeTypeTag");
            
            // verify the required parameter 'billingCodeTypeTag' is set
            if (billingCodeTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeTag' when calling BillingCodeTypeApi->AddBillingCodeTypeTag");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/tag/{billingCodeTypeTag}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            if (billingCodeTypeTag != null) localVarPathParams.Add("billingCodeTypeTag", Configuration.ApiClient.ParameterToString(billingCodeTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a billingCodeType. Adds a tag to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param>
        /// <param name="billingCodeTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBillingCodeTypeTagAsync (int? billingCodeTypeId, string billingCodeTypeTag)
        {
             await AddBillingCodeTypeTagAsyncWithHttpInfo(billingCodeTypeId, billingCodeTypeTag);

        }

        /// <summary>
        /// Add new tags for a billingCodeType. Adds a tag to an existing billingCodeType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to add a tag to</param>
        /// <param name="billingCodeTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeTypeTagAsyncWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag)
        {
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling AddBillingCodeTypeTag");
            // verify the required parameter 'billingCodeTypeTag' is set
            if (billingCodeTypeTag == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeTag' when calling AddBillingCodeTypeTag");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/tag/{billingCodeTypeTag}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            if (billingCodeTypeTag != null) localVarPathParams.Add("billingCodeTypeTag", Configuration.ApiClient.ParameterToString(billingCodeTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a billingCodeType Deletes the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param> 
        /// <returns></returns>
        public void DeleteBillingCodeType (int? billingCodeTypeId)
        {
             DeleteBillingCodeTypeWithHttpInfo(billingCodeTypeId);
        }

        /// <summary>
        /// Delete a billingCodeType Deletes the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBillingCodeTypeWithHttpInfo (int? billingCodeTypeId)
        {
            
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling BillingCodeTypeApi->DeleteBillingCodeType");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a billingCodeType Deletes the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBillingCodeTypeAsync (int? billingCodeTypeId)
        {
             await DeleteBillingCodeTypeAsyncWithHttpInfo(billingCodeTypeId);

        }

        /// <summary>
        /// Delete a billingCodeType Deletes the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeTypeAsyncWithHttpInfo (int? billingCodeTypeId)
        {
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling DeleteBillingCodeType");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a billingCodeType. Deletes an existing billingCodeType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param> 
        /// <param name="billingCodeTypeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteBillingCodeTypeTag (int? billingCodeTypeId, string billingCodeTypeTag)
        {
             DeleteBillingCodeTypeTagWithHttpInfo(billingCodeTypeId, billingCodeTypeTag);
        }

        /// <summary>
        /// Delete a tag for a billingCodeType. Deletes an existing billingCodeType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param> 
        /// <param name="billingCodeTypeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBillingCodeTypeTagWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag)
        {
            
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling BillingCodeTypeApi->DeleteBillingCodeTypeTag");
            
            // verify the required parameter 'billingCodeTypeTag' is set
            if (billingCodeTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeTag' when calling BillingCodeTypeApi->DeleteBillingCodeTypeTag");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/tag/{billingCodeTypeTag}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            if (billingCodeTypeTag != null) localVarPathParams.Add("billingCodeTypeTag", Configuration.ApiClient.ParameterToString(billingCodeTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a billingCodeType. Deletes an existing billingCodeType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param>
        /// <param name="billingCodeTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBillingCodeTypeTagAsync (int? billingCodeTypeId, string billingCodeTypeTag)
        {
             await DeleteBillingCodeTypeTagAsyncWithHttpInfo(billingCodeTypeId, billingCodeTypeTag);

        }

        /// <summary>
        /// Delete a tag for a billingCodeType. Deletes an existing billingCodeType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to remove tag from</param>
        /// <param name="billingCodeTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeTypeTagAsyncWithHttpInfo (int? billingCodeTypeId, string billingCodeTypeTag)
        {
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling DeleteBillingCodeTypeTag");
            // verify the required parameter 'billingCodeTypeTag' is set
            if (billingCodeTypeTag == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeTag' when calling DeleteBillingCodeTypeTag");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/tag/{billingCodeTypeTag}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            if (billingCodeTypeTag != null) localVarPathParams.Add("billingCodeTypeTag", Configuration.ApiClient.ParameterToString(billingCodeTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search billingCodeTypes by filter Returns the list of billingCodeTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;BillingCodeType&gt;</returns>
        public List<BillingCodeType> GetBillingCodeTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BillingCodeType>> localVarResponse = GetBillingCodeTypeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search billingCodeTypes by filter Returns the list of billingCodeTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;BillingCodeType&gt;</returns>
        public ApiResponse< List<BillingCodeType> > GetBillingCodeTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/billingCodeType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<BillingCodeType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BillingCodeType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillingCodeType>)));
            
        }

        
        /// <summary>
        /// Search billingCodeTypes by filter Returns the list of billingCodeTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BillingCodeType&gt;</returns>
        public async System.Threading.Tasks.Task<List<BillingCodeType>> GetBillingCodeTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BillingCodeType>> localVarResponse = await GetBillingCodeTypeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search billingCodeTypes by filter Returns the list of billingCodeTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BillingCodeType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BillingCodeType>>> GetBillingCodeTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/billingCodeType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<BillingCodeType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BillingCodeType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillingCodeType>)));
            
        }
        
        /// <summary>
        /// Get a billingCodeType by id Returns the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param> 
        /// <returns>BillingCodeType</returns>
        public BillingCodeType GetBillingCodeTypeById (int? billingCodeTypeId)
        {
             ApiResponse<BillingCodeType> localVarResponse = GetBillingCodeTypeByIdWithHttpInfo(billingCodeTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a billingCodeType by id Returns the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param> 
        /// <returns>ApiResponse of BillingCodeType</returns>
        public ApiResponse< BillingCodeType > GetBillingCodeTypeByIdWithHttpInfo (int? billingCodeTypeId)
        {
            
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling BillingCodeTypeApi->GetBillingCodeTypeById");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillingCodeType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeType)));
            
        }

        
        /// <summary>
        /// Get a billingCodeType by id Returns the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param>
        /// <returns>Task of BillingCodeType</returns>
        public async System.Threading.Tasks.Task<BillingCodeType> GetBillingCodeTypeByIdAsync (int? billingCodeTypeId)
        {
             ApiResponse<BillingCodeType> localVarResponse = await GetBillingCodeTypeByIdAsyncWithHttpInfo(billingCodeTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a billingCodeType by id Returns the billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be returned.</param>
        /// <returns>Task of ApiResponse (BillingCodeType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillingCodeType>> GetBillingCodeTypeByIdAsyncWithHttpInfo (int? billingCodeTypeId)
        {
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling GetBillingCodeTypeById");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingCodeType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeType)));
            
        }
        
        /// <summary>
        /// Get the tags for a billingCodeType. Get all existing billingCodeType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param> 
        /// <returns></returns>
        public void GetBillingCodeTypeTags (int? billingCodeTypeId)
        {
             GetBillingCodeTypeTagsWithHttpInfo(billingCodeTypeId);
        }

        /// <summary>
        /// Get the tags for a billingCodeType. Get all existing billingCodeType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetBillingCodeTypeTagsWithHttpInfo (int? billingCodeTypeId)
        {
            
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling BillingCodeTypeApi->GetBillingCodeTypeTags");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/tag";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a billingCodeType. Get all existing billingCodeType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetBillingCodeTypeTagsAsync (int? billingCodeTypeId)
        {
             await GetBillingCodeTypeTagsAsyncWithHttpInfo(billingCodeTypeId);

        }

        /// <summary>
        /// Get the tags for a billingCodeType. Get all existing billingCodeType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetBillingCodeTypeTagsAsyncWithHttpInfo (int? billingCodeTypeId)
        {
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling GetBillingCodeTypeTags");
            
    
            var localVarPath = "/beta/billingCodeType/{billingCodeTypeId}/tag";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a billingCodeType by id Returns a duplicated billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param> 
        /// <returns>BillingCodeType</returns>
        public BillingCodeType GetDuplicateBillingCodeTypeById (int? billingCodeTypeId)
        {
             ApiResponse<BillingCodeType> localVarResponse = GetDuplicateBillingCodeTypeByIdWithHttpInfo(billingCodeTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a billingCodeType by id Returns a duplicated billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param> 
        /// <returns>ApiResponse of BillingCodeType</returns>
        public ApiResponse< BillingCodeType > GetDuplicateBillingCodeTypeByIdWithHttpInfo (int? billingCodeTypeId)
        {
            
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling BillingCodeTypeApi->GetDuplicateBillingCodeTypeById");
            
    
            var localVarPath = "/beta/billingCodeType/duplicate/{billingCodeTypeId}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillingCodeType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeType)));
            
        }

        
        /// <summary>
        /// Get a duplicated a billingCodeType by id Returns a duplicated billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param>
        /// <returns>Task of BillingCodeType</returns>
        public async System.Threading.Tasks.Task<BillingCodeType> GetDuplicateBillingCodeTypeByIdAsync (int? billingCodeTypeId)
        {
             ApiResponse<BillingCodeType> localVarResponse = await GetDuplicateBillingCodeTypeByIdAsyncWithHttpInfo(billingCodeTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a billingCodeType by id Returns a duplicated billingCodeType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeTypeId">Id of the billingCodeType to be duplicated.</param>
        /// <returns>Task of ApiResponse (BillingCodeType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillingCodeType>> GetDuplicateBillingCodeTypeByIdAsyncWithHttpInfo (int? billingCodeTypeId)
        {
            // verify the required parameter 'billingCodeTypeId' is set
            if (billingCodeTypeId == null) throw new ApiException(400, "Missing required parameter 'billingCodeTypeId' when calling GetDuplicateBillingCodeTypeById");
            
    
            var localVarPath = "/beta/billingCodeType/duplicate/{billingCodeTypeId}";
    
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
            if (billingCodeTypeId != null) localVarPathParams.Add("billingCodeTypeId", Configuration.ApiClient.ParameterToString(billingCodeTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingCodeType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeType)));
            
        }
        
        /// <summary>
        /// Update a billingCodeType Updates an existing billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param> 
        /// <returns></returns>
        public void UpdateBillingCodeType (BillingCodeType body)
        {
             UpdateBillingCodeTypeWithHttpInfo(body);
        }

        /// <summary>
        /// Update a billingCodeType Updates an existing billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateBillingCodeTypeWithHttpInfo (BillingCodeType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillingCodeTypeApi->UpdateBillingCodeType");
            
    
            var localVarPath = "/beta/billingCodeType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a billingCodeType Updates an existing billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateBillingCodeTypeAsync (BillingCodeType body)
        {
             await UpdateBillingCodeTypeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a billingCodeType Updates an existing billingCodeType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillingCodeTypeAsyncWithHttpInfo (BillingCodeType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBillingCodeType");
            
    
            var localVarPath = "/beta/billingCodeType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a billingCodeType custom fields Updates an existing billingCodeType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param> 
        /// <returns></returns>
        public void UpdateBillingCodeTypeCustomFields (BillingCodeType body)
        {
             UpdateBillingCodeTypeCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a billingCodeType custom fields Updates an existing billingCodeType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateBillingCodeTypeCustomFieldsWithHttpInfo (BillingCodeType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillingCodeTypeApi->UpdateBillingCodeTypeCustomFields");
            
    
            var localVarPath = "/beta/billingCodeType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a billingCodeType custom fields Updates an existing billingCodeType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateBillingCodeTypeCustomFieldsAsync (BillingCodeType body)
        {
             await UpdateBillingCodeTypeCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a billingCodeType custom fields Updates an existing billingCodeType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillingCodeTypeCustomFieldsAsyncWithHttpInfo (BillingCodeType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBillingCodeTypeCustomFields");
            
    
            var localVarPath = "/beta/billingCodeType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
