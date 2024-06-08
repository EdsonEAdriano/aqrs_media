import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';

import { AppMaterialModule } from '../../../app-material/app-material/app-material.module';
import { ParticipantService } from '../../../services/participant/participant.service';

@Component({
  selector: 'app-participant-form',
  standalone: true,
  imports: [AppMaterialModule],
  templateUrl: './participant-form.component.html',
  styleUrl: './participant-form.component.scss'
})
export class ParticipantFormComponent implements OnInit {

  form: FormGroup;

  constructor(private formBuilder: FormBuilder,
    private service: ParticipantService,
    private snackBar: MatSnackBar
  ) {

    this.form = this.formBuilder.group({
      name: [null],
      createdDate: [null]
    });
  }

  ngOnInit(): void {
  }

  onSubmit() {
    console.log(this.form.value);
    this.service.save(this.form.value).
      subscribe(result => console.log(result), error => this.onError());
  }

  onCancel() {
  }

  onError() {
    this.snackBar.open('Erro ao salvar participante', '', {duration: 5000});
  }
}
