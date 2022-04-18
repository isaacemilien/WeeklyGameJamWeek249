using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region FIELDS
    Rigidbody2D rb;
    Vector2 velocity = new Vector2(1f, 0f);

    [SerializeField] PlayerData playerData;
    #endregion

    #region MONOBEHAVIOUR METHODS 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.MovePosition(rb.position + velocity);
            playerData.playerMoved = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.MovePosition(rb.position + -velocity);
            playerData.playerMoved = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerData.playerMoved = true;
        }
    }
    #endregion

    #region METHODS
    #endregion
}
