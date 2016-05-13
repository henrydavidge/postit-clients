# SwaggerJsClient.PostItServiceApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createPostItTable**](PostItServiceApi.md#createPostItTable) | **POST** /api/1.0/create | PostItService.createPostItTable
[**deleteApiKey**](PostItServiceApi.md#deleteApiKey) | **POST** /api/1.0/delete | PostItService.deleteApiKey
[**postIt**](PostItServiceApi.md#postIt) | **POST** /api/1.0/post | PostItService.postIt
[**regenerateApiKey**](PostItServiceApi.md#regenerateApiKey) | **POST** /api/1.0/regenerate | PostItService.regenerateApiKey
[**updatePostItTable**](PostItServiceApi.md#updatePostItTable) | **POST** /api/1.0/update | PostItService.updatePostItTable


<a name="createPostItTable"></a>
# **createPostItTable**
> PostitCreatePostItTableResponse createPostItTable(body)

PostItService.createPostItTable

### Example
```javascript
var SwaggerJsClient = require('swagger-js-client');

var apiInstance = new SwaggerJsClient.PostItServiceApi()

var body = new SwaggerJsClient.PostitCreatePostItTable(); // {PostitCreatePostItTable} 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.createPostItTable(body, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostitCreatePostItTable**](PostitCreatePostItTable.md)|  | 

### Return type

[**PostitCreatePostItTableResponse**](PostitCreatePostItTableResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteApiKey"></a>
# **deleteApiKey**
> PostitDeleteApiKeyResponse deleteApiKey(body)

PostItService.deleteApiKey

### Example
```javascript
var SwaggerJsClient = require('swagger-js-client');

var apiInstance = new SwaggerJsClient.PostItServiceApi()

var body = new SwaggerJsClient.PostitDeleteApiKey(); // {PostitDeleteApiKey} 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.deleteApiKey(body, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostitDeleteApiKey**](PostitDeleteApiKey.md)|  | 

### Return type

[**PostitDeleteApiKeyResponse**](PostitDeleteApiKeyResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="postIt"></a>
# **postIt**
> PostitPostItResponse postIt(body)

PostItService.postIt

### Example
```javascript
var SwaggerJsClient = require('swagger-js-client');

var apiInstance = new SwaggerJsClient.PostItServiceApi()

var body = new SwaggerJsClient.PostitPostIt(); // {PostitPostIt} 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.postIt(body, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostitPostIt**](PostitPostIt.md)|  | 

### Return type

[**PostitPostItResponse**](PostitPostItResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="regenerateApiKey"></a>
# **regenerateApiKey**
> PostitRegenerateApiKeyResponse regenerateApiKey(body)

PostItService.regenerateApiKey

### Example
```javascript
var SwaggerJsClient = require('swagger-js-client');

var apiInstance = new SwaggerJsClient.PostItServiceApi()

var body = new SwaggerJsClient.PostitRegenerateApiKey(); // {PostitRegenerateApiKey} 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.regenerateApiKey(body, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostitRegenerateApiKey**](PostitRegenerateApiKey.md)|  | 

### Return type

[**PostitRegenerateApiKeyResponse**](PostitRegenerateApiKeyResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updatePostItTable"></a>
# **updatePostItTable**
> PostitUpdatePostItTableResponse updatePostItTable(body)

PostItService.updatePostItTable

### Example
```javascript
var SwaggerJsClient = require('swagger-js-client');

var apiInstance = new SwaggerJsClient.PostItServiceApi()

var body = new SwaggerJsClient.PostitUpdatePostItTable(); // {PostitUpdatePostItTable} 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.updatePostItTable(body, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostitUpdatePostItTable**](PostitUpdatePostItTable.md)|  | 

### Return type

[**PostitUpdatePostItTableResponse**](PostitUpdatePostItTableResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

