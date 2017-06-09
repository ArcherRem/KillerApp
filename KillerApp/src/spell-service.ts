import { autoinject } from 'aurelia-framework';
import { HttpClient, json } from 'aurelia-fetch-client';
import { Spell } from './resources/spell';

@autoinject
export class SpellService {

    constructor(private http: HttpClient) {
        
    }
    public async getAllSpells() : Promise<Spell[]>
    {
        let response: Response = await this.http.fetch('spell/getAllSpells')
        let data = await response.json();
        return data;
    }
}