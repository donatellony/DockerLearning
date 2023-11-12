import {Component, Input} from '@angular/core';
import {Column} from "../kb-models/Column";

@Component({
  selector: 'app-kb-column',
  templateUrl: './kb-column.component.html',
  styleUrls: ['./kb-column.component.sass']
})
export class KbColumnComponent {
  @Input() column: Column = {} as Column;
}
