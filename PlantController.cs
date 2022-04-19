using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    #region FIELDS
    #endregion

    #region MONOBEHAVIOUR METHODS 
    void Start()
    {
    }

    void OnEnable()
    {
        EventManager.OnMoved += Grow;
    }

    void OnDisable()
    {
        EventManager.OnMoved -= Grow;
    }
    #endregion

    #region METHODS
    void Grow()
    {
        gameObject.transform.localScale += new Vector3(0, 1, 0);
    }
    #endregion
}
