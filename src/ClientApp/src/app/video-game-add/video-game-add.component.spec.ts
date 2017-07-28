import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VideoGameAddComponent } from './video-game-add.component';

describe('VideoGameAddComponent', () => {
  let component: VideoGameAddComponent;
  let fixture: ComponentFixture<VideoGameAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VideoGameAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VideoGameAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
