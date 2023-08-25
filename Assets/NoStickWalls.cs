using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoStickWalls : MonoBehaviour
{
    PhysicsMaterial2D myMaterial;
    EnemyAI enemyMovement;
    CircleCollider2D myPoly;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = new PhysicsMaterial2D();
        enemyMovement = GetComponent<EnemyAI>();
        myPoly = GetComponent<CircleCollider2D>();
        myPoly.sharedMaterial = myMaterial;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (enemyMovement.isGrounded)
        {
            myMaterial.friction = 0.4f;
            myPoly.enabled = false;
            myPoly.enabled = true; 

        }
        else if (enemyMovement.isInAir)
        {
            myMaterial.friction = 0.0f;
            myPoly.enabled = false;
            myPoly.enabled = true;
        }
    }
}
