import { Component, OnInit } from '@angular/core';
import { AccountService } from '../services/account.service';
import { Account } from '../Models/Account';

@Component({
  selector: 'app-account',
  standalone: false,
  templateUrl: './account.component.html',
  styleUrl: './account.component.css'
})
export class AccountComponent implements OnInit{
  accounts:Account[] = []
  displayedColumns: string[] = ['id', 'accountName', 'balance', 'isActive'];

  constructor(private accountService:AccountService){
  }

  ngOnInit(): void {
    this.accountService.getAll().subscribe({
      next:(result:Account[])=>{
        this.accounts = result as Account[];
      },error:(error)=>{
        throw error;
      }
    })
  }
}
