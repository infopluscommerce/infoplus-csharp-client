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
    public interface IPickFaceAssignmentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Inserts a new pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param>
        /// <returns>PickFaceAssignment</returns>
        PickFaceAssignment AddPickFaceAssignment (PickFaceAssignment body);
  
        /// <summary>
        /// Create a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Inserts a new pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param>
        /// <returns>ApiResponse of PickFaceAssignment</returns>
        ApiResponse<PickFaceAssignment> AddPickFaceAssignmentWithHttpInfo (PickFaceAssignment body);
        
        /// <summary>
        /// Delete a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Deletes the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param>
        /// <returns></returns>
        void DeletePickFaceAssignment (int? pickFaceAssignmentId);
  
        /// <summary>
        /// Delete a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Deletes the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePickFaceAssignmentWithHttpInfo (int? pickFaceAssignmentId);
        
        /// <summary>
        /// Search pickFaceAssignments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of pickFaceAssignments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;PickFaceAssignment&gt;</returns>
        List<PickFaceAssignment> GetPickFaceAssignmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search pickFaceAssignments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of pickFaceAssignments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;PickFaceAssignment&gt;</returns>
        ApiResponse<List<PickFaceAssignment>> GetPickFaceAssignmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a pickFaceAssignment by id
        /// </summary>
        /// <remarks>
        /// Returns the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param>
        /// <returns>PickFaceAssignment</returns>
        PickFaceAssignment GetPickFaceAssignmentById (int? pickFaceAssignmentId);
  
        /// <summary>
        /// Get a pickFaceAssignment by id
        /// </summary>
        /// <remarks>
        /// Returns the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param>
        /// <returns>ApiResponse of PickFaceAssignment</returns>
        ApiResponse<PickFaceAssignment> GetPickFaceAssignmentByIdWithHttpInfo (int? pickFaceAssignmentId);
        
        /// <summary>
        /// Update a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns></returns>
        void UpdatePickFaceAssignment (PickFaceAssignment body);
  
        /// <summary>
        /// Update a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdatePickFaceAssignmentWithHttpInfo (PickFaceAssignment body);
        
        /// <summary>
        /// Update a pickFaceAssignment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns></returns>
        void UpdatePickFaceAssignmentCustomFields (PickFaceAssignment body);
  
        /// <summary>
        /// Update a pickFaceAssignment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdatePickFaceAssignmentCustomFieldsWithHttpInfo (PickFaceAssignment body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Inserts a new pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param>
        /// <returns>Task of PickFaceAssignment</returns>
        System.Threading.Tasks.Task<PickFaceAssignment> AddPickFaceAssignmentAsync (PickFaceAssignment body);

        /// <summary>
        /// Create a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Inserts a new pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param>
        /// <returns>Task of ApiResponse (PickFaceAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<PickFaceAssignment>> AddPickFaceAssignmentAsyncWithHttpInfo (PickFaceAssignment body);
        
        /// <summary>
        /// Delete a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Deletes the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePickFaceAssignmentAsync (int? pickFaceAssignmentId);

        /// <summary>
        /// Delete a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Deletes the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePickFaceAssignmentAsyncWithHttpInfo (int? pickFaceAssignmentId);
        
        /// <summary>
        /// Search pickFaceAssignments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of pickFaceAssignments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;PickFaceAssignment&gt;</returns>
        System.Threading.Tasks.Task<List<PickFaceAssignment>> GetPickFaceAssignmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search pickFaceAssignments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of pickFaceAssignments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PickFaceAssignment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PickFaceAssignment>>> GetPickFaceAssignmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a pickFaceAssignment by id
        /// </summary>
        /// <remarks>
        /// Returns the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param>
        /// <returns>Task of PickFaceAssignment</returns>
        System.Threading.Tasks.Task<PickFaceAssignment> GetPickFaceAssignmentByIdAsync (int? pickFaceAssignmentId);

        /// <summary>
        /// Get a pickFaceAssignment by id
        /// </summary>
        /// <remarks>
        /// Returns the pickFaceAssignment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param>
        /// <returns>Task of ApiResponse (PickFaceAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<PickFaceAssignment>> GetPickFaceAssignmentByIdAsyncWithHttpInfo (int? pickFaceAssignmentId);
        
        /// <summary>
        /// Update a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdatePickFaceAssignmentAsync (PickFaceAssignment body);

        /// <summary>
        /// Update a pickFaceAssignment
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePickFaceAssignmentAsyncWithHttpInfo (PickFaceAssignment body);
        
        /// <summary>
        /// Update a pickFaceAssignment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdatePickFaceAssignmentCustomFieldsAsync (PickFaceAssignment body);

        /// <summary>
        /// Update a pickFaceAssignment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePickFaceAssignmentCustomFieldsAsyncWithHttpInfo (PickFaceAssignment body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PickFaceAssignmentApi : IPickFaceAssignmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PickFaceAssignmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PickFaceAssignmentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PickFaceAssignmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PickFaceAssignmentApi(Configuration configuration = null)
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
        /// Create a pickFaceAssignment Inserts a new pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param> 
        /// <returns>PickFaceAssignment</returns>
        public PickFaceAssignment AddPickFaceAssignment (PickFaceAssignment body)
        {
             ApiResponse<PickFaceAssignment> localVarResponse = AddPickFaceAssignmentWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a pickFaceAssignment Inserts a new pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param> 
        /// <returns>ApiResponse of PickFaceAssignment</returns>
        public ApiResponse< PickFaceAssignment > AddPickFaceAssignmentWithHttpInfo (PickFaceAssignment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PickFaceAssignmentApi->AddPickFaceAssignment");
            
    
            var localVarPath = "/beta/pickFaceAssignment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddPickFaceAssignment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPickFaceAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PickFaceAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PickFaceAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PickFaceAssignment)));
            
        }

        
        /// <summary>
        /// Create a pickFaceAssignment Inserts a new pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param>
        /// <returns>Task of PickFaceAssignment</returns>
        public async System.Threading.Tasks.Task<PickFaceAssignment> AddPickFaceAssignmentAsync (PickFaceAssignment body)
        {
             ApiResponse<PickFaceAssignment> localVarResponse = await AddPickFaceAssignmentAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a pickFaceAssignment Inserts a new pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be inserted.</param>
        /// <returns>Task of ApiResponse (PickFaceAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PickFaceAssignment>> AddPickFaceAssignmentAsyncWithHttpInfo (PickFaceAssignment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddPickFaceAssignment");
            
    
            var localVarPath = "/beta/pickFaceAssignment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddPickFaceAssignment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPickFaceAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PickFaceAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PickFaceAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PickFaceAssignment)));
            
        }
        
        /// <summary>
        /// Delete a pickFaceAssignment Deletes the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param> 
        /// <returns></returns>
        public void DeletePickFaceAssignment (int? pickFaceAssignmentId)
        {
             DeletePickFaceAssignmentWithHttpInfo(pickFaceAssignmentId);
        }

        /// <summary>
        /// Delete a pickFaceAssignment Deletes the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePickFaceAssignmentWithHttpInfo (int? pickFaceAssignmentId)
        {
            
            // verify the required parameter 'pickFaceAssignmentId' is set
            if (pickFaceAssignmentId == null)
                throw new ApiException(400, "Missing required parameter 'pickFaceAssignmentId' when calling PickFaceAssignmentApi->DeletePickFaceAssignment");
            
    
            var localVarPath = "/beta/pickFaceAssignment/{pickFaceAssignmentId}";
    
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
            if (pickFaceAssignmentId != null) localVarPathParams.Add("pickFaceAssignmentId", Configuration.ApiClient.ParameterToString(pickFaceAssignmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePickFaceAssignment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePickFaceAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a pickFaceAssignment Deletes the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePickFaceAssignmentAsync (int? pickFaceAssignmentId)
        {
             await DeletePickFaceAssignmentAsyncWithHttpInfo(pickFaceAssignmentId);

        }

        /// <summary>
        /// Delete a pickFaceAssignment Deletes the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePickFaceAssignmentAsyncWithHttpInfo (int? pickFaceAssignmentId)
        {
            // verify the required parameter 'pickFaceAssignmentId' is set
            if (pickFaceAssignmentId == null) throw new ApiException(400, "Missing required parameter 'pickFaceAssignmentId' when calling DeletePickFaceAssignment");
            
    
            var localVarPath = "/beta/pickFaceAssignment/{pickFaceAssignmentId}";
    
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
            if (pickFaceAssignmentId != null) localVarPathParams.Add("pickFaceAssignmentId", Configuration.ApiClient.ParameterToString(pickFaceAssignmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeletePickFaceAssignment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePickFaceAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search pickFaceAssignments by filter Returns the list of pickFaceAssignments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;PickFaceAssignment&gt;</returns>
        public List<PickFaceAssignment> GetPickFaceAssignmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<PickFaceAssignment>> localVarResponse = GetPickFaceAssignmentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search pickFaceAssignments by filter Returns the list of pickFaceAssignments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;PickFaceAssignment&gt;</returns>
        public ApiResponse< List<PickFaceAssignment> > GetPickFaceAssignmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/pickFaceAssignment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<PickFaceAssignment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PickFaceAssignment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PickFaceAssignment>)));
            
        }

        
        /// <summary>
        /// Search pickFaceAssignments by filter Returns the list of pickFaceAssignments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;PickFaceAssignment&gt;</returns>
        public async System.Threading.Tasks.Task<List<PickFaceAssignment>> GetPickFaceAssignmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<PickFaceAssignment>> localVarResponse = await GetPickFaceAssignmentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search pickFaceAssignments by filter Returns the list of pickFaceAssignments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PickFaceAssignment&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PickFaceAssignment>>> GetPickFaceAssignmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/pickFaceAssignment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<PickFaceAssignment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PickFaceAssignment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PickFaceAssignment>)));
            
        }
        
        /// <summary>
        /// Get a pickFaceAssignment by id Returns the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param> 
        /// <returns>PickFaceAssignment</returns>
        public PickFaceAssignment GetPickFaceAssignmentById (int? pickFaceAssignmentId)
        {
             ApiResponse<PickFaceAssignment> localVarResponse = GetPickFaceAssignmentByIdWithHttpInfo(pickFaceAssignmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pickFaceAssignment by id Returns the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param> 
        /// <returns>ApiResponse of PickFaceAssignment</returns>
        public ApiResponse< PickFaceAssignment > GetPickFaceAssignmentByIdWithHttpInfo (int? pickFaceAssignmentId)
        {
            
            // verify the required parameter 'pickFaceAssignmentId' is set
            if (pickFaceAssignmentId == null)
                throw new ApiException(400, "Missing required parameter 'pickFaceAssignmentId' when calling PickFaceAssignmentApi->GetPickFaceAssignmentById");
            
    
            var localVarPath = "/beta/pickFaceAssignment/{pickFaceAssignmentId}";
    
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
            if (pickFaceAssignmentId != null) localVarPathParams.Add("pickFaceAssignmentId", Configuration.ApiClient.ParameterToString(pickFaceAssignmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PickFaceAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PickFaceAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PickFaceAssignment)));
            
        }

        
        /// <summary>
        /// Get a pickFaceAssignment by id Returns the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param>
        /// <returns>Task of PickFaceAssignment</returns>
        public async System.Threading.Tasks.Task<PickFaceAssignment> GetPickFaceAssignmentByIdAsync (int? pickFaceAssignmentId)
        {
             ApiResponse<PickFaceAssignment> localVarResponse = await GetPickFaceAssignmentByIdAsyncWithHttpInfo(pickFaceAssignmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pickFaceAssignment by id Returns the pickFaceAssignment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pickFaceAssignmentId">Id of the pickFaceAssignment to be returned.</param>
        /// <returns>Task of ApiResponse (PickFaceAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PickFaceAssignment>> GetPickFaceAssignmentByIdAsyncWithHttpInfo (int? pickFaceAssignmentId)
        {
            // verify the required parameter 'pickFaceAssignmentId' is set
            if (pickFaceAssignmentId == null) throw new ApiException(400, "Missing required parameter 'pickFaceAssignmentId' when calling GetPickFaceAssignmentById");
            
    
            var localVarPath = "/beta/pickFaceAssignment/{pickFaceAssignmentId}";
    
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
            if (pickFaceAssignmentId != null) localVarPathParams.Add("pickFaceAssignmentId", Configuration.ApiClient.ParameterToString(pickFaceAssignmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPickFaceAssignmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PickFaceAssignment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PickFaceAssignment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PickFaceAssignment)));
            
        }
        
        /// <summary>
        /// Update a pickFaceAssignment Updates an existing pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param> 
        /// <returns></returns>
        public void UpdatePickFaceAssignment (PickFaceAssignment body)
        {
             UpdatePickFaceAssignmentWithHttpInfo(body);
        }

        /// <summary>
        /// Update a pickFaceAssignment Updates an existing pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdatePickFaceAssignmentWithHttpInfo (PickFaceAssignment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PickFaceAssignmentApi->UpdatePickFaceAssignment");
            
    
            var localVarPath = "/beta/pickFaceAssignment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a pickFaceAssignment Updates an existing pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdatePickFaceAssignmentAsync (PickFaceAssignment body)
        {
             await UpdatePickFaceAssignmentAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a pickFaceAssignment Updates an existing pickFaceAssignment using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePickFaceAssignmentAsyncWithHttpInfo (PickFaceAssignment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePickFaceAssignment");
            
    
            var localVarPath = "/beta/pickFaceAssignment";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a pickFaceAssignment custom fields Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param> 
        /// <returns></returns>
        public void UpdatePickFaceAssignmentCustomFields (PickFaceAssignment body)
        {
             UpdatePickFaceAssignmentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a pickFaceAssignment custom fields Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdatePickFaceAssignmentCustomFieldsWithHttpInfo (PickFaceAssignment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PickFaceAssignmentApi->UpdatePickFaceAssignmentCustomFields");
            
    
            var localVarPath = "/beta/pickFaceAssignment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a pickFaceAssignment custom fields Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdatePickFaceAssignmentCustomFieldsAsync (PickFaceAssignment body)
        {
             await UpdatePickFaceAssignmentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a pickFaceAssignment custom fields Updates an existing pickFaceAssignment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PickFaceAssignment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePickFaceAssignmentCustomFieldsAsyncWithHttpInfo (PickFaceAssignment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePickFaceAssignmentCustomFields");
            
    
            var localVarPath = "/beta/pickFaceAssignment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePickFaceAssignmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
