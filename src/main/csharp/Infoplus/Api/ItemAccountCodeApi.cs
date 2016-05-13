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
    public interface IItemAccountCodeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search itemAccountCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;ItemAccountCode&gt;</returns>
        List<ItemAccountCode> GetItemAccountCodeBySearchText (string searchText = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Search itemAccountCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemAccountCode&gt;</returns>
        ApiResponse<List<ItemAccountCode>> GetItemAccountCodeBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param>
        /// <returns>ItemAccountCode</returns>
        ItemAccountCode GetTranslateAccountCodeById (string itemAccountCodeId);
  
        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param>
        /// <returns>ApiResponse of ItemAccountCode</returns>
        ApiResponse<ItemAccountCode> GetTranslateAccountCodeByIdWithHttpInfo (string itemAccountCodeId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search itemAccountCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemAccountCode&gt;</returns>
        System.Threading.Tasks.Task<List<ItemAccountCode>> GetItemAccountCodeBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search itemAccountCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemAccountCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemAccountCode>>> GetItemAccountCodeBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param>
        /// <returns>Task of ItemAccountCode</returns>
        System.Threading.Tasks.Task<ItemAccountCode> GetTranslateAccountCodeByIdAsync (string itemAccountCodeId);

        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> GetTranslateAccountCodeByIdAsyncWithHttpInfo (string itemAccountCodeId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemAccountCodeApi : IItemAccountCodeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAccountCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemAccountCodeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAccountCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemAccountCodeApi(Configuration configuration = null)
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
        /// Search itemAccountCodes Returns the list of itemAccountCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>List&lt;ItemAccountCode&gt;</returns>
        public List<ItemAccountCode> GetItemAccountCodeBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemAccountCode>> localVarResponse = GetItemAccountCodeBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemAccountCodes Returns the list of itemAccountCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemAccountCode&gt;</returns>
        public ApiResponse< List<ItemAccountCode> > GetItemAccountCodeBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/v1.0/itemAccountCode/search";
    
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
            
            if (searchText != null) localVarQueryParams.Add("searchText", Configuration.ApiClient.ParameterToString(searchText)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemAccountCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemAccountCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemAccountCode>)));
            
        }

        
        /// <summary>
        /// Search itemAccountCodes Returns the list of itemAccountCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemAccountCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemAccountCode>> GetItemAccountCodeBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemAccountCode>> localVarResponse = await GetItemAccountCodeBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemAccountCodes Returns the list of itemAccountCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemAccountCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemAccountCode>>> GetItemAccountCodeBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/v1.0/itemAccountCode/search";
    
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
            
            if (searchText != null) localVarQueryParams.Add("searchText", Configuration.ApiClient.ParameterToString(searchText)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemAccountCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemAccountCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemAccountCode>)));
            
        }
        
        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param> 
        /// <returns>ItemAccountCode</returns>
        public ItemAccountCode GetTranslateAccountCodeById (string itemAccountCodeId)
        {
             ApiResponse<ItemAccountCode> localVarResponse = GetTranslateAccountCodeByIdWithHttpInfo(itemAccountCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param> 
        /// <returns>ApiResponse of ItemAccountCode</returns>
        public ApiResponse< ItemAccountCode > GetTranslateAccountCodeByIdWithHttpInfo (string itemAccountCodeId)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->GetTranslateAccountCodeById");
            
    
            var localVarPath = "/v1.0/itemAccountCode/{itemAccountCodeId}";
    
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
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateAccountCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateAccountCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }

        
        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param>
        /// <returns>Task of ItemAccountCode</returns>
        public async System.Threading.Tasks.Task<ItemAccountCode> GetTranslateAccountCodeByIdAsync (string itemAccountCodeId)
        {
             ApiResponse<ItemAccountCode> localVarResponse = await GetTranslateAccountCodeByIdAsyncWithHttpInfo(itemAccountCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of itemAccountCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> GetTranslateAccountCodeByIdAsyncWithHttpInfo (string itemAccountCodeId)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling GetTranslateAccountCodeById");
            
    
            var localVarPath = "/v1.0/itemAccountCode/{itemAccountCodeId}";
    
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
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateAccountCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateAccountCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }
        
    }
    
}
