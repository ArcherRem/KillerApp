import { autoinject } from 'aurelia-framework';
import { Spell } from './resources/spell';
import { SpellService} from './spell-service';

@autoinject
export class App {
    spells: Spell[];

    constructor(private spellService: SpellService)
    {

    }
    async Attached()
    {
        this.spells = await this.spellService.getAllSpells();
    }

}
