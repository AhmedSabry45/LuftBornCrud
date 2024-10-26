import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  Url = environment.apiUrl;
  constructor(private http:HttpClient) { }

  signUp(userObj:any){

return this.http.post<any>(this.Url + 'Account/Register', userObj)

  }

  login(UserName:string,  Password:string){
    return this.http.get<any>(this.Url + 'Account/Login?UserName='+UserName+'&Password='+Password)
  }
}
