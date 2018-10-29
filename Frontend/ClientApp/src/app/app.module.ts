import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http'
import { RightBarComponent } from './components/right-bar/right-bar.component';
import { LeftBarComponent } from './components/left-bar/left-bar.component';

@NgModule({
  declarations: [
    RightBarComponent,
    LeftBarComponent
  ],
  imports: [
    BrowserModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [LeftBarComponent,RightBarComponent]
})
export class AppModule { }
