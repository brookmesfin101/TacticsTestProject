using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Camera _mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit, 100f, LayerMask.NameToLayer(Layers.TILE)))
            {
                var tile = hit.collider.GetComponent<Tile>();
                if(tile != null)
                {
                    tile.GetComponent<MeshRenderer>().material.color = Color.magenta;
                }
            }

            if (Physics.Raycast(ray, out RaycastHit hit2))
            {
                Debug.Log(hit2);
            }
        }
    }


}
