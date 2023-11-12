import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KbMainMenuComponent } from './kb-main-menu.component';

describe('KbMainMenuComponent', () => {
  let component: KbMainMenuComponent;
  let fixture: ComponentFixture<KbMainMenuComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [KbMainMenuComponent]
    });
    fixture = TestBed.createComponent(KbMainMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
