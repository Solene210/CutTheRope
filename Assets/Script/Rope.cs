using UnityEngine;

public class Rope : MonoBehaviour
{
    #region Expose
    [SerializeField] private Rigidbody2D _hook;
    [SerializeField] private GameObject _linkPrefab;
    [SerializeField] private int _links = 7;
    [SerializeField] private Weight _weight;
    #endregion

    #region Unity Life Cycle
    void Start()
    {
        GenerateRope();
    }
    #endregion

    #region methods
    private void GenerateRope()
    {
        Rigidbody2D previousRB = _hook;
        for (int i = 0; i < _links; i++)
        {
            GameObject link = Instantiate(_linkPrefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;
            if (i < _links - 1)
            {
                previousRB = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                _weight.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
        }
    }
    #endregion
}
