package io.swagger.client.api;

import com.sun.jersey.api.client.GenericType;

import io.swagger.client.ApiException;
import io.swagger.client.ApiClient;
import io.swagger.client.Configuration;
import io.swagger.client.Pair;

import io.swagger.client.model.PostitCreatePostItTableResponse;
import io.swagger.client.model.PostitCreatePostItTable;
import io.swagger.client.model.PostitDeleteApiKey;
import io.swagger.client.model.PostitDeleteApiKeyResponse;
import io.swagger.client.model.PostitPostItResponse;
import io.swagger.client.model.PostitPostIt;
import io.swagger.client.model.PostitRegenerateApiKeyResponse;
import io.swagger.client.model.PostitRegenerateApiKey;
import io.swagger.client.model.PostitUpdatePostItTable;
import io.swagger.client.model.PostitUpdatePostItTableResponse;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-05-13T14:30:58.052-07:00")
public class PostItServiceApi {
  private ApiClient apiClient;

  public PostItServiceApi() {
    this(Configuration.getDefaultApiClient());
  }

  public PostItServiceApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * PostItService.createPostItTable
   * 
   * @param body  (required)
   * @return PostitCreatePostItTableResponse
   * @throws ApiException if fails to make API call
   */
  public PostitCreatePostItTableResponse createPostItTable(PostitCreatePostItTable body) throws ApiException {
    Object localVarPostBody = body;
    
    // verify the required parameter 'body' is set
    if (body == null) {
      throw new ApiException(400, "Missing the required parameter 'body' when calling createPostItTable");
    }
    
    // create path and map variables
    String localVarPath = "/api/1.0/create".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    

    

    

    final String[] localVarAccepts = {
      "application/json"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    
    GenericType<PostitCreatePostItTableResponse> localVarReturnType = new GenericType<PostitCreatePostItTableResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
    
  }
  
  /**
   * PostItService.deleteApiKey
   * 
   * @param body  (required)
   * @return PostitDeleteApiKeyResponse
   * @throws ApiException if fails to make API call
   */
  public PostitDeleteApiKeyResponse deleteApiKey(PostitDeleteApiKey body) throws ApiException {
    Object localVarPostBody = body;
    
    // verify the required parameter 'body' is set
    if (body == null) {
      throw new ApiException(400, "Missing the required parameter 'body' when calling deleteApiKey");
    }
    
    // create path and map variables
    String localVarPath = "/api/1.0/delete".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    

    

    

    final String[] localVarAccepts = {
      "application/json"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    
    GenericType<PostitDeleteApiKeyResponse> localVarReturnType = new GenericType<PostitDeleteApiKeyResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
    
  }
  
  /**
   * PostItService.postIt
   * 
   * @param body  (required)
   * @return PostitPostItResponse
   * @throws ApiException if fails to make API call
   */
  public PostitPostItResponse postIt(PostitPostIt body) throws ApiException {
    Object localVarPostBody = body;
    
    // verify the required parameter 'body' is set
    if (body == null) {
      throw new ApiException(400, "Missing the required parameter 'body' when calling postIt");
    }
    
    // create path and map variables
    String localVarPath = "/api/1.0/post".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    

    

    

    final String[] localVarAccepts = {
      "application/json"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    
    GenericType<PostitPostItResponse> localVarReturnType = new GenericType<PostitPostItResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
    
  }
  
  /**
   * PostItService.regenerateApiKey
   * 
   * @param body  (required)
   * @return PostitRegenerateApiKeyResponse
   * @throws ApiException if fails to make API call
   */
  public PostitRegenerateApiKeyResponse regenerateApiKey(PostitRegenerateApiKey body) throws ApiException {
    Object localVarPostBody = body;
    
    // verify the required parameter 'body' is set
    if (body == null) {
      throw new ApiException(400, "Missing the required parameter 'body' when calling regenerateApiKey");
    }
    
    // create path and map variables
    String localVarPath = "/api/1.0/regenerate".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    

    

    

    final String[] localVarAccepts = {
      "application/json"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    
    GenericType<PostitRegenerateApiKeyResponse> localVarReturnType = new GenericType<PostitRegenerateApiKeyResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
    
  }
  
  /**
   * PostItService.updatePostItTable
   * 
   * @param body  (required)
   * @return PostitUpdatePostItTableResponse
   * @throws ApiException if fails to make API call
   */
  public PostitUpdatePostItTableResponse updatePostItTable(PostitUpdatePostItTable body) throws ApiException {
    Object localVarPostBody = body;
    
    // verify the required parameter 'body' is set
    if (body == null) {
      throw new ApiException(400, "Missing the required parameter 'body' when calling updatePostItTable");
    }
    
    // create path and map variables
    String localVarPath = "/api/1.0/update".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    

    

    

    final String[] localVarAccepts = {
      "application/json"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    
    GenericType<PostitUpdatePostItTableResponse> localVarReturnType = new GenericType<PostitUpdatePostItTableResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
    
  }
  
}
