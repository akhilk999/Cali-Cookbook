using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu()]
public class RecipeListSO : ScriptableObject
{
    public List<BlenderRecipeSO> blenderRecipeSOList;
    public List<PanRecipeSO> panRecipeSOList;
}
