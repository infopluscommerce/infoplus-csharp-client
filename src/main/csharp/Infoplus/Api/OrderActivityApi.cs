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
    public interface IOrderActivityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an orderActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param>
        /// <returns>OrderActivity</returns>
        OrderActivity AddOrderActivity (OrderActivity body);
  
        /// <summary>
        /// Create an orderActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param>
        /// <returns>ApiResponse of OrderActivity</returns>
        ApiResponse<OrderActivity> AddOrderActivityWithHttpInfo (OrderActivity body);
        
        /// <summary>
        /// Add new audit for an orderActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param>
        /// <param name="orderActivityAudit">The audit to add</param>
        /// <returns></returns>
        void AddOrderActivityAudit (double? orderActivityId, string orderActivityAudit);
  
        /// <summary>
        /// Add new audit for an orderActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param>
        /// <param name="orderActivityAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddOrderActivityAuditWithHttpInfo (double? orderActivityId, string orderActivityAudit);
        
        /// <summary>
        /// Add new tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param>
        /// <param name="orderActivityTag">The tag to add</param>
        /// <returns></returns>
        void AddOrderActivityTag (double? orderActivityId, string orderActivityTag);
  
        /// <summary>
        /// Add new tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param>
        /// <param name="orderActivityTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddOrderActivityTagWithHttpInfo (double? orderActivityId, string orderActivityTag);
        
        /// <summary>
        /// Delete an orderActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param>
        /// <returns></returns>
        void DeleteOrderActivity (double? orderActivityId);
  
        /// <summary>
        /// Delete an orderActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrderActivityWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Delete a tag for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param>
        /// <param name="orderActivityTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteOrderActivityTag (double? orderActivityId, string orderActivityTag);
  
        /// <summary>
        /// Delete a tag for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param>
        /// <param name="orderActivityTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrderActivityTagWithHttpInfo (double? orderActivityId, string orderActivityTag);
        
        /// <summary>
        /// Get a duplicated an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param>
        /// <returns>OrderActivity</returns>
        OrderActivity GetDuplicateOrderActivityById (double? orderActivityId);
  
        /// <summary>
        /// Get a duplicated an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param>
        /// <returns>ApiResponse of OrderActivity</returns>
        ApiResponse<OrderActivity> GetDuplicateOrderActivityByIdWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Search orderActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;OrderActivity&gt;</returns>
        List<OrderActivity> GetOrderActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search orderActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;OrderActivity&gt;</returns>
        ApiResponse<List<OrderActivity>> GetOrderActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param>
        /// <returns>OrderActivity</returns>
        OrderActivity GetOrderActivityById (double? orderActivityId);
  
        /// <summary>
        /// Get an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param>
        /// <returns>ApiResponse of OrderActivity</returns>
        ApiResponse<OrderActivity> GetOrderActivityByIdWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Get the tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param>
        /// <returns></returns>
        void GetOrderActivityTags (double? orderActivityId);
  
        /// <summary>
        /// Get the tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetOrderActivityTagsWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Update an orderActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param>
        /// <returns></returns>
        void UpdateOrderActivity (OrderActivity body);
  
        /// <summary>
        /// Update an orderActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOrderActivityWithHttpInfo (OrderActivity body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an orderActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param>
        /// <returns>Task of OrderActivity</returns>
        System.Threading.Tasks.Task<OrderActivity> AddOrderActivityAsync (OrderActivity body);

        /// <summary>
        /// Create an orderActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (OrderActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderActivity>> AddOrderActivityAsyncWithHttpInfo (OrderActivity body);
        
        /// <summary>
        /// Add new audit for an orderActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param>
        /// <param name="orderActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddOrderActivityAuditAsync (double? orderActivityId, string orderActivityAudit);

        /// <summary>
        /// Add new audit for an orderActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param>
        /// <param name="orderActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderActivityAuditAsyncWithHttpInfo (double? orderActivityId, string orderActivityAudit);
        
        /// <summary>
        /// Add new tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param>
        /// <param name="orderActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddOrderActivityTagAsync (double? orderActivityId, string orderActivityTag);

        /// <summary>
        /// Add new tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param>
        /// <param name="orderActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderActivityTagAsyncWithHttpInfo (double? orderActivityId, string orderActivityTag);
        
        /// <summary>
        /// Delete an orderActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrderActivityAsync (double? orderActivityId);

        /// <summary>
        /// Delete an orderActivity
        /// </summary>
        /// <remarks>
        /// Deletes the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderActivityAsyncWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Delete a tag for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param>
        /// <param name="orderActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrderActivityTagAsync (double? orderActivityId, string orderActivityTag);

        /// <summary>
        /// Delete a tag for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param>
        /// <param name="orderActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderActivityTagAsyncWithHttpInfo (double? orderActivityId, string orderActivityTag);
        
        /// <summary>
        /// Get a duplicated an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param>
        /// <returns>Task of OrderActivity</returns>
        System.Threading.Tasks.Task<OrderActivity> GetDuplicateOrderActivityByIdAsync (double? orderActivityId);

        /// <summary>
        /// Get a duplicated an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (OrderActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderActivity>> GetDuplicateOrderActivityByIdAsyncWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Search orderActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OrderActivity&gt;</returns>
        System.Threading.Tasks.Task<List<OrderActivity>> GetOrderActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search orderActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderActivity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrderActivity>>> GetOrderActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param>
        /// <returns>Task of OrderActivity</returns>
        System.Threading.Tasks.Task<OrderActivity> GetOrderActivityByIdAsync (double? orderActivityId);

        /// <summary>
        /// Get an orderActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the orderActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param>
        /// <returns>Task of ApiResponse (OrderActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderActivity>> GetOrderActivityByIdAsyncWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Get the tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetOrderActivityTagsAsync (double? orderActivityId);

        /// <summary>
        /// Get the tags for an orderActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing orderActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetOrderActivityTagsAsyncWithHttpInfo (double? orderActivityId);
        
        /// <summary>
        /// Update an orderActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOrderActivityAsync (OrderActivity body);

        /// <summary>
        /// Update an orderActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing orderActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderActivityAsyncWithHttpInfo (OrderActivity body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderActivityApi : IOrderActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderActivityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderActivityApi(Configuration configuration = null)
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
        /// Create an orderActivity Inserts a new orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param> 
        /// <returns>OrderActivity</returns>
        public OrderActivity AddOrderActivity (OrderActivity body)
        {
             ApiResponse<OrderActivity> localVarResponse = AddOrderActivityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an orderActivity Inserts a new orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param> 
        /// <returns>ApiResponse of OrderActivity</returns>
        public ApiResponse< OrderActivity > AddOrderActivityWithHttpInfo (OrderActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrderActivityApi->AddOrderActivity");
            
    
            var localVarPath = "/beta/orderActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderActivity)));
            
        }

        
        /// <summary>
        /// Create an orderActivity Inserts a new orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param>
        /// <returns>Task of OrderActivity</returns>
        public async System.Threading.Tasks.Task<OrderActivity> AddOrderActivityAsync (OrderActivity body)
        {
             ApiResponse<OrderActivity> localVarResponse = await AddOrderActivityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an orderActivity Inserts a new orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (OrderActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderActivity>> AddOrderActivityAsyncWithHttpInfo (OrderActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOrderActivity");
            
    
            var localVarPath = "/beta/orderActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderActivity)));
            
        }
        
        /// <summary>
        /// Add new audit for an orderActivity Adds an audit to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param> 
        /// <param name="orderActivityAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddOrderActivityAudit (double? orderActivityId, string orderActivityAudit)
        {
             AddOrderActivityAuditWithHttpInfo(orderActivityId, orderActivityAudit);
        }

        /// <summary>
        /// Add new audit for an orderActivity Adds an audit to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param> 
        /// <param name="orderActivityAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddOrderActivityAuditWithHttpInfo (double? orderActivityId, string orderActivityAudit)
        {
            
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling OrderActivityApi->AddOrderActivityAudit");
            
            // verify the required parameter 'orderActivityAudit' is set
            if (orderActivityAudit == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityAudit' when calling OrderActivityApi->AddOrderActivityAudit");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/audit/{orderActivityAudit}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            if (orderActivityAudit != null) localVarPathParams.Add("orderActivityAudit", Configuration.ApiClient.ParameterToString(orderActivityAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an orderActivity Adds an audit to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param>
        /// <param name="orderActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddOrderActivityAuditAsync (double? orderActivityId, string orderActivityAudit)
        {
             await AddOrderActivityAuditAsyncWithHttpInfo(orderActivityId, orderActivityAudit);

        }

        /// <summary>
        /// Add new audit for an orderActivity Adds an audit to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add an audit to</param>
        /// <param name="orderActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderActivityAuditAsyncWithHttpInfo (double? orderActivityId, string orderActivityAudit)
        {
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null) throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling AddOrderActivityAudit");
            // verify the required parameter 'orderActivityAudit' is set
            if (orderActivityAudit == null) throw new ApiException(400, "Missing required parameter 'orderActivityAudit' when calling AddOrderActivityAudit");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/audit/{orderActivityAudit}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            if (orderActivityAudit != null) localVarPathParams.Add("orderActivityAudit", Configuration.ApiClient.ParameterToString(orderActivityAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an orderActivity. Adds a tag to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param> 
        /// <param name="orderActivityTag">The tag to add</param> 
        /// <returns></returns>
        public void AddOrderActivityTag (double? orderActivityId, string orderActivityTag)
        {
             AddOrderActivityTagWithHttpInfo(orderActivityId, orderActivityTag);
        }

        /// <summary>
        /// Add new tags for an orderActivity. Adds a tag to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param> 
        /// <param name="orderActivityTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddOrderActivityTagWithHttpInfo (double? orderActivityId, string orderActivityTag)
        {
            
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling OrderActivityApi->AddOrderActivityTag");
            
            // verify the required parameter 'orderActivityTag' is set
            if (orderActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityTag' when calling OrderActivityApi->AddOrderActivityTag");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/tag/{orderActivityTag}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            if (orderActivityTag != null) localVarPathParams.Add("orderActivityTag", Configuration.ApiClient.ParameterToString(orderActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an orderActivity. Adds a tag to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param>
        /// <param name="orderActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddOrderActivityTagAsync (double? orderActivityId, string orderActivityTag)
        {
             await AddOrderActivityTagAsyncWithHttpInfo(orderActivityId, orderActivityTag);

        }

        /// <summary>
        /// Add new tags for an orderActivity. Adds a tag to an existing orderActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to add a tag to</param>
        /// <param name="orderActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderActivityTagAsyncWithHttpInfo (double? orderActivityId, string orderActivityTag)
        {
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null) throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling AddOrderActivityTag");
            // verify the required parameter 'orderActivityTag' is set
            if (orderActivityTag == null) throw new ApiException(400, "Missing required parameter 'orderActivityTag' when calling AddOrderActivityTag");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/tag/{orderActivityTag}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            if (orderActivityTag != null) localVarPathParams.Add("orderActivityTag", Configuration.ApiClient.ParameterToString(orderActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an orderActivity Deletes the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param> 
        /// <returns></returns>
        public void DeleteOrderActivity (double? orderActivityId)
        {
             DeleteOrderActivityWithHttpInfo(orderActivityId);
        }

        /// <summary>
        /// Delete an orderActivity Deletes the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrderActivityWithHttpInfo (double? orderActivityId)
        {
            
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling OrderActivityApi->DeleteOrderActivity");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an orderActivity Deletes the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrderActivityAsync (double? orderActivityId)
        {
             await DeleteOrderActivityAsyncWithHttpInfo(orderActivityId);

        }

        /// <summary>
        /// Delete an orderActivity Deletes the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderActivityAsyncWithHttpInfo (double? orderActivityId)
        {
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null) throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling DeleteOrderActivity");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an orderActivity. Deletes an existing orderActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param> 
        /// <param name="orderActivityTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteOrderActivityTag (double? orderActivityId, string orderActivityTag)
        {
             DeleteOrderActivityTagWithHttpInfo(orderActivityId, orderActivityTag);
        }

        /// <summary>
        /// Delete a tag for an orderActivity. Deletes an existing orderActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param> 
        /// <param name="orderActivityTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrderActivityTagWithHttpInfo (double? orderActivityId, string orderActivityTag)
        {
            
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling OrderActivityApi->DeleteOrderActivityTag");
            
            // verify the required parameter 'orderActivityTag' is set
            if (orderActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityTag' when calling OrderActivityApi->DeleteOrderActivityTag");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/tag/{orderActivityTag}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            if (orderActivityTag != null) localVarPathParams.Add("orderActivityTag", Configuration.ApiClient.ParameterToString(orderActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an orderActivity. Deletes an existing orderActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param>
        /// <param name="orderActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrderActivityTagAsync (double? orderActivityId, string orderActivityTag)
        {
             await DeleteOrderActivityTagAsyncWithHttpInfo(orderActivityId, orderActivityTag);

        }

        /// <summary>
        /// Delete a tag for an orderActivity. Deletes an existing orderActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to remove tag from</param>
        /// <param name="orderActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderActivityTagAsyncWithHttpInfo (double? orderActivityId, string orderActivityTag)
        {
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null) throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling DeleteOrderActivityTag");
            // verify the required parameter 'orderActivityTag' is set
            if (orderActivityTag == null) throw new ApiException(400, "Missing required parameter 'orderActivityTag' when calling DeleteOrderActivityTag");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/tag/{orderActivityTag}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            if (orderActivityTag != null) localVarPathParams.Add("orderActivityTag", Configuration.ApiClient.ParameterToString(orderActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an orderActivity by id Returns a duplicated orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param> 
        /// <returns>OrderActivity</returns>
        public OrderActivity GetDuplicateOrderActivityById (double? orderActivityId)
        {
             ApiResponse<OrderActivity> localVarResponse = GetDuplicateOrderActivityByIdWithHttpInfo(orderActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an orderActivity by id Returns a duplicated orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param> 
        /// <returns>ApiResponse of OrderActivity</returns>
        public ApiResponse< OrderActivity > GetDuplicateOrderActivityByIdWithHttpInfo (double? orderActivityId)
        {
            
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling OrderActivityApi->GetDuplicateOrderActivityById");
            
    
            var localVarPath = "/beta/orderActivity/duplicate/{orderActivityId}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderActivity)));
            
        }

        
        /// <summary>
        /// Get a duplicated an orderActivity by id Returns a duplicated orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param>
        /// <returns>Task of OrderActivity</returns>
        public async System.Threading.Tasks.Task<OrderActivity> GetDuplicateOrderActivityByIdAsync (double? orderActivityId)
        {
             ApiResponse<OrderActivity> localVarResponse = await GetDuplicateOrderActivityByIdAsyncWithHttpInfo(orderActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an orderActivity by id Returns a duplicated orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (OrderActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderActivity>> GetDuplicateOrderActivityByIdAsyncWithHttpInfo (double? orderActivityId)
        {
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null) throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling GetDuplicateOrderActivityById");
            
    
            var localVarPath = "/beta/orderActivity/duplicate/{orderActivityId}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderActivity)));
            
        }
        
        /// <summary>
        /// Search orderActivitys by filter Returns the list of orderActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;OrderActivity&gt;</returns>
        public List<OrderActivity> GetOrderActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OrderActivity>> localVarResponse = GetOrderActivityByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search orderActivitys by filter Returns the list of orderActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;OrderActivity&gt;</returns>
        public ApiResponse< List<OrderActivity> > GetOrderActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/orderActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<OrderActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderActivity>)));
            
        }

        
        /// <summary>
        /// Search orderActivitys by filter Returns the list of orderActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OrderActivity&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrderActivity>> GetOrderActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OrderActivity>> localVarResponse = await GetOrderActivityByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search orderActivitys by filter Returns the list of orderActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderActivity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OrderActivity>>> GetOrderActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/orderActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OrderActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderActivity>)));
            
        }
        
        /// <summary>
        /// Get an orderActivity by id Returns the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param> 
        /// <returns>OrderActivity</returns>
        public OrderActivity GetOrderActivityById (double? orderActivityId)
        {
             ApiResponse<OrderActivity> localVarResponse = GetOrderActivityByIdWithHttpInfo(orderActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an orderActivity by id Returns the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param> 
        /// <returns>ApiResponse of OrderActivity</returns>
        public ApiResponse< OrderActivity > GetOrderActivityByIdWithHttpInfo (double? orderActivityId)
        {
            
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling OrderActivityApi->GetOrderActivityById");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderActivity)));
            
        }

        
        /// <summary>
        /// Get an orderActivity by id Returns the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param>
        /// <returns>Task of OrderActivity</returns>
        public async System.Threading.Tasks.Task<OrderActivity> GetOrderActivityByIdAsync (double? orderActivityId)
        {
             ApiResponse<OrderActivity> localVarResponse = await GetOrderActivityByIdAsyncWithHttpInfo(orderActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an orderActivity by id Returns the orderActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to be returned.</param>
        /// <returns>Task of ApiResponse (OrderActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderActivity>> GetOrderActivityByIdAsyncWithHttpInfo (double? orderActivityId)
        {
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null) throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling GetOrderActivityById");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderActivity)));
            
        }
        
        /// <summary>
        /// Get the tags for an orderActivity. Get all existing orderActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param> 
        /// <returns></returns>
        public void GetOrderActivityTags (double? orderActivityId)
        {
             GetOrderActivityTagsWithHttpInfo(orderActivityId);
        }

        /// <summary>
        /// Get the tags for an orderActivity. Get all existing orderActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetOrderActivityTagsWithHttpInfo (double? orderActivityId)
        {
            
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null)
                throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling OrderActivityApi->GetOrderActivityTags");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/tag";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an orderActivity. Get all existing orderActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetOrderActivityTagsAsync (double? orderActivityId)
        {
             await GetOrderActivityTagsAsyncWithHttpInfo(orderActivityId);

        }

        /// <summary>
        /// Get the tags for an orderActivity. Get all existing orderActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderActivityId">Id of the orderActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetOrderActivityTagsAsyncWithHttpInfo (double? orderActivityId)
        {
            // verify the required parameter 'orderActivityId' is set
            if (orderActivityId == null) throw new ApiException(400, "Missing required parameter 'orderActivityId' when calling GetOrderActivityTags");
            
    
            var localVarPath = "/beta/orderActivity/{orderActivityId}/tag";
    
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
            if (orderActivityId != null) localVarPathParams.Add("orderActivityId", Configuration.ApiClient.ParameterToString(orderActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an orderActivity Updates an existing orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param> 
        /// <returns></returns>
        public void UpdateOrderActivity (OrderActivity body)
        {
             UpdateOrderActivityWithHttpInfo(body);
        }

        /// <summary>
        /// Update an orderActivity Updates an existing orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOrderActivityWithHttpInfo (OrderActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrderActivityApi->UpdateOrderActivity");
            
    
            var localVarPath = "/beta/orderActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an orderActivity Updates an existing orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOrderActivityAsync (OrderActivity body)
        {
             await UpdateOrderActivityAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an orderActivity Updates an existing orderActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderActivityAsyncWithHttpInfo (OrderActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrderActivity");
            
    
            var localVarPath = "/beta/orderActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
