using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SpawnCube : MonoBehaviour
{
    [SerializeField]
    GameObject cube;

    public void OnButtonDown(Hand hand)
    {
        if(!Physics.CheckBox(transform.position, cube.transform.localScale / 2))
        {
            GameObject cube_clone = Instantiate(cube);
            cube_clone.transform.position = transform.position;

        }
        
    }
}
