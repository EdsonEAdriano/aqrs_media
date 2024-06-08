import { Routes } from '@angular/router';
import { ParticipantComponent } from './components/participant/participant.component';
import { ParticipantFormComponent } from './forms/participant/participant-form/participant-form.component';

export const PART_ROUTES: Routes = [
  // {path : '', component: ParticipantComponent},
  {path : 'Participant', component: ParticipantComponent},
  {path : 'newParticipant', component: ParticipantFormComponent}
];
