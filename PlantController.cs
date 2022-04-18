using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    #region FIELDS
    Vector2 velocity = new Vector2(1f, 0f);

    [SerializeField] PlayerData playerData;
    #endregion

    #region MONOBEHAVIOUR METHODS 
    void Start()
    {
    }

    void Update()
    {
        if (playerData.playerMoved)
        {
            playerData.playerMoved = false;
            gameObject.transform.localScale += new Vector3(0, 1, 0);
        }
    }
    #endregion

    #region METHODS
    #endregion
}
