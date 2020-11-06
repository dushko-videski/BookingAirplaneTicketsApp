import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'mapUseLoyalMemberCredits'
})
export class MapUseLoyalMemberCreditsPipe implements PipeTransform {

  transform(value: any) {
    switch (value) {
      case true:
        return "YES"
        break;
      case false:
        return "NO"
        break;
    }
  }

}
