import { Component, OnInit } from '@angular/core';
import { ProductListDto } from 'src/app/models/productListDto';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  products: ProductListDto[] = [];
  dataLoaded = false;
  constructor(
    private productService: ProductService
  ) { }

  ngOnInit() {
    this.getProducts();
  }

  getProducts(){
    this.productService.getAll().subscribe((response) => {
      this.products = response.data;
      this.dataLoaded = true;
    })
  }
}
