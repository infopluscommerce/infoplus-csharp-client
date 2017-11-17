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
    public interface IWarehouseDocumentTypeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get a duplicated a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param>
        /// <returns>WarehouseDocumentType</returns>
        WarehouseDocumentType GetDuplicateWarehouseDocumentTypeById (int? warehouseDocumentTypeId);
  
        /// <summary>
        /// Get a duplicated a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param>
        /// <returns>ApiResponse of WarehouseDocumentType</returns>
        ApiResponse<WarehouseDocumentType> GetDuplicateWarehouseDocumentTypeByIdWithHttpInfo (int? warehouseDocumentTypeId);
        
        /// <summary>
        /// Search warehouseDocumentTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocumentTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;WarehouseDocumentType&gt;</returns>
        List<WarehouseDocumentType> GetWarehouseDocumentTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search warehouseDocumentTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocumentTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;WarehouseDocumentType&gt;</returns>
        ApiResponse<List<WarehouseDocumentType>> GetWarehouseDocumentTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param>
        /// <returns>WarehouseDocumentType</returns>
        WarehouseDocumentType GetWarehouseDocumentTypeById (int? warehouseDocumentTypeId);
  
        /// <summary>
        /// Get a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param>
        /// <returns>ApiResponse of WarehouseDocumentType</returns>
        ApiResponse<WarehouseDocumentType> GetWarehouseDocumentTypeByIdWithHttpInfo (int? warehouseDocumentTypeId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get a duplicated a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param>
        /// <returns>Task of WarehouseDocumentType</returns>
        System.Threading.Tasks.Task<WarehouseDocumentType> GetDuplicateWarehouseDocumentTypeByIdAsync (int? warehouseDocumentTypeId);

        /// <summary>
        /// Get a duplicated a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param>
        /// <returns>Task of ApiResponse (WarehouseDocumentType)</returns>
        System.Threading.Tasks.Task<ApiResponse<WarehouseDocumentType>> GetDuplicateWarehouseDocumentTypeByIdAsyncWithHttpInfo (int? warehouseDocumentTypeId);
        
        /// <summary>
        /// Search warehouseDocumentTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocumentTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WarehouseDocumentType&gt;</returns>
        System.Threading.Tasks.Task<List<WarehouseDocumentType>> GetWarehouseDocumentTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search warehouseDocumentTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocumentTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WarehouseDocumentType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WarehouseDocumentType>>> GetWarehouseDocumentTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param>
        /// <returns>Task of WarehouseDocumentType</returns>
        System.Threading.Tasks.Task<WarehouseDocumentType> GetWarehouseDocumentTypeByIdAsync (int? warehouseDocumentTypeId);

        /// <summary>
        /// Get a warehouseDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param>
        /// <returns>Task of ApiResponse (WarehouseDocumentType)</returns>
        System.Threading.Tasks.Task<ApiResponse<WarehouseDocumentType>> GetWarehouseDocumentTypeByIdAsyncWithHttpInfo (int? warehouseDocumentTypeId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WarehouseDocumentTypeApi : IWarehouseDocumentTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseDocumentTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WarehouseDocumentTypeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseDocumentTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WarehouseDocumentTypeApi(Configuration configuration = null)
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
        /// Get a duplicated a warehouseDocumentType by id Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param> 
        /// <returns>WarehouseDocumentType</returns>
        public WarehouseDocumentType GetDuplicateWarehouseDocumentTypeById (int? warehouseDocumentTypeId)
        {
             ApiResponse<WarehouseDocumentType> localVarResponse = GetDuplicateWarehouseDocumentTypeByIdWithHttpInfo(warehouseDocumentTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a warehouseDocumentType by id Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param> 
        /// <returns>ApiResponse of WarehouseDocumentType</returns>
        public ApiResponse< WarehouseDocumentType > GetDuplicateWarehouseDocumentTypeByIdWithHttpInfo (int? warehouseDocumentTypeId)
        {
            
            // verify the required parameter 'warehouseDocumentTypeId' is set
            if (warehouseDocumentTypeId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentTypeId' when calling WarehouseDocumentTypeApi->GetDuplicateWarehouseDocumentTypeById");
            
    
            var localVarPath = "/v2.0/warehouseDocumentType/duplicate/{warehouseDocumentTypeId}";
    
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
            if (warehouseDocumentTypeId != null) localVarPathParams.Add("warehouseDocumentTypeId", Configuration.ApiClient.ParameterToString(warehouseDocumentTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WarehouseDocumentType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocumentType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocumentType)));
            
        }

        
        /// <summary>
        /// Get a duplicated a warehouseDocumentType by id Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param>
        /// <returns>Task of WarehouseDocumentType</returns>
        public async System.Threading.Tasks.Task<WarehouseDocumentType> GetDuplicateWarehouseDocumentTypeByIdAsync (int? warehouseDocumentTypeId)
        {
             ApiResponse<WarehouseDocumentType> localVarResponse = await GetDuplicateWarehouseDocumentTypeByIdAsyncWithHttpInfo(warehouseDocumentTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a warehouseDocumentType by id Returns a duplicated warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be duplicated.</param>
        /// <returns>Task of ApiResponse (WarehouseDocumentType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WarehouseDocumentType>> GetDuplicateWarehouseDocumentTypeByIdAsyncWithHttpInfo (int? warehouseDocumentTypeId)
        {
            // verify the required parameter 'warehouseDocumentTypeId' is set
            if (warehouseDocumentTypeId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentTypeId' when calling GetDuplicateWarehouseDocumentTypeById");
            
    
            var localVarPath = "/v2.0/warehouseDocumentType/duplicate/{warehouseDocumentTypeId}";
    
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
            if (warehouseDocumentTypeId != null) localVarPathParams.Add("warehouseDocumentTypeId", Configuration.ApiClient.ParameterToString(warehouseDocumentTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WarehouseDocumentType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocumentType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocumentType)));
            
        }
        
        /// <summary>
        /// Search warehouseDocumentTypes by filter Returns the list of warehouseDocumentTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;WarehouseDocumentType&gt;</returns>
        public List<WarehouseDocumentType> GetWarehouseDocumentTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WarehouseDocumentType>> localVarResponse = GetWarehouseDocumentTypeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search warehouseDocumentTypes by filter Returns the list of warehouseDocumentTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;WarehouseDocumentType&gt;</returns>
        public ApiResponse< List<WarehouseDocumentType> > GetWarehouseDocumentTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/warehouseDocumentType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WarehouseDocumentType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WarehouseDocumentType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WarehouseDocumentType>)));
            
        }

        
        /// <summary>
        /// Search warehouseDocumentTypes by filter Returns the list of warehouseDocumentTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WarehouseDocumentType&gt;</returns>
        public async System.Threading.Tasks.Task<List<WarehouseDocumentType>> GetWarehouseDocumentTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WarehouseDocumentType>> localVarResponse = await GetWarehouseDocumentTypeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search warehouseDocumentTypes by filter Returns the list of warehouseDocumentTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WarehouseDocumentType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WarehouseDocumentType>>> GetWarehouseDocumentTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/warehouseDocumentType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WarehouseDocumentType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WarehouseDocumentType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WarehouseDocumentType>)));
            
        }
        
        /// <summary>
        /// Get a warehouseDocumentType by id Returns the warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param> 
        /// <returns>WarehouseDocumentType</returns>
        public WarehouseDocumentType GetWarehouseDocumentTypeById (int? warehouseDocumentTypeId)
        {
             ApiResponse<WarehouseDocumentType> localVarResponse = GetWarehouseDocumentTypeByIdWithHttpInfo(warehouseDocumentTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a warehouseDocumentType by id Returns the warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param> 
        /// <returns>ApiResponse of WarehouseDocumentType</returns>
        public ApiResponse< WarehouseDocumentType > GetWarehouseDocumentTypeByIdWithHttpInfo (int? warehouseDocumentTypeId)
        {
            
            // verify the required parameter 'warehouseDocumentTypeId' is set
            if (warehouseDocumentTypeId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentTypeId' when calling WarehouseDocumentTypeApi->GetWarehouseDocumentTypeById");
            
    
            var localVarPath = "/v2.0/warehouseDocumentType/{warehouseDocumentTypeId}";
    
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
            if (warehouseDocumentTypeId != null) localVarPathParams.Add("warehouseDocumentTypeId", Configuration.ApiClient.ParameterToString(warehouseDocumentTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WarehouseDocumentType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocumentType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocumentType)));
            
        }

        
        /// <summary>
        /// Get a warehouseDocumentType by id Returns the warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param>
        /// <returns>Task of WarehouseDocumentType</returns>
        public async System.Threading.Tasks.Task<WarehouseDocumentType> GetWarehouseDocumentTypeByIdAsync (int? warehouseDocumentTypeId)
        {
             ApiResponse<WarehouseDocumentType> localVarResponse = await GetWarehouseDocumentTypeByIdAsyncWithHttpInfo(warehouseDocumentTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a warehouseDocumentType by id Returns the warehouseDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentTypeId">Id of the warehouseDocumentType to be returned.</param>
        /// <returns>Task of ApiResponse (WarehouseDocumentType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WarehouseDocumentType>> GetWarehouseDocumentTypeByIdAsyncWithHttpInfo (int? warehouseDocumentTypeId)
        {
            // verify the required parameter 'warehouseDocumentTypeId' is set
            if (warehouseDocumentTypeId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentTypeId' when calling GetWarehouseDocumentTypeById");
            
    
            var localVarPath = "/v2.0/warehouseDocumentType/{warehouseDocumentTypeId}";
    
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
            if (warehouseDocumentTypeId != null) localVarPathParams.Add("warehouseDocumentTypeId", Configuration.ApiClient.ParameterToString(warehouseDocumentTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WarehouseDocumentType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocumentType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocumentType)));
            
        }
        
    }
    
}
