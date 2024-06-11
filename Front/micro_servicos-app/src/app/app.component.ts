import { Component } from '@angular/core';
import { ActivatedRoute, Router, RouterOutlet } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MatToolbarModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'micro_servicos-app';
  constructor(
    private router: Router,
    private route: ActivatedRoute
  ) {

  }

  getParticipant() {
    // this.router.navigate(['Participant'], {relativeTo: this.route})
    this.router.navigate(['app/Participant'])
  }
}
