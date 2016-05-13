# Swagger\Client\PostItServiceApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createPostItTable**](PostItServiceApi.md#createPostItTable) | **POST** /api/1.0/create | PostItService.createPostItTable
[**deleteApiKey**](PostItServiceApi.md#deleteApiKey) | **POST** /api/1.0/delete | PostItService.deleteApiKey
[**postIt**](PostItServiceApi.md#postIt) | **POST** /api/1.0/post | PostItService.postIt
[**regenerateApiKey**](PostItServiceApi.md#regenerateApiKey) | **POST** /api/1.0/regenerate | PostItService.regenerateApiKey
[**updatePostItTable**](PostItServiceApi.md#updatePostItTable) | **POST** /api/1.0/update | PostItService.updatePostItTable


# **createPostItTable**
> \Swagger\Client\Model\PostitCreatePostItTableResponse createPostItTable($body)

PostItService.createPostItTable

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Swagger\Client\Api\PostItServiceApi();
$body = new \Swagger\Client\Model\PostitCreatePostItTable(); // \Swagger\Client\Model\PostitCreatePostItTable | 

try { 
    $result = $api_instance->createPostItTable($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PostItServiceApi->createPostItTable: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\PostitCreatePostItTable**](\Swagger\Client\Model\PostitCreatePostItTable.md)|  | 

### Return type

[**\Swagger\Client\Model\PostitCreatePostItTableResponse**](PostitCreatePostItTableResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deleteApiKey**
> \Swagger\Client\Model\PostitDeleteApiKeyResponse deleteApiKey($body)

PostItService.deleteApiKey

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Swagger\Client\Api\PostItServiceApi();
$body = new \Swagger\Client\Model\PostitDeleteApiKey(); // \Swagger\Client\Model\PostitDeleteApiKey | 

try { 
    $result = $api_instance->deleteApiKey($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PostItServiceApi->deleteApiKey: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\PostitDeleteApiKey**](\Swagger\Client\Model\PostitDeleteApiKey.md)|  | 

### Return type

[**\Swagger\Client\Model\PostitDeleteApiKeyResponse**](PostitDeleteApiKeyResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postIt**
> \Swagger\Client\Model\PostitPostItResponse postIt($body)

PostItService.postIt

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Swagger\Client\Api\PostItServiceApi();
$body = new \Swagger\Client\Model\PostitPostIt(); // \Swagger\Client\Model\PostitPostIt | 

try { 
    $result = $api_instance->postIt($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PostItServiceApi->postIt: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\PostitPostIt**](\Swagger\Client\Model\PostitPostIt.md)|  | 

### Return type

[**\Swagger\Client\Model\PostitPostItResponse**](PostitPostItResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regenerateApiKey**
> \Swagger\Client\Model\PostitRegenerateApiKeyResponse regenerateApiKey($body)

PostItService.regenerateApiKey

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Swagger\Client\Api\PostItServiceApi();
$body = new \Swagger\Client\Model\PostitRegenerateApiKey(); // \Swagger\Client\Model\PostitRegenerateApiKey | 

try { 
    $result = $api_instance->regenerateApiKey($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PostItServiceApi->regenerateApiKey: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\PostitRegenerateApiKey**](\Swagger\Client\Model\PostitRegenerateApiKey.md)|  | 

### Return type

[**\Swagger\Client\Model\PostitRegenerateApiKeyResponse**](PostitRegenerateApiKeyResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **updatePostItTable**
> \Swagger\Client\Model\PostitUpdatePostItTableResponse updatePostItTable($body)

PostItService.updatePostItTable

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Swagger\Client\Api\PostItServiceApi();
$body = new \Swagger\Client\Model\PostitUpdatePostItTable(); // \Swagger\Client\Model\PostitUpdatePostItTable | 

try { 
    $result = $api_instance->updatePostItTable($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PostItServiceApi->updatePostItTable: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\PostitUpdatePostItTable**](\Swagger\Client\Model\PostitUpdatePostItTable.md)|  | 

### Return type

[**\Swagger\Client\Model\PostitUpdatePostItTableResponse**](PostitUpdatePostItTableResponse.md)

### Authorization

No authorization required

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

