/*
 * SWGPostitCreatePostItTableResponse.h
 * 
 * 
 */

#ifndef SWGPostitCreatePostItTableResponse_H_
#define SWGPostitCreatePostItTableResponse_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGPostitCreatePostItTableResponse: public SWGObject {
public:
    SWGPostitCreatePostItTableResponse();
    SWGPostitCreatePostItTableResponse(QString* json);
    virtual ~SWGPostitCreatePostItTableResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitCreatePostItTableResponse* fromJson(QString &jsonString);

    QString* getApiKey();
    void setApiKey(QString* api_key);
    

private:
    QString* api_key;
    
};

} /* namespace Swagger */

#endif /* SWGPostitCreatePostItTableResponse_H_ */
