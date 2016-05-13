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
    public interface IItemLegacyLowStockContactApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search itemLegacyLowStockContacts
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;ItemLegacyLowStockContact&gt;</returns>
        List<ItemLegacyLowStockContact> GetItemLegacyLowStockContactBySearchText (string searchText = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Search itemLegacyLowStockContacts
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemLegacyLowStockContact&gt;</returns>
        ApiResponse<List<ItemLegacyLowStockContact>> GetItemLegacyLowStockContactBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemLegacyLowStockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLegacyLowStockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param>
        /// <returns>ItemLegacyLowStockContact</returns>
        ItemLegacyLowStockContact GetTranslateLowStockContactById (string itemLegacyLowStockContactId);
  
        /// <summary>
        /// Get an itemLegacyLowStockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLegacyLowStockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param>
        /// <returns>ApiResponse of ItemLegacyLowStockContact</returns>
        ApiResponse<ItemLegacyLowStockContact> GetTranslateLowStockContactByIdWithHttpInfo (string itemLegacyLowStockContactId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search itemLegacyLowStockContacts
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemLegacyLowStockContact&gt;</returns>
        System.Threading.Tasks.Task<List<ItemLegacyLowStockContact>> GetItemLegacyLowStockContactBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search itemLegacyLowStockContacts
        /// </summary>
        /// <remarks>
        /// Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemLegacyLowStockContact&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemLegacyLowStockContact>>> GetItemLegacyLowStockContactBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemLegacyLowStockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLegacyLowStockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param>
        /// <returns>Task of ItemLegacyLowStockContact</returns>
        System.Threading.Tasks.Task<ItemLegacyLowStockContact> GetTranslateLowStockContactByIdAsync (string itemLegacyLowStockContactId);

        /// <summary>
        /// Get an itemLegacyLowStockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the itemLegacyLowStockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param>
        /// <returns>Task of ApiResponse (ItemLegacyLowStockContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemLegacyLowStockContact>> GetTranslateLowStockContactByIdAsyncWithHttpInfo (string itemLegacyLowStockContactId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemLegacyLowStockContactApi : IItemLegacyLowStockContactApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLegacyLowStockContactApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemLegacyLowStockContactApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLegacyLowStockContactApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemLegacyLowStockContactApi(Configuration configuration = null)
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
        /// Search itemLegacyLowStockContacts Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>List&lt;ItemLegacyLowStockContact&gt;</returns>
        public List<ItemLegacyLowStockContact> GetItemLegacyLowStockContactBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemLegacyLowStockContact>> localVarResponse = GetItemLegacyLowStockContactBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemLegacyLowStockContacts Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemLegacyLowStockContact&gt;</returns>
        public ApiResponse< List<ItemLegacyLowStockContact> > GetItemLegacyLowStockContactBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/v1.0/itemLegacyLowStockContact/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemLegacyLowStockContactBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemLegacyLowStockContactBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemLegacyLowStockContact>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemLegacyLowStockContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemLegacyLowStockContact>)));
            
        }

        
        /// <summary>
        /// Search itemLegacyLowStockContacts Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemLegacyLowStockContact&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemLegacyLowStockContact>> GetItemLegacyLowStockContactBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemLegacyLowStockContact>> localVarResponse = await GetItemLegacyLowStockContactBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemLegacyLowStockContacts Returns the list of itemLegacyLowStockContacts that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemLegacyLowStockContact&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemLegacyLowStockContact>>> GetItemLegacyLowStockContactBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/v1.0/itemLegacyLowStockContact/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemLegacyLowStockContactBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemLegacyLowStockContactBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemLegacyLowStockContact>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemLegacyLowStockContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemLegacyLowStockContact>)));
            
        }
        
        /// <summary>
        /// Get an itemLegacyLowStockContact by id Returns the itemLegacyLowStockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param> 
        /// <returns>ItemLegacyLowStockContact</returns>
        public ItemLegacyLowStockContact GetTranslateLowStockContactById (string itemLegacyLowStockContactId)
        {
             ApiResponse<ItemLegacyLowStockContact> localVarResponse = GetTranslateLowStockContactByIdWithHttpInfo(itemLegacyLowStockContactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemLegacyLowStockContact by id Returns the itemLegacyLowStockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param> 
        /// <returns>ApiResponse of ItemLegacyLowStockContact</returns>
        public ApiResponse< ItemLegacyLowStockContact > GetTranslateLowStockContactByIdWithHttpInfo (string itemLegacyLowStockContactId)
        {
            
            // verify the required parameter 'itemLegacyLowStockContactId' is set
            if (itemLegacyLowStockContactId == null)
                throw new ApiException(400, "Missing required parameter 'itemLegacyLowStockContactId' when calling ItemLegacyLowStockContactApi->GetTranslateLowStockContactById");
            
    
            var localVarPath = "/v1.0/itemLegacyLowStockContact/{itemLegacyLowStockContactId}";
    
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
            if (itemLegacyLowStockContactId != null) localVarPathParams.Add("itemLegacyLowStockContactId", Configuration.ApiClient.ParameterToString(itemLegacyLowStockContactId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockContactById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockContactById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemLegacyLowStockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemLegacyLowStockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemLegacyLowStockContact)));
            
        }

        
        /// <summary>
        /// Get an itemLegacyLowStockContact by id Returns the itemLegacyLowStockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param>
        /// <returns>Task of ItemLegacyLowStockContact</returns>
        public async System.Threading.Tasks.Task<ItemLegacyLowStockContact> GetTranslateLowStockContactByIdAsync (string itemLegacyLowStockContactId)
        {
             ApiResponse<ItemLegacyLowStockContact> localVarResponse = await GetTranslateLowStockContactByIdAsyncWithHttpInfo(itemLegacyLowStockContactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemLegacyLowStockContact by id Returns the itemLegacyLowStockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemLegacyLowStockContactId">Id of itemLegacyLowStockContact to be returned.</param>
        /// <returns>Task of ApiResponse (ItemLegacyLowStockContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemLegacyLowStockContact>> GetTranslateLowStockContactByIdAsyncWithHttpInfo (string itemLegacyLowStockContactId)
        {
            // verify the required parameter 'itemLegacyLowStockContactId' is set
            if (itemLegacyLowStockContactId == null) throw new ApiException(400, "Missing required parameter 'itemLegacyLowStockContactId' when calling GetTranslateLowStockContactById");
            
    
            var localVarPath = "/v1.0/itemLegacyLowStockContact/{itemLegacyLowStockContactId}";
    
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
            if (itemLegacyLowStockContactId != null) localVarPathParams.Add("itemLegacyLowStockContactId", Configuration.ApiClient.ParameterToString(itemLegacyLowStockContactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockContactById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateLowStockContactById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemLegacyLowStockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemLegacyLowStockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemLegacyLowStockContact)));
            
        }
        
    }
    
}
