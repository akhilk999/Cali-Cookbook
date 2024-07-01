using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    [SerializeField] private RecipeListSO recipeListSO;
    private Boolean orderCompleted;
    private Order currentOrder;

    private void Start() {
        orderCompleted = false;
        currentOrder = createOrder();
    }

    private void Update() {
        if (orderCompleted) {
            orderCompleted = false;
            currentOrder = createOrder();
        }
    }

    private Order createOrder() {
        List<PanRecipeSO> panRecipes = randomPanRecipes();
        List<BlenderRecipeSO> blenderRecipes = randomBlenderRecipes();
        Order order = new Order(blenderRecipes, panRecipes);
        Debug.Log(order);
        while(order.IsEmpty()) {
            panRecipes = randomPanRecipes();
            blenderRecipes = randomBlenderRecipes();
            order = new Order(blenderRecipes, panRecipes);
        }
        return order;
    }

    private List<PanRecipeSO> randomPanRecipes() {
        System.Random random = new System.Random();
        int numItem = random.Next(3);
        if(numItem == 0) {
            return new List<PanRecipeSO>();
        }
        int itemIndex = random.Next(recipeListSO.panRecipeSOList.Count);
        return new List<PanRecipeSO>() { recipeListSO.panRecipeSOList[itemIndex]};
    }
    private List<BlenderRecipeSO> randomBlenderRecipes() {
        System.Random random = new System.Random(); ;
        int numItem = random.Next(3);
        if (numItem == 0) {
            return new List<BlenderRecipeSO>();
        }
        int itemIndex = random.Next(recipeListSO.panRecipeSOList.Count);
        return new List<BlenderRecipeSO>() { recipeListSO.blenderRecipeSOList[itemIndex]};
    }

    public Order getCurrentOrder() { return currentOrder; }
}
