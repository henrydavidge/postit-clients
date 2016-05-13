
#include "SWGPostitDeleteApiKey.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitDeleteApiKey::SWGPostitDeleteApiKey(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitDeleteApiKey::SWGPostitDeleteApiKey() {
    init();
}

SWGPostitDeleteApiKey::~SWGPostitDeleteApiKey() {
    this->cleanup();
}

void
SWGPostitDeleteApiKey::init() {
    api_key = new QString("");
    
}

void
SWGPostitDeleteApiKey::cleanup() {
    if(api_key != NULL) {
        delete api_key;
    }
    
}

SWGPostitDeleteApiKey*
SWGPostitDeleteApiKey::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitDeleteApiKey::fromJsonObject(QJsonObject &pJson) {
    setValue(&api_key, pJson["api_key"], "QString", "QString");
    
}

QString
SWGPostitDeleteApiKey::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitDeleteApiKey::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("api_key"), api_key, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGPostitDeleteApiKey::getApiKey() {
    return api_key;
}
void
SWGPostitDeleteApiKey::setApiKey(QString* api_key) {
    this->api_key = api_key;
}



} /* namespace Swagger */

