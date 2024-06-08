import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AppMaterialModule } from '../../../app-material/app-material/app-material.module';

@Component({
  selector: 'app-participant-form',
  standalone: true,
  imports: [AppMaterialModule],
  templateUrl: './participant-form.component.html',
  styleUrl: './participant-form.component.scss'
})
export class ParticipantFormComponent implements OnInit {

  form: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.form = this.formBuilder.group({
      name: [null],
      createdDate: [null]
    });
  }

  ngOnInit(): void {
  }

  onSubmit() {

  }

  onCancel() {

  }

}
