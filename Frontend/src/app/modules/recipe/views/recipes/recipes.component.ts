import { Component, OnInit } from "@angular/core";
import { RecipeService } from "../../../../core/api/services/recipe-service";
import { IRecipeDto } from "../../../../core/api/models/IRecipeDto";
import { take } from "rxjs/operators";

@Component({
  selector: "app-recipes",
  templateUrl: "./recipes.component.html",
  styleUrls: ["./recipes.component.scss"]
})
export class RecipesComponent implements OnInit {
  public recipes: IRecipeDto[] = [];

  constructor(private recipeService: RecipeService) {
  }

  ngOnInit(): void {
    this.init();
  }

  public init(): void {
    this.recipeService.getRecipes().pipe(take(1)).subscribe((recipes: IRecipeDto[]) => this.recipes = recipes);
  }
}
