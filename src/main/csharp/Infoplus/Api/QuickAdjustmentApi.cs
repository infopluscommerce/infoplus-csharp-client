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
    public interface IQuickAdjustmentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Inserts a new quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param>
        /// <returns>QuickAdjustment</returns>
        QuickAdjustment AddQuickAdjustment (QuickAdjustment body);
  
        /// <summary>
        /// Create a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Inserts a new quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param>
        /// <returns>ApiResponse of QuickAdjustment</returns>
        ApiResponse<QuickAdjustment> AddQuickAdjustmentWithHttpInfo (QuickAdjustment body);
        
        /// <summary>
        /// Delete a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Deletes the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param>
        /// <returns></returns>
        void DeleteQuickAdjustment (int? quickAdjustmentId);
  
        /// <summary>
        /// Delete a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Deletes the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteQuickAdjustmentWithHttpInfo (int? quickAdjustmentId);
        
        /// <summary>
        /// Get a duplicated a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param>
        /// <returns>QuickAdjustment</returns>
        QuickAdjustment GetDuplicateQuickAdjustmentById (int? quickAdjustmentId);
  
        /// <summary>
        /// Get a duplicated a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param>
        /// <returns>ApiResponse of QuickAdjustment</returns>
        ApiResponse<QuickAdjustment> GetDuplicateQuickAdjustmentByIdWithHttpInfo (int? quickAdjustmentId);
        
        /// <summary>
        /// Search quickAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;QuickAdjustment&gt;</returns>
        List<QuickAdjustment> GetQuickAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search quickAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;QuickAdjustment&gt;</returns>
        ApiResponse<List<QuickAdjustment>> GetQuickAdjustmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param>
        /// <returns>QuickAdjustment</returns>
        QuickAdjustment GetQuickAdjustmentById (int? quickAdjustmentId);
  
        /// <summary>
        /// Get a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param>
        /// <returns>ApiResponse of QuickAdjustment</returns>
        ApiResponse<QuickAdjustment> GetQuickAdjustmentByIdWithHttpInfo (int? quickAdjustmentId);
        
        /// <summary>
        /// Update a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns></returns>
        void UpdateQuickAdjustment (QuickAdjustment body);
  
        /// <summary>
        /// Update a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateQuickAdjustmentWithHttpInfo (QuickAdjustment body);
        
        /// <summary>
        /// Update a quickAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns></returns>
        void UpdateQuickAdjustmentCustomFields (QuickAdjustment body);
  
        /// <summary>
        /// Update a quickAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateQuickAdjustmentCustomFieldsWithHttpInfo (QuickAdjustment body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Inserts a new quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param>
        /// <returns>Task of QuickAdjustment</returns>
        System.Threading.Tasks.Task<QuickAdjustment> AddQuickAdjustmentAsync (QuickAdjustment body);

        /// <summary>
        /// Create a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Inserts a new quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param>
        /// <returns>Task of ApiResponse (QuickAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuickAdjustment>> AddQuickAdjustmentAsyncWithHttpInfo (QuickAdjustment body);
        
        /// <summary>
        /// Delete a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Deletes the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteQuickAdjustmentAsync (int? quickAdjustmentId);

        /// <summary>
        /// Delete a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Deletes the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQuickAdjustmentAsyncWithHttpInfo (int? quickAdjustmentId);
        
        /// <summary>
        /// Get a duplicated a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param>
        /// <returns>Task of QuickAdjustment</returns>
        System.Threading.Tasks.Task<QuickAdjustment> GetDuplicateQuickAdjustmentByIdAsync (int? quickAdjustmentId);

        /// <summary>
        /// Get a duplicated a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param>
        /// <returns>Task of ApiResponse (QuickAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuickAdjustment>> GetDuplicateQuickAdjustmentByIdAsyncWithHttpInfo (int? quickAdjustmentId);
        
        /// <summary>
        /// Search quickAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;QuickAdjustment&gt;</returns>
        System.Threading.Tasks.Task<List<QuickAdjustment>> GetQuickAdjustmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search quickAdjustments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickAdjustments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;QuickAdjustment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<QuickAdjustment>>> GetQuickAdjustmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param>
        /// <returns>Task of QuickAdjustment</returns>
        System.Threading.Tasks.Task<QuickAdjustment> GetQuickAdjustmentByIdAsync (int? quickAdjustmentId);

        /// <summary>
        /// Get a quickAdjustment by id
        /// </summary>
        /// <remarks>
        /// Returns the quickAdjustment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param>
        /// <returns>Task of ApiResponse (QuickAdjustment)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuickAdjustment>> GetQuickAdjustmentByIdAsyncWithHttpInfo (int? quickAdjustmentId);
        
        /// <summary>
        /// Update a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateQuickAdjustmentAsync (QuickAdjustment body);

        /// <summary>
        /// Update a quickAdjustment
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickAdjustmentAsyncWithHttpInfo (QuickAdjustment body);
        
        /// <summary>
        /// Update a quickAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateQuickAdjustmentCustomFieldsAsync (QuickAdjustment body);

        /// <summary>
        /// Update a quickAdjustment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickAdjustment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickAdjustmentCustomFieldsAsyncWithHttpInfo (QuickAdjustment body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QuickAdjustmentApi : IQuickAdjustmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickAdjustmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QuickAdjustmentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickAdjustmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QuickAdjustmentApi(Configuration configuration = null)
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
        /// Create a quickAdjustment Inserts a new quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param> 
        /// <returns>QuickAdjustment</returns>
        public QuickAdjustment AddQuickAdjustment (QuickAdjustment body)
        {
             ApiResponse<QuickAdjustment> localVarResponse = AddQuickAdjustmentWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a quickAdjustment Inserts a new quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param> 
        /// <returns>ApiResponse of QuickAdjustment</returns>
        public ApiResponse< QuickAdjustment > AddQuickAdjustmentWithHttpInfo (QuickAdjustment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QuickAdjustmentApi->AddQuickAdjustment");
            
    
            var localVarPath = "/v2.0/quickAdjustment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickAdjustment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickAdjustment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QuickAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickAdjustment)));
            
        }

        
        /// <summary>
        /// Create a quickAdjustment Inserts a new quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param>
        /// <returns>Task of QuickAdjustment</returns>
        public async System.Threading.Tasks.Task<QuickAdjustment> AddQuickAdjustmentAsync (QuickAdjustment body)
        {
             ApiResponse<QuickAdjustment> localVarResponse = await AddQuickAdjustmentAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a quickAdjustment Inserts a new quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be inserted.</param>
        /// <returns>Task of ApiResponse (QuickAdjustment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickAdjustment>> AddQuickAdjustmentAsyncWithHttpInfo (QuickAdjustment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddQuickAdjustment");
            
    
            var localVarPath = "/v2.0/quickAdjustment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickAdjustment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickAdjustment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QuickAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickAdjustment)));
            
        }
        
        /// <summary>
        /// Delete a quickAdjustment Deletes the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param> 
        /// <returns></returns>
        public void DeleteQuickAdjustment (int? quickAdjustmentId)
        {
             DeleteQuickAdjustmentWithHttpInfo(quickAdjustmentId);
        }

        /// <summary>
        /// Delete a quickAdjustment Deletes the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteQuickAdjustmentWithHttpInfo (int? quickAdjustmentId)
        {
            
            // verify the required parameter 'quickAdjustmentId' is set
            if (quickAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'quickAdjustmentId' when calling QuickAdjustmentApi->DeleteQuickAdjustment");
            
    
            var localVarPath = "/v2.0/quickAdjustment/{quickAdjustmentId}";
    
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
            if (quickAdjustmentId != null) localVarPathParams.Add("quickAdjustmentId", Configuration.ApiClient.ParameterToString(quickAdjustmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickAdjustment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickAdjustment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a quickAdjustment Deletes the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteQuickAdjustmentAsync (int? quickAdjustmentId)
        {
             await DeleteQuickAdjustmentAsyncWithHttpInfo(quickAdjustmentId);

        }

        /// <summary>
        /// Delete a quickAdjustment Deletes the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQuickAdjustmentAsyncWithHttpInfo (int? quickAdjustmentId)
        {
            // verify the required parameter 'quickAdjustmentId' is set
            if (quickAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'quickAdjustmentId' when calling DeleteQuickAdjustment");
            
    
            var localVarPath = "/v2.0/quickAdjustment/{quickAdjustmentId}";
    
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
            if (quickAdjustmentId != null) localVarPathParams.Add("quickAdjustmentId", Configuration.ApiClient.ParameterToString(quickAdjustmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickAdjustment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickAdjustment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a quickAdjustment by id Returns a duplicated quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param> 
        /// <returns>QuickAdjustment</returns>
        public QuickAdjustment GetDuplicateQuickAdjustmentById (int? quickAdjustmentId)
        {
             ApiResponse<QuickAdjustment> localVarResponse = GetDuplicateQuickAdjustmentByIdWithHttpInfo(quickAdjustmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a quickAdjustment by id Returns a duplicated quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param> 
        /// <returns>ApiResponse of QuickAdjustment</returns>
        public ApiResponse< QuickAdjustment > GetDuplicateQuickAdjustmentByIdWithHttpInfo (int? quickAdjustmentId)
        {
            
            // verify the required parameter 'quickAdjustmentId' is set
            if (quickAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'quickAdjustmentId' when calling QuickAdjustmentApi->GetDuplicateQuickAdjustmentById");
            
    
            var localVarPath = "/v2.0/quickAdjustment/duplicate/{quickAdjustmentId}";
    
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
            if (quickAdjustmentId != null) localVarPathParams.Add("quickAdjustmentId", Configuration.ApiClient.ParameterToString(quickAdjustmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QuickAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickAdjustment)));
            
        }

        
        /// <summary>
        /// Get a duplicated a quickAdjustment by id Returns a duplicated quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param>
        /// <returns>Task of QuickAdjustment</returns>
        public async System.Threading.Tasks.Task<QuickAdjustment> GetDuplicateQuickAdjustmentByIdAsync (int? quickAdjustmentId)
        {
             ApiResponse<QuickAdjustment> localVarResponse = await GetDuplicateQuickAdjustmentByIdAsyncWithHttpInfo(quickAdjustmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a quickAdjustment by id Returns a duplicated quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be duplicated.</param>
        /// <returns>Task of ApiResponse (QuickAdjustment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickAdjustment>> GetDuplicateQuickAdjustmentByIdAsyncWithHttpInfo (int? quickAdjustmentId)
        {
            // verify the required parameter 'quickAdjustmentId' is set
            if (quickAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'quickAdjustmentId' when calling GetDuplicateQuickAdjustmentById");
            
    
            var localVarPath = "/v2.0/quickAdjustment/duplicate/{quickAdjustmentId}";
    
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
            if (quickAdjustmentId != null) localVarPathParams.Add("quickAdjustmentId", Configuration.ApiClient.ParameterToString(quickAdjustmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QuickAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickAdjustment)));
            
        }
        
        /// <summary>
        /// Search quickAdjustments by filter Returns the list of quickAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;QuickAdjustment&gt;</returns>
        public List<QuickAdjustment> GetQuickAdjustmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<QuickAdjustment>> localVarResponse = GetQuickAdjustmentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search quickAdjustments by filter Returns the list of quickAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;QuickAdjustment&gt;</returns>
        public ApiResponse< List<QuickAdjustment> > GetQuickAdjustmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/quickAdjustment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<QuickAdjustment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<QuickAdjustment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<QuickAdjustment>)));
            
        }

        
        /// <summary>
        /// Search quickAdjustments by filter Returns the list of quickAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;QuickAdjustment&gt;</returns>
        public async System.Threading.Tasks.Task<List<QuickAdjustment>> GetQuickAdjustmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<QuickAdjustment>> localVarResponse = await GetQuickAdjustmentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search quickAdjustments by filter Returns the list of quickAdjustments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;QuickAdjustment&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<QuickAdjustment>>> GetQuickAdjustmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v2.0/quickAdjustment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<QuickAdjustment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<QuickAdjustment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<QuickAdjustment>)));
            
        }
        
        /// <summary>
        /// Get a quickAdjustment by id Returns the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param> 
        /// <returns>QuickAdjustment</returns>
        public QuickAdjustment GetQuickAdjustmentById (int? quickAdjustmentId)
        {
             ApiResponse<QuickAdjustment> localVarResponse = GetQuickAdjustmentByIdWithHttpInfo(quickAdjustmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a quickAdjustment by id Returns the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param> 
        /// <returns>ApiResponse of QuickAdjustment</returns>
        public ApiResponse< QuickAdjustment > GetQuickAdjustmentByIdWithHttpInfo (int? quickAdjustmentId)
        {
            
            // verify the required parameter 'quickAdjustmentId' is set
            if (quickAdjustmentId == null)
                throw new ApiException(400, "Missing required parameter 'quickAdjustmentId' when calling QuickAdjustmentApi->GetQuickAdjustmentById");
            
    
            var localVarPath = "/v2.0/quickAdjustment/{quickAdjustmentId}";
    
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
            if (quickAdjustmentId != null) localVarPathParams.Add("quickAdjustmentId", Configuration.ApiClient.ParameterToString(quickAdjustmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QuickAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickAdjustment)));
            
        }

        
        /// <summary>
        /// Get a quickAdjustment by id Returns the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param>
        /// <returns>Task of QuickAdjustment</returns>
        public async System.Threading.Tasks.Task<QuickAdjustment> GetQuickAdjustmentByIdAsync (int? quickAdjustmentId)
        {
             ApiResponse<QuickAdjustment> localVarResponse = await GetQuickAdjustmentByIdAsyncWithHttpInfo(quickAdjustmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a quickAdjustment by id Returns the quickAdjustment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickAdjustmentId">Id of the quickAdjustment to be returned.</param>
        /// <returns>Task of ApiResponse (QuickAdjustment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickAdjustment>> GetQuickAdjustmentByIdAsyncWithHttpInfo (int? quickAdjustmentId)
        {
            // verify the required parameter 'quickAdjustmentId' is set
            if (quickAdjustmentId == null) throw new ApiException(400, "Missing required parameter 'quickAdjustmentId' when calling GetQuickAdjustmentById");
            
    
            var localVarPath = "/v2.0/quickAdjustment/{quickAdjustmentId}";
    
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
            if (quickAdjustmentId != null) localVarPathParams.Add("quickAdjustmentId", Configuration.ApiClient.ParameterToString(quickAdjustmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickAdjustmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QuickAdjustment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickAdjustment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickAdjustment)));
            
        }
        
        /// <summary>
        /// Update a quickAdjustment Updates an existing quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param> 
        /// <returns></returns>
        public void UpdateQuickAdjustment (QuickAdjustment body)
        {
             UpdateQuickAdjustmentWithHttpInfo(body);
        }

        /// <summary>
        /// Update a quickAdjustment Updates an existing quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateQuickAdjustmentWithHttpInfo (QuickAdjustment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QuickAdjustmentApi->UpdateQuickAdjustment");
            
    
            var localVarPath = "/v2.0/quickAdjustment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a quickAdjustment Updates an existing quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateQuickAdjustmentAsync (QuickAdjustment body)
        {
             await UpdateQuickAdjustmentAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a quickAdjustment Updates an existing quickAdjustment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickAdjustmentAsyncWithHttpInfo (QuickAdjustment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateQuickAdjustment");
            
    
            var localVarPath = "/v2.0/quickAdjustment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a quickAdjustment custom fields Updates an existing quickAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param> 
        /// <returns></returns>
        public void UpdateQuickAdjustmentCustomFields (QuickAdjustment body)
        {
             UpdateQuickAdjustmentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a quickAdjustment custom fields Updates an existing quickAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateQuickAdjustmentCustomFieldsWithHttpInfo (QuickAdjustment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QuickAdjustmentApi->UpdateQuickAdjustmentCustomFields");
            
    
            var localVarPath = "/v2.0/quickAdjustment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a quickAdjustment custom fields Updates an existing quickAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateQuickAdjustmentCustomFieldsAsync (QuickAdjustment body)
        {
             await UpdateQuickAdjustmentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a quickAdjustment custom fields Updates an existing quickAdjustment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickAdjustment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickAdjustmentCustomFieldsAsyncWithHttpInfo (QuickAdjustment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateQuickAdjustmentCustomFields");
            
    
            var localVarPath = "/v2.0/quickAdjustment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickAdjustmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
