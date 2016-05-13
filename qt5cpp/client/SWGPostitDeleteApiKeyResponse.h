/*
 * SWGPostitDeleteApiKeyResponse.h
 * 
 * 
 */

#ifndef SWGPostitDeleteApiKeyResponse_H_
#define SWGPostitDeleteApiKeyResponse_H_

#include <QJsonObject>



#include "SWGObject.h"


namespace Swagger {

class SWGPostitDeleteApiKeyResponse: public SWGObject {
public:
    SWGPostitDeleteApiKeyResponse();
    SWGPostitDeleteApiKeyResponse(QString* json);
    virtual ~SWGPostitDeleteApiKeyResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitDeleteApiKeyResponse* fromJson(QString &jsonString);

    

private:
    
};

} /* namespace Swagger */

#endif /* SWGPostitDeleteApiKeyResponse_H_ */
