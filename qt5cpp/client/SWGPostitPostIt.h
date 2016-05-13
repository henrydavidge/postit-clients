/*
 * SWGPostitPostIt.h
 * 
 * 
 */

#ifndef SWGPostitPostIt_H_
#define SWGPostitPostIt_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGPostitPostIt: public SWGObject {
public:
    SWGPostitPostIt();
    SWGPostitPostIt(QString* json);
    virtual ~SWGPostitPostIt();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGPostitPostIt* fromJson(QString &jsonString);

    QString* getApiKey();
    void setApiKey(QString* api_key);
    qint64 getEventTime();
    void setEventTime(qint64 event_time);
    QString* getPayload();
    void setPayload(QString* payload);
    

private:
    QString* api_key;
    qint64 event_time;
    QString* payload;
    
};

} /* namespace Swagger */

#endif /* SWGPostitPostIt_H_ */
