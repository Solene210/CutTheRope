using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Cutting : MonoBehaviour
{
    #region Expose

    #endregion

    #region Unity Life Cycle
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider != null)
            {
                if(hit.collider.tag == "Rope")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
    #endregion

    #region methods

    #endregion

    #region Private & Protected

    #endregion
}
