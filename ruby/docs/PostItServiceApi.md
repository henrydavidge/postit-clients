# SwaggerClient::PostItServiceApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create_post_it_table**](PostItServiceApi.md#create_post_it_table) | **POST** /api/1.0/create | PostItService.createPostItTable
[**delete_api_key**](PostItServiceApi.md#delete_api_key) | **POST** /api/1.0/delete | PostItService.deleteApiKey
[**post_it**](PostItServiceApi.md#post_it) | **POST** /api/1.0/post | PostItService.postIt
[**regenerate_api_key**](PostItServiceApi.md#regenerate_api_key) | **POST** /api/1.0/regenerate | PostItService.regenerateApiKey
[**update_post_it_table**](PostItServiceApi.md#update_post_it_table) | **POST** /api/1.0/update | PostItService.updatePostItTable


# **create_post_it_table**
> PostitCreatePostItTableResponse create_post_it_table(body)

PostItService.createPostItTable

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::PostItServiceApi.new

body = SwaggerClient::PostitCreatePostItTable.new # PostitCreatePostItTable | 


begin
  #PostItService.createPostItTable
  result = api_instance.create_post_it_table(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling PostItServiceApi->create_post_it_table: #{e}"
end
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



# **delete_api_key**
> PostitDeleteApiKeyResponse delete_api_key(body)

PostItService.deleteApiKey

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::PostItServiceApi.new

body = SwaggerClient::PostitDeleteApiKey.new # PostitDeleteApiKey | 


begin
  #PostItService.deleteApiKey
  result = api_instance.delete_api_key(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling PostItServiceApi->delete_api_key: #{e}"
end
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



# **post_it**
> PostitPostItResponse post_it(body)

PostItService.postIt

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::PostItServiceApi.new

body = SwaggerClient::PostitPostIt.new # PostitPostIt | 


begin
  #PostItService.postIt
  result = api_instance.post_it(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling PostItServiceApi->post_it: #{e}"
end
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



# **regenerate_api_key**
> PostitRegenerateApiKeyResponse regenerate_api_key(body)

PostItService.regenerateApiKey

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::PostItServiceApi.new

body = SwaggerClient::PostitRegenerateApiKey.new # PostitRegenerateApiKey | 


begin
  #PostItService.regenerateApiKey
  result = api_instance.regenerate_api_key(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling PostItServiceApi->regenerate_api_key: #{e}"
end
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



# **update_post_it_table**
> PostitUpdatePostItTableResponse update_post_it_table(body)

PostItService.updatePostItTable

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::PostItServiceApi.new

body = SwaggerClient::PostitUpdatePostItTable.new # PostitUpdatePostItTable | 


begin
  #PostItService.updatePostItTable
  result = api_instance.update_post_it_table(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling PostItServiceApi->update_post_it_table: #{e}"
end
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



