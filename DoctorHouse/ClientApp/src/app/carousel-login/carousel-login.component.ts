import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validators} from '@angular/forms';

@Component({
  selector: 'app-carousel-login',
  templateUrl: './carousel-login.component.html',
  styleUrls: ['./carousel-login.component.css']
})
export class CarouselLoginComponent implements OnInit {
  form = new FormGroup({
    username: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
  });

  constructor() { }

  get username() {
    return this.form.get('username');
  }

  get password() {
    return this.form.get('password');
  }

  ngOnInit(): void {
  }

}
