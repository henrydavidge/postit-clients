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
    root.SwaggerJsClient.PostitUpdatePostItTable = factory(root.SwaggerJsClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The PostitUpdatePostItTable model module.
   * @module model/PostitUpdatePostItTable
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>PostitUpdatePostItTable</code>.
   * @alias module:model/PostitUpdatePostItTable
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>PostitUpdatePostItTable</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PostitUpdatePostItTable} obj Optional instance to populate.
   * @return {module:model/PostitUpdatePostItTable} The populated <code>PostitUpdatePostItTable</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('api_key')) {
        obj['api_key'] = ApiClient.convertToType(data['api_key'], 'String');
      }
      if (data.hasOwnProperty('path')) {
        obj['path'] = ApiClient.convertToType(data['path'], 'String');
      }
      if (data.hasOwnProperty('schema')) {
        obj['schema'] = ApiClient.convertToType(data['schema'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {String} api_key
   */
  exports.prototype['api_key'] = undefined;

  /**
   * @member {String} path
   */
  exports.prototype['path'] = undefined;

  /**
   * @member {String} schema
   */
  exports.prototype['schema'] = undefined;




  return exports;
}));
