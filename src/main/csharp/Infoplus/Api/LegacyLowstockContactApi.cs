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
    public interface ILegacyLowstockContactApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Inserts a new legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param>
        /// <returns>LegacyLowstockContact</returns>
        LegacyLowstockContact AddLegacyLowstockContact (LegacyLowstockContact body);
  
        /// <summary>
        /// Create a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Inserts a new legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param>
        /// <returns>ApiResponse of LegacyLowstockContact</returns>
        ApiResponse<LegacyLowstockContact> AddLegacyLowstockContactWithHttpInfo (LegacyLowstockContact body);
        
        /// <summary>
        /// Delete a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Deletes the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param>
        /// <returns></returns>
        void DeleteLegacyLowstockContact (int? legacyLowstockContactId);
  
        /// <summary>
        /// Delete a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Deletes the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLegacyLowstockContactWithHttpInfo (int? legacyLowstockContactId);
        
        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param>
        /// <returns>LegacyLowstockContact</returns>
        LegacyLowstockContact GetDuplicateLegacyLowstockContactById (int? legacyLowstockContactId);
  
        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param>
        /// <returns>ApiResponse of LegacyLowstockContact</returns>
        ApiResponse<LegacyLowstockContact> GetDuplicateLegacyLowstockContactByIdWithHttpInfo (int? legacyLowstockContactId);
        
        /// <summary>
        /// Search legacyLowstockContacts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of legacyLowstockContacts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;LegacyLowstockContact&gt;</returns>
        List<LegacyLowstockContact> GetLegacyLowstockContactByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search legacyLowstockContacts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of legacyLowstockContacts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;LegacyLowstockContact&gt;</returns>
        ApiResponse<List<LegacyLowstockContact>> GetLegacyLowstockContactByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param>
        /// <returns>LegacyLowstockContact</returns>
        LegacyLowstockContact GetLegacyLowstockContactById (int? legacyLowstockContactId);
  
        /// <summary>
        /// Get a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param>
        /// <returns>ApiResponse of LegacyLowstockContact</returns>
        ApiResponse<LegacyLowstockContact> GetLegacyLowstockContactByIdWithHttpInfo (int? legacyLowstockContactId);
        
        /// <summary>
        /// Update a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Updates an existing legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param>
        /// <returns></returns>
        void UpdateLegacyLowstockContact (LegacyLowstockContact body);
  
        /// <summary>
        /// Update a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Updates an existing legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLegacyLowstockContactWithHttpInfo (LegacyLowstockContact body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Inserts a new legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param>
        /// <returns>Task of LegacyLowstockContact</returns>
        System.Threading.Tasks.Task<LegacyLowstockContact> AddLegacyLowstockContactAsync (LegacyLowstockContact body);

        /// <summary>
        /// Create a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Inserts a new legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param>
        /// <returns>Task of ApiResponse (LegacyLowstockContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<LegacyLowstockContact>> AddLegacyLowstockContactAsyncWithHttpInfo (LegacyLowstockContact body);
        
        /// <summary>
        /// Delete a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Deletes the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLegacyLowstockContactAsync (int? legacyLowstockContactId);

        /// <summary>
        /// Delete a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Deletes the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLegacyLowstockContactAsyncWithHttpInfo (int? legacyLowstockContactId);
        
        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param>
        /// <returns>Task of LegacyLowstockContact</returns>
        System.Threading.Tasks.Task<LegacyLowstockContact> GetDuplicateLegacyLowstockContactByIdAsync (int? legacyLowstockContactId);

        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param>
        /// <returns>Task of ApiResponse (LegacyLowstockContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<LegacyLowstockContact>> GetDuplicateLegacyLowstockContactByIdAsyncWithHttpInfo (int? legacyLowstockContactId);
        
        /// <summary>
        /// Search legacyLowstockContacts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of legacyLowstockContacts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LegacyLowstockContact&gt;</returns>
        System.Threading.Tasks.Task<List<LegacyLowstockContact>> GetLegacyLowstockContactByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search legacyLowstockContacts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of legacyLowstockContacts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LegacyLowstockContact&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LegacyLowstockContact>>> GetLegacyLowstockContactByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param>
        /// <returns>Task of LegacyLowstockContact</returns>
        System.Threading.Tasks.Task<LegacyLowstockContact> GetLegacyLowstockContactByIdAsync (int? legacyLowstockContactId);

        /// <summary>
        /// Get a legacyLowstockContact by id
        /// </summary>
        /// <remarks>
        /// Returns the legacyLowstockContact identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param>
        /// <returns>Task of ApiResponse (LegacyLowstockContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<LegacyLowstockContact>> GetLegacyLowstockContactByIdAsyncWithHttpInfo (int? legacyLowstockContactId);
        
        /// <summary>
        /// Update a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Updates an existing legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLegacyLowstockContactAsync (LegacyLowstockContact body);

        /// <summary>
        /// Update a legacyLowstockContact
        /// </summary>
        /// <remarks>
        /// Updates an existing legacyLowstockContact using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLegacyLowstockContactAsyncWithHttpInfo (LegacyLowstockContact body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LegacyLowstockContactApi : ILegacyLowstockContactApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyLowstockContactApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LegacyLowstockContactApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyLowstockContactApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LegacyLowstockContactApi(Configuration configuration = null)
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
        /// Create a legacyLowstockContact Inserts a new legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param> 
        /// <returns>LegacyLowstockContact</returns>
        public LegacyLowstockContact AddLegacyLowstockContact (LegacyLowstockContact body)
        {
             ApiResponse<LegacyLowstockContact> localVarResponse = AddLegacyLowstockContactWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a legacyLowstockContact Inserts a new legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param> 
        /// <returns>ApiResponse of LegacyLowstockContact</returns>
        public ApiResponse< LegacyLowstockContact > AddLegacyLowstockContactWithHttpInfo (LegacyLowstockContact body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LegacyLowstockContactApi->AddLegacyLowstockContact");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLegacyLowstockContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLegacyLowstockContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LegacyLowstockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegacyLowstockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegacyLowstockContact)));
            
        }

        
        /// <summary>
        /// Create a legacyLowstockContact Inserts a new legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param>
        /// <returns>Task of LegacyLowstockContact</returns>
        public async System.Threading.Tasks.Task<LegacyLowstockContact> AddLegacyLowstockContactAsync (LegacyLowstockContact body)
        {
             ApiResponse<LegacyLowstockContact> localVarResponse = await AddLegacyLowstockContactAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a legacyLowstockContact Inserts a new legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be inserted.</param>
        /// <returns>Task of ApiResponse (LegacyLowstockContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LegacyLowstockContact>> AddLegacyLowstockContactAsyncWithHttpInfo (LegacyLowstockContact body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddLegacyLowstockContact");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLegacyLowstockContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLegacyLowstockContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LegacyLowstockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegacyLowstockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegacyLowstockContact)));
            
        }
        
        /// <summary>
        /// Delete a legacyLowstockContact Deletes the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param> 
        /// <returns></returns>
        public void DeleteLegacyLowstockContact (int? legacyLowstockContactId)
        {
             DeleteLegacyLowstockContactWithHttpInfo(legacyLowstockContactId);
        }

        /// <summary>
        /// Delete a legacyLowstockContact Deletes the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLegacyLowstockContactWithHttpInfo (int? legacyLowstockContactId)
        {
            
            // verify the required parameter 'legacyLowstockContactId' is set
            if (legacyLowstockContactId == null)
                throw new ApiException(400, "Missing required parameter 'legacyLowstockContactId' when calling LegacyLowstockContactApi->DeleteLegacyLowstockContact");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/{legacyLowstockContactId}";
    
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
            if (legacyLowstockContactId != null) localVarPathParams.Add("legacyLowstockContactId", Configuration.ApiClient.ParameterToString(legacyLowstockContactId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLegacyLowstockContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLegacyLowstockContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a legacyLowstockContact Deletes the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLegacyLowstockContactAsync (int? legacyLowstockContactId)
        {
             await DeleteLegacyLowstockContactAsyncWithHttpInfo(legacyLowstockContactId);

        }

        /// <summary>
        /// Delete a legacyLowstockContact Deletes the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLegacyLowstockContactAsyncWithHttpInfo (int? legacyLowstockContactId)
        {
            // verify the required parameter 'legacyLowstockContactId' is set
            if (legacyLowstockContactId == null) throw new ApiException(400, "Missing required parameter 'legacyLowstockContactId' when calling DeleteLegacyLowstockContact");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/{legacyLowstockContactId}";
    
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
            if (legacyLowstockContactId != null) localVarPathParams.Add("legacyLowstockContactId", Configuration.ApiClient.ParameterToString(legacyLowstockContactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLegacyLowstockContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLegacyLowstockContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param> 
        /// <returns>LegacyLowstockContact</returns>
        public LegacyLowstockContact GetDuplicateLegacyLowstockContactById (int? legacyLowstockContactId)
        {
             ApiResponse<LegacyLowstockContact> localVarResponse = GetDuplicateLegacyLowstockContactByIdWithHttpInfo(legacyLowstockContactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param> 
        /// <returns>ApiResponse of LegacyLowstockContact</returns>
        public ApiResponse< LegacyLowstockContact > GetDuplicateLegacyLowstockContactByIdWithHttpInfo (int? legacyLowstockContactId)
        {
            
            // verify the required parameter 'legacyLowstockContactId' is set
            if (legacyLowstockContactId == null)
                throw new ApiException(400, "Missing required parameter 'legacyLowstockContactId' when calling LegacyLowstockContactApi->GetDuplicateLegacyLowstockContactById");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/duplicate/{legacyLowstockContactId}";
    
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
            if (legacyLowstockContactId != null) localVarPathParams.Add("legacyLowstockContactId", Configuration.ApiClient.ParameterToString(legacyLowstockContactId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLegacyLowstockContactById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLegacyLowstockContactById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LegacyLowstockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegacyLowstockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegacyLowstockContact)));
            
        }

        
        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param>
        /// <returns>Task of LegacyLowstockContact</returns>
        public async System.Threading.Tasks.Task<LegacyLowstockContact> GetDuplicateLegacyLowstockContactByIdAsync (int? legacyLowstockContactId)
        {
             ApiResponse<LegacyLowstockContact> localVarResponse = await GetDuplicateLegacyLowstockContactByIdAsyncWithHttpInfo(legacyLowstockContactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a legacyLowstockContact by id Returns a duplicated legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be duplicated.</param>
        /// <returns>Task of ApiResponse (LegacyLowstockContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LegacyLowstockContact>> GetDuplicateLegacyLowstockContactByIdAsyncWithHttpInfo (int? legacyLowstockContactId)
        {
            // verify the required parameter 'legacyLowstockContactId' is set
            if (legacyLowstockContactId == null) throw new ApiException(400, "Missing required parameter 'legacyLowstockContactId' when calling GetDuplicateLegacyLowstockContactById");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/duplicate/{legacyLowstockContactId}";
    
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
            if (legacyLowstockContactId != null) localVarPathParams.Add("legacyLowstockContactId", Configuration.ApiClient.ParameterToString(legacyLowstockContactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLegacyLowstockContactById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLegacyLowstockContactById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LegacyLowstockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegacyLowstockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegacyLowstockContact)));
            
        }
        
        /// <summary>
        /// Search legacyLowstockContacts by filter Returns the list of legacyLowstockContacts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;LegacyLowstockContact&gt;</returns>
        public List<LegacyLowstockContact> GetLegacyLowstockContactByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LegacyLowstockContact>> localVarResponse = GetLegacyLowstockContactByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search legacyLowstockContacts by filter Returns the list of legacyLowstockContacts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;LegacyLowstockContact&gt;</returns>
        public ApiResponse< List<LegacyLowstockContact> > GetLegacyLowstockContactByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<LegacyLowstockContact>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LegacyLowstockContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LegacyLowstockContact>)));
            
        }

        
        /// <summary>
        /// Search legacyLowstockContacts by filter Returns the list of legacyLowstockContacts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LegacyLowstockContact&gt;</returns>
        public async System.Threading.Tasks.Task<List<LegacyLowstockContact>> GetLegacyLowstockContactByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LegacyLowstockContact>> localVarResponse = await GetLegacyLowstockContactByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search legacyLowstockContacts by filter Returns the list of legacyLowstockContacts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LegacyLowstockContact&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LegacyLowstockContact>>> GetLegacyLowstockContactByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LegacyLowstockContact>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LegacyLowstockContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LegacyLowstockContact>)));
            
        }
        
        /// <summary>
        /// Get a legacyLowstockContact by id Returns the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param> 
        /// <returns>LegacyLowstockContact</returns>
        public LegacyLowstockContact GetLegacyLowstockContactById (int? legacyLowstockContactId)
        {
             ApiResponse<LegacyLowstockContact> localVarResponse = GetLegacyLowstockContactByIdWithHttpInfo(legacyLowstockContactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a legacyLowstockContact by id Returns the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param> 
        /// <returns>ApiResponse of LegacyLowstockContact</returns>
        public ApiResponse< LegacyLowstockContact > GetLegacyLowstockContactByIdWithHttpInfo (int? legacyLowstockContactId)
        {
            
            // verify the required parameter 'legacyLowstockContactId' is set
            if (legacyLowstockContactId == null)
                throw new ApiException(400, "Missing required parameter 'legacyLowstockContactId' when calling LegacyLowstockContactApi->GetLegacyLowstockContactById");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/{legacyLowstockContactId}";
    
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
            if (legacyLowstockContactId != null) localVarPathParams.Add("legacyLowstockContactId", Configuration.ApiClient.ParameterToString(legacyLowstockContactId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LegacyLowstockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegacyLowstockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegacyLowstockContact)));
            
        }

        
        /// <summary>
        /// Get a legacyLowstockContact by id Returns the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param>
        /// <returns>Task of LegacyLowstockContact</returns>
        public async System.Threading.Tasks.Task<LegacyLowstockContact> GetLegacyLowstockContactByIdAsync (int? legacyLowstockContactId)
        {
             ApiResponse<LegacyLowstockContact> localVarResponse = await GetLegacyLowstockContactByIdAsyncWithHttpInfo(legacyLowstockContactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a legacyLowstockContact by id Returns the legacyLowstockContact identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="legacyLowstockContactId">Id of the legacyLowstockContact to be returned.</param>
        /// <returns>Task of ApiResponse (LegacyLowstockContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LegacyLowstockContact>> GetLegacyLowstockContactByIdAsyncWithHttpInfo (int? legacyLowstockContactId)
        {
            // verify the required parameter 'legacyLowstockContactId' is set
            if (legacyLowstockContactId == null) throw new ApiException(400, "Missing required parameter 'legacyLowstockContactId' when calling GetLegacyLowstockContactById");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact/{legacyLowstockContactId}";
    
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
            if (legacyLowstockContactId != null) localVarPathParams.Add("legacyLowstockContactId", Configuration.ApiClient.ParameterToString(legacyLowstockContactId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLegacyLowstockContactById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LegacyLowstockContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegacyLowstockContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegacyLowstockContact)));
            
        }
        
        /// <summary>
        /// Update a legacyLowstockContact Updates an existing legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param> 
        /// <returns></returns>
        public void UpdateLegacyLowstockContact (LegacyLowstockContact body)
        {
             UpdateLegacyLowstockContactWithHttpInfo(body);
        }

        /// <summary>
        /// Update a legacyLowstockContact Updates an existing legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLegacyLowstockContactWithHttpInfo (LegacyLowstockContact body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LegacyLowstockContactApi->UpdateLegacyLowstockContact");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLegacyLowstockContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLegacyLowstockContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a legacyLowstockContact Updates an existing legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLegacyLowstockContactAsync (LegacyLowstockContact body)
        {
             await UpdateLegacyLowstockContactAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a legacyLowstockContact Updates an existing legacyLowstockContact using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LegacyLowstockContact to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLegacyLowstockContactAsyncWithHttpInfo (LegacyLowstockContact body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLegacyLowstockContact");
            
    
            var localVarPath = "/v2.0/legacyLowstockContact";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLegacyLowstockContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLegacyLowstockContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
