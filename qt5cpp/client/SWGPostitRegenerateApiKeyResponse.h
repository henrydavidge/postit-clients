/*
 * SWGPostitRegenerateApiKeyResponse.h
 * 
 * 
 */

#ifndef SWGPostitRegenerateApiKeyResponse_H_
#define SWGPostitRegenerateApiKeyResponse_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGPostitRegenerateApiKeyResponse: public SWGObject {
public:
    SWGPostitRegenerateApiKeyResponse();
    SWGPostitRegenerateApiKeyResponse(QString* json);
    virtual ~SWGPostitRegenerateApiKeyResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitRegenerateApiKeyResponse* fromJson(QString &jsonString);

    QString* getApiKey();
    void setApiKey(QString* api_key);
    

private:
    QString* api_key;
    
};

} /* namespace Swagger */

#endif /* SWGPostitRegenerateApiKeyResponse_H_ */
