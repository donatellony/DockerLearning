import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KbColumnComponent } from './kb-column.component';

describe('KbColumnComponent', () => {
  let component: KbColumnComponent;
  let fixture: ComponentFixture<KbColumnComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [KbColumnComponent]
    });
    fixture = TestBed.createComponent(KbColumnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
