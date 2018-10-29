import { Component, OnInit } from '@angular/core';
import{ConfigurationService} from '../configuration.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  identityServerConfig: string;
  apiServerCofnig: string;
  otherAppSettingConfig: string;

  constructor(private configurationService: ConfigurationService){

  }

  ngOnInit(): void {
    this.identityServerConfig = this.configurationService.identityServerAddress;
    this.apiServerCofnig = this.configurationService.apiAddress;
    this.otherAppSettingConfig = this.configurationService.anotherAppSettingValue;
  }
}
