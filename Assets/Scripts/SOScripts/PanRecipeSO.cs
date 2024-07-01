using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class PanRecipeSO : ScriptableObject
{
    public List<KitchenObjectSO> input;
    public KitchenObjectSO output;

    //override
    //public string ToString() {return output.ToString();}
}
