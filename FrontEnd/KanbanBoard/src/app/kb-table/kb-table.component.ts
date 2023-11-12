import {Component} from '@angular/core';
import {Column} from "../kb-models/Column";
import {Card} from "../kb-models/Card";
import {CdkDragDrop, moveItemInArray, transferArrayItem} from "@angular/cdk/drag-drop";

@Component({
  selector: 'app-kb-table',
  templateUrl: './kb-table.component.html',
  styleUrls: ['./kb-table.component.sass']
})
export class KbTableComponent {
  private exampleCard: Card =
    {
      title: 'Do the kanban board website',
      description: 'To remind myself of Angular and to learn Docker 1',
      url: undefined
    }

  public cards: Card[] = [
    this.deepClone(this.exampleCard),
    this.deepClone(this.exampleCard),
    this.deepClone(this.exampleCard)
  ]

  public columns: Column[] = [
    {title: 'TODO', cards: this.deepClone(this.cards)},
    {title: 'In progress', cards: this.deepClone(this.cards)},
    {title: 'Done', cards: this.deepClone(this.cards)}
  ]

  drop(event: CdkDragDrop<Column>) {
    console.log(event.previousIndex)
    console.log(event.currentIndex)

    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data.cards, event.previousIndex, event.currentIndex);
    } else {
      transferArrayItem(
        event.previousContainer.data.cards,
        event.container.data.cards,
        event.previousIndex,
        event.currentIndex
      );
    }
  }

  private deepClone(array: any): any {
    return JSON.parse(JSON.stringify(array));
  }

}
