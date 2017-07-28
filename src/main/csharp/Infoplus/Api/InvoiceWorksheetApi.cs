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
    public interface IInvoiceWorksheetApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param>
        /// <returns>InvoiceWorksheet</returns>
        InvoiceWorksheet AddInvoiceWorksheet (InvoiceWorksheet body);
  
        /// <summary>
        /// Create an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param>
        /// <returns>ApiResponse of InvoiceWorksheet</returns>
        ApiResponse<InvoiceWorksheet> AddInvoiceWorksheetWithHttpInfo (InvoiceWorksheet body);
        
        /// <summary>
        /// Add new audit for an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param>
        /// <param name="invoiceWorksheetAudit">The audit to add</param>
        /// <returns></returns>
        void AddInvoiceWorksheetAudit (int? invoiceWorksheetId, string invoiceWorksheetAudit);
  
        /// <summary>
        /// Add new audit for an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param>
        /// <param name="invoiceWorksheetAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInvoiceWorksheetAuditWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetAudit);
        
        /// <summary>
        /// Add new tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param>
        /// <param name="invoiceWorksheetTag">The tag to add</param>
        /// <returns></returns>
        void AddInvoiceWorksheetTag (int? invoiceWorksheetId, string invoiceWorksheetTag);
  
        /// <summary>
        /// Add new tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param>
        /// <param name="invoiceWorksheetTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInvoiceWorksheetTagWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag);
        
        /// <summary>
        /// Delete an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param>
        /// <returns></returns>
        void DeleteInvoiceWorksheet (int? invoiceWorksheetId);
  
        /// <summary>
        /// Delete an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInvoiceWorksheetWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Delete a tag for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param>
        /// <param name="invoiceWorksheetTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteInvoiceWorksheetTag (int? invoiceWorksheetId, string invoiceWorksheetTag);
  
        /// <summary>
        /// Delete a tag for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param>
        /// <param name="invoiceWorksheetTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInvoiceWorksheetTagWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag);
        
        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param>
        /// <returns>InvoiceWorksheet</returns>
        InvoiceWorksheet GetDuplicateInvoiceWorksheetById (int? invoiceWorksheetId);
  
        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param>
        /// <returns>ApiResponse of InvoiceWorksheet</returns>
        ApiResponse<InvoiceWorksheet> GetDuplicateInvoiceWorksheetByIdWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Search invoiceWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;InvoiceWorksheet&gt;</returns>
        List<InvoiceWorksheet> GetInvoiceWorksheetByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search invoiceWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;InvoiceWorksheet&gt;</returns>
        ApiResponse<List<InvoiceWorksheet>> GetInvoiceWorksheetByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param>
        /// <returns>InvoiceWorksheet</returns>
        InvoiceWorksheet GetInvoiceWorksheetById (int? invoiceWorksheetId);
  
        /// <summary>
        /// Get an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param>
        /// <returns>ApiResponse of InvoiceWorksheet</returns>
        ApiResponse<InvoiceWorksheet> GetInvoiceWorksheetByIdWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Get the tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param>
        /// <returns></returns>
        void GetInvoiceWorksheetTags (int? invoiceWorksheetId);
  
        /// <summary>
        /// Get the tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetInvoiceWorksheetTagsWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Update an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param>
        /// <returns></returns>
        void UpdateInvoiceWorksheet (InvoiceWorksheet body);
  
        /// <summary>
        /// Update an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateInvoiceWorksheetWithHttpInfo (InvoiceWorksheet body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param>
        /// <returns>Task of InvoiceWorksheet</returns>
        System.Threading.Tasks.Task<InvoiceWorksheet> AddInvoiceWorksheetAsync (InvoiceWorksheet body);

        /// <summary>
        /// Create an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheet)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheet>> AddInvoiceWorksheetAsyncWithHttpInfo (InvoiceWorksheet body);
        
        /// <summary>
        /// Add new audit for an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param>
        /// <param name="invoiceWorksheetAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInvoiceWorksheetAuditAsync (int? invoiceWorksheetId, string invoiceWorksheetAudit);

        /// <summary>
        /// Add new audit for an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param>
        /// <param name="invoiceWorksheetAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetAuditAsyncWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetAudit);
        
        /// <summary>
        /// Add new tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param>
        /// <param name="invoiceWorksheetTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInvoiceWorksheetTagAsync (int? invoiceWorksheetId, string invoiceWorksheetTag);

        /// <summary>
        /// Add new tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param>
        /// <param name="invoiceWorksheetTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetTagAsyncWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag);
        
        /// <summary>
        /// Delete an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInvoiceWorksheetAsync (int? invoiceWorksheetId);

        /// <summary>
        /// Delete an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetAsyncWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Delete a tag for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param>
        /// <param name="invoiceWorksheetTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInvoiceWorksheetTagAsync (int? invoiceWorksheetId, string invoiceWorksheetTag);

        /// <summary>
        /// Delete a tag for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param>
        /// <param name="invoiceWorksheetTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetTagAsyncWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag);
        
        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param>
        /// <returns>Task of InvoiceWorksheet</returns>
        System.Threading.Tasks.Task<InvoiceWorksheet> GetDuplicateInvoiceWorksheetByIdAsync (int? invoiceWorksheetId);

        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheet)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheet>> GetDuplicateInvoiceWorksheetByIdAsyncWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Search invoiceWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InvoiceWorksheet&gt;</returns>
        System.Threading.Tasks.Task<List<InvoiceWorksheet>> GetInvoiceWorksheetByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search invoiceWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InvoiceWorksheet&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InvoiceWorksheet>>> GetInvoiceWorksheetByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param>
        /// <returns>Task of InvoiceWorksheet</returns>
        System.Threading.Tasks.Task<InvoiceWorksheet> GetInvoiceWorksheetByIdAsync (int? invoiceWorksheetId);

        /// <summary>
        /// Get an invoiceWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheet)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheet>> GetInvoiceWorksheetByIdAsyncWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Get the tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetInvoiceWorksheetTagsAsync (int? invoiceWorksheetId);

        /// <summary>
        /// Get the tags for an invoiceWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetInvoiceWorksheetTagsAsyncWithHttpInfo (int? invoiceWorksheetId);
        
        /// <summary>
        /// Update an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateInvoiceWorksheetAsync (InvoiceWorksheet body);

        /// <summary>
        /// Update an invoiceWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInvoiceWorksheetAsyncWithHttpInfo (InvoiceWorksheet body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoiceWorksheetApi : IInvoiceWorksheetApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceWorksheetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceWorksheetApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceWorksheetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceWorksheetApi(Configuration configuration = null)
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
        /// Create an invoiceWorksheet Inserts a new invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param> 
        /// <returns>InvoiceWorksheet</returns>
        public InvoiceWorksheet AddInvoiceWorksheet (InvoiceWorksheet body)
        {
             ApiResponse<InvoiceWorksheet> localVarResponse = AddInvoiceWorksheetWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an invoiceWorksheet Inserts a new invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param> 
        /// <returns>ApiResponse of InvoiceWorksheet</returns>
        public ApiResponse< InvoiceWorksheet > AddInvoiceWorksheetWithHttpInfo (InvoiceWorksheet body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceWorksheetApi->AddInvoiceWorksheet");
            
    
            var localVarPath = "/beta/invoiceWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InvoiceWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheet)));
            
        }

        
        /// <summary>
        /// Create an invoiceWorksheet Inserts a new invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param>
        /// <returns>Task of InvoiceWorksheet</returns>
        public async System.Threading.Tasks.Task<InvoiceWorksheet> AddInvoiceWorksheetAsync (InvoiceWorksheet body)
        {
             ApiResponse<InvoiceWorksheet> localVarResponse = await AddInvoiceWorksheetAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an invoiceWorksheet Inserts a new invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be inserted.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheet>> AddInvoiceWorksheetAsyncWithHttpInfo (InvoiceWorksheet body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddInvoiceWorksheet");
            
    
            var localVarPath = "/beta/invoiceWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InvoiceWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheet)));
            
        }
        
        /// <summary>
        /// Add new audit for an invoiceWorksheet Adds an audit to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param> 
        /// <param name="invoiceWorksheetAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddInvoiceWorksheetAudit (int? invoiceWorksheetId, string invoiceWorksheetAudit)
        {
             AddInvoiceWorksheetAuditWithHttpInfo(invoiceWorksheetId, invoiceWorksheetAudit);
        }

        /// <summary>
        /// Add new audit for an invoiceWorksheet Adds an audit to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param> 
        /// <param name="invoiceWorksheetAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInvoiceWorksheetAuditWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetAudit)
        {
            
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling InvoiceWorksheetApi->AddInvoiceWorksheetAudit");
            
            // verify the required parameter 'invoiceWorksheetAudit' is set
            if (invoiceWorksheetAudit == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetAudit' when calling InvoiceWorksheetApi->AddInvoiceWorksheetAudit");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/audit/{invoiceWorksheetAudit}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            if (invoiceWorksheetAudit != null) localVarPathParams.Add("invoiceWorksheetAudit", Configuration.ApiClient.ParameterToString(invoiceWorksheetAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an invoiceWorksheet Adds an audit to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param>
        /// <param name="invoiceWorksheetAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInvoiceWorksheetAuditAsync (int? invoiceWorksheetId, string invoiceWorksheetAudit)
        {
             await AddInvoiceWorksheetAuditAsyncWithHttpInfo(invoiceWorksheetId, invoiceWorksheetAudit);

        }

        /// <summary>
        /// Add new audit for an invoiceWorksheet Adds an audit to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add an audit to</param>
        /// <param name="invoiceWorksheetAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetAuditAsyncWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetAudit)
        {
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling AddInvoiceWorksheetAudit");
            // verify the required parameter 'invoiceWorksheetAudit' is set
            if (invoiceWorksheetAudit == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetAudit' when calling AddInvoiceWorksheetAudit");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/audit/{invoiceWorksheetAudit}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            if (invoiceWorksheetAudit != null) localVarPathParams.Add("invoiceWorksheetAudit", Configuration.ApiClient.ParameterToString(invoiceWorksheetAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an invoiceWorksheet. Adds a tag to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param> 
        /// <param name="invoiceWorksheetTag">The tag to add</param> 
        /// <returns></returns>
        public void AddInvoiceWorksheetTag (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
             AddInvoiceWorksheetTagWithHttpInfo(invoiceWorksheetId, invoiceWorksheetTag);
        }

        /// <summary>
        /// Add new tags for an invoiceWorksheet. Adds a tag to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param> 
        /// <param name="invoiceWorksheetTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInvoiceWorksheetTagWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
            
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling InvoiceWorksheetApi->AddInvoiceWorksheetTag");
            
            // verify the required parameter 'invoiceWorksheetTag' is set
            if (invoiceWorksheetTag == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetTag' when calling InvoiceWorksheetApi->AddInvoiceWorksheetTag");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/tag/{invoiceWorksheetTag}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            if (invoiceWorksheetTag != null) localVarPathParams.Add("invoiceWorksheetTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an invoiceWorksheet. Adds a tag to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param>
        /// <param name="invoiceWorksheetTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInvoiceWorksheetTagAsync (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
             await AddInvoiceWorksheetTagAsyncWithHttpInfo(invoiceWorksheetId, invoiceWorksheetTag);

        }

        /// <summary>
        /// Add new tags for an invoiceWorksheet. Adds a tag to an existing invoiceWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to add a tag to</param>
        /// <param name="invoiceWorksheetTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetTagAsyncWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling AddInvoiceWorksheetTag");
            // verify the required parameter 'invoiceWorksheetTag' is set
            if (invoiceWorksheetTag == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetTag' when calling AddInvoiceWorksheetTag");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/tag/{invoiceWorksheetTag}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            if (invoiceWorksheetTag != null) localVarPathParams.Add("invoiceWorksheetTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an invoiceWorksheet Deletes the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param> 
        /// <returns></returns>
        public void DeleteInvoiceWorksheet (int? invoiceWorksheetId)
        {
             DeleteInvoiceWorksheetWithHttpInfo(invoiceWorksheetId);
        }

        /// <summary>
        /// Delete an invoiceWorksheet Deletes the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInvoiceWorksheetWithHttpInfo (int? invoiceWorksheetId)
        {
            
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling InvoiceWorksheetApi->DeleteInvoiceWorksheet");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an invoiceWorksheet Deletes the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInvoiceWorksheetAsync (int? invoiceWorksheetId)
        {
             await DeleteInvoiceWorksheetAsyncWithHttpInfo(invoiceWorksheetId);

        }

        /// <summary>
        /// Delete an invoiceWorksheet Deletes the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetAsyncWithHttpInfo (int? invoiceWorksheetId)
        {
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling DeleteInvoiceWorksheet");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an invoiceWorksheet. Deletes an existing invoiceWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param> 
        /// <param name="invoiceWorksheetTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteInvoiceWorksheetTag (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
             DeleteInvoiceWorksheetTagWithHttpInfo(invoiceWorksheetId, invoiceWorksheetTag);
        }

        /// <summary>
        /// Delete a tag for an invoiceWorksheet. Deletes an existing invoiceWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param> 
        /// <param name="invoiceWorksheetTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInvoiceWorksheetTagWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
            
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling InvoiceWorksheetApi->DeleteInvoiceWorksheetTag");
            
            // verify the required parameter 'invoiceWorksheetTag' is set
            if (invoiceWorksheetTag == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetTag' when calling InvoiceWorksheetApi->DeleteInvoiceWorksheetTag");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/tag/{invoiceWorksheetTag}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            if (invoiceWorksheetTag != null) localVarPathParams.Add("invoiceWorksheetTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an invoiceWorksheet. Deletes an existing invoiceWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param>
        /// <param name="invoiceWorksheetTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInvoiceWorksheetTagAsync (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
             await DeleteInvoiceWorksheetTagAsyncWithHttpInfo(invoiceWorksheetId, invoiceWorksheetTag);

        }

        /// <summary>
        /// Delete a tag for an invoiceWorksheet. Deletes an existing invoiceWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to remove tag from</param>
        /// <param name="invoiceWorksheetTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetTagAsyncWithHttpInfo (int? invoiceWorksheetId, string invoiceWorksheetTag)
        {
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling DeleteInvoiceWorksheetTag");
            // verify the required parameter 'invoiceWorksheetTag' is set
            if (invoiceWorksheetTag == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetTag' when calling DeleteInvoiceWorksheetTag");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/tag/{invoiceWorksheetTag}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            if (invoiceWorksheetTag != null) localVarPathParams.Add("invoiceWorksheetTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param> 
        /// <returns>InvoiceWorksheet</returns>
        public InvoiceWorksheet GetDuplicateInvoiceWorksheetById (int? invoiceWorksheetId)
        {
             ApiResponse<InvoiceWorksheet> localVarResponse = GetDuplicateInvoiceWorksheetByIdWithHttpInfo(invoiceWorksheetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param> 
        /// <returns>ApiResponse of InvoiceWorksheet</returns>
        public ApiResponse< InvoiceWorksheet > GetDuplicateInvoiceWorksheetByIdWithHttpInfo (int? invoiceWorksheetId)
        {
            
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling InvoiceWorksheetApi->GetDuplicateInvoiceWorksheetById");
            
    
            var localVarPath = "/beta/invoiceWorksheet/duplicate/{invoiceWorksheetId}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InvoiceWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheet)));
            
        }

        
        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param>
        /// <returns>Task of InvoiceWorksheet</returns>
        public async System.Threading.Tasks.Task<InvoiceWorksheet> GetDuplicateInvoiceWorksheetByIdAsync (int? invoiceWorksheetId)
        {
             ApiResponse<InvoiceWorksheet> localVarResponse = await GetDuplicateInvoiceWorksheetByIdAsyncWithHttpInfo(invoiceWorksheetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an invoiceWorksheet by id Returns a duplicated invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be duplicated.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheet>> GetDuplicateInvoiceWorksheetByIdAsyncWithHttpInfo (int? invoiceWorksheetId)
        {
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling GetDuplicateInvoiceWorksheetById");
            
    
            var localVarPath = "/beta/invoiceWorksheet/duplicate/{invoiceWorksheetId}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InvoiceWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheet)));
            
        }
        
        /// <summary>
        /// Search invoiceWorksheets by filter Returns the list of invoiceWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;InvoiceWorksheet&gt;</returns>
        public List<InvoiceWorksheet> GetInvoiceWorksheetByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InvoiceWorksheet>> localVarResponse = GetInvoiceWorksheetByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search invoiceWorksheets by filter Returns the list of invoiceWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;InvoiceWorksheet&gt;</returns>
        public ApiResponse< List<InvoiceWorksheet> > GetInvoiceWorksheetByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/invoiceWorksheet/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InvoiceWorksheet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InvoiceWorksheet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InvoiceWorksheet>)));
            
        }

        
        /// <summary>
        /// Search invoiceWorksheets by filter Returns the list of invoiceWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InvoiceWorksheet&gt;</returns>
        public async System.Threading.Tasks.Task<List<InvoiceWorksheet>> GetInvoiceWorksheetByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InvoiceWorksheet>> localVarResponse = await GetInvoiceWorksheetByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search invoiceWorksheets by filter Returns the list of invoiceWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InvoiceWorksheet&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InvoiceWorksheet>>> GetInvoiceWorksheetByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/invoiceWorksheet/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InvoiceWorksheet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InvoiceWorksheet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InvoiceWorksheet>)));
            
        }
        
        /// <summary>
        /// Get an invoiceWorksheet by id Returns the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param> 
        /// <returns>InvoiceWorksheet</returns>
        public InvoiceWorksheet GetInvoiceWorksheetById (int? invoiceWorksheetId)
        {
             ApiResponse<InvoiceWorksheet> localVarResponse = GetInvoiceWorksheetByIdWithHttpInfo(invoiceWorksheetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an invoiceWorksheet by id Returns the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param> 
        /// <returns>ApiResponse of InvoiceWorksheet</returns>
        public ApiResponse< InvoiceWorksheet > GetInvoiceWorksheetByIdWithHttpInfo (int? invoiceWorksheetId)
        {
            
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling InvoiceWorksheetApi->GetInvoiceWorksheetById");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InvoiceWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheet)));
            
        }

        
        /// <summary>
        /// Get an invoiceWorksheet by id Returns the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param>
        /// <returns>Task of InvoiceWorksheet</returns>
        public async System.Threading.Tasks.Task<InvoiceWorksheet> GetInvoiceWorksheetByIdAsync (int? invoiceWorksheetId)
        {
             ApiResponse<InvoiceWorksheet> localVarResponse = await GetInvoiceWorksheetByIdAsyncWithHttpInfo(invoiceWorksheetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an invoiceWorksheet by id Returns the invoiceWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to be returned.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheet>> GetInvoiceWorksheetByIdAsyncWithHttpInfo (int? invoiceWorksheetId)
        {
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling GetInvoiceWorksheetById");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InvoiceWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheet)));
            
        }
        
        /// <summary>
        /// Get the tags for an invoiceWorksheet. Get all existing invoiceWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param> 
        /// <returns></returns>
        public void GetInvoiceWorksheetTags (int? invoiceWorksheetId)
        {
             GetInvoiceWorksheetTagsWithHttpInfo(invoiceWorksheetId);
        }

        /// <summary>
        /// Get the tags for an invoiceWorksheet. Get all existing invoiceWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetInvoiceWorksheetTagsWithHttpInfo (int? invoiceWorksheetId)
        {
            
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling InvoiceWorksheetApi->GetInvoiceWorksheetTags");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/tag";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an invoiceWorksheet. Get all existing invoiceWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetInvoiceWorksheetTagsAsync (int? invoiceWorksheetId)
        {
             await GetInvoiceWorksheetTagsAsyncWithHttpInfo(invoiceWorksheetId);

        }

        /// <summary>
        /// Get the tags for an invoiceWorksheet. Get all existing invoiceWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetId">Id of the invoiceWorksheet to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetInvoiceWorksheetTagsAsyncWithHttpInfo (int? invoiceWorksheetId)
        {
            // verify the required parameter 'invoiceWorksheetId' is set
            if (invoiceWorksheetId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetId' when calling GetInvoiceWorksheetTags");
            
    
            var localVarPath = "/beta/invoiceWorksheet/{invoiceWorksheetId}/tag";
    
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
            if (invoiceWorksheetId != null) localVarPathParams.Add("invoiceWorksheetId", Configuration.ApiClient.ParameterToString(invoiceWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an invoiceWorksheet Updates an existing invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param> 
        /// <returns></returns>
        public void UpdateInvoiceWorksheet (InvoiceWorksheet body)
        {
             UpdateInvoiceWorksheetWithHttpInfo(body);
        }

        /// <summary>
        /// Update an invoiceWorksheet Updates an existing invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateInvoiceWorksheetWithHttpInfo (InvoiceWorksheet body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceWorksheetApi->UpdateInvoiceWorksheet");
            
    
            var localVarPath = "/beta/invoiceWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an invoiceWorksheet Updates an existing invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateInvoiceWorksheetAsync (InvoiceWorksheet body)
        {
             await UpdateInvoiceWorksheetAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an invoiceWorksheet Updates an existing invoiceWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheet to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInvoiceWorksheetAsyncWithHttpInfo (InvoiceWorksheet body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateInvoiceWorksheet");
            
    
            var localVarPath = "/beta/invoiceWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
