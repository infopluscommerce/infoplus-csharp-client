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
    public interface IFulfillmentPlanApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Inserts a new fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param>
        /// <returns>FulfillmentPlan</returns>
        FulfillmentPlan AddFulfillmentPlan (FulfillmentPlan body);
  
        /// <summary>
        /// Create a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Inserts a new fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param>
        /// <returns>ApiResponse of FulfillmentPlan</returns>
        ApiResponse<FulfillmentPlan> AddFulfillmentPlanWithHttpInfo (FulfillmentPlan body);
        
        /// <summary>
        /// Delete a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Deletes the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param>
        /// <returns></returns>
        void DeleteFulfillmentPlan (int? fulfillmentPlanId);
  
        /// <summary>
        /// Delete a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Deletes the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFulfillmentPlanWithHttpInfo (int? fulfillmentPlanId);
        
        /// <summary>
        /// Search fulfillmentPlans by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentPlans that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;FulfillmentPlan&gt;</returns>
        List<FulfillmentPlan> GetFulfillmentPlanByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search fulfillmentPlans by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentPlans that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;FulfillmentPlan&gt;</returns>
        ApiResponse<List<FulfillmentPlan>> GetFulfillmentPlanByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a fulfillmentPlan by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param>
        /// <returns>FulfillmentPlan</returns>
        FulfillmentPlan GetFulfillmentPlanById (int? fulfillmentPlanId);
  
        /// <summary>
        /// Get a fulfillmentPlan by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param>
        /// <returns>ApiResponse of FulfillmentPlan</returns>
        ApiResponse<FulfillmentPlan> GetFulfillmentPlanByIdWithHttpInfo (int? fulfillmentPlanId);
        
        /// <summary>
        /// Update a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns></returns>
        void UpdateFulfillmentPlan (FulfillmentPlan body);
  
        /// <summary>
        /// Update a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateFulfillmentPlanWithHttpInfo (FulfillmentPlan body);
        
        /// <summary>
        /// Update a fulfillmentPlan custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns></returns>
        void UpdateFulfillmentPlanCustomFields (FulfillmentPlan body);
  
        /// <summary>
        /// Update a fulfillmentPlan custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateFulfillmentPlanCustomFieldsWithHttpInfo (FulfillmentPlan body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Inserts a new fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param>
        /// <returns>Task of FulfillmentPlan</returns>
        System.Threading.Tasks.Task<FulfillmentPlan> AddFulfillmentPlanAsync (FulfillmentPlan body);

        /// <summary>
        /// Create a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Inserts a new fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param>
        /// <returns>Task of ApiResponse (FulfillmentPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<FulfillmentPlan>> AddFulfillmentPlanAsyncWithHttpInfo (FulfillmentPlan body);
        
        /// <summary>
        /// Delete a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Deletes the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFulfillmentPlanAsync (int? fulfillmentPlanId);

        /// <summary>
        /// Delete a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Deletes the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFulfillmentPlanAsyncWithHttpInfo (int? fulfillmentPlanId);
        
        /// <summary>
        /// Search fulfillmentPlans by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentPlans that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;FulfillmentPlan&gt;</returns>
        System.Threading.Tasks.Task<List<FulfillmentPlan>> GetFulfillmentPlanByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search fulfillmentPlans by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentPlans that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FulfillmentPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FulfillmentPlan>>> GetFulfillmentPlanByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a fulfillmentPlan by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param>
        /// <returns>Task of FulfillmentPlan</returns>
        System.Threading.Tasks.Task<FulfillmentPlan> GetFulfillmentPlanByIdAsync (int? fulfillmentPlanId);

        /// <summary>
        /// Get a fulfillmentPlan by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentPlan identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param>
        /// <returns>Task of ApiResponse (FulfillmentPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<FulfillmentPlan>> GetFulfillmentPlanByIdAsyncWithHttpInfo (int? fulfillmentPlanId);
        
        /// <summary>
        /// Update a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateFulfillmentPlanAsync (FulfillmentPlan body);

        /// <summary>
        /// Update a fulfillmentPlan
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFulfillmentPlanAsyncWithHttpInfo (FulfillmentPlan body);
        
        /// <summary>
        /// Update a fulfillmentPlan custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateFulfillmentPlanCustomFieldsAsync (FulfillmentPlan body);

        /// <summary>
        /// Update a fulfillmentPlan custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFulfillmentPlanCustomFieldsAsyncWithHttpInfo (FulfillmentPlan body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FulfillmentPlanApi : IFulfillmentPlanApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPlanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FulfillmentPlanApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPlanApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FulfillmentPlanApi(Configuration configuration = null)
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
        /// Create a fulfillmentPlan Inserts a new fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param> 
        /// <returns>FulfillmentPlan</returns>
        public FulfillmentPlan AddFulfillmentPlan (FulfillmentPlan body)
        {
             ApiResponse<FulfillmentPlan> localVarResponse = AddFulfillmentPlanWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a fulfillmentPlan Inserts a new fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param> 
        /// <returns>ApiResponse of FulfillmentPlan</returns>
        public ApiResponse< FulfillmentPlan > AddFulfillmentPlanWithHttpInfo (FulfillmentPlan body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling FulfillmentPlanApi->AddFulfillmentPlan");
            
    
            var localVarPath = "/beta/fulfillmentPlan";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentPlan: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentPlan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FulfillmentPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentPlan)));
            
        }

        
        /// <summary>
        /// Create a fulfillmentPlan Inserts a new fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param>
        /// <returns>Task of FulfillmentPlan</returns>
        public async System.Threading.Tasks.Task<FulfillmentPlan> AddFulfillmentPlanAsync (FulfillmentPlan body)
        {
             ApiResponse<FulfillmentPlan> localVarResponse = await AddFulfillmentPlanAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a fulfillmentPlan Inserts a new fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be inserted.</param>
        /// <returns>Task of ApiResponse (FulfillmentPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FulfillmentPlan>> AddFulfillmentPlanAsyncWithHttpInfo (FulfillmentPlan body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddFulfillmentPlan");
            
    
            var localVarPath = "/beta/fulfillmentPlan";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentPlan: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddFulfillmentPlan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FulfillmentPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentPlan)));
            
        }
        
        /// <summary>
        /// Delete a fulfillmentPlan Deletes the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param> 
        /// <returns></returns>
        public void DeleteFulfillmentPlan (int? fulfillmentPlanId)
        {
             DeleteFulfillmentPlanWithHttpInfo(fulfillmentPlanId);
        }

        /// <summary>
        /// Delete a fulfillmentPlan Deletes the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFulfillmentPlanWithHttpInfo (int? fulfillmentPlanId)
        {
            
            // verify the required parameter 'fulfillmentPlanId' is set
            if (fulfillmentPlanId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentPlanId' when calling FulfillmentPlanApi->DeleteFulfillmentPlan");
            
    
            var localVarPath = "/beta/fulfillmentPlan/{fulfillmentPlanId}";
    
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
            if (fulfillmentPlanId != null) localVarPathParams.Add("fulfillmentPlanId", Configuration.ApiClient.ParameterToString(fulfillmentPlanId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentPlan: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentPlan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a fulfillmentPlan Deletes the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFulfillmentPlanAsync (int? fulfillmentPlanId)
        {
             await DeleteFulfillmentPlanAsyncWithHttpInfo(fulfillmentPlanId);

        }

        /// <summary>
        /// Delete a fulfillmentPlan Deletes the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFulfillmentPlanAsyncWithHttpInfo (int? fulfillmentPlanId)
        {
            // verify the required parameter 'fulfillmentPlanId' is set
            if (fulfillmentPlanId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentPlanId' when calling DeleteFulfillmentPlan");
            
    
            var localVarPath = "/beta/fulfillmentPlan/{fulfillmentPlanId}";
    
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
            if (fulfillmentPlanId != null) localVarPathParams.Add("fulfillmentPlanId", Configuration.ApiClient.ParameterToString(fulfillmentPlanId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentPlan: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFulfillmentPlan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search fulfillmentPlans by filter Returns the list of fulfillmentPlans that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;FulfillmentPlan&gt;</returns>
        public List<FulfillmentPlan> GetFulfillmentPlanByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<FulfillmentPlan>> localVarResponse = GetFulfillmentPlanByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search fulfillmentPlans by filter Returns the list of fulfillmentPlans that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;FulfillmentPlan&gt;</returns>
        public ApiResponse< List<FulfillmentPlan> > GetFulfillmentPlanByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/fulfillmentPlan/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<FulfillmentPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FulfillmentPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FulfillmentPlan>)));
            
        }

        
        /// <summary>
        /// Search fulfillmentPlans by filter Returns the list of fulfillmentPlans that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;FulfillmentPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<FulfillmentPlan>> GetFulfillmentPlanByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<FulfillmentPlan>> localVarResponse = await GetFulfillmentPlanByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search fulfillmentPlans by filter Returns the list of fulfillmentPlans that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FulfillmentPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FulfillmentPlan>>> GetFulfillmentPlanByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/fulfillmentPlan/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<FulfillmentPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FulfillmentPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FulfillmentPlan>)));
            
        }
        
        /// <summary>
        /// Get a fulfillmentPlan by id Returns the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param> 
        /// <returns>FulfillmentPlan</returns>
        public FulfillmentPlan GetFulfillmentPlanById (int? fulfillmentPlanId)
        {
             ApiResponse<FulfillmentPlan> localVarResponse = GetFulfillmentPlanByIdWithHttpInfo(fulfillmentPlanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a fulfillmentPlan by id Returns the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param> 
        /// <returns>ApiResponse of FulfillmentPlan</returns>
        public ApiResponse< FulfillmentPlan > GetFulfillmentPlanByIdWithHttpInfo (int? fulfillmentPlanId)
        {
            
            // verify the required parameter 'fulfillmentPlanId' is set
            if (fulfillmentPlanId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentPlanId' when calling FulfillmentPlanApi->GetFulfillmentPlanById");
            
    
            var localVarPath = "/beta/fulfillmentPlan/{fulfillmentPlanId}";
    
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
            if (fulfillmentPlanId != null) localVarPathParams.Add("fulfillmentPlanId", Configuration.ApiClient.ParameterToString(fulfillmentPlanId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FulfillmentPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentPlan)));
            
        }

        
        /// <summary>
        /// Get a fulfillmentPlan by id Returns the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param>
        /// <returns>Task of FulfillmentPlan</returns>
        public async System.Threading.Tasks.Task<FulfillmentPlan> GetFulfillmentPlanByIdAsync (int? fulfillmentPlanId)
        {
             ApiResponse<FulfillmentPlan> localVarResponse = await GetFulfillmentPlanByIdAsyncWithHttpInfo(fulfillmentPlanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a fulfillmentPlan by id Returns the fulfillmentPlan identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentPlanId">Id of the fulfillmentPlan to be returned.</param>
        /// <returns>Task of ApiResponse (FulfillmentPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FulfillmentPlan>> GetFulfillmentPlanByIdAsyncWithHttpInfo (int? fulfillmentPlanId)
        {
            // verify the required parameter 'fulfillmentPlanId' is set
            if (fulfillmentPlanId == null) throw new ApiException(400, "Missing required parameter 'fulfillmentPlanId' when calling GetFulfillmentPlanById");
            
    
            var localVarPath = "/beta/fulfillmentPlan/{fulfillmentPlanId}";
    
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
            if (fulfillmentPlanId != null) localVarPathParams.Add("fulfillmentPlanId", Configuration.ApiClient.ParameterToString(fulfillmentPlanId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFulfillmentPlanById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FulfillmentPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentPlan)));
            
        }
        
        /// <summary>
        /// Update a fulfillmentPlan Updates an existing fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param> 
        /// <returns></returns>
        public void UpdateFulfillmentPlan (FulfillmentPlan body)
        {
             UpdateFulfillmentPlanWithHttpInfo(body);
        }

        /// <summary>
        /// Update a fulfillmentPlan Updates an existing fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateFulfillmentPlanWithHttpInfo (FulfillmentPlan body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling FulfillmentPlanApi->UpdateFulfillmentPlan");
            
    
            var localVarPath = "/beta/fulfillmentPlan";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlan: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a fulfillmentPlan Updates an existing fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateFulfillmentPlanAsync (FulfillmentPlan body)
        {
             await UpdateFulfillmentPlanAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a fulfillmentPlan Updates an existing fulfillmentPlan using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFulfillmentPlanAsyncWithHttpInfo (FulfillmentPlan body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateFulfillmentPlan");
            
    
            var localVarPath = "/beta/fulfillmentPlan";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlan: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlan: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a fulfillmentPlan custom fields Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param> 
        /// <returns></returns>
        public void UpdateFulfillmentPlanCustomFields (FulfillmentPlan body)
        {
             UpdateFulfillmentPlanCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a fulfillmentPlan custom fields Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateFulfillmentPlanCustomFieldsWithHttpInfo (FulfillmentPlan body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling FulfillmentPlanApi->UpdateFulfillmentPlanCustomFields");
            
    
            var localVarPath = "/beta/fulfillmentPlan/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlanCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlanCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a fulfillmentPlan custom fields Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateFulfillmentPlanCustomFieldsAsync (FulfillmentPlan body)
        {
             await UpdateFulfillmentPlanCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a fulfillmentPlan custom fields Updates an existing fulfillmentPlan custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">FulfillmentPlan to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateFulfillmentPlanCustomFieldsAsyncWithHttpInfo (FulfillmentPlan body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateFulfillmentPlanCustomFields");
            
    
            var localVarPath = "/beta/fulfillmentPlan/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlanCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateFulfillmentPlanCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
