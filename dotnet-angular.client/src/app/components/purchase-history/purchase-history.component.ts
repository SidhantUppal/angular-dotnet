import { Component } from '@angular/core';
import { Purchase, PurchaseHistoryService } from '../../services/purchase-history.service';

@Component({
  selector: 'app-purchase-history',
  templateUrl: './purchase-history.component.html',
  styleUrl: './purchase-history.component.css'
})
export class PurchaseHistoryComponent {
  purchases: Purchase[] = [];

  constructor(private purchaseService: PurchaseHistoryService) {
  }
  
  ngOnInit()
  {
   this.refresh();
  }

  refresh(): void {
    this.purchaseService.getPurchaseHistory().subscribe(res => {
	if(res && res.data.length)
	{
	  this.purchases = res.data;
	}
    });
  }
}
