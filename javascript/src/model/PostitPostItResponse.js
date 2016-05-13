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
    root.SwaggerJsClient.PostitPostItResponse = factory(root.SwaggerJsClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The PostitPostItResponse model module.
   * @module model/PostitPostItResponse
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>PostitPostItResponse</code>.
   * @alias module:model/PostitPostItResponse
   * @class
   */
  var exports = function() {

  };

  /**
   * Constructs a <code>PostitPostItResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PostitPostItResponse} obj Optional instance to populate.
   * @return {module:model/PostitPostItResponse} The populated <code>PostitPostItResponse</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

    }
    return obj;
  }





  return exports;
}));
