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
    public interface ICustomerInvoiceTemplateLineApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param>
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param>
        /// <returns></returns>
        void AddCustomerInvoiceTemplateLineAudit (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit);
  
        /// <summary>
        /// Add new audit for a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param>
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCustomerInvoiceTemplateLineAuditWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit);
        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param>
        /// <returns></returns>
        void AddCustomerInvoiceTemplateLineTag (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);
  
        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCustomerInvoiceTemplateLineTagWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);
        
        /// <summary>
        /// Delete a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param>
        /// <returns></returns>
        void DeleteCustomerInvoiceTemplateLine (int? customerInvoiceTemplateLineId);
  
        /// <summary>
        /// Delete a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomerInvoiceTemplateLineWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteCustomerInvoiceTemplateLineTag (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);
  
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomerInvoiceTemplateLineTagWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);
        
        /// <summary>
        /// Search customerInvoiceTemplateLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;CustomerInvoiceTemplateLine&gt;</returns>
        List<CustomerInvoiceTemplateLine> GetCustomerInvoiceTemplateLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search customerInvoiceTemplateLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;CustomerInvoiceTemplateLine&gt;</returns>
        ApiResponse<List<CustomerInvoiceTemplateLine>> GetCustomerInvoiceTemplateLineByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param>
        /// <returns>CustomerInvoiceTemplateLine</returns>
        CustomerInvoiceTemplateLine GetCustomerInvoiceTemplateLineById (int? customerInvoiceTemplateLineId);
  
        /// <summary>
        /// Get a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param>
        /// <returns>ApiResponse of CustomerInvoiceTemplateLine</returns>
        ApiResponse<CustomerInvoiceTemplateLine> GetCustomerInvoiceTemplateLineByIdWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplateLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param>
        /// <returns></returns>
        void GetCustomerInvoiceTemplateLineTags (int? customerInvoiceTemplateLineId);
  
        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplateLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetCustomerInvoiceTemplateLineTagsWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param>
        /// <returns>CustomerInvoiceTemplateLine</returns>
        CustomerInvoiceTemplateLine GetDuplicateCustomerInvoiceTemplateLineById (int? customerInvoiceTemplateLineId);
  
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param>
        /// <returns>ApiResponse of CustomerInvoiceTemplateLine</returns>
        ApiResponse<CustomerInvoiceTemplateLine> GetDuplicateCustomerInvoiceTemplateLineByIdWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Update a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param>
        /// <returns></returns>
        void UpdateCustomerInvoiceTemplateLine (CustomerInvoiceTemplateLine body);
  
        /// <summary>
        /// Update a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCustomerInvoiceTemplateLineWithHttpInfo (CustomerInvoiceTemplateLine body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param>
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCustomerInvoiceTemplateLineAuditAsync (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit);

        /// <summary>
        /// Add new audit for a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param>
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateLineAuditAsyncWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit);
        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCustomerInvoiceTemplateLineTagAsync (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);

        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplateLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateLineTagAsyncWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);
        
        /// <summary>
        /// Delete a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateLineAsync (int? customerInvoiceTemplateLineId);

        /// <summary>
        /// Delete a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateLineAsyncWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateLineTagAsync (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);

        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateLineTagAsyncWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag);
        
        /// <summary>
        /// Search customerInvoiceTemplateLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CustomerInvoiceTemplateLine&gt;</returns>
        System.Threading.Tasks.Task<List<CustomerInvoiceTemplateLine>> GetCustomerInvoiceTemplateLineByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search customerInvoiceTemplateLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CustomerInvoiceTemplateLine&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CustomerInvoiceTemplateLine>>> GetCustomerInvoiceTemplateLineByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param>
        /// <returns>Task of CustomerInvoiceTemplateLine</returns>
        System.Threading.Tasks.Task<CustomerInvoiceTemplateLine> GetCustomerInvoiceTemplateLineByIdAsync (int? customerInvoiceTemplateLineId);

        /// <summary>
        /// Get a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplateLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplateLine>> GetCustomerInvoiceTemplateLineByIdAsyncWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplateLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetCustomerInvoiceTemplateLineTagsAsync (int? customerInvoiceTemplateLineId);

        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplateLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCustomerInvoiceTemplateLineTagsAsyncWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param>
        /// <returns>Task of CustomerInvoiceTemplateLine</returns>
        System.Threading.Tasks.Task<CustomerInvoiceTemplateLine> GetDuplicateCustomerInvoiceTemplateLineByIdAsync (int? customerInvoiceTemplateLineId);

        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplateLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplateLine>> GetDuplicateCustomerInvoiceTemplateLineByIdAsyncWithHttpInfo (int? customerInvoiceTemplateLineId);
        
        /// <summary>
        /// Update a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCustomerInvoiceTemplateLineAsync (CustomerInvoiceTemplateLine body);

        /// <summary>
        /// Update a customerInvoiceTemplateLine
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomerInvoiceTemplateLineAsyncWithHttpInfo (CustomerInvoiceTemplateLine body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomerInvoiceTemplateLineApi : ICustomerInvoiceTemplateLineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateLineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerInvoiceTemplateLineApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateLineApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomerInvoiceTemplateLineApi(Configuration configuration = null)
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
        /// Add new audit for a customerInvoiceTemplateLine Adds an audit to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param> 
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddCustomerInvoiceTemplateLineAudit (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit)
        {
             AddCustomerInvoiceTemplateLineAuditWithHttpInfo(customerInvoiceTemplateLineId, customerInvoiceTemplateLineAudit);
        }

        /// <summary>
        /// Add new audit for a customerInvoiceTemplateLine Adds an audit to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param> 
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCustomerInvoiceTemplateLineAuditWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit)
        {
            
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling CustomerInvoiceTemplateLineApi->AddCustomerInvoiceTemplateLineAudit");
            
            // verify the required parameter 'customerInvoiceTemplateLineAudit' is set
            if (customerInvoiceTemplateLineAudit == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineAudit' when calling CustomerInvoiceTemplateLineApi->AddCustomerInvoiceTemplateLineAudit");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/audit/{customerInvoiceTemplateLineAudit}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            if (customerInvoiceTemplateLineAudit != null) localVarPathParams.Add("customerInvoiceTemplateLineAudit", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a customerInvoiceTemplateLine Adds an audit to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param>
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCustomerInvoiceTemplateLineAuditAsync (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit)
        {
             await AddCustomerInvoiceTemplateLineAuditAsyncWithHttpInfo(customerInvoiceTemplateLineId, customerInvoiceTemplateLineAudit);

        }

        /// <summary>
        /// Add new audit for a customerInvoiceTemplateLine Adds an audit to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add an audit to</param>
        /// <param name="customerInvoiceTemplateLineAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateLineAuditAsyncWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineAudit)
        {
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling AddCustomerInvoiceTemplateLineAudit");
            // verify the required parameter 'customerInvoiceTemplateLineAudit' is set
            if (customerInvoiceTemplateLineAudit == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineAudit' when calling AddCustomerInvoiceTemplateLineAudit");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/audit/{customerInvoiceTemplateLineAudit}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            if (customerInvoiceTemplateLineAudit != null) localVarPathParams.Add("customerInvoiceTemplateLineAudit", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine. Adds a tag to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param> 
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param> 
        /// <returns></returns>
        public void AddCustomerInvoiceTemplateLineTag (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
             AddCustomerInvoiceTemplateLineTagWithHttpInfo(customerInvoiceTemplateLineId, customerInvoiceTemplateLineTag);
        }

        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine. Adds a tag to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param> 
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCustomerInvoiceTemplateLineTagWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
            
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling CustomerInvoiceTemplateLineApi->AddCustomerInvoiceTemplateLineTag");
            
            // verify the required parameter 'customerInvoiceTemplateLineTag' is set
            if (customerInvoiceTemplateLineTag == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineTag' when calling CustomerInvoiceTemplateLineApi->AddCustomerInvoiceTemplateLineTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag/{customerInvoiceTemplateLineTag}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            if (customerInvoiceTemplateLineTag != null) localVarPathParams.Add("customerInvoiceTemplateLineTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine. Adds a tag to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCustomerInvoiceTemplateLineTagAsync (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
             await AddCustomerInvoiceTemplateLineTagAsyncWithHttpInfo(customerInvoiceTemplateLineId, customerInvoiceTemplateLineTag);

        }

        /// <summary>
        /// Add new tags for a customerInvoiceTemplateLine. Adds a tag to an existing customerInvoiceTemplateLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to add a tag to</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateLineTagAsyncWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling AddCustomerInvoiceTemplateLineTag");
            // verify the required parameter 'customerInvoiceTemplateLineTag' is set
            if (customerInvoiceTemplateLineTag == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineTag' when calling AddCustomerInvoiceTemplateLineTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag/{customerInvoiceTemplateLineTag}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            if (customerInvoiceTemplateLineTag != null) localVarPathParams.Add("customerInvoiceTemplateLineTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a customerInvoiceTemplateLine Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param> 
        /// <returns></returns>
        public void DeleteCustomerInvoiceTemplateLine (int? customerInvoiceTemplateLineId)
        {
             DeleteCustomerInvoiceTemplateLineWithHttpInfo(customerInvoiceTemplateLineId);
        }

        /// <summary>
        /// Delete a customerInvoiceTemplateLine Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCustomerInvoiceTemplateLineWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling CustomerInvoiceTemplateLineApi->DeleteCustomerInvoiceTemplateLine");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a customerInvoiceTemplateLine Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateLineAsync (int? customerInvoiceTemplateLineId)
        {
             await DeleteCustomerInvoiceTemplateLineAsyncWithHttpInfo(customerInvoiceTemplateLineId);

        }

        /// <summary>
        /// Delete a customerInvoiceTemplateLine Deletes the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateLineAsyncWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling DeleteCustomerInvoiceTemplateLine");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine. Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param> 
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteCustomerInvoiceTemplateLineTag (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
             DeleteCustomerInvoiceTemplateLineTagWithHttpInfo(customerInvoiceTemplateLineId, customerInvoiceTemplateLineTag);
        }

        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine. Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param> 
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCustomerInvoiceTemplateLineTagWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
            
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling CustomerInvoiceTemplateLineApi->DeleteCustomerInvoiceTemplateLineTag");
            
            // verify the required parameter 'customerInvoiceTemplateLineTag' is set
            if (customerInvoiceTemplateLineTag == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineTag' when calling CustomerInvoiceTemplateLineApi->DeleteCustomerInvoiceTemplateLineTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag/{customerInvoiceTemplateLineTag}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            if (customerInvoiceTemplateLineTag != null) localVarPathParams.Add("customerInvoiceTemplateLineTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine. Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateLineTagAsync (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
             await DeleteCustomerInvoiceTemplateLineTagAsyncWithHttpInfo(customerInvoiceTemplateLineId, customerInvoiceTemplateLineTag);

        }

        /// <summary>
        /// Delete a tag for a customerInvoiceTemplateLine. Deletes an existing customerInvoiceTemplateLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to remove tag from</param>
        /// <param name="customerInvoiceTemplateLineTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateLineTagAsyncWithHttpInfo (int? customerInvoiceTemplateLineId, string customerInvoiceTemplateLineTag)
        {
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling DeleteCustomerInvoiceTemplateLineTag");
            // verify the required parameter 'customerInvoiceTemplateLineTag' is set
            if (customerInvoiceTemplateLineTag == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineTag' when calling DeleteCustomerInvoiceTemplateLineTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag/{customerInvoiceTemplateLineTag}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            if (customerInvoiceTemplateLineTag != null) localVarPathParams.Add("customerInvoiceTemplateLineTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search customerInvoiceTemplateLines by filter Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;CustomerInvoiceTemplateLine&gt;</returns>
        public List<CustomerInvoiceTemplateLine> GetCustomerInvoiceTemplateLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CustomerInvoiceTemplateLine>> localVarResponse = GetCustomerInvoiceTemplateLineByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search customerInvoiceTemplateLines by filter Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;CustomerInvoiceTemplateLine&gt;</returns>
        public ApiResponse< List<CustomerInvoiceTemplateLine> > GetCustomerInvoiceTemplateLineByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<CustomerInvoiceTemplateLine>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CustomerInvoiceTemplateLine>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CustomerInvoiceTemplateLine>)));
            
        }

        
        /// <summary>
        /// Search customerInvoiceTemplateLines by filter Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CustomerInvoiceTemplateLine&gt;</returns>
        public async System.Threading.Tasks.Task<List<CustomerInvoiceTemplateLine>> GetCustomerInvoiceTemplateLineByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CustomerInvoiceTemplateLine>> localVarResponse = await GetCustomerInvoiceTemplateLineByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search customerInvoiceTemplateLines by filter Returns the list of customerInvoiceTemplateLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CustomerInvoiceTemplateLine&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CustomerInvoiceTemplateLine>>> GetCustomerInvoiceTemplateLineByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CustomerInvoiceTemplateLine>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CustomerInvoiceTemplateLine>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CustomerInvoiceTemplateLine>)));
            
        }
        
        /// <summary>
        /// Get a customerInvoiceTemplateLine by id Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param> 
        /// <returns>CustomerInvoiceTemplateLine</returns>
        public CustomerInvoiceTemplateLine GetCustomerInvoiceTemplateLineById (int? customerInvoiceTemplateLineId)
        {
             ApiResponse<CustomerInvoiceTemplateLine> localVarResponse = GetCustomerInvoiceTemplateLineByIdWithHttpInfo(customerInvoiceTemplateLineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a customerInvoiceTemplateLine by id Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param> 
        /// <returns>ApiResponse of CustomerInvoiceTemplateLine</returns>
        public ApiResponse< CustomerInvoiceTemplateLine > GetCustomerInvoiceTemplateLineByIdWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling CustomerInvoiceTemplateLineApi->GetCustomerInvoiceTemplateLineById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CustomerInvoiceTemplateLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplateLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplateLine)));
            
        }

        
        /// <summary>
        /// Get a customerInvoiceTemplateLine by id Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param>
        /// <returns>Task of CustomerInvoiceTemplateLine</returns>
        public async System.Threading.Tasks.Task<CustomerInvoiceTemplateLine> GetCustomerInvoiceTemplateLineByIdAsync (int? customerInvoiceTemplateLineId)
        {
             ApiResponse<CustomerInvoiceTemplateLine> localVarResponse = await GetCustomerInvoiceTemplateLineByIdAsyncWithHttpInfo(customerInvoiceTemplateLineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a customerInvoiceTemplateLine by id Returns the customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be returned.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplateLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplateLine>> GetCustomerInvoiceTemplateLineByIdAsyncWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling GetCustomerInvoiceTemplateLineById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerInvoiceTemplateLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplateLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplateLine)));
            
        }
        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine. Get all existing customerInvoiceTemplateLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param> 
        /// <returns></returns>
        public void GetCustomerInvoiceTemplateLineTags (int? customerInvoiceTemplateLineId)
        {
             GetCustomerInvoiceTemplateLineTagsWithHttpInfo(customerInvoiceTemplateLineId);
        }

        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine. Get all existing customerInvoiceTemplateLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetCustomerInvoiceTemplateLineTagsWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling CustomerInvoiceTemplateLineApi->GetCustomerInvoiceTemplateLineTags");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine. Get all existing customerInvoiceTemplateLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetCustomerInvoiceTemplateLineTagsAsync (int? customerInvoiceTemplateLineId)
        {
             await GetCustomerInvoiceTemplateLineTagsAsyncWithHttpInfo(customerInvoiceTemplateLineId);

        }

        /// <summary>
        /// Get the tags for a customerInvoiceTemplateLine. Get all existing customerInvoiceTemplateLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCustomerInvoiceTemplateLineTagsAsyncWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling GetCustomerInvoiceTemplateLineTags");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/{customerInvoiceTemplateLineId}/tag";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateLineTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param> 
        /// <returns>CustomerInvoiceTemplateLine</returns>
        public CustomerInvoiceTemplateLine GetDuplicateCustomerInvoiceTemplateLineById (int? customerInvoiceTemplateLineId)
        {
             ApiResponse<CustomerInvoiceTemplateLine> localVarResponse = GetDuplicateCustomerInvoiceTemplateLineByIdWithHttpInfo(customerInvoiceTemplateLineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param> 
        /// <returns>ApiResponse of CustomerInvoiceTemplateLine</returns>
        public ApiResponse< CustomerInvoiceTemplateLine > GetDuplicateCustomerInvoiceTemplateLineByIdWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling CustomerInvoiceTemplateLineApi->GetDuplicateCustomerInvoiceTemplateLineById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/duplicate/{customerInvoiceTemplateLineId}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CustomerInvoiceTemplateLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplateLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplateLine)));
            
        }

        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param>
        /// <returns>Task of CustomerInvoiceTemplateLine</returns>
        public async System.Threading.Tasks.Task<CustomerInvoiceTemplateLine> GetDuplicateCustomerInvoiceTemplateLineByIdAsync (int? customerInvoiceTemplateLineId)
        {
             ApiResponse<CustomerInvoiceTemplateLine> localVarResponse = await GetDuplicateCustomerInvoiceTemplateLineByIdAsyncWithHttpInfo(customerInvoiceTemplateLineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a customerInvoiceTemplateLine by id Returns a duplicated customerInvoiceTemplateLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateLineId">Id of the customerInvoiceTemplateLine to be duplicated.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplateLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplateLine>> GetDuplicateCustomerInvoiceTemplateLineByIdAsyncWithHttpInfo (int? customerInvoiceTemplateLineId)
        {
            // verify the required parameter 'customerInvoiceTemplateLineId' is set
            if (customerInvoiceTemplateLineId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateLineId' when calling GetDuplicateCustomerInvoiceTemplateLineById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine/duplicate/{customerInvoiceTemplateLineId}";
    
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
            if (customerInvoiceTemplateLineId != null) localVarPathParams.Add("customerInvoiceTemplateLineId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerInvoiceTemplateLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplateLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplateLine)));
            
        }
        
        /// <summary>
        /// Update a customerInvoiceTemplateLine Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param> 
        /// <returns></returns>
        public void UpdateCustomerInvoiceTemplateLine (CustomerInvoiceTemplateLine body)
        {
             UpdateCustomerInvoiceTemplateLineWithHttpInfo(body);
        }

        /// <summary>
        /// Update a customerInvoiceTemplateLine Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCustomerInvoiceTemplateLineWithHttpInfo (CustomerInvoiceTemplateLine body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CustomerInvoiceTemplateLineApi->UpdateCustomerInvoiceTemplateLine");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplateLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplateLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a customerInvoiceTemplateLine Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCustomerInvoiceTemplateLineAsync (CustomerInvoiceTemplateLine body)
        {
             await UpdateCustomerInvoiceTemplateLineAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a customerInvoiceTemplateLine Updates an existing customerInvoiceTemplateLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplateLine to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomerInvoiceTemplateLineAsyncWithHttpInfo (CustomerInvoiceTemplateLine body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCustomerInvoiceTemplateLine");
            
    
            var localVarPath = "/beta/customerInvoiceTemplateLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplateLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplateLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
