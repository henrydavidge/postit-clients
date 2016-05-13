
#include "SWGPostitRegenerateApiKey.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitRegenerateApiKey::SWGPostitRegenerateApiKey(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitRegenerateApiKey::SWGPostitRegenerateApiKey() {
    init();
}

SWGPostitRegenerateApiKey::~SWGPostitRegenerateApiKey() {
    this->cleanup();
}

void
SWGPostitRegenerateApiKey::init() {
    api_key = new QString("");
    
}

void
SWGPostitRegenerateApiKey::cleanup() {
    if(api_key != NULL) {
        delete api_key;
    }
    
}

SWGPostitRegenerateApiKey*
SWGPostitRegenerateApiKey::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitRegenerateApiKey::fromJsonObject(QJsonObject &pJson) {
    setValue(&api_key, pJson["api_key"], "QString", "QString");
    
}

QString
SWGPostitRegenerateApiKey::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitRegenerateApiKey::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("api_key"), api_key, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGPostitRegenerateApiKey::getApiKey() {
    return api_key;
}
void
SWGPostitRegenerateApiKey::setApiKey(QString* api_key) {
    this->api_key = api_key;
}



} /* namespace Swagger */

