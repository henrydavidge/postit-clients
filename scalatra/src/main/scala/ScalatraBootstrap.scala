import com.wordnik.client.api._
import akka.actor.ActorSystem
import io.swagger.app.{ResourcesApp, SwaggerApp}
import javax.servlet.ServletContext
import org.scalatra.LifeCycle

class ScalatraBootstrap extends LifeCycle {
  implicit val swagger = new SwaggerApp

  override def init(context: ServletContext) {
    implicit val system = ActorSystem("appActorSystem")
    try {
      context mount (new PostItServiceApi, "/PostItService/*")
      
      context mount (new ResourcesApp, "/api-docs/*")
    } catch {
      case e: Throwable => e.printStackTrace()
    }
  }
}