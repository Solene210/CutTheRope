using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    #region Expose
    [SerializeField] private float _distancefromchainend = 0.6f;
    #endregion

    #region methods
    public void ConnectRopeEnd(Rigidbody2D endRB)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = endRB;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0, -_distancefromchainend);
    }
    #endregion
}
