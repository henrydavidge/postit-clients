(ns .api.post-it-service
  (:require [.core :refer [call-api check-required-params with-collection-format]])
  (:import (java.io File)))

(defn create-post-it-table-with-http-info
  "PostItService.createPostItTable"
  [body ]
  (call-api "/api/1.0/create" :post
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    body
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    []}))

(defn create-post-it-table
  "PostItService.createPostItTable"
  [body ]
  (:data (create-post-it-table-with-http-info body)))

(defn delete-api-key-with-http-info
  "PostItService.deleteApiKey"
  [body ]
  (call-api "/api/1.0/delete" :post
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    body
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    []}))

(defn delete-api-key
  "PostItService.deleteApiKey"
  [body ]
  (:data (delete-api-key-with-http-info body)))

(defn post-it-with-http-info
  "PostItService.postIt"
  [body ]
  (call-api "/api/1.0/post" :post
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    body
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    []}))

(defn post-it
  "PostItService.postIt"
  [body ]
  (:data (post-it-with-http-info body)))

(defn regenerate-api-key-with-http-info
  "PostItService.regenerateApiKey"
  [body ]
  (call-api "/api/1.0/regenerate" :post
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    body
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    []}))

(defn regenerate-api-key
  "PostItService.regenerateApiKey"
  [body ]
  (:data (regenerate-api-key-with-http-info body)))

(defn update-post-it-table-with-http-info
  "PostItService.updatePostItTable"
  [body ]
  (call-api "/api/1.0/update" :post
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    body
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    []}))

(defn update-post-it-table
  "PostItService.updatePostItTable"
  [body ]
  (:data (update-post-it-table-with-http-info body)))
