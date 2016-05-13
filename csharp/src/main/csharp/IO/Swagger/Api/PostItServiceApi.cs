using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPostItServiceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// PostItService.createPostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>PostitCreatePostItTableResponse</returns>
        PostitCreatePostItTableResponse CreatePostItTable (PostitCreatePostItTable body);
  
        /// <summary>
        /// PostItService.createPostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PostitCreatePostItTableResponse</returns>
        ApiResponse<PostitCreatePostItTableResponse> CreatePostItTableWithHttpInfo (PostitCreatePostItTable body);
        
        /// <summary>
        /// PostItService.deleteApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>PostitDeleteApiKeyResponse</returns>
        PostitDeleteApiKeyResponse DeleteApiKey (PostitDeleteApiKey body);
  
        /// <summary>
        /// PostItService.deleteApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PostitDeleteApiKeyResponse</returns>
        ApiResponse<PostitDeleteApiKeyResponse> DeleteApiKeyWithHttpInfo (PostitDeleteApiKey body);
        
        /// <summary>
        /// PostItService.postIt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>PostitPostItResponse</returns>
        PostitPostItResponse PostIt (PostitPostIt body);
  
        /// <summary>
        /// PostItService.postIt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PostitPostItResponse</returns>
        ApiResponse<PostitPostItResponse> PostItWithHttpInfo (PostitPostIt body);
        
        /// <summary>
        /// PostItService.regenerateApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>PostitRegenerateApiKeyResponse</returns>
        PostitRegenerateApiKeyResponse RegenerateApiKey (PostitRegenerateApiKey body);
  
        /// <summary>
        /// PostItService.regenerateApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PostitRegenerateApiKeyResponse</returns>
        ApiResponse<PostitRegenerateApiKeyResponse> RegenerateApiKeyWithHttpInfo (PostitRegenerateApiKey body);
        
        /// <summary>
        /// PostItService.updatePostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>PostitUpdatePostItTableResponse</returns>
        PostitUpdatePostItTableResponse UpdatePostItTable (PostitUpdatePostItTable body);
  
        /// <summary>
        /// PostItService.updatePostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PostitUpdatePostItTableResponse</returns>
        ApiResponse<PostitUpdatePostItTableResponse> UpdatePostItTableWithHttpInfo (PostitUpdatePostItTable body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// PostItService.createPostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitCreatePostItTableResponse</returns>
        System.Threading.Tasks.Task<PostitCreatePostItTableResponse> CreatePostItTableAsync (PostitCreatePostItTable body);

        /// <summary>
        /// PostItService.createPostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitCreatePostItTableResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostitCreatePostItTableResponse>> CreatePostItTableAsyncWithHttpInfo (PostitCreatePostItTable body);
        
        /// <summary>
        /// PostItService.deleteApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitDeleteApiKeyResponse</returns>
        System.Threading.Tasks.Task<PostitDeleteApiKeyResponse> DeleteApiKeyAsync (PostitDeleteApiKey body);

        /// <summary>
        /// PostItService.deleteApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitDeleteApiKeyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostitDeleteApiKeyResponse>> DeleteApiKeyAsyncWithHttpInfo (PostitDeleteApiKey body);
        
        /// <summary>
        /// PostItService.postIt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitPostItResponse</returns>
        System.Threading.Tasks.Task<PostitPostItResponse> PostItAsync (PostitPostIt body);

        /// <summary>
        /// PostItService.postIt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitPostItResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostitPostItResponse>> PostItAsyncWithHttpInfo (PostitPostIt body);
        
        /// <summary>
        /// PostItService.regenerateApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitRegenerateApiKeyResponse</returns>
        System.Threading.Tasks.Task<PostitRegenerateApiKeyResponse> RegenerateApiKeyAsync (PostitRegenerateApiKey body);

        /// <summary>
        /// PostItService.regenerateApiKey
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitRegenerateApiKeyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostitRegenerateApiKeyResponse>> RegenerateApiKeyAsyncWithHttpInfo (PostitRegenerateApiKey body);
        
        /// <summary>
        /// PostItService.updatePostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitUpdatePostItTableResponse</returns>
        System.Threading.Tasks.Task<PostitUpdatePostItTableResponse> UpdatePostItTableAsync (PostitUpdatePostItTable body);

        /// <summary>
        /// PostItService.updatePostItTable
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitUpdatePostItTableResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostitUpdatePostItTableResponse>> UpdatePostItTableAsyncWithHttpInfo (PostitUpdatePostItTable body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PostItServiceApi : IPostItServiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostItServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PostItServiceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostItServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PostItServiceApi(Configuration configuration = null)
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
        /// PostItService.createPostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>PostitCreatePostItTableResponse</returns>
        public PostitCreatePostItTableResponse CreatePostItTable (PostitCreatePostItTable body)
        {
             ApiResponse<PostitCreatePostItTableResponse> localVarResponse = CreatePostItTableWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PostItService.createPostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PostitCreatePostItTableResponse</returns>
        public ApiResponse< PostitCreatePostItTableResponse > CreatePostItTableWithHttpInfo (PostitCreatePostItTable body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PostItServiceApi->CreatePostItTable");
            
    
            var localVarPath = "/api/1.0/create";
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreatePostItTable: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreatePostItTable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PostitCreatePostItTableResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitCreatePostItTableResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitCreatePostItTableResponse)));
            
        }

        
        /// <summary>
        /// PostItService.createPostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitCreatePostItTableResponse</returns>
        public async System.Threading.Tasks.Task<PostitCreatePostItTableResponse> CreatePostItTableAsync (PostitCreatePostItTable body)
        {
             ApiResponse<PostitCreatePostItTableResponse> localVarResponse = await CreatePostItTableAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PostItService.createPostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitCreatePostItTableResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostitCreatePostItTableResponse>> CreatePostItTableAsyncWithHttpInfo (PostitCreatePostItTable body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePostItTable");
            
    
            var localVarPath = "/api/1.0/create";
    
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreatePostItTable: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreatePostItTable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostitCreatePostItTableResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitCreatePostItTableResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitCreatePostItTableResponse)));
            
        }
        
        /// <summary>
        /// PostItService.deleteApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>PostitDeleteApiKeyResponse</returns>
        public PostitDeleteApiKeyResponse DeleteApiKey (PostitDeleteApiKey body)
        {
             ApiResponse<PostitDeleteApiKeyResponse> localVarResponse = DeleteApiKeyWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PostItService.deleteApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PostitDeleteApiKeyResponse</returns>
        public ApiResponse< PostitDeleteApiKeyResponse > DeleteApiKeyWithHttpInfo (PostitDeleteApiKey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PostItServiceApi->DeleteApiKey");
            
    
            var localVarPath = "/api/1.0/delete";
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PostitDeleteApiKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitDeleteApiKeyResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitDeleteApiKeyResponse)));
            
        }

        
        /// <summary>
        /// PostItService.deleteApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitDeleteApiKeyResponse</returns>
        public async System.Threading.Tasks.Task<PostitDeleteApiKeyResponse> DeleteApiKeyAsync (PostitDeleteApiKey body)
        {
             ApiResponse<PostitDeleteApiKeyResponse> localVarResponse = await DeleteApiKeyAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PostItService.deleteApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitDeleteApiKeyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostitDeleteApiKeyResponse>> DeleteApiKeyAsyncWithHttpInfo (PostitDeleteApiKey body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteApiKey");
            
    
            var localVarPath = "/api/1.0/delete";
    
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostitDeleteApiKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitDeleteApiKeyResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitDeleteApiKeyResponse)));
            
        }
        
        /// <summary>
        /// PostItService.postIt 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>PostitPostItResponse</returns>
        public PostitPostItResponse PostIt (PostitPostIt body)
        {
             ApiResponse<PostitPostItResponse> localVarResponse = PostItWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PostItService.postIt 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PostitPostItResponse</returns>
        public ApiResponse< PostitPostItResponse > PostItWithHttpInfo (PostitPostIt body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PostItServiceApi->PostIt");
            
    
            var localVarPath = "/api/1.0/post";
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostIt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PostitPostItResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitPostItResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitPostItResponse)));
            
        }

        
        /// <summary>
        /// PostItService.postIt 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitPostItResponse</returns>
        public async System.Threading.Tasks.Task<PostitPostItResponse> PostItAsync (PostitPostIt body)
        {
             ApiResponse<PostitPostItResponse> localVarResponse = await PostItAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PostItService.postIt 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitPostItResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostitPostItResponse>> PostItAsyncWithHttpInfo (PostitPostIt body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostIt");
            
    
            var localVarPath = "/api/1.0/post";
    
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostIt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostitPostItResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitPostItResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitPostItResponse)));
            
        }
        
        /// <summary>
        /// PostItService.regenerateApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>PostitRegenerateApiKeyResponse</returns>
        public PostitRegenerateApiKeyResponse RegenerateApiKey (PostitRegenerateApiKey body)
        {
             ApiResponse<PostitRegenerateApiKeyResponse> localVarResponse = RegenerateApiKeyWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PostItService.regenerateApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PostitRegenerateApiKeyResponse</returns>
        public ApiResponse< PostitRegenerateApiKeyResponse > RegenerateApiKeyWithHttpInfo (PostitRegenerateApiKey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PostItServiceApi->RegenerateApiKey");
            
    
            var localVarPath = "/api/1.0/regenerate";
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RegenerateApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RegenerateApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PostitRegenerateApiKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitRegenerateApiKeyResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitRegenerateApiKeyResponse)));
            
        }

        
        /// <summary>
        /// PostItService.regenerateApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitRegenerateApiKeyResponse</returns>
        public async System.Threading.Tasks.Task<PostitRegenerateApiKeyResponse> RegenerateApiKeyAsync (PostitRegenerateApiKey body)
        {
             ApiResponse<PostitRegenerateApiKeyResponse> localVarResponse = await RegenerateApiKeyAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PostItService.regenerateApiKey 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitRegenerateApiKeyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostitRegenerateApiKeyResponse>> RegenerateApiKeyAsyncWithHttpInfo (PostitRegenerateApiKey body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RegenerateApiKey");
            
    
            var localVarPath = "/api/1.0/regenerate";
    
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RegenerateApiKey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RegenerateApiKey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostitRegenerateApiKeyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitRegenerateApiKeyResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitRegenerateApiKeyResponse)));
            
        }
        
        /// <summary>
        /// PostItService.updatePostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>PostitUpdatePostItTableResponse</returns>
        public PostitUpdatePostItTableResponse UpdatePostItTable (PostitUpdatePostItTable body)
        {
             ApiResponse<PostitUpdatePostItTableResponse> localVarResponse = UpdatePostItTableWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PostItService.updatePostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PostitUpdatePostItTableResponse</returns>
        public ApiResponse< PostitUpdatePostItTableResponse > UpdatePostItTableWithHttpInfo (PostitUpdatePostItTable body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PostItServiceApi->UpdatePostItTable");
            
    
            var localVarPath = "/api/1.0/update";
    
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

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePostItTable: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePostItTable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PostitUpdatePostItTableResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitUpdatePostItTableResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitUpdatePostItTableResponse)));
            
        }

        
        /// <summary>
        /// PostItService.updatePostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of PostitUpdatePostItTableResponse</returns>
        public async System.Threading.Tasks.Task<PostitUpdatePostItTableResponse> UpdatePostItTableAsync (PostitUpdatePostItTable body)
        {
             ApiResponse<PostitUpdatePostItTableResponse> localVarResponse = await UpdatePostItTableAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PostItService.updatePostItTable 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PostitUpdatePostItTableResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostitUpdatePostItTableResponse>> UpdatePostItTableAsyncWithHttpInfo (PostitUpdatePostItTable body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePostItTable");
            
    
            var localVarPath = "/api/1.0/update";
    
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePostItTable: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePostItTable: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostitUpdatePostItTableResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PostitUpdatePostItTableResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostitUpdatePostItTableResponse)));
            
        }
        
    }
    
}
