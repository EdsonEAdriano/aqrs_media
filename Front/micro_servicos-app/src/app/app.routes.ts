import { Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { ParticipantComponent } from './microsservicos/components/participant/participant.component';

export const routes: Routes = [
  // {path: 'Participant', component: ParticipantComponent}
  {path: '', pathMatch: 'full', redirectTo: 'app'},
  // {
  //   path: 'app',
  //   component: AppComponent
  // },
  {
    path: 'app',
    loadChildren: () => import('./microsservicos/microsservicos.routes').then(m => m.PART_ROUTES)
  }
];
