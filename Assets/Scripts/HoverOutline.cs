using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HoverOutline : MonoBehaviour
{
    private Renderer _meshRenderer;
    [SerializeField] private Material _outlineMaterial;
    [SerializeField] private Color _selectColor;
    [SerializeField] private Color _deselectColor;
    [SerializeField] private Color _clickColor;
    protected Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<Renderer>();
        materials = new Material[_meshRenderer.materials.Length + 1];
        for (int i = 0; i < _meshRenderer.materials.Length; i++) {
            materials[i] = _meshRenderer.materials[i];
        }
        _outlineMaterial.SetColor("_Outline_Color", _deselectColor);
        materials[materials.Length - 1] = new Material(_outlineMaterial);
        _meshRenderer.materials = materials;
    }

    // Update is called - read bruh
    void OnMouseOver()
    {
        Material outline = materials[materials.Length - 1];
        outline.SetColor("_Outline_Color", _selectColor);

        if (Input.GetMouseButton(0))
        {
            outline.SetColor("_Outline_Color", _clickColor);
        }
        _meshRenderer.materials = materials;
    }

    void OnMouseExit()
    {
        Material outline = materials[materials.Length - 1];
        outline.SetColor("_Outline_Color", _deselectColor);
        _meshRenderer.materials = materials;

    }
}
