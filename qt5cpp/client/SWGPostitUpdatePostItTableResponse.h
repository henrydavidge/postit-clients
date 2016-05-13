/*
 * SWGPostitUpdatePostItTableResponse.h
 * 
 * 
 */

#ifndef SWGPostitUpdatePostItTableResponse_H_
#define SWGPostitUpdatePostItTableResponse_H_

#include <QJsonObject>



#include "SWGObject.h"


namespace Swagger {

class SWGPostitUpdatePostItTableResponse: public SWGObject {
public:
    SWGPostitUpdatePostItTableResponse();
    SWGPostitUpdatePostItTableResponse(QString* json);
    virtual ~SWGPostitUpdatePostItTableResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitUpdatePostItTableResponse* fromJson(QString &jsonString);

    

private:
    
};

} /* namespace Swagger */

#endif /* SWGPostitUpdatePostItTableResponse_H_ */
