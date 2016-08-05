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
    public interface IItemMajorGroupApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search itemMajorGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of itemMajorGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;ItemMajorGroup&gt;</returns>
        List<ItemMajorGroup> GetItemMajorGroupBySearchText (string searchText = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Search itemMajorGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of itemMajorGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemMajorGroup&gt;</returns>
        ApiResponse<List<ItemMajorGroup>> GetItemMajorGroupBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemMajorGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the itemMajorGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param>
        /// <returns>ItemMajorGroup</returns>
        ItemMajorGroup GetTranslateMajorGroupById (string itemMajorGroupId);
  
        /// <summary>
        /// Get an itemMajorGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the itemMajorGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param>
        /// <returns>ApiResponse of ItemMajorGroup</returns>
        ApiResponse<ItemMajorGroup> GetTranslateMajorGroupByIdWithHttpInfo (string itemMajorGroupId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search itemMajorGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of itemMajorGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemMajorGroup&gt;</returns>
        System.Threading.Tasks.Task<List<ItemMajorGroup>> GetItemMajorGroupBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search itemMajorGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of itemMajorGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemMajorGroup&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemMajorGroup>>> GetItemMajorGroupBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Get an itemMajorGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the itemMajorGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param>
        /// <returns>Task of ItemMajorGroup</returns>
        System.Threading.Tasks.Task<ItemMajorGroup> GetTranslateMajorGroupByIdAsync (string itemMajorGroupId);

        /// <summary>
        /// Get an itemMajorGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the itemMajorGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param>
        /// <returns>Task of ApiResponse (ItemMajorGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemMajorGroup>> GetTranslateMajorGroupByIdAsyncWithHttpInfo (string itemMajorGroupId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemMajorGroupApi : IItemMajorGroupApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemMajorGroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemMajorGroupApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemMajorGroupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemMajorGroupApi(Configuration configuration = null)
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
        /// Search itemMajorGroups Returns the list of itemMajorGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>List&lt;ItemMajorGroup&gt;</returns>
        public List<ItemMajorGroup> GetItemMajorGroupBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemMajorGroup>> localVarResponse = GetItemMajorGroupBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemMajorGroups Returns the list of itemMajorGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemMajorGroup&gt;</returns>
        public ApiResponse< List<ItemMajorGroup> > GetItemMajorGroupBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/itemMajorGroup/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemMajorGroupBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemMajorGroupBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemMajorGroup>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemMajorGroup>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemMajorGroup>)));
            
        }

        
        /// <summary>
        /// Search itemMajorGroups Returns the list of itemMajorGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;ItemMajorGroup&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemMajorGroup>> GetItemMajorGroupBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<ItemMajorGroup>> localVarResponse = await GetItemMajorGroupBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemMajorGroups Returns the list of itemMajorGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemMajorGroup&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemMajorGroup>>> GetItemMajorGroupBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/itemMajorGroup/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetItemMajorGroupBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemMajorGroupBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemMajorGroup>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemMajorGroup>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemMajorGroup>)));
            
        }
        
        /// <summary>
        /// Get an itemMajorGroup by id Returns the itemMajorGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param> 
        /// <returns>ItemMajorGroup</returns>
        public ItemMajorGroup GetTranslateMajorGroupById (string itemMajorGroupId)
        {
             ApiResponse<ItemMajorGroup> localVarResponse = GetTranslateMajorGroupByIdWithHttpInfo(itemMajorGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemMajorGroup by id Returns the itemMajorGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param> 
        /// <returns>ApiResponse of ItemMajorGroup</returns>
        public ApiResponse< ItemMajorGroup > GetTranslateMajorGroupByIdWithHttpInfo (string itemMajorGroupId)
        {
            
            // verify the required parameter 'itemMajorGroupId' is set
            if (itemMajorGroupId == null)
                throw new ApiException(400, "Missing required parameter 'itemMajorGroupId' when calling ItemMajorGroupApi->GetTranslateMajorGroupById");
            
    
            var localVarPath = "/beta/itemMajorGroup/{itemMajorGroupId}";
    
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
            if (itemMajorGroupId != null) localVarPathParams.Add("itemMajorGroupId", Configuration.ApiClient.ParameterToString(itemMajorGroupId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateMajorGroupById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateMajorGroupById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemMajorGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemMajorGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemMajorGroup)));
            
        }

        
        /// <summary>
        /// Get an itemMajorGroup by id Returns the itemMajorGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param>
        /// <returns>Task of ItemMajorGroup</returns>
        public async System.Threading.Tasks.Task<ItemMajorGroup> GetTranslateMajorGroupByIdAsync (string itemMajorGroupId)
        {
             ApiResponse<ItemMajorGroup> localVarResponse = await GetTranslateMajorGroupByIdAsyncWithHttpInfo(itemMajorGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemMajorGroup by id Returns the itemMajorGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemMajorGroupId">Id of itemMajorGroup to be returned.</param>
        /// <returns>Task of ApiResponse (ItemMajorGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemMajorGroup>> GetTranslateMajorGroupByIdAsyncWithHttpInfo (string itemMajorGroupId)
        {
            // verify the required parameter 'itemMajorGroupId' is set
            if (itemMajorGroupId == null) throw new ApiException(400, "Missing required parameter 'itemMajorGroupId' when calling GetTranslateMajorGroupById");
            
    
            var localVarPath = "/beta/itemMajorGroup/{itemMajorGroupId}";
    
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
            if (itemMajorGroupId != null) localVarPathParams.Add("itemMajorGroupId", Configuration.ApiClient.ParameterToString(itemMajorGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateMajorGroupById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetTranslateMajorGroupById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemMajorGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemMajorGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemMajorGroup)));
            
        }
        
    }
    
}
