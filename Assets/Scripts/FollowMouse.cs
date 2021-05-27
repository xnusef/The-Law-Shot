using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    public GameObject sight;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        sight.transform.position = Input.mousePosition;
    }
}
