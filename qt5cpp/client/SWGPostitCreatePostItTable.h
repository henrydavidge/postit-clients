/*
 * SWGPostitCreatePostItTable.h
 * 
 * 
 */

#ifndef SWGPostitCreatePostItTable_H_
#define SWGPostitCreatePostItTable_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGPostitCreatePostItTable: public SWGObject {
public:
    SWGPostitCreatePostItTable();
    SWGPostitCreatePostItTable(QString* json);
    virtual ~SWGPostitCreatePostItTable();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitCreatePostItTable* fromJson(QString &jsonString);

    QString* getPath();
    void setPath(QString* path);
    QString* getSchema();
    void setSchema(QString* schema);
    QString* getShardName();
    void setShardName(QString* shard_name);
    

private:
    QString* path;
    QString* schema;
    QString* shard_name;
    
};

} /* namespace Swagger */

#endif /* SWGPostitCreatePostItTable_H_ */
