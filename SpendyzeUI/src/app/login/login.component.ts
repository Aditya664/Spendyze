import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {
  formGroup!: FormGroup;

  constructor(private fb: FormBuilder, private router: Router,private authSerice:AuthService) {}

  ngOnInit(): void {
    this.formGroup = this.fb.group({
      userName: [null, Validators.required],
      password: [null, [Validators.required]]
    });
  }

  login(): void {
    if (this.formGroup.valid) {
      this.authSerice.login({username:this.formGroup.get("userName")?.value,password:this.formGroup.get("password")?.value}).subscribe({
        next:(res)=>{
          localStorage.setItem("token",res.jwtToken)
          this.router.navigate(['/dashboard']);
        },error:(error:Error)=>{
          throw error;
        }
      })
    } else {
      this.formGroup.markAllAsTouched();
    }
  }
}
