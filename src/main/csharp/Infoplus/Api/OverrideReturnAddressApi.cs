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
    public interface IOverrideReturnAddressApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Inserts a new overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param>
        /// <returns>OverrideReturnAddress</returns>
        OverrideReturnAddress AddOverrideReturnAddress (OverrideReturnAddress body);
  
        /// <summary>
        /// Create an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Inserts a new overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param>
        /// <returns>ApiResponse of OverrideReturnAddress</returns>
        ApiResponse<OverrideReturnAddress> AddOverrideReturnAddressWithHttpInfo (OverrideReturnAddress body);
        
        /// <summary>
        /// Delete an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Deletes the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param>
        /// <returns></returns>
        void DeleteOverrideReturnAddress (int? overrideReturnAddressId);
  
        /// <summary>
        /// Delete an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Deletes the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOverrideReturnAddressWithHttpInfo (int? overrideReturnAddressId);
        
        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param>
        /// <returns>OverrideReturnAddress</returns>
        OverrideReturnAddress GetDuplicateOverrideReturnAddressById (int? overrideReturnAddressId);
  
        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param>
        /// <returns>ApiResponse of OverrideReturnAddress</returns>
        ApiResponse<OverrideReturnAddress> GetDuplicateOverrideReturnAddressByIdWithHttpInfo (int? overrideReturnAddressId);
        
        /// <summary>
        /// Search overrideReturnAddresses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of overrideReturnAddresses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;OverrideReturnAddress&gt;</returns>
        List<OverrideReturnAddress> GetOverrideReturnAddressByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search overrideReturnAddresses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of overrideReturnAddresses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;OverrideReturnAddress&gt;</returns>
        ApiResponse<List<OverrideReturnAddress>> GetOverrideReturnAddressByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param>
        /// <returns>OverrideReturnAddress</returns>
        OverrideReturnAddress GetOverrideReturnAddressById (int? overrideReturnAddressId);
  
        /// <summary>
        /// Get an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param>
        /// <returns>ApiResponse of OverrideReturnAddress</returns>
        ApiResponse<OverrideReturnAddress> GetOverrideReturnAddressByIdWithHttpInfo (int? overrideReturnAddressId);
        
        /// <summary>
        /// Update an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns></returns>
        void UpdateOverrideReturnAddress (OverrideReturnAddress body);
  
        /// <summary>
        /// Update an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOverrideReturnAddressWithHttpInfo (OverrideReturnAddress body);
        
        /// <summary>
        /// Update an overrideReturnAddress custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns></returns>
        void UpdateOverrideReturnAddressCustomFields (OverrideReturnAddress body);
  
        /// <summary>
        /// Update an overrideReturnAddress custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOverrideReturnAddressCustomFieldsWithHttpInfo (OverrideReturnAddress body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Inserts a new overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param>
        /// <returns>Task of OverrideReturnAddress</returns>
        System.Threading.Tasks.Task<OverrideReturnAddress> AddOverrideReturnAddressAsync (OverrideReturnAddress body);

        /// <summary>
        /// Create an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Inserts a new overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param>
        /// <returns>Task of ApiResponse (OverrideReturnAddress)</returns>
        System.Threading.Tasks.Task<ApiResponse<OverrideReturnAddress>> AddOverrideReturnAddressAsyncWithHttpInfo (OverrideReturnAddress body);
        
        /// <summary>
        /// Delete an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Deletes the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOverrideReturnAddressAsync (int? overrideReturnAddressId);

        /// <summary>
        /// Delete an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Deletes the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOverrideReturnAddressAsyncWithHttpInfo (int? overrideReturnAddressId);
        
        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param>
        /// <returns>Task of OverrideReturnAddress</returns>
        System.Threading.Tasks.Task<OverrideReturnAddress> GetDuplicateOverrideReturnAddressByIdAsync (int? overrideReturnAddressId);

        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param>
        /// <returns>Task of ApiResponse (OverrideReturnAddress)</returns>
        System.Threading.Tasks.Task<ApiResponse<OverrideReturnAddress>> GetDuplicateOverrideReturnAddressByIdAsyncWithHttpInfo (int? overrideReturnAddressId);
        
        /// <summary>
        /// Search overrideReturnAddresses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of overrideReturnAddresses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OverrideReturnAddress&gt;</returns>
        System.Threading.Tasks.Task<List<OverrideReturnAddress>> GetOverrideReturnAddressByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search overrideReturnAddresses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of overrideReturnAddresses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OverrideReturnAddress&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OverrideReturnAddress>>> GetOverrideReturnAddressByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param>
        /// <returns>Task of OverrideReturnAddress</returns>
        System.Threading.Tasks.Task<OverrideReturnAddress> GetOverrideReturnAddressByIdAsync (int? overrideReturnAddressId);

        /// <summary>
        /// Get an overrideReturnAddress by id
        /// </summary>
        /// <remarks>
        /// Returns the overrideReturnAddress identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param>
        /// <returns>Task of ApiResponse (OverrideReturnAddress)</returns>
        System.Threading.Tasks.Task<ApiResponse<OverrideReturnAddress>> GetOverrideReturnAddressByIdAsyncWithHttpInfo (int? overrideReturnAddressId);
        
        /// <summary>
        /// Update an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOverrideReturnAddressAsync (OverrideReturnAddress body);

        /// <summary>
        /// Update an overrideReturnAddress
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOverrideReturnAddressAsyncWithHttpInfo (OverrideReturnAddress body);
        
        /// <summary>
        /// Update an overrideReturnAddress custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOverrideReturnAddressCustomFieldsAsync (OverrideReturnAddress body);

        /// <summary>
        /// Update an overrideReturnAddress custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOverrideReturnAddressCustomFieldsAsyncWithHttpInfo (OverrideReturnAddress body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OverrideReturnAddressApi : IOverrideReturnAddressApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideReturnAddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OverrideReturnAddressApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OverrideReturnAddressApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OverrideReturnAddressApi(Configuration configuration = null)
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
        /// Create an overrideReturnAddress Inserts a new overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param> 
        /// <returns>OverrideReturnAddress</returns>
        public OverrideReturnAddress AddOverrideReturnAddress (OverrideReturnAddress body)
        {
             ApiResponse<OverrideReturnAddress> localVarResponse = AddOverrideReturnAddressWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an overrideReturnAddress Inserts a new overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param> 
        /// <returns>ApiResponse of OverrideReturnAddress</returns>
        public ApiResponse< OverrideReturnAddress > AddOverrideReturnAddressWithHttpInfo (OverrideReturnAddress body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OverrideReturnAddressApi->AddOverrideReturnAddress");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOverrideReturnAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOverrideReturnAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OverrideReturnAddress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OverrideReturnAddress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverrideReturnAddress)));
            
        }

        
        /// <summary>
        /// Create an overrideReturnAddress Inserts a new overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param>
        /// <returns>Task of OverrideReturnAddress</returns>
        public async System.Threading.Tasks.Task<OverrideReturnAddress> AddOverrideReturnAddressAsync (OverrideReturnAddress body)
        {
             ApiResponse<OverrideReturnAddress> localVarResponse = await AddOverrideReturnAddressAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an overrideReturnAddress Inserts a new overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be inserted.</param>
        /// <returns>Task of ApiResponse (OverrideReturnAddress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OverrideReturnAddress>> AddOverrideReturnAddressAsyncWithHttpInfo (OverrideReturnAddress body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOverrideReturnAddress");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOverrideReturnAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOverrideReturnAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OverrideReturnAddress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OverrideReturnAddress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverrideReturnAddress)));
            
        }
        
        /// <summary>
        /// Delete an overrideReturnAddress Deletes the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param> 
        /// <returns></returns>
        public void DeleteOverrideReturnAddress (int? overrideReturnAddressId)
        {
             DeleteOverrideReturnAddressWithHttpInfo(overrideReturnAddressId);
        }

        /// <summary>
        /// Delete an overrideReturnAddress Deletes the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOverrideReturnAddressWithHttpInfo (int? overrideReturnAddressId)
        {
            
            // verify the required parameter 'overrideReturnAddressId' is set
            if (overrideReturnAddressId == null)
                throw new ApiException(400, "Missing required parameter 'overrideReturnAddressId' when calling OverrideReturnAddressApi->DeleteOverrideReturnAddress");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/{overrideReturnAddressId}";
    
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
            if (overrideReturnAddressId != null) localVarPathParams.Add("overrideReturnAddressId", Configuration.ApiClient.ParameterToString(overrideReturnAddressId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOverrideReturnAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOverrideReturnAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an overrideReturnAddress Deletes the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOverrideReturnAddressAsync (int? overrideReturnAddressId)
        {
             await DeleteOverrideReturnAddressAsyncWithHttpInfo(overrideReturnAddressId);

        }

        /// <summary>
        /// Delete an overrideReturnAddress Deletes the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOverrideReturnAddressAsyncWithHttpInfo (int? overrideReturnAddressId)
        {
            // verify the required parameter 'overrideReturnAddressId' is set
            if (overrideReturnAddressId == null) throw new ApiException(400, "Missing required parameter 'overrideReturnAddressId' when calling DeleteOverrideReturnAddress");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/{overrideReturnAddressId}";
    
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
            if (overrideReturnAddressId != null) localVarPathParams.Add("overrideReturnAddressId", Configuration.ApiClient.ParameterToString(overrideReturnAddressId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOverrideReturnAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOverrideReturnAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param> 
        /// <returns>OverrideReturnAddress</returns>
        public OverrideReturnAddress GetDuplicateOverrideReturnAddressById (int? overrideReturnAddressId)
        {
             ApiResponse<OverrideReturnAddress> localVarResponse = GetDuplicateOverrideReturnAddressByIdWithHttpInfo(overrideReturnAddressId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param> 
        /// <returns>ApiResponse of OverrideReturnAddress</returns>
        public ApiResponse< OverrideReturnAddress > GetDuplicateOverrideReturnAddressByIdWithHttpInfo (int? overrideReturnAddressId)
        {
            
            // verify the required parameter 'overrideReturnAddressId' is set
            if (overrideReturnAddressId == null)
                throw new ApiException(400, "Missing required parameter 'overrideReturnAddressId' when calling OverrideReturnAddressApi->GetDuplicateOverrideReturnAddressById");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/duplicate/{overrideReturnAddressId}";
    
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
            if (overrideReturnAddressId != null) localVarPathParams.Add("overrideReturnAddressId", Configuration.ApiClient.ParameterToString(overrideReturnAddressId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOverrideReturnAddressById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOverrideReturnAddressById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OverrideReturnAddress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OverrideReturnAddress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverrideReturnAddress)));
            
        }

        
        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param>
        /// <returns>Task of OverrideReturnAddress</returns>
        public async System.Threading.Tasks.Task<OverrideReturnAddress> GetDuplicateOverrideReturnAddressByIdAsync (int? overrideReturnAddressId)
        {
             ApiResponse<OverrideReturnAddress> localVarResponse = await GetDuplicateOverrideReturnAddressByIdAsyncWithHttpInfo(overrideReturnAddressId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an overrideReturnAddress by id Returns a duplicated overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be duplicated.</param>
        /// <returns>Task of ApiResponse (OverrideReturnAddress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OverrideReturnAddress>> GetDuplicateOverrideReturnAddressByIdAsyncWithHttpInfo (int? overrideReturnAddressId)
        {
            // verify the required parameter 'overrideReturnAddressId' is set
            if (overrideReturnAddressId == null) throw new ApiException(400, "Missing required parameter 'overrideReturnAddressId' when calling GetDuplicateOverrideReturnAddressById");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/duplicate/{overrideReturnAddressId}";
    
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
            if (overrideReturnAddressId != null) localVarPathParams.Add("overrideReturnAddressId", Configuration.ApiClient.ParameterToString(overrideReturnAddressId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOverrideReturnAddressById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOverrideReturnAddressById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OverrideReturnAddress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OverrideReturnAddress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverrideReturnAddress)));
            
        }
        
        /// <summary>
        /// Search overrideReturnAddresses by filter Returns the list of overrideReturnAddresses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;OverrideReturnAddress&gt;</returns>
        public List<OverrideReturnAddress> GetOverrideReturnAddressByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OverrideReturnAddress>> localVarResponse = GetOverrideReturnAddressByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search overrideReturnAddresses by filter Returns the list of overrideReturnAddresses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;OverrideReturnAddress&gt;</returns>
        public ApiResponse< List<OverrideReturnAddress> > GetOverrideReturnAddressByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<OverrideReturnAddress>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OverrideReturnAddress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OverrideReturnAddress>)));
            
        }

        
        /// <summary>
        /// Search overrideReturnAddresses by filter Returns the list of overrideReturnAddresses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OverrideReturnAddress&gt;</returns>
        public async System.Threading.Tasks.Task<List<OverrideReturnAddress>> GetOverrideReturnAddressByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OverrideReturnAddress>> localVarResponse = await GetOverrideReturnAddressByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search overrideReturnAddresses by filter Returns the list of overrideReturnAddresses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OverrideReturnAddress&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OverrideReturnAddress>>> GetOverrideReturnAddressByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OverrideReturnAddress>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OverrideReturnAddress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OverrideReturnAddress>)));
            
        }
        
        /// <summary>
        /// Get an overrideReturnAddress by id Returns the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param> 
        /// <returns>OverrideReturnAddress</returns>
        public OverrideReturnAddress GetOverrideReturnAddressById (int? overrideReturnAddressId)
        {
             ApiResponse<OverrideReturnAddress> localVarResponse = GetOverrideReturnAddressByIdWithHttpInfo(overrideReturnAddressId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an overrideReturnAddress by id Returns the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param> 
        /// <returns>ApiResponse of OverrideReturnAddress</returns>
        public ApiResponse< OverrideReturnAddress > GetOverrideReturnAddressByIdWithHttpInfo (int? overrideReturnAddressId)
        {
            
            // verify the required parameter 'overrideReturnAddressId' is set
            if (overrideReturnAddressId == null)
                throw new ApiException(400, "Missing required parameter 'overrideReturnAddressId' when calling OverrideReturnAddressApi->GetOverrideReturnAddressById");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/{overrideReturnAddressId}";
    
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
            if (overrideReturnAddressId != null) localVarPathParams.Add("overrideReturnAddressId", Configuration.ApiClient.ParameterToString(overrideReturnAddressId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OverrideReturnAddress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OverrideReturnAddress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverrideReturnAddress)));
            
        }

        
        /// <summary>
        /// Get an overrideReturnAddress by id Returns the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param>
        /// <returns>Task of OverrideReturnAddress</returns>
        public async System.Threading.Tasks.Task<OverrideReturnAddress> GetOverrideReturnAddressByIdAsync (int? overrideReturnAddressId)
        {
             ApiResponse<OverrideReturnAddress> localVarResponse = await GetOverrideReturnAddressByIdAsyncWithHttpInfo(overrideReturnAddressId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an overrideReturnAddress by id Returns the overrideReturnAddress identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="overrideReturnAddressId">Id of the overrideReturnAddress to be returned.</param>
        /// <returns>Task of ApiResponse (OverrideReturnAddress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OverrideReturnAddress>> GetOverrideReturnAddressByIdAsyncWithHttpInfo (int? overrideReturnAddressId)
        {
            // verify the required parameter 'overrideReturnAddressId' is set
            if (overrideReturnAddressId == null) throw new ApiException(400, "Missing required parameter 'overrideReturnAddressId' when calling GetOverrideReturnAddressById");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/{overrideReturnAddressId}";
    
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
            if (overrideReturnAddressId != null) localVarPathParams.Add("overrideReturnAddressId", Configuration.ApiClient.ParameterToString(overrideReturnAddressId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOverrideReturnAddressById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OverrideReturnAddress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OverrideReturnAddress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverrideReturnAddress)));
            
        }
        
        /// <summary>
        /// Update an overrideReturnAddress Updates an existing overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param> 
        /// <returns></returns>
        public void UpdateOverrideReturnAddress (OverrideReturnAddress body)
        {
             UpdateOverrideReturnAddressWithHttpInfo(body);
        }

        /// <summary>
        /// Update an overrideReturnAddress Updates an existing overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOverrideReturnAddressWithHttpInfo (OverrideReturnAddress body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OverrideReturnAddressApi->UpdateOverrideReturnAddress");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an overrideReturnAddress Updates an existing overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOverrideReturnAddressAsync (OverrideReturnAddress body)
        {
             await UpdateOverrideReturnAddressAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an overrideReturnAddress Updates an existing overrideReturnAddress using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOverrideReturnAddressAsyncWithHttpInfo (OverrideReturnAddress body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOverrideReturnAddress");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an overrideReturnAddress custom fields Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param> 
        /// <returns></returns>
        public void UpdateOverrideReturnAddressCustomFields (OverrideReturnAddress body)
        {
             UpdateOverrideReturnAddressCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an overrideReturnAddress custom fields Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOverrideReturnAddressCustomFieldsWithHttpInfo (OverrideReturnAddress body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OverrideReturnAddressApi->UpdateOverrideReturnAddressCustomFields");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddressCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddressCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an overrideReturnAddress custom fields Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOverrideReturnAddressCustomFieldsAsync (OverrideReturnAddress body)
        {
             await UpdateOverrideReturnAddressCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an overrideReturnAddress custom fields Updates an existing overrideReturnAddress custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OverrideReturnAddress to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOverrideReturnAddressCustomFieldsAsyncWithHttpInfo (OverrideReturnAddress body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOverrideReturnAddressCustomFields");
            
    
            var localVarPath = "/v2.0/overrideReturnAddress/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddressCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOverrideReturnAddressCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
