import { Component, inject, OnInit } from '@angular/core';
import { InvationsService } from '../invations.service';
import { Invitation } from '..';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-invitations',
  imports: [CommonModule],
  templateUrl: './invitations.component.html',
  styleUrl: './invitations.component.scss',
})
export class InvitationsComponent implements OnInit {
  private invationsService = inject(InvationsService);
  exceptionalInvitations = this.invationsService.invitations;

  ngOnInit(): void {
    this.invationsService.getExceptionalInvitations();
  }

  approve(id: number) {
    this.invationsService.approve(id);
  }
  reject(id: number) {
    this.invationsService.approve(id);
  }
}
