
#include "SWGPostitCreatePostItTableResponse.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitCreatePostItTableResponse::SWGPostitCreatePostItTableResponse(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitCreatePostItTableResponse::SWGPostitCreatePostItTableResponse() {
    init();
}

SWGPostitCreatePostItTableResponse::~SWGPostitCreatePostItTableResponse() {
    this->cleanup();
}

void
SWGPostitCreatePostItTableResponse::init() {
    api_key = new QString("");
    
}

void
SWGPostitCreatePostItTableResponse::cleanup() {
    if(api_key != NULL) {
        delete api_key;
    }
    
}

SWGPostitCreatePostItTableResponse*
SWGPostitCreatePostItTableResponse::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitCreatePostItTableResponse::fromJsonObject(QJsonObject &pJson) {
    setValue(&api_key, pJson["api_key"], "QString", "QString");
    
}

QString
SWGPostitCreatePostItTableResponse::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitCreatePostItTableResponse::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("api_key"), api_key, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGPostitCreatePostItTableResponse::getApiKey() {
    return api_key;
}
void
SWGPostitCreatePostItTableResponse::setApiKey(QString* api_key) {
    this->api_key = api_key;
}



} /* namespace Swagger */

