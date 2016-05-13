package com.wordnik.client.api

import com.wordnik.client.model.PostitCreatePostItTableResponse
import com.wordnik.client.model.PostitCreatePostItTable
import com.wordnik.client.model.PostitDeleteApiKey
import com.wordnik.client.model.PostitDeleteApiKeyResponse
import com.wordnik.client.model.PostitPostItResponse
import com.wordnik.client.model.PostitPostIt
import com.wordnik.client.model.PostitRegenerateApiKeyResponse
import com.wordnik.client.model.PostitRegenerateApiKey
import com.wordnik.client.model.PostitUpdatePostItTable
import com.wordnik.client.model.PostitUpdatePostItTableResponse

import java.io.File

import org.scalatra.{ TypedParamSupport, ScalatraServlet }
import org.scalatra.swagger._
import org.json4s._
import org.json4s.JsonDSL._
import org.scalatra.json.{ JValueResult, JacksonJsonSupport }
import org.scalatra.servlet.{FileUploadSupport, MultipartConfig, SizeConstraintExceededException}

import scala.collection.JavaConverters._

class PostItServiceApi (implicit val swagger: Swagger) extends ScalatraServlet 
    with FileUploadSupport
    with JacksonJsonSupport
    with SwaggerSupport {
  protected implicit val jsonFormats: Formats = DefaultFormats

  protected val applicationDescription: String = "PostItServiceApi"
  override protected val applicationName: Option[String] = Some("PostItService")

  before() {
    contentType = formats("json")
    response.headers += ("Access-Control-Allow-Origin" -> "*")
  }
  

  val createPostItTableOperation = (apiOperation[PostitCreatePostItTableResponse]("createPostItTable")
      summary "PostItService.createPostItTable"
      parameters(bodyParam[PostitCreatePostItTable]("body").description(""))
  )

  post("/api/1.0/create",operation(createPostItTableOperation)) {
    
    
    
                
bodyParam[PostitCreatePostItTable]("body").description("")
    
    println("body: " + body)
  
  }

  

  val deleteApiKeyOperation = (apiOperation[PostitDeleteApiKeyResponse]("deleteApiKey")
      summary "PostItService.deleteApiKey"
      parameters(bodyParam[PostitDeleteApiKey]("body").description(""))
  )

  post("/api/1.0/delete",operation(deleteApiKeyOperation)) {
    
    
    
                
bodyParam[PostitDeleteApiKey]("body").description("")
    
    println("body: " + body)
  
  }

  

  val postItOperation = (apiOperation[PostitPostItResponse]("postIt")
      summary "PostItService.postIt"
      parameters(bodyParam[PostitPostIt]("body").description(""))
  )

  post("/api/1.0/post",operation(postItOperation)) {
    
    
    
                
bodyParam[PostitPostIt]("body").description("")
    
    println("body: " + body)
  
  }

  

  val regenerateApiKeyOperation = (apiOperation[PostitRegenerateApiKeyResponse]("regenerateApiKey")
      summary "PostItService.regenerateApiKey"
      parameters(bodyParam[PostitRegenerateApiKey]("body").description(""))
  )

  post("/api/1.0/regenerate",operation(regenerateApiKeyOperation)) {
    
    
    
                
bodyParam[PostitRegenerateApiKey]("body").description("")
    
    println("body: " + body)
  
  }

  

  val updatePostItTableOperation = (apiOperation[PostitUpdatePostItTableResponse]("updatePostItTable")
      summary "PostItService.updatePostItTable"
      parameters(bodyParam[PostitUpdatePostItTable]("body").description(""))
  )

  post("/api/1.0/update",operation(updatePostItTableOperation)) {
    
    
    
                
bodyParam[PostitUpdatePostItTable]("body").description("")
    
    println("body: " + body)
  
  }

}