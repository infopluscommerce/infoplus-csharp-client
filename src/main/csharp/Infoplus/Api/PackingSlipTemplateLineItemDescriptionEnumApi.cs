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
    public interface IPackingSlipTemplateLineItemDescriptionEnumApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id
        /// </summary>
        /// <remarks>
        /// Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param>
        /// <returns>PackingSlipTemplateLineItemDescriptionEnum</returns>
        PackingSlipTemplateLineItemDescriptionEnum GetPackingSlipTemplateLineItemDescriptionEnumById (string packingSlipTemplateLineItemDescriptionEnumId);
  
        /// <summary>
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id
        /// </summary>
        /// <remarks>
        /// Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param>
        /// <returns>ApiResponse of PackingSlipTemplateLineItemDescriptionEnum</returns>
        ApiResponse<PackingSlipTemplateLineItemDescriptionEnum> GetPackingSlipTemplateLineItemDescriptionEnumByIdWithHttpInfo (string packingSlipTemplateLineItemDescriptionEnumId);
        
        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums
        /// </summary>
        /// <remarks>
        /// Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;</returns>
        List<PackingSlipTemplateLineItemDescriptionEnum> GetPackingSlipTemplateLineItemDescriptionEnumBySearchText (string searchText = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums
        /// </summary>
        /// <remarks>
        /// Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;</returns>
        ApiResponse<List<PackingSlipTemplateLineItemDescriptionEnum>> GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id
        /// </summary>
        /// <remarks>
        /// Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param>
        /// <returns>Task of PackingSlipTemplateLineItemDescriptionEnum</returns>
        System.Threading.Tasks.Task<PackingSlipTemplateLineItemDescriptionEnum> GetPackingSlipTemplateLineItemDescriptionEnumByIdAsync (string packingSlipTemplateLineItemDescriptionEnumId);

        /// <summary>
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id
        /// </summary>
        /// <remarks>
        /// Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param>
        /// <returns>Task of ApiResponse (PackingSlipTemplateLineItemDescriptionEnum)</returns>
        System.Threading.Tasks.Task<ApiResponse<PackingSlipTemplateLineItemDescriptionEnum>> GetPackingSlipTemplateLineItemDescriptionEnumByIdAsyncWithHttpInfo (string packingSlipTemplateLineItemDescriptionEnumId);
        
        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums
        /// </summary>
        /// <remarks>
        /// Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;</returns>
        System.Threading.Tasks.Task<List<PackingSlipTemplateLineItemDescriptionEnum>> GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums
        /// </summary>
        /// <remarks>
        /// Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PackingSlipTemplateLineItemDescriptionEnum>>> GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PackingSlipTemplateLineItemDescriptionEnumApi : IPackingSlipTemplateLineItemDescriptionEnumApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingSlipTemplateLineItemDescriptionEnumApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PackingSlipTemplateLineItemDescriptionEnumApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingSlipTemplateLineItemDescriptionEnumApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PackingSlipTemplateLineItemDescriptionEnumApi(Configuration configuration = null)
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
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param> 
        /// <returns>PackingSlipTemplateLineItemDescriptionEnum</returns>
        public PackingSlipTemplateLineItemDescriptionEnum GetPackingSlipTemplateLineItemDescriptionEnumById (string packingSlipTemplateLineItemDescriptionEnumId)
        {
             ApiResponse<PackingSlipTemplateLineItemDescriptionEnum> localVarResponse = GetPackingSlipTemplateLineItemDescriptionEnumByIdWithHttpInfo(packingSlipTemplateLineItemDescriptionEnumId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param> 
        /// <returns>ApiResponse of PackingSlipTemplateLineItemDescriptionEnum</returns>
        public ApiResponse< PackingSlipTemplateLineItemDescriptionEnum > GetPackingSlipTemplateLineItemDescriptionEnumByIdWithHttpInfo (string packingSlipTemplateLineItemDescriptionEnumId)
        {
            
            // verify the required parameter 'packingSlipTemplateLineItemDescriptionEnumId' is set
            if (packingSlipTemplateLineItemDescriptionEnumId == null)
                throw new ApiException(400, "Missing required parameter 'packingSlipTemplateLineItemDescriptionEnumId' when calling PackingSlipTemplateLineItemDescriptionEnumApi->GetPackingSlipTemplateLineItemDescriptionEnumById");
            
    
            var localVarPath = "/beta/packingSlipTemplateLineItemDescriptionEnum/{packingSlipTemplateLineItemDescriptionEnumId}";
    
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
            if (packingSlipTemplateLineItemDescriptionEnumId != null) localVarPathParams.Add("packingSlipTemplateLineItemDescriptionEnumId", Configuration.ApiClient.ParameterToString(packingSlipTemplateLineItemDescriptionEnumId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PackingSlipTemplateLineItemDescriptionEnum>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PackingSlipTemplateLineItemDescriptionEnum) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PackingSlipTemplateLineItemDescriptionEnum)));
            
        }

        
        /// <summary>
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param>
        /// <returns>Task of PackingSlipTemplateLineItemDescriptionEnum</returns>
        public async System.Threading.Tasks.Task<PackingSlipTemplateLineItemDescriptionEnum> GetPackingSlipTemplateLineItemDescriptionEnumByIdAsync (string packingSlipTemplateLineItemDescriptionEnumId)
        {
             ApiResponse<PackingSlipTemplateLineItemDescriptionEnum> localVarResponse = await GetPackingSlipTemplateLineItemDescriptionEnumByIdAsyncWithHttpInfo(packingSlipTemplateLineItemDescriptionEnumId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a packingSlipTemplateLineItemDescriptionEnum by id Returns the packingSlipTemplateLineItemDescriptionEnum identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packingSlipTemplateLineItemDescriptionEnumId">Id of packingSlipTemplateLineItemDescriptionEnum to be returned.</param>
        /// <returns>Task of ApiResponse (PackingSlipTemplateLineItemDescriptionEnum)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PackingSlipTemplateLineItemDescriptionEnum>> GetPackingSlipTemplateLineItemDescriptionEnumByIdAsyncWithHttpInfo (string packingSlipTemplateLineItemDescriptionEnumId)
        {
            // verify the required parameter 'packingSlipTemplateLineItemDescriptionEnumId' is set
            if (packingSlipTemplateLineItemDescriptionEnumId == null) throw new ApiException(400, "Missing required parameter 'packingSlipTemplateLineItemDescriptionEnumId' when calling GetPackingSlipTemplateLineItemDescriptionEnumById");
            
    
            var localVarPath = "/beta/packingSlipTemplateLineItemDescriptionEnum/{packingSlipTemplateLineItemDescriptionEnumId}";
    
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
            if (packingSlipTemplateLineItemDescriptionEnumId != null) localVarPathParams.Add("packingSlipTemplateLineItemDescriptionEnumId", Configuration.ApiClient.ParameterToString(packingSlipTemplateLineItemDescriptionEnumId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PackingSlipTemplateLineItemDescriptionEnum>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PackingSlipTemplateLineItemDescriptionEnum) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PackingSlipTemplateLineItemDescriptionEnum)));
            
        }
        
        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;</returns>
        public List<PackingSlipTemplateLineItemDescriptionEnum> GetPackingSlipTemplateLineItemDescriptionEnumBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<PackingSlipTemplateLineItemDescriptionEnum>> localVarResponse = GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>ApiResponse of List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;</returns>
        public ApiResponse< List<PackingSlipTemplateLineItemDescriptionEnum> > GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/packingSlipTemplateLineItemDescriptionEnum/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<PackingSlipTemplateLineItemDescriptionEnum>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PackingSlipTemplateLineItemDescriptionEnum>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PackingSlipTemplateLineItemDescriptionEnum>)));
            
        }

        
        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;</returns>
        public async System.Threading.Tasks.Task<List<PackingSlipTemplateLineItemDescriptionEnum>> GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<PackingSlipTemplateLineItemDescriptionEnum>> localVarResponse = await GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search packingSlipTemplateLineItemDescriptionEnums Returns the list of packingSlipTemplateLineItemDescriptionEnums that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PackingSlipTemplateLineItemDescriptionEnum&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PackingSlipTemplateLineItemDescriptionEnum>>> GetPackingSlipTemplateLineItemDescriptionEnumBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/packingSlipTemplateLineItemDescriptionEnum/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPackingSlipTemplateLineItemDescriptionEnumBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<PackingSlipTemplateLineItemDescriptionEnum>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PackingSlipTemplateLineItemDescriptionEnum>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PackingSlipTemplateLineItemDescriptionEnum>)));
            
        }
        
    }
    
}
