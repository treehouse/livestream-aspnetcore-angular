import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { VideoGamesComponent } from './video-games/video-games.component';
import { VideoGameAddComponent } from './video-game-add/video-game-add.component';

const routes: Routes = [
  { path: 'videogames', component: VideoGamesComponent },
  { path: 'videogames/add', component: VideoGameAddComponent },
  { path: '', redirectTo: '/videogames', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
