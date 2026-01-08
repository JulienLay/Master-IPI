import { from, Observable, of} from "rxjs";
import { delay, concatMap } from "rxjs/operators";
import { Injectable } from "@angular/core";
import { Hero } from './hero.model';

@Injectable()
export class HeroService {
    mockHeroList: Array<Hero> = [
        new Hero(1, 'Batman', 100),
        new Hero(2, 'Pacman', 200),
        new Hero(3, 'Batman', 300),
    ]

    getAllHeroes(): Observable<Array<Hero>> {
        return of(this.mockHeroList).pipe(delay(1000))
    }

    rotateAllHeroes(): Observable<Hero> {
        return from(this.mockHeroList).pipe(
            concatMap(item => of(item).pipe(delay(5000)))
        )
    }
}