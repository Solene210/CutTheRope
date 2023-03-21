using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsPickUp : MonoBehaviour
{
    #region Expose
    
    #endregion

    #region Unity Life Cycle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            Destroy(gameObject);
        }
    }
    #endregion

    #region methods

    #endregion

    #region Private & Protected

    #endregion
}
