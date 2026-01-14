import { TestBed } from '@angular/core/testing';

import { InvationsService } from './invations.service';

describe('InvationsService', () => {
  let service: InvationsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InvationsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
