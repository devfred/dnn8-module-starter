import {Component, View} from "angular2/core";
import {RouteParams} from "angular2/router";
import {FORM_DIRECTIVES} from 'angular2/common'
import {DnnService} from '../dnn.service';

@Component({
    selector: 'edit-view'
})

@View({
    templateUrl: '/DesktopModules/ModuleStarter/Scripts/App/Views/edit.html',
    directives:[FORM_DIRECTIVES]
})

export class Edit {
    
    _dnnService:DnnService;    
    data:any = {
        id: -1,
        name: "",
        description: ""
    };
    
    constructor(dnnService:DnnService, params:RouteParams) {
        this._dnnService = dnnService;
        this.GetItem(params.get("id"));                       
    }
    
    GetItem(itemId){
        this._dnnService.GetItem(itemId).subscribe(
            data => this.data = data
        );
    }
    
    Save(){         
        this._dnnService.CreateItem(this.data).subscribe();
    }
    
}