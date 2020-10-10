import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];

  public products: Product[]; 
  //private productUrl = "https://localhost:44340/api/products";
  private productUrl = "https://azuredevopsangularservicesgalaxy.azurewebsites.net/";

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    //  this.forecasts = result;
    //}, error => console.error(error));

    http.get<Product[]>(this.productUrl).subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}


interface Product {
  ProductId: number;
  Description: string;
  Price: number;
  Created: Date;
  Update: Date;
}
