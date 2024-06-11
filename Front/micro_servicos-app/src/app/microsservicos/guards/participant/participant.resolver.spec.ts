import { TestBed } from '@angular/core/testing';
import { ResolveFn } from '@angular/router';

import { participantResolver } from './participant.resolver';

describe('participantResolver', () => {
  const executeResolver: ResolveFn<boolean> = (...resolverParameters) => 
      TestBed.runInInjectionContext(() => participantResolver(...resolverParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeResolver).toBeTruthy();
  });
});
