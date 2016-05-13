
#include "SWGPostitPostItResponse.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitPostItResponse::SWGPostitPostItResponse(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitPostItResponse::SWGPostitPostItResponse() {
    init();
}

SWGPostitPostItResponse::~SWGPostitPostItResponse() {
    this->cleanup();
}

void
SWGPostitPostItResponse::init() {
    
}

void
SWGPostitPostItResponse::cleanup() {
    
}

SWGPostitPostItResponse*
SWGPostitPostItResponse::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitPostItResponse::fromJsonObject(QJsonObject &pJson) {
    
}

QString
SWGPostitPostItResponse::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitPostItResponse::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    

    return obj;
}



} /* namespace Swagger */

