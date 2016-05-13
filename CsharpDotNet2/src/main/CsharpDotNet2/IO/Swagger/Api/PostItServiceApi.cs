using System;
using System.IO;
using System.Collections.Generic;
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
        
        /// <summary>
        /// PostItService.createPostItTable 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>PostitCreatePostItTableResponse</returns>
        PostitCreatePostItTableResponse CreatePostItTable (PostitCreatePostItTable body);
        
        /// <summary>
        /// PostItService.deleteApiKey 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>PostitDeleteApiKeyResponse</returns>
        PostitDeleteApiKeyResponse DeleteApiKey (PostitDeleteApiKey body);
        
        /// <summary>
        /// PostItService.postIt 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>PostitPostItResponse</returns>
        PostitPostItResponse PostIt (PostitPostIt body);
        
        /// <summary>
        /// PostItService.regenerateApiKey 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>PostitRegenerateApiKeyResponse</returns>
        PostitRegenerateApiKeyResponse RegenerateApiKey (PostitRegenerateApiKey body);
        
        /// <summary>
        /// PostItService.updatePostItTable 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>PostitUpdatePostItTableResponse</returns>
        PostitUpdatePostItTableResponse UpdatePostItTable (PostitUpdatePostItTable body);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PostItServiceApi : IPostItServiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostItServiceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PostItServiceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostItServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PostItServiceApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// PostItService.createPostItTable 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PostitCreatePostItTableResponse</returns>            
        public PostitCreatePostItTableResponse CreatePostItTable (PostitCreatePostItTable body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePostItTable");
            
    
            var path = "/api/1.0/create";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePostItTable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePostItTable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostitCreatePostItTableResponse) ApiClient.Deserialize(response.Content, typeof(PostitCreatePostItTableResponse), response.Headers);
        }
    
        
        /// <summary>
        /// PostItService.deleteApiKey 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PostitDeleteApiKeyResponse</returns>            
        public PostitDeleteApiKeyResponse DeleteApiKey (PostitDeleteApiKey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteApiKey");
            
    
            var path = "/api/1.0/delete";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostitDeleteApiKeyResponse) ApiClient.Deserialize(response.Content, typeof(PostitDeleteApiKeyResponse), response.Headers);
        }
    
        
        /// <summary>
        /// PostItService.postIt 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PostitPostItResponse</returns>            
        public PostitPostItResponse PostIt (PostitPostIt body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostIt");
            
    
            var path = "/api/1.0/post";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostIt: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostIt: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostitPostItResponse) ApiClient.Deserialize(response.Content, typeof(PostitPostItResponse), response.Headers);
        }
    
        
        /// <summary>
        /// PostItService.regenerateApiKey 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PostitRegenerateApiKeyResponse</returns>            
        public PostitRegenerateApiKeyResponse RegenerateApiKey (PostitRegenerateApiKey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RegenerateApiKey");
            
    
            var path = "/api/1.0/regenerate";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RegenerateApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegenerateApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostitRegenerateApiKeyResponse) ApiClient.Deserialize(response.Content, typeof(PostitRegenerateApiKeyResponse), response.Headers);
        }
    
        
        /// <summary>
        /// PostItService.updatePostItTable 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PostitUpdatePostItTableResponse</returns>            
        public PostitUpdatePostItTableResponse UpdatePostItTable (PostitUpdatePostItTable body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePostItTable");
            
    
            var path = "/api/1.0/update";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePostItTable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePostItTable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PostitUpdatePostItTableResponse) ApiClient.Deserialize(response.Content, typeof(PostitUpdatePostItTableResponse), response.Headers);
        }
    
        
    }
    
}
