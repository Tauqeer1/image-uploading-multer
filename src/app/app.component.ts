import {Component, ElementRef, Input} from '@angular/core';
import {Http, Response} from '@angular/http';
import 'rxjs/add/operator/map';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  constructor(private http: Http, private el: ElementRef) {
  }

  upload() {
    const inputEl: HTMLInputElement = this.el.nativeElement.querySelector('#upload');
    console.log('inputEl', inputEl.files);
    const fileCount: number = inputEl.files.length;
    const formData = new FormData();
    if (fileCount > 0) {
      formData.append('uploadFile', inputEl.files.item(0));
      this.http.post('http://localhost:3000/api/upload', formData)
        .subscribe(res => {
          console.log('res', res);
        })
    }

  }
}
