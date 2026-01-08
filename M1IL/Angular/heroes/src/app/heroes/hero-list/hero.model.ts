export class Hero {
    id:number;
    nom: string;
    score: number|null;

    constructor(id:number, nom:string, score:number) {
        this.id = id;
        this.nom = nom;
        this.score = score;
    }
}