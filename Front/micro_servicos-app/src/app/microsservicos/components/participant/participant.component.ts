import { Participant } from './../../model/participant';
import { ParticipantService } from '../../services/participant/participant.service';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AppMaterialModule } from '../../app-material/app-material/app-material.module';
import { Observable } from 'rxjs';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-participant',
  standalone: true,
  imports: [AppMaterialModule],
  templateUrl: './participant.component.html',
  styleUrl: './participant.component.scss'
})
export class ParticipantComponent implements OnInit{
  // participants: Participant [] = [{_id: '1', name: 'Djonathan'}];
  participants: Observable<Participant[]>;
  // @Input() participants: Participant[] = [];
  // @Output() add = new EventEmitter(false);
  // @Output() edit = new EventEmitter(false);
  // @Output() remove = new EventEmitter(false);

  readonly displayedColumns = ['name', 'createdDate', 'actions'];

  constructor (
    private participanteService: ParticipantService,
    private router: Router,
    private route: ActivatedRoute
  ) {
    this.participants = this.participanteService.getAll();


  }

  ngOnInit(): void {

  };

  onAdd() {
    this.router.navigate(['app/newParticipant']);
  }

  onEdit(participant: Participant){
    this.router.navigate(['app/editParticipant', participant.id]);
    // this.participanteService.update(participant).subscribe;
  }

  onDelete(participant: Participant) {
    // this.participanteService.delete(participant.id);
    this.participanteService.delete(participant.id).subscribe(
      () => {
        console.log('Delete successful');
        this.participants = this.participanteService.getAll();
      });
  }
}
