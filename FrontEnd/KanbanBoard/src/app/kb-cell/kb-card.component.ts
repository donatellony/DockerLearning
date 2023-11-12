import {Component, Input} from '@angular/core';
import {Card} from "../kb-models/Card";

@Component({
  selector: 'kb-card',
  templateUrl: './kb-card.component.html',
  styleUrls: ['./kb-card.component.sass']
})

export class KbCardComponent {
  @Input() card!: Card

}
