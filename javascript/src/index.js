(function(factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['./ApiClient', './model/PostitCreatePostItTable', './model/PostitCreatePostItTableResponse', './model/PostitDeleteApiKey', './model/PostitDeleteApiKeyResponse', './model/PostitPostIt', './model/PostitPostItResponse', './model/PostitRegenerateApiKey', './model/PostitRegenerateApiKeyResponse', './model/PostitUpdatePostItTable', './model/PostitUpdatePostItTableResponse', './api/PostItServiceApi'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('./ApiClient'), require('./model/PostitCreatePostItTable'), require('./model/PostitCreatePostItTableResponse'), require('./model/PostitDeleteApiKey'), require('./model/PostitDeleteApiKeyResponse'), require('./model/PostitPostIt'), require('./model/PostitPostItResponse'), require('./model/PostitRegenerateApiKey'), require('./model/PostitRegenerateApiKeyResponse'), require('./model/PostitUpdatePostItTable'), require('./model/PostitUpdatePostItTableResponse'), require('./api/PostItServiceApi'));
  }
}(function(ApiClient, PostitCreatePostItTable, PostitCreatePostItTableResponse, PostitDeleteApiKey, PostitDeleteApiKeyResponse, PostitPostIt, PostitPostItResponse, PostitRegenerateApiKey, PostitRegenerateApiKeyResponse, PostitUpdatePostItTable, PostitUpdatePostItTableResponse, PostItServiceApi) {
  'use strict';

  /**
   * Client library of swagger-js-client.<br>
   * The <code>index</code> module provides access to constructors for all the classes which comprise the public API.
   * <p>
   * An AMD (recommended!) or CommonJS application will generally do something equivalent to the following:
   * <pre>
   * var SwaggerJsClient = require('./index'); // See note below*.
   * var xxxSvc = new SwaggerJsClient.XxxApi(); // Allocate the API class we're going to use.
   * var yyyModel = new SwaggerJsClient.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * <em>*NOTE: For a top-level AMD script, use require(['./index'], function(){...}) and put the application logic within the
   * callback function.</em>
   * </p>
   * <p>
   * A non-AMD browser application (discouraged) might do something like this:
   * <pre>
   * var xxxSvc = new SwaggerJsClient.XxxApi(); // Allocate the API class we're going to use.
   * var yyy = new SwaggerJsClient.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * </p>
   * @module index
   * @version 1.0.0
   */
  var exports = {
    /**
     * The ApiClient constructor.
     * @property {module:ApiClient}
     */
    ApiClient: ApiClient,
    /**
     * The PostitCreatePostItTable model constructor.
     * @property {module:model/PostitCreatePostItTable}
     */
    PostitCreatePostItTable: PostitCreatePostItTable,
    /**
     * The PostitCreatePostItTableResponse model constructor.
     * @property {module:model/PostitCreatePostItTableResponse}
     */
    PostitCreatePostItTableResponse: PostitCreatePostItTableResponse,
    /**
     * The PostitDeleteApiKey model constructor.
     * @property {module:model/PostitDeleteApiKey}
     */
    PostitDeleteApiKey: PostitDeleteApiKey,
    /**
     * The PostitDeleteApiKeyResponse model constructor.
     * @property {module:model/PostitDeleteApiKeyResponse}
     */
    PostitDeleteApiKeyResponse: PostitDeleteApiKeyResponse,
    /**
     * The PostitPostIt model constructor.
     * @property {module:model/PostitPostIt}
     */
    PostitPostIt: PostitPostIt,
    /**
     * The PostitPostItResponse model constructor.
     * @property {module:model/PostitPostItResponse}
     */
    PostitPostItResponse: PostitPostItResponse,
    /**
     * The PostitRegenerateApiKey model constructor.
     * @property {module:model/PostitRegenerateApiKey}
     */
    PostitRegenerateApiKey: PostitRegenerateApiKey,
    /**
     * The PostitRegenerateApiKeyResponse model constructor.
     * @property {module:model/PostitRegenerateApiKeyResponse}
     */
    PostitRegenerateApiKeyResponse: PostitRegenerateApiKeyResponse,
    /**
     * The PostitUpdatePostItTable model constructor.
     * @property {module:model/PostitUpdatePostItTable}
     */
    PostitUpdatePostItTable: PostitUpdatePostItTable,
    /**
     * The PostitUpdatePostItTableResponse model constructor.
     * @property {module:model/PostitUpdatePostItTableResponse}
     */
    PostitUpdatePostItTableResponse: PostitUpdatePostItTableResponse,
    /**
     * The PostItServiceApi service constructor.
     * @property {module:api/PostItServiceApi}
     */
    PostItServiceApi: PostItServiceApi
  };

  return exports;
}));
