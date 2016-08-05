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
    public interface ISubstitutionApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a substitution
        /// </summary>
        /// <remarks>
        /// Inserts a new substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param>
        /// <returns>Substitution</returns>
        Substitution AddSubstitution (Substitution body);
  
        /// <summary>
        /// Create a substitution
        /// </summary>
        /// <remarks>
        /// Inserts a new substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param>
        /// <returns>ApiResponse of Substitution</returns>
        ApiResponse<Substitution> AddSubstitutionWithHttpInfo (Substitution body);
        
        /// <summary>
        /// Delete a substitution
        /// </summary>
        /// <remarks>
        /// Deletes the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param>
        /// <returns></returns>
        void DeleteSubstitution (int? substitutionId);
  
        /// <summary>
        /// Delete a substitution
        /// </summary>
        /// <remarks>
        /// Deletes the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSubstitutionWithHttpInfo (int? substitutionId);
        
        /// <summary>
        /// Search substitutions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of substitutions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;Substitution&gt;</returns>
        List<Substitution> GetSubstitutionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search substitutions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of substitutions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;Substitution&gt;</returns>
        ApiResponse<List<Substitution>> GetSubstitutionByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a substitution by id
        /// </summary>
        /// <remarks>
        /// Returns the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param>
        /// <returns>Substitution</returns>
        Substitution GetSubstitutionById (int? substitutionId);
  
        /// <summary>
        /// Get a substitution by id
        /// </summary>
        /// <remarks>
        /// Returns the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param>
        /// <returns>ApiResponse of Substitution</returns>
        ApiResponse<Substitution> GetSubstitutionByIdWithHttpInfo (int? substitutionId);
        
        /// <summary>
        /// Update a substitution
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns></returns>
        void UpdateSubstitution (Substitution body);
  
        /// <summary>
        /// Update a substitution
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateSubstitutionWithHttpInfo (Substitution body);
        
        /// <summary>
        /// Update a substitution custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns></returns>
        void UpdateSubstitutionCustomFields (Substitution body);
  
        /// <summary>
        /// Update a substitution custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateSubstitutionCustomFieldsWithHttpInfo (Substitution body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a substitution
        /// </summary>
        /// <remarks>
        /// Inserts a new substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param>
        /// <returns>Task of Substitution</returns>
        System.Threading.Tasks.Task<Substitution> AddSubstitutionAsync (Substitution body);

        /// <summary>
        /// Create a substitution
        /// </summary>
        /// <remarks>
        /// Inserts a new substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param>
        /// <returns>Task of ApiResponse (Substitution)</returns>
        System.Threading.Tasks.Task<ApiResponse<Substitution>> AddSubstitutionAsyncWithHttpInfo (Substitution body);
        
        /// <summary>
        /// Delete a substitution
        /// </summary>
        /// <remarks>
        /// Deletes the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSubstitutionAsync (int? substitutionId);

        /// <summary>
        /// Delete a substitution
        /// </summary>
        /// <remarks>
        /// Deletes the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSubstitutionAsyncWithHttpInfo (int? substitutionId);
        
        /// <summary>
        /// Search substitutions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of substitutions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;Substitution&gt;</returns>
        System.Threading.Tasks.Task<List<Substitution>> GetSubstitutionByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search substitutions by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of substitutions that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Substitution&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Substitution>>> GetSubstitutionByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a substitution by id
        /// </summary>
        /// <remarks>
        /// Returns the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param>
        /// <returns>Task of Substitution</returns>
        System.Threading.Tasks.Task<Substitution> GetSubstitutionByIdAsync (int? substitutionId);

        /// <summary>
        /// Get a substitution by id
        /// </summary>
        /// <remarks>
        /// Returns the substitution identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param>
        /// <returns>Task of ApiResponse (Substitution)</returns>
        System.Threading.Tasks.Task<ApiResponse<Substitution>> GetSubstitutionByIdAsyncWithHttpInfo (int? substitutionId);
        
        /// <summary>
        /// Update a substitution
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateSubstitutionAsync (Substitution body);

        /// <summary>
        /// Update a substitution
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSubstitutionAsyncWithHttpInfo (Substitution body);
        
        /// <summary>
        /// Update a substitution custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateSubstitutionCustomFieldsAsync (Substitution body);

        /// <summary>
        /// Update a substitution custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing substitution custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSubstitutionCustomFieldsAsyncWithHttpInfo (Substitution body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubstitutionApi : ISubstitutionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubstitutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubstitutionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubstitutionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubstitutionApi(Configuration configuration = null)
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
        /// Create a substitution Inserts a new substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param> 
        /// <returns>Substitution</returns>
        public Substitution AddSubstitution (Substitution body)
        {
             ApiResponse<Substitution> localVarResponse = AddSubstitutionWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a substitution Inserts a new substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param> 
        /// <returns>ApiResponse of Substitution</returns>
        public ApiResponse< Substitution > AddSubstitutionWithHttpInfo (Substitution body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SubstitutionApi->AddSubstitution");
            
    
            var localVarPath = "/beta/substitution";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddSubstitution: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddSubstitution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Substitution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Substitution) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Substitution)));
            
        }

        
        /// <summary>
        /// Create a substitution Inserts a new substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param>
        /// <returns>Task of Substitution</returns>
        public async System.Threading.Tasks.Task<Substitution> AddSubstitutionAsync (Substitution body)
        {
             ApiResponse<Substitution> localVarResponse = await AddSubstitutionAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a substitution Inserts a new substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be inserted.</param>
        /// <returns>Task of ApiResponse (Substitution)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Substitution>> AddSubstitutionAsyncWithHttpInfo (Substitution body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddSubstitution");
            
    
            var localVarPath = "/beta/substitution";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddSubstitution: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddSubstitution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Substitution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Substitution) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Substitution)));
            
        }
        
        /// <summary>
        /// Delete a substitution Deletes the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param> 
        /// <returns></returns>
        public void DeleteSubstitution (int? substitutionId)
        {
             DeleteSubstitutionWithHttpInfo(substitutionId);
        }

        /// <summary>
        /// Delete a substitution Deletes the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSubstitutionWithHttpInfo (int? substitutionId)
        {
            
            // verify the required parameter 'substitutionId' is set
            if (substitutionId == null)
                throw new ApiException(400, "Missing required parameter 'substitutionId' when calling SubstitutionApi->DeleteSubstitution");
            
    
            var localVarPath = "/beta/substitution/{substitutionId}";
    
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
            if (substitutionId != null) localVarPathParams.Add("substitutionId", Configuration.ApiClient.ParameterToString(substitutionId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSubstitution: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSubstitution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a substitution Deletes the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSubstitutionAsync (int? substitutionId)
        {
             await DeleteSubstitutionAsyncWithHttpInfo(substitutionId);

        }

        /// <summary>
        /// Delete a substitution Deletes the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSubstitutionAsyncWithHttpInfo (int? substitutionId)
        {
            // verify the required parameter 'substitutionId' is set
            if (substitutionId == null) throw new ApiException(400, "Missing required parameter 'substitutionId' when calling DeleteSubstitution");
            
    
            var localVarPath = "/beta/substitution/{substitutionId}";
    
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
            if (substitutionId != null) localVarPathParams.Add("substitutionId", Configuration.ApiClient.ParameterToString(substitutionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSubstitution: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSubstitution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search substitutions by filter Returns the list of substitutions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;Substitution&gt;</returns>
        public List<Substitution> GetSubstitutionByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<Substitution>> localVarResponse = GetSubstitutionByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search substitutions by filter Returns the list of substitutions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;Substitution&gt;</returns>
        public ApiResponse< List<Substitution> > GetSubstitutionByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/substitution/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Substitution>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Substitution>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Substitution>)));
            
        }

        
        /// <summary>
        /// Search substitutions by filter Returns the list of substitutions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;Substitution&gt;</returns>
        public async System.Threading.Tasks.Task<List<Substitution>> GetSubstitutionByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<Substitution>> localVarResponse = await GetSubstitutionByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search substitutions by filter Returns the list of substitutions that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Substitution&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Substitution>>> GetSubstitutionByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/substitution/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Substitution>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Substitution>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Substitution>)));
            
        }
        
        /// <summary>
        /// Get a substitution by id Returns the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param> 
        /// <returns>Substitution</returns>
        public Substitution GetSubstitutionById (int? substitutionId)
        {
             ApiResponse<Substitution> localVarResponse = GetSubstitutionByIdWithHttpInfo(substitutionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a substitution by id Returns the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param> 
        /// <returns>ApiResponse of Substitution</returns>
        public ApiResponse< Substitution > GetSubstitutionByIdWithHttpInfo (int? substitutionId)
        {
            
            // verify the required parameter 'substitutionId' is set
            if (substitutionId == null)
                throw new ApiException(400, "Missing required parameter 'substitutionId' when calling SubstitutionApi->GetSubstitutionById");
            
    
            var localVarPath = "/beta/substitution/{substitutionId}";
    
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
            if (substitutionId != null) localVarPathParams.Add("substitutionId", Configuration.ApiClient.ParameterToString(substitutionId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Substitution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Substitution) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Substitution)));
            
        }

        
        /// <summary>
        /// Get a substitution by id Returns the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param>
        /// <returns>Task of Substitution</returns>
        public async System.Threading.Tasks.Task<Substitution> GetSubstitutionByIdAsync (int? substitutionId)
        {
             ApiResponse<Substitution> localVarResponse = await GetSubstitutionByIdAsyncWithHttpInfo(substitutionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a substitution by id Returns the substitution identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="substitutionId">Id of the substitution to be returned.</param>
        /// <returns>Task of ApiResponse (Substitution)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Substitution>> GetSubstitutionByIdAsyncWithHttpInfo (int? substitutionId)
        {
            // verify the required parameter 'substitutionId' is set
            if (substitutionId == null) throw new ApiException(400, "Missing required parameter 'substitutionId' when calling GetSubstitutionById");
            
    
            var localVarPath = "/beta/substitution/{substitutionId}";
    
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
            if (substitutionId != null) localVarPathParams.Add("substitutionId", Configuration.ApiClient.ParameterToString(substitutionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSubstitutionById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Substitution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Substitution) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Substitution)));
            
        }
        
        /// <summary>
        /// Update a substitution Updates an existing substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param> 
        /// <returns></returns>
        public void UpdateSubstitution (Substitution body)
        {
             UpdateSubstitutionWithHttpInfo(body);
        }

        /// <summary>
        /// Update a substitution Updates an existing substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateSubstitutionWithHttpInfo (Substitution body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SubstitutionApi->UpdateSubstitution");
            
    
            var localVarPath = "/beta/substitution";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitution: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a substitution Updates an existing substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateSubstitutionAsync (Substitution body)
        {
             await UpdateSubstitutionAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a substitution Updates an existing substitution using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSubstitutionAsyncWithHttpInfo (Substitution body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateSubstitution");
            
    
            var localVarPath = "/beta/substitution";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitution: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitution: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a substitution custom fields Updates an existing substitution custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param> 
        /// <returns></returns>
        public void UpdateSubstitutionCustomFields (Substitution body)
        {
             UpdateSubstitutionCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a substitution custom fields Updates an existing substitution custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateSubstitutionCustomFieldsWithHttpInfo (Substitution body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SubstitutionApi->UpdateSubstitutionCustomFields");
            
    
            var localVarPath = "/beta/substitution/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitutionCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitutionCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a substitution custom fields Updates an existing substitution custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateSubstitutionCustomFieldsAsync (Substitution body)
        {
             await UpdateSubstitutionCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a substitution custom fields Updates an existing substitution custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Substitution to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSubstitutionCustomFieldsAsyncWithHttpInfo (Substitution body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateSubstitutionCustomFields");
            
    
            var localVarPath = "/beta/substitution/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitutionCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateSubstitutionCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
