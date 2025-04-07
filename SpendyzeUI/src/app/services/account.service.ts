import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Account } from '../Models/Account';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private baseUrl = "http://spendyze.runasp.net"
  constructor(private http:HttpClient) { }

  getAll(): Observable<Account[]> {
      return this.http.get<Account[]>(this.baseUrl +"/api/TransactionAccount/GetAllAccounts");
  }
}
