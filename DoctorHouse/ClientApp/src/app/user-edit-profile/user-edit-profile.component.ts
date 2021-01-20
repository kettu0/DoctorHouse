import { Component, OnInit } from '@angular/core';
import { Validators, FormControl, FormGroup, FormBuilder } from '@angular/forms';
import { ToastyService } from 'ng2-toasty';
import { AreaValidators } from '../common/validators/area.validators';
import { PasswordValidators } from '../common/validators/password.validators';
import { PhoneValidators } from '../common/validators/phone.validators';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-user-edit-profile',
  templateUrl: './user-edit-profile.component.html',
  styleUrls: ['./user-edit-profile.component.css']
})
export class UserEditProfileComponent implements OnInit {

  customer;

  updateUser = new FormGroup({
    firstName: new FormControl(),
    lastName: new FormControl(),
    phone: new FormControl(),
    email: new FormControl(),
    address: new FormControl(),
    username: new FormControl(),
    password: new FormControl()
  });


  get firstName() {
    return this.updateUser.get('firstName')
  }

  get username() {
    return this.updateUser.get('username')
  }

  get password() {
    return this.updateUser.get('password')
  }

  get lastName() {
    return this.updateUser.get('lastName')
  }

  get phone() {
    return this.updateUser.get('phone')
  }

  get email() {
    return this.updateUser.get('email')
  }

  get address() {
    return this.updateUser.get('address')
  }

  constructor(
    private customerService: CustomerService,
    private toastyService: ToastyService) {
  }

  ngOnInit(): void {
    this.customerService.getCustomerById(1).subscribe(customer => {
      this.customer = customer
      this.firstName.setValue(this.customer.details.firstName)
      this.lastName.setValue(this.customer.details.lastName)
      this.email.setValue(this.customer.details.eMail)
      this.phone.setValue(this.customer.details.phoneNumber)
      this.address.setValue(this.customer.address)
      this.username.setValue(this.customer.username)
      this.password.setValue(this.customer.password)
    })

  }
}
