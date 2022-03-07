import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RecipeModule } from "./modules/recipe/recipe.module";

const routes: Routes = [
  {
    path: 'recipe',
    loadChildren: () => RecipeModule
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
