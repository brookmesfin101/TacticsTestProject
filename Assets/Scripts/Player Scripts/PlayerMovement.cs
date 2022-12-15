using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Camera _mainCamera;
    private IList<Tile> moveableTiles = new List<Tile>();
    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayerUnit();
    }

    private void MovePlayerUnit()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100f, ~LayerMask.NameToLayer(Layers.TILE)))
            {
                var tile = hit.collider.GetComponent<Tile>();
                if (tile != null)
                {
                    tile.GetComponent<MeshRenderer>().material.color = Color.magenta;


                    Physics.Raycast(tile.transform.position, Vector3.back, 2f, ~LayerMask.NameToLayer(Layers.TILE));
                    Physics.Raycast(tile.transform.position, Vector3.forward, 2f, ~LayerMask.NameToLayer(Layers.TILE));
                    Physics.Raycast(tile.transform.position, Vector3.left, 2f, ~LayerMask.NameToLayer(Layers.TILE));
                    Physics.Raycast(tile.transform.position, Vector3.right, 2f, ~LayerMask.NameToLayer(Layers.TILE));
                }
            }
        }
    }
}
