# WWW::SwaggerClient::PostItServiceApi

## Load the API package
```perl
use WWW::SwaggerClient::Object::PostItServiceApi;
```

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create_post_it_table**](PostItServiceApi.md#create_post_it_table) | **POST** /api/1.0/create | PostItService.createPostItTable
[**delete_api_key**](PostItServiceApi.md#delete_api_key) | **POST** /api/1.0/delete | PostItService.deleteApiKey
[**post_it**](PostItServiceApi.md#post_it) | **POST** /api/1.0/post | PostItService.postIt
[**regenerate_api_key**](PostItServiceApi.md#regenerate_api_key) | **POST** /api/1.0/regenerate | PostItService.regenerateApiKey
[**update_post_it_table**](PostItServiceApi.md#update_post_it_table) | **POST** /api/1.0/update | PostItService.updatePostItTable


# **create_post_it_table**
> PostitCreatePostItTableResponse create_post_it_table(body => $body)

PostItService.createPostItTable

### Example 
```perl
use Data::Dumper;

my $api_instance = WWW::SwaggerClient::PostItServiceApi->new();
my $body = WWW::SwaggerClient::Object::PostitCreatePostItTable->new(); # PostitCreatePostItTable | 

eval { 
    my $result = $api_instance->create_post_it_table(body => $body);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling PostItServiceApi->create_post_it_table: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **delete_api_key**
> PostitDeleteApiKeyResponse delete_api_key(body => $body)

PostItService.deleteApiKey

### Example 
```perl
use Data::Dumper;

my $api_instance = WWW::SwaggerClient::PostItServiceApi->new();
my $body = WWW::SwaggerClient::Object::PostitDeleteApiKey->new(); # PostitDeleteApiKey | 

eval { 
    my $result = $api_instance->delete_api_key(body => $body);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling PostItServiceApi->delete_api_key: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post_it**
> PostitPostItResponse post_it(body => $body)

PostItService.postIt

### Example 
```perl
use Data::Dumper;

my $api_instance = WWW::SwaggerClient::PostItServiceApi->new();
my $body = WWW::SwaggerClient::Object::PostitPostIt->new(); # PostitPostIt | 

eval { 
    my $result = $api_instance->post_it(body => $body);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling PostItServiceApi->post_it: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regenerate_api_key**
> PostitRegenerateApiKeyResponse regenerate_api_key(body => $body)

PostItService.regenerateApiKey

### Example 
```perl
use Data::Dumper;

my $api_instance = WWW::SwaggerClient::PostItServiceApi->new();
my $body = WWW::SwaggerClient::Object::PostitRegenerateApiKey->new(); # PostitRegenerateApiKey | 

eval { 
    my $result = $api_instance->regenerate_api_key(body => $body);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling PostItServiceApi->regenerate_api_key: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **update_post_it_table**
> PostitUpdatePostItTableResponse update_post_it_table(body => $body)

PostItService.updatePostItTable

### Example 
```perl
use Data::Dumper;

my $api_instance = WWW::SwaggerClient::PostItServiceApi->new();
my $body = WWW::SwaggerClient::Object::PostitUpdatePostItTable->new(); # PostitUpdatePostItTable | 

eval { 
    my $result = $api_instance->update_post_it_table(body => $body);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling PostItServiceApi->update_post_it_table: $@\n";
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

