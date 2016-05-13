(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', '../model/PostitCreatePostItTableResponse', '../model/PostitCreatePostItTable', '../model/PostitDeleteApiKey', '../model/PostitDeleteApiKeyResponse', '../model/PostitPostItResponse', '../model/PostitPostIt', '../model/PostitRegenerateApiKeyResponse', '../model/PostitRegenerateApiKey', '../model/PostitUpdatePostItTable', '../model/PostitUpdatePostItTableResponse'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/PostitCreatePostItTableResponse'), require('../model/PostitCreatePostItTable'), require('../model/PostitDeleteApiKey'), require('../model/PostitDeleteApiKeyResponse'), require('../model/PostitPostItResponse'), require('../model/PostitPostIt'), require('../model/PostitRegenerateApiKeyResponse'), require('../model/PostitRegenerateApiKey'), require('../model/PostitUpdatePostItTable'), require('../model/PostitUpdatePostItTableResponse'));
  } else {
    // Browser globals (root is window)
    if (!root.SwaggerJsClient) {
      root.SwaggerJsClient = {};
    }
    root.SwaggerJsClient.PostItServiceApi = factory(root.SwaggerJsClient.ApiClient, root.SwaggerJsClient.PostitCreatePostItTableResponse, root.SwaggerJsClient.PostitCreatePostItTable, root.SwaggerJsClient.PostitDeleteApiKey, root.SwaggerJsClient.PostitDeleteApiKeyResponse, root.SwaggerJsClient.PostitPostItResponse, root.SwaggerJsClient.PostitPostIt, root.SwaggerJsClient.PostitRegenerateApiKeyResponse, root.SwaggerJsClient.PostitRegenerateApiKey, root.SwaggerJsClient.PostitUpdatePostItTable, root.SwaggerJsClient.PostitUpdatePostItTableResponse);
  }
}(this, function(ApiClient, PostitCreatePostItTableResponse, PostitCreatePostItTable, PostitDeleteApiKey, PostitDeleteApiKeyResponse, PostitPostItResponse, PostitPostIt, PostitRegenerateApiKeyResponse, PostitRegenerateApiKey, PostitUpdatePostItTable, PostitUpdatePostItTableResponse) {
  'use strict';

  /**
   * PostItService service.
   * @module api/PostItServiceApi
   * @version 1.0.0
   */

  /**
   * Constructs a new PostItServiceApi. 
   * @alias module:api/PostItServiceApi
   * @class
   * @param {module:ApiClient} apiClient Optional API client implementation to use, default to {@link module:ApiClient#instance}
   * if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the createPostItTable operation.
     * @callback module:api/PostItServiceApi~createPostItTableCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PostitCreatePostItTableResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * PostItService.createPostItTable
     * @param {module:model/PostitCreatePostItTable} body 
     * @param {module:api/PostItServiceApi~createPostItTableCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/PostitCreatePostItTableResponse}
     */
    this.createPostItTable = function(body, callback) {
      var postBody = body;

      // verify the required parameter 'body' is set
      if (body == undefined || body == null) {
        throw "Missing the required parameter 'body' when calling createPostItTable";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = PostitCreatePostItTableResponse;

      return this.apiClient.callApi(
        '/api/1.0/create', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the deleteApiKey operation.
     * @callback module:api/PostItServiceApi~deleteApiKeyCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PostitDeleteApiKeyResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * PostItService.deleteApiKey
     * @param {module:model/PostitDeleteApiKey} body 
     * @param {module:api/PostItServiceApi~deleteApiKeyCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/PostitDeleteApiKeyResponse}
     */
    this.deleteApiKey = function(body, callback) {
      var postBody = body;

      // verify the required parameter 'body' is set
      if (body == undefined || body == null) {
        throw "Missing the required parameter 'body' when calling deleteApiKey";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = PostitDeleteApiKeyResponse;

      return this.apiClient.callApi(
        '/api/1.0/delete', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the postIt operation.
     * @callback module:api/PostItServiceApi~postItCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PostitPostItResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * PostItService.postIt
     * @param {module:model/PostitPostIt} body 
     * @param {module:api/PostItServiceApi~postItCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/PostitPostItResponse}
     */
    this.postIt = function(body, callback) {
      var postBody = body;

      // verify the required parameter 'body' is set
      if (body == undefined || body == null) {
        throw "Missing the required parameter 'body' when calling postIt";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = PostitPostItResponse;

      return this.apiClient.callApi(
        '/api/1.0/post', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the regenerateApiKey operation.
     * @callback module:api/PostItServiceApi~regenerateApiKeyCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PostitRegenerateApiKeyResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * PostItService.regenerateApiKey
     * @param {module:model/PostitRegenerateApiKey} body 
     * @param {module:api/PostItServiceApi~regenerateApiKeyCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/PostitRegenerateApiKeyResponse}
     */
    this.regenerateApiKey = function(body, callback) {
      var postBody = body;

      // verify the required parameter 'body' is set
      if (body == undefined || body == null) {
        throw "Missing the required parameter 'body' when calling regenerateApiKey";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = PostitRegenerateApiKeyResponse;

      return this.apiClient.callApi(
        '/api/1.0/regenerate', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updatePostItTable operation.
     * @callback module:api/PostItServiceApi~updatePostItTableCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PostitUpdatePostItTableResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * PostItService.updatePostItTable
     * @param {module:model/PostitUpdatePostItTable} body 
     * @param {module:api/PostItServiceApi~updatePostItTableCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/PostitUpdatePostItTableResponse}
     */
    this.updatePostItTable = function(body, callback) {
      var postBody = body;

      // verify the required parameter 'body' is set
      if (body == undefined || body == null) {
        throw "Missing the required parameter 'body' when calling updatePostItTable";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = PostitUpdatePostItTableResponse;

      return this.apiClient.callApi(
        '/api/1.0/update', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
