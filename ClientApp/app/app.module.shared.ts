import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { 
    MatButtonModule, MatButton, MatFormFieldModule, 
    MatAutocompleteModule, MatButtonToggleModule, MatCardModule, 
    MatCheckboxModule, MatChipsModule, MatTableModule, 
    MatDatepickerModule, MatDialogModule, MatExpansionModule,
    MatGridListModule, MatIconModule, MatInputModule,
    MatListModule, MatMenuModule, MatPaginatorModule,
    MatProgressBarModule, MatRadioModule, MatProgressSpinnerModule,
    MatSelectModule, MatRippleModule, MatSlideToggleModule,
    MatSidenavModule, MatSliderModule, MatSnackBarModule,
    MatSortModule, MatStepperModule, MatTabsModule,
    MatToolbarModule, MatTooltipModule, MatNativeDateModule
    } from '@angular/material';

import { AuthGuard } from './_guards/auth.guard';
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { TenderCreateComponent } from './components/tender_create/tendercreate.component';
import { OrdersComponent } from './components/orders/orders.component';
import { OrdersFormComponent} from './components/orders/form.orders.component';
import { LoginComponent } from './components/login/login.component'; 
import { RegisterComponent } from './components/register/register.component'; 
import { AlertComponent } from './components/alert/alert.component';
import { ToolbarComponent } from './components/toolbar/toolbar.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        TenderCreateComponent,
        OrdersComponent,
        OrdersFormComponent,
        LoginComponent,
        RegisterComponent,
        AlertComponent,
        ToolbarComponent
    ],
    imports: [
        MatAutocompleteModule,
        MatButtonModule,
        MatButtonToggleModule,
        MatCardModule,
        MatCheckboxModule,
        MatChipsModule,
        MatTableModule,
        MatDatepickerModule,
        MatDialogModule,
        MatExpansionModule,
        MatFormFieldModule,
        MatGridListModule,
        MatIconModule,
        MatInputModule,
        MatListModule,
        MatMenuModule,
        MatPaginatorModule,
        MatProgressBarModule,
        MatProgressSpinnerModule,
        MatRadioModule,
        MatRippleModule,
        MatSelectModule,
        MatSidenavModule,
        MatSlideToggleModule,
        MatSliderModule,
        MatSnackBarModule,
        MatSortModule,
        MatStepperModule,
        MatTabsModule,
        MatToolbarModule,
        MatTooltipModule,
        MatNativeDateModule,
        CommonModule,
        HttpClientModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent,canActivate: [AuthGuard] },            
            { path: 'orders', component: OrdersComponent },            
            { path: 'tender-create', component: TenderCreateComponent },
            { path: 'login', component: LoginComponent },
            { path: 'register', component: RegisterComponent },

            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
