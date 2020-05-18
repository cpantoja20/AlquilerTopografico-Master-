import { Component, OnInit } from '@angular/core';
import { Cliente } from '../../models/cliente';
import { ClienteService } from 'src/app/services/cliente.service';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-cliente-registro',
  templateUrl: './cliente-registro.component.html',
  styleUrls: ['./cliente-registro.component.css']
})
export class ClienteRegistroComponent implements OnInit {

  formGroup: FormGroup;
  cliente: Cliente;

  constructor(private clienteService: ClienteService, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.buildForm();
  }

  private buildForm() {
    this.formGroup = this.formBuilder.group({});
  }

  add() {
    this.clienteService.post(this.cliente).subscribe(c => {
      if (c != null) {
        alert('Cliente creado!');
        this.cliente = c;
      }
    });

  }

}
