import { Component, OnInit, Output, EventEmitter  } from '@angular/core';
import { HttpClient, HttpRequest, HttpEventType } from '@angular/common/http'

@Component({
  selector: 'upload-component',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent implements OnInit {
  public progress: number;
  public message: string;
  public responseMessage: string;

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
  }

  public uploadFile = (files) => {
    if (files.length === 0) {
      return;
    }
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    this.http.post('https://localhost:44387/meterreading/meter-reading-uploads', formData, { reportProgress: true, observe: 'events' })
      .subscribe(event => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round(100 * event.loaded / event.total);
        else if (event.type === HttpEventType.Response) {
          this.message = 'Upload success.';
          console.log(event.body);
          this.responseMessage = event.body["successfulCount"] + ' meter readings were successfully uploaded and ' + event.body["failureCount"] + ' failed.' ;
        }
      });
  }
}
