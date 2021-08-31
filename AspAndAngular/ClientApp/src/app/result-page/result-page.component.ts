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
  public procentageAsString: string;
  public procentageAsNumber: number;

  constructor(private route: ActivatedRoute) {
    this.route.queryParams.subscribe(params => {
      this.totalAmount = params["totalAmount"];
      this.amountcorrect = params["amountCorrect"];
    });
  }

  Redirect() {
    window.location.href = "https://docs.microsoft.com/en-us/learn/paths/az-900-describe-cloud-concepts/";
  }

  ngOnInit() {
    this.procentageAsNumber = Number.parseFloat((this.amountcorrect / this.totalAmount * 100).toFixed(2));
    this.procentageAsString = `${this.procentageAsNumber}` + "%";
    console.log(this.amountcorrect, "/", this.totalAmount)
    console.log(this.procentageAsString);
  }
}
