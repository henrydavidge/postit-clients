
#include "SWGPostitPostIt.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitPostIt::SWGPostitPostIt(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitPostIt::SWGPostitPostIt() {
    init();
}

SWGPostitPostIt::~SWGPostitPostIt() {
    this->cleanup();
}

void
SWGPostitPostIt::init() {
    api_key = new QString("");
    event_time = 0L;
    payload = new QString("");
    
}

void
SWGPostitPostIt::cleanup() {
    if(api_key != NULL) {
        delete api_key;
    }
    
    if(payload != NULL) {
        delete payload;
    }
    
}

SWGPostitPostIt*
SWGPostitPostIt::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitPostIt::fromJsonObject(QJsonObject &pJson) {
    setValue(&api_key, pJson["api_key"], "QString", "QString");
    setValue(&event_time, pJson["event_time"], "qint64", "");
    setValue(&payload, pJson["payload"], "QString", "QString");
    
}

QString
SWGPostitPostIt::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitPostIt::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("api_key"), api_key, obj, QString("QString"));
    
    
    
    obj->insert("event_time", QJsonValue(event_time));
    
    
    toJsonValue(QString("payload"), payload, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGPostitPostIt::getApiKey() {
    return api_key;
}
void
SWGPostitPostIt::setApiKey(QString* api_key) {
    this->api_key = api_key;
}

qint64
SWGPostitPostIt::getEventTime() {
    return event_time;
}
void
SWGPostitPostIt::setEventTime(qint64 event_time) {
    this->event_time = event_time;
}

QString*
SWGPostitPostIt::getPayload() {
    return payload;
}
void
SWGPostitPostIt::setPayload(QString* payload) {
    this->payload = payload;
}



} /* namespace Swagger */

