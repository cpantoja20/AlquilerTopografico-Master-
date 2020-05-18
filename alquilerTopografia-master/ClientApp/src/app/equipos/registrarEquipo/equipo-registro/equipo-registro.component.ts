import { Component, OnInit } from '@angular/core';
import { Equipo } from '../../models/equipo';
import { EquipoService } from 'src/app/services/equipo/equipo.service';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-equipo-registro',
  templateUrl: './equipo-registro.component.html',
  styleUrls: ['./equipo-registro.component.css']
})
export class EquipoRegistroComponent implements OnInit {

  formGroup: FormGroup;
  equipo: Equipo;

  constructor(private equipoService: EquipoService, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.buildForm();
  }

  private buildForm() {
    this.formGroup = this.formBuilder.group({});
  }

  add() {
    this.equipoService.post(this.equipo).subscribe(p => {
      if (p != null) {
        alert('Equipo creado!');
        this.equipo = p;
      }
    });

  }

}