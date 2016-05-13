package io.swagger.client.api {

import io.swagger.common.ApiInvoker;
import io.swagger.exception.ApiErrorCodes;
import io.swagger.exception.ApiError;
import io.swagger.common.ApiUserCredentials;
import io.swagger.event.Response;
import io.swagger.common.SwaggerApi;
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

import mx.rpc.AsyncToken;
import mx.utils.UIDUtil;
import flash.utils.Dictionary;
import flash.events.EventDispatcher;

public class PostItServiceApi extends SwaggerApi {
    /**
    * Constructor for the PostItServiceApi api client
    * @param apiCredentials Wrapper object for tokens and hostName required towards authentication
    * @param eventDispatcher Optional event dispatcher that when provided is used by the SDK to dispatch any Response
    */
    public function PostItServiceApi(apiCredentials: ApiUserCredentials, eventDispatcher: EventDispatcher = null) {
        super(apiCredentials, eventDispatcher);
    }

        public static const event_create_post_it_table: String = "create_post_it_table";
        public static const event_delete_api_key: String = "delete_api_key";
        public static const event_post_it: String = "post_it";
        public static const event_regenerate_api_key: String = "regenerate_api_key";
        public static const event_update_post_it_table: String = "update_post_it_table";


    /*
     * Returns PostitCreatePostItTableResponse 
     */
    public function create_post_it_table (body: PostitCreatePostItTable): String {
        // create path and map variables
        var path: String = "/api/1.0/create".replace(/{format}/g,"xml");

        // query params
        var queryParams: Dictionary = new Dictionary();
        var headerParams: Dictionary = new Dictionary();

        

        

        

        var token:AsyncToken = getApiInvoker().invokeAPI(path, "POST", queryParams, body, headerParams);

        var requestId: String = getUniqueId();

        token.requestId = requestId;
        token.completionEventType = "create_post_it_table";

        token.returnType = PostitCreatePostItTableResponse;
        return requestId;

    }
    
    /*
     * Returns PostitDeleteApiKeyResponse 
     */
    public function delete_api_key (body: PostitDeleteApiKey): String {
        // create path and map variables
        var path: String = "/api/1.0/delete".replace(/{format}/g,"xml");

        // query params
        var queryParams: Dictionary = new Dictionary();
        var headerParams: Dictionary = new Dictionary();

        

        

        

        var token:AsyncToken = getApiInvoker().invokeAPI(path, "POST", queryParams, body, headerParams);

        var requestId: String = getUniqueId();

        token.requestId = requestId;
        token.completionEventType = "delete_api_key";

        token.returnType = PostitDeleteApiKeyResponse;
        return requestId;

    }
    
    /*
     * Returns PostitPostItResponse 
     */
    public function post_it (body: PostitPostIt): String {
        // create path and map variables
        var path: String = "/api/1.0/post".replace(/{format}/g,"xml");

        // query params
        var queryParams: Dictionary = new Dictionary();
        var headerParams: Dictionary = new Dictionary();

        

        

        

        var token:AsyncToken = getApiInvoker().invokeAPI(path, "POST", queryParams, body, headerParams);

        var requestId: String = getUniqueId();

        token.requestId = requestId;
        token.completionEventType = "post_it";

        token.returnType = PostitPostItResponse;
        return requestId;

    }
    
    /*
     * Returns PostitRegenerateApiKeyResponse 
     */
    public function regenerate_api_key (body: PostitRegenerateApiKey): String {
        // create path and map variables
        var path: String = "/api/1.0/regenerate".replace(/{format}/g,"xml");

        // query params
        var queryParams: Dictionary = new Dictionary();
        var headerParams: Dictionary = new Dictionary();

        

        

        

        var token:AsyncToken = getApiInvoker().invokeAPI(path, "POST", queryParams, body, headerParams);

        var requestId: String = getUniqueId();

        token.requestId = requestId;
        token.completionEventType = "regenerate_api_key";

        token.returnType = PostitRegenerateApiKeyResponse;
        return requestId;

    }
    
    /*
     * Returns PostitUpdatePostItTableResponse 
     */
    public function update_post_it_table (body: PostitUpdatePostItTable): String {
        // create path and map variables
        var path: String = "/api/1.0/update".replace(/{format}/g,"xml");

        // query params
        var queryParams: Dictionary = new Dictionary();
        var headerParams: Dictionary = new Dictionary();

        

        

        

        var token:AsyncToken = getApiInvoker().invokeAPI(path, "POST", queryParams, body, headerParams);

        var requestId: String = getUniqueId();

        token.requestId = requestId;
        token.completionEventType = "update_post_it_table";

        token.returnType = PostitUpdatePostItTableResponse;
        return requestId;

    }
    
}
        
}
