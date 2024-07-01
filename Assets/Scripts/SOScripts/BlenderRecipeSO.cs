using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

[CreateAssetMenu()]
public class BlenderRecipeSO : ScriptableObject
{
    public List<KitchenObjectSO> input;
    public KitchenObjectSO output;

    //override
    //public string ToString() {return output.ToString();}
}
