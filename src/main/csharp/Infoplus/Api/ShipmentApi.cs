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
    public interface IShipmentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a shipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param>
        /// <param name="shipmentAudit">The audit to add</param>
        /// <returns></returns>
        void AddShipmentAudit (int? shipmentId, string shipmentAudit);
  
        /// <summary>
        /// Add new audit for a shipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param>
        /// <param name="shipmentAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddShipmentAuditWithHttpInfo (int? shipmentId, string shipmentAudit);
        
        /// <summary>
        /// Add new tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param>
        /// <param name="shipmentTag">The tag to add</param>
        /// <returns></returns>
        void AddShipmentTag (int? shipmentId, string shipmentTag);
  
        /// <summary>
        /// Add new tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param>
        /// <param name="shipmentTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddShipmentTagWithHttpInfo (int? shipmentId, string shipmentTag);
        
        /// <summary>
        /// Delete a tag for a shipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing shipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param>
        /// <param name="shipmentTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteShipmentTag (int? shipmentId, string shipmentTag);
  
        /// <summary>
        /// Delete a tag for a shipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing shipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param>
        /// <param name="shipmentTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteShipmentTagWithHttpInfo (int? shipmentId, string shipmentTag);
        
        /// <summary>
        /// Get a duplicated a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param>
        /// <returns>Shipment</returns>
        Shipment GetDuplicateShipmentById (int? shipmentId);
  
        /// <summary>
        /// Get a duplicated a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param>
        /// <returns>ApiResponse of Shipment</returns>
        ApiResponse<Shipment> GetDuplicateShipmentByIdWithHttpInfo (int? shipmentId);
        
        /// <summary>
        /// Search shipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;Shipment&gt;</returns>
        List<Shipment> GetShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search shipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;Shipment&gt;</returns>
        ApiResponse<List<Shipment>> GetShipmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns the shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param>
        /// <returns>Shipment</returns>
        Shipment GetShipmentById (int? shipmentId);
  
        /// <summary>
        /// Get a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns the shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param>
        /// <returns>ApiResponse of Shipment</returns>
        ApiResponse<Shipment> GetShipmentByIdWithHttpInfo (int? shipmentId);
        
        /// <summary>
        /// Get the tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Get all existing shipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param>
        /// <returns></returns>
        void GetShipmentTags (int? shipmentId);
  
        /// <summary>
        /// Get the tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Get all existing shipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetShipmentTagsWithHttpInfo (int? shipmentId);
        
        /// <summary>
        /// Update a shipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param>
        /// <returns></returns>
        void UpdateShipmentCustomFields (Shipment body);
  
        /// <summary>
        /// Update a shipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateShipmentCustomFieldsWithHttpInfo (Shipment body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a shipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param>
        /// <param name="shipmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddShipmentAuditAsync (int? shipmentId, string shipmentAudit);

        /// <summary>
        /// Add new audit for a shipment
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param>
        /// <param name="shipmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddShipmentAuditAsyncWithHttpInfo (int? shipmentId, string shipmentAudit);
        
        /// <summary>
        /// Add new tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param>
        /// <param name="shipmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddShipmentTagAsync (int? shipmentId, string shipmentTag);

        /// <summary>
        /// Add new tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing shipment.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param>
        /// <param name="shipmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddShipmentTagAsyncWithHttpInfo (int? shipmentId, string shipmentTag);
        
        /// <summary>
        /// Delete a tag for a shipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing shipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param>
        /// <param name="shipmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteShipmentTagAsync (int? shipmentId, string shipmentTag);

        /// <summary>
        /// Delete a tag for a shipment.
        /// </summary>
        /// <remarks>
        /// Deletes an existing shipment tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param>
        /// <param name="shipmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteShipmentTagAsyncWithHttpInfo (int? shipmentId, string shipmentTag);
        
        /// <summary>
        /// Get a duplicated a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param>
        /// <returns>Task of Shipment</returns>
        System.Threading.Tasks.Task<Shipment> GetDuplicateShipmentByIdAsync (int? shipmentId);

        /// <summary>
        /// Get a duplicated a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Shipment>> GetDuplicateShipmentByIdAsyncWithHttpInfo (int? shipmentId);
        
        /// <summary>
        /// Search shipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;Shipment&gt;</returns>
        System.Threading.Tasks.Task<List<Shipment>> GetShipmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search shipments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of shipments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Shipment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Shipment>>> GetShipmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns the shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param>
        /// <returns>Task of Shipment</returns>
        System.Threading.Tasks.Task<Shipment> GetShipmentByIdAsync (int? shipmentId);

        /// <summary>
        /// Get a shipment by id
        /// </summary>
        /// <remarks>
        /// Returns the shipment identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Shipment>> GetShipmentByIdAsyncWithHttpInfo (int? shipmentId);
        
        /// <summary>
        /// Get the tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Get all existing shipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetShipmentTagsAsync (int? shipmentId);

        /// <summary>
        /// Get the tags for a shipment.
        /// </summary>
        /// <remarks>
        /// Get all existing shipment tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetShipmentTagsAsyncWithHttpInfo (int? shipmentId);
        
        /// <summary>
        /// Update a shipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateShipmentCustomFieldsAsync (Shipment body);

        /// <summary>
        /// Update a shipment custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing shipment custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateShipmentCustomFieldsAsyncWithHttpInfo (Shipment body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShipmentApi : IShipmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShipmentApi(Configuration configuration = null)
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
        /// Add new audit for a shipment Adds an audit to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param> 
        /// <param name="shipmentAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddShipmentAudit (int? shipmentId, string shipmentAudit)
        {
             AddShipmentAuditWithHttpInfo(shipmentId, shipmentAudit);
        }

        /// <summary>
        /// Add new audit for a shipment Adds an audit to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param> 
        /// <param name="shipmentAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddShipmentAuditWithHttpInfo (int? shipmentId, string shipmentAudit)
        {
            
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling ShipmentApi->AddShipmentAudit");
            
            // verify the required parameter 'shipmentAudit' is set
            if (shipmentAudit == null)
                throw new ApiException(400, "Missing required parameter 'shipmentAudit' when calling ShipmentApi->AddShipmentAudit");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/audit/{shipmentAudit}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            if (shipmentAudit != null) localVarPathParams.Add("shipmentAudit", Configuration.ApiClient.ParameterToString(shipmentAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a shipment Adds an audit to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param>
        /// <param name="shipmentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddShipmentAuditAsync (int? shipmentId, string shipmentAudit)
        {
             await AddShipmentAuditAsyncWithHttpInfo(shipmentId, shipmentAudit);

        }

        /// <summary>
        /// Add new audit for a shipment Adds an audit to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add an audit to</param>
        /// <param name="shipmentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddShipmentAuditAsyncWithHttpInfo (int? shipmentId, string shipmentAudit)
        {
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null) throw new ApiException(400, "Missing required parameter 'shipmentId' when calling AddShipmentAudit");
            // verify the required parameter 'shipmentAudit' is set
            if (shipmentAudit == null) throw new ApiException(400, "Missing required parameter 'shipmentAudit' when calling AddShipmentAudit");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/audit/{shipmentAudit}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            if (shipmentAudit != null) localVarPathParams.Add("shipmentAudit", Configuration.ApiClient.ParameterToString(shipmentAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a shipment. Adds a tag to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param> 
        /// <param name="shipmentTag">The tag to add</param> 
        /// <returns></returns>
        public void AddShipmentTag (int? shipmentId, string shipmentTag)
        {
             AddShipmentTagWithHttpInfo(shipmentId, shipmentTag);
        }

        /// <summary>
        /// Add new tags for a shipment. Adds a tag to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param> 
        /// <param name="shipmentTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddShipmentTagWithHttpInfo (int? shipmentId, string shipmentTag)
        {
            
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling ShipmentApi->AddShipmentTag");
            
            // verify the required parameter 'shipmentTag' is set
            if (shipmentTag == null)
                throw new ApiException(400, "Missing required parameter 'shipmentTag' when calling ShipmentApi->AddShipmentTag");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/tag/{shipmentTag}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            if (shipmentTag != null) localVarPathParams.Add("shipmentTag", Configuration.ApiClient.ParameterToString(shipmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a shipment. Adds a tag to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param>
        /// <param name="shipmentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddShipmentTagAsync (int? shipmentId, string shipmentTag)
        {
             await AddShipmentTagAsyncWithHttpInfo(shipmentId, shipmentTag);

        }

        /// <summary>
        /// Add new tags for a shipment. Adds a tag to an existing shipment.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to add a tag to</param>
        /// <param name="shipmentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddShipmentTagAsyncWithHttpInfo (int? shipmentId, string shipmentTag)
        {
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null) throw new ApiException(400, "Missing required parameter 'shipmentId' when calling AddShipmentTag");
            // verify the required parameter 'shipmentTag' is set
            if (shipmentTag == null) throw new ApiException(400, "Missing required parameter 'shipmentTag' when calling AddShipmentTag");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/tag/{shipmentTag}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            if (shipmentTag != null) localVarPathParams.Add("shipmentTag", Configuration.ApiClient.ParameterToString(shipmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a shipment. Deletes an existing shipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param> 
        /// <param name="shipmentTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteShipmentTag (int? shipmentId, string shipmentTag)
        {
             DeleteShipmentTagWithHttpInfo(shipmentId, shipmentTag);
        }

        /// <summary>
        /// Delete a tag for a shipment. Deletes an existing shipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param> 
        /// <param name="shipmentTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteShipmentTagWithHttpInfo (int? shipmentId, string shipmentTag)
        {
            
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling ShipmentApi->DeleteShipmentTag");
            
            // verify the required parameter 'shipmentTag' is set
            if (shipmentTag == null)
                throw new ApiException(400, "Missing required parameter 'shipmentTag' when calling ShipmentApi->DeleteShipmentTag");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/tag/{shipmentTag}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            if (shipmentTag != null) localVarPathParams.Add("shipmentTag", Configuration.ApiClient.ParameterToString(shipmentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a shipment. Deletes an existing shipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param>
        /// <param name="shipmentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteShipmentTagAsync (int? shipmentId, string shipmentTag)
        {
             await DeleteShipmentTagAsyncWithHttpInfo(shipmentId, shipmentTag);

        }

        /// <summary>
        /// Delete a tag for a shipment. Deletes an existing shipment tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to remove tag from</param>
        /// <param name="shipmentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteShipmentTagAsyncWithHttpInfo (int? shipmentId, string shipmentTag)
        {
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null) throw new ApiException(400, "Missing required parameter 'shipmentId' when calling DeleteShipmentTag");
            // verify the required parameter 'shipmentTag' is set
            if (shipmentTag == null) throw new ApiException(400, "Missing required parameter 'shipmentTag' when calling DeleteShipmentTag");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/tag/{shipmentTag}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            if (shipmentTag != null) localVarPathParams.Add("shipmentTag", Configuration.ApiClient.ParameterToString(shipmentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteShipmentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteShipmentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a shipment by id Returns a duplicated shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param> 
        /// <returns>Shipment</returns>
        public Shipment GetDuplicateShipmentById (int? shipmentId)
        {
             ApiResponse<Shipment> localVarResponse = GetDuplicateShipmentByIdWithHttpInfo(shipmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a shipment by id Returns a duplicated shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param> 
        /// <returns>ApiResponse of Shipment</returns>
        public ApiResponse< Shipment > GetDuplicateShipmentByIdWithHttpInfo (int? shipmentId)
        {
            
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling ShipmentApi->GetDuplicateShipmentById");
            
    
            var localVarPath = "/beta/shipment/duplicate/{shipmentId}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Shipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Shipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Shipment)));
            
        }

        
        /// <summary>
        /// Get a duplicated a shipment by id Returns a duplicated shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param>
        /// <returns>Task of Shipment</returns>
        public async System.Threading.Tasks.Task<Shipment> GetDuplicateShipmentByIdAsync (int? shipmentId)
        {
             ApiResponse<Shipment> localVarResponse = await GetDuplicateShipmentByIdAsyncWithHttpInfo(shipmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a shipment by id Returns a duplicated shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be duplicated.</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Shipment>> GetDuplicateShipmentByIdAsyncWithHttpInfo (int? shipmentId)
        {
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null) throw new ApiException(400, "Missing required parameter 'shipmentId' when calling GetDuplicateShipmentById");
            
    
            var localVarPath = "/beta/shipment/duplicate/{shipmentId}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Shipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Shipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Shipment)));
            
        }
        
        /// <summary>
        /// Search shipments by filter Returns the list of shipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;Shipment&gt;</returns>
        public List<Shipment> GetShipmentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<Shipment>> localVarResponse = GetShipmentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search shipments by filter Returns the list of shipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;Shipment&gt;</returns>
        public ApiResponse< List<Shipment> > GetShipmentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/shipment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Shipment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Shipment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Shipment>)));
            
        }

        
        /// <summary>
        /// Search shipments by filter Returns the list of shipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;Shipment&gt;</returns>
        public async System.Threading.Tasks.Task<List<Shipment>> GetShipmentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<Shipment>> localVarResponse = await GetShipmentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search shipments by filter Returns the list of shipments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Shipment&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Shipment>>> GetShipmentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/shipment/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Shipment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Shipment>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Shipment>)));
            
        }
        
        /// <summary>
        /// Get a shipment by id Returns the shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param> 
        /// <returns>Shipment</returns>
        public Shipment GetShipmentById (int? shipmentId)
        {
             ApiResponse<Shipment> localVarResponse = GetShipmentByIdWithHttpInfo(shipmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a shipment by id Returns the shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param> 
        /// <returns>ApiResponse of Shipment</returns>
        public ApiResponse< Shipment > GetShipmentByIdWithHttpInfo (int? shipmentId)
        {
            
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling ShipmentApi->GetShipmentById");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Shipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Shipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Shipment)));
            
        }

        
        /// <summary>
        /// Get a shipment by id Returns the shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param>
        /// <returns>Task of Shipment</returns>
        public async System.Threading.Tasks.Task<Shipment> GetShipmentByIdAsync (int? shipmentId)
        {
             ApiResponse<Shipment> localVarResponse = await GetShipmentByIdAsyncWithHttpInfo(shipmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a shipment by id Returns the shipment identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to be returned.</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Shipment>> GetShipmentByIdAsyncWithHttpInfo (int? shipmentId)
        {
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null) throw new ApiException(400, "Missing required parameter 'shipmentId' when calling GetShipmentById");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Shipment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Shipment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Shipment)));
            
        }
        
        /// <summary>
        /// Get the tags for a shipment. Get all existing shipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param> 
        /// <returns></returns>
        public void GetShipmentTags (int? shipmentId)
        {
             GetShipmentTagsWithHttpInfo(shipmentId);
        }

        /// <summary>
        /// Get the tags for a shipment. Get all existing shipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetShipmentTagsWithHttpInfo (int? shipmentId)
        {
            
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null)
                throw new ApiException(400, "Missing required parameter 'shipmentId' when calling ShipmentApi->GetShipmentTags");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/tag";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a shipment. Get all existing shipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetShipmentTagsAsync (int? shipmentId)
        {
             await GetShipmentTagsAsyncWithHttpInfo(shipmentId);

        }

        /// <summary>
        /// Get the tags for a shipment. Get all existing shipment tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Id of the shipment to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetShipmentTagsAsyncWithHttpInfo (int? shipmentId)
        {
            // verify the required parameter 'shipmentId' is set
            if (shipmentId == null) throw new ApiException(400, "Missing required parameter 'shipmentId' when calling GetShipmentTags");
            
    
            var localVarPath = "/beta/shipment/{shipmentId}/tag";
    
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
            if (shipmentId != null) localVarPathParams.Add("shipmentId", Configuration.ApiClient.ParameterToString(shipmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetShipmentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a shipment custom fields Updates an existing shipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param> 
        /// <returns></returns>
        public void UpdateShipmentCustomFields (Shipment body)
        {
             UpdateShipmentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a shipment custom fields Updates an existing shipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateShipmentCustomFieldsWithHttpInfo (Shipment body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ShipmentApi->UpdateShipmentCustomFields");
            
    
            var localVarPath = "/beta/shipment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateShipmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateShipmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a shipment custom fields Updates an existing shipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateShipmentCustomFieldsAsync (Shipment body)
        {
             await UpdateShipmentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a shipment custom fields Updates an existing shipment custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Shipment to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateShipmentCustomFieldsAsyncWithHttpInfo (Shipment body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateShipmentCustomFields");
            
    
            var localVarPath = "/beta/shipment/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateShipmentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateShipmentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
