import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Movie} from 'src/app/Shared/models/movie.model';
@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {
  private url = 'http://localhost:5000/api/movies';

  constructor(private http: HttpClient) { }

  public GetMovieList(): Observable<Movie[]>{
    return this.http.get<Movie[]>(this.url);
  }

}
