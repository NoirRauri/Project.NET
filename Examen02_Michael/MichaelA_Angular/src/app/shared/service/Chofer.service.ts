import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, catchError, throwError } from "rxjs";
import { environments } from "src/environments/environmets";
import { Chofer } from "../Models/Chofer";

@Injectable({
    providedIn: 'root'
})
export class ChoferService {
    constructor(private http: HttpClient) { }

    getALL(): Observable<Chofer[]> {
        return this.http.get<Chofer[]>(`${environments.API_URL}/chofers`).pipe(catchError(this.handlerError));
    }

    guardar(Chofer: Chofer): Observable<Chofer> {
        return this.http.post<Chofer>(`${environments.API_URL}/chofers`, Chofer).pipe(catchError(this.handlerError));
    }

    handlerError(error: any): Observable<never> {
        // console.log(error)
        let errorMensaje = 'Error Desconocido'
        return throwError(errorMensaje)
    }
}