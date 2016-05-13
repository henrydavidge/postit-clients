
#include "SWGPostitUpdatePostItTable.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitUpdatePostItTable::SWGPostitUpdatePostItTable(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitUpdatePostItTable::SWGPostitUpdatePostItTable() {
    init();
}

SWGPostitUpdatePostItTable::~SWGPostitUpdatePostItTable() {
    this->cleanup();
}

void
SWGPostitUpdatePostItTable::init() {
    api_key = new QString("");
    path = new QString("");
    schema = new QString("");
    
}

void
SWGPostitUpdatePostItTable::cleanup() {
    if(api_key != NULL) {
        delete api_key;
    }
    if(path != NULL) {
        delete path;
    }
    if(schema != NULL) {
        delete schema;
    }
    
}

SWGPostitUpdatePostItTable*
SWGPostitUpdatePostItTable::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitUpdatePostItTable::fromJsonObject(QJsonObject &pJson) {
    setValue(&api_key, pJson["api_key"], "QString", "QString");
    setValue(&path, pJson["path"], "QString", "QString");
    setValue(&schema, pJson["schema"], "QString", "QString");
    
}

QString
SWGPostitUpdatePostItTable::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitUpdatePostItTable::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("api_key"), api_key, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("path"), path, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("schema"), schema, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGPostitUpdatePostItTable::getApiKey() {
    return api_key;
}
void
SWGPostitUpdatePostItTable::setApiKey(QString* api_key) {
    this->api_key = api_key;
}

QString*
SWGPostitUpdatePostItTable::getPath() {
    return path;
}
void
SWGPostitUpdatePostItTable::setPath(QString* path) {
    this->path = path;
}

QString*
SWGPostitUpdatePostItTable::getSchema() {
    return schema;
}
void
SWGPostitUpdatePostItTable::setSchema(QString* schema) {
    this->schema = schema;
}



} /* namespace Swagger */

