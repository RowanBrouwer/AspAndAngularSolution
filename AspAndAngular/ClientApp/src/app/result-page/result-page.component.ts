import { Component } from '@angular/core';
import { ActivatedRoute } from "@angular/router";

@Component({
    selector: 'app-result-page',
    templateUrl: './result-page.component.html',
    styleUrls: ['./result-page.component.css']
})
/** result-page component*/
export class ResultPageComponent {
  public totalAmount: number;
  public amountcorrect: number;
  public procentage: string;

  constructor(private route: ActivatedRoute) {
    this.route.queryParams.subscribe(params => {
      this.totalAmount = params["totalAmount"];
      this.amountcorrect = params["amountCorrect"];
    });
  }

  ngOnInit() {
    this.procentage = `${Number.parseFloat((this.amountcorrect / this.totalAmount * 100).toFixed(2))}` + '%';
    console.log(this.amountcorrect, "/", this.totalAmount)
    console.log(this.procentage);
  }
}
