import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppComponent} from './app.component';
import {KbColumnComponent} from './kb-column/kb-column.component';
import {KbTableComponent} from './kb-table/kb-table.component';
import {AppRoutingModule} from "./app-routing/app-routing.module";
import {KbMainMenuComponent} from './kb-main-menu/kb-main-menu.component';
import {KbHeaderComponent} from './kb-header/kb-header.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatSlideToggleModule} from "@angular/material/slide-toggle";
import {KbMaterialTableComponent} from './kb-material-table/kb-material-table.component';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatSortModule} from '@angular/material/sort';
import {KbCardComponent} from './kb-cell/kb-card.component';
import {CdkDrag, CdkDropList, CdkDropListGroup} from "@angular/cdk/drag-drop";

@NgModule({
  declarations: [
    AppComponent,
    KbColumnComponent,
    KbTableComponent,
    KbMainMenuComponent,
    KbHeaderComponent,
    KbMaterialTableComponent,
    KbCardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSlideToggleModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    CdkDropListGroup,
    CdkDropList,
    CdkDrag
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
