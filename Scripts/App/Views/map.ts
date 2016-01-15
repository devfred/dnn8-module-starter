import {Component, View} from "angular2/core";
import {ROUTER_DIRECTIVES} from 'angular2/router';
import {CORE_DIRECTIVES} from 'angular2/common';
import {MapMouseEvent,ANGULAR2_GOOGLE_MAPS_DIRECTIVES} from 'angular2-google-maps/core';
import {DnnService} from '../dnn.service';

@Component({
    selector: 'map-view'
})


@View({
    templateUrl: '/DesktopModules/ModuleStarter/Scripts/App/Views/map.html',
    directives: [ANGULAR2_GOOGLE_MAPS_DIRECTIVES],
    styles: [`
        .sebm-google-map-container { height: 300px;}
    `]
})

export class Map {

  // google maps zoom level
  zoom: number = 8;
  
  // initial center position for the map
  lat: number = 51.673858;
  lng: number = 7.815982;
  
  clickedMarker(label: string) {
    window.alert(`clicked the marker: ${label || ''}`)
  }
  
  mapClicked($event: MapMouseEvent) {
    this.markers.push({
      lat: $event.coords.lat,
      lng: $event.coords.lng
    });
  }
  
  markers: marker[] = [
	  {
		  lat: 51.673858,
		  lng: 7.815982,
		  label: 'A'
	  },
	  {
		  lat: 51.373858,
		  lng: 7.215982,
		  label: 'B'
	  },
	  {
		  lat: 51.723858,
		  lng: 7.895982,
		  label: 'C'
	  }
  ]
}
// just an interface for type safety.
interface marker {
	lat: number;
	lng: number;
	label?: string;
}