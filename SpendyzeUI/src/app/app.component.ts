import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { filter, Observable } from 'rxjs';
import { LoaderService } from './services/loader.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'SpendyzeUI';
  isSidebarOpen = true;
  isLoginRoute = false;
  isLoading: Observable<boolean>;

  constructor(private router: Router, private loaderService: LoaderService) {
    this.isLoading = this.loaderService.isLoading;
    this.router.events
      .pipe(filter(event => event instanceof NavigationEnd))
      .subscribe((event: NavigationEnd) => {
        this.isLoginRoute = (event as NavigationEnd).urlAfterRedirects === '/login';
      });
  }

  navigateTo(path: string): void {
    this.router.navigate([path]);
  }
  
  logout():void{
    localStorage.clear()
    this.router.navigate(['/login']);
  }
  
}
