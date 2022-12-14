using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] Material _originalMaterial;
    [SerializeField] bool _walkable = false;

    bool _hasUnit = false;



    // Start is called before the first frame update
    void Start()
    {
        _hasUnit = Physics.Raycast(transform.position, Vector3.up, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
