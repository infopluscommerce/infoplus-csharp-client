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
    public interface IWarehouseDocumentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;WarehouseDocument&gt;</returns>
        List<WarehouseDocument> GetWarehouseDocumentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;WarehouseDocument&gt;</returns>
        ApiResponse<List<WarehouseDocument>> GetWarehouseDocumentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>WarehouseDocument</returns>
        WarehouseDocument GetWarehouseDocumentById (int? warehouseDocumentId);
  
        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>ApiResponse of WarehouseDocument</returns>
        ApiResponse<WarehouseDocument> GetWarehouseDocumentByIdWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns></returns>
        void UpdateWarehouseDocumentCustomFields (WarehouseDocument body);
  
        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateWarehouseDocumentCustomFieldsWithHttpInfo (WarehouseDocument body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WarehouseDocument&gt;</returns>
        System.Threading.Tasks.Task<List<WarehouseDocument>> GetWarehouseDocumentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WarehouseDocument&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WarehouseDocument>>> GetWarehouseDocumentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of WarehouseDocument</returns>
        System.Threading.Tasks.Task<WarehouseDocument> GetWarehouseDocumentByIdAsync (int? warehouseDocumentId);

        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of ApiResponse (WarehouseDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<WarehouseDocument>> GetWarehouseDocumentByIdAsyncWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateWarehouseDocumentCustomFieldsAsync (WarehouseDocument body);

        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateWarehouseDocumentCustomFieldsAsyncWithHttpInfo (WarehouseDocument body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WarehouseDocumentApi : IWarehouseDocumentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseDocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WarehouseDocumentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseDocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WarehouseDocumentApi(Configuration configuration = null)
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
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;WarehouseDocument&gt;</returns>
        public List<WarehouseDocument> GetWarehouseDocumentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WarehouseDocument>> localVarResponse = GetWarehouseDocumentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;WarehouseDocument&gt;</returns>
        public ApiResponse< List<WarehouseDocument> > GetWarehouseDocumentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/warehouseDocument/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WarehouseDocument>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WarehouseDocument>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WarehouseDocument>)));
            
        }

        
        /// <summary>
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WarehouseDocument&gt;</returns>
        public async System.Threading.Tasks.Task<List<WarehouseDocument>> GetWarehouseDocumentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WarehouseDocument>> localVarResponse = await GetWarehouseDocumentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WarehouseDocument&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WarehouseDocument>>> GetWarehouseDocumentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/warehouseDocument/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WarehouseDocument>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WarehouseDocument>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WarehouseDocument>)));
            
        }
        
        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param> 
        /// <returns>WarehouseDocument</returns>
        public WarehouseDocument GetWarehouseDocumentById (int? warehouseDocumentId)
        {
             ApiResponse<WarehouseDocument> localVarResponse = GetWarehouseDocumentByIdWithHttpInfo(warehouseDocumentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param> 
        /// <returns>ApiResponse of WarehouseDocument</returns>
        public ApiResponse< WarehouseDocument > GetWarehouseDocumentByIdWithHttpInfo (int? warehouseDocumentId)
        {
            
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling WarehouseDocumentApi->GetWarehouseDocumentById");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WarehouseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocument)));
            
        }

        
        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of WarehouseDocument</returns>
        public async System.Threading.Tasks.Task<WarehouseDocument> GetWarehouseDocumentByIdAsync (int? warehouseDocumentId)
        {
             ApiResponse<WarehouseDocument> localVarResponse = await GetWarehouseDocumentByIdAsyncWithHttpInfo(warehouseDocumentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of ApiResponse (WarehouseDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WarehouseDocument>> GetWarehouseDocumentByIdAsyncWithHttpInfo (int? warehouseDocumentId)
        {
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling GetWarehouseDocumentById");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WarehouseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocument)));
            
        }
        
        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param> 
        /// <returns></returns>
        public void UpdateWarehouseDocumentCustomFields (WarehouseDocument body)
        {
             UpdateWarehouseDocumentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateWarehouseDocumentCustomFieldsWithHttpInfo (WarehouseDocument body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WarehouseDocumentApi->UpdateWarehouseDocumentCustomFields");
            
    
            var localVarPath = "/beta/warehouseDocument/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateWarehouseDocumentCustomFieldsAsync (WarehouseDocument body)
        {
             await UpdateWarehouseDocumentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateWarehouseDocumentCustomFieldsAsyncWithHttpInfo (WarehouseDocument body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateWarehouseDocumentCustomFields");
            
    
            var localVarPath = "/beta/warehouseDocument/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
