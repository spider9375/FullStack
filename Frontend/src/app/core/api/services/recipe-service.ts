import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { IRecipeDto } from "../models/IRecipeDto";
import { environment } from "../../../../environments/environment";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class RecipeService {
  constructor(private http: HttpClient) {
  }

  public getRecipes(): Observable<IRecipeDto[]> {
    const headers: HttpHeaders = new HttpHeaders();
    return this.http.get<IRecipeDto[]>(environment.backendUrl + 'recipe');
  }
}
