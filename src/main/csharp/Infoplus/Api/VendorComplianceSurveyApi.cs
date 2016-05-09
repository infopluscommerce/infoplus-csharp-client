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
    public interface IVendorComplianceSurveyApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>VendorComplianceSurvey</returns>
        VendorComplianceSurvey AddVendorComplianceSurvey (VendorComplianceSurvey body);
  
        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        ApiResponse<VendorComplianceSurvey> AddVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body);
        
        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns></returns>
        void DeleteVendorComplianceSurvey (int? vendorComplianceSurveyId);
  
        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVendorComplianceSurveyWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;VendorComplianceSurvey&gt;</returns>
        List<VendorComplianceSurvey> GetVendorComplianceSurveyByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;VendorComplianceSurvey&gt;</returns>
        ApiResponse<List<VendorComplianceSurvey>> GetVendorComplianceSurveyByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>VendorComplianceSurvey</returns>
        VendorComplianceSurvey GetVendorComplianceSurveyById (int? vendorComplianceSurveyId);
  
        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        ApiResponse<VendorComplianceSurvey> GetVendorComplianceSurveyByIdWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns></returns>
        void UpdateVendorComplianceSurvey (VendorComplianceSurvey body);
  
        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        System.Threading.Tasks.Task<VendorComplianceSurvey> AddVendorComplianceSurveyAsync (VendorComplianceSurvey body);

        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> AddVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body);
        
        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteVendorComplianceSurveyAsync (int? vendorComplianceSurveyId);

        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVendorComplianceSurveyAsyncWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;VendorComplianceSurvey&gt;</returns>
        System.Threading.Tasks.Task<List<VendorComplianceSurvey>> GetVendorComplianceSurveyByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;VendorComplianceSurvey&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VendorComplianceSurvey>>> GetVendorComplianceSurveyByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        System.Threading.Tasks.Task<VendorComplianceSurvey> GetVendorComplianceSurveyByIdAsync (int? vendorComplianceSurveyId);

        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> GetVendorComplianceSurveyByIdAsyncWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateVendorComplianceSurveyAsync (VendorComplianceSurvey body);

        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VendorComplianceSurveyApi : IVendorComplianceSurveyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorComplianceSurveyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VendorComplianceSurveyApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorComplianceSurveyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VendorComplianceSurveyApi(Configuration configuration = null)
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
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param> 
        /// <returns>VendorComplianceSurvey</returns>
        public VendorComplianceSurvey AddVendorComplianceSurvey (VendorComplianceSurvey body)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = AddVendorComplianceSurveyWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param> 
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        public ApiResponse< VendorComplianceSurvey > AddVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VendorComplianceSurveyApi->AddVendorComplianceSurvey");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }

        
        /// <summary>
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        public async System.Threading.Tasks.Task<VendorComplianceSurvey> AddVendorComplianceSurveyAsync (VendorComplianceSurvey body)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = await AddVendorComplianceSurveyAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> AddVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddVendorComplianceSurvey");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }
        
        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param> 
        /// <returns></returns>
        public void DeleteVendorComplianceSurvey (int? vendorComplianceSurveyId)
        {
             DeleteVendorComplianceSurveyWithHttpInfo(vendorComplianceSurveyId);
        }

        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteVendorComplianceSurveyWithHttpInfo (int? vendorComplianceSurveyId)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->DeleteVendorComplianceSurvey");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteVendorComplianceSurveyAsync (int? vendorComplianceSurveyId)
        {
             await DeleteVendorComplianceSurveyAsyncWithHttpInfo(vendorComplianceSurveyId);

        }

        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVendorComplianceSurveyAsyncWithHttpInfo (int? vendorComplianceSurveyId)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling DeleteVendorComplianceSurvey");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;VendorComplianceSurvey&gt;</returns>
        public List<VendorComplianceSurvey> GetVendorComplianceSurveyByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<VendorComplianceSurvey>> localVarResponse = GetVendorComplianceSurveyByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;VendorComplianceSurvey&gt;</returns>
        public ApiResponse< List<VendorComplianceSurvey> > GetVendorComplianceSurveyByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<VendorComplianceSurvey>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VendorComplianceSurvey>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VendorComplianceSurvey>)));
            
        }

        
        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;VendorComplianceSurvey&gt;</returns>
        public async System.Threading.Tasks.Task<List<VendorComplianceSurvey>> GetVendorComplianceSurveyByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<VendorComplianceSurvey>> localVarResponse = await GetVendorComplianceSurveyByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;VendorComplianceSurvey&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<VendorComplianceSurvey>>> GetVendorComplianceSurveyByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<VendorComplianceSurvey>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VendorComplianceSurvey>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VendorComplianceSurvey>)));
            
        }
        
        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param> 
        /// <returns>VendorComplianceSurvey</returns>
        public VendorComplianceSurvey GetVendorComplianceSurveyById (int? vendorComplianceSurveyId)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = GetVendorComplianceSurveyByIdWithHttpInfo(vendorComplianceSurveyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param> 
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        public ApiResponse< VendorComplianceSurvey > GetVendorComplianceSurveyByIdWithHttpInfo (int? vendorComplianceSurveyId)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->GetVendorComplianceSurveyById");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }

        
        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        public async System.Threading.Tasks.Task<VendorComplianceSurvey> GetVendorComplianceSurveyByIdAsync (int? vendorComplianceSurveyId)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = await GetVendorComplianceSurveyByIdAsyncWithHttpInfo(vendorComplianceSurveyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> GetVendorComplianceSurveyByIdAsyncWithHttpInfo (int? vendorComplianceSurveyId)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling GetVendorComplianceSurveyById");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }
        
        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param> 
        /// <returns></returns>
        public void UpdateVendorComplianceSurvey (VendorComplianceSurvey body)
        {
             UpdateVendorComplianceSurveyWithHttpInfo(body);
        }

        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VendorComplianceSurveyApi->UpdateVendorComplianceSurvey");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateVendorComplianceSurveyAsync (VendorComplianceSurvey body)
        {
             await UpdateVendorComplianceSurveyAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateVendorComplianceSurvey");
            
    
            var localVarPath = "/v1.0/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
