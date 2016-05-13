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
    root.SwaggerJsClient.PostitPostIt = factory(root.SwaggerJsClient.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The PostitPostIt model module.
   * @module model/PostitPostIt
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>PostitPostIt</code>.
   * @alias module:model/PostitPostIt
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>PostitPostIt</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PostitPostIt} obj Optional instance to populate.
   * @return {module:model/PostitPostIt} The populated <code>PostitPostIt</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('api_key')) {
        obj['api_key'] = ApiClient.convertToType(data['api_key'], 'String');
      }
      if (data.hasOwnProperty('event_time')) {
        obj['event_time'] = ApiClient.convertToType(data['event_time'], 'Integer');
      }
      if (data.hasOwnProperty('payload')) {
        obj['payload'] = ApiClient.convertToType(data['payload'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {String} api_key
   */
  exports.prototype['api_key'] = undefined;

  /**
   * @member {Integer} event_time
   */
  exports.prototype['event_time'] = undefined;

  /**
   * @member {String} payload
   */
  exports.prototype['payload'] = undefined;




  return exports;
}));
