import { ResolveFn } from '@angular/router';
import { ParticipantService } from '../../services/participant/participant.service';
import { inject } from '@angular/core';
import { Observable, of } from 'rxjs';

export const participantResolver: ResolveFn<unknown> = (route, state): Observable<unknown> => {
  if (route.params && route.params['id']) {
    return inject(ParticipantService).loadById(route.params['id']);
  }
  return of({id: '', name: ''});
};
