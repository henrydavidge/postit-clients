/*
 * SWGPostitDeleteApiKey.h
 * 
 * 
 */

#ifndef SWGPostitDeleteApiKey_H_
#define SWGPostitDeleteApiKey_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGPostitDeleteApiKey: public SWGObject {
public:
    SWGPostitDeleteApiKey();
    SWGPostitDeleteApiKey(QString* json);
    virtual ~SWGPostitDeleteApiKey();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitDeleteApiKey* fromJson(QString &jsonString);

    QString* getApiKey();
    void setApiKey(QString* api_key);
    

private:
    QString* api_key;
    
};

} /* namespace Swagger */

#endif /* SWGPostitDeleteApiKey_H_ */
