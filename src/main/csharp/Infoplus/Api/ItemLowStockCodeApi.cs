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
    public interface IItemLowStockCodeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search itemLowStockCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLowStockCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;ItemLowStockCode&gt;</returns>
        List<ItemLowStockCode> GetItemLowStockCodeBySearchText (string searchText = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Search itemLowStockCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLowStockCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemLowStockCode&gt;</returns>
        ApiResponse<List<ItemLowStockCode>> GetItemLowStockCodeBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemLowStockCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLowStockCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param>
        /// <returns>ItemLowStockCode</returns>
        ItemLowStockCode GetTranslateLowStockCodeById (string itemLowStockCodeId);
  
        /// <summary>
        /// Get an itemLowStockCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLowStockCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param>
        /// <returns>ApiResponse of ItemLowStockCode</returns>
        ApiResponse<ItemLowStockCode> GetTranslateLowStockCodeByIdWithHttpInfo (string itemLowStockCodeId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search itemLowStockCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLowStockCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemLowStockCode&gt;</returns>
        System.Threading.Tasks.Task<List<ItemLowStockCode>> GetItemLowStockCodeBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search itemLowStockCodes
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLowStockCodes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemLowStockCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemLowStockCode>>> GetItemLowStockCodeBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemLowStockCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLowStockCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param>
        /// <returns>Task of ItemLowStockCode</returns>
        System.Threading.Tasks.Task<ItemLowStockCode> GetTranslateLowStockCodeByIdAsync (string itemLowStockCodeId);

        /// <summary>
        /// Get an itemLowStockCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLowStockCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemLowStockCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemLowStockCode>> GetTranslateLowStockCodeByIdAsyncWithHttpInfo (string itemLowStockCodeId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemLowStockCodeApi : IItemLowStockCodeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLowStockCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemLowStockCodeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLowStockCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemLowStockCodeApi(Configuration configuration = null)
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
        /// Search itemLowStockCodes Returns the list of itemLowStockCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>List&lt;ItemLowStockCode&gt;</returns>
        public List<ItemLowStockCode> GetItemLowStockCodeBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemLowStockCode>> localVarResponse = GetItemLowStockCodeBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemLowStockCodes Returns the list of itemLowStockCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemLowStockCode&gt;</returns>
        public ApiResponse< List<ItemLowStockCode> > GetItemLowStockCodeBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/v1.0/itemLowStockCode/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemLowStockCodeBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemLowStockCodeBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemLowStockCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemLowStockCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemLowStockCode>)));
            
        }

        
        /// <summary>
        /// Search itemLowStockCodes Returns the list of itemLowStockCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemLowStockCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemLowStockCode>> GetItemLowStockCodeBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemLowStockCode>> localVarResponse = await GetItemLowStockCodeBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemLowStockCodes Returns the list of itemLowStockCodes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemLowStockCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemLowStockCode>>> GetItemLowStockCodeBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/v1.0/itemLowStockCode/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemLowStockCodeBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemLowStockCodeBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemLowStockCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemLowStockCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemLowStockCode>)));
            
        }
        
        /// <summary>
        /// Get an itemLowStockCode by id Returns the itemLowStockCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param> 
        /// <returns>ItemLowStockCode</returns>
        public ItemLowStockCode GetTranslateLowStockCodeById (string itemLowStockCodeId)
        {
             ApiResponse<ItemLowStockCode> localVarResponse = GetTranslateLowStockCodeByIdWithHttpInfo(itemLowStockCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemLowStockCode by id Returns the itemLowStockCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param> 
        /// <returns>ApiResponse of ItemLowStockCode</returns>
        public ApiResponse< ItemLowStockCode > GetTranslateLowStockCodeByIdWithHttpInfo (string itemLowStockCodeId)
        {
            
            // verify the required parameter 'itemLowStockCodeId' is set
            if (itemLowStockCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemLowStockCodeId' when calling ItemLowStockCodeApi->GetTranslateLowStockCodeById");
            
    
            var localVarPath = "/v1.0/itemLowStockCode/{itemLowStockCodeId}";
    
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
            if (itemLowStockCodeId != null) localVarPathParams.Add("itemLowStockCodeId", Configuration.ApiClient.ParameterToString(itemLowStockCodeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemLowStockCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemLowStockCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemLowStockCode)));
            
        }

        
        /// <summary>
        /// Get an itemLowStockCode by id Returns the itemLowStockCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param>
        /// <returns>Task of ItemLowStockCode</returns>
        public async System.Threading.Tasks.Task<ItemLowStockCode> GetTranslateLowStockCodeByIdAsync (string itemLowStockCodeId)
        {
             ApiResponse<ItemLowStockCode> localVarResponse = await GetTranslateLowStockCodeByIdAsyncWithHttpInfo(itemLowStockCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemLowStockCode by id Returns the itemLowStockCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLowStockCodeId">Id of itemLowStockCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemLowStockCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemLowStockCode>> GetTranslateLowStockCodeByIdAsyncWithHttpInfo (string itemLowStockCodeId)
        {
            // verify the required parameter 'itemLowStockCodeId' is set
            if (itemLowStockCodeId == null) throw new ApiException(400, "Missing required parameter 'itemLowStockCodeId' when calling GetTranslateLowStockCodeById");
            
    
            var localVarPath = "/v1.0/itemLowStockCode/{itemLowStockCodeId}";
    
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
            if (itemLowStockCodeId != null) localVarPathParams.Add("itemLowStockCodeId", Configuration.ApiClient.ParameterToString(itemLowStockCodeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemLowStockCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemLowStockCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemLowStockCode)));
            
        }
        
    }
    
}
