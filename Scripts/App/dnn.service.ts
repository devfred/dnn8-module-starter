/// <reference path="../typings/tsd.d.ts" />
import {Injectable} from 'angular2/core';
import {Http, Headers} from 'angular2/http';
import 'rxjs/Rx';

var _http;

@Injectable()
export class DnnService{    
    
    moduleId: any;
    baseUrl: String;
                 
    constructor(http:Http){
        _http = http;
    }
    
    GetServiceRoot(moduleName){
        var serviceRoot = dnn.getVar("sf_siteRoot", "/");
        serviceRoot += "DesktopModules/" + moduleName + "/API/";
        return serviceRoot;
    }
    
    GetTabId(){
        return dnn.getVar("sf_tabId", -1);
    }
    
    GetHeaders(){
        var headers = new Headers();
        var tabId = this.GetTabId();
        if (tabId > -1) {
           headers.append('ModuleId', this.moduleId );
           headers.append('TabId', this.GetTabId() );
        }        
        var afValue = this.GetAntiForgeryValue();
        if (afValue) {
            headers.append("RequestVerificationToken", afValue);
        }
        headers.append("Accept", "application/json");
        headers.append("Content-Type", "application/json");
        return headers
    }
           
    Get(){                       
        return _http.get(this.baseUrl, {headers: this.GetHeaders()}).map(res => res.json())         
    }
    
    GetItem(itemId){
        return _http.get(this.baseUrl + itemId, {headers: this.GetHeaders()}).map(res => res.json())
    }
    
    CreateItem(item){
        return _http.post(this.baseUrl, JSON.stringify(item), {headers: this.GetHeaders()}).map(res => res.json())
    }
    
    Delete(itemId){
         return _http.delete(this.baseUrl + itemId, {headers: this.GetHeaders()}).map(res => res.json())
    }
            
    GetAntiForgeryValue = function() {
      return jQuery('[name="__RequestVerificationToken"]').val();
    }
         
}