
#include "SWGPostitRegenerateApiKeyResponse.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitRegenerateApiKeyResponse::SWGPostitRegenerateApiKeyResponse(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitRegenerateApiKeyResponse::SWGPostitRegenerateApiKeyResponse() {
    init();
}

SWGPostitRegenerateApiKeyResponse::~SWGPostitRegenerateApiKeyResponse() {
    this->cleanup();
}

void
SWGPostitRegenerateApiKeyResponse::init() {
    api_key = new QString("");
    
}

void
SWGPostitRegenerateApiKeyResponse::cleanup() {
    if(api_key != NULL) {
        delete api_key;
    }
    
}

SWGPostitRegenerateApiKeyResponse*
SWGPostitRegenerateApiKeyResponse::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitRegenerateApiKeyResponse::fromJsonObject(QJsonObject &pJson) {
    setValue(&api_key, pJson["api_key"], "QString", "QString");
    
}

QString
SWGPostitRegenerateApiKeyResponse::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitRegenerateApiKeyResponse::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("api_key"), api_key, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGPostitRegenerateApiKeyResponse::getApiKey() {
    return api_key;
}
void
SWGPostitRegenerateApiKeyResponse::setApiKey(QString* api_key) {
    this->api_key = api_key;
}



} /* namespace Swagger */

