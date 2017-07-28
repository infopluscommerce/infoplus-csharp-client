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
    public interface IOrderLineActivityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param>
        /// <returns>OrderLineActivity</returns>
        OrderLineActivity AddOrderLineActivity (OrderLineActivity body);
  
        /// <summary>
        /// Create an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param>
        /// <returns>ApiResponse of OrderLineActivity</returns>
        ApiResponse<OrderLineActivity> AddOrderLineActivityWithHttpInfo (OrderLineActivity body);
        
        /// <summary>
        /// Add new audit for an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param>
        /// <param name="orderLineActivityAudit">The audit to add</param>
        /// <returns></returns>
        void AddOrderLineActivityAudit (int? orderLineActivityId, string orderLineActivityAudit);
  
        /// <summary>
        /// Add new audit for an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param>
        /// <param name="orderLineActivityAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddOrderLineActivityAuditWithHttpInfo (int? orderLineActivityId, string orderLineActivityAudit);
        
        /// <summary>
        /// Add new tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param>
        /// <param name="orderLineActivityTag">The tag to add</param>
        /// <returns></returns>
        void AddOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag);
  
        /// <summary>
        /// Add new tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param>
        /// <param name="orderLineActivityTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddOrderLineActivityTagWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag);
        
        /// <summary>
        /// Delete an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param>
        /// <returns></returns>
        void DeleteOrderLineActivity (int? orderLineActivityId);
  
        /// <summary>
        /// Delete an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrderLineActivityWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Delete a tag for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderLineActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param>
        /// <param name="orderLineActivityTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag);
  
        /// <summary>
        /// Delete a tag for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderLineActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param>
        /// <param name="orderLineActivityTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrderLineActivityTagWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag);
        
        /// <summary>
        /// Get a duplicated an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param>
        /// <returns>OrderLineActivity</returns>
        OrderLineActivity GetDuplicateOrderLineActivityById (int? orderLineActivityId);
  
        /// <summary>
        /// Get a duplicated an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param>
        /// <returns>ApiResponse of OrderLineActivity</returns>
        ApiResponse<OrderLineActivity> GetDuplicateOrderLineActivityByIdWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Search orderLineActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLineActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;OrderLineActivity&gt;</returns>
        List<OrderLineActivity> GetOrderLineActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search orderLineActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLineActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;OrderLineActivity&gt;</returns>
        ApiResponse<List<OrderLineActivity>> GetOrderLineActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param>
        /// <returns>OrderLineActivity</returns>
        OrderLineActivity GetOrderLineActivityById (int? orderLineActivityId);
  
        /// <summary>
        /// Get an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param>
        /// <returns>ApiResponse of OrderLineActivity</returns>
        ApiResponse<OrderLineActivity> GetOrderLineActivityByIdWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Get the tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderLineActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param>
        /// <returns></returns>
        void GetOrderLineActivityTags (int? orderLineActivityId);
  
        /// <summary>
        /// Get the tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderLineActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetOrderLineActivityTagsWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Update an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param>
        /// <returns></returns>
        void UpdateOrderLineActivity (OrderLineActivity body);
  
        /// <summary>
        /// Update an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOrderLineActivityWithHttpInfo (OrderLineActivity body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param>
        /// <returns>Task of OrderLineActivity</returns>
        System.Threading.Tasks.Task<OrderLineActivity> AddOrderLineActivityAsync (OrderLineActivity body);

        /// <summary>
        /// Create an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (OrderLineActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderLineActivity>> AddOrderLineActivityAsyncWithHttpInfo (OrderLineActivity body);
        
        /// <summary>
        /// Add new audit for an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param>
        /// <param name="orderLineActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddOrderLineActivityAuditAsync (int? orderLineActivityId, string orderLineActivityAudit);

        /// <summary>
        /// Add new audit for an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param>
        /// <param name="orderLineActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderLineActivityAuditAsyncWithHttpInfo (int? orderLineActivityId, string orderLineActivityAudit);
        
        /// <summary>
        /// Add new tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param>
        /// <param name="orderLineActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddOrderLineActivityTagAsync (int? orderLineActivityId, string orderLineActivityTag);

        /// <summary>
        /// Add new tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderLineActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param>
        /// <param name="orderLineActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderLineActivityTagAsyncWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag);
        
        /// <summary>
        /// Delete an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrderLineActivityAsync (int? orderLineActivityId);

        /// <summary>
        /// Delete an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderLineActivityAsyncWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Delete a tag for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderLineActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param>
        /// <param name="orderLineActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrderLineActivityTagAsync (int? orderLineActivityId, string orderLineActivityTag);

        /// <summary>
        /// Delete a tag for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderLineActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param>
        /// <param name="orderLineActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderLineActivityTagAsyncWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag);
        
        /// <summary>
        /// Get a duplicated an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param>
        /// <returns>Task of OrderLineActivity</returns>
        System.Threading.Tasks.Task<OrderLineActivity> GetDuplicateOrderLineActivityByIdAsync (int? orderLineActivityId);

        /// <summary>
        /// Get a duplicated an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (OrderLineActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderLineActivity>> GetDuplicateOrderLineActivityByIdAsyncWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Search orderLineActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLineActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OrderLineActivity&gt;</returns>
        System.Threading.Tasks.Task<List<OrderLineActivity>> GetOrderLineActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search orderLineActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderLineActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderLineActivity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrderLineActivity>>> GetOrderLineActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param>
        /// <returns>Task of OrderLineActivity</returns>
        System.Threading.Tasks.Task<OrderLineActivity> GetOrderLineActivityByIdAsync (int? orderLineActivityId);

        /// <summary>
        /// Get an orderLineActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderLineActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param>
        /// <returns>Task of ApiResponse (OrderLineActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderLineActivity>> GetOrderLineActivityByIdAsyncWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Get the tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderLineActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetOrderLineActivityTagsAsync (int? orderLineActivityId);

        /// <summary>
        /// Get the tags for an orderLineActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderLineActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetOrderLineActivityTagsAsyncWithHttpInfo (int? orderLineActivityId);
        
        /// <summary>
        /// Update an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOrderLineActivityAsync (OrderLineActivity body);

        /// <summary>
        /// Update an orderLineActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderLineActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderLineActivityAsyncWithHttpInfo (OrderLineActivity body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderLineActivityApi : IOrderLineActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderLineActivityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderLineActivityApi(Configuration configuration = null)
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
        /// Create an orderLineActivity Inserts a new orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param> 
        /// <returns>OrderLineActivity</returns>
        public OrderLineActivity AddOrderLineActivity (OrderLineActivity body)
        {
             ApiResponse<OrderLineActivity> localVarResponse = AddOrderLineActivityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an orderLineActivity Inserts a new orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param> 
        /// <returns>ApiResponse of OrderLineActivity</returns>
        public ApiResponse< OrderLineActivity > AddOrderLineActivityWithHttpInfo (OrderLineActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrderLineActivityApi->AddOrderLineActivity");
            
    
            var localVarPath = "/beta/orderLineActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderLineActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLineActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLineActivity)));
            
        }

        
        /// <summary>
        /// Create an orderLineActivity Inserts a new orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param>
        /// <returns>Task of OrderLineActivity</returns>
        public async System.Threading.Tasks.Task<OrderLineActivity> AddOrderLineActivityAsync (OrderLineActivity body)
        {
             ApiResponse<OrderLineActivity> localVarResponse = await AddOrderLineActivityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an orderLineActivity Inserts a new orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (OrderLineActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderLineActivity>> AddOrderLineActivityAsyncWithHttpInfo (OrderLineActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOrderLineActivity");
            
    
            var localVarPath = "/beta/orderLineActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderLineActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLineActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLineActivity)));
            
        }
        
        /// <summary>
        /// Add new audit for an orderLineActivity Adds an audit to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param> 
        /// <param name="orderLineActivityAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddOrderLineActivityAudit (int? orderLineActivityId, string orderLineActivityAudit)
        {
             AddOrderLineActivityAuditWithHttpInfo(orderLineActivityId, orderLineActivityAudit);
        }

        /// <summary>
        /// Add new audit for an orderLineActivity Adds an audit to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param> 
        /// <param name="orderLineActivityAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddOrderLineActivityAuditWithHttpInfo (int? orderLineActivityId, string orderLineActivityAudit)
        {
            
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling OrderLineActivityApi->AddOrderLineActivityAudit");
            
            // verify the required parameter 'orderLineActivityAudit' is set
            if (orderLineActivityAudit == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityAudit' when calling OrderLineActivityApi->AddOrderLineActivityAudit");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/audit/{orderLineActivityAudit}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            if (orderLineActivityAudit != null) localVarPathParams.Add("orderLineActivityAudit", Configuration.ApiClient.ParameterToString(orderLineActivityAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an orderLineActivity Adds an audit to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param>
        /// <param name="orderLineActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddOrderLineActivityAuditAsync (int? orderLineActivityId, string orderLineActivityAudit)
        {
             await AddOrderLineActivityAuditAsyncWithHttpInfo(orderLineActivityId, orderLineActivityAudit);

        }

        /// <summary>
        /// Add new audit for an orderLineActivity Adds an audit to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add an audit to</param>
        /// <param name="orderLineActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderLineActivityAuditAsyncWithHttpInfo (int? orderLineActivityId, string orderLineActivityAudit)
        {
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling AddOrderLineActivityAudit");
            // verify the required parameter 'orderLineActivityAudit' is set
            if (orderLineActivityAudit == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityAudit' when calling AddOrderLineActivityAudit");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/audit/{orderLineActivityAudit}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            if (orderLineActivityAudit != null) localVarPathParams.Add("orderLineActivityAudit", Configuration.ApiClient.ParameterToString(orderLineActivityAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an orderLineActivity. Adds a tag to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param> 
        /// <param name="orderLineActivityTag">The tag to add</param> 
        /// <returns></returns>
        public void AddOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag)
        {
             AddOrderLineActivityTagWithHttpInfo(orderLineActivityId, orderLineActivityTag);
        }

        /// <summary>
        /// Add new tags for an orderLineActivity. Adds a tag to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param> 
        /// <param name="orderLineActivityTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddOrderLineActivityTagWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag)
        {
            
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling OrderLineActivityApi->AddOrderLineActivityTag");
            
            // verify the required parameter 'orderLineActivityTag' is set
            if (orderLineActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityTag' when calling OrderLineActivityApi->AddOrderLineActivityTag");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            if (orderLineActivityTag != null) localVarPathParams.Add("orderLineActivityTag", Configuration.ApiClient.ParameterToString(orderLineActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an orderLineActivity. Adds a tag to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param>
        /// <param name="orderLineActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddOrderLineActivityTagAsync (int? orderLineActivityId, string orderLineActivityTag)
        {
             await AddOrderLineActivityTagAsyncWithHttpInfo(orderLineActivityId, orderLineActivityTag);

        }

        /// <summary>
        /// Add new tags for an orderLineActivity. Adds a tag to an existing orderLineActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to add a tag to</param>
        /// <param name="orderLineActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderLineActivityTagAsyncWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag)
        {
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling AddOrderLineActivityTag");
            // verify the required parameter 'orderLineActivityTag' is set
            if (orderLineActivityTag == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityTag' when calling AddOrderLineActivityTag");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            if (orderLineActivityTag != null) localVarPathParams.Add("orderLineActivityTag", Configuration.ApiClient.ParameterToString(orderLineActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderLineActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an orderLineActivity Deletes the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param> 
        /// <returns></returns>
        public void DeleteOrderLineActivity (int? orderLineActivityId)
        {
             DeleteOrderLineActivityWithHttpInfo(orderLineActivityId);
        }

        /// <summary>
        /// Delete an orderLineActivity Deletes the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrderLineActivityWithHttpInfo (int? orderLineActivityId)
        {
            
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling OrderLineActivityApi->DeleteOrderLineActivity");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an orderLineActivity Deletes the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrderLineActivityAsync (int? orderLineActivityId)
        {
             await DeleteOrderLineActivityAsyncWithHttpInfo(orderLineActivityId);

        }

        /// <summary>
        /// Delete an orderLineActivity Deletes the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderLineActivityAsyncWithHttpInfo (int? orderLineActivityId)
        {
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling DeleteOrderLineActivity");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an orderLineActivity. Deletes an existing orderLineActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param> 
        /// <param name="orderLineActivityTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteOrderLineActivityTag (int? orderLineActivityId, string orderLineActivityTag)
        {
             DeleteOrderLineActivityTagWithHttpInfo(orderLineActivityId, orderLineActivityTag);
        }

        /// <summary>
        /// Delete a tag for an orderLineActivity. Deletes an existing orderLineActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param> 
        /// <param name="orderLineActivityTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrderLineActivityTagWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag)
        {
            
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling OrderLineActivityApi->DeleteOrderLineActivityTag");
            
            // verify the required parameter 'orderLineActivityTag' is set
            if (orderLineActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityTag' when calling OrderLineActivityApi->DeleteOrderLineActivityTag");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            if (orderLineActivityTag != null) localVarPathParams.Add("orderLineActivityTag", Configuration.ApiClient.ParameterToString(orderLineActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an orderLineActivity. Deletes an existing orderLineActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param>
        /// <param name="orderLineActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrderLineActivityTagAsync (int? orderLineActivityId, string orderLineActivityTag)
        {
             await DeleteOrderLineActivityTagAsyncWithHttpInfo(orderLineActivityId, orderLineActivityTag);

        }

        /// <summary>
        /// Delete a tag for an orderLineActivity. Deletes an existing orderLineActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to remove tag from</param>
        /// <param name="orderLineActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderLineActivityTagAsyncWithHttpInfo (int? orderLineActivityId, string orderLineActivityTag)
        {
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling DeleteOrderLineActivityTag");
            // verify the required parameter 'orderLineActivityTag' is set
            if (orderLineActivityTag == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityTag' when calling DeleteOrderLineActivityTag");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/tag/{orderLineActivityTag}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            if (orderLineActivityTag != null) localVarPathParams.Add("orderLineActivityTag", Configuration.ApiClient.ParameterToString(orderLineActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderLineActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an orderLineActivity by id Returns a duplicated orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param> 
        /// <returns>OrderLineActivity</returns>
        public OrderLineActivity GetDuplicateOrderLineActivityById (int? orderLineActivityId)
        {
             ApiResponse<OrderLineActivity> localVarResponse = GetDuplicateOrderLineActivityByIdWithHttpInfo(orderLineActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an orderLineActivity by id Returns a duplicated orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param> 
        /// <returns>ApiResponse of OrderLineActivity</returns>
        public ApiResponse< OrderLineActivity > GetDuplicateOrderLineActivityByIdWithHttpInfo (int? orderLineActivityId)
        {
            
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling OrderLineActivityApi->GetDuplicateOrderLineActivityById");
            
    
            var localVarPath = "/beta/orderLineActivity/duplicate/{orderLineActivityId}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderLineActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderLineActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderLineActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLineActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLineActivity)));
            
        }

        
        /// <summary>
        /// Get a duplicated an orderLineActivity by id Returns a duplicated orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param>
        /// <returns>Task of OrderLineActivity</returns>
        public async System.Threading.Tasks.Task<OrderLineActivity> GetDuplicateOrderLineActivityByIdAsync (int? orderLineActivityId)
        {
             ApiResponse<OrderLineActivity> localVarResponse = await GetDuplicateOrderLineActivityByIdAsyncWithHttpInfo(orderLineActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an orderLineActivity by id Returns a duplicated orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (OrderLineActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderLineActivity>> GetDuplicateOrderLineActivityByIdAsyncWithHttpInfo (int? orderLineActivityId)
        {
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling GetDuplicateOrderLineActivityById");
            
    
            var localVarPath = "/beta/orderLineActivity/duplicate/{orderLineActivityId}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderLineActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderLineActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderLineActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLineActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLineActivity)));
            
        }
        
        /// <summary>
        /// Search orderLineActivitys by filter Returns the list of orderLineActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;OrderLineActivity&gt;</returns>
        public List<OrderLineActivity> GetOrderLineActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OrderLineActivity>> localVarResponse = GetOrderLineActivityByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search orderLineActivitys by filter Returns the list of orderLineActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;OrderLineActivity&gt;</returns>
        public ApiResponse< List<OrderLineActivity> > GetOrderLineActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/orderLineActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<OrderLineActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderLineActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderLineActivity>)));
            
        }

        
        /// <summary>
        /// Search orderLineActivitys by filter Returns the list of orderLineActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OrderLineActivity&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrderLineActivity>> GetOrderLineActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OrderLineActivity>> localVarResponse = await GetOrderLineActivityByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search orderLineActivitys by filter Returns the list of orderLineActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderLineActivity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OrderLineActivity>>> GetOrderLineActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/orderLineActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OrderLineActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderLineActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderLineActivity>)));
            
        }
        
        /// <summary>
        /// Get an orderLineActivity by id Returns the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param> 
        /// <returns>OrderLineActivity</returns>
        public OrderLineActivity GetOrderLineActivityById (int? orderLineActivityId)
        {
             ApiResponse<OrderLineActivity> localVarResponse = GetOrderLineActivityByIdWithHttpInfo(orderLineActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an orderLineActivity by id Returns the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param> 
        /// <returns>ApiResponse of OrderLineActivity</returns>
        public ApiResponse< OrderLineActivity > GetOrderLineActivityByIdWithHttpInfo (int? orderLineActivityId)
        {
            
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling OrderLineActivityApi->GetOrderLineActivityById");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderLineActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLineActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLineActivity)));
            
        }

        
        /// <summary>
        /// Get an orderLineActivity by id Returns the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param>
        /// <returns>Task of OrderLineActivity</returns>
        public async System.Threading.Tasks.Task<OrderLineActivity> GetOrderLineActivityByIdAsync (int? orderLineActivityId)
        {
             ApiResponse<OrderLineActivity> localVarResponse = await GetOrderLineActivityByIdAsyncWithHttpInfo(orderLineActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an orderLineActivity by id Returns the orderLineActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to be returned.</param>
        /// <returns>Task of ApiResponse (OrderLineActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderLineActivity>> GetOrderLineActivityByIdAsyncWithHttpInfo (int? orderLineActivityId)
        {
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling GetOrderLineActivityById");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderLineActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderLineActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderLineActivity)));
            
        }
        
        /// <summary>
        /// Get the tags for an orderLineActivity. Get all existing orderLineActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param> 
        /// <returns></returns>
        public void GetOrderLineActivityTags (int? orderLineActivityId)
        {
             GetOrderLineActivityTagsWithHttpInfo(orderLineActivityId);
        }

        /// <summary>
        /// Get the tags for an orderLineActivity. Get all existing orderLineActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetOrderLineActivityTagsWithHttpInfo (int? orderLineActivityId)
        {
            
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling OrderLineActivityApi->GetOrderLineActivityTags");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/tag";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an orderLineActivity. Get all existing orderLineActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetOrderLineActivityTagsAsync (int? orderLineActivityId)
        {
             await GetOrderLineActivityTagsAsyncWithHttpInfo(orderLineActivityId);

        }

        /// <summary>
        /// Get the tags for an orderLineActivity. Get all existing orderLineActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderLineActivityId">Id of the orderLineActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetOrderLineActivityTagsAsyncWithHttpInfo (int? orderLineActivityId)
        {
            // verify the required parameter 'orderLineActivityId' is set
            if (orderLineActivityId == null) throw new ApiException(400, "Missing required parameter 'orderLineActivityId' when calling GetOrderLineActivityTags");
            
    
            var localVarPath = "/beta/orderLineActivity/{orderLineActivityId}/tag";
    
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
            if (orderLineActivityId != null) localVarPathParams.Add("orderLineActivityId", Configuration.ApiClient.ParameterToString(orderLineActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderLineActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an orderLineActivity Updates an existing orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param> 
        /// <returns></returns>
        public void UpdateOrderLineActivity (OrderLineActivity body)
        {
             UpdateOrderLineActivityWithHttpInfo(body);
        }

        /// <summary>
        /// Update an orderLineActivity Updates an existing orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOrderLineActivityWithHttpInfo (OrderLineActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrderLineActivityApi->UpdateOrderLineActivity");
            
    
            var localVarPath = "/beta/orderLineActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderLineActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderLineActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an orderLineActivity Updates an existing orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOrderLineActivityAsync (OrderLineActivity body)
        {
             await UpdateOrderLineActivityAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an orderLineActivity Updates an existing orderLineActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderLineActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderLineActivityAsyncWithHttpInfo (OrderLineActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrderLineActivity");
            
    
            var localVarPath = "/beta/orderLineActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderLineActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderLineActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
