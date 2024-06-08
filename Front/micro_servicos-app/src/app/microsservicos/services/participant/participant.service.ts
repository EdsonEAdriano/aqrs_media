import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Participant } from '../../model/participant';
import { first, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ParticipantService {
  // private readonly API = 'http://localhost:4200/api/Category';
  private readonly API = 'http://localhost:8080/participant'

  constructor(private httpClient: HttpClient) { }

  getAll()  {
    return this.httpClient.get<Participant[]>(this.API)
    .pipe(
      first(),
      tap(participants => console.log(participants))
    );
  }

  loadById(id: string) {
    return this.httpClient.get<Participant>(`${this.API}/${id}`);
  }
}
