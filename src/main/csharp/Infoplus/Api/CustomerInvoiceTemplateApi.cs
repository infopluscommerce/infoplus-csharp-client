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
    public interface ICustomerInvoiceTemplateApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param>
        /// <returns>CustomerInvoiceTemplate</returns>
        CustomerInvoiceTemplate AddCustomerInvoiceTemplate (CustomerInvoiceTemplate body);
  
        /// <summary>
        /// Create a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param>
        /// <returns>ApiResponse of CustomerInvoiceTemplate</returns>
        ApiResponse<CustomerInvoiceTemplate> AddCustomerInvoiceTemplateWithHttpInfo (CustomerInvoiceTemplate body);
        
        /// <summary>
        /// Add new audit for a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param>
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param>
        /// <returns></returns>
        void AddCustomerInvoiceTemplateAudit (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit);
  
        /// <summary>
        /// Add new audit for a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param>
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCustomerInvoiceTemplateAuditWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit);
        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param>
        /// <param name="customerInvoiceTemplateTag">The tag to add</param>
        /// <returns></returns>
        void AddCustomerInvoiceTemplateTag (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);
  
        /// <summary>
        /// Add new tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param>
        /// <param name="customerInvoiceTemplateTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCustomerInvoiceTemplateTagWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);
        
        /// <summary>
        /// Delete a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param>
        /// <returns></returns>
        void DeleteCustomerInvoiceTemplate (int? customerInvoiceTemplateId);
  
        /// <summary>
        /// Delete a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomerInvoiceTemplateWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param>
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteCustomerInvoiceTemplateTag (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);
  
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param>
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomerInvoiceTemplateTagWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);
        
        /// <summary>
        /// Search customerInvoiceTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;CustomerInvoiceTemplate&gt;</returns>
        List<CustomerInvoiceTemplate> GetCustomerInvoiceTemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search customerInvoiceTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;CustomerInvoiceTemplate&gt;</returns>
        ApiResponse<List<CustomerInvoiceTemplate>> GetCustomerInvoiceTemplateByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param>
        /// <returns>CustomerInvoiceTemplate</returns>
        CustomerInvoiceTemplate GetCustomerInvoiceTemplateById (int? customerInvoiceTemplateId);
  
        /// <summary>
        /// Get a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param>
        /// <returns>ApiResponse of CustomerInvoiceTemplate</returns>
        ApiResponse<CustomerInvoiceTemplate> GetCustomerInvoiceTemplateByIdWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param>
        /// <returns></returns>
        void GetCustomerInvoiceTemplateTags (int? customerInvoiceTemplateId);
  
        /// <summary>
        /// Get the tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetCustomerInvoiceTemplateTagsWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param>
        /// <returns>CustomerInvoiceTemplate</returns>
        CustomerInvoiceTemplate GetDuplicateCustomerInvoiceTemplateById (int? customerInvoiceTemplateId);
  
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param>
        /// <returns>ApiResponse of CustomerInvoiceTemplate</returns>
        ApiResponse<CustomerInvoiceTemplate> GetDuplicateCustomerInvoiceTemplateByIdWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Update a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param>
        /// <returns></returns>
        void UpdateCustomerInvoiceTemplate (CustomerInvoiceTemplate body);
  
        /// <summary>
        /// Update a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCustomerInvoiceTemplateWithHttpInfo (CustomerInvoiceTemplate body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param>
        /// <returns>Task of CustomerInvoiceTemplate</returns>
        System.Threading.Tasks.Task<CustomerInvoiceTemplate> AddCustomerInvoiceTemplateAsync (CustomerInvoiceTemplate body);

        /// <summary>
        /// Create a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplate>> AddCustomerInvoiceTemplateAsyncWithHttpInfo (CustomerInvoiceTemplate body);
        
        /// <summary>
        /// Add new audit for a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param>
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCustomerInvoiceTemplateAuditAsync (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit);

        /// <summary>
        /// Add new audit for a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param>
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateAuditAsyncWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit);
        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param>
        /// <param name="customerInvoiceTemplateTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCustomerInvoiceTemplateTagAsync (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);

        /// <summary>
        /// Add new tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing customerInvoiceTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param>
        /// <param name="customerInvoiceTemplateTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateTagAsyncWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);
        
        /// <summary>
        /// Delete a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateAsync (int? customerInvoiceTemplateId);

        /// <summary>
        /// Delete a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateAsyncWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param>
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateTagAsync (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);

        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param>
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateTagAsyncWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag);
        
        /// <summary>
        /// Search customerInvoiceTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CustomerInvoiceTemplate&gt;</returns>
        System.Threading.Tasks.Task<List<CustomerInvoiceTemplate>> GetCustomerInvoiceTemplateByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search customerInvoiceTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of customerInvoiceTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CustomerInvoiceTemplate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CustomerInvoiceTemplate>>> GetCustomerInvoiceTemplateByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param>
        /// <returns>Task of CustomerInvoiceTemplate</returns>
        System.Threading.Tasks.Task<CustomerInvoiceTemplate> GetCustomerInvoiceTemplateByIdAsync (int? customerInvoiceTemplateId);

        /// <summary>
        /// Get a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplate>> GetCustomerInvoiceTemplateByIdAsyncWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetCustomerInvoiceTemplateTagsAsync (int? customerInvoiceTemplateId);

        /// <summary>
        /// Get the tags for a customerInvoiceTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing customerInvoiceTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCustomerInvoiceTemplateTagsAsyncWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param>
        /// <returns>Task of CustomerInvoiceTemplate</returns>
        System.Threading.Tasks.Task<CustomerInvoiceTemplate> GetDuplicateCustomerInvoiceTemplateByIdAsync (int? customerInvoiceTemplateId);

        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplate>> GetDuplicateCustomerInvoiceTemplateByIdAsyncWithHttpInfo (int? customerInvoiceTemplateId);
        
        /// <summary>
        /// Update a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCustomerInvoiceTemplateAsync (CustomerInvoiceTemplate body);

        /// <summary>
        /// Update a customerInvoiceTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing customerInvoiceTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomerInvoiceTemplateAsyncWithHttpInfo (CustomerInvoiceTemplate body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomerInvoiceTemplateApi : ICustomerInvoiceTemplateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerInvoiceTemplateApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInvoiceTemplateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomerInvoiceTemplateApi(Configuration configuration = null)
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
        /// Create a customerInvoiceTemplate Inserts a new customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param> 
        /// <returns>CustomerInvoiceTemplate</returns>
        public CustomerInvoiceTemplate AddCustomerInvoiceTemplate (CustomerInvoiceTemplate body)
        {
             ApiResponse<CustomerInvoiceTemplate> localVarResponse = AddCustomerInvoiceTemplateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a customerInvoiceTemplate Inserts a new customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param> 
        /// <returns>ApiResponse of CustomerInvoiceTemplate</returns>
        public ApiResponse< CustomerInvoiceTemplate > AddCustomerInvoiceTemplateWithHttpInfo (CustomerInvoiceTemplate body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CustomerInvoiceTemplateApi->AddCustomerInvoiceTemplate");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CustomerInvoiceTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplate)));
            
        }

        
        /// <summary>
        /// Create a customerInvoiceTemplate Inserts a new customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param>
        /// <returns>Task of CustomerInvoiceTemplate</returns>
        public async System.Threading.Tasks.Task<CustomerInvoiceTemplate> AddCustomerInvoiceTemplateAsync (CustomerInvoiceTemplate body)
        {
             ApiResponse<CustomerInvoiceTemplate> localVarResponse = await AddCustomerInvoiceTemplateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a customerInvoiceTemplate Inserts a new customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be inserted.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplate>> AddCustomerInvoiceTemplateAsyncWithHttpInfo (CustomerInvoiceTemplate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCustomerInvoiceTemplate");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerInvoiceTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplate)));
            
        }
        
        /// <summary>
        /// Add new audit for a customerInvoiceTemplate Adds an audit to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param> 
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddCustomerInvoiceTemplateAudit (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit)
        {
             AddCustomerInvoiceTemplateAuditWithHttpInfo(customerInvoiceTemplateId, customerInvoiceTemplateAudit);
        }

        /// <summary>
        /// Add new audit for a customerInvoiceTemplate Adds an audit to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param> 
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCustomerInvoiceTemplateAuditWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit)
        {
            
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling CustomerInvoiceTemplateApi->AddCustomerInvoiceTemplateAudit");
            
            // verify the required parameter 'customerInvoiceTemplateAudit' is set
            if (customerInvoiceTemplateAudit == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateAudit' when calling CustomerInvoiceTemplateApi->AddCustomerInvoiceTemplateAudit");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/audit/{customerInvoiceTemplateAudit}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            if (customerInvoiceTemplateAudit != null) localVarPathParams.Add("customerInvoiceTemplateAudit", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a customerInvoiceTemplate Adds an audit to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param>
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCustomerInvoiceTemplateAuditAsync (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit)
        {
             await AddCustomerInvoiceTemplateAuditAsyncWithHttpInfo(customerInvoiceTemplateId, customerInvoiceTemplateAudit);

        }

        /// <summary>
        /// Add new audit for a customerInvoiceTemplate Adds an audit to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add an audit to</param>
        /// <param name="customerInvoiceTemplateAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateAuditAsyncWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateAudit)
        {
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling AddCustomerInvoiceTemplateAudit");
            // verify the required parameter 'customerInvoiceTemplateAudit' is set
            if (customerInvoiceTemplateAudit == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateAudit' when calling AddCustomerInvoiceTemplateAudit");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/audit/{customerInvoiceTemplateAudit}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            if (customerInvoiceTemplateAudit != null) localVarPathParams.Add("customerInvoiceTemplateAudit", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplate. Adds a tag to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param> 
        /// <param name="customerInvoiceTemplateTag">The tag to add</param> 
        /// <returns></returns>
        public void AddCustomerInvoiceTemplateTag (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
             AddCustomerInvoiceTemplateTagWithHttpInfo(customerInvoiceTemplateId, customerInvoiceTemplateTag);
        }

        /// <summary>
        /// Add new tags for a customerInvoiceTemplate. Adds a tag to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param> 
        /// <param name="customerInvoiceTemplateTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCustomerInvoiceTemplateTagWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
            
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling CustomerInvoiceTemplateApi->AddCustomerInvoiceTemplateTag");
            
            // verify the required parameter 'customerInvoiceTemplateTag' is set
            if (customerInvoiceTemplateTag == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateTag' when calling CustomerInvoiceTemplateApi->AddCustomerInvoiceTemplateTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag/{customerInvoiceTemplateTag}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            if (customerInvoiceTemplateTag != null) localVarPathParams.Add("customerInvoiceTemplateTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a customerInvoiceTemplate. Adds a tag to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param>
        /// <param name="customerInvoiceTemplateTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCustomerInvoiceTemplateTagAsync (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
             await AddCustomerInvoiceTemplateTagAsyncWithHttpInfo(customerInvoiceTemplateId, customerInvoiceTemplateTag);

        }

        /// <summary>
        /// Add new tags for a customerInvoiceTemplate. Adds a tag to an existing customerInvoiceTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to add a tag to</param>
        /// <param name="customerInvoiceTemplateTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCustomerInvoiceTemplateTagAsyncWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling AddCustomerInvoiceTemplateTag");
            // verify the required parameter 'customerInvoiceTemplateTag' is set
            if (customerInvoiceTemplateTag == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateTag' when calling AddCustomerInvoiceTemplateTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag/{customerInvoiceTemplateTag}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            if (customerInvoiceTemplateTag != null) localVarPathParams.Add("customerInvoiceTemplateTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCustomerInvoiceTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a customerInvoiceTemplate Deletes the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param> 
        /// <returns></returns>
        public void DeleteCustomerInvoiceTemplate (int? customerInvoiceTemplateId)
        {
             DeleteCustomerInvoiceTemplateWithHttpInfo(customerInvoiceTemplateId);
        }

        /// <summary>
        /// Delete a customerInvoiceTemplate Deletes the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCustomerInvoiceTemplateWithHttpInfo (int? customerInvoiceTemplateId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling CustomerInvoiceTemplateApi->DeleteCustomerInvoiceTemplate");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a customerInvoiceTemplate Deletes the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateAsync (int? customerInvoiceTemplateId)
        {
             await DeleteCustomerInvoiceTemplateAsyncWithHttpInfo(customerInvoiceTemplateId);

        }

        /// <summary>
        /// Delete a customerInvoiceTemplate Deletes the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateAsyncWithHttpInfo (int? customerInvoiceTemplateId)
        {
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling DeleteCustomerInvoiceTemplate");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate. Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param> 
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteCustomerInvoiceTemplateTag (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
             DeleteCustomerInvoiceTemplateTagWithHttpInfo(customerInvoiceTemplateId, customerInvoiceTemplateTag);
        }

        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate. Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param> 
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCustomerInvoiceTemplateTagWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
            
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling CustomerInvoiceTemplateApi->DeleteCustomerInvoiceTemplateTag");
            
            // verify the required parameter 'customerInvoiceTemplateTag' is set
            if (customerInvoiceTemplateTag == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateTag' when calling CustomerInvoiceTemplateApi->DeleteCustomerInvoiceTemplateTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag/{customerInvoiceTemplateTag}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            if (customerInvoiceTemplateTag != null) localVarPathParams.Add("customerInvoiceTemplateTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate. Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param>
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCustomerInvoiceTemplateTagAsync (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
             await DeleteCustomerInvoiceTemplateTagAsyncWithHttpInfo(customerInvoiceTemplateId, customerInvoiceTemplateTag);

        }

        /// <summary>
        /// Delete a tag for a customerInvoiceTemplate. Deletes an existing customerInvoiceTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to remove tag from</param>
        /// <param name="customerInvoiceTemplateTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomerInvoiceTemplateTagAsyncWithHttpInfo (int? customerInvoiceTemplateId, string customerInvoiceTemplateTag)
        {
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling DeleteCustomerInvoiceTemplateTag");
            // verify the required parameter 'customerInvoiceTemplateTag' is set
            if (customerInvoiceTemplateTag == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateTag' when calling DeleteCustomerInvoiceTemplateTag");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag/{customerInvoiceTemplateTag}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            if (customerInvoiceTemplateTag != null) localVarPathParams.Add("customerInvoiceTemplateTag", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCustomerInvoiceTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search customerInvoiceTemplates by filter Returns the list of customerInvoiceTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;CustomerInvoiceTemplate&gt;</returns>
        public List<CustomerInvoiceTemplate> GetCustomerInvoiceTemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CustomerInvoiceTemplate>> localVarResponse = GetCustomerInvoiceTemplateByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search customerInvoiceTemplates by filter Returns the list of customerInvoiceTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;CustomerInvoiceTemplate&gt;</returns>
        public ApiResponse< List<CustomerInvoiceTemplate> > GetCustomerInvoiceTemplateByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<CustomerInvoiceTemplate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CustomerInvoiceTemplate>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CustomerInvoiceTemplate>)));
            
        }

        
        /// <summary>
        /// Search customerInvoiceTemplates by filter Returns the list of customerInvoiceTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CustomerInvoiceTemplate&gt;</returns>
        public async System.Threading.Tasks.Task<List<CustomerInvoiceTemplate>> GetCustomerInvoiceTemplateByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CustomerInvoiceTemplate>> localVarResponse = await GetCustomerInvoiceTemplateByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search customerInvoiceTemplates by filter Returns the list of customerInvoiceTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CustomerInvoiceTemplate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CustomerInvoiceTemplate>>> GetCustomerInvoiceTemplateByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CustomerInvoiceTemplate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CustomerInvoiceTemplate>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CustomerInvoiceTemplate>)));
            
        }
        
        /// <summary>
        /// Get a customerInvoiceTemplate by id Returns the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param> 
        /// <returns>CustomerInvoiceTemplate</returns>
        public CustomerInvoiceTemplate GetCustomerInvoiceTemplateById (int? customerInvoiceTemplateId)
        {
             ApiResponse<CustomerInvoiceTemplate> localVarResponse = GetCustomerInvoiceTemplateByIdWithHttpInfo(customerInvoiceTemplateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a customerInvoiceTemplate by id Returns the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param> 
        /// <returns>ApiResponse of CustomerInvoiceTemplate</returns>
        public ApiResponse< CustomerInvoiceTemplate > GetCustomerInvoiceTemplateByIdWithHttpInfo (int? customerInvoiceTemplateId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling CustomerInvoiceTemplateApi->GetCustomerInvoiceTemplateById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CustomerInvoiceTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplate)));
            
        }

        
        /// <summary>
        /// Get a customerInvoiceTemplate by id Returns the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param>
        /// <returns>Task of CustomerInvoiceTemplate</returns>
        public async System.Threading.Tasks.Task<CustomerInvoiceTemplate> GetCustomerInvoiceTemplateByIdAsync (int? customerInvoiceTemplateId)
        {
             ApiResponse<CustomerInvoiceTemplate> localVarResponse = await GetCustomerInvoiceTemplateByIdAsyncWithHttpInfo(customerInvoiceTemplateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a customerInvoiceTemplate by id Returns the customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be returned.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplate>> GetCustomerInvoiceTemplateByIdAsyncWithHttpInfo (int? customerInvoiceTemplateId)
        {
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling GetCustomerInvoiceTemplateById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerInvoiceTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplate)));
            
        }
        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplate. Get all existing customerInvoiceTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param> 
        /// <returns></returns>
        public void GetCustomerInvoiceTemplateTags (int? customerInvoiceTemplateId)
        {
             GetCustomerInvoiceTemplateTagsWithHttpInfo(customerInvoiceTemplateId);
        }

        /// <summary>
        /// Get the tags for a customerInvoiceTemplate. Get all existing customerInvoiceTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetCustomerInvoiceTemplateTagsWithHttpInfo (int? customerInvoiceTemplateId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling CustomerInvoiceTemplateApi->GetCustomerInvoiceTemplateTags");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a customerInvoiceTemplate. Get all existing customerInvoiceTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetCustomerInvoiceTemplateTagsAsync (int? customerInvoiceTemplateId)
        {
             await GetCustomerInvoiceTemplateTagsAsyncWithHttpInfo(customerInvoiceTemplateId);

        }

        /// <summary>
        /// Get the tags for a customerInvoiceTemplate. Get all existing customerInvoiceTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCustomerInvoiceTemplateTagsAsyncWithHttpInfo (int? customerInvoiceTemplateId)
        {
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling GetCustomerInvoiceTemplateTags");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/{customerInvoiceTemplateId}/tag";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCustomerInvoiceTemplateTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param> 
        /// <returns>CustomerInvoiceTemplate</returns>
        public CustomerInvoiceTemplate GetDuplicateCustomerInvoiceTemplateById (int? customerInvoiceTemplateId)
        {
             ApiResponse<CustomerInvoiceTemplate> localVarResponse = GetDuplicateCustomerInvoiceTemplateByIdWithHttpInfo(customerInvoiceTemplateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param> 
        /// <returns>ApiResponse of CustomerInvoiceTemplate</returns>
        public ApiResponse< CustomerInvoiceTemplate > GetDuplicateCustomerInvoiceTemplateByIdWithHttpInfo (int? customerInvoiceTemplateId)
        {
            
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling CustomerInvoiceTemplateApi->GetDuplicateCustomerInvoiceTemplateById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/duplicate/{customerInvoiceTemplateId}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CustomerInvoiceTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplate)));
            
        }

        
        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param>
        /// <returns>Task of CustomerInvoiceTemplate</returns>
        public async System.Threading.Tasks.Task<CustomerInvoiceTemplate> GetDuplicateCustomerInvoiceTemplateByIdAsync (int? customerInvoiceTemplateId)
        {
             ApiResponse<CustomerInvoiceTemplate> localVarResponse = await GetDuplicateCustomerInvoiceTemplateByIdAsyncWithHttpInfo(customerInvoiceTemplateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a customerInvoiceTemplate by id Returns a duplicated customerInvoiceTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerInvoiceTemplateId">Id of the customerInvoiceTemplate to be duplicated.</param>
        /// <returns>Task of ApiResponse (CustomerInvoiceTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomerInvoiceTemplate>> GetDuplicateCustomerInvoiceTemplateByIdAsyncWithHttpInfo (int? customerInvoiceTemplateId)
        {
            // verify the required parameter 'customerInvoiceTemplateId' is set
            if (customerInvoiceTemplateId == null) throw new ApiException(400, "Missing required parameter 'customerInvoiceTemplateId' when calling GetDuplicateCustomerInvoiceTemplateById");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate/duplicate/{customerInvoiceTemplateId}";
    
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
            if (customerInvoiceTemplateId != null) localVarPathParams.Add("customerInvoiceTemplateId", Configuration.ApiClient.ParameterToString(customerInvoiceTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCustomerInvoiceTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CustomerInvoiceTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerInvoiceTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomerInvoiceTemplate)));
            
        }
        
        /// <summary>
        /// Update a customerInvoiceTemplate Updates an existing customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param> 
        /// <returns></returns>
        public void UpdateCustomerInvoiceTemplate (CustomerInvoiceTemplate body)
        {
             UpdateCustomerInvoiceTemplateWithHttpInfo(body);
        }

        /// <summary>
        /// Update a customerInvoiceTemplate Updates an existing customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCustomerInvoiceTemplateWithHttpInfo (CustomerInvoiceTemplate body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CustomerInvoiceTemplateApi->UpdateCustomerInvoiceTemplate");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a customerInvoiceTemplate Updates an existing customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCustomerInvoiceTemplateAsync (CustomerInvoiceTemplate body)
        {
             await UpdateCustomerInvoiceTemplateAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a customerInvoiceTemplate Updates an existing customerInvoiceTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CustomerInvoiceTemplate to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCustomerInvoiceTemplateAsyncWithHttpInfo (CustomerInvoiceTemplate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCustomerInvoiceTemplate");
            
    
            var localVarPath = "/beta/customerInvoiceTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCustomerInvoiceTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
