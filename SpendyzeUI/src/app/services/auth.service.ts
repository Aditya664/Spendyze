import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginRequest, LoginResponse } from '../Models/AuthModel';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private baseUrl = "https://localhost:7189"
  constructor(private http:HttpClient) { }

  login(credentials: LoginRequest): Observable<LoginResponse> {
    return this.http.post<LoginResponse>(this.baseUrl +"/api/Account/Login", credentials);
  }
}
