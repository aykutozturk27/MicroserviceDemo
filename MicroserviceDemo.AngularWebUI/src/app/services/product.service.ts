import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ProductListDto } from '../models/productListDto';
import { ListResponseModel } from '../models/listResponseModel';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private apiUrl = environment.apiUrl;

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<ListResponseModel<ProductListDto>> {
    let newPath = this.apiUrl + "products";
    return this.httpClient.get<ListResponseModel<ProductListDto>>(newPath);
  }
}
