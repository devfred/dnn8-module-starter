import {Component, ElementRef} from 'angular2/core';
import {RouteConfig, RouterLink,RouterOutlet,Route,Location,Router, ROUTER_DIRECTIVES} from 'angular2/router';
import {DnnService} from './dnn.service';
import {Default} from './views/default';
import {Edit} from './views/edit';
import {Map} from './views/map';

@Component({
    selector: 'dnn-module',
    templateUrl: '/DesktopModules/ModuleStarter/Scripts/App/module.component.template.html',
    directives: [ROUTER_DIRECTIVES]
})

@RouteConfig([  
  { path: '/', component: Default, as: 'Default' },
  { path: '/Edit/:id', component: Edit, as: 'Edit' },
  { path: '/Map', component: Map, as: 'Map' }
])

 
export class ModuleComponent {
            
    _dnnService:DnnService;
    _router: Router;
    _location: Location;
       
    constructor(dnnService: DnnService, private elementRef: ElementRef, router: Router, location: Location){
        this._router = router;
        this._location = location;
        this._dnnService = dnnService;                               
        this._dnnService.moduleId = this.elementRef.nativeElement.getAttribute("module-id");        
        this._dnnService.baseUrl = dnnService.GetServiceRoot("ModuleStarter") + 'Item/';                                               
    }
                                    
 }