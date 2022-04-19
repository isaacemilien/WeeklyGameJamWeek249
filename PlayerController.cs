using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region FIELDS
    Rigidbody2D rb;
    Vector2 sideVelocity = new Vector2(1f, 0f);
    Vector2 upVelocity = new Vector2(0f, 1f);

    [SerializeField] PlayerData playerData;
    #endregion

    #region MONOBEHAVIOUR METHODS 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Debug.Log(5);
    }
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.MovePosition(rb.position + sideVelocity);
            playerData.playerMoved = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.MovePosition(rb.position + -sideVelocity);
            playerData.playerMoved = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.MovePosition(rb.position + upVelocity);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.MovePosition(rb.position + upVelocity);
        }
    }
    #endregion

    #region METHODS
    #endregion
}
