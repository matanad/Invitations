import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { InvitationsComponent } from "./invitations/invitations.component";

@Component({
  selector: 'app-root',
  imports: [InvitationsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'invitations';

  
}
