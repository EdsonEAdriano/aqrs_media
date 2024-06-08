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

  constructor(private httpClient: HttpClient
  ) { }

  getAll()  {
    return this.httpClient.get<Participant[]>(this.API)
    .pipe(
      first(),
      tap(participants => console.log(participants))
    );
  }

  save(record: Partial<Participant>) {
    // console.log(record)
    if (record.id) {
      // console.log('update');
      return this.update(record);
    }
    // console.log('create');
    return this.create(record);
  }

  private create(record: Partial<Participant>) {
    return this.httpClient.post<Participant>(this.API, record).pipe(first());
  }

  update(record: Partial<Participant>) {
    return this.httpClient.put<Participant>(`${this.API}/${record.id}`, record).pipe(first());
  }

  delete(id: string) {
    console.log(`senhor -> ${this.API}/${id}`);
    return this.httpClient.delete(`${this.API}/${id}`).pipe(first());
  }



  loadById(id: string) {
    return this.httpClient.get<Participant>(`${this.API}/${id}`);
  }
}
