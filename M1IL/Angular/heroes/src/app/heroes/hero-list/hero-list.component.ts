import { Component } from '@angular/core';
import { Hero } from './hero.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms'
import { fobiddenNameValidatior } from '../forbiddenName.directive';
import { HeroService } from './hero.service';

@Component({
  selector: 'app-hero-list',
  templateUrl: './hero-list.component.html',
  styleUrls: ['./hero-list.component.css']
})
export class HeroListComponent {
  x:string = 'Ceci est un test pour la variable !'
  isDisplayed:boolean = false;
  heroArray: Array<Hero> = new Array<Hero>();
  count:number = 0;
  private _title:string = "I love Angular";
  currentDate:Date = new Date();
  profileForm = this.fb.group({
    nom: ['lay', [Validators.required, Validators.minLength(4), fobiddenNameValidatior(/bob/i)]],
    prenom: [''],
    age: [0],
  });
  data : {nom:string|null, prenom:string|null, age:number|null} = {nom: 'lay', prenom:'julien', age:22};
  currentHero: Hero | undefined;
  heroesList: Array<Hero> | undefined;


  ngOnInit(): void {
    setTimeout(() => this.changeDisplay(), 5000)
    this.heroArray.push(new Hero(4, 'Batman', 400));
    this.heroArray.push(new Hero(5, 'Superman', 500));
    this.heroArray.push(new Hero(6, 'Pacman', 600));
    this.profileForm.patchValue(this.data);

    this.heroService.getAllHeroes().subscribe(resHeroList =>  {
      this.heroesList = resHeroList;
      if (this.heroesList.length > 0) {
        this.currentHero = this.heroesList.at(0);
      }
    });

  }

  rotateHeroClicked() {
    this.heroService.rotateAllHeroes().subscribe(hero => {
      this.currentHero = hero;
      })
    }


  changeDisplay() {
    this.isDisplayed = !this.isDisplayed;
  }

  onButtonClicked(event: Event, nbToAdd: number) {
    this.count += nbToAdd;
  }

  get title() {
    return this._title;
  }

  set title(val:string) {
    this._title = val;
  }

  constructor(private fb: FormBuilder, private heroService: HeroService) {}

  changeValues() {
    if (this.profileForm.valid) {
      this.data = {...this.data, ...this.profileForm.value}
    }
    console.log(this.data);

  }
}
