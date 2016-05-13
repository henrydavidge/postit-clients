(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.SwaggerJsClient) {
      root.SwaggerJsClient = {};
    }
    root.SwaggerJsClient.PostitUpdatePostItTableResponse = factory(root.SwaggerJsClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The PostitUpdatePostItTableResponse model module.
   * @module model/PostitUpdatePostItTableResponse
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>PostitUpdatePostItTableResponse</code>.
   * @alias module:model/PostitUpdatePostItTableResponse
   * @class
   */
  var exports = function() {

  };

  /**
   * Constructs a <code>PostitUpdatePostItTableResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PostitUpdatePostItTableResponse} obj Optional instance to populate.
   * @return {module:model/PostitUpdatePostItTableResponse} The populated <code>PostitUpdatePostItTableResponse</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

    }
    return obj;
  }





  return exports;
}));
