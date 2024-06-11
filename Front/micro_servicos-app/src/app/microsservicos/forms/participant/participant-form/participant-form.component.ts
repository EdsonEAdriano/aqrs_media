import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NonNullableFormBuilder } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute } from '@angular/router';

import { AppMaterialModule } from '../../../app-material/app-material/app-material.module';
import { ParticipantService } from '../../../services/participant/participant.service';
import { Participant } from '../../../model/participant';

@Component({
  selector: 'app-participant-form',
  standalone: true,
  imports: [AppMaterialModule],
  templateUrl: './participant-form.component.html',
  styleUrl: './participant-form.component.scss'
})
export class ParticipantFormComponent implements OnInit {

  // form: FormGroup;
  form = this.formBuilder.group({
    id: [''],
    name: ['']
    // createdDate: [new Date('2020-01-01')]
  });

  constructor(private formBuilder: NonNullableFormBuilder,
    private service: ParticipantService,
    private snackBar: MatSnackBar,
    private location: Location,
    private route: ActivatedRoute
  ) {

    // this.form = this.formBuilder.group({
    //   name: [null],
    //   createdDate: [null]
    // });
  }

  ngOnInit(): void {
    const participant: Participant = this.route.snapshot.data['participant'];
    this.form.setValue({id: participant.id, name: participant.name});
  }

  onSubmit() {
    console.log(this.form.value);
    this.service.save(this.form.value).
      subscribe(result => this.onSuccess(), error => this.onError());
  }

  onCancel() {
    this.location.back();
  }

  onSuccess() {
    this.snackBar.open('Participante salvo com sucesso!', '', {duration: 5000});
    this.onCancel();
  }

  onError() {
    this.snackBar.open('Erro ao salvar participante.', '', {duration: 5000});
  }
}
