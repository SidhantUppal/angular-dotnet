import { Routes } from '@angular/router';
import { DetailComponent } from './components/detail/detail.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { PurchaseHistoryComponent } from './components/purchase-history/purchase-history.component';

export const routes: Routes = [{ path: '', component: HomePageComponent },
{ path: 'details/:id', component: DetailComponent },
{path:'purchase',component:PurchaseHistoryComponent}];
