package io.swagger.client.model

import io.swagger.client.core.ApiModel
import org.joda.time.DateTime


case class PostitPostIt (
  apiKey: Option[String],
  eventTime: Option[Long],
  payload: Option[String])
   extends ApiModel


