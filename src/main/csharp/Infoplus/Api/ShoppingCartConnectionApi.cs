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
    public interface IShoppingCartConnectionApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Inserts a new shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param>
        /// <returns>ShoppingCartConnection</returns>
        ShoppingCartConnection AddShoppingCartConnection (ShoppingCartConnection body);
  
        /// <summary>
        /// Create a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Inserts a new shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param>
        /// <returns>ApiResponse of ShoppingCartConnection</returns>
        ApiResponse<ShoppingCartConnection> AddShoppingCartConnectionWithHttpInfo (ShoppingCartConnection body);
        
        /// <summary>
        /// Delete a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Deletes the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param>
        /// <returns></returns>
        void DeleteShoppingCartConnection (int? shoppingCartConnectionId);
  
        /// <summary>
        /// Delete a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Deletes the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteShoppingCartConnectionWithHttpInfo (int? shoppingCartConnectionId);
        
        /// <summary>
        /// Search shoppingCartConnections by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shoppingCartConnections that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ShoppingCartConnection&gt;</returns>
        List<ShoppingCartConnection> GetShoppingCartConnectionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search shoppingCartConnections by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shoppingCartConnections that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ShoppingCartConnection&gt;</returns>
        ApiResponse<List<ShoppingCartConnection>> GetShoppingCartConnectionByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a shoppingCartConnection by id
        /// </summary>
        /// <remarks>
        /// Returns the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param>
        /// <returns>ShoppingCartConnection</returns>
        ShoppingCartConnection GetShoppingCartConnectionById (int? shoppingCartConnectionId);
  
        /// <summary>
        /// Get a shoppingCartConnection by id
        /// </summary>
        /// <remarks>
        /// Returns the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param>
        /// <returns>ApiResponse of ShoppingCartConnection</returns>
        ApiResponse<ShoppingCartConnection> GetShoppingCartConnectionByIdWithHttpInfo (int? shoppingCartConnectionId);
        
        /// <summary>
        /// Update a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns></returns>
        void UpdateShoppingCartConnection (ShoppingCartConnection body);
  
        /// <summary>
        /// Update a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateShoppingCartConnectionWithHttpInfo (ShoppingCartConnection body);
        
        /// <summary>
        /// Update a shoppingCartConnection custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns></returns>
        void UpdateShoppingCartConnectionCustomFields (ShoppingCartConnection body);
  
        /// <summary>
        /// Update a shoppingCartConnection custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateShoppingCartConnectionCustomFieldsWithHttpInfo (ShoppingCartConnection body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Inserts a new shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param>
        /// <returns>Task of ShoppingCartConnection</returns>
        System.Threading.Tasks.Task<ShoppingCartConnection> AddShoppingCartConnectionAsync (ShoppingCartConnection body);

        /// <summary>
        /// Create a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Inserts a new shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param>
        /// <returns>Task of ApiResponse (ShoppingCartConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShoppingCartConnection>> AddShoppingCartConnectionAsyncWithHttpInfo (ShoppingCartConnection body);
        
        /// <summary>
        /// Delete a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Deletes the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteShoppingCartConnectionAsync (int? shoppingCartConnectionId);

        /// <summary>
        /// Delete a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Deletes the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteShoppingCartConnectionAsyncWithHttpInfo (int? shoppingCartConnectionId);
        
        /// <summary>
        /// Search shoppingCartConnections by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shoppingCartConnections that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ShoppingCartConnection&gt;</returns>
        System.Threading.Tasks.Task<List<ShoppingCartConnection>> GetShoppingCartConnectionByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search shoppingCartConnections by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shoppingCartConnections that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ShoppingCartConnection&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ShoppingCartConnection>>> GetShoppingCartConnectionByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a shoppingCartConnection by id
        /// </summary>
        /// <remarks>
        /// Returns the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param>
        /// <returns>Task of ShoppingCartConnection</returns>
        System.Threading.Tasks.Task<ShoppingCartConnection> GetShoppingCartConnectionByIdAsync (int? shoppingCartConnectionId);

        /// <summary>
        /// Get a shoppingCartConnection by id
        /// </summary>
        /// <remarks>
        /// Returns the shoppingCartConnection identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param>
        /// <returns>Task of ApiResponse (ShoppingCartConnection)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShoppingCartConnection>> GetShoppingCartConnectionByIdAsyncWithHttpInfo (int? shoppingCartConnectionId);
        
        /// <summary>
        /// Update a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateShoppingCartConnectionAsync (ShoppingCartConnection body);

        /// <summary>
        /// Update a shoppingCartConnection
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateShoppingCartConnectionAsyncWithHttpInfo (ShoppingCartConnection body);
        
        /// <summary>
        /// Update a shoppingCartConnection custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateShoppingCartConnectionCustomFieldsAsync (ShoppingCartConnection body);

        /// <summary>
        /// Update a shoppingCartConnection custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateShoppingCartConnectionCustomFieldsAsyncWithHttpInfo (ShoppingCartConnection body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShoppingCartConnectionApi : IShoppingCartConnectionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartConnectionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShoppingCartConnectionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartConnectionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShoppingCartConnectionApi(Configuration configuration = null)
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
        /// Create a shoppingCartConnection Inserts a new shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param> 
        /// <returns>ShoppingCartConnection</returns>
        public ShoppingCartConnection AddShoppingCartConnection (ShoppingCartConnection body)
        {
             ApiResponse<ShoppingCartConnection> localVarResponse = AddShoppingCartConnectionWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a shoppingCartConnection Inserts a new shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param> 
        /// <returns>ApiResponse of ShoppingCartConnection</returns>
        public ApiResponse< ShoppingCartConnection > AddShoppingCartConnectionWithHttpInfo (ShoppingCartConnection body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ShoppingCartConnectionApi->AddShoppingCartConnection");
            
    
            var localVarPath = "/beta/shoppingCartConnection";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddShoppingCartConnection: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddShoppingCartConnection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ShoppingCartConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShoppingCartConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShoppingCartConnection)));
            
        }

        
        /// <summary>
        /// Create a shoppingCartConnection Inserts a new shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param>
        /// <returns>Task of ShoppingCartConnection</returns>
        public async System.Threading.Tasks.Task<ShoppingCartConnection> AddShoppingCartConnectionAsync (ShoppingCartConnection body)
        {
             ApiResponse<ShoppingCartConnection> localVarResponse = await AddShoppingCartConnectionAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a shoppingCartConnection Inserts a new shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be inserted.</param>
        /// <returns>Task of ApiResponse (ShoppingCartConnection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShoppingCartConnection>> AddShoppingCartConnectionAsyncWithHttpInfo (ShoppingCartConnection body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddShoppingCartConnection");
            
    
            var localVarPath = "/beta/shoppingCartConnection";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddShoppingCartConnection: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddShoppingCartConnection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShoppingCartConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShoppingCartConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShoppingCartConnection)));
            
        }
        
        /// <summary>
        /// Delete a shoppingCartConnection Deletes the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param> 
        /// <returns></returns>
        public void DeleteShoppingCartConnection (int? shoppingCartConnectionId)
        {
             DeleteShoppingCartConnectionWithHttpInfo(shoppingCartConnectionId);
        }

        /// <summary>
        /// Delete a shoppingCartConnection Deletes the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteShoppingCartConnectionWithHttpInfo (int? shoppingCartConnectionId)
        {
            
            // verify the required parameter 'shoppingCartConnectionId' is set
            if (shoppingCartConnectionId == null)
                throw new ApiException(400, "Missing required parameter 'shoppingCartConnectionId' when calling ShoppingCartConnectionApi->DeleteShoppingCartConnection");
            
    
            var localVarPath = "/beta/shoppingCartConnection/{shoppingCartConnectionId}";
    
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
            if (shoppingCartConnectionId != null) localVarPathParams.Add("shoppingCartConnectionId", Configuration.ApiClient.ParameterToString(shoppingCartConnectionId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteShoppingCartConnection: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteShoppingCartConnection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a shoppingCartConnection Deletes the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteShoppingCartConnectionAsync (int? shoppingCartConnectionId)
        {
             await DeleteShoppingCartConnectionAsyncWithHttpInfo(shoppingCartConnectionId);

        }

        /// <summary>
        /// Delete a shoppingCartConnection Deletes the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteShoppingCartConnectionAsyncWithHttpInfo (int? shoppingCartConnectionId)
        {
            // verify the required parameter 'shoppingCartConnectionId' is set
            if (shoppingCartConnectionId == null) throw new ApiException(400, "Missing required parameter 'shoppingCartConnectionId' when calling DeleteShoppingCartConnection");
            
    
            var localVarPath = "/beta/shoppingCartConnection/{shoppingCartConnectionId}";
    
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
            if (shoppingCartConnectionId != null) localVarPathParams.Add("shoppingCartConnectionId", Configuration.ApiClient.ParameterToString(shoppingCartConnectionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteShoppingCartConnection: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteShoppingCartConnection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search shoppingCartConnections by filter Returns the list of shoppingCartConnections that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ShoppingCartConnection&gt;</returns>
        public List<ShoppingCartConnection> GetShoppingCartConnectionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ShoppingCartConnection>> localVarResponse = GetShoppingCartConnectionByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search shoppingCartConnections by filter Returns the list of shoppingCartConnections that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ShoppingCartConnection&gt;</returns>
        public ApiResponse< List<ShoppingCartConnection> > GetShoppingCartConnectionByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/shoppingCartConnection/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ShoppingCartConnection>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ShoppingCartConnection>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ShoppingCartConnection>)));
            
        }

        
        /// <summary>
        /// Search shoppingCartConnections by filter Returns the list of shoppingCartConnections that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ShoppingCartConnection&gt;</returns>
        public async System.Threading.Tasks.Task<List<ShoppingCartConnection>> GetShoppingCartConnectionByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ShoppingCartConnection>> localVarResponse = await GetShoppingCartConnectionByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search shoppingCartConnections by filter Returns the list of shoppingCartConnections that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ShoppingCartConnection&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ShoppingCartConnection>>> GetShoppingCartConnectionByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/shoppingCartConnection/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ShoppingCartConnection>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ShoppingCartConnection>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ShoppingCartConnection>)));
            
        }
        
        /// <summary>
        /// Get a shoppingCartConnection by id Returns the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param> 
        /// <returns>ShoppingCartConnection</returns>
        public ShoppingCartConnection GetShoppingCartConnectionById (int? shoppingCartConnectionId)
        {
             ApiResponse<ShoppingCartConnection> localVarResponse = GetShoppingCartConnectionByIdWithHttpInfo(shoppingCartConnectionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a shoppingCartConnection by id Returns the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param> 
        /// <returns>ApiResponse of ShoppingCartConnection</returns>
        public ApiResponse< ShoppingCartConnection > GetShoppingCartConnectionByIdWithHttpInfo (int? shoppingCartConnectionId)
        {
            
            // verify the required parameter 'shoppingCartConnectionId' is set
            if (shoppingCartConnectionId == null)
                throw new ApiException(400, "Missing required parameter 'shoppingCartConnectionId' when calling ShoppingCartConnectionApi->GetShoppingCartConnectionById");
            
    
            var localVarPath = "/beta/shoppingCartConnection/{shoppingCartConnectionId}";
    
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
            if (shoppingCartConnectionId != null) localVarPathParams.Add("shoppingCartConnectionId", Configuration.ApiClient.ParameterToString(shoppingCartConnectionId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ShoppingCartConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShoppingCartConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShoppingCartConnection)));
            
        }

        
        /// <summary>
        /// Get a shoppingCartConnection by id Returns the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param>
        /// <returns>Task of ShoppingCartConnection</returns>
        public async System.Threading.Tasks.Task<ShoppingCartConnection> GetShoppingCartConnectionByIdAsync (int? shoppingCartConnectionId)
        {
             ApiResponse<ShoppingCartConnection> localVarResponse = await GetShoppingCartConnectionByIdAsyncWithHttpInfo(shoppingCartConnectionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a shoppingCartConnection by id Returns the shoppingCartConnection identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shoppingCartConnectionId">Id of the shoppingCartConnection to be returned.</param>
        /// <returns>Task of ApiResponse (ShoppingCartConnection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShoppingCartConnection>> GetShoppingCartConnectionByIdAsyncWithHttpInfo (int? shoppingCartConnectionId)
        {
            // verify the required parameter 'shoppingCartConnectionId' is set
            if (shoppingCartConnectionId == null) throw new ApiException(400, "Missing required parameter 'shoppingCartConnectionId' when calling GetShoppingCartConnectionById");
            
    
            var localVarPath = "/beta/shoppingCartConnection/{shoppingCartConnectionId}";
    
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
            if (shoppingCartConnectionId != null) localVarPathParams.Add("shoppingCartConnectionId", Configuration.ApiClient.ParameterToString(shoppingCartConnectionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShoppingCartConnectionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ShoppingCartConnection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShoppingCartConnection) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShoppingCartConnection)));
            
        }
        
        /// <summary>
        /// Update a shoppingCartConnection Updates an existing shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param> 
        /// <returns></returns>
        public void UpdateShoppingCartConnection (ShoppingCartConnection body)
        {
             UpdateShoppingCartConnectionWithHttpInfo(body);
        }

        /// <summary>
        /// Update a shoppingCartConnection Updates an existing shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateShoppingCartConnectionWithHttpInfo (ShoppingCartConnection body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ShoppingCartConnectionApi->UpdateShoppingCartConnection");
            
    
            var localVarPath = "/beta/shoppingCartConnection";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnection: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a shoppingCartConnection Updates an existing shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateShoppingCartConnectionAsync (ShoppingCartConnection body)
        {
             await UpdateShoppingCartConnectionAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a shoppingCartConnection Updates an existing shoppingCartConnection using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateShoppingCartConnectionAsyncWithHttpInfo (ShoppingCartConnection body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateShoppingCartConnection");
            
    
            var localVarPath = "/beta/shoppingCartConnection";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnection: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnection: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a shoppingCartConnection custom fields Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param> 
        /// <returns></returns>
        public void UpdateShoppingCartConnectionCustomFields (ShoppingCartConnection body)
        {
             UpdateShoppingCartConnectionCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a shoppingCartConnection custom fields Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateShoppingCartConnectionCustomFieldsWithHttpInfo (ShoppingCartConnection body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ShoppingCartConnectionApi->UpdateShoppingCartConnectionCustomFields");
            
    
            var localVarPath = "/beta/shoppingCartConnection/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnectionCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnectionCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a shoppingCartConnection custom fields Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateShoppingCartConnectionCustomFieldsAsync (ShoppingCartConnection body)
        {
             await UpdateShoppingCartConnectionCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a shoppingCartConnection custom fields Updates an existing shoppingCartConnection custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ShoppingCartConnection to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateShoppingCartConnectionCustomFieldsAsyncWithHttpInfo (ShoppingCartConnection body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateShoppingCartConnectionCustomFields");
            
    
            var localVarPath = "/beta/shoppingCartConnection/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnectionCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateShoppingCartConnectionCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
