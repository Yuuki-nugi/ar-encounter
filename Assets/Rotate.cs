using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        this.transform.localRotation *= Quaternion.AngleAxis(360 * Time.deltaTime, Vector3.up);
    }
}
