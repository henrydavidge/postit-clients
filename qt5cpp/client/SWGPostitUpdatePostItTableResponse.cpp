
#include "SWGPostitUpdatePostItTableResponse.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitUpdatePostItTableResponse::SWGPostitUpdatePostItTableResponse(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitUpdatePostItTableResponse::SWGPostitUpdatePostItTableResponse() {
    init();
}

SWGPostitUpdatePostItTableResponse::~SWGPostitUpdatePostItTableResponse() {
    this->cleanup();
}

void
SWGPostitUpdatePostItTableResponse::init() {
    
}

void
SWGPostitUpdatePostItTableResponse::cleanup() {
    
}

SWGPostitUpdatePostItTableResponse*
SWGPostitUpdatePostItTableResponse::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitUpdatePostItTableResponse::fromJsonObject(QJsonObject &pJson) {
    
}

QString
SWGPostitUpdatePostItTableResponse::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitUpdatePostItTableResponse::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    

    return obj;
}



} /* namespace Swagger */

