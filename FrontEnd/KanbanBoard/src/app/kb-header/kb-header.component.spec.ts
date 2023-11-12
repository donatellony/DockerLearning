import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KbHeaderComponent } from './kb-header.component';

describe('KbHeaderComponent', () => {
  let component: KbHeaderComponent;
  let fixture: ComponentFixture<KbHeaderComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [KbHeaderComponent]
    });
    fixture = TestBed.createComponent(KbHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
