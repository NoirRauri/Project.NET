import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { TipoLicencia } from "../Models/TipoLicencia";
import { Observable, catchError, throwError } from "rxjs";
import { environments } from "src/environments/environmets";

@Injectable({
    providedIn: 'root'
})
export class TipoLicenciaService {
    constructor(private http: HttpClient) { }

    getALL(): Observable<TipoLicencia[]> {
        return this.http.get<TipoLicencia[]>(`${environments.API_URL}/tipolicencia`).pipe(catchError(this.handlerError));
    }

    handlerError(error: any): Observable<never> {
        // console.log(error)
        let errorMensaje = 'Error Desconocido'
        return throwError(errorMensaje)
    }
}