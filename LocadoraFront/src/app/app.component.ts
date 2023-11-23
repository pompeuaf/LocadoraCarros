import { Component } from '@angular/core';
import { NavigationEnd, NavigationStart, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'LocadoraFront';

  IsLogin = false;

  constructor(private router: Router) { }
ngOnInit(): void {

  this.router.events.pipe().subscribe(event => {
    if (event instanceof NavigationStart) {
      if (event.url.includes('login')) {
        this.IsLogin = true;
      } else {
        this.IsLogin = false;
      }
    }
  });
}

}


