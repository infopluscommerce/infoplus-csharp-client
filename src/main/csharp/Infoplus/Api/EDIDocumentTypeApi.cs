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
    public interface IEDIDocumentTypeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get an eDIDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the eDIDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param>
        /// <returns>EDIDocumentType</returns>
        EDIDocumentType GetEDIDocumentTypeById (string eDIDocumentTypeId);
  
        /// <summary>
        /// Get an eDIDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the eDIDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param>
        /// <returns>ApiResponse of EDIDocumentType</returns>
        ApiResponse<EDIDocumentType> GetEDIDocumentTypeByIdWithHttpInfo (string eDIDocumentTypeId);
        
        /// <summary>
        /// Search eDIDocumentTypes
        /// </summary>
        /// <remarks>
        /// Returns the list of eDIDocumentTypes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;EDIDocumentType&gt;</returns>
        List<EDIDocumentType> GetEDIDocumentTypeBySearchText (string searchText = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Search eDIDocumentTypes
        /// </summary>
        /// <remarks>
        /// Returns the list of eDIDocumentTypes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;EDIDocumentType&gt;</returns>
        ApiResponse<List<EDIDocumentType>> GetEDIDocumentTypeBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get an eDIDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the eDIDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param>
        /// <returns>Task of EDIDocumentType</returns>
        System.Threading.Tasks.Task<EDIDocumentType> GetEDIDocumentTypeByIdAsync (string eDIDocumentTypeId);

        /// <summary>
        /// Get an eDIDocumentType by id
        /// </summary>
        /// <remarks>
        /// Returns the eDIDocumentType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param>
        /// <returns>Task of ApiResponse (EDIDocumentType)</returns>
        System.Threading.Tasks.Task<ApiResponse<EDIDocumentType>> GetEDIDocumentTypeByIdAsyncWithHttpInfo (string eDIDocumentTypeId);
        
        /// <summary>
        /// Search eDIDocumentTypes
        /// </summary>
        /// <remarks>
        /// Returns the list of eDIDocumentTypes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;EDIDocumentType&gt;</returns>
        System.Threading.Tasks.Task<List<EDIDocumentType>> GetEDIDocumentTypeBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search eDIDocumentTypes
        /// </summary>
        /// <remarks>
        /// Returns the list of eDIDocumentTypes that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EDIDocumentType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<EDIDocumentType>>> GetEDIDocumentTypeBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EDIDocumentTypeApi : IEDIDocumentTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EDIDocumentTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EDIDocumentTypeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EDIDocumentTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EDIDocumentTypeApi(Configuration configuration = null)
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
        /// Get an eDIDocumentType by id Returns the eDIDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param> 
        /// <returns>EDIDocumentType</returns>
        public EDIDocumentType GetEDIDocumentTypeById (string eDIDocumentTypeId)
        {
             ApiResponse<EDIDocumentType> localVarResponse = GetEDIDocumentTypeByIdWithHttpInfo(eDIDocumentTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an eDIDocumentType by id Returns the eDIDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param> 
        /// <returns>ApiResponse of EDIDocumentType</returns>
        public ApiResponse< EDIDocumentType > GetEDIDocumentTypeByIdWithHttpInfo (string eDIDocumentTypeId)
        {
            
            // verify the required parameter 'eDIDocumentTypeId' is set
            if (eDIDocumentTypeId == null)
                throw new ApiException(400, "Missing required parameter 'eDIDocumentTypeId' when calling EDIDocumentTypeApi->GetEDIDocumentTypeById");
            
    
            var localVarPath = "/beta/eDIDocumentType/{eDIDocumentTypeId}";
    
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
            if (eDIDocumentTypeId != null) localVarPathParams.Add("eDIDocumentTypeId", Configuration.ApiClient.ParameterToString(eDIDocumentTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EDIDocumentType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EDIDocumentType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EDIDocumentType)));
            
        }

        
        /// <summary>
        /// Get an eDIDocumentType by id Returns the eDIDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param>
        /// <returns>Task of EDIDocumentType</returns>
        public async System.Threading.Tasks.Task<EDIDocumentType> GetEDIDocumentTypeByIdAsync (string eDIDocumentTypeId)
        {
             ApiResponse<EDIDocumentType> localVarResponse = await GetEDIDocumentTypeByIdAsyncWithHttpInfo(eDIDocumentTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an eDIDocumentType by id Returns the eDIDocumentType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eDIDocumentTypeId">Id of eDIDocumentType to be returned.</param>
        /// <returns>Task of ApiResponse (EDIDocumentType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EDIDocumentType>> GetEDIDocumentTypeByIdAsyncWithHttpInfo (string eDIDocumentTypeId)
        {
            // verify the required parameter 'eDIDocumentTypeId' is set
            if (eDIDocumentTypeId == null) throw new ApiException(400, "Missing required parameter 'eDIDocumentTypeId' when calling GetEDIDocumentTypeById");
            
    
            var localVarPath = "/beta/eDIDocumentType/{eDIDocumentTypeId}";
    
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
            if (eDIDocumentTypeId != null) localVarPathParams.Add("eDIDocumentTypeId", Configuration.ApiClient.ParameterToString(eDIDocumentTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EDIDocumentType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EDIDocumentType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EDIDocumentType)));
            
        }
        
        /// <summary>
        /// Search eDIDocumentTypes Returns the list of eDIDocumentTypes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>List&lt;EDIDocumentType&gt;</returns>
        public List<EDIDocumentType> GetEDIDocumentTypeBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<EDIDocumentType>> localVarResponse = GetEDIDocumentTypeBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search eDIDocumentTypes Returns the list of eDIDocumentTypes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <returns>ApiResponse of List&lt;EDIDocumentType&gt;</returns>
        public ApiResponse< List<EDIDocumentType> > GetEDIDocumentTypeBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/eDIDocumentType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<EDIDocumentType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EDIDocumentType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EDIDocumentType>)));
            
        }

        
        /// <summary>
        /// Search eDIDocumentTypes Returns the list of eDIDocumentTypes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;EDIDocumentType&gt;</returns>
        public async System.Threading.Tasks.Task<List<EDIDocumentType>> GetEDIDocumentTypeBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<EDIDocumentType>> localVarResponse = await GetEDIDocumentTypeBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search eDIDocumentTypes Returns the list of eDIDocumentTypes that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EDIDocumentType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<EDIDocumentType>>> GetEDIDocumentTypeBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/beta/eDIDocumentType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeBySearchText: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEDIDocumentTypeBySearchText: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<EDIDocumentType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EDIDocumentType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EDIDocumentType>)));
            
        }
        
    }
    
}
