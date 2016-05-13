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
import com.wordnik.swagger.client._
import scala.concurrent.Future
import collection.mutable

class PostItServiceApi(client: TransportClient, config: SwaggerConfig) extends ApiClient(client, config) {

  
  def createPostItTable(body: PostitCreatePostItTable)(implicit reader: ClientResponseReader[PostitCreatePostItTableResponse], writer: RequestWriter[PostitCreatePostItTable]): Future[PostitCreatePostItTableResponse] = {
    // create path and map variables
    val path = (addFmt("/api/1.0/create"))

    // query params
    val queryParams = new mutable.HashMap[String, String]
    val headerParams = new mutable.HashMap[String, String]

    

    

    

    val resFuture = client.submit("POST", path, queryParams.toMap, headerParams.toMap, writer.write(body))
    resFuture flatMap { resp =>
      process(reader.read(resp))
    }
  }

  
  def deleteApiKey(body: PostitDeleteApiKey)(implicit reader: ClientResponseReader[PostitDeleteApiKeyResponse], writer: RequestWriter[PostitDeleteApiKey]): Future[PostitDeleteApiKeyResponse] = {
    // create path and map variables
    val path = (addFmt("/api/1.0/delete"))

    // query params
    val queryParams = new mutable.HashMap[String, String]
    val headerParams = new mutable.HashMap[String, String]

    

    

    

    val resFuture = client.submit("POST", path, queryParams.toMap, headerParams.toMap, writer.write(body))
    resFuture flatMap { resp =>
      process(reader.read(resp))
    }
  }

  
  def postIt(body: PostitPostIt)(implicit reader: ClientResponseReader[PostitPostItResponse], writer: RequestWriter[PostitPostIt]): Future[PostitPostItResponse] = {
    // create path and map variables
    val path = (addFmt("/api/1.0/post"))

    // query params
    val queryParams = new mutable.HashMap[String, String]
    val headerParams = new mutable.HashMap[String, String]

    

    

    

    val resFuture = client.submit("POST", path, queryParams.toMap, headerParams.toMap, writer.write(body))
    resFuture flatMap { resp =>
      process(reader.read(resp))
    }
  }

  
  def regenerateApiKey(body: PostitRegenerateApiKey)(implicit reader: ClientResponseReader[PostitRegenerateApiKeyResponse], writer: RequestWriter[PostitRegenerateApiKey]): Future[PostitRegenerateApiKeyResponse] = {
    // create path and map variables
    val path = (addFmt("/api/1.0/regenerate"))

    // query params
    val queryParams = new mutable.HashMap[String, String]
    val headerParams = new mutable.HashMap[String, String]

    

    

    

    val resFuture = client.submit("POST", path, queryParams.toMap, headerParams.toMap, writer.write(body))
    resFuture flatMap { resp =>
      process(reader.read(resp))
    }
  }

  
  def updatePostItTable(body: PostitUpdatePostItTable)(implicit reader: ClientResponseReader[PostitUpdatePostItTableResponse], writer: RequestWriter[PostitUpdatePostItTable]): Future[PostitUpdatePostItTableResponse] = {
    // create path and map variables
    val path = (addFmt("/api/1.0/update"))

    // query params
    val queryParams = new mutable.HashMap[String, String]
    val headerParams = new mutable.HashMap[String, String]

    

    

    

    val resFuture = client.submit("POST", path, queryParams.toMap, headerParams.toMap, writer.write(body))
    resFuture flatMap { resp =>
      process(reader.read(resp))
    }
  }

  

}
