import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Router } from "@angular/router";
import { map } from "rxjs";
import { plainToClass } from 'class-transformer';
import { Projeto } from "../model/projeto";

@Injectable()
export class ProjetoService  {

    constructor(router: Router, private http: HttpClient) {  }

    salvar(projetoViewModel: Projeto): Observable<Projeto> {
        return this.http.post('http://1010/api/v1/Projeto/SalvarProjeto', projetoViewModel)
            .pipe(map(a => plainToClass(Projeto, a)));
    }
}
