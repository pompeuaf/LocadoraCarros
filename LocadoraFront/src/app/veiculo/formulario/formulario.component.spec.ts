/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormVeiculoComponent } from './formulario.component';

describe('FormularioComponent', () => {
  let component: FormVeiculoComponent;
  let fixture: ComponentFixture<FormVeiculoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormVeiculoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormVeiculoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
