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
    public interface IThirdPartyParcelAccountApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>ThirdPartyParcelAccount</returns>
        ThirdPartyParcelAccount AddThirdPartyParcelAccount (ThirdPartyParcelAccount body);
  
        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        ApiResponse<ThirdPartyParcelAccount> AddThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body);
        
        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns></returns>
        void DeleteThirdPartyParcelAccount (int? thirdPartyParcelAccountId);
  
        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteThirdPartyParcelAccountWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ThirdPartyParcelAccount&gt;</returns>
        List<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ThirdPartyParcelAccount&gt;</returns>
        ApiResponse<List<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>ThirdPartyParcelAccount</returns>
        ThirdPartyParcelAccount GetThirdPartyParcelAccountById (int? thirdPartyParcelAccountId);
  
        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        ApiResponse<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByIdWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns></returns>
        void UpdateThirdPartyParcelAccount (ThirdPartyParcelAccount body);
  
        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        System.Threading.Tasks.Task<ThirdPartyParcelAccount> AddThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body);

        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> AddThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body);
        
        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteThirdPartyParcelAccountAsync (int? thirdPartyParcelAccountId);

        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteThirdPartyParcelAccountAsyncWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ThirdPartyParcelAccount&gt;</returns>
        System.Threading.Tasks.Task<List<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ThirdPartyParcelAccount&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ThirdPartyParcelAccount>>> GetThirdPartyParcelAccountByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        System.Threading.Tasks.Task<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByIdAsync (int? thirdPartyParcelAccountId);

        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByIdAsyncWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body);

        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ThirdPartyParcelAccountApi : IThirdPartyParcelAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParcelAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ThirdPartyParcelAccountApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParcelAccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ThirdPartyParcelAccountApi(Configuration configuration = null)
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
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param> 
        /// <returns>ThirdPartyParcelAccount</returns>
        public ThirdPartyParcelAccount AddThirdPartyParcelAccount (ThirdPartyParcelAccount body)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = AddThirdPartyParcelAccountWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param> 
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        public ApiResponse< ThirdPartyParcelAccount > AddThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThirdPartyParcelAccountApi->AddThirdPartyParcelAccount");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }

        
        /// <summary>
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        public async System.Threading.Tasks.Task<ThirdPartyParcelAccount> AddThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = await AddThirdPartyParcelAccountAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> AddThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddThirdPartyParcelAccount");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }
        
        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param> 
        /// <returns></returns>
        public void DeleteThirdPartyParcelAccount (int? thirdPartyParcelAccountId)
        {
             DeleteThirdPartyParcelAccountWithHttpInfo(thirdPartyParcelAccountId);
        }

        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteThirdPartyParcelAccountWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->DeleteThirdPartyParcelAccount");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
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
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteThirdPartyParcelAccountAsync (int? thirdPartyParcelAccountId)
        {
             await DeleteThirdPartyParcelAccountAsyncWithHttpInfo(thirdPartyParcelAccountId);

        }

        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteThirdPartyParcelAccountAsyncWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling DeleteThirdPartyParcelAccount");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
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
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ThirdPartyParcelAccount&gt;</returns>
        public List<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ThirdPartyParcelAccount>> localVarResponse = GetThirdPartyParcelAccountByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ThirdPartyParcelAccount&gt;</returns>
        public ApiResponse< List<ThirdPartyParcelAccount> > GetThirdPartyParcelAccountByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ThirdPartyParcelAccount>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ThirdPartyParcelAccount>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ThirdPartyParcelAccount>)));
            
        }

        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ThirdPartyParcelAccount&gt;</returns>
        public async System.Threading.Tasks.Task<List<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ThirdPartyParcelAccount>> localVarResponse = await GetThirdPartyParcelAccountByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ThirdPartyParcelAccount&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ThirdPartyParcelAccount>>> GetThirdPartyParcelAccountByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ThirdPartyParcelAccount>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ThirdPartyParcelAccount>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ThirdPartyParcelAccount>)));
            
        }
        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param> 
        /// <returns>ThirdPartyParcelAccount</returns>
        public ThirdPartyParcelAccount GetThirdPartyParcelAccountById (int? thirdPartyParcelAccountId)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = GetThirdPartyParcelAccountByIdWithHttpInfo(thirdPartyParcelAccountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param> 
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        public ApiResponse< ThirdPartyParcelAccount > GetThirdPartyParcelAccountByIdWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->GetThirdPartyParcelAccountById");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
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
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }

        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        public async System.Threading.Tasks.Task<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByIdAsync (int? thirdPartyParcelAccountId)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = await GetThirdPartyParcelAccountByIdAsyncWithHttpInfo(thirdPartyParcelAccountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByIdAsyncWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling GetThirdPartyParcelAccountById");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
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
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }
        
        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param> 
        /// <returns></returns>
        public void UpdateThirdPartyParcelAccount (ThirdPartyParcelAccount body)
        {
             UpdateThirdPartyParcelAccountWithHttpInfo(body);
        }

        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThirdPartyParcelAccountApi->UpdateThirdPartyParcelAccount");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body)
        {
             await UpdateThirdPartyParcelAccountAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateThirdPartyParcelAccount");
            
    
            var localVarPath = "/v1.0/thirdPartyParcelAccount";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
