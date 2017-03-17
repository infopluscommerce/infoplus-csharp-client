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
    public interface IExternalShippingSystemApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param>
        /// <returns>ExternalShippingSystem</returns>
        ExternalShippingSystem AddExternalShippingSystem (ExternalShippingSystem body);
  
        /// <summary>
        /// Create an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param>
        /// <returns>ApiResponse of ExternalShippingSystem</returns>
        ApiResponse<ExternalShippingSystem> AddExternalShippingSystemWithHttpInfo (ExternalShippingSystem body);
        
        /// <summary>
        /// Add new audit for an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param>
        /// <param name="externalShippingSystemAudit">The audit to add</param>
        /// <returns></returns>
        void AddExternalShippingSystemAudit (int? externalShippingSystemId, string externalShippingSystemAudit);
  
        /// <summary>
        /// Add new audit for an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param>
        /// <param name="externalShippingSystemAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddExternalShippingSystemAuditWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemAudit);
        
        /// <summary>
        /// Add new tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param>
        /// <param name="externalShippingSystemTag">The tag to add</param>
        /// <returns></returns>
        void AddExternalShippingSystemTag (int? externalShippingSystemId, string externalShippingSystemTag);
  
        /// <summary>
        /// Add new tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param>
        /// <param name="externalShippingSystemTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddExternalShippingSystemTagWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag);
        
        /// <summary>
        /// Delete an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Deletes the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param>
        /// <returns></returns>
        void DeleteExternalShippingSystem (int? externalShippingSystemId);
  
        /// <summary>
        /// Delete an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Deletes the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalShippingSystemWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Delete a tag for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShippingSystem tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param>
        /// <param name="externalShippingSystemTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteExternalShippingSystemTag (int? externalShippingSystemId, string externalShippingSystemTag);
  
        /// <summary>
        /// Delete a tag for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShippingSystem tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param>
        /// <param name="externalShippingSystemTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalShippingSystemTagWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag);
        
        /// <summary>
        /// Get a duplicated an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param>
        /// <returns>ExternalShippingSystem</returns>
        ExternalShippingSystem GetDuplicateExternalShippingSystemById (int? externalShippingSystemId);
  
        /// <summary>
        /// Get a duplicated an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param>
        /// <returns>ApiResponse of ExternalShippingSystem</returns>
        ApiResponse<ExternalShippingSystem> GetDuplicateExternalShippingSystemByIdWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Search externalShippingSystems by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShippingSystems that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ExternalShippingSystem&gt;</returns>
        List<ExternalShippingSystem> GetExternalShippingSystemByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search externalShippingSystems by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShippingSystems that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ExternalShippingSystem&gt;</returns>
        ApiResponse<List<ExternalShippingSystem>> GetExternalShippingSystemByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param>
        /// <returns>ExternalShippingSystem</returns>
        ExternalShippingSystem GetExternalShippingSystemById (int? externalShippingSystemId);
  
        /// <summary>
        /// Get an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param>
        /// <returns>ApiResponse of ExternalShippingSystem</returns>
        ApiResponse<ExternalShippingSystem> GetExternalShippingSystemByIdWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Get the tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShippingSystem tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param>
        /// <returns></returns>
        void GetExternalShippingSystemTags (int? externalShippingSystemId);
  
        /// <summary>
        /// Get the tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShippingSystem tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetExternalShippingSystemTagsWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Update an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns></returns>
        void UpdateExternalShippingSystem (ExternalShippingSystem body);
  
        /// <summary>
        /// Update an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateExternalShippingSystemWithHttpInfo (ExternalShippingSystem body);
        
        /// <summary>
        /// Update an externalShippingSystem custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns></returns>
        void UpdateExternalShippingSystemCustomFields (ExternalShippingSystem body);
  
        /// <summary>
        /// Update an externalShippingSystem custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateExternalShippingSystemCustomFieldsWithHttpInfo (ExternalShippingSystem body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param>
        /// <returns>Task of ExternalShippingSystem</returns>
        System.Threading.Tasks.Task<ExternalShippingSystem> AddExternalShippingSystemAsync (ExternalShippingSystem body);

        /// <summary>
        /// Create an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Inserts a new externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param>
        /// <returns>Task of ApiResponse (ExternalShippingSystem)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalShippingSystem>> AddExternalShippingSystemAsyncWithHttpInfo (ExternalShippingSystem body);
        
        /// <summary>
        /// Add new audit for an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param>
        /// <param name="externalShippingSystemAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddExternalShippingSystemAuditAsync (int? externalShippingSystemId, string externalShippingSystemAudit);

        /// <summary>
        /// Add new audit for an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param>
        /// <param name="externalShippingSystemAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShippingSystemAuditAsyncWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemAudit);
        
        /// <summary>
        /// Add new tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param>
        /// <param name="externalShippingSystemTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddExternalShippingSystemTagAsync (int? externalShippingSystemId, string externalShippingSystemTag);

        /// <summary>
        /// Add new tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing externalShippingSystem.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param>
        /// <param name="externalShippingSystemTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShippingSystemTagAsyncWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag);
        
        /// <summary>
        /// Delete an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Deletes the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalShippingSystemAsync (int? externalShippingSystemId);

        /// <summary>
        /// Delete an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Deletes the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShippingSystemAsyncWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Delete a tag for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShippingSystem tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param>
        /// <param name="externalShippingSystemTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalShippingSystemTagAsync (int? externalShippingSystemId, string externalShippingSystemTag);

        /// <summary>
        /// Delete a tag for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Deletes an existing externalShippingSystem tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param>
        /// <param name="externalShippingSystemTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShippingSystemTagAsyncWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag);
        
        /// <summary>
        /// Get a duplicated an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param>
        /// <returns>Task of ExternalShippingSystem</returns>
        System.Threading.Tasks.Task<ExternalShippingSystem> GetDuplicateExternalShippingSystemByIdAsync (int? externalShippingSystemId);

        /// <summary>
        /// Get a duplicated an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param>
        /// <returns>Task of ApiResponse (ExternalShippingSystem)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalShippingSystem>> GetDuplicateExternalShippingSystemByIdAsyncWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Search externalShippingSystems by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShippingSystems that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ExternalShippingSystem&gt;</returns>
        System.Threading.Tasks.Task<List<ExternalShippingSystem>> GetExternalShippingSystemByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search externalShippingSystems by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of externalShippingSystems that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ExternalShippingSystem&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ExternalShippingSystem>>> GetExternalShippingSystemByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param>
        /// <returns>Task of ExternalShippingSystem</returns>
        System.Threading.Tasks.Task<ExternalShippingSystem> GetExternalShippingSystemByIdAsync (int? externalShippingSystemId);

        /// <summary>
        /// Get an externalShippingSystem by id
        /// </summary>
        /// <remarks>
        /// Returns the externalShippingSystem identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param>
        /// <returns>Task of ApiResponse (ExternalShippingSystem)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalShippingSystem>> GetExternalShippingSystemByIdAsyncWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Get the tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShippingSystem tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetExternalShippingSystemTagsAsync (int? externalShippingSystemId);

        /// <summary>
        /// Get the tags for an externalShippingSystem.
        /// </summary>
        /// <remarks>
        /// Get all existing externalShippingSystem tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetExternalShippingSystemTagsAsyncWithHttpInfo (int? externalShippingSystemId);
        
        /// <summary>
        /// Update an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateExternalShippingSystemAsync (ExternalShippingSystem body);

        /// <summary>
        /// Update an externalShippingSystem
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShippingSystemAsyncWithHttpInfo (ExternalShippingSystem body);
        
        /// <summary>
        /// Update an externalShippingSystem custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateExternalShippingSystemCustomFieldsAsync (ExternalShippingSystem body);

        /// <summary>
        /// Update an externalShippingSystem custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing externalShippingSystem custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShippingSystemCustomFieldsAsyncWithHttpInfo (ExternalShippingSystem body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExternalShippingSystemApi : IExternalShippingSystemApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShippingSystemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExternalShippingSystemApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShippingSystemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExternalShippingSystemApi(Configuration configuration = null)
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
        /// Create an externalShippingSystem Inserts a new externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param> 
        /// <returns>ExternalShippingSystem</returns>
        public ExternalShippingSystem AddExternalShippingSystem (ExternalShippingSystem body)
        {
             ApiResponse<ExternalShippingSystem> localVarResponse = AddExternalShippingSystemWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an externalShippingSystem Inserts a new externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param> 
        /// <returns>ApiResponse of ExternalShippingSystem</returns>
        public ApiResponse< ExternalShippingSystem > AddExternalShippingSystemWithHttpInfo (ExternalShippingSystem body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalShippingSystemApi->AddExternalShippingSystem");
            
    
            var localVarPath = "/beta/externalShippingSystem";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExternalShippingSystem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShippingSystem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShippingSystem)));
            
        }

        
        /// <summary>
        /// Create an externalShippingSystem Inserts a new externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param>
        /// <returns>Task of ExternalShippingSystem</returns>
        public async System.Threading.Tasks.Task<ExternalShippingSystem> AddExternalShippingSystemAsync (ExternalShippingSystem body)
        {
             ApiResponse<ExternalShippingSystem> localVarResponse = await AddExternalShippingSystemAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an externalShippingSystem Inserts a new externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be inserted.</param>
        /// <returns>Task of ApiResponse (ExternalShippingSystem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalShippingSystem>> AddExternalShippingSystemAsyncWithHttpInfo (ExternalShippingSystem body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddExternalShippingSystem");
            
    
            var localVarPath = "/beta/externalShippingSystem";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalShippingSystem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShippingSystem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShippingSystem)));
            
        }
        
        /// <summary>
        /// Add new audit for an externalShippingSystem Adds an audit to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param> 
        /// <param name="externalShippingSystemAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddExternalShippingSystemAudit (int? externalShippingSystemId, string externalShippingSystemAudit)
        {
             AddExternalShippingSystemAuditWithHttpInfo(externalShippingSystemId, externalShippingSystemAudit);
        }

        /// <summary>
        /// Add new audit for an externalShippingSystem Adds an audit to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param> 
        /// <param name="externalShippingSystemAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddExternalShippingSystemAuditWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemAudit)
        {
            
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling ExternalShippingSystemApi->AddExternalShippingSystemAudit");
            
            // verify the required parameter 'externalShippingSystemAudit' is set
            if (externalShippingSystemAudit == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemAudit' when calling ExternalShippingSystemApi->AddExternalShippingSystemAudit");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/audit/{externalShippingSystemAudit}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            if (externalShippingSystemAudit != null) localVarPathParams.Add("externalShippingSystemAudit", Configuration.ApiClient.ParameterToString(externalShippingSystemAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an externalShippingSystem Adds an audit to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param>
        /// <param name="externalShippingSystemAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddExternalShippingSystemAuditAsync (int? externalShippingSystemId, string externalShippingSystemAudit)
        {
             await AddExternalShippingSystemAuditAsyncWithHttpInfo(externalShippingSystemId, externalShippingSystemAudit);

        }

        /// <summary>
        /// Add new audit for an externalShippingSystem Adds an audit to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add an audit to</param>
        /// <param name="externalShippingSystemAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShippingSystemAuditAsyncWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemAudit)
        {
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling AddExternalShippingSystemAudit");
            // verify the required parameter 'externalShippingSystemAudit' is set
            if (externalShippingSystemAudit == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemAudit' when calling AddExternalShippingSystemAudit");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/audit/{externalShippingSystemAudit}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            if (externalShippingSystemAudit != null) localVarPathParams.Add("externalShippingSystemAudit", Configuration.ApiClient.ParameterToString(externalShippingSystemAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an externalShippingSystem. Adds a tag to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param> 
        /// <param name="externalShippingSystemTag">The tag to add</param> 
        /// <returns></returns>
        public void AddExternalShippingSystemTag (int? externalShippingSystemId, string externalShippingSystemTag)
        {
             AddExternalShippingSystemTagWithHttpInfo(externalShippingSystemId, externalShippingSystemTag);
        }

        /// <summary>
        /// Add new tags for an externalShippingSystem. Adds a tag to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param> 
        /// <param name="externalShippingSystemTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddExternalShippingSystemTagWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag)
        {
            
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling ExternalShippingSystemApi->AddExternalShippingSystemTag");
            
            // verify the required parameter 'externalShippingSystemTag' is set
            if (externalShippingSystemTag == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemTag' when calling ExternalShippingSystemApi->AddExternalShippingSystemTag");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/tag/{externalShippingSystemTag}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            if (externalShippingSystemTag != null) localVarPathParams.Add("externalShippingSystemTag", Configuration.ApiClient.ParameterToString(externalShippingSystemTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an externalShippingSystem. Adds a tag to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param>
        /// <param name="externalShippingSystemTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddExternalShippingSystemTagAsync (int? externalShippingSystemId, string externalShippingSystemTag)
        {
             await AddExternalShippingSystemTagAsyncWithHttpInfo(externalShippingSystemId, externalShippingSystemTag);

        }

        /// <summary>
        /// Add new tags for an externalShippingSystem. Adds a tag to an existing externalShippingSystem.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to add a tag to</param>
        /// <param name="externalShippingSystemTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddExternalShippingSystemTagAsyncWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag)
        {
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling AddExternalShippingSystemTag");
            // verify the required parameter 'externalShippingSystemTag' is set
            if (externalShippingSystemTag == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemTag' when calling AddExternalShippingSystemTag");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/tag/{externalShippingSystemTag}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            if (externalShippingSystemTag != null) localVarPathParams.Add("externalShippingSystemTag", Configuration.ApiClient.ParameterToString(externalShippingSystemTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddExternalShippingSystemTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an externalShippingSystem Deletes the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param> 
        /// <returns></returns>
        public void DeleteExternalShippingSystem (int? externalShippingSystemId)
        {
             DeleteExternalShippingSystemWithHttpInfo(externalShippingSystemId);
        }

        /// <summary>
        /// Delete an externalShippingSystem Deletes the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalShippingSystemWithHttpInfo (int? externalShippingSystemId)
        {
            
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling ExternalShippingSystemApi->DeleteExternalShippingSystem");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an externalShippingSystem Deletes the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalShippingSystemAsync (int? externalShippingSystemId)
        {
             await DeleteExternalShippingSystemAsyncWithHttpInfo(externalShippingSystemId);

        }

        /// <summary>
        /// Delete an externalShippingSystem Deletes the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShippingSystemAsyncWithHttpInfo (int? externalShippingSystemId)
        {
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling DeleteExternalShippingSystem");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an externalShippingSystem. Deletes an existing externalShippingSystem tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param> 
        /// <param name="externalShippingSystemTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteExternalShippingSystemTag (int? externalShippingSystemId, string externalShippingSystemTag)
        {
             DeleteExternalShippingSystemTagWithHttpInfo(externalShippingSystemId, externalShippingSystemTag);
        }

        /// <summary>
        /// Delete a tag for an externalShippingSystem. Deletes an existing externalShippingSystem tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param> 
        /// <param name="externalShippingSystemTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalShippingSystemTagWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag)
        {
            
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling ExternalShippingSystemApi->DeleteExternalShippingSystemTag");
            
            // verify the required parameter 'externalShippingSystemTag' is set
            if (externalShippingSystemTag == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemTag' when calling ExternalShippingSystemApi->DeleteExternalShippingSystemTag");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/tag/{externalShippingSystemTag}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            if (externalShippingSystemTag != null) localVarPathParams.Add("externalShippingSystemTag", Configuration.ApiClient.ParameterToString(externalShippingSystemTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystemTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystemTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an externalShippingSystem. Deletes an existing externalShippingSystem tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param>
        /// <param name="externalShippingSystemTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalShippingSystemTagAsync (int? externalShippingSystemId, string externalShippingSystemTag)
        {
             await DeleteExternalShippingSystemTagAsyncWithHttpInfo(externalShippingSystemId, externalShippingSystemTag);

        }

        /// <summary>
        /// Delete a tag for an externalShippingSystem. Deletes an existing externalShippingSystem tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to remove tag from</param>
        /// <param name="externalShippingSystemTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalShippingSystemTagAsyncWithHttpInfo (int? externalShippingSystemId, string externalShippingSystemTag)
        {
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling DeleteExternalShippingSystemTag");
            // verify the required parameter 'externalShippingSystemTag' is set
            if (externalShippingSystemTag == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemTag' when calling DeleteExternalShippingSystemTag");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/tag/{externalShippingSystemTag}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            if (externalShippingSystemTag != null) localVarPathParams.Add("externalShippingSystemTag", Configuration.ApiClient.ParameterToString(externalShippingSystemTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystemTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExternalShippingSystemTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an externalShippingSystem by id Returns a duplicated externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param> 
        /// <returns>ExternalShippingSystem</returns>
        public ExternalShippingSystem GetDuplicateExternalShippingSystemById (int? externalShippingSystemId)
        {
             ApiResponse<ExternalShippingSystem> localVarResponse = GetDuplicateExternalShippingSystemByIdWithHttpInfo(externalShippingSystemId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an externalShippingSystem by id Returns a duplicated externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param> 
        /// <returns>ApiResponse of ExternalShippingSystem</returns>
        public ApiResponse< ExternalShippingSystem > GetDuplicateExternalShippingSystemByIdWithHttpInfo (int? externalShippingSystemId)
        {
            
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling ExternalShippingSystemApi->GetDuplicateExternalShippingSystemById");
            
    
            var localVarPath = "/beta/externalShippingSystem/duplicate/{externalShippingSystemId}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShippingSystemById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShippingSystemById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExternalShippingSystem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShippingSystem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShippingSystem)));
            
        }

        
        /// <summary>
        /// Get a duplicated an externalShippingSystem by id Returns a duplicated externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param>
        /// <returns>Task of ExternalShippingSystem</returns>
        public async System.Threading.Tasks.Task<ExternalShippingSystem> GetDuplicateExternalShippingSystemByIdAsync (int? externalShippingSystemId)
        {
             ApiResponse<ExternalShippingSystem> localVarResponse = await GetDuplicateExternalShippingSystemByIdAsyncWithHttpInfo(externalShippingSystemId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an externalShippingSystem by id Returns a duplicated externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be duplicated.</param>
        /// <returns>Task of ApiResponse (ExternalShippingSystem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalShippingSystem>> GetDuplicateExternalShippingSystemByIdAsyncWithHttpInfo (int? externalShippingSystemId)
        {
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling GetDuplicateExternalShippingSystemById");
            
    
            var localVarPath = "/beta/externalShippingSystem/duplicate/{externalShippingSystemId}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShippingSystemById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateExternalShippingSystemById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalShippingSystem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShippingSystem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShippingSystem)));
            
        }
        
        /// <summary>
        /// Search externalShippingSystems by filter Returns the list of externalShippingSystems that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ExternalShippingSystem&gt;</returns>
        public List<ExternalShippingSystem> GetExternalShippingSystemByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ExternalShippingSystem>> localVarResponse = GetExternalShippingSystemByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search externalShippingSystems by filter Returns the list of externalShippingSystems that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ExternalShippingSystem&gt;</returns>
        public ApiResponse< List<ExternalShippingSystem> > GetExternalShippingSystemByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/externalShippingSystem/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ExternalShippingSystem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ExternalShippingSystem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExternalShippingSystem>)));
            
        }

        
        /// <summary>
        /// Search externalShippingSystems by filter Returns the list of externalShippingSystems that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ExternalShippingSystem&gt;</returns>
        public async System.Threading.Tasks.Task<List<ExternalShippingSystem>> GetExternalShippingSystemByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ExternalShippingSystem>> localVarResponse = await GetExternalShippingSystemByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search externalShippingSystems by filter Returns the list of externalShippingSystems that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ExternalShippingSystem&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ExternalShippingSystem>>> GetExternalShippingSystemByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/externalShippingSystem/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ExternalShippingSystem>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ExternalShippingSystem>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ExternalShippingSystem>)));
            
        }
        
        /// <summary>
        /// Get an externalShippingSystem by id Returns the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param> 
        /// <returns>ExternalShippingSystem</returns>
        public ExternalShippingSystem GetExternalShippingSystemById (int? externalShippingSystemId)
        {
             ApiResponse<ExternalShippingSystem> localVarResponse = GetExternalShippingSystemByIdWithHttpInfo(externalShippingSystemId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an externalShippingSystem by id Returns the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param> 
        /// <returns>ApiResponse of ExternalShippingSystem</returns>
        public ApiResponse< ExternalShippingSystem > GetExternalShippingSystemByIdWithHttpInfo (int? externalShippingSystemId)
        {
            
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling ExternalShippingSystemApi->GetExternalShippingSystemById");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExternalShippingSystem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShippingSystem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShippingSystem)));
            
        }

        
        /// <summary>
        /// Get an externalShippingSystem by id Returns the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param>
        /// <returns>Task of ExternalShippingSystem</returns>
        public async System.Threading.Tasks.Task<ExternalShippingSystem> GetExternalShippingSystemByIdAsync (int? externalShippingSystemId)
        {
             ApiResponse<ExternalShippingSystem> localVarResponse = await GetExternalShippingSystemByIdAsyncWithHttpInfo(externalShippingSystemId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an externalShippingSystem by id Returns the externalShippingSystem identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to be returned.</param>
        /// <returns>Task of ApiResponse (ExternalShippingSystem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalShippingSystem>> GetExternalShippingSystemByIdAsyncWithHttpInfo (int? externalShippingSystemId)
        {
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling GetExternalShippingSystemById");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExternalShippingSystem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalShippingSystem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExternalShippingSystem)));
            
        }
        
        /// <summary>
        /// Get the tags for an externalShippingSystem. Get all existing externalShippingSystem tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param> 
        /// <returns></returns>
        public void GetExternalShippingSystemTags (int? externalShippingSystemId)
        {
             GetExternalShippingSystemTagsWithHttpInfo(externalShippingSystemId);
        }

        /// <summary>
        /// Get the tags for an externalShippingSystem. Get all existing externalShippingSystem tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetExternalShippingSystemTagsWithHttpInfo (int? externalShippingSystemId)
        {
            
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null)
                throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling ExternalShippingSystemApi->GetExternalShippingSystemTags");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/tag";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an externalShippingSystem. Get all existing externalShippingSystem tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetExternalShippingSystemTagsAsync (int? externalShippingSystemId)
        {
             await GetExternalShippingSystemTagsAsyncWithHttpInfo(externalShippingSystemId);

        }

        /// <summary>
        /// Get the tags for an externalShippingSystem. Get all existing externalShippingSystem tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShippingSystemId">Id of the externalShippingSystem to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetExternalShippingSystemTagsAsyncWithHttpInfo (int? externalShippingSystemId)
        {
            // verify the required parameter 'externalShippingSystemId' is set
            if (externalShippingSystemId == null) throw new ApiException(400, "Missing required parameter 'externalShippingSystemId' when calling GetExternalShippingSystemTags");
            
    
            var localVarPath = "/beta/externalShippingSystem/{externalShippingSystemId}/tag";
    
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
            if (externalShippingSystemId != null) localVarPathParams.Add("externalShippingSystemId", Configuration.ApiClient.ParameterToString(externalShippingSystemId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExternalShippingSystemTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an externalShippingSystem Updates an existing externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param> 
        /// <returns></returns>
        public void UpdateExternalShippingSystem (ExternalShippingSystem body)
        {
             UpdateExternalShippingSystemWithHttpInfo(body);
        }

        /// <summary>
        /// Update an externalShippingSystem Updates an existing externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateExternalShippingSystemWithHttpInfo (ExternalShippingSystem body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalShippingSystemApi->UpdateExternalShippingSystem");
            
    
            var localVarPath = "/beta/externalShippingSystem";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an externalShippingSystem Updates an existing externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateExternalShippingSystemAsync (ExternalShippingSystem body)
        {
             await UpdateExternalShippingSystemAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an externalShippingSystem Updates an existing externalShippingSystem using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShippingSystemAsyncWithHttpInfo (ExternalShippingSystem body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateExternalShippingSystem");
            
    
            var localVarPath = "/beta/externalShippingSystem";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an externalShippingSystem custom fields Updates an existing externalShippingSystem custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param> 
        /// <returns></returns>
        public void UpdateExternalShippingSystemCustomFields (ExternalShippingSystem body)
        {
             UpdateExternalShippingSystemCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an externalShippingSystem custom fields Updates an existing externalShippingSystem custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateExternalShippingSystemCustomFieldsWithHttpInfo (ExternalShippingSystem body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ExternalShippingSystemApi->UpdateExternalShippingSystemCustomFields");
            
    
            var localVarPath = "/beta/externalShippingSystem/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystemCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystemCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an externalShippingSystem custom fields Updates an existing externalShippingSystem custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateExternalShippingSystemCustomFieldsAsync (ExternalShippingSystem body)
        {
             await UpdateExternalShippingSystemCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an externalShippingSystem custom fields Updates an existing externalShippingSystem custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExternalShippingSystem to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateExternalShippingSystemCustomFieldsAsyncWithHttpInfo (ExternalShippingSystem body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateExternalShippingSystemCustomFields");
            
    
            var localVarPath = "/beta/externalShippingSystem/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystemCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateExternalShippingSystemCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
