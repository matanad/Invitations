import { HttpClient } from '@angular/common/http';
import { Injectable, signal } from '@angular/core';
import { take } from 'rxjs';
import { Invitation } from '.';

@Injectable({
  providedIn: 'root',
})
export class InvationsService {
  private API = 'https://localhost:7048/api/invitations';
  invitations = signal<Invitation[]>([]);
  constructor(private http: HttpClient) {}

  async getExceptionalInvitations() {
    this.http
      .get<Invitation[]>(this.API + '/exceptional')
      .pipe(take(1))
      .subscribe({
        next: (i) => {
          this.invitations.set(i);
        },
      });
  }
  async approve(id: number) {
    this.http
      .post(this.API + `/${id}/approve`, id)
      .pipe(take(1))
      .subscribe({ next: () => this.getExceptionalInvitations() });
  }
  async reject(id: number) {
    this.http
      .post(this.API + `/${id}/reject`, id)
      .pipe(take(1))
      .subscribe({ next: () => this.getExceptionalInvitations() });
  }
}
