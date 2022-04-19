using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlaceObject : MonoBehaviour
{
    [SerializeField] GameObject plantPrefab;
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

                // Get click
        if (Input.GetButtonDown("Fire1"))
        {
            var v3 = Input.mousePosition;
            v3.z = 10.0f;
            v3 = Camera.main.ScreenToWorldPoint(v3);

            RaycastHit2D hit = Physics2D.Raycast(v3, Vector2.zero);

            if(hit.collider != null)
            {
                if(hit.collider.tag == "Ground")
                {
                    v3.x = (float)Math.Round(v3.x * 2) / 2;
                    v3.y = (float)Math.Round(v3.y * 2) / 2;
                    v3.z = (float)Math.Round(v3.z * 2) / 2;
                    Instantiate(plantPrefab, v3, Quaternion.identity);
                }
            }
        }

    }
}
