import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeroListComponent } from './hero-list/hero-list.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { caracterePipe } from './caractere.pipe';
import { HeroService } from './hero-list/hero.service';
import { HighlightDirective } from './hilight.directive';

@NgModule({
  declarations: [
    HeroListComponent,
    caracterePipe,
    HighlightDirective
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    HeroListComponent
  ],
  providers: [
    HeroService
  ]
})
export class HeroesModule { }
