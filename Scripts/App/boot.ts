import {bootstrap} from 'angular2/platform/browser';
import {provide} from 'angular2/core';
import {HTTP_BINDINGS} from 'angular2/http';
import {ROUTER_PROVIDERS, LocationStrategy, HashLocationStrategy} from 'angular2/router';
import {ModuleComponent} from './module.component';
import {DnnService} from './dnn.service';
import {ANGULAR2_GOOGLE_MAPS_PROVIDERS} from 'angular2-google-maps/core';
 
bootstrap(ModuleComponent, [DnnService, HTTP_BINDINGS, ROUTER_PROVIDERS, ANGULAR2_GOOGLE_MAPS_PROVIDERS, provide(LocationStrategy, {useClass: HashLocationStrategy})]);