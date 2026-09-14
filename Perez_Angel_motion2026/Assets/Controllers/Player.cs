using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    void Update()
    {
        //call bomb when b key is pressed
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            Vector2 offset = new Vector2(0, 1);

            spawnBombAtOffset(offset);
        }

        //warp player to enemy when w key is pressed
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {

        }

    }

    void spawnBombAtOffset(Vector2 inOffSet)
    {
        //instantiate bomb preset
        
    }

    void WarpJump(Vector2 enemylocation, float distance)
    {

        Vector2 direction = enemylocation.normalized;



    }

}
