/*
 * SWGPostitRegenerateApiKey.h
 * 
 * 
 */

#ifndef SWGPostitRegenerateApiKey_H_
#define SWGPostitRegenerateApiKey_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGPostitRegenerateApiKey: public SWGObject {
public:
    SWGPostitRegenerateApiKey();
    SWGPostitRegenerateApiKey(QString* json);
    virtual ~SWGPostitRegenerateApiKey();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitRegenerateApiKey* fromJson(QString &jsonString);

    QString* getApiKey();
    void setApiKey(QString* api_key);
    

private:
    QString* api_key;
    
};

} /* namespace Swagger */

#endif /* SWGPostitRegenerateApiKey_H_ */
