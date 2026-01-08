import { Pipe, PipeTransform } from "@angular/core";

@Pipe({name : 'caractere'})
export class caracterePipe implements PipeTransform {
    transform(value: string|null) {
        if (value != null && (value.slice(-1) === "0")) {
            return value + ' !';
        } else {
            return value
        }
    }
}