import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

export interface Purchase {
  id: number;
  item: string;
  amount: number;
}

interface ApiResponse {
  data: Purchase[];
  message: string;
}

@Injectable({
  providedIn: 'root'
})
export class PurchaseHistoryService {

  constructor(private http: HttpClient) { }

  getPurchaseHistory(): Observable<ApiResponse> {
    return this.http.get<ApiResponse>(`${environment.apiUrl}/purchasehistory`);
  }
}
