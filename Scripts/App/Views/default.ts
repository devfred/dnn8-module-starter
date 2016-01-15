import {Component, View} from "angular2/core";
import {ROUTER_DIRECTIVES} from 'angular2/router';
import {CORE_DIRECTIVES} from 'angular2/common';
import {DnnService} from '../dnn.service';

@Component({
    selector: 'default-view'
})

@View({
    templateUrl: '/DesktopModules/ModuleStarter/Scripts/App/Views/default.html',
    directives: [ROUTER_DIRECTIVES, CORE_DIRECTIVES]
})

export class Default {
    
    _dnnService:DnnService;   
    data: Array<any>;
    
    constructor(dnnService:DnnService) {
        this._dnnService = dnnService;        
        this.GetData();
    }
    
    GetData(){
        this._dnnService.Get().subscribe(
            data => this.data = data,
            err => console.log(err)
        );
    }
    
    DeleteItem(item){
        return this._dnnService.Delete(item);
    }
   
}