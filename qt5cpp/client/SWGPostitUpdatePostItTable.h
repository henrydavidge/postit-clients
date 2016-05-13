/*
 * SWGPostitUpdatePostItTable.h
 * 
 * 
 */

#ifndef SWGPostitUpdatePostItTable_H_
#define SWGPostitUpdatePostItTable_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGPostitUpdatePostItTable: public SWGObject {
public:
    SWGPostitUpdatePostItTable();
    SWGPostitUpdatePostItTable(QString* json);
    virtual ~SWGPostitUpdatePostItTable();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitUpdatePostItTable* fromJson(QString &jsonString);

    QString* getApiKey();
    void setApiKey(QString* api_key);
    QString* getPath();
    void setPath(QString* path);
    QString* getSchema();
    void setSchema(QString* schema);
    

private:
    QString* api_key;
    QString* path;
    QString* schema;
    
};

} /* namespace Swagger */

#endif /* SWGPostitUpdatePostItTable_H_ */
