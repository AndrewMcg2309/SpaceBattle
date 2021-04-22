using UnityEngine;

// Transform.Rotate example
//
// This script creates two different cubes: one red which is rotated using Space.Self; one green which is rotated using Space.World.
// Add it onto any GameObject in a scene and hit play to see it run. The rotation is controlled using xAngle, yAngle and zAngle, modifiable on the inspector.

public class Rotate : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    private GameObject cube1, cube2;

    void Update()
    {
        this.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        this.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }
}