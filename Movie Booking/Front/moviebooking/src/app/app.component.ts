import { Component, OnInit } from '@angular/core';
import { Movie } from './Shared/models/movie.model';
import { MovieserviceService } from './Shared/Services/movieservice.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
constructor(private movieservice:MovieserviceService)
{

}
public listMovies : Movie[];
  ngOnInit(): void {
    
    this.movieservice.GetMovieList().subscribe(
     
      res=>{
        debugger;
        this.listMovies =res;
      }
    )
  }
  title = 'moviebooking';

  bookmovie()
{
alert('booked');
}
}


