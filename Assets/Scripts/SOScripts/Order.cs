using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Order
{
    private List<BlenderRecipeSO> blenderRecipes;
    private List<PanRecipeSO> panRecipes;
    private Boolean isEmpty;

    public Order(List<BlenderRecipeSO> blenderRecipes, List<PanRecipeSO> panRecipes) {
        this.blenderRecipes = blenderRecipes;
        this.panRecipes = panRecipes;
        isEmpty = CheckEmpty();
    }

    private Boolean CheckEmpty() {
        if(!blenderRecipes.Any() && !panRecipes.Any())
           return true;
        return false;
    }

    public Boolean IsEmpty() {
        return isEmpty;
    }

    override
    public string ToString() {
        string output = "";
        if (blenderRecipes.Any())
            output += blenderRecipes[0];
        if (blenderRecipes.Any() && panRecipes.Any())
            output += ", ";
        if (panRecipes.Any())
            output += panRecipes[0];
        return output;
    }
}
