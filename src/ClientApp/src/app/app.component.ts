import { Component } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app works updated!';
  videoGames = [];

  constructor(private http: Http) {}

  loadVideoGames() {
    this.http.get("http://localhost:5000/api/videogames")
    .map((res: Response) => res.json())
    .subscribe(data => {
      console.log(data);
      this.videoGames = data;
    });
  }
}
