
#include "SWGPostitDeleteApiKeyResponse.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitDeleteApiKeyResponse::SWGPostitDeleteApiKeyResponse(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitDeleteApiKeyResponse::SWGPostitDeleteApiKeyResponse() {
    init();
}

SWGPostitDeleteApiKeyResponse::~SWGPostitDeleteApiKeyResponse() {
    this->cleanup();
}

void
SWGPostitDeleteApiKeyResponse::init() {
    
}

void
SWGPostitDeleteApiKeyResponse::cleanup() {
    
}

SWGPostitDeleteApiKeyResponse*
SWGPostitDeleteApiKeyResponse::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitDeleteApiKeyResponse::fromJsonObject(QJsonObject &pJson) {
    
}

QString
SWGPostitDeleteApiKeyResponse::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitDeleteApiKeyResponse::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    

    return obj;
}



} /* namespace Swagger */

