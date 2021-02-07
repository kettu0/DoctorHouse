import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticateService } from '../services/authenticate.service';
import { PhotosService } from '../services/photos.service';

@Component({
  selector: 'app-my-photos',
  templateUrl: './my-photos.component.html',
  styleUrls: ['./my-photos.component.css']
})
export class MyPhotosComponent implements OnInit {
  @ViewChild('fileInput') fileInput: ElementRef;
  userId = this.authService.currentUser.id;
  photos;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authService: AuthenticateService,
    private photosService: PhotosService) { }

  ngOnInit(): void {
    this.photosService.getPhotos(this.userId)
      .subscribe(photos => this.photos = photos);
  }

  uploadPhoto() {
    var nativeElement: HTMLInputElement = this.fileInput.nativeElement

    this.photosService.upload(this.userId, nativeElement.files[0])
      .subscribe(photo => {
        this.photos.push(photo);
      });
  }
}