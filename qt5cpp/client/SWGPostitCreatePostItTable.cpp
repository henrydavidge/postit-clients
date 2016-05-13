
#include "SWGPostitCreatePostItTable.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGPostitCreatePostItTable::SWGPostitCreatePostItTable(QString* json) {
    init();
    this->fromJson(*json);
}

SWGPostitCreatePostItTable::SWGPostitCreatePostItTable() {
    init();
}

SWGPostitCreatePostItTable::~SWGPostitCreatePostItTable() {
    this->cleanup();
}

void
SWGPostitCreatePostItTable::init() {
    path = new QString("");
    schema = new QString("");
    shard_name = new QString("");
    
}

void
SWGPostitCreatePostItTable::cleanup() {
    if(path != NULL) {
        delete path;
    }
    if(schema != NULL) {
        delete schema;
    }
    if(shard_name != NULL) {
        delete shard_name;
    }
    
}

SWGPostitCreatePostItTable*
SWGPostitCreatePostItTable::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGPostitCreatePostItTable::fromJsonObject(QJsonObject &pJson) {
    setValue(&path, pJson["path"], "QString", "QString");
    setValue(&schema, pJson["schema"], "QString", "QString");
    setValue(&shard_name, pJson["shard_name"], "QString", "QString");
    
}

QString
SWGPostitCreatePostItTable::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGPostitCreatePostItTable::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("path"), path, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("schema"), schema, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("shard_name"), shard_name, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGPostitCreatePostItTable::getPath() {
    return path;
}
void
SWGPostitCreatePostItTable::setPath(QString* path) {
    this->path = path;
}

QString*
SWGPostitCreatePostItTable::getSchema() {
    return schema;
}
void
SWGPostitCreatePostItTable::setSchema(QString* schema) {
    this->schema = schema;
}

QString*
SWGPostitCreatePostItTable::getShardName() {
    return shard_name;
}
void
SWGPostitCreatePostItTable::setShardName(QString* shard_name) {
    this->shard_name = shard_name;
}



} /* namespace Swagger */

