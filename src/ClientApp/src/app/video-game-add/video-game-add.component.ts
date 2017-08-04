import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';

class VideoGame {
  id: number;
  title: string;
  publishedOn: Date;
  platformId: number
}

class Platform {
  id: number;
  name: string;
}

@Component({
  selector: 'app-video-game-add',
  templateUrl: './video-game-add.component.html',
  styleUrls: ['./video-game-add.component.css']
})
export class VideoGameAddComponent implements OnInit {
  model: VideoGame;
  platforms: Platform[];

  constructor(private http: Http, private router: Router) { }

  ngOnInit() {
    this.model = new VideoGame();

    this.http.get("http://localhost:5000/api/platforms")
      .map((res: Response) => res.json())
      .subscribe(data => {
        console.log(data);
        this.platforms = data;
      });
  }

  onSubmit() {
    this.http.post('http://localhost:5000/api/videogames', this.model)
      .subscribe(() => {
        this.router.navigate(['/videogames']);
      });
  }
}
