import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router'
import { recipeRoutes } from "./recipe-routing";
import { RecipesComponent } from './views/recipes/recipes.component'

@NgModule({
  declarations: [
    RecipesComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(recipeRoutes)
  ]
})
export class RecipeModule { }
