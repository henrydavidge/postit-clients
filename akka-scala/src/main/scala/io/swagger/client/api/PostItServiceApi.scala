package io.swagger.client.api

import io.swagger.client.model.PostitCreatePostItTableResponse
import io.swagger.client.model.PostitCreatePostItTable
import io.swagger.client.model.PostitDeleteApiKey
import io.swagger.client.model.PostitDeleteApiKeyResponse
import io.swagger.client.model.PostitPostItResponse
import io.swagger.client.model.PostitPostIt
import io.swagger.client.model.PostitRegenerateApiKeyResponse
import io.swagger.client.model.PostitRegenerateApiKey
import io.swagger.client.model.PostitUpdatePostItTable
import io.swagger.client.model.PostitUpdatePostItTableResponse
import io.swagger.client.core._
import io.swagger.client.core.CollectionFormats._
import io.swagger.client.core.ApiKeyLocations._

object PostItServiceApi {

  /**
   * 
   * 
   * Expected answers:
   *   code 0 : PostitCreatePostItTableResponse (Description)
   * 
   * @param body 
   */
  def createPostItTable(body: PostitCreatePostItTable): ApiRequest[PostitCreatePostItTableResponse] =
    ApiRequest[PostitCreatePostItTableResponse](ApiMethods.POST, "http://localhost", "/api/1.0/create", "application/json")
      .withBody(body)
      .withDefaultSuccessResponse[PostitCreatePostItTableResponse]
      
  /**
   * 
   * 
   * Expected answers:
   *   code 0 : PostitDeleteApiKeyResponse (Description)
   * 
   * @param body 
   */
  def deleteApiKey(body: PostitDeleteApiKey): ApiRequest[PostitDeleteApiKeyResponse] =
    ApiRequest[PostitDeleteApiKeyResponse](ApiMethods.POST, "http://localhost", "/api/1.0/delete", "application/json")
      .withBody(body)
      .withDefaultSuccessResponse[PostitDeleteApiKeyResponse]
      
  /**
   * 
   * 
   * Expected answers:
   *   code 0 : PostitPostItResponse (Description)
   * 
   * @param body 
   */
  def postIt(body: PostitPostIt): ApiRequest[PostitPostItResponse] =
    ApiRequest[PostitPostItResponse](ApiMethods.POST, "http://localhost", "/api/1.0/post", "application/json")
      .withBody(body)
      .withDefaultSuccessResponse[PostitPostItResponse]
      
  /**
   * 
   * 
   * Expected answers:
   *   code 0 : PostitRegenerateApiKeyResponse (Description)
   * 
   * @param body 
   */
  def regenerateApiKey(body: PostitRegenerateApiKey): ApiRequest[PostitRegenerateApiKeyResponse] =
    ApiRequest[PostitRegenerateApiKeyResponse](ApiMethods.POST, "http://localhost", "/api/1.0/regenerate", "application/json")
      .withBody(body)
      .withDefaultSuccessResponse[PostitRegenerateApiKeyResponse]
      
  /**
   * 
   * 
   * Expected answers:
   *   code 0 : PostitUpdatePostItTableResponse (Description)
   * 
   * @param body 
   */
  def updatePostItTable(body: PostitUpdatePostItTable): ApiRequest[PostitUpdatePostItTableResponse] =
    ApiRequest[PostitUpdatePostItTableResponse](ApiMethods.POST, "http://localhost", "/api/1.0/update", "application/json")
      .withBody(body)
      .withDefaultSuccessResponse[PostitUpdatePostItTableResponse]
      


}

