/// <reference path="api.d.ts" />

/* tslint:disable:no-unused-variable member-ordering */

namespace API.Client {
    'use strict';

    export class PostItServiceApi {
        protected basePath = 'http://localhost';
        public defaultHeaders : any = {};

        static $inject: string[] = ['$http', '$httpParamSerializer'];

        constructor(protected $http: ng.IHttpService, protected $httpParamSerializer?: (d: any) => any, basePath?: string) {
            if (basePath) {
                this.basePath = basePath;
            }
        }

        private extendObj<T1,T2>(objA: T1, objB: T2) {
            for(let key in objB){
                if(objB.hasOwnProperty(key)){
                    objA[key] = objB[key];
                }
            }
            return <T1&T2>objA;
        }

        /**
         * PostItService.createPostItTable
         * 
         * @param body 
         */
        public createPostItTable (body: PostitCreatePostItTable, extraHttpRequestParams?: any ) : ng.IHttpPromise<PostitCreatePostItTableResponse> {
            const localVarPath = this.basePath + '/api/1.0/create';

            let queryParameters: any = {};
            let headerParams: any = this.extendObj({}, this.defaultHeaders);
            // verify required parameter 'body' is set
            if (!body) {
                throw new Error('Missing required parameter body when calling createPostItTable');
            }
            let httpRequestParams: any = {
                method: 'POST',
                url: localVarPath,
                json: true,
                data: body,
                
                
                params: queryParameters,
                headers: headerParams
            };

            if (extraHttpRequestParams) {
                httpRequestParams = this.extendObj(httpRequestParams, extraHttpRequestParams);
            }

            return this.$http(httpRequestParams);
        }
        /**
         * PostItService.deleteApiKey
         * 
         * @param body 
         */
        public deleteApiKey (body: PostitDeleteApiKey, extraHttpRequestParams?: any ) : ng.IHttpPromise<PostitDeleteApiKeyResponse> {
            const localVarPath = this.basePath + '/api/1.0/delete';

            let queryParameters: any = {};
            let headerParams: any = this.extendObj({}, this.defaultHeaders);
            // verify required parameter 'body' is set
            if (!body) {
                throw new Error('Missing required parameter body when calling deleteApiKey');
            }
            let httpRequestParams: any = {
                method: 'POST',
                url: localVarPath,
                json: true,
                data: body,
                
                
                params: queryParameters,
                headers: headerParams
            };

            if (extraHttpRequestParams) {
                httpRequestParams = this.extendObj(httpRequestParams, extraHttpRequestParams);
            }

            return this.$http(httpRequestParams);
        }
        /**
         * PostItService.postIt
         * 
         * @param body 
         */
        public postIt (body: PostitPostIt, extraHttpRequestParams?: any ) : ng.IHttpPromise<PostitPostItResponse> {
            const localVarPath = this.basePath + '/api/1.0/post';

            let queryParameters: any = {};
            let headerParams: any = this.extendObj({}, this.defaultHeaders);
            // verify required parameter 'body' is set
            if (!body) {
                throw new Error('Missing required parameter body when calling postIt');
            }
            let httpRequestParams: any = {
                method: 'POST',
                url: localVarPath,
                json: true,
                data: body,
                
                
                params: queryParameters,
                headers: headerParams
            };

            if (extraHttpRequestParams) {
                httpRequestParams = this.extendObj(httpRequestParams, extraHttpRequestParams);
            }

            return this.$http(httpRequestParams);
        }
        /**
         * PostItService.regenerateApiKey
         * 
         * @param body 
         */
        public regenerateApiKey (body: PostitRegenerateApiKey, extraHttpRequestParams?: any ) : ng.IHttpPromise<PostitRegenerateApiKeyResponse> {
            const localVarPath = this.basePath + '/api/1.0/regenerate';

            let queryParameters: any = {};
            let headerParams: any = this.extendObj({}, this.defaultHeaders);
            // verify required parameter 'body' is set
            if (!body) {
                throw new Error('Missing required parameter body when calling regenerateApiKey');
            }
            let httpRequestParams: any = {
                method: 'POST',
                url: localVarPath,
                json: true,
                data: body,
                
                
                params: queryParameters,
                headers: headerParams
            };

            if (extraHttpRequestParams) {
                httpRequestParams = this.extendObj(httpRequestParams, extraHttpRequestParams);
            }

            return this.$http(httpRequestParams);
        }
        /**
         * PostItService.updatePostItTable
         * 
         * @param body 
         */
        public updatePostItTable (body: PostitUpdatePostItTable, extraHttpRequestParams?: any ) : ng.IHttpPromise<PostitUpdatePostItTableResponse> {
            const localVarPath = this.basePath + '/api/1.0/update';

            let queryParameters: any = {};
            let headerParams: any = this.extendObj({}, this.defaultHeaders);
            // verify required parameter 'body' is set
            if (!body) {
                throw new Error('Missing required parameter body when calling updatePostItTable');
            }
            let httpRequestParams: any = {
                method: 'POST',
                url: localVarPath,
                json: true,
                data: body,
                
                
                params: queryParameters,
                headers: headerParams
            };

            if (extraHttpRequestParams) {
                httpRequestParams = this.extendObj(httpRequestParams, extraHttpRequestParams);
            }

            return this.$http(httpRequestParams);
        }
    }
}
