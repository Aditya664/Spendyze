import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IncomeComponent } from './income/income.component';
import { AppComponent } from './app.component';
import { ExpenseComponent } from './expense/expense.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SettingsComponent } from './settings/settings.component';
import { ReportsComponent } from './reports/reports.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './gaurd/AppGuard';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },

  {
    path: '',
    canActivate: [AuthGuard], 
    children: [
      { path: 'dashboard', component: DashboardComponent },
      { path: 'income', component: IncomeComponent },
      { path: 'expenses', component: ExpenseComponent },
      { path: 'settings', component: SettingsComponent },
      { path: 'reports', component: ReportsComponent }
    ]
  },

  { path: '**', redirectTo: 'login' }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
